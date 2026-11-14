# Foodirect web (V5)

ASP.NET MVC 5 on **.NET Framework 4.8**, built with Visual Studio MSBuild and deployed by GitHub Actions to the
existing **Azure App Service Web App `FDWeb`** (resource group `FDWebSite`), live at <https://foodirect.quasarsolutions.com>.

> This is not ASP.NET Core. `dotnet build` / `dotnet publish` cannot build the web project (legacy web-application
> targets), so the pipeline builds and publishes with **MSBuild on a Windows runner**. `dotnet test` runs the test project.

| Path | What |
|---|---|
| `UI/` | The web app (controllers, Razor views, `Content/fd` design system) |
| `BusinessObjects/`, `FDShared/` | Data layer (EntitySpaces) and shared helpers |
| `Tests/FoodirectV5.Tests/` | MSTest unit tests (encryption, secret hygiene, config consistency) |
| `V5.Web.slnf` | Solution filter used by CI and VS Code: the four projects above |
| `.github/workflows/ci-cd.yml` | Build, test, publish, and deploy |
| `deploy/azure-oidc-setup.ps1` | One-time Azure identity setup for passwordless deploys |

`FDJobMaster`, `FDTest` and other folders in the original working directory are intentionally **not** in this repo yet.

---

## 1. Run it locally (VS Code)

**Prerequisites:** Windows; Visual Studio 2022+ (Community is fine) with the *ASP.NET and web development* workload
(provides MSBuild, the .NET Framework 4.8 targeting pack and IIS Express); the .NET SDK in `global.json`; Git; and
SQL Server LocalDB with the `fdv5` database (or edit the `FD` connection string in `UI/Web.config`).

**Secrets (one time):** copy `UI/Web.secrets.config.example` to `UI/Web.secrets.config` and fill in the values. Ask
the project owner. Do the same for `FDShared/SecurityCore.Fallback.cs.example`. Both real files are git-ignored.

In VS Code, open **Terminal > Run Task…**:

| Task | Does |
|---|---|
| `restore` | NuGet restore (run once after cloning) |
| `build` (Ctrl+Shift+B) | Debug build of the web solution filter |
| `test` | Builds, then runs the unit tests |
| `run site (http://localhost:1687)` | Starts IIS Express, then browse to <http://localhost:1687> |
| `compile views` | Compiles every Razor view (same check CI runs) |
| `publish (Release -> artifacts/publish)` | Exactly what CI deploys |

The same steps from the terminal:

```powershell
$msb = "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe"  # adjust for your VS version
& $msb V5.Web.slnf /t:Restore /p:RestorePackagesConfig=true
& $msb V5.Web.slnf /p:Configuration=Debug /m
dotnet test Tests/FoodirectV5.Tests/FoodirectV5.Tests.csproj --no-build -c Debug
& "C:\Program Files\IIS Express\iisexpress.exe" /path:"$PWD\UI" /port:1687
```

Health check: <http://localhost:1687/health> returns `200` with JSON when the database and keys are configured.

---

## 2. Day-to-day Git workflow

```powershell
git clone https://github.com/OWNER/REPO.git      # first time only
cd REPO
git switch main && git pull                      # get the latest main
git switch -c feature/short-description          # new branch for your change
# ...edit, build, run the "test" task...
git add -A
git commit -m "Explain what and why"
git push -u origin feature/short-description     # first push of the branch; later just: git push
```

Then open a **pull request**: GitHub shows a *Compare & pull request* banner after the push, or use
**Pull requests > New pull request**, base `main`, compare your branch. The PR runs **Build & test** only. It cannot
deploy and has no Azure access. Merge when it's green. The merge to `main` deploys to production.

---

## 3. What the pipeline does

| Trigger | Jobs |
|---|---|
| PR targeting `main` | **Build & test**: restore, Release build, unit tests, compile all Razor views. Token is read-only. |
| Push / merge to `main` | Same checks, then **publish** (`Web.Release.config` applied) and upload artifact `foodirect-web`, then **Deploy** that same artifact. |

Deploy job (only job with `id-token: write`, gated by the GitHub environment `production`):
1. Azure login with **OIDC**: a short-lived token, no stored secret.
2. If the Web App has a slot named `staging` (or `AZURE_STAGING_SLOT`), deploy there, check `https://<slot-host>/health`,
   then **swap** to production. Otherwise deploy straight to production.
3. Check `PRODUCTION_URL/health` until it returns 200 (retries for about 3 minutes). A non-200 fails the run.
4. Print the deployed commit from `/version.txt`.

---

## 4. One-time setup

### 4a. GitHub
1. Create a **private** repository (it contains licensed ExpertPDF and EntitySpaces DLLs). Push this repo to it.
2. **Settings > Environments > New environment** `production`:
   - *Deployment branches and tags*: **Selected branches** > add `main`.
   - Optional: *Required reviewers* (yourself) to approve each production deploy.
   - **Environment variables** (variables, not secrets; none of these are sensitive):

     | Variable | Value |
     |---|---|
     | `AZURE_CLIENT_ID` | client ID printed by the setup script |
     | `AZURE_TENANT_ID` | printed by the setup script |
     | `AZURE_SUBSCRIPTION_ID` | `b2b45d8b-c7ea-4903-9c19-92023e296e38` |
     | `AZURE_RESOURCE_GROUP` | `FDWebSite` |
     | `AZURE_WEBAPP_NAME` | `FDWeb` |
     | `PRODUCTION_URL` | `https://foodirect.quasarsolutions.com` |
     | `AZURE_STAGING_SLOT` | *(optional, default `staging`)* |
3. **Settings > Branches > Add rule** for `main`: require a pull request and require the status check **Build & test**.
4. **Settings > Actions > General > Workflow permissions**: *Read repository contents* (the default).

### 4b. Azure (no billable resources are created)
Run once, as someone with Owner or User Access Administrator on the Web App:

```powershell
winget install -e --id Microsoft.AzureCLI ; az login
.\deploy\azure-oidc-setup.ps1 -GitHubRepo OWNER/REPO -WhatIf   # preview
.\deploy\azure-oidc-setup.ps1 -GitHubRepo OWNER/REPO           # apply
```

It creates the managed identity **`id-foodirect-github-deploy`** in `FDWebSite`. It adds a federated credential with
issuer `https://token.actions.githubusercontent.com`, subject `repo:OWNER/REPO:environment:production` and audience
`api://AzureADTokenExchange`. It assigns **Website Contributor** on `FDWeb` only. It prints the IDs for step 4a.

### 4c. App Service configuration (secrets live here, never in Git)
Portal > **FDWeb > Settings > Environment variables** (older portals: *Configuration*):

**App settings**

| Name | Notes |
|---|---|
| `FD_ENCRYPTION_KEY` | **Required.** Must equal the legacy key (value in `FDShared/SecurityCore.Fallback.cs` on the owner's PC); otherwise no one can log in. |
| `LOGIN_COOKIE_KEY` | **Required.** Legacy remember-me key (`UI/Objects/CookieHelper.Fallback.cs`). |
| `SMTPPWD` | SendGrid API key (order/registration emails) |
| `EXPERTPDF` | ExpertPDF v15 license key (PDFs) |
| `RECAPTCHA_SECRET` | Google reCAPTCHA secret (Contact form) |

**Connection strings** (same names as `Web.config`): `FD` (type *SQLAzure*, the Azure SQL `FDV5` database);
`FDAS400_PRIMARY`, `FDAS400_SECONDARY`, `FDAS400_TERTIARY` (type *Custom*) if the AS400 features are used.

**General settings**: Stack **.NET**, version **.NET Framework 4.8**, Windows. PDF generation needs a **Basic or higher**
plan (Free/Shared block the rendering engine). A `staging` slot needs **Standard or higher**. It's optional: without it the
pipeline deploys straight to production.

`/health` returns **503** until `FD`, `FD_ENCRYPTION_KEY` and `LOGIN_COOKIE_KEY` are set, and the deploy fails on purpose.

---

## 5. Verify the first deployment

1. Merge a PR into `main` (or **Actions > CI/CD > Run workflow** on `main`).
2. **GitHub > Actions > CI/CD > the run**: both jobs green. The *Deploy* job summary shows the environment URL.
   **Code > Environments > production** lists every deployment.
3. Open `https://foodirect.quasarsolutions.com/health`: expect `"status":"Healthy"`. Open `/version.txt`: the commit SHA matches.
4. Smoke test: home page, log in, open Products, download an order PDF.

**Where to look**

| What | Where |
|---|---|
| Live URL | `https://foodirect.quasarsolutions.com` (also `https://<app>.azurewebsites.net`, on the Web App *Overview* page) |
| Pipeline logs | GitHub > **Actions** > run > job > step |
| Deployment history/logs | Azure portal > FDWeb > **Deployment Center > Logs** |
| App runtime logs | Azure portal > FDWeb > **Log stream** (enable *App Service logs* first); app errors also go to DB table `v5WebLog` |
| Files on the server (Kudu) | `https://fdweb-cmdmh4aag6g6gnau.scm.centralus-01.azurewebsites.net` |

**Roll back:** re-run the deploy job of the last good run (**Actions > run > Re-run jobs**; it redeploys that run's
artifact), or swap the slots back if you use `staging`.

---

## 6. Secrets policy
- Real secrets live only in `UI/Web.secrets.config`, the `*.Fallback.cs` files (local, git-ignored) and App Service settings.
- The unit tests fail the build if a secret value reappears in `Web.config`/`Web.Release.config`, if a connection string
  contains a password, or if a SendGrid key, reCAPTCHA secret, SQL login password or `...KEY = "..."` constant is
  hardcoded in source.
- These values existed in plain text in local files before this repo was created: the SendGrid key, Azure SQL `FDSQL`
  password, AS400 `TRANSFER` password and reCAPTCHA secret. They were never committed. Rotating them is still good practice.
