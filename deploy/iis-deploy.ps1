<#
.SYNOPSIS
  Installs one published build of the Foodirect web app on the IIS VM. The CI/CD pipeline runs it on the
  self-hosted runner; you can also run it by hand from an elevated PowerShell.

.DESCRIPTION
  1. Copies the package into a new folder  <Root>\releases\<yyyyMMdd-HHmmss>-<sha>.
  2. Copies the server's private config (<Root>\shared\config\Web.secrets.config and connectionStrings.config)
     into that folder. "{RELEASE}" inside those files is replaced with the release folder path.
  3. Points the private staging site (<SiteName>-staging, http://127.0.0.1:<StagingPort>) at the new folder and
     waits for /health to return 200. On failure, stops here: production is untouched.
  4. Switches the live site's physical path to the new folder (IIS restarts the app; it takes a few seconds),
     recycles the app pool, then checks the live /health. On failure, switches back to the previous folder.
  5. Keeps the newest <Keep> releases (never the live or previous one) and deletes older ones.

  Created once by deploy/vm-setup.ps1: the folders, the staging site, the AdUpload virtual directory and the
  shared config files.

.EXAMPLE
  .\iis-deploy.ps1 -PackagePath C:\temp\site -SiteName Foodirect -CommitSha abc1234
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)] [string] $PackagePath,
    [Parameter(Mandatory)] [string] $SiteName,
    [string] $Root = '',                 # default C:\Foodirect\<SiteName> (same as vm-setup.ps1)
    [int]    $StagingPort = 8088,
    [string] $CommitSha = 'manual',
    [int]    $Keep = 5,
    # Optional override for the live health check, e.g. https://foodirect.quasarsolutions.com/health.
    # Default: derived from the site's first binding and requested via 127.0.0.1 with the right Host header,
    # so it does not depend on DNS or the VM reaching its own public IP.
    [string] $HealthUrl = ''
)

$ErrorActionPreference = 'Stop'
Import-Module WebAdministration
if (-not $Root) { $Root = Join-Path 'C:\Foodirect' $SiteName }

function Write-Step([string] $msg) { Write-Host "==> $msg" }

function Test-Health {
    param([string] $Url, [string] $HostHeader = '', [int] $Attempts = 12, [int] $DelaySeconds = 10)
    $prevCallback = [Net.ServicePointManager]::ServerCertificateValidationCallback
    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    $local = ([Uri]$Url).Host -in @('127.0.0.1', 'localhost')
    try {
        if ($local) {
            # Local loopback check only: the certificate is for the public host name, not 127.0.0.1.
            [Net.ServicePointManager]::ServerCertificateValidationCallback = { $true }
        }
        for ($i = 1; $i -le $Attempts; $i++) {
            try {
                $req = [Net.HttpWebRequest]::Create($Url)
                $req.Timeout = 120000            # first request compiles the app; allow 2 minutes
                $req.AllowAutoRedirect = $false
                if ($HostHeader) { $req.Host = $HostHeader }
                $resp = $req.GetResponse()
                $body = (New-Object IO.StreamReader($resp.GetResponseStream())).ReadToEnd()
                $code = [int]$resp.StatusCode
                $resp.Close()
                if ($code -eq 200) { Write-Host "    200 OK  $body"; return $true }
                Write-Host "    attempt $i : HTTP $code"
            }
            catch [Net.WebException] {
                $r = $_.Exception.Response
                if ($r) {
                    $body = (New-Object IO.StreamReader($r.GetResponseStream())).ReadToEnd()
                    Write-Host "    attempt $i : HTTP $([int]$r.StatusCode)  $body"
                    $r.Close()
                } else { Write-Host "    attempt $i : $($_.Exception.Message)" }
            }
            if ($i -lt $Attempts) { Start-Sleep -Seconds $DelaySeconds }
        }
        return $false
    }
    finally { [Net.ServicePointManager]::ServerCertificateValidationCallback = $prevCallback }
}

function Get-LiveHealthTarget([string] $Site) {
    # Prefer an http binding (no certificate involved), else https. Request 127.0.0.1 with the binding's host name.
    $bindings = @(Get-WebBinding -Name $Site | Where-Object { $_.protocol -in 'http', 'https' } |
        Sort-Object { if ($_.protocol -eq 'http') { 0 } else { 1 } })
    if (-not $bindings) { throw "Site '$Site' has no http/https binding." }
    $b = $bindings[0]
    $parts = $b.bindingInformation.Split(':')      # ip:port:host
    $port = $parts[1]; $hostName = $parts[2]
    $url = '{0}://127.0.0.1:{1}/health' -f $b.protocol, $port
    return @{ Url = $url; Host = $(if ($hostName) { $hostName } else { '' }) }
}

# ---------------------------------------------------------------- checks
$sitePath = "IIS:\Sites\$SiteName"
$stagingName = "$SiteName-staging"
$stagingPath = "IIS:\Sites\$stagingName"
if (-not (Test-Path $sitePath))    { throw "IIS site '$SiteName' not found. Check the IIS_SITE_NAME variable." }
if (-not (Test-Path $stagingPath)) { throw "Staging site '$stagingName' not found. Run deploy/vm-setup.ps1 first." }
if (-not (Test-Path (Join-Path $PackagePath 'Web.config'))) { throw "No Web.config in package '$PackagePath'." }

$releasesDir = Join-Path $Root 'releases'
$configDir   = Join-Path $Root 'shared\config'
$serverFiles = 'Web.secrets.config', 'connectionStrings.config'
foreach ($f in $serverFiles) {
    if (-not (Test-Path (Join-Path $configDir $f))) { throw "Missing $configDir\$f. Run deploy/vm-setup.ps1 first." }
}

$site     = Get-Item $sitePath
$pool     = $site.applicationPool
$previous = [Environment]::ExpandEnvironmentVariables($site.physicalPath)

# ---------------------------------------------------------------- 1-2. stage files
$short = if ($CommitSha.Length -ge 7) { $CommitSha.Substring(0, 7) } else { $CommitSha }
$release = Join-Path $releasesDir ('{0}-{1}' -f (Get-Date -Format 'yyyyMMdd-HHmmss'), $short)
Write-Step "Copying package to $release"
New-Item -ItemType Directory -Path $release -Force | Out-Null
Copy-Item -Path (Join-Path $PackagePath '*') -Destination $release -Recurse -Force

Write-Step "Adding server config from $configDir"
$utf8 = New-Object Text.UTF8Encoding $false
foreach ($f in $serverFiles) {
    $text = [IO.File]::ReadAllText((Join-Path $configDir $f))
    [IO.File]::WriteAllText((Join-Path $release $f), $text.Replace('{RELEASE}', $release), $utf8)
}

# Uploads written by the previous release's own folder (before the AdUpload virtual directory existed) are
# carried into the shared folder once, without overwriting anything already there.
$adSettings = [xml][IO.File]::ReadAllText((Join-Path $configDir 'Web.secrets.config'))
$adShared = ($adSettings.appSettings.add | Where-Object { $_.key -eq 'ADUPLOADPATH' }).value
if ($adShared -and (Test-Path (Join-Path $previous 'AdUpload')) -and (Test-Path $adShared)) {
    & robocopy (Join-Path $previous 'AdUpload') $adShared /E /XC /XN /XO /NJH /NJS /NP /NFL /NDL | Out-Null
    if ($LASTEXITCODE -ge 8) { throw "robocopy of AdUpload failed ($LASTEXITCODE)" }
    $global:LASTEXITCODE = 0
}

# ---------------------------------------------------------------- 3. verify on staging
Write-Step "Verifying on staging site '$stagingName' (http://127.0.0.1:$StagingPort)"
Set-ItemProperty $stagingPath -Name physicalPath -Value $release
if ((Get-WebAppPoolState -Name (Get-Item $stagingPath).applicationPool).Value -ne 'Started') {
    Start-WebAppPool -Name (Get-Item $stagingPath).applicationPool
}
Start-Website -Name $stagingName
$stagingOk = Test-Health -Url "http://127.0.0.1:$StagingPort/health"
Stop-Website -Name $stagingName
if (-not $stagingOk) {
    throw "Staging /health did not return 200. Production was NOT changed. Release left at $release for inspection."
}

# ---------------------------------------------------------------- 4. switch production
Write-Step "Switching '$SiteName' from $previous to $release"
Set-ItemProperty $sitePath -Name physicalPath -Value $release
Restart-WebAppPool -Name $pool

if ($HealthUrl) { $target = @{ Url = $HealthUrl; Host = '' } } else { $target = Get-LiveHealthTarget $SiteName }
Write-Step "Verifying production: $($target.Url) $(if ($target.Host) { "(Host: $($target.Host))" })"
if (-not (Test-Health -Url $target.Url -HostHeader $target.Host)) {
    Write-Warning "Production /health failed - rolling back to $previous"
    Set-ItemProperty $sitePath -Name physicalPath -Value $previous
    Restart-WebAppPool -Name $pool
    throw "Deployment rolled back to $previous. Failed release kept at $release."
}

Set-Content -Path (Join-Path $releasesDir 'previous.txt') -Value $previous
Set-Content -Path (Join-Path $releasesDir 'current.txt')  -Value $release

# ---------------------------------------------------------------- 5. retention
$protect = @($release, $previous)
Get-ChildItem $releasesDir -Directory | Sort-Object Name -Descending | Select-Object -Skip $Keep |
    Where-Object { $protect -notcontains $_.FullName } |
    ForEach-Object { Write-Host "    removing old release $($_.Name)"; Remove-Item $_.FullName -Recurse -Force }

Write-Step "Deployed $CommitSha -> $release"
