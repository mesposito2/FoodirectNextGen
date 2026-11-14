using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessObjects;
using u = CSA.UTILITY.MyUtility;

using System.Web.UI;

namespace UI.OBJECTS
{
    public class LogHelper
    {
   
        public static void WebLogAdd(WebMsgType type, string message, WebLogAction action,bool isAjax=false, bool isNotFound=false)
        {
           string user="";
           if (SecurityHelper.IsAuthenticated())
           {
               user = SecurityHelper.UserName;
           }

            var REMOTE_ADDR = u.ObjToString(HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
            var HTTP_HOST = u.ObjToString(HttpContext.Current.Request.ServerVariables["HTTP_HOST"]);
            var SCRIPT_NAME = u.ObjToString(HttpContext.Current.Request.ServerVariables["SCRIPT_NAME"]);
            var HTTP_REFERER = u.ObjToString(HttpContext.Current.Request.ServerVariables["HTTP_REFERER"]);
            var HTTP_USER_AGENT = u.ObjToString(HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"]);
            var HTTPS = u.ObjToString(HttpContext.Current.Request.ServerVariables["HTTPS"]);
            var responseCode = u.ObjToInt(HttpContext.Current.Response.StatusCode);

            V5WebLogBO.AddLog(
                REMOTE_ADDR,
                type,
                message,
                action,
                user,
                HTTP_HOST+SCRIPT_NAME,
                isAjax,
                HTTP_REFERER,
                HTTP_USER_AGENT,
                HTTPS,
                responseCode,
               isNotFound
                );

            //UNDONE - a Try catch here should go to MyLog
        }
        
       
    }
}