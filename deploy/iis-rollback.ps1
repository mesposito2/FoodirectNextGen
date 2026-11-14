<#
.SYNOPSIS
  Points the live Foodirect IIS site back at an earlier release folder. Run on the VM, elevated.

.EXAMPLE
  .\iis-rollback.ps1 -SiteName Foodirect                 # back to the release before the current one
  .\iis-rollback.ps1 -SiteName Foodirect -List           # show available releases
  .\iis-rollback.ps1 -SiteName Foodirect -Release 20261114-153000-abc1234
#>
[CmdletBinding(SupportsShouldProcess)]
param(
    [Parameter(Mandatory)] [string] $SiteName,
    [string] $Root = 'C:\Foodirect',
    [string] $Release = '',
    [switch] $List
)
$ErrorActionPreference = 'Stop'
Import-Module WebAdministration

$releasesDir = Join-Path $Root 'releases'
$site = Get-Item "IIS:\Sites\$SiteName"
$current = [Environment]::ExpandEnvironmentVariables($site.physicalPath)

if ($List) {
    Get-ChildItem $releasesDir -Directory | Sort-Object Name -Descending |
        Select-Object Name, @{ n = 'Live'; e = { if ($_.FullName -eq $current) { '<== live' } } }, LastWriteTime
    return
}

if ($Release) {
    $target = Join-Path $releasesDir $Release
} else {
    $prevFile = Join-Path $releasesDir 'previous.txt'
    if (-not (Test-Path $prevFile)) { throw "No previous.txt; pass -Release (see -List)." }
    $target = (Get-Content $prevFile -TotalCount 1).Trim()
}
if (-not (Test-Path (Join-Path $target 'Web.config'))) { throw "'$target' is not a deployable release folder." }
if ($target -eq $current) { Write-Host "Already live: $target"; return }

if ($PSCmdlet.ShouldProcess($SiteName, "Switch physical path $current -> $target")) {
    Set-ItemProperty "IIS:\Sites\$SiteName" -Name physicalPath -Value $target
    Restart-WebAppPool -Name $site.applicationPool
    Set-Content (Join-Path $releasesDir 'previous.txt') $current
    Set-Content (Join-Path $releasesDir 'current.txt')  $target
    Write-Host "Live site now serves $target (was $current). Check /health."
}
