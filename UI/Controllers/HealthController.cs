using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace UI.Controllers
{
    /// <summary>
    /// GET /health - lightweight readiness probe used by the CI/CD pipeline after deployment.
    /// Returns 200 when the app is running, the FD database answers and both legacy keys
    /// (FD_ENCRYPTION_KEY, LOGIN_COOKIE_KEY) are configured; otherwise 503. Never returns secrets or connection details.
    /// Deliberately does not derive from BaseController (no session/auth/SSL redirects).
    /// </summary>
    [OutputCache(NoStore = true, Duration = 0)]
    public class HealthController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            bool dbOk = false;
            string dbError = null;
            try
            {
                var cs = ConfigurationManager.ConnectionStrings["FD"];
                using (var cn = new SqlConnection(cs == null ? "" : cs.ConnectionString))
                using (var cmd = new SqlCommand("SELECT 1", cn))
                {
                    cn.Open();
                    cmd.CommandTimeout = 10;
                    dbOk = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                }
            }
            catch (Exception ex)
            {
                dbError = ex.GetType().Name;
            }

            bool keyOk = FDSHARED.SecurityCore.IsKeyConfigured;
            bool cookieKeyOk;
            try { cookieKeyOk = !string.IsNullOrEmpty(UI.OBJECTS.CookieHelper.LOGINCOOKIEKEY); }
            catch (ConfigurationErrorsException) { cookieKeyOk = false; }
            bool healthy = dbOk && keyOk && cookieKeyOk;

            Response.StatusCode = healthy ? 200 : 503;
            Response.TrySkipIisCustomErrors = true;
            return Json(new
            {
                status = healthy ? "Healthy" : "Unhealthy",
                version = UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString(),
                instance = UI.OBJECTS.Config.INSTANCENAME,
                checks = new
                {
                    database = dbOk ? "ok" : "failed" + (dbError == null ? "" : " (" + dbError + ")"),
                    encryptionKey = keyOk ? "ok" : "missing",
                    loginCookieKey = cookieKeyOk ? "ok" : "missing",
                    pdfLicense = string.IsNullOrEmpty(UI.OBJECTS.Config.EXPERTPDF) ? "missing" : "ok",
                    smtp = string.IsNullOrEmpty(UI.OBJECTS.Config.SMTPPWD) ? "missing" : "ok",
                    recaptcha = string.IsNullOrEmpty(UI.OBJECTS.Config.RECAPTCHA_SECRET) ? "missing" : "ok"
                },
                utc = DateTime.UtcNow.ToString("o")
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
