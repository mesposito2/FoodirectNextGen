using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BusinessObjects;
using UI.OBJECTS;
using u = CSA.UTILITY.MyUtility;
using mh = UI.OBJECTS.MyHelper;
using  System.IO;
using System.Configuration;
using System.Diagnostics;
using EntitySpaces.DynamicQuery;
using System.Data;
using System.Net.Http;
using System.Text.RegularExpressions;


namespace UI.Controllers
{
    public class AdminController : BaseController
    {

        #region MarketingEmailBlast

        public ActionResult MarketingEmailBlast(int? id)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            MODELS.MarketingEmailBlastModel m;
            if (id.HasValue)
            {
                var o = new BusinessObjects.V5EmailBlastBO();
                o.LoadByPrimaryKey(id.Value);
                m = new MODELS.MarketingEmailBlastModel(o);
            }
            else
            {
                m = new MODELS.MarketingEmailBlastModel();
            }

            return View(m);
        }

        [HttpPost]
        public ActionResult MarketingEmailBlast(MODELS.MarketingEmailBlastModel m)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            if (m.ToUCODE == "CUSTOM" && u.ObjToString(m.ToOther).Trim() == string.Empty)
            {
                m.ToOtherValidationMsg = "Custom email address(es) must be entered.";
            }
            else
            {
                //Process 
                //Get the ID
                var item = new BusinessObjects.V5EmailBlastBO();
                if (m.EmailBlastID == 0)
                {
                    item.AddNew();
                    item.CreatedByDate = DateTime.Now;
                    item.CreatedBy = SecurityHelper.UserName;
                }
                else
                {
                    item.LoadByPrimaryKey(m.EmailBlastID);
                }
                item.StatusUCODE = "PENDING";
                item.Subject = m.Subject;
                item.ToUCODE = m.ToUCODE;
                item.ToOther = m.ToOther;
                item.Body = m.Body;
                item.Save();

                return RedirectToAction("MarketingEmailBlastAttach", "Admin", new { id = item.EmailBlastID });

            }
            return View(m);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Required</param>
        /// <returns></returns>
        public ActionResult MarketingEmailBlastAttach(int id)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            var o = new BusinessObjects.V5EmailBlastBO();
            if (!o.LoadByPrimaryKey(id))
            {
                throw new ApplicationException("EmailBlastID with ID : " + id.ToString() + " could not be loaded");
            }
        
            var m = new MODELS.MarketingEmailBlastModel(o);
            return View(m);
        }
        [HttpPost]
        public ActionResult MarketingEmailBlastAttachNav()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            //[HttpPost]
            var emailBlastID = u.ObjToInt(Request["EmailBlastID"]);
            var navAction = u.ObjToString(Request["NavAction"]);

            if (navAction == "PREV")
            {
                return RedirectToAction("MarketingEmailBlast", "Admin", new { id = emailBlastID });

            }
            else if (navAction == "NEXT")
            {
                return RedirectToAction("MarketingEmailBlastConfirm", "Admin", new { id = emailBlastID });

            }
            else
            {
                var o = new BusinessObjects.V5EmailBlastBO();
                o.LoadByPrimaryKey(emailBlastID);
                o.StatusUCODE = "CANCEL";
                o.Save();
                return RedirectToAction("Admin", "Admin");
            }

        }


        [HttpPost]
        public ActionResult MarketingEmailBlastUpload(HttpPostedFileBase file1)
        {

            //[HttpPost]
            var emailBlastID = u.ObjToInt(Request["EmailBlastID"]);

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
           
            if (file1 != null && file1.ContentLength > 0)
            {
                var fileName = Path.GetFileName(MyHelper.CreateHTMLFileName(file1.FileName));
                //note - we should check here if the file already exists 
                //otherwise we will just overwrite. 

                u.MakeDir(Path.Combine(UI.OBJECTS.Config.ADUPLOADPATH, "EmailBlasts",emailBlastID.ToString()));
                var path = Path.Combine(UI.OBJECTS.Config.ADUPLOADPATH,"EmailBlasts", emailBlastID.ToString(), fileName);
                file1.SaveAs(path);

                var bo = new V5EmailBlastAttachmentBO();
                bo.OriginalFileName = fileName;
                bo.EmailBlastID = emailBlastID;
                bo.AttachmentPath = path;
                bo.CreatedBy = UI.OBJECTS.SecurityHelper.CustID;
                bo.CreatedByDate = DateTime.Now;
                bo.Save();
                
                //base.SetDisplayMsg(WebMsgType.OK, fileName + " uploaded OK", WebLogAction.UIMSG);
                //msg = fileName + " uploaded OK!";

            }

            return RedirectToAction("MarketingEmailBlastAttach", "Admin", new { id = emailBlastID });
        }
        [HttpPost]
        public ActionResult MarketingEmailBlastAttachDel()
        {

            //[HttpPost]
            var attachmentID = u.ObjToInt(Request["AttachmentID"]);
            var emailBlastID = u.ObjToInt(Request["EmailBlastID"]);
            var bo = new V5EmailBlastAttachmentBO();
            bo.LoadByPrimaryKey(attachmentID);
            bo.MarkAsDeleted();
            bo.Save();
            return RedirectToAction("MarketingEmailBlastAttach", "Admin", new { id = emailBlastID });

        }


        public ActionResult MarketingEmailBlastHistory()
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var col =new  BusinessObjects.V5EmailBlastCollection();


            var q = new V5EmailBlastQuery();
            q.OrderBy(q.CreatedByDate, esOrderByDirection.Descending);
            q.Where(q.Or(q.StatusUCODE == "READY", q.StatusUCODE == "INPROCCESS", q.StatusUCODE == "COMPLETE"));
            col.Load(q);
            var m = new MODELS.MarketingEmailBlastListModel(col);

            return View(m);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Required</param>
        /// <param name="mode">EDIT/VIEW</param>
        /// <returns></returns>
        public ActionResult MarketingEmailBlastConfirm(int id,string mode="")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            var o = new BusinessObjects.V5EmailBlastBO();
            if (!o.LoadByPrimaryKey(id))
            {
                throw new ApplicationException("EmailBlastID with ID : " + id.ToString() + " could not be loaded");
            }

            var m = new MODELS.MarketingEmailBlastModel(o);
            if (mode==String.Empty)
            {
                mode = "EDIT";
            }
            m.DisplayMode = mode;
            return View(m);
        }
        [HttpPost]
        public ActionResult MarketingEmailBlastConfirmNav()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            //[HttpPost]
            var emailBlastID = u.ObjToInt(Request["EmailBlastID"]);
            var navAction = u.ObjToString(Request["NavAction"]);

            if (navAction == "PREV")
            {
                return RedirectToAction("MarketingEmailBlastAttach", "Admin", new { id = emailBlastID });

            }
            else if (navAction == "NEXT")
            {
                //Save this Record
                var ob = new BusinessObjects.V5EmailBlastBO();
                ob.LoadByPrimaryKey(emailBlastID);
                ob.StatusUCODE = "READY";
                ob.Save();


                //Also Create a Job for execution
                //5/1/2018 add a process record to the database. 
                var o = new BusinessObjects.V5JobMasterRunBO();
                o.CreatedBy = OBJECTS.SecurityHelper.UserName;
                o.Parameters = "EMAILBLAST";
                o.StatusUcode = "OPEN";
                o.Save();
                

                return RedirectToAction("MarketingEmailBlastHistory", "Admin");

            }
            else if (navAction=="CANCEL")
            {

                var o = new BusinessObjects.V5EmailBlastBO();
                o.LoadByPrimaryKey(emailBlastID);
                o.StatusUCODE = "CANCEL";
                o.Save();
                return RedirectToAction("Admin", "Admin");
            }
            else //if (navAction == "HISTORY")
            {
                return RedirectToAction("MarketingEmailBlastHistory", "Admin");
            }



        }

        #endregion



        public ActionResult SetEOWStatus()
        {


            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var msg = "";
            var status = "";
             
            //Create a New HttpClient object.
            HttpClient client = new HttpClient();
            HttpResponseMessage resp;

            var value = u.ObjToString(Request["VALUE"]);

            // Call asynchronous network methods in a try/catch block to handle exceptions
            try
            {
                //First set 
                if (value != "")
                {
                    resp = client.GetAsync(UI.OBJECTS.Config.AS400APIURI + "/SetEOWStatus?status=" + value).Result;  // Blocking call!
                    if (resp.IsSuccessStatusCode)
                    {
                        var text = resp.Content.ReadAsStringAsync().Result;
                        status = Regex.Replace(text, @"[\""]", "", RegexOptions.None);
                        msg = "Status Set OK - ";
                    }
                    else
                    {
                        msg = "ERROR- Could not SET the EOW status - Code: " + resp.StatusCode.ToString()+":"+ resp.ReasonPhrase + ". ";
                        status = "<error>";
                    }
                }
                //Now get the value... 
                resp = client.GetAsync(UI.OBJECTS.Config.AS400APIURI + "/GetEOWStatus").Result;  // Blocking call!
                if (resp.IsSuccessStatusCode)
                {
                    var text = resp.Content.ReadAsStringAsync().Result;
                    status = Regex.Replace(text, @"[\""]", "", RegexOptions.None);
                    msg += "Status retrieved OK";
                }
                else
                {
                    msg += "ERROR- Could not GET the EOW status - Code: " + resp.StatusCode;
                    status = "<error>";
                }
            }
            catch (HttpRequestException e)
            {
                msg = "ERROR - Could not set/get the EOW status System Exception - " + e.ToString();
                status = "<error>";
            }

            ViewBag.CurrentStatus = status;
            ViewBag.Msg = msg;
            return View();
        }



        public ActionResult ExecuteSQL()
        {
            ensureSSL();            
            var m = new MODELS.ExecuteSQLModel(MySession.SQL);
          
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            return View(m);
        }

        [HttpPost]
        public ActionResult ExecuteSQL(MODELS.ExecuteSQLModel m)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            string sql = m.SQL;
            MySession.SQL = m.SQL;
            m.SQLDataSet = null;

            if (m.SelectDataSource == "WEB")
            {

                //Just some rando collection to execute regular datavase sql on - this has nothing to do with the Users Collection 
                UsersCollection col = new UsersCollection();
                string msg = "";
                DataSet ds = null;
                var retVal = col.ExecuteSQL(sql, ref ds, ref msg);
                m.Message = msg;
                if (retVal)
                {
                    m.SQLDataSet = ds;
                    
                }
            }
            else if (m.SelectDataSource == "AS400")
            {
                string msg = "";
                DataSet ds = null;
                var retVal = AS400Product.AS400GetDataSet(sql, ref ds, ref msg);
                m.Message = msg;
                if (retVal)
                {
                    m.SQLDataSet = ds;
                }
            }

            return View(m);
        }

        /// <summary>
        /// Member Email Page - collect all member emails for cut and paste
        /// </summary>
        /// <returns></returns>
        public ActionResult MemberEmailTool()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var m = new MODELS.MemberEmailToolModel();
            m.MemberSelection = "ALL";
            m.SpacingSize = 400;//can get from config..
            return View(m);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
       [HttpPost]
       public ActionResult MemberEmailTool(MODELS.MemberEmailToolModel m)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            var col = new BusinessObjects.UsersCollection();
            if (!col.LoadActiveMarketingUsers(m.MemberSelection))
            {
                base.SetDisplayMsg(WebMsgType.WAR, "No members could be found for selection: " + m.MemberSelection, WebLogAction.UIMSG);

            }
            else
            {
                int ctr = 0;
                int size = u.ObjToInt(m.SpacingSize);
                var s="";
                var delim = ";";
                foreach (BusinessObjects.UsersBO us in col)
                {
                    s+=(u.ObjToString(us.XEmail1)!="")?u.ObjToString(us.XEmail1)+delim:"";
                    s += (u.ObjToString(us.XEmail2) != "") ? u.ObjToString(us.XEmail2) + delim : "";
                    s += (u.ObjToString(us.XEmail3) != "") ? u.ObjToString(us.XEmail3) + delim : "";
                    s += (u.ObjToString(us.XEmail4) != "") ? u.ObjToString(us.XEmail4) + delim : "";
                    ctr++;
                    if (size!=0 && (ctr%size)==0)
                    {
                        s += "\r\n\r\n<--BREAK-->\r\n\r\n";
                    }
                }
                s = u.Chop(s);
                m.EmailBuffer = s;
                base.SetDisplayMsg(WebMsgType.OK, col.Count.ToString()+" members found and emails extracted.", WebLogAction.UIMSG);

            }


            return View(m);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public ActionResult BookGen(string msg = "")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            var m = new MODELS.BookConfigModel();
            var o = new BusinessObjects.BookConfigBO();

            var q = new BusinessObjects.BookConfigQuery();
            q.Where(q.IsCurrent.Equal(true));
            m.BookConfigID = 0;
            m.ShowPrices = true;
            m.AdList = null;
            m.Ads = null;

            if (o.Load(q))
            {
                m.BookConfigID = o.BookConfigID.Value;
                m.ShowPrices = o.ShowPrices.Value;
                
                var col = new BusinessObjects.BookConfigAdCollection();
                var qcol = new BusinessObjects.BookConfigAdQuery();
                qcol.Where(qcol.BookConfigID.Equal(m.BookConfigID));
                qcol.OrderBy(qcol.PageNum,esOrderByDirection.Ascending);
                if (col.Load(qcol))
                {
                    m.AdList = new MODELS.BookConfigAdListModel(col.ToList());
                }
            }
            else
            {
                m.AdList = new MODELS.BookConfigAdListModel();
             }

            //now load adds
            var acol = new BusinessObjects.AdCollection();
            var aq= new AdQuery();
            aq.Where(aq.Active.Equal(true));
            aq.OrderBy(aq.AdName, esOrderByDirection.Ascending);
            if (acol.Load(aq))
            {
                m.SetAds(acol);
            }
            else
            {
                m.Ads = new MODELS.NameValuePairListModel();
            }
            
            if (msg != "")
            {
                base.SetDisplayMsg(WebMsgType.OK, msg, WebLogAction.UIMSG);
            }
            return View(m);
        }
        [HttpPost]
        public ActionResult BookGenSave()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            string msg = "";

            bool ShowPrices = u.ObjToBool(Request["showprices"] == "on");
            int BookConfigID = u.ObjToInt(Request["BookConfigID"]);
            string mode = u.ObjToString(Request["MODE"]);
            int DELBookConfigAdID= u.ObjToInt(Request["DELID"]);

            //delete
            if (mode=="DEL" && DELBookConfigAdID!=0)
            {
                var od = new BookConfigAdBO();
                od.LoadByPrimaryKey(DELBookConfigAdID);
                od.MarkAsDeleted();
                od.Save();
            }



            var o = new BookConfigBO();
            //Create new one
            if (BookConfigID == 0)
            {
                o.ShowPrices = ShowPrices;
                o.Createdby = OBJECTS.SecurityHelper.CustID;
                o.LastUpdatedby = OBJECTS.SecurityHelper.CustID;
                o.IsCurrent = true;
                o.Save();
                BookConfigID = o.BookConfigID.Value;
                o = null;
                o = new BookConfigBO();
            }

            if (!o.LoadByPrimaryKey(BookConfigID))
            {
                throw new ApplicationException("BookConfigID: " + BookConfigID.ToString() + " could not be found - Book Generation settings cannot be saved.");
            }
            o.ShowPrices = ShowPrices;
            o.IsCurrent = true;
            o.LastUpdatedby = OBJECTS.SecurityHelper.CustID;
            o.LastUpdate = DateTime.Now;
            o.Save();

            foreach (string k in Request.Form)
            {

                if (k.StartsWith("ID_"))
                {
                    int bookConfigAdID = u.ObjToInt(Request[k]);
                    if (bookConfigAdID != DELBookConfigAdID || bookConfigAdID == 0)
                    {
                        var ba = new BusinessObjects.BookConfigAdBO();
                        int adID = u.ObjToInt(Request["AD_SELECT_" + bookConfigAdID]);
                        int pageNum = u.ObjToInt(Request["PAGE_" + bookConfigAdID]);
                        pageNum = verifyPage(BookConfigID, bookConfigAdID, pageNum);
                        if (pageNum == 0)
                        {
                            throw new ApplicationException("Could not verify page for " + bookConfigAdID.ToString());

                        }
                        if (adID != 0)
                        {
                            if (bookConfigAdID != 0)
                            {
                                if (!ba.LoadByPrimaryKey(bookConfigAdID))
                                {
                                    throw new ApplicationException("Could not load add " + bookConfigAdID.ToString());
                                }
                            }
                            ba.BookConfigID = BookConfigID;
                            ba.AdID = adID;
                            ba.PageNum = pageNum;
                            ba.Save();
                        }
                    }
                }
            }


            msg = "Book Configuration Settings Saved OK!";

            return RedirectToAction("BookGen", "Admin", new { msg = Server.HtmlEncode(msg) });
        }
        /// <summary>
        /// find out if a page is in use. 
        /// </summary>
        /// <param name="bookConfigAdID"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        private int verifyPage(int bookConfigID, int bookConfigAdID, int page)
        {
            //give them the page they want
            int retVal = page;

            do
            {
                //if the page they wanted is 0 - give them the next one 
                int nextPage = nextAvailPage(bookConfigID);
                if (page == 0)
                {
                    retVal = nextPage;
                    break;
                }


                //If the page they wanted is already used by another add - give them the next one
                var col = new BusinessObjects.BookConfigAdCollection();
                var q = new BusinessObjects.BookConfigAdQuery();
                q.Where(q.And(q.BookConfigID.Equal(bookConfigID), q.PageNum.Equal(page)));
                if (col.Load(q))
                {
                    var o = col[0];
                    if (o.BookConfigAdID.Value != bookConfigAdID)
                    {
                        retVal = nextPage;
                    }
                 }
                
            } while (false);
        
            return retVal; 
        }
        /// <summary>
        /// Get the first page without an ad 
        /// </summary>
        /// <param name="bookConfigAdID"></param>
        /// <returns></returns>
        private  int nextAvailPage(int bookConfigID)
        {
            var col = new BusinessObjects.BookConfigAdCollection();
            var q = new BusinessObjects.BookConfigAdQuery();
            q.Where(q.BookConfigID.Equal(bookConfigID));
            q.OrderBy(q.PageNum, esOrderByDirection.Ascending);
            int retVal = 1;//default values
            if (col.Load(q))
            {
                foreach (var o in col)
                {
                    if (retVal!=o.PageNum.Value && o.PageNum.Value!=0)
                    {
                        break;
                    }
                    retVal++;
                }
            }
            return retVal;
        }
        public ActionResult ManageAd(string msg="")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            var col = new BusinessObjects.AdCollection();
            var q = new BusinessObjects.AdQuery();
            q.OrderBy(q.AdName, esOrderByDirection.Ascending);
            col.Load(q);
            ViewBag.COL = col;
            var m = new UI.MODELS.AdListModel(col.ToList());
            if (msg != "")
            {
                base.SetDisplayMsg(WebMsgType.OK, msg, WebLogAction.UIMSG);
            }
            return View(m);
        }
        [HttpPost]
        public ActionResult UploadAd(HttpPostedFileBase file1)

        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            string msg = "";

            if (file1!=null && file1.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file1.FileName);
                //note - we should check here if the file already exists 
                //otherwise we will just overwrite. 
                var path = Path.Combine(UI.OBJECTS.Config.ADUPLOADPATH, fileName);
                file1.SaveAs(path);
                var bo = new AdBO();
                bo.AdImage = fileName;
                bo.AdName = fileName;
                bo.AltText = fileName;
                bo.Active = true;
                bo.CreatedBy = UI.OBJECTS.SecurityHelper.CustID;
                bo.LastUpdatedBy = UI.OBJECTS.SecurityHelper.CustID;
                bo.Save();
                //base.SetDisplayMsg(WebMsgType.OK, fileName + " uploaded OK", WebLogAction.UIMSG);
                msg = fileName + " uploaded OK!";
               
            }
            
            return RedirectToAction("ManageAd", "Admin", new { msg = Server.HtmlEncode(msg) });
        }

        [HttpPost]
        public ActionResult ManageAdSave()
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            string msg = "";

            foreach (string k in Request.Form)
            {
                if (k.StartsWith("ID_"))
                {
                    int id = u.ObjToInt(Request.Form[k]);
                    var o = new BusinessObjects.AdBO();
                    if (id != 0 && o.LoadByPrimaryKey(id))
                    {
                        o.LastUpdatedBy = SecurityHelper.CustID;
                        o.LastUpdate = DateTime.Now;

                        string temp = "ADNAME_" + id.ToString();
                        string val = u.ObjToString(Request.Form[temp]);
                        o.AdName = val;

                        temp = "ALTTEXT_" + id.ToString();
                        val = u.ObjToString(Request.Form[temp]);
                        o.AltText = val;

                        temp = "ACTIVE_" + id.ToString();
                        val = u.ObjToString(Request.Form[temp]);
                        o.Active = val == "on";
                        o.Save();
                        msg = "Ad Information saved OK!";

                    }
                }
            }
            return RedirectToAction("ManageAd", "Admin", new { msg = Server.HtmlEncode(msg) });
        }

        public ActionResult SalesBeefConfigAd()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            return View();
        }
        [HttpPost]
        public ActionResult SalesBeefConfig()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            return View();
        }

        public ActionResult ExecuteJob()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            return View();
        }
        [HttpPost]
        public ActionResult ExecuteJob(MODELS.ExecuteJobModel model)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);


            //Take a look if anything is running
            var col = new BusinessObjects.FdactionCollection();
            var q = new BusinessObjects.FdactionQuery();
            q.Where(q.Lastresult.Equal(u.ObjToInt(OBJECTS.FDJobStatus.INPROGRESS)));
            if (col.Load(q) && col.Count > 0)
            {
                base.SetDisplayMsg(WebMsgType.WAR, "There is already a job in progress: " + col[0].Token + " (" + col[0].Description + ") Please visit the Job Status page or try again.", WebLogAction.UIMSG);
                return View();
            }
            else
            {
                //5/1/2018 add a process record to the database. 
                var o = new BusinessObjects.V5JobMasterRunBO();
                o.CreatedBy = OBJECTS.SecurityHelper.UserName;
                if (model.JobType == "SALESEMAIL")
                {
                    model.JobXParm = "";
                    model.JobXParm2 = "";
                }
                o.Parameters = model.JobType + " " + model.JobXParm + " " + model.JobXParm2;
                o.StatusUcode = "OPEN";
                o.Save();
                
                return RedirectToAction("JobStatus");
            }
        }
        public ActionResult ViewLog(string file, string source = "")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var path = UI.OBJECTS.Config.LogPath;

            if (source == "APP")
            {
                path = UI.OBJECTS.Config.APPSERVERLOGPATH;
            }

            var p = System.IO.Path.Combine(path, file);
            ViewBag.FileName = p;

                if (System.IO.File.Exists(p))
            {
                ViewBag.Text = u.ReadFromFile(p);
            }
            else
            {
                ViewBag.Text = "System.IO.File.Exists - File Not Found: "+p;
            }

            return View();
        }


        public ActionResult Admin()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            //ViewBag.Message = "Welcome to Foodirect";

            return View();
        }

        public ActionResult Email()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            //ViewBag.Message = "Welcome to Foodirect";

            var m = new MODELS.EmailModel();
            m.To = OBJECTS.Config.WEBMASTEREMAIL;
            m.Subject = "Test Message";
            m.Message = "This is a test message";
            return View(m);
        }
        [HttpPost]
        public ActionResult Email(MODELS.EmailModel email)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            string retMsg = "";
            if (EmailHelper.SendTestAdminEmail(email.To, email.Subject, email.Message, ref retMsg))
            {
                base.SetDisplayMsg(WebMsgType.OK, "Test Email Sent OK: " + email.Subject + " - " + email.To, WebLogAction.EMAIL_OK);
            }
            else
            {
                base.SetDisplayMsg(WebMsgType.ERR, "Test Email Error: " + email.Subject + " - " + email.To + " - " + retMsg, WebLogAction.EMAIL_ERROR);
            }
            return View(email);
        }


        public ActionResult WebLog(string msg, string mode = "", string sf = "createdatetime", string so = "desc", int page = 1)
        {
            
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            OBJECTS.SecurityHelper.ThrowSQLInjection(msg, mode, sf, so);


            var col = new BusinessObjects.V5WebLogCollection();
            var pageSize = 15;
            int totalCount = 0;
            string orderBy = sf + " " + so;
            var ds = col.GetPagedView(page, pageSize,orderBy, ref totalCount, "");
            var p = new MODELS.WebLogListModel(ds);
            var v = new MODELS.WebLogViewModel();
            v.Logs = p;

            var m = new MODELS.WebLogXParmsModel();
            m.QueryType = mode;
            m.SortField = sf;
            m.SortOrder = so;

            var pv = new MODELS.WebLogQueryAndViewModel(m, v);

            pv.ViewModel.TotalCount = totalCount;
            pv.PageSize = pageSize;

            pv.Page = page;

            return View(pv);
        }
        public ActionResult WebLogView(int webLogID)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var o = new BusinessObjects.V5WebLogBO();
            if (!o.LoadByPrimaryKey(webLogID))
            {
                throw new ApplicationException("There was no web log found with ID: " + webLogID.ToString());

            }
            var m = new MODELS.WebLogModel(o);

            return View(m);

        }
     
     

        public ActionResult JobStatus()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var col = new BusinessObjects.FdactionCollection();
            var q = new FdactionQuery();
            q.Where(q.Active.Equal(1));
            col.Load(q);
            var m = new MODELS.FDActionViewModel(col);
            return View(m);
        }
        public ActionResult JobStatusHistory(string token,string result)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var resultValue = -1;
            if (result == "OK") resultValue = 0;
            if (result == "ERROR") resultValue = 1;
            if (result == "WARNING") resultValue = 2;
            if (result == "INPROGRESS") resultValue = 3;
            
            var col = new BusinessObjects.FDACTIONHistoryCollection();
            var q = new FDACTIONHistoryQuery();

            if (resultValue== -1)
            {
                q.Where(q.Token.Equal(token));
            }
            else
            {
                q.Where(q.And(q.Token.Equal(token),q.Lastresult.Equal(resultValue)));

            }
            q.OrderBy(q.Lastrun.Descending);
            col.Load(q);
            var m = new MODELS.FDACTIONHistoryViewModel(col);
            ViewBag.Token = token;
            ViewBag.Result = result;

            return View(m);
        }
        public ActionResult Config()
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var list = new Dictionary<string, string>();

            foreach (string key in ConfigurationManager.AppSettings.Keys)
            {
                list.Add(u.ObjToString(key), u.ObjToString(ConfigurationManager.AppSettings[key]));
            }

            list.Add("Map Path", Server.MapPath("/").ToString());

            ViewBag.ConfigInfo = list;

            return View();



        }

        #region Persons
        public ActionResult Salesman()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);


            var col = new BusinessObjects.V5SalesManCollection();
            var q = new V5SalesManQuery();
            q.Where(q.Active.Equal(1));
            q.OrderBy(q.Name, EntitySpaces.DynamicQuery.esOrderByDirection.Ascending);
            col.Load(q);
            //col.LoadAll();
            var m = new MODELS.SalesmanListModel(col);
            return View(m);

        }
        [HttpPost]
        public ActionResult Salesman(string x)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            //save all the emails
            var status = true;
            foreach (string k in Request.Form.Keys)
            {
                var i = k.IndexOf("EDITEMAIL");
                int id = 0;
                var email = "";
                if (i >= 0)
                {
                    id = u.ObjToInt(k.Replace("EDITEMAIL_", ""));
                    email = Request[k].Trim();
                }
                if (id > 0)
                {
                    var o = new V5SalesManBO();
                    if (o.LoadByPrimaryKey(id))
                    {
                        o.Email = email;
                        o.Save();
                    }
                    else
                    {
                        status = false;
                    }
                }
            }


            //now reload the model. 
            var col = new BusinessObjects.V5SalesManCollection();
            var q = new V5SalesManQuery();
            q.Where(q.Active.Equal(1));
            col.Load(q);
            //col.LoadAll();
            var m = new MODELS.SalesmanListModel(col);


            if (status)
            {
                base.SetDisplayMsg(WebMsgType.OK, "Email addresses saved OK!", WebLogAction.UIMSG);

            }
            else
            {
                base.SetDisplayMsg(WebMsgType.WAR, "There were some issues saving the email addresses.", WebLogAction.UIMSG);

            }

            return View(m);

        }
        public ActionResult PersonsBookRedirect(string custID)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);


            // Create Hash query string paremeter
            var hash = new Dictionary<string, string>();
            hash.Add("custid", custID);
            var guid = FDSHARED.HashHelper.Set(hash);
            return RedirectToAction("BookPrint","Product", new { guid = guid });
        }

        public ActionResult PersonsOfInterest(string msg="")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);


            if (msg != null && msg != string.Empty)
            {
                SetDisplayMsg(WebMsgType.OK, msg.Trim(), WebLogAction.INFO);
            }

            var col = new BusinessObjects.UsersCollection();

            int totalCount = 0;
            var ds = col.GetPersonsOfInterest(ref totalCount);
            var p = new MODELS.PersonListModel(ds);
            var v = new MODELS.PersonViewModel();
            
            v.Persons = p;
            v.TotalCount = totalCount;

            return View(v);
        }
        public ActionResult POIEdit(string id)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            MODELS.PersonModel p;

            if (u.ObjToString(id) != "")
            {
                p = new MODELS.PersonModel(id);

                ViewBag.Mode = "EDIT";
            }
            else
            {
                //Its a new Person 
                p = new MODELS.PersonModel();
                p.AccessType = OBJECTS.FDLegacyRoles.AMM_SFSALES;
                var poiid = createUniquePOIID();
                p.CustID = poiid; 
                p.Internetid= poiid;
                ViewBag.Mode = "NEW";
            }
            return View(p);
        }
        string createUniquePOIID()
        {
            int ctr = 100;
            string retVal = "";

            do
            {
                string id = "WU" + u.Replicate("0", 4 - ctr.ToString().Length)+ ctr.ToString();
                var o = new UsersBO();
                if (o.LoadByCustID(id))
                {
                    o = null;
                    ctr++;
                }
                else
                {
                    retVal = id;
                    break;
                }


            }
            while (true);

            return retVal;
        }
        [HttpPost]
        public ActionResult POIEdit(MODELS.PersonModel p)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            string msg = "";
            var value = u.ObjToString(Request["ACTIONBTN"]);
            var mode = u.ObjToString(Request["MODE"]);
            bool valid = true;
            string validMsg = "";



            //do some hard core checks
            var ot = new BusinessObjects.UsersBO();
            if (p.DecryptedPassword.Length < 8)
            {
                validMsg = "Password is too short. Must be 8 bytes.";
                valid = false;
            }
            else if (ot.LoadByCustID(p.CustID) && mode == "NEW")
            {
                validMsg = "The Customer ID Already Exists";
                valid = false;
            }
            else if (ot.LoadByInternetID(p.Internetid) && (mode == "NEW" || p.CustID!=ot.Custid))
            {
                validMsg = "The Internet ID Already Exists";
                valid = false;
            }

            if (!valid)
            {

                base.SetDisplayMsg(WebMsgType.WAR, validMsg,WebLogAction.UIMSG);
                return View(p);

            }
            else
            { 

                var op = new BusinessObjects.UsersBO();
                if (mode == "EDIT")
                {

                    op.LoadByCustID(p.CustID);
                }
                else
                {
                    op.AddNew();
                    op.Flags = 0;

                }

                op.Custid = p.CustID;
                op.Bizname = p.BizName;
                op.Contactname = p.ContactName;
                op.Internetid = p.Internetid;
                op.Type = Convert.ToInt16(p.AccessType);
                op.Password = OBJECTS.SecurityHelper.Encrypt(p.DecryptedPassword);
                op.Flags = 0;
                if (!p.Active)
                {
                    op.Flags = 2;
                }
                op.Save();
             
                msg = u.ObjToString(op.Contactname) + " - POI Saved OK";
                return RedirectToAction("PersonsOfInterest", "Admin", new { msg = msg });

            }

        }




        public ActionResult Persons(string msg, string mode="", string sf="BizName",string so="asc", int page = 1,string search="",bool lastSettings=false)
        {

            ensureSSL();

            var searchFields = new List<string>();
            searchFields.Add("internetid");
            searchFields.Add("notes");
            searchFields.Add("altcode");
            searchFields.Add("bizname");
            searchFields.Add("contactname");
            searchFields.Add("address1");
            searchFields.Add("address2");
            searchFields.Add("city");
            searchFields.Add("state");
            searchFields.Add("zip");
            searchFields.Add("zip4");
            searchFields.Add("telephone");
            searchFields.Add("fax");
            searchFields.Add("cell");
            searchFields.Add("email");
            searchFields.Add("xemail1");
            searchFields.Add("xemail2");
            searchFields.Add("xemail3");
            searchFields.Add("xemail4");
            searchFields.Add("ChainCode");
           
            
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            OBJECTS.SecurityHelper.ThrowSQLInjection(msg,mode,sf,so);
            if (msg!=null && msg != string.Empty)
            {
                SetDisplayMsg(WebMsgType.OK, msg.Trim(), WebLogAction.INFO);
            }

           var col = new BusinessObjects.UsersCollection();
            var pageSize = 15;
            int totalCount = 0;
            var title = "All Members";
            var filter = "";
            var s = "";

            MODELS.PersonXParmsModel m;

            if (lastSettings == true)
            {
                m = MySession.LASTPERSONSXPARM;
            }
            else
            {
                m = new MODELS.PersonXParmsModel();

                if (mode == "WEB")
                {
                    title = "Active Web Members";
                    filter = "(type = 2 or type = 3 or type = 7) and (flags = 0)";
                }

                if (search!="")
                {
                    s = "(";
                    if (filter != "")
                    {
                         s = "and (";
                    }
                    var si = 0;
                    foreach (string f in searchFields)
                    {
                        si++;
                        s += f + " like '%" + search + "%'";
                        if (si < searchFields.Count)
                        {
                            s += " or ";
                        }
                    }
                    s += ")";
                     

                    filter = filter + s;
                    title = title + " Contains: " + search;
                }


                m.QueryType = mode;
                m.Title = title;
                m.SortField = sf;
                m.SortOrder = so;
                m.Search = search;
                m.Filter = filter;
                OBJECTS.MySession.LASTPERSONSXPARM = m;
            }
            
            string orderBy = m.SortField + " " + m.SortOrder;
            var ds = col.GetPagedView(page, pageSize, orderBy, ref totalCount, m.Filter);
            var p = new MODELS.PersonListModel(ds);
            var v = new MODELS.PersonViewModel();
            v.Persons = p;

            var pv = new MODELS.PersonQueryAndViewModel(m, v);


            pv.ViewModel.TotalCount = totalCount;
            pv.PageSize = pageSize;
            pv.Page = page;

            return View(pv);
        }
        public ActionResult UserAccess(string custID)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var o = new BusinessObjects.UsersBO();
            if (!o.LoadByPrimaryKey(custID))
            {
                throw new ApplicationException("There was no user found with custID: " + custID);

            }
            var m = new MODELS.PersonModel(o);

            return View(m);
        }
        [HttpPost]
        public ActionResult UserAccess(MODELS.PersonModel p)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            string action = u.ObjToString(Request["ACTIONBTN"]).ToUpper();
            if (action == "")
            {
                action = "SAVE";
            }

            string retMsg = "";
            if (action == "SAVE")
            {
                var o = new BusinessObjects.UsersBO();
                string custID = p.CustID;
                if (!o.LoadByPrimaryKey(custID))
                {
                    throw new ApplicationException("There was no user found with custID: " + custID);

                }
                o.CanOrder = p.CanOrder;
                o.CanViewInventoryDetails = p.CanViewInventoryDetails;
                o.UseProdCustGuide = p.UseProdCustGuide;
                o.Save();
                retMsg= "Member Access Saved OK";

            }
            return RedirectToAction("Persons", "Admin", new { lastSettings = true, msg = Server.HtmlEncode(retMsg) });


        }
        #endregion

        #region Registrations
        public ActionResult Registrations(string mode, string sf="createdate", string so="desc", int page = 1)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            OBJECTS.SecurityHelper.ThrowSQLInjection(mode, sf, so);
            
            var col = new BusinessObjects.V5RegisterCollection();
            var pageSize = 15;
            int totalCount=0;
            var ds = col.GetPagedView(page, pageSize, sf+" "+so, ref totalCount, "");
            
            var p = new MODELS.RegisterListModel(ds);
            var v = new MODELS.RegisterViewModel();
            v.Registrations = p;

            var m = new MODELS.RegisterXParmsModel();
            m.QueryType = mode;
            m.SortField = sf;
            m.SortOrder = so;

            var pv = new MODELS.RegisterQueryAndViewModel(m, v);
           
            pv.ViewModel.TotalCount = totalCount;
            
            pv.PageSize = pageSize;
            pv.Page = page;

            return View(pv);

        }
        public ActionResult RegisterView(int registerid)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);

            var o = new BusinessObjects.V5RegisterBO();
            if (!o.LoadByPrimaryKey(registerid))
            {
                throw new ApplicationException("There was no registration found with ID: " + registerid.ToString());

            }
            var m = new MODELS.RegisterModel(o);

            return View(m);
        }
 #endregion
    }
}