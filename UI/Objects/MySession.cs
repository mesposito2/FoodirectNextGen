using System;
using System.Configuration;
using u = CSA.UTILITY.MyUtility;
using System.Web;
using System.Web.UI;

	/// <summary>
	/// Summary description for MyConfig.
	/// </summary>

namespace UI.OBJECTS
{
    public class MySession
    {


        public MySession()
        {

        }
        public static MODELS.PersonXParmsModel LASTPERSONSXPARM
        {
            get
            {
                 var c= (MODELS.PersonXParmsModel)HttpContext.Current.Session["LASTPERSONSXPARM"];
                return c;
            }
            set
            {
                HttpContext.Current.Session["LASTPERSONSXPARM"] = value;
            }

        }


        public static System.Exception LASTEXCEPTION
        {
            get
            {
                System.Exception i= null;
                if (HttpContext.Current.Session != null)
                {
                    i = HttpContext.Current.Session["LASTEXCEPTION"] as System.Exception;
                }
                return i;
            }
            set
            {
                if (HttpContext.Current.Session != null)
                {
                    HttpContext.Current.Session["LASTEXCEPTION"] = value;
                }
            }
        }

        public static int ORDERID
        {
              get
            {
                var i = u.ObjToInt(HttpContext.Current.Session["ORDERID"]);
                return i;
            }
            set
            {
                HttpContext.Current.Session["ORDERID"] = value;
            }
        
        }
        public static string SQL
        {
            get
            {
                string id = "";
                if (HttpContext.Current.Session != null)
                {
                    id = u.ObjToString(HttpContext.Current.Session["SQL"]);
                }
                return id;
            }
            set
            {
                HttpContext.Current.Session["SQL"] = value;
            }
        }

        public static string AUTHTOKEN
        {
            get
            {
                string id = "";
                if (HttpContext.Current.Session != null)
                {
                    id = u.ObjToString(HttpContext.Current.Session["AUTHTOKEN"]);
                }
                return id;
            }
            set
            {
                HttpContext.Current.Session["AUTHTOKEN"] = value;
            }
        }
        public static string LASTPRODSQL
        {
            get
            {
                string val = "";
                if (HttpContext.Current.Session != null)
                {
                    val = u.ObjToString(HttpContext.Current.Session["LASTPRODSQL"]);
                }
                return val;
            }
            set
            {
                HttpContext.Current.Session["LASTPRODSQL"] = value;
            }
        }
    }
}
