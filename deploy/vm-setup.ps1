<#
.SYNOPSIS
  One-time preparation of the IIS VM for GitHub Actions deployments of the Foodirect web app.
  Run on the VM in an elevated Windows PowerShell. Preview first with -WhatIf.

.DESCRIPTION
  Works with the EXISTING IIS site; it does not change its bindings, certificate or app pool settings.

  1. Creates  <Root>\releases          one folder per deployed build      (<Root> = C:\Foodirect\<SiteName>)
              <Root>\shared\config     private server config (never in Git)
              <Root>\shared\AdUpload   uploaded ad images / email-blast files (survive deployments)
              C:\Foodirect\runner      the GitHub Actions runner (shared by all sites on the VM)
  2. Builds shared\config\Web.secrets.config from the live site's current Web.config <appSettings>
     (so production keeps today's values, including server-specific paths and URLs) and adds
     FD_ENCRYPTION_KEY / LOGIN_COOKIE_KEY, which you are prompted for if you don't pass them.
     Paths that pointed inside the old site folder become {RELEASE}\..., resolved at each deploy.
  3. Copies the live <connectionStrings> into shared\config\connectionStrings.config.
  4. Locks shared\config down to Administrators, SYSTEM and the app pool identity (read).
  5. Copies existing uploads into shared\AdUpload and maps the site's /AdUpload virtual directory to it.
  6. Creates a private staging site "<SiteName>-staging" on http://127.0.0.1:<StagingPort> (loopback only,
     not reachable from outside the VM), stopped, using the same app pool.
  7. Installs the GitHub Actions runner as a Windows service (LocalSystem, needed to manage IIS) with
     label "foodirect-iis", registered to the repository only.

  Existing files in shared\config are never overwritten. Re-running the script is safe.

.PARAMETER RunnerToken
  Registration token from GitHub: repo > Settings > Actions > Runners > New self-hosted runner (valid 1 hour).
  Omit to skip the runner step.

.EXAMPLE
  .\vm-setup.ps1 -SiteName Foodirect -GitHubRepo OWNER/REPO -RunnerToken XXXX -WhatIf
  .\vm-setup.ps1 -SiteName Foodirect -GitHubRepo OWNER/REPO -RunnerToken XXXX
#>
[CmdletBinding(SupportsShouldProcess)]
param(
    [Parameter(Mandatory)] [string] $SiteName,
    [Parameter(Mandatory)] [ValidatePattern('^[\w.-]+/[\w.-]+$')] [string] $GitHubRepo,
    [string] $RunnerToken = '',
    # Per-site folder (releases + shared config), default C:\Foodirect\<SiteName>, so several sites can coexist.
    [string] $Root = '',
    # One runner serves every site on this VM.
    [string] $RunnerDir = 'C:\Foodirect\runner',
    [int]    $StagingPort = 8088,
    [string] $EncryptionKey = '',
    [string] $CookieKey = ''
)

$ErrorActionPreference = 'Stop'
if (-not $Root) { $Root = Join-Path 'C:\Foodirect' $SiteName }
$principal = New-Object Security.Principal.WindowsPrincipal([Security.Principal.WindowsIdentity]::GetCurrent())
if (-not $principal.IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator)) {
    throw 'Run this script from an elevated (Administrator) PowerShell.'
}
Import-Module WebAdministration

function Write-Step([string] $msg) { Write-Host "`n==> $msg" -ForegroundColor Cyan }
function Read-Plain([string] $prompt) {
    $s = Read-Host -Prompt $prompt -AsSecureString
    [Runtime.InteropServices.Marshal]::PtrToStringBSTR([Runtime.InteropServices.Marshal]::SecureStringToBSTR($s))
}

# ---------------------------------------------------------------- inspect the live site
$sitePath = "IIS:\Sites\$SiteName"
if (-not (Test-Path $sitePath)) {
    throw "IIS site '$SiteName' not found. Sites on this server: $((Get-ChildItem IIS:\Sites).Name -join ', ')"
}
$site     = Get-Item $sitePath
$pool     = $site.applicationPool
$livePath = [Environment]::ExpandEnvironmentVariables($site.physicalPath).TrimEnd('\')
$liveCfg  = Join-Path $livePath 'Web.config'
if (-not (Test-Path $liveCfg)) { throw "No Web.config at $liveCfg" }

$procModel = Get-ItemProperty "IIS:\AppPools\$pool" -Name processModel
switch ($procModel.identityType) {
    'ApplicationPoolIdentity' { $poolAccount = "IIS AppPool\$pool" }
    'NetworkService'          { $poolAccount = 'NT AUTHORITY\NETWORK SERVICE' }
    'LocalService'            { $poolAccount = 'NT AUTHORITY\LOCAL SERVICE' }
    'LocalSystem'             { $poolAccount = 'NT AUTHORITY\SYSTEM' }
    default                   { $poolAccount = $procModel.userName }
}
Write-Host "Site       : $SiteName"
Write-Host "Live folder: $livePath"
Write-Host "App pool   : $pool (runs as $poolAccount)"
Write-Host "Bindings   : $((Get-WebBinding -Name $SiteName | ForEach-Object { "$($_.protocol) $($_.bindingInformation)" }) -join '; ')"

$releasesDir = Join-Path $Root 'releases'
$configDir   = Join-Path $Root 'shared\config'
$adDir       = Join-Path $Root 'shared\AdUpload'
$runnerDir   = $RunnerDir

# ---------------------------------------------------------------- 1. folders
Write-Step "Folders under $Root"
foreach ($d in $releasesDir, $configDir, $adDir, $runnerDir) {
    if (-not (Test-Path $d) -and $PSCmdlet.ShouldProcess($d, 'Create folder')) { New-Item -ItemType Directory $d | Out-Null }
}

# ---------------------------------------------------------------- read live config (+ any external files it uses)
$xml = [xml][IO.File]::ReadAllText($liveCfg)
$appNode = $xml.configuration.appSettings
$settings = [ordered]@{}
foreach ($a in @($appNode.add)) { if ($a) { $settings[$a.key] = $a.value } }
if ($appNode.file -and (Test-Path (Join-Path $livePath $appNode.file))) {
    foreach ($a in @(([xml][IO.File]::ReadAllText((Join-Path $livePath $appNode.file))).appSettings.add)) {
        if ($a) { $settings[$a.key] = $a.value }
    }
}
$csNode = $xml.configuration.connectionStrings
if ($csNode.configSource) { $csXml = [IO.File]::ReadAllText((Join-Path $livePath $csNode.configSource)) }
else                      { $csXml = $csNode.OuterXml }

$oldAdPath = $settings['ADUPLOADPATH']
$adWebPath = if ($settings['ADUPLOADWEBPATH']) { $settings['ADUPLOADWEBPATH'] } else { '\AdUpload' }
$adVdir    = $adWebPath.Trim('\', '/')

# ---------------------------------------------------------------- 2. Web.secrets.config
Write-Step 'Server app settings (shared\config\Web.secrets.config)'
$secretsFile = Join-Path $configDir 'Web.secrets.config'
if (Test-Path $secretsFile) {
    Write-Host "Exists - left unchanged: $secretsFile"
} else {
    # Framework switches come from the deployed Web.config, not from the old server copy.
    $skip = '^(webpages:.*|ClientValidationEnabled|UnobtrusiveJavaScriptEnabled|PreserveLoginUrl)$'
    $out = [ordered]@{}
    foreach ($k in $settings.Keys) {
        if ($k -match $skip) { continue }
        $v = [string]$settings[$k]
        if ($v -and $v.StartsWith($livePath + '\', [StringComparison]::OrdinalIgnoreCase)) {
            $v = '{RELEASE}' + $v.Substring($livePath.Length)      # e.g. EmailTemplates ship with each release
        }
        $out[$k] = $v
    }
    $out['ADUPLOADPATH'] = $adDir
    if (-not $out['FD_ENCRYPTION_KEY']) {
        if (-not $EncryptionKey -and -not $WhatIfPreference) { $EncryptionKey = Read-Plain 'FD_ENCRYPTION_KEY (legacy AES key, from FDShared\SecurityCore.Fallback.cs)' }
        $out['FD_ENCRYPTION_KEY'] = $EncryptionKey
    }
    if (-not $out['LOGIN_COOKIE_KEY']) {
        if (-not $CookieKey -and -not $WhatIfPreference) { $CookieKey = Read-Plain 'LOGIN_COOKIE_KEY (legacy cookie key, from UI\Objects\CookieHelper.Fallback.cs)' }
        $out['LOGIN_COOKIE_KEY'] = $CookieKey
    }
    foreach ($k in $out.Keys) {
        $shown = if ($k -match 'PWD|KEY|SECRET|EXPERTPDF') { '********' } else { $out[$k] }
        Write-Host ("    {0,-22} {1}" -f $k, $shown)
    }
    foreach ($k in 'FD_ENCRYPTION_KEY', 'LOGIN_COOKIE_KEY', 'SMTPPWD', 'EXPERTPDF') {
        if (-not $out[$k]) { Write-Warning "$k is empty - set it in $secretsFile before the first deploy." }
    }
    if ($PSCmdlet.ShouldProcess($secretsFile, 'Write server app settings')) {
        $ws = New-Object Xml.XmlWriterSettings; $ws.Indent = $true; $ws.Encoding = New-Object Text.UTF8Encoding $false
        $w = [Xml.XmlWriter]::Create($secretsFile, $ws)
        $w.WriteStartElement('appSettings')
        $w.WriteComment(' Production overrides for Web.config <appSettings>. Copied into every release by iis-deploy.ps1. Not in Git. ')
        foreach ($k in $out.Keys) { $w.WriteStartElement('add'); $w.WriteAttributeString('key', $k); $w.WriteAttributeString('value', [string]$out[$k]); $w.WriteEndElement() }
        $w.WriteEndElement(); $w.Close()
    }
}

# ---------------------------------------------------------------- 3. connectionStrings.config
Write-Step 'Server connection strings (shared\config\connectionStrings.config)'
$csFile = Join-Path $configDir 'connectionStrings.config'
if (Test-Path $csFile) {
    Write-Host "Exists - left unchanged: $csFile"
} else {
    $names = @(([xml]$csXml).connectionStrings.add | ForEach-Object { $_.name })
    Write-Host "    copying from live Web.config: $($names -join ', ')"
    if ($names -notcontains 'FD') { Write-Warning "No 'FD' connection string found - add it to $csFile before the first deploy." }
    if ($PSCmdlet.ShouldProcess($csFile, 'Write connection strings')) {
        [IO.File]::WriteAllText($csFile, "<?xml version=`"1.0`" encoding=`"utf-8`"?>`r`n" + $csXml, (New-Object Text.UTF8Encoding $false))
    }
}

# ---------------------------------------------------------------- 4. permissions
Write-Step 'Permissions'
if ($PSCmdlet.ShouldProcess($configDir, "Restrict to Administrators, SYSTEM, $poolAccount (read)")) {
    & icacls $configDir /inheritance:r /grant:r 'BUILTIN\Administrators:(OI)(CI)F' 'NT AUTHORITY\SYSTEM:(OI)(CI)F' "${poolAccount}:(OI)(CI)RX" | Out-Null
    if ($LASTEXITCODE) { throw "icacls failed on $configDir" }
}
if ($PSCmdlet.ShouldProcess($releasesDir, "Grant $poolAccount read")) {
    & icacls $releasesDir /grant "${poolAccount}:(OI)(CI)RX" | Out-Null
    if ($LASTEXITCODE) { throw "icacls failed on $releasesDir" }
}
if ($PSCmdlet.ShouldProcess($adDir, "Grant $poolAccount modify (uploads)")) {
    & icacls $adDir /grant "${poolAccount}:(OI)(CI)M" | Out-Null
    if ($LASTEXITCODE) { throw "icacls failed on $adDir" }
}

# ---------------------------------------------------------------- 5. uploads + virtual directory
Write-Step "Uploads -> $adDir and /$adVdir virtual directory"
$sources = @((Join-Path $livePath $adVdir), $oldAdPath) | Where-Object { $_ -and (Test-Path $_) } | Select-Object -Unique
foreach ($src in $sources) {
    if ($src.TrimEnd('\') -ieq $adDir) { continue }
    if ($PSCmdlet.ShouldProcess("$src -> $adDir", 'Copy existing uploads (no overwrite)')) {
        & robocopy $src $adDir /E /XC /XN /XO /NJH /NJS /NP /NFL /NDL | Out-Null
        if ($LASTEXITCODE -ge 8) { throw "robocopy failed ($LASTEXITCODE)" }
    }
}
foreach ($s in $SiteName, "$SiteName-staging") {
    if (-not (Test-Path "IIS:\Sites\$s")) { continue }      # staging is created below (and gets its vdir there)
    $vd = Get-WebVirtualDirectory -Site $s -Name $adVdir
    if ($vd) {
        if ($vd.physicalPath.TrimEnd('\') -ine $adDir) {
            Write-Warning "$s/$adVdir already points to $($vd.physicalPath) - left unchanged. ADUPLOADPATH in $secretsFile must match it."
        }
    } elseif ($PSCmdlet.ShouldProcess("$s/$adVdir", "Create virtual directory -> $adDir")) {
        New-WebVirtualDirectory -Site $s -Name $adVdir -PhysicalPath $adDir | Out-Null
    }
}

# ---------------------------------------------------------------- 6. staging site
$stagingName = "$SiteName-staging"
Write-Step "Staging site $stagingName (http://127.0.0.1:$StagingPort, loopback only)"
if (Test-Path "IIS:\Sites\$stagingName") {
    Write-Host 'Exists - left unchanged.'
} else {
    $inUse = Get-WebBinding | Where-Object { $_.bindingInformation -match ":${StagingPort}:" }
    if ($inUse) { throw "Port $StagingPort is already bound in IIS. Re-run with -StagingPort <free port>." }
    if ($PSCmdlet.ShouldProcess($stagingName, "Create site on 127.0.0.1:$StagingPort using pool $pool")) {
        New-Website -Name $stagingName -IPAddress '127.0.0.1' -Port $StagingPort -PhysicalPath $livePath -ApplicationPool $pool | Out-Null
        New-WebVirtualDirectory -Site $stagingName -Name $adVdir -PhysicalPath $adDir | Out-Null
        Stop-Website -Name $stagingName
    }
}

# ---------------------------------------------------------------- 7. GitHub Actions runner
Write-Step 'GitHub Actions runner'
$svc = Get-Service -Name 'actions.runner.*' -ErrorAction SilentlyContinue | Select-Object -First 1
if ($svc) {
    Write-Host "Already installed: $($svc.Name) ($($svc.Status))"
} elseif (-not $RunnerToken) {
    Write-Warning 'No -RunnerToken given - runner not installed. Re-run with a token from repo Settings > Actions > Runners.'
} elseif ($PSCmdlet.ShouldProcess($runnerDir, "Install runner for github.com/$GitHubRepo (label foodirect-iis, service as LocalSystem)")) {
    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    $rel = Invoke-RestMethod 'https://api.github.com/repos/actions/runner/releases/latest' -Headers @{ 'User-Agent' = 'foodirect-vm-setup' }
    $asset = $rel.assets | Where-Object { $_.name -match '^actions-runner-win-x64-[\d.]+\.zip$' } | Select-Object -First 1
    if (-not $asset) { throw 'Could not find the win-x64 runner package in the latest release.' }
    $zip = Join-Path $env:TEMP $asset.name
    Invoke-WebRequest $asset.browser_download_url -OutFile $zip -UseBasicParsing
    # The release notes publish each package's SHA-256 between <!-- BEGIN SHA win-x64 --> markers.
    if ($rel.body -match '<!-- BEGIN SHA win-x64 -->([0-9a-f]{64})<!-- END SHA win-x64 -->') {
        $actual = (Get-FileHash $zip -Algorithm SHA256).Hash.ToLower()
        if ($actual -ne $Matches[1]) { throw "Runner download hash mismatch ($actual)." }
        Write-Host "    $($asset.name) SHA-256 verified"
    } else { Write-Warning 'Release notes had no SHA-256 for win-x64; hash not verified.' }
    Expand-Archive $zip -DestinationPath $runnerDir -Force
    Remove-Item $zip
    Push-Location $runnerDir
    try {
        & .\config.cmd --unattended --url "https://github.com/$GitHubRepo" --token $RunnerToken `
            --name "$env:COMPUTERNAME-foodirect" --labels foodirect-iis --work _work --runasservice --replace
        if ($LASTEXITCODE) { throw "Runner configuration failed ($LASTEXITCODE)." }
    } finally { Pop-Location }
    # Run as LocalSystem: the deploy script manages IIS (site paths, app pool recycle), which needs admin rights.
    $svc = Get-Service -Name 'actions.runner.*' | Select-Object -First 1
    & sc.exe config $svc.Name obj= LocalSystem | Out-Null
    Restart-Service $svc.Name
    Write-Host "    service $($svc.Name): $((Get-Service $svc.Name).Status)"
}

# ---------------------------------------------------------------- summary
Write-Step 'GitHub > Settings > Environments > production > Environment variables'
Write-Host "    IIS_SITE_NAME   = $SiteName"
Write-Host "    STAGING_PORT    = $StagingPort"
Write-Host "    PRODUCTION_URL  = https://<your public host name>   (used for the external check)"
Write-Host "`nReview $secretsFile and $csFile, then merge to main (or run the workflow) to deploy."
