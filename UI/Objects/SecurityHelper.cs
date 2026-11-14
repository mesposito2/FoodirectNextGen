using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using u = CSA.UTILITY.MyUtility;
using BusinessObjects;





namespace UI.OBJECTS
{
    /// <summary>
    /// Security Helper Class
    /// </summary>
    public class SecurityHelper
    {


        public static void ThrowAPIBadSourceIP()
        {

            var whitelist = Config.AS400APIWHITELIST;
            var sourceIP = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            var b = whitelist.Exists(element => element == sourceIP);
            if (!b)
            {
                var msg = "The Source IP of the request: " + sourceIP + " is not permitted to access this URL.";
                LogHelper.WebLogAdd(WebMsgType.ERR, msg, WebLogAction.SYSTEM_ERROR);
                throw new ApplicationException(msg);
            }
            else
            {
                var msg = sourceIP + " permitted to access this URL.";
                LogHelper.WebLogAdd(WebMsgType.OK, msg, WebLogAction.INFO);

            }



            return;
        }

/// <summary>
        /// Get User Name from Encrypted Session Token
        /// </summary>       
        public static string UserName
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 0)
                {
                    return a[0];
                }
                else
                {
                    return "";
                }

            }
        }

        public static string BizName
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 0)
                {
                    return a[1];
                }
                else
                {
                    return "";
                }
            }
        }


        public static OBJECTS.Roles Role
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 1)
                {
                    return (OBJECTS.Roles)Enum.Parse(typeof(OBJECTS.Roles), a[2], true);
                }
                else
                {
                    return OBJECTS.Roles.GUEST;
                }

            }
        }
        public static string CustID
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 3)
                {
                    return a[3];
                }
                else
                {
                    return "";
                }
            }
        }
        public static bool MemberCanOrder
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 4)
                {
                    return u.ObjToBool(a[4]);
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool MemberCanViewInventory 
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 5)
                {
                    return u.ObjToBool(a[5]);
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool ForceOrderGuide
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 5)
                {
                    return u.ObjToBool(a[6]);
                }
                else
                {
                    return false;
                }
            }
        }
        public static string ChainCode
        {
            get
            {
                var a = getDecryptedTokenList();
                if (a.Count > 6)
                {
                    return u.ObjToString(a[7]);
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool MemberShowNonOrderGuide
        {
            get
            {
                return 
                     UI.OBJECTS.SecurityHelper.ChainCode == "" || 
                     //has a chain - is not forced.... 
                     (UI.OBJECTS.SecurityHelper.ChainCode != "" &&  !UI.OBJECTS.SecurityHelper.ForceOrderGuide);

            }
                           
        }




        /// <summary>
        /// et the actaul Token
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="bizName"></param>
        /// <param name="role"></param>
        /// <param name="custID"></param>
        /// <param name="canOrder"></param>
        /// <param name="canViewInventoryDetails"></param>
        /// <param name="forceOrderGuide"></param>
        /// <param name="chainCode"></param>
        static void setEncryptedToken(string userName, string bizName, OBJECTS.Roles role, string custID, bool canOrder,bool canViewInventoryDetails, bool forceOrderGuide,string chainCode)
        {
            string s = userName + "|" + bizName + "|" + role.ToString() + "|" + custID + "|" + ((canOrder) ? "1" : "0") + "|" + ((canViewInventoryDetails) ? "1" : "0")+ "|" + ((forceOrderGuide) ? "1" : "0") + "|"+ chainCode  ;
            string token = FDSHARED.SecurityCore.EncryptText(s);
            MySession.AUTHTOKEN = token;
        }
        static List<string> getDecryptedTokenList()
        {
            var s = FDSHARED.SecurityCore.DecryptText(MySession.AUTHTOKEN);
            return u.TextToArray(s, '|');
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool VerifyAccess(OBJECTS.Roles role)
        {

            if (UserName == string.Empty)
            {
                HttpContext.Current.Response.Redirect("~/Membership/Login");
                return false;
            }
            if (!(SecurityHelper.Role == OBJECTS.Roles.ADMIN || role == SecurityHelper.Role))
            {
                HttpContext.Current.Response.Redirect("~/Home/AccessDenied");
                return false;
            }

            return true;

        }

        /// <summary>
        /// Is the current session authenticated. 
        /// </summary>
        /// <returns></returns>
        public static bool IsAuthenticated()
        {
            return (MySession.AUTHTOKEN != "");
        }
        public static bool IsAdmin()
        {
            return SecurityHelper.Role == Roles.ADMIN;
        }
        public static bool IsMember()
        {
            return SecurityHelper.Role == Roles.MEMBER;
        }
       
        public static bool IsSales()
        {
            return SecurityHelper.Role == Roles.SALES;
        }
        public static bool CANORDER
        {
            get
            {
                return u.ObjToBool(Config.GLOBALCANORDER && SecurityHelper.Role == Roles.MEMBER && MemberCanOrder);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool Login(string userName, string password, ref string message)
        {
            bool retVal = true;
            var x = new BusinessObjects.UsersBO();
            if (!x.LoadByInternetID(userName))
            {
                message = "The password or user name was not found.";
                return false;
            }
            //
            var dpw = FDSHARED.SecurityCore.DecryptText(x.Password);


            if (dpw.ToUpper() != password.Trim().ToUpper())
            {
                message = "The password or user name was not found.";
                return false;

            }


         
            //is 
            if (x.Flags.Value == 2)
            {
                message = "The account is no longer active.";
                return false;
            }
            else if (x.Flags == 1)
            {
                message = "This account does not have web access.";
                return false;

            }

            //these should all go into an encrypted cookie
            var role = OBJECTS.Roles.MEMBER;
            if (x.Type == u.ObjToInt(OBJECTS.FDLegacyRoles.AMM_FDADMIN))
            {
                role = OBJECTS.Roles.ADMIN;
            }
            //12/9/2017 - add sales
            else if (x.Type == u.ObjToInt(OBJECTS.FDLegacyRoles.AMM_SFSALES))
            {
                role = OBJECTS.Roles.SALES;
            }

            //finally set token
            var co = x.CanOrder.HasValue ? u.ObjToBool(x.CanOrder.Value) : false;
            var ci= x.CanViewInventoryDetails.HasValue ? u.ObjToBool(x.CanViewInventoryDetails.Value) : false;
            var cog = x.UseProdCustGuide.HasValue ? u.ObjToBool(x.UseProdCustGuide.Value) : false;

            setEncryptedToken(x.Internetid, x.Bizname, role, x.Custid, co,ci,cog,x.ChainCode);

            return retVal;
        }
        public static void Logout()
        {
            MySession.AUTHTOKEN = "";
        }

        /// <summary>
        /// Encrypt Text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Encrypt(string s)
        {
            return FDSHARED.SecurityCore.EncryptText(s);
        }
        /// <summary>
        /// Decrypt Text
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Decrypt(string s)
        {
            return FDSHARED.SecurityCore.DecryptText(s);
        }
        public static void ThrowSQLInjection(params string[] strings)
        {
            if (IsSQLInjection(strings))
            {
                throw new ApplicationException("Danger Danger Will Robinson - Request Does Not Compute");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool IsSQLInjection(params string[] strings)
        {
            bool retVal = false;
            foreach (string s in strings)
            {

                if (IsSQLInjectionString(s))
                {
                    retVal = true;
                    break;
                }
            }
            return retVal;
        }
        //
        public static Boolean IsSQLInjectionString(string userInput)
        {
            bool isSQLInjection = false;

            userInput = u.ObjToString(userInput);

            string[] sqlCheckList = { "--",
                                       ";--",
                                       ";",
                                       "/*",
                                       "*/",
                                        "@@",
                                        "@",
                                        "char",
                                       "nchar",
                                       "varchar",
                                       "nvarchar",
                                       "alter",
                                       "begin",
                                       "cast",
                                      /* "create", */
                                       "cursor",
                                       "declare",
                                       "delete",
                                       "drop",
                                       "end",
                                       "exec",
                                       "execute",
                                       "fetch",
                                            "insert",
                                          "kill",
                                             "select",
                                           "sys",
                                            "sysobjects",
                                            "syscolumns",
                                          /* "table" ,*/
                                           "update"
                                       };
            string CheckString = userInput.Replace("'", "''");
            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((CheckString.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    isSQLInjection = true;
                }
            }
            return isSQLInjection;
        }



        /// <summary>
        /// This one is not working that well
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool IsSQLInjectionString2DoNotUse(string inputText)
        {


            bool isInj = false;

            inputText = u.ObjToString(inputText);

            string regexForTypicalInj = @"/\w*((\%27)|(\'))((\%6F)|o|(\%4F))((\%72)|r|(\%52))/ix";
            Regex reT = new Regex(regexForTypicalInj);
            if (reT.IsMatch(inputText))
                isInj = true;


            string regexForUnion = @"/((\%27)|(\'))union/ix";
            Regex reUn = new Regex(regexForUnion);
            if (reUn.IsMatch(inputText))
                isInj = true;



            string regexForSelect = @"/((\%27)|(\'))select/ix";
            Regex reS = new Regex(regexForSelect);
            if (reS.IsMatch(inputText))
                isInj = true;

            string regexForInsert = @"/((\%27)|(\'))insert/ix";
            Regex reI = new Regex(regexForInsert);
            if (reI.IsMatch(inputText))
                isInj = true;

            string regexForUpdate = @"/((\%27)|(\'))update/ix";
            Regex reU = new Regex(regexForUpdate);
            if (reU.IsMatch(inputText))
                isInj = true;

            string regexForDelete = @"/((\%27)|(\'))delete/ix";
            Regex reDel = new Regex(regexForDelete);
            if (reDel.IsMatch(inputText))
                isInj = true;

            string regexForDrop = @"/((\%27)|(\'))drop/ix";
            Regex reDr = new Regex(regexForDrop);
            if (reDr.IsMatch(inputText))
                isInj = true;

            string regexForAlter = @"/((\%27)|(\'))alter/ix";
            Regex reA = new Regex(regexForAlter);
            if (reA.IsMatch(inputText))
                isInj = true;

            string regexForCreate = @"/((\%27)|(\'))create/ix";
            Regex reC = new Regex(regexForCreate);
            if (reC.IsMatch(inputText))
                isInj = true;

            return isInj;

        }
    }
}

