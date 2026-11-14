using System;
using System.Collections.Generic;
using System.Configuration;
using u = CSA.UTILITY.MyUtility;
using System.Web;
using System.Web.Security;
using e = CSA.UTILITY.MyEncrypt;

namespace UI.OBJECTS
{
    public partial class CookieHelper
    {

        public const string LOGINCOOKIENAME = "TURBO9000";

        /// <summary>
        /// Key for the "remember me" login cookie. Not in source control: comes from the
        /// LOGIN_COOKIE_KEY app setting, else the untracked local CookieHelper.Fallback.cs.
        /// Must stay equal to the old value or existing remember-me cookies stop working.
        /// </summary>
        public static string LOGINCOOKIEKEY
        {
            get
            {
                string key = ConfigurationManager.AppSettings["LOGIN_COOKIE_KEY"];
                if (string.IsNullOrEmpty(key)) { GetFallbackCookieKey(ref key); }
                if (string.IsNullOrEmpty(key))
                {
                    throw new ConfigurationErrorsException("LOGIN_COOKIE_KEY app setting is not configured.");
                }
                return key;
            }
        }

        static partial void GetFallbackCookieKey(ref string key);

        public CookieHelper()
        {


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static bool HasLoginCookie(HttpRequestBase request)
        {

            HttpCookie cookie = null;
            foreach (string key in request.Cookies.Keys)
            {
                if (key == LOGINCOOKIENAME)
                    cookie = request.Cookies[key];

            }
            if (cookie == null)
                return false;

            string temp = u.ObjToString(cookie.Value);
            if (temp == string.Empty)
                return false;

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="server"></param>
        /// <param name="UID"></param>
        /// <param name="PWD"></param>
        public static void GetLoginCookie(HttpRequestBase request, HttpServerUtilityBase server, ref string UID, ref string PWD)
        {
            UID = "";
            PWD = "";

            if (HasLoginCookie(request))
            {
                HttpCookie cookie = request.Cookies[LOGINCOOKIENAME];
                string temp = server.UrlDecode(u.ObjToString(cookie.Value));
                List<string> a = u.TextToArray(temp, ':');
                if (a.Count > 0)
                    UID = e.DecryptText(a[0], LOGINCOOKIEKEY); 
                if (a.Count > 1)
                    PWD = e.DecryptText(a[1], LOGINCOOKIEKEY);
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="server"></param>
        /// <param name="UID"></param>
        /// <param name="PWD"></param>
        public static void SetLoginCookie(HttpResponseBase response, HttpServerUtilityBase server, string UID, string PWD)
        {
            string cookieValue = string.Format("{0}:{1}", e.EncryptText(UID, LOGINCOOKIEKEY), e.EncryptText(PWD, LOGINCOOKIEKEY));
            HttpCookie cookie = new HttpCookie(LOGINCOOKIENAME, server.UrlEncode(cookieValue));
            cookie.Path = "/";
            cookie.Expires = new DateTime(2100, 1, 1);

            response.Cookies.Add(cookie);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public static void ClearLoginCookie(HttpResponseBase response)
        {

            HttpCookie cookie = new HttpCookie(LOGINCOOKIENAME, "");
            response.Cookies.Add(cookie);
        }

        
    }
}