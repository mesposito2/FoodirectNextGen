using System;
using System.Configuration;
using u = CSA.UTILITY.MyUtility;
using System.Collections.Generic;


/// <summary>
/// Summary description for MyConfig.
/// </summary>

namespace UI.OBJECTS
{
    public class Config
    {


        public Config()
        {


        }


        public static string LOCALURL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["LOCALURL"]);
            }
        }


        //http://foodirectdoc.quasarsolutions.com/productbook
        public static string BOOKURL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["BOOKURL"]);
            }
        }


        public static int AS400_INV_BATCH
        {
            get
            {
                return u.ObjToInt(ConfigurationManager.AppSettings["AS400_INV_BATCH"]);
            }
        }

        public static string AS400_EOW_SQL_SET
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["AS400_EOW_SQL_SET"]);
            }
        }
        public static string AS400_EOW_SQL_GET
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["AS400_EOW_SQL_GET"]);
            }
        }




        public static string AS400_INV_SQL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["AS400_INV_SQL"]);
            }
        }

        public static string AS400APIURI
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["AS400APIURI"]);
            }
        }

        public static string SITEURL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SITEURL"]);
            }
        }
        public static string SSL_SITEURL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SSL_SITEURL"]);
            }
        }


        public static string APPSERVERLOGPATH
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["APPSERVERLOGPATH"]);
            }

        }

        public static string ORDERCUTOFF
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["ORDERCUTOFF"]);
            }

        }
        public static String  PRODUCECUTOFF
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["PRODUCECUTOFF"]);
            }

        }
        public static string PRODUCECATID
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["PRODUCECATID"]);
            }

        }
        public static string AUTHORNAME
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["AUTHORNAME"]);
            }

        }
        public static string APPLICATION
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["APPLICATION"]);
            }

        }
       
        public static string EXPERTPDF
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["EXPERTPDF"]);
            }

        }
        public static bool ENFORCESSL
        {
            get
            {
                return u.ObjToBool(ConfigurationManager.AppSettings["ENFORCESSL"]);
            }

        }
        
        public static string TEMPEXPORTPATH
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["TEMPEXPORTPATH"]);
            }

        }
        public static string ADUPLOADPATH
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["ADUPLOADPATH"]);
            }

        }

        public static string  ADUPLOADWEBPATH
        {

            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["ADUPLOADWEBPATH"]);
            }

        }

        public static bool EMAILON
        {
            get
            {
                return u.ObjToBool(ConfigurationManager.AppSettings["EMAILON"]);
            }

        }


        public static int WEBPONUMSTART
        {
            get
            {
                return u.ObjToInt(ConfigurationManager.AppSettings["WEBPONUMSTART"]);
            }

        }
            
        public static bool GLOBALCANORDER
        {
            get
            {
                return u.ObjToBool(ConfigurationManager.AppSettings["CANORDER"]);
            }

        }
        
        public static bool REALINVENTORYFETCH
        {
            get
            {
                return u.ObjToBool(ConfigurationManager.AppSettings["REALINVENTORYFETCH"]);
            }

        }
        public static string INSTANCENAME
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["InstanceName"]);
            }
        }
        public static string BUSINESSEMAIL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["BUSINESSEMAIL"]);
            }

        }
        public static string WEBMASTEREMAIL
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["WEBMASTEREMAIL"]);
            }

        }
        public static string SMTPUSER
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SMTPUSER"]);
            }
        }
        public static string SMTPPWD
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SMTPPWD"]);
            }
        }
        /// <summary>Google reCAPTCHA server-side secret (Contact form). Secret: set via App Service setting / Web.secrets.config.</summary>
        public static string RECAPTCHA_SECRET
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["RECAPTCHA_SECRET"]);
            }
        }
        public static string SMTPSERVER
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SMTPSERVER"]);
            }
        }
        public static string SMTPPORT
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["SMTPPORT"]);
            }
        }
        public static string LogPath
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["Logpath"]);
            }
        }
        public static string EmailPath
        {
            get
            {
                return u.ObjToString(ConfigurationManager.AppSettings["EmailPath"]);
            }
        }
        public static List<string> AS400APIWHITELIST
        {
            get
            {
                var s= u.ObjToString(ConfigurationManager.AppSettings["AS400APIWHITELIST"]);
                return u.TextToArray(s,',');
            }
        }

        

    }
}