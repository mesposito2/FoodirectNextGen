<#
.SYNOPSIS
  One-time Azure setup so GitHub Actions can deploy to the existing Web App with OpenID Connect.

.DESCRIPTION
  Creates (no secrets, no billable compute):
    1. A user-assigned managed identity  (free)
    2. A federated credential trusting ONLY  repo:<owner>/<repo>:environment:production
    3. A "Website Contributor" role assignment scoped to the ONE Web App (covers its slots)
  Then prints the values to enter as GitHub environment variables.

  It does NOT create/resize App Service plans, slots, databases, or set any app secrets.

.EXAMPLE
  # Dry run - prints every az command without executing:
  .\deploy\azure-oidc-setup.ps1 -GitHubRepo myorg/foodirect-web -WhatIf
  # Real run (needs Azure CLI and Owner / User Access Administrator on the Web App):
  az login
  .\deploy\azure-oidc-setup.ps1 -GitHubRepo myorg/foodirect-web
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)] [ValidatePattern('^[\w.-]+/[\w.-]+$')] [string] $GitHubRepo,
    [string] $SubscriptionId = 'b2b45d8b-c7ea-4903-9c19-92023e296e38',   # from UI\Properties\PublishProfiles\FDWeb_AZURE_DEPLOY.pubxml
    [string] $ResourceGroup  = 'FDWebSite',
    [string] $WebAppName     = 'FDWeb',
    [string] $IdentityName   = 'id-foodirect-github-deploy',
    [string] $GitHubEnvironment = 'production',
    [switch] $WhatIf
)
$ErrorActionPreference = 'Stop'

function Az([string[]] $AzArgs) {
    $line = 'az ' + ($AzArgs -join ' ')
    if ($WhatIf) { Write-Host "[WhatIf] $line" -ForegroundColor Yellow; return $null }
    Write-Host "> $line" -ForegroundColor Cyan
    $out = & az @AzArgs
    if ($LASTEXITCODE -ne 0) { throw "az failed: $line" }
    return $out
}

if (-not $WhatIf -and -not (Get-Command az -ErrorAction SilentlyContinue)) {
    throw 'Azure CLI not found. Install: winget install -e --id Microsoft.AzureCLI  then run: az login'
}

Az @('account','set','--subscription',$SubscriptionId) | Out-Null

$location = Az @('group','show','-n',$ResourceGroup,'--query','location','-o','tsv')
if ($WhatIf) { $location = '<resource-group-location>' }

# 1) Managed identity (idempotent: create returns the existing one)
$idJson = Az @('identity','create','-g',$ResourceGroup,'-n',$IdentityName,'-l',$location,'-o','json')
$clientId = '<client-id>'; $principalId = '<principal-id>'
if (-not $WhatIf) { $id = $idJson | ConvertFrom-Json; $clientId = $id.clientId; $principalId = $id.principalId }

# 2) Federated credential: only jobs running in the GitHub "production" environment of this repo can log in
$subject = "repo:${GitHubRepo}:environment:${GitHubEnvironment}"
Az @('identity','federated-credential','create',
     '--name',"github-$GitHubEnvironment",
     '--identity-name',$IdentityName,'-g',$ResourceGroup,
     '--issuer','https://token.actions.githubusercontent.com',
     '--subject',$subject,
     '--audiences','api://AzureADTokenExchange') | Out-Null

# 3) Least-privilege role on just this Web App (slots are child resources, so swap works too)
$webAppId = Az @('webapp','show','-g',$ResourceGroup,'-n',$WebAppName,'--query','id','-o','tsv')
if ($WhatIf) { $webAppId = "/subscriptions/$SubscriptionId/resourceGroups/$ResourceGroup/providers/Microsoft.Web/sites/$WebAppName" }
Az @('role','assignment','create',
     '--assignee-object-id',$principalId,'--assignee-principal-type','ServicePrincipal',
     '--role','Website Contributor','--scope',$webAppId) | Out-Null

$tenantId = Az @('account','show','--query','tenantId','-o','tsv')
if ($WhatIf) { $tenantId = '<tenant-id>' }

Write-Host ''
Write-Host 'Done. Add these as VARIABLES (not secrets) on the GitHub environment "production":' -ForegroundColor Green
[ordered]@{
    AZURE_CLIENT_ID       = $clientId
    AZURE_TENANT_ID       = $tenantId
    AZURE_SUBSCRIPTION_ID = $SubscriptionId
    AZURE_RESOURCE_GROUP  = $ResourceGroup
    AZURE_WEBAPP_NAME     = $WebAppName
    PRODUCTION_URL        = 'https://foodirect.quasarsolutions.com'
} | Format-Table -AutoSize
Write-Host "Federated credential subject: $subject"
