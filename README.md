# Foodirect web (V5)

ASP.NET MVC 5 on **.NET Framework 4.8**, built with Visual Studio MSBuild and deployed by GitHub Actions to
**IIS on an Azure Windows VM**.

> This is not ASP.NET Core. `dotnet build` / `dotnet publish` cannot build the web project (legacy web-application
> targets), so the pipeline builds and publishes with **MSBuild on a Windows runner**. `dotnet test` runs the test project.

| Path | What |
|---|---|
| `UI/` | The web app (controllers, Razor views, `Content/fd` design system) |
| `BusinessObjects/`, `FDShared/` | Data layer (EntitySpaces) and shared helpers |
| `Tests/FoodirectV5.Tests/` | MSTest unit tests (encryption, secret hygiene, config consistency) |
| `V5.Web.slnf` | Solution filter used by CI and VS Code: the four projects above |
| `.github/workflows/ci-cd.yml` | Build, test, publish, deploy, verify |
| `deploy/vm-setup.ps1` | One-time VM preparation (folders, server config, staging site, runner) |
| `deploy/iis-deploy.ps1` | Installs one build on the VM (the pipeline runs it) |
| `deploy/iis-rollback.ps1` | Switches the live site back to an earlier build |

`FDJobMaster`, `FDTest` and other folders in the original working directory are intentionally **not** in this repo yet.

---

## 1. Run it locally (VS Code)

**Prerequisites:** Windows; Visual Studio 2022+ (Community is fine) with the *ASP.NET and web development* workload
(provides MSBuild, the .NET Framework 4.8 targeting pack and IIS Express); the .NET SDK in `global.json`; Git; and
SQL Server LocalDB with the `fdv5` database (or edit the `FD` connection string in `UI/Web.config`).

**Secrets (one time):** copy `UI/Web.secrets.config.example` to `UI/Web.secrets.config` and fill in the values (ask
the project owner). Do the same for `FDShared/SecurityCore.Fallback.cs.example`. Both real files are git-ignored.

In VS Code, open **Terminal > Run Task…**:

| Task | Does |
|---|---|
| `restore` | NuGet restore (run once after cloning) |
| `build` (Ctrl+Shift+B) | Debug build of the web solution filter |
| `test` | Builds, then runs the unit tests |
| `run site (http://localhost:1687)` | Starts IIS Express, then browse to <http://localhost:1687> |
| `compile views` | Compiles every Razor view (same check CI runs) |
| `publish (Release -> artifacts/publish)` | The same publish CI does |

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
git clone https://github.com/mesposito2/FoodirectNextGen.git      # first time only
cd FoodirectNextGen
git switch main && git pull                      # get the latest main
git switch -c feature/short-description          # new branch for your change
# ...edit, build, run the "test" task...
git add -A
git commit -m "Explain what and why"
git push -u origin feature/short-description     # first push of the branch; later just: git push
```

Then open a **pull request**: GitHub shows a *Compare & pull request* banner after the push, or use
**Pull requests > New pull request**, base `main`, compare your branch. The PR runs **Build & test** only, on
GitHub's machines. It cannot reach the VM. Merge when it's green. The merge to `main` deploys to production.

---

## 3. What the pipeline does

| Trigger | Jobs |
|---|---|
| PR targeting `main` | **Build & test** (GitHub-hosted Windows): restore, Release build, unit tests, compile all Razor views. Read-only token. |
| Push / merge to `main` | Same checks, then **publish** (`Web.Release.config` applied) and upload artifact `foodirect-web`, then **Deploy to IIS VM**, then **Verify public site**. |

**Deploy to IIS VM** runs on the self-hosted runner installed on the VM and executes `deploy/iis-deploy.ps1` from
the artifact:

1. Copies the build into a new folder `C:\Foodirect\<site>\releases\<date-time>-<commit>`.
2. Adds the server's private config (`C:\Foodirect\<site>\shared\config\Web.secrets.config` and `connectionStrings.config`).
3. Points the private staging site `<site>-staging` (`http://127.0.0.1:8088`, VM-only) at it and waits for
   `/health` = 200. **If that fails, production is not touched.**
4. Switches the live IIS site's physical path to the new folder and recycles the app pool. That takes seconds, not
   a long outage. Then checks the live `/health`. **If that fails, it switches straight back to the previous folder.**
5. Keeps the last 5 releases for rollback.

**Verify public site** (GitHub-hosted Linux) then calls `PRODUCTION_URL/health` from the internet and confirms that
`/version.txt` shows the commit just deployed.

Credentials: none are stored in GitHub. The runner connects **outbound** to GitHub (no inbound ports on the VM) using
short-lived job tokens. App secrets never leave the VM.

---

## 4. One-time setup

### 4a. GitHub
1. Create a **private** repository (it contains licensed ExpertPDF and EntitySpaces DLLs). Push this repo to it.
2. **Settings > Secrets and variables > Actions > Variables > New repository variable** (variables, not
   secrets; none of these are sensitive):

     | Variable | Value |
     |---|---|
     | `DEPLOY_ENABLED` | `true` turns production deploys on. Leave it unset, or set anything else, to pause deploys (builds and tests still run). |
     | `IIS_SITE_NAME` | The existing IIS site name (IIS Manager > Sites), e.g. `FDWebStage` (stage) or `FDWeb` (live) |
     | `PRODUCTION_URL` | `https://foodirect.quasarsolutions.com` (no trailing slash) |
     | `STAGING_PORT` | *(optional)* default `8088`; must match `vm-setup.ps1 -StagingPort` |
     | `LOCAL_HEALTH_URL` | *(optional)* override the on-VM live check. By default it calls `127.0.0.1` with the site's host name. |
   Deploys only ever run from `main` (enforced in the workflow). On **GitHub Free**, private repos cannot use
   environment protection (required reviewers, branch rules), so `DEPLOY_ENABLED` is the on/off switch. With
   **GitHub Pro/Team**, add *Required reviewers* on **Settings > Environments > production** to approve each deploy.
3. **Settings > Branches > Add rule** for `main` (needs GitHub Pro/Team on a private repo): require a pull request and
   require the status check **Build & test**.
4. **Settings > Actions > General > Workflow permissions**: *Read repository contents* (the default).

> **Self-hosted runner security.** The runner can run anything a workflow tells it to, as LocalSystem on the
> production VM. In this repo only the `deploy` job targets it, and only for `main`. However, anyone with **write
> access** to the repository could push a workflow that targets it. Keep the repository private, limit
> collaborators to people you'd trust with admin on the VM, and require PR reviews on `main`.

### 4b. The VM (run once, in an elevated PowerShell on the VM)
1. In GitHub: **Settings > Actions > Runners > New self-hosted runner > Windows**. Copy only the **token** from the
   `config.cmd --token XXXX` line. It is valid for 1 hour.
2. Copy `deploy\vm-setup.ps1` to the VM, then:

```powershell
.\vm-setup.ps1 -SiteName FDWebStage -GitHubRepo mesposito2/FoodirectNextGen -RunnerToken XXXX -WhatIf   # preview, changes nothing
.\vm-setup.ps1 -SiteName FDWebStage -GitHubRepo mesposito2/FoodirectNextGen -RunnerToken XXXX           # apply
```

What it does (it never changes the site's bindings, certificate or app pool settings):

| Creates | Purpose |
|---|---|
| `C:\Foodirect\<site>\releases\` | One folder per deployed build |
| `C:\Foodirect\<site>\shared\config\Web.secrets.config` | Built from the live site's current `Web.config` app settings, so production keeps today's paths and URLs. You are prompted for `FD_ENCRYPTION_KEY` and `LOGIN_COOKIE_KEY`: they must equal the legacy values (`FDShared\SecurityCore.Fallback.cs` / `UI\Objects\CookieHelper.Fallback.cs` on the owner's PC) or no one can log in. |
| `C:\Foodirect\<site>\shared\config\connectionStrings.config` | Copied from the live site's `Web.config` (`FD`, `FDAS400_*`) |
| `C:\Foodirect\<site>\shared\AdUpload\` + `/AdUpload` virtual directory | Uploaded ads and email-blast files. Existing ones are copied in; they now survive deployments. |
| IIS site `<site>-staging` on `127.0.0.1:8088` | Private pre-switch check; loopback only, stopped between deploys |
| Windows service `actions.runner.*` (LocalSystem) | The GitHub runner, label `foodirect-iis`, in `C:\Foodirect\runner` (one runner for all sites on the VM) |

The config folder is readable only by Administrators, SYSTEM and the app pool identity. The script prints the GitHub
variables to set. Afterwards, open `C:\Foodirect\<site>\shared\config\Web.secrets.config` and check the values. Any app setting
there overrides `Web.Release.config`, and `{RELEASE}` means "the current release folder".

Check **GitHub > Settings > Actions > Runners**: the runner shows **Idle**.

---

## 5. Verify the first deployment

1. Merge a PR into `main` (or **Actions > CI/CD > Run workflow** on `main`).
2. Make sure `DEPLOY_ENABLED` is `true`. If you set a required reviewer (Pro/Team): **Actions > the run > Review deployments > Approve**.
3. **GitHub > Actions > CI/CD > the run**: all three jobs green. The *Deploy to IIS VM* log shows the staging check,
   the switch and the production check. **Code > Environments > production** lists every deployment.
4. Open `https://foodirect.quasarsolutions.com/health`: expect `"status":"Healthy"`. Open `/version.txt`: the commit
   SHA matches.
5. Smoke test: home page, log in, open Products, download an order PDF, open an ad image under `/AdUpload/`.

**Where to look**

| What | Where |
|---|---|
| Live URL | `https://foodirect.quasarsolutions.com` |
| Pipeline logs | GitHub > **Actions** > run > job > step |
| Which build is live | `/version.txt`, or on the VM `C:\Foodirect\<site>\releases\current.txt` |
| Runner status / logs | GitHub > Settings > Actions > Runners; on the VM `C:\Foodirect\runner\_diag\` |
| IIS request logs | VM: `C:\inetpub\logs\LogFiles\W3SVC<site id>\` |
| App errors | DB table `v5WebLog`; VM: Event Viewer > Windows Logs > Application (source *ASP.NET 4.0*) |

**Roll back** (pick one):
- On the VM (elevated): `.\iis-rollback.ps1 -SiteName FDWebStage` returns to the previous build. Or run it with `-List`,
  then `-Release <folder>`. It takes effect in seconds. The script is in `deploy\` in the repo, and also inside every
  downloaded artifact.
- In GitHub: re-run the **Deploy to IIS VM** job of an earlier good run. It reinstalls that run's artifact.

---

## 6. Secrets policy
- Real secrets live only in `UI/Web.secrets.config` and the `*.Fallback.cs` files (local, git-ignored), and on the VM in
  `C:\Foodirect\<site>\shared\config` (locked down, never in Git or GitHub).
- The unit tests fail the build if a secret value reappears in `Web.config`/`Web.Release.config`, if connection strings
  become inline in the Release transform or contain a password, or if a SendGrid key, reCAPTCHA secret, SQL login
  password or `...KEY = "..."` constant is hardcoded in source.
- These values existed in plain text in local files before this repo was created: the SendGrid key, Azure SQL `FDSQL`
  password, AS400 `TRANSFER` password and reCAPTCHA secret. They were never committed. Rotating them is still good practice.
