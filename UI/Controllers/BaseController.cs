using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using UI.OBJECTS;
using u = CSA.UTILITY.MyUtility;

namespace UI.Controllers
{
    public abstract class BaseController : Controller
    
    {

        protected string expandFullUrlPath(string path,string host="",bool honorHTTPS=true)
        {

            //only work for this web-site
            path = path.Replace("http://", "");
            path = path.Replace("https://", "");
            path = path.Replace("www", "");
            string h = "http://";
            if (honorHTTPS)
            {
                if (Request.ServerVariables["HTTPS"] == "ON")
                {
                    h = "https://";
                }
            }

            if (host=="")
            {
                host = Request.ServerVariables["HTTP_HOST"];
            }

            path = h + host + path;
            return path;
        }
        /// <summary>
        /// Make sure we are in ssl
        /// Also make sure we hit cloud flare with www.foodirect.com
        /// </summary>
        protected void ensureSSL()
        {


            //4/13/2022 - This should now be completely controlled by cloud flarew
            //Both https and utilizing www (i.e. blocking http://foodirect.com
            //so don't even process this now
            //return;
            //12/4/2023 - Actually do use this and if mot needed turn off in the config file. 
            //But only redirect of they are accessing from www.foodirect.com



            bool enforceHttps = OBJECTS.Config.ENFORCESSL;
            if (!enforceHttps)
                return;

            Response.Buffer = true;
            string temp = u.ObjToString(Request.ServerVariables["HTTPS"]).Trim();

            string host = Request.ServerVariables["HTTP_HOST"].ToLower();

            //This one was also redirecting people who access the site with http://foodirect.com no www. 
            //if (temp.ToUpper() == "OFF" || temp == string.Empty || host.IndexOf("www")<0)

            //this one - if not in HTTPs and - they accessed it via the www.foodirect.com = 
            //so leave when accessing via non-ssl internally alone
            if ((temp.ToUpper() == "OFF" || temp == string.Empty) && host.IndexOf("www.foodirect.com")==0)
            {

                String redirect = "";
                string queryString = "";


                //This is cool every domain name we pointed at Foodirect has its own Cert. 
                //But lets not do that and direc to the real deal cert.... wich is foodirect.com
                //redirect += "https://" + Request.ServerVariables["SERVER_NAME"];

                var t = u.Chop(Config.SSL_SITEURL);
                redirect = t+Request.ServerVariables["SCRIPT_NAME"];
                queryString = Request.ServerVariables["QUERY_STRING"];
        
                if (!queryString.Equals(""))
                {

                    redirect += "?" + queryString;
                }

                LogHelper.WebLogAdd(WebMsgType.WAR, "ENSURE SSL - HTTPS Redirect Info: HTTPS Flag: '" + temp + "' - Host: " + host + " - Redirect URL: " + redirect, WebLogAction.INFO);


                //Response.Write(redirect);
                Response.Redirect(redirect);
                Response.End();


            }
        }
        /// <summary>
        /// Make sure we are not in SSL
        /// </summary>
        protected void ensureNonSSL()
        {
            Response.Buffer = true;
            string temp = u.ObjToString(Request.ServerVariables["HTTPS"]).Trim();

            if (temp.ToUpper() == "ON")
            {

                String redirect = "";
                string queryString = "";
                redirect = "http://" + Request.ServerVariables["SERVER_NAME"] +
                    //redirect = "https://" + "www.relishsecure.com" +
                Request.ServerVariables["SCRIPT_NAME"];
                queryString = Request.ServerVariables["QUERY_STRING"];

                if (!queryString.Equals(""))
                {

                    redirect += "?" + queryString;
                }
                Response.Redirect(redirect);

            }
        }


        public void RedirectAccessDenied(string msg = "")
        {
            msg = HttpUtility.UrlEncode(msg);
            Response.Redirect("/Home/AccessDenied?msg=" + msg,true);
           
        }

        public void SetDisplayMsg(WebMsgType type, string msg, WebLogAction action)
        {
            ViewBag.DisplayMsgType = type.ToString();
            ViewBag.DisplayMsg = msg;
            LogHelper.WebLogAdd(type, msg, action);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        protected string makeFilterExpression(MODELS.GridFilters filter)
        {
            //quick logic for filter  - UNDONE - Cleanup 
            string filterExpression = "";
            if (filter != null)
            {
                var ictr = 0;
                foreach (var f in filter.Filters)
                {
                    var op = "";
                    var val = f.Value;
                    switch (f.Operator)
                    {
                        case "eq":
                            op = "=";
                            break;
                        case "neq":
                            op = "<>";
                            break;
                        case "gt":
                            op = ">";
                            break;
                        case "lt":
                            op = "<";
                            break;
                        case "contains":
                            op = " like ";
                            val = "%" + val + "%";
                            break;
                        case "doesnotcontain":
                            op = " not like ";
                            val = "%" + val + "%";
                            break;
                        case "startswith":
                            op = " like ";
                            val = val + "%";
                            break;
                        case "endswith":
                            op = " like ";
                            val = "%" + val;
                            break;
                    }
                    filterExpression += "(" + f.Field + " " + op + " '" + val + "')";

                    if (ictr < filter.Filters.Count() - 1)
                    {
                        filterExpression += " " + filter.Logic + " ";
                    }
                    ictr++;
                }
            }
            return filterExpression;
        }
        
    }
}