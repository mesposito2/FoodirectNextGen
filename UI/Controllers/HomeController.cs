using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using UI.OBJECTS;
using u = CSA.UTILITY.MyUtility;
using System.Net.Http;
using System.Threading.Tasks;


namespace UI.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult PDF(string path)
        {

            //why do we do this here - can create firewall isses. 
            path = base.expandFullUrlPath(path, Config.LOCALURL,false);

            byte[] pdfBuffer=null;
            string title = "";
            string fileName="";
            string msg = "";
            LogHelper.WebLogAdd(WebMsgType.OK, "DEBUG - PDF Convert Source Path: " + path, WebLogAction.INFO);
            if (!PDFHelper.GetPDFFileBufferFromURL(path,ref pdfBuffer,ref title,ref fileName,ref msg))
            {
                throw new ApplicationException("Could not generate a PDF file view: " + msg);
            }
            return this.File(pdfBuffer, "app/pdf",fileName );
        }
  

        public ActionResult Error()
        {
            //This never seems to get a value. 
            //deal any error handling process in global.asax
            //var x = Server.GetLastError();   
            return View();
        }
        public ActionResult AccessDenied(string msg="")
        {
            ViewBag.AccessDeniedMsg = msg;
            return View();
        }
        public ActionResult Error404(string url)
        {
         
            //Response.StatusCode = 404;
            ViewData["url"] = url;
            return View();
        }
        public ActionResult Employment()
        {
            //ViewBag.Message = "About Foodirect";

            return View();
        }
        public ActionResult CreditApp()
        {
            //ViewBag.Message = "About Foodirect";

            return View();
        }
        public ActionResult CreditApplication()
        {
            //ViewBag.Message = "About Foodirect";

            return View();
        }

        public ActionResult Apply()
        {
            //ViewBag.Message = "About Foodirect";

            return View();
        }
  
        public ActionResult Index()
        {
            ensureSSL();
            return View();
        }
        public ActionResult About()
        {
            
            return View();
        }
        public ActionResult Brochure()
        {
      
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult EmploymentApplication()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult DriverApplication()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Contact(string x)
        {
            ensureSSL();

            string msg = Request["Message"];
            string email = Request["Email"];
            string captcha = u.ObjToString(Request["g-recaptcha-response"]).Trim();

            if (captcha != string.Empty)
            {
                // Now validate the captcha
                //create the data for automatic post
                var data = new Dictionary<string, string>();
                data.Add("grant_type", "authorization_code");
                //server-side secret comes from config (RECAPTCHA_SECRET) - never source control
                data.Add("secret", Config.RECAPTCHA_SECRET);
                data.Add("response", captcha);
                var content = new FormUrlEncodedContent(data);

                //Make a call to the Google api
                var response = await UI.OBJECTS.HTTPHelper.Client.PostAsync("https://www.google.com/recaptcha/api/siteverify", content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (responseString.IndexOf("\"success\": true") > 0)
                {
                    LogHelper.WebLogAdd(WebMsgType.OK, "GOOGLE RECAPTCHA "+responseString, WebLogAction.INFO);
                    if (EmailHelper.SendContactEmail(email, msg))
                    {
                        base.SetDisplayMsg(WebMsgType.OK, email + ", your message was sent OK.", WebLogAction.UIMSG);
                    }
                    else
                    {
                        base.SetDisplayMsg(WebMsgType.ERR, "Your  message could not be sent. Please give us a call.", WebLogAction.UIMSG);
                    }
                }
                else
                {
                    LogHelper.WebLogAdd(WebMsgType.ERR, "ROBOT DETECTED - "+responseString, WebLogAction.SYSTEM_ERROR);
                    base.SetDisplayMsg(WebMsgType.ERR, "It appears you are a ROBOT. Humans only Please.", WebLogAction.UIMSG);
                }
            }
            else
            {
                base.SetDisplayMsg(WebMsgType.ERR, "We can't tell of your a ROBOT. Please give us a call.", WebLogAction.UIMSG);
            }

            return View();
        }

    }
}
