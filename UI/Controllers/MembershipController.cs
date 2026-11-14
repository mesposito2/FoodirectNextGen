using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using UI.OBJECTS;
using u = CSA.UTILITY.MyUtility;
using System.Data;


namespace UI.Controllers
{
    public class MembershipController : BaseController
    {

        public ActionResult MyBillsAmountDue()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var custid = "";

            custid = SecurityHelper.CustID;

            var user = new BusinessObjects.UsersBO();
            if (!user.LoadByPrimaryKey(custid))
            {
                throw new ApplicationException("Could not find user for custid:" + custid);
            }
            //set ager Model
            var a=new MODELS.Ager(user);


            var col = new BusinessObjects.WtaPoCollection();
            DataSet ds = col.GetTop100Bills(custid);

            
            var p = new MODELS.OrdersListModel(ds, user);

            //Create  the encapsulating view model -
            //This is so we can get Total count out where the Kendo Grid can use it 
            var pvm = new MODELS.OrderViewModel();
            pvm.Orders = p;

            pvm.TotalCount = 0;
            pvm.TotalCost = 0;
            pvm.StartDate = DateTime.MinValue;
            pvm.EndDate = DateTime.MinValue;
            pvm.Ager = a;

            return View(pvm);



        }
        public ActionResult MyBills()
        {


            ensureSSL();
            DateTime startDate = u.ObjToDateTime(base.Request["start"]);
            DateTime endDate = u.ObjToDateTime(base.Request["end"]);
            string action=u.ObjToString(base.Request["myAction"]);

            if (startDate == DateTime.MinValue)
            {
                startDate = DateTime.Now;
                endDate = startDate;
            }
           

            if (action == "RANGE")
            {
                //use what came in
            }
            else if (action == "TODAY")
            {
                startDate = DateTime.Now;
                endDate = startDate;

            }
             else if (action=="YESTERDAY")
             {
                 startDate = DateTime.Now.AddDays(-1);
                 endDate = startDate;
             }
            else if (action == "PREVIOUSDAY")
            {
                startDate = startDate.AddDays(-1);
                endDate = startDate;
            }
            else if (action == "NEXTDAY")
            {
                startDate = startDate.AddDays(+1);
                endDate = startDate;
           
            }
            else if (action == "THISWEEK")
            {
                int  dow=(int) DateTime.Now.DayOfWeek;
                startDate = DateTime.Now.AddDays(dow * -1);
                endDate = startDate.AddDays(6);
            }
            else if (action == "LASTWEEK")
            {
                int dow = (int)DateTime.Now.DayOfWeek;
                startDate = DateTime.Now.AddDays((dow+7) * -1);
                endDate = startDate.AddDays(6);
           
            }
            else if (action == "PREVIOUSWEEK")
            {
                int dow = (int)startDate.DayOfWeek;
                startDate = startDate.AddDays((dow + 7) * -1);
                endDate = startDate.AddDays(6);
           
            }
            else if (action == "NEXTWEEK")
            {
                int dow = (int)startDate.DayOfWeek;
                startDate = startDate.AddDays((dow + 7));
                endDate = startDate.AddDays(6);
            }

            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var custid = "";
          
            custid = SecurityHelper.CustID;
           
            double totalCost = 0;
            int totalCount = 0;

            var col = new BusinessObjects.WtaPoCollection();
            DataSet ds = col.GetBills(custid, startDate, endDate, ref totalCount, ref totalCost);

            var user = new BusinessObjects.UsersBO();
            if (!user.LoadByPrimaryKey(custid))
            {
                throw new ApplicationException("Could not find user for custid:" + custid);
            }

            var p = new MODELS.OrdersListModel(ds, user);

            //Create  the encapsulating view model -
            //This is so we can get Total count out where the Kendo Grid can use it 
            var pvm = new MODELS.OrderViewModel();
            pvm.Orders = p;
            pvm.TotalCount = totalCount;
            pvm.TotalCost = totalCost;
            pvm.StartDate=startDate;
            pvm.EndDate=endDate;


            return View(pvm);
        }
        


        public ActionResult MyAccount(string custID)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
            
            if (SecurityHelper.IsMember())
            {
                custID = SecurityHelper.CustID;
            }
          

            var pm = new MODELS.PersonModel(custID);
            return View(pm);
        }
        public ActionResult ContactSalesRep()
        {
            ensureSSL();
            //Get View Bag stuff
            var custID = SecurityHelper.CustID;
            var o = new BusinessObjects.UsersBO();
            if (!o.LoadByCustID(custID))
            {
                throw new ApplicationException("Could not load CustID :" + custID);
            }

            var ini = o.SlmInit;
            var s = new BusinessObjects.V5SalesManBO();

            if (!s.LoadByInitial(ini))
            {
                throw new ApplicationException("Could not load with Salesman INI :" + ini);
            }

            ViewBag.SalesManName = s.Name + " (" + s.Initial + ")";
            //end view bagstuff

            var m = new MODELS.SalesMessageModel();
            return View(m);
        }
        [HttpPost]
        public ActionResult ContactSalesRep(MODELS.SalesMessageModel m)
        {



            ensureSSL();
            if ( EmailHelper.SendSalesmanEmail(SecurityHelper.CustID, m.Message))
            {
                base.SetDisplayMsg(WebMsgType.OK, "Message Sent!", WebLogAction.UIMSG);
            }
            else
            {
                base.SetDisplayMsg(WebMsgType.ERR, "Your sales rep could not be contacted", WebLogAction.UIMSG);
            
            }

            ///Get View Bag stuff
            var custID = SecurityHelper.CustID;
            var o = new BusinessObjects.UsersBO();
            if (!o.LoadByCustID(custID))
            {
                throw new ApplicationException("Could not load CustID :" + custID);
            }

            var ini = o.SlmInit;
            var s = new BusinessObjects.V5SalesManBO();

            if (!s.LoadByInitial(ini))
            {
                throw new ApplicationException("Could not load with Salesman INI :" + ini);
            }

            ViewBag.SalesManName = s.Name + " (" + s.Initial + ")";
            //end view bagstuff


            return View(m);
        }
        public ActionResult Logout()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.Logout();
            return RedirectToAction("Login");

        }

        public ActionResult Login()
        {
            ensureSSL();
           
            var login = new MODELS.LoginModel();
            if (CookieHelper.HasLoginCookie(this.Request))
            {
              
                login.RememberMe = true;
                string UID = string.Empty;
                string PWD = string.Empty;
                CookieHelper.GetLoginCookie(this.Request, this.Server, ref UID, ref PWD);
                login.UserName  = UID;
                login.Password = PWD;
                //txtPWD.Text = PWD;
                //txtPWD.Attributes.Add("value", PWD);
            }

            return View(login);
        }


        [HttpPost]
        public ActionResult Login(MODELS.LoginModel login)
        {
            ensureSSL();
            CookieHelper.ClearLoginCookie(this.Response);
            //some how this is getting thru validation. To a post back 
            if (u.ObjToString(login.UserName).Trim() == "" || u.ObjToString(login.Password).Trim() == "")
            {
                base.SetDisplayMsg(WebMsgType.ERR, "User Name and Password is Required", WebLogAction.BADLOGIN);

            }
            else
            {
                string msg = "";
                if (OBJECTS.SecurityHelper.Login(login.UserName, login.Password, ref msg))
                {

                    if (login.RememberMe)
                    {
                        CookieHelper.SetLoginCookie (this.Response,this.Server,login.UserName,login.Password);
                    }

                    base.SetDisplayMsg(WebMsgType.OK, login.UserName + " : Login OK", WebLogAction.LOGIN);
                    //In this case  the message is never displayed - but will log non the less
                    if (OBJECTS.SecurityHelper.IsSales())
                    {
                        return RedirectToAction("salesproducts", "product");
                    }
                    else
                    {
                        return RedirectToAction("Dashboard");
                    }
                }
                else
                {


                    base.SetDisplayMsg(WebMsgType.WAR, login.UserName + " : " + msg, WebLogAction.BADLOGIN);

                }
            }

            return View(login);
        }


        public ActionResult Register()
        {

            ensureSSL();
            return View();
        }

        /* 11/23/2024 - Don't even have these end points available. Sometimes people try to hack */
        /*
        [HttpPost]
        public ActionResult Register(MODELS.RegisterModel registerModel)
        {
            ensureSSL();
            var r = new BusinessObjects.V5RegisterBO();
            r.BusinessName = registerModel.BusinessName;
            r.BusinessSize = registerModel.BusinessSize;
            r.BestTimeToContact = registerModel.BestTimeToContact;
            r.Address = registerModel.Address;
            r.Address2 = registerModel.Address2;
            r.BusinessType  = registerModel.BusinessType;
            r.City  = registerModel.City;
            r.Country = "US";
            //r.CreateDate  = DateTime.Now()
            r.CreatedBy  = "SYS";
            //r.LastUpdate  = registerModel.BusinessName;
            r.LastUpdateBy  = "SYS";
            r.Email = registerModel.Email;
            r.FName = registerModel.FName;
            r.LName = registerModel.LName;
            r.Password = SecurityHelper.Encrypt(u.ObjToString(registerModel.Password));
            r.State  = registerModel.State;
            r.Phone = registerModel.Phone;
            r.StatusUCode  = "NEW";
            //r.UserName = "";
            r.Zip = registerModel.Zip;
            r.Save();

            //send client email
            EmailHelper.SendRegistrationEmail(r.RegisterID.Value);

            EmailHelper.SendRegistrationAdminEmail(r.RegisterID.Value);

            return RedirectToAction("RegisterConfirm");
        }
        */
        public ActionResult RegisterConfirm()
        {
            ensureSSL(); 
            return View();
        }
        

        public ActionResult PasswordReset()
        {
            ensureSSL(); 
            return View();
        }
        [HttpPost]
        public ActionResult PasswordReset(MODELS.PasswordResetModel passwordreset)
        {

            ensureSSL(); 
            string u = passwordreset.UserName.Trim();
            u = u.Replace(" ", "");
            u = u.ToUpper();
             var user = new BusinessObjects.UsersBO();
             if (!user.LoadByInternetID(u))
             {
                 base.SetDisplayMsg(WebMsgType.WAR, "The user name: " + u + " could not be found.", WebLogAction.UIMSG);
             }
             else
             {
                 if (EmailHelper.SendAdminPasswordResetEmail(user))
                 {
                     base.SetDisplayMsg(WebMsgType.OK, "Technical Support has been contacted. You will be notified shortly about your login information.", WebLogAction.UIMSG);
                 }
                 else
                 {
                     return RedirectToAction("Home", "Error");
                 }
             }
            return View();
          }

 
        /// <summary>
        /// Show dashboard
        /// </summary>
        /// <returns></returns>
        public ActionResult Dashboard()
        {
            ensureSSL();
            //ViewBag.Message = "About Foodirect";
            //OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER );
            if (OBJECTS.SecurityHelper.Role == OBJECTS.Roles.SALES)
            {
                Response.Redirect("/Product/SalesProducts", true);

            }
            if (OBJECTS.SecurityHelper.Role == OBJECTS.Roles.ADMIN)
            {
                Response.Redirect("/Admin/Admin", true);
            }
            else if (!OBJECTS.SecurityHelper.IsAuthenticated())
            {
                Response.Redirect("/Home/AccessDenied", true);
            }

            //Load the user for some one Off Values
            var custid = "";

            custid = SecurityHelper.CustID;

            var user = new BusinessObjects.UsersBO();
            if (!user.LoadByPrimaryKey(custid))
            {
                throw new ApplicationException("Could not find user for custid:" + custid);
            }

            ViewBag.ChainCode = u.ObjToString(user.ChainCode);


            return View();
        }
    }
}
