using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using csa = CSA.UTILITY;
using u = CSA.UTILITY.MyUtility;

using EntitySpaces.Interfaces;
using EntitySpaces.LoaderMT;


namespace UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Unclear how this helps or hinders with error handling
            //Check out the Global.asax file for more information on how we are doing 
            //this. 
            //filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
           

            routes.MapHttpRoute(
                name: "XApi",
                routeTemplate: "XAPI/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapPageRoute("DefaultHtml", "", "~/default.html");
        }

        protected void Application_Start()
       {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);



            //From Config
            //entity spaces set up
            esConnectionElement conn = new esConnectionElement();
            string cs = u.ObjToString(ConfigurationManager.ConnectionStrings["FD"]);
            conn.ConnectionString = cs;

            conn.Name = "FD";


            conn.Provider = "EntitySpaces.SqlClientProvider";

            conn.ProviderClass = "DataProvider";
            conn.SqlAccessType = esSqlAccessType.DynamicSQL;
            conn.ProviderMetadataKey = "esDefault";

            //get from config
            conn.DatabaseVersion = "2008";

            esConfigSettings.ConnectionInfo.Connections.Add(conn);
            esConfigSettings.ConnectionInfo.Default = "FD";

            esProviderFactory.Factory = new esDataProviderFactory();
        }

        /// <summary>
        /// Custom errors in config - works - but controller never envoked. 
        /// Adding the error filter does not work at all
        /// And we can use the controlller error default event - but this needs to be global
        /// So go back to the whole asp.net method. And trap the error and redirect. 
        /// Unclea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void Application_Error(object sender, EventArgs e)
        {
            System.Exception ex = Server.GetLastError();

            var isAjax = IsAjaxRequest();


            var msg = "";
            
            int cErrorCode404 = -2147467259;
            var errorCode = 0;
            msg = "Application Error - No Exception";
        
            if (ex != null)
            {
                msg = "Application Error - " + ex.ToString();

                var hx = ex as HttpException;
                if (hx != null)
                {
                    errorCode = hx.ErrorCode;
                }
            }

            var isNotFound = HttpContext.Current.Response.StatusCode == 404;//|| errorCode == cErrorCode404;
            OBJECTS.LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.SYSTEM_ERROR,isAjax,isNotFound);
            OBJECTS.MySession.LASTEXCEPTION = ex;
            Response.Clear();
            Server.ClearError();

            //We check if we have an AJAX request and return JSON in this case to he Screen and don't redirect.
            if (isAjax)
            {
                Response.Write("Ajax Error - " + msg);
                //Not clear what GUI stuff we should do here.... just log it and kill for now... 
            }
            else
            {
                //if  real error go to out error page - that will shopw the last exception 
                if (!isNotFound)
                {
                    Response.Redirect("/home/error", true);
                }
                else
                {
                    Response.Redirect("/home/Error404", true);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsAjaxRequest()
        {
            //The easy way
            bool isAjaxRequest = (Request["X-Requested-With"] == "XMLHttpRequest")
            || ((Request.Headers != null)
            && (Request.Headers["X-Requested-With"] == "XMLHttpRequest"));

            //If we are not sure that we have an AJAX request or that we have to return JSON 
            //we fall back to Reflection
            if (!isAjaxRequest)
            {
                try
                {
                    //The controller and action
                    string controllerName = Request.RequestContext.
                                            RouteData.Values["controller"].ToString();
                    string actionName = Request.RequestContext.
                                        RouteData.Values["action"].ToString();

                    //We create a controller instance
                    DefaultControllerFactory controllerFactory = new DefaultControllerFactory();
                    Controller controller = controllerFactory.CreateController(
                    Request.RequestContext, controllerName) as Controller;

                    //We get the controller actions
                    ReflectedControllerDescriptor controllerDescriptor =
                    new ReflectedControllerDescriptor(controller.GetType());
                    ActionDescriptor[] controllerActions =
                    controllerDescriptor.GetCanonicalActions();

                    //We search for our action
                    foreach (ReflectedActionDescriptor actionDescriptor in controllerActions)
                    {
                        if (actionDescriptor.ActionName.ToUpper().Equals(actionName.ToUpper()))
                        {
                            //If the action returns JsonResult then we have an AJAX request
                            if (actionDescriptor.MethodInfo.ReturnType
                            .Equals(typeof(JsonResult)))
                                return true;
                        }
                    }
                }
                catch
                {

                }
            }

            return isAjaxRequest;
        }
    }
}
