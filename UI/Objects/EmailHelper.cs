using System.Configuration;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
using System;
using System.Text.RegularExpressions;
using u = CSA.UTILITY.MyUtility;
using em = BusinessObjects.Email;
using  BusinessObjects;

namespace UI.OBJECTS
{
    public class EmailHelper
    {
        private EmailHelper()
        {

        }

        static private string getTitle(string file)
        {
            Match m = Regex.Match(file, @"<title>\s*(.+?)\s*</title>");
            if (m.Success)
            {
                return m.Groups[1].Value;
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="to"></param>
        /// <param name="htmlBody"></param>
        /// <param name="retMsg"></param>
        /// <returns></returns>
        static private bool sendEmail(string subject, string to, string htmlBody, ref string retMsg, string replyto = "",string attachment="")
        {

            bool retVal = false;
            retMsg = "";

            if (!Config.EMAILON)
            {
                return true;
            }

            var ei = new EmailInfo();
            ei.Body = stripHTML(htmlBody);
            ei.HTMLBody = htmlBody;
            ei.To = to;
            ei.Subject = subject;
            ei.From = Config.BUSINESSEMAIL;
            if (replyto == "")
            {
                ei.ReplyTo = Config.BUSINESSEMAIL;
            }
            else
            {
                ei.ReplyTo = replyto;

            }
            if (!string.IsNullOrEmpty(attachment))
            {
                ei.Attachments.Add(attachment);
            }
            
            
            Email x;
            if (string.IsNullOrEmpty(Config.SMTPUSER))
            {
              
                 if (string.IsNullOrEmpty(Config.SMTPPORT)) 
                {
                    x = new Email(Config.SMTPSERVER);
                }
                else
                {
                       x = new Email(Config.SMTPSERVER,Config.SMTPPORT);
                }
               
            }
            else
            {

                if (string.IsNullOrEmpty(Config.SMTPPORT))
                {
                 
                    x = new Email(Config.SMTPSERVER, Config.SMTPUSER, Config.SMTPPWD);
                }
                else
                {
                    x = new Email(Config.SMTPSERVER, Config.SMTPPORT,Config.SMTPUSER, Config.SMTPPWD);
                }
               
            }
            string msg = "";
            string info = "";

            var log = "";
            log += "To:" + ei.To + "\n";
            log += "From:" + ei.From + "\n";
            log += "Reply To:" + ei.ReplyTo + "\n";
            
            log += "Subject: " + ei.Subject + "\n";

            log += "HTML:" + ei.HTMLBody + "\n";
            log += "Body:" + ei.Body + "\n";


            LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, log, BusinessObjects.WebLogAction.EMAIL_OK);




            if (x.SendAndCatchError(ei, ref msg, ref info))
            {
                retVal = true;
                retMsg = "Email Sent OK " + msg + " - " + info;
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, retMsg, BusinessObjects.WebLogAction.EMAIL_ERROR);

            }
            else
            {
                retVal = false;
                retMsg = "Email Could not be Sent - " + msg + " - " + info;
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, retMsg, BusinessObjects.WebLogAction.EMAIL_ERROR);
            }
            return retVal;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private static string stripHTML(string source)
        {
            string output;

            //get rid of HTML tags
            output = Regex.Replace(source, "<[^>]*>", string.Empty);

            //get rid of multiple blank lines
            output = Regex.Replace(output, @"^\s*$\n", string.Empty, RegexOptions.Multiline);

            return output;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ajax"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static bool SendAdminErrorEmail(string msg, bool ajax, System.Exception exIn=null)
        {
                var retVal=true;
            try
            {
                string file = Path.Combine(Config.EmailPath, "ErrorAdmin.html");
                string buffer = u.ReadFromFile(file);


                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%MSG", msg);
                buffer = buffer.Replace("%ISAJAX", ajax.ToString());
                buffer = buffer.Replace("%HASEXCEPTION", exIn==null?"No":"Yes");
                var s=(exIn==null?"(none)":exIn.ToString());
                 buffer = buffer.Replace("%STACK", s);
               
                var subject = getTitle(buffer);
                string retMsg = "";
               
                var to = Config.WEBMASTEREMAIL;
                
                if (!sendEmail(subject, to, buffer, ref retMsg))
                {
                    throw new ApplicationException(retMsg);
                }
            }
            catch (System.Exception ex)
            {
                MyLog.Msg("Could not send Salesman Contact Email " + ex.ToString());
                retVal = false;
            }
            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toAddress"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="retMsg"></param>
        /// <returns></returns>
        public static bool SendTestAdminEmail(string toAddress, string subject, string body, ref string retMsg)
        {

            bool retVal = false;
            retMsg = "";

            string file = Path.Combine(Config.EmailPath, "AdminTest.html");
            string buffer = u.ReadFromFile(file);
            buffer = buffer.Replace("%SUBJECT", subject);
            buffer = buffer.Replace("%MESSAGE", body);
            buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
           
            if (sendEmail(subject, toAddress, buffer, ref retMsg,OBJECTS.Config.BUSINESSEMAIL))
            {
                retVal = true;
                retMsg = "Email Sent OK " + retMsg;
            }
            else
            {
                retVal = false;
                retMsg = "Email Could not be Sent - " + retMsg;
            }
            return retVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationID"></param>
        public static bool SendSalesmanPriceEmail(int polid, string message)
        {

            bool retVal = true;

            try
            {

                var line = new BusinessObjects.WtaPoLineBO();
                if (!line.LoadByPrimaryKey(polid))
                {
                    throw new ApplicationException("PO Line does not exist" + u.ObjToString(polid));
                }
                var po = new BusinessObjects.WtaPoBO();
                if (!po.LoadByPrimaryKey(line.Poid.Value))
                {
                    throw new ApplicationException("PO  does not exist" + u.ObjToString(line.Poid.Value));
                }


                var o = new BusinessObjects.UsersBO();
                if (!o.LoadByCustID(po.Mid))
                {
                    throw new ApplicationException("Could not load CustID :" + po.FDRCustid);
                }

                var ini = o.SlmInit;
                var s = new BusinessObjects.V5SalesManBO();

                if (!s.LoadByInitial(ini))
                {
                    throw new ApplicationException("Could not load with Salesman INI :" + ini);
                }



                string file = Path.Combine(Config.EmailPath, "ContactSalesPrice.html");
                string buffer = u.ReadFromFile(file);


                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%BIZNAME", o.Bizname);
                buffer = buffer.Replace("%SALESMAN", s.Name + "(" + s.Initial + ")");
                buffer = buffer.Replace("%MESSAGE", message);
                buffer = buffer.Replace("%PRODUCTCODE", line.Productcode);
                buffer = buffer.Replace("%PRODUCTDESC", line.Productdescription);
                buffer = buffer.Replace("%WEBORDER", po.Ponum);
                buffer = buffer.Replace("%CREATEDATE", MyHelper.MakeSimpleDateTimeString(po.Createdate));
                buffer = buffer.Replace("%RSHIP", MyHelper.MakeSimpleDateTimeString(po.RequestedDeliveryTime));



                var subject = getTitle(buffer);
                string retMsg = "";
               
                var fto = "";
                var to = "";
                if (!string.IsNullOrEmpty(s.Email))
                {
                    fto = s.Email;
                }
                else
                {
                    fto = Config.BUSINESSEMAIL;
                }

                if (!string.IsNullOrEmpty(o.Email))
                {
                    to = fto + ";" + o.Email;
                }
                else
                {
                    to = fto;
                }


                if (!sendEmail(subject, to, buffer, ref retMsg, fto))
                {
                    throw new ApplicationException(retMsg);
                }
                retVal = true;

            }
            catch (System.Exception ex)
            {
                MyLog.Msg("Could not send Salesman Contact Email " + ex.ToString());
                retVal = false;
            }
            return retVal;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationID"></param>
        public static bool SendSalesmanEmail(string custID, string message)
        {

            bool retVal = true;
            var o = new BusinessObjects.UsersBO();

            try
            {
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



                string file = Path.Combine(Config.EmailPath, "ContactSales.html");
                string buffer = u.ReadFromFile(file);


                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%BIZNAME", o.Bizname);
                buffer = buffer.Replace("%SALESMAN", s.Name + "(" + s.Initial + ")");
                buffer = buffer.Replace("%MESSAGE", message);

                var subject = getTitle(buffer);
                string retMsg = "";

                var fto = "";
                var to="";
                if (!string.IsNullOrEmpty(s.Email))
                {
                    fto = s.Email;
                }
                else
                {
                    fto = Config.BUSINESSEMAIL;
                }
                
                if (!string.IsNullOrEmpty(o.Email))
                {
                    to = fto + ";" + o.Email;
                }
                else
                {
                    to = fto;
                }

                if (!sendEmail(subject, to, buffer, ref retMsg,fto))
                {
                    throw new ApplicationException(retMsg);

                }
                retVal = true;

            }
            catch (System.Exception ex)
            {
                MyLog.Msg("Could not send Salesman Contact Email " + ex.ToString());
                retVal = false;
            }
            return retVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationID"></param>
        public static bool SendContactEmail(string from, string message)
        {

            bool retVal = true;
            
            try
            {

                string file = Path.Combine(Config.EmailPath, "ContactAdmin.html");
                string buffer = u.ReadFromFile(file);

                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%FROM", from);
                buffer = buffer.Replace("%MESSAGE", message);

                var subject = getTitle(buffer);
                string retMsg = "";


                if (!sendEmail(subject, Config.BUSINESSEMAIL + ";" + Config.WEBMASTEREMAIL, buffer, ref retMsg, from))
                {
                    throw new ApplicationException(retMsg);

                }
                retVal = true;

            }
            catch (System.Exception ex)
            {
                MyLog.Msg("Could not send Salesman Contact Email " + ex.ToString());
                retVal = false;
            }
            return retVal;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationID"></param>
        public static void SendRegistrationAdminEmail(int registrationID)
        {
            try
            {

                string file = Path.Combine(Config.EmailPath, "RegistrationAdmin.html");
                string buffer = u.ReadFromFile(file);


                //get the registration record
                var r = new BusinessObjects.V5RegisterBO();
                if (!r.LoadByPrimaryKey(registrationID))
                {
                    throw new ApplicationException("could not load registration with id :" + registrationID.ToString());
                }

                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%NAME", r.FName + " " + r.LName);
                buffer = buffer.Replace("%ADDRESS", r.Address + " " + r.Address2);
                buffer = buffer.Replace("%CITY", r.City);
                buffer = buffer.Replace("%STATE", r.State);
                buffer = buffer.Replace("%ZIP", r.Zip);
                buffer = buffer.Replace("%BUSINESSNAME", r.BusinessName);
                buffer = buffer.Replace("%BUSINESSTYPE", r.BusinessType);
                buffer = buffer.Replace("%BUSINESSSIZE", r.BusinessSize);
                buffer = buffer.Replace("%BESTTIME", r.BestTimeToContact);
                buffer = buffer.Replace("%EMAIL", r.Email);
                buffer = buffer.Replace("%PHONE", r.Phone);
                //buffer = buffer.Replace("%USERNAME", r.UserName);
                //buffer = buffer.Replace("%PASSWORD", r.Password);

                var subject = getTitle(buffer);
                string retMsg = "";
                sendEmail(subject, Config.BUSINESSEMAIL + ";" + Config.WEBMASTEREMAIL, buffer, ref retMsg);

            }
            catch (System.Exception ex)
            {
                MyLog.Msg("Could not send Registration Admin Email " + ex.ToString());

            }
        }
        static public bool SendAdminPasswordResetEmail(BusinessObjects.UsersBO user)
        {
            bool retVal = true;
            try
            {

                string file = Path.Combine(Config.EmailPath, "PasswordResetAdmin.html");
                string buffer = u.ReadFromFile(file);



                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());

                buffer = buffer.Replace("%BIZNAME", user.Bizname);
                buffer = buffer.Replace("%EMAIL", user.Email);
                buffer = buffer.Replace("%CUSTID", user.Custid);
                buffer = buffer.Replace("%INTERNETID", user.Internetid);
                buffer = buffer.Replace("%PHONE", user.Telephone);


                var subject = getTitle(buffer);
                string retMsg = "";
                retVal = sendEmail(subject, Config.BUSINESSEMAIL + ";" + Config.WEBMASTEREMAIL, buffer, ref retMsg);

            }
            catch (System.Exception ex)
            {
                retVal = false;
                MyLog.Msg("Could not send Regstration Member Email " + ex.ToString());

            }
            return retVal;
        }


        /// <summary>
        /// Send the Recipient email - Use the template Buffer Technique
        /// </summary>
        /// <param name="order"></param>
        static public bool SendRegistrationEmail(int registrationID)
        {
            bool retVal = true;
            try
            {

                string file = Path.Combine(Config.EmailPath, "RegistrationMember.html");
                string buffer = u.ReadFromFile(file);


                //get the registration record
                var r = new BusinessObjects.V5RegisterBO();
                if (!r.LoadByPrimaryKey(registrationID))
                {
                    throw new ApplicationException("could not load registration with id :" + registrationID.ToString());
                }


                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%NAME", r.FName + " " + r.LName);
                var subject = getTitle(buffer);
                string retMsg = "";
                retVal = sendEmail(subject, r.Email, buffer, ref retMsg);

            }
            catch (System.Exception ex)
            {
                retVal = false;
                MyLog.Msg("Could not send Regstration Member Email " + ex.ToString());

            }
            return retVal;
        }
        /// <summary>
        /// Send a PO Order Confirmation to the customer
        /// </summary>
        /// <param name="orderx"></param>
        /// <returns></returns>
        static public bool SendPOEmailToMember(BusinessObjects.WtaPoBO order,string fileAttachment,string printGUID, ref string msg)
        {
            bool retVal = true;
            try
            {

                string file = Path.Combine(Config.EmailPath, "POMember.html");
                string buffer = u.ReadFromFile(file);

               //get the user 
                var us = new BusinessObjects.UsersBO();
                if (!us.LoadByPrimaryKey(order.Mid))
                {
                    msg = "Could not load member with id:" + order.Mid;
                    LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_OK);
                        
                    retVal = false;
                }
                else
                {
                    var memberEmail = u.ObjToString(us.Email);
                    if (memberEmail != "")
                    {
                        // end buffer gen

                        var link = Config.SITEURL + "/Order/OrderPrint?guid=" + printGUID;
                        buffer = buffer.Replace("%ORDERLINK", link);
                        buffer = buffer.Replace("%TOTAL", order.BizName);
                        buffer = buffer.Replace("%BIZNAME", order.BizName);
                        buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                        var subject = getTitle(buffer);
                        string retMsg = "";
                        retVal = sendEmail(subject, memberEmail, buffer,ref retMsg,"",fileAttachment);
                        msg = retMsg;
                    }
                    else
                    {
                        msg = "Member email for Web Order: " + order.Ponum + " could not be sent as the member: " + order.BizName + " has no email address";
                        LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                        retVal = true;
                    }
                }

            }
            catch (System.Exception ex)
            {
                retVal = false;
                msg="Could not send PO Member Email " + ex.ToString();
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                        

            }
            return retVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        static public bool SendPOTestEmailToAdmin(BusinessObjects.WtaPoBO order,string fileAttachment, ref string msg)
        {
            bool retVal = true;
            try
            {

                string file = Path.Combine(Config.EmailPath, "POAdminTest.html");
                string buffer = u.ReadFromFile(file);
                
                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
                buffer = buffer.Replace("%TOTAL", order.BizName);
                buffer = buffer.Replace("%BIZNAME", order.BizName);
                var subject = getTitle(buffer);
                string retMsg = "";


                //add salesman email
                string to = Config.BUSINESSEMAIL + ";" + Config.WEBMASTEREMAIL;
              
                retVal = sendEmail(subject, to, buffer, ref retMsg,"",fileAttachment);
                msg=retMsg;
            }
            catch (System.Exception ex)
            {
                retVal = false;
                msg="Could not send PO Admin Email " + ex.ToString();
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                
            }
            return retVal;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        static public bool SendPOEmailToAdmin(BusinessObjects.WtaPoBO order,string fileAttachment,string printGUID, ref string msg)
        {
            bool retVal = true;
            try
            {

                string file = Path.Combine(Config.EmailPath, "POAdmin.html");
                string buffer = u.ReadFromFile(file);
                
                //get the registration record
                var us = new BusinessObjects.UsersBO();
                if (!us.LoadByPrimaryKey(order.Mid))
                {
                    msg="Could not load member with id:" + order.Mid;
                    LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                }

                var ini = us.SlmInit;
                var s = new BusinessObjects.V5SalesManBO();

                if (!s.LoadByInitial(ini))
                {
                    msg="Could not load with Salesman INI :" + ini;
                    LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                }



                // end buffer gen
                var link = Config.SITEURL + "/Order/OrderPrint?guid=" + printGUID;
                buffer = buffer.Replace("%ORDERLINK", link);


                buffer = buffer.Replace("%TOTAL", order.BizName);
                buffer = buffer.Replace("%BIZNAME", order.BizName);
                buffer = buffer.Replace("%VERSION", UI.OBJECTS.ApplicationInfo.ExecutingAssemblyVersion.ToString());
         
                var subject = getTitle(buffer);
                string retMsg = "";
                
                //add salesman email
                string to = Config.BUSINESSEMAIL + ";" + Config.WEBMASTEREMAIL;
                if (!string.IsNullOrEmpty(s.Email))
                {
                    to += ";" + s.Email;
                }

                retVal = sendEmail(subject, to, buffer, ref retMsg,"",fileAttachment);
                msg=retMsg;

            }
            catch (System.Exception ex)
            {
                retVal = false;
                msg="Could not send PO Admin Email " + ex.ToString();
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.EMAIL_ERROR);
                
            }
            return retVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="om"></param>
        private static string makeOrderBufferUNUSED(string buffer, MODELS.OrderModel om)
        {
            buffer = buffer.Replace("%CUSTID", om.Custid);
            buffer = buffer.Replace("%BIZNAME", om.BizName);
            buffer = buffer.Replace("%ORDERDATE", om.CreateDate);
            buffer = buffer.Replace("%ORDERNUM", om.Ponum.ToString());
            buffer = buffer.Replace("%STATUS", om.StatusUCode);
            buffer = buffer.Replace("%REQDATE", om.RequestedDeliveryDateAndTime);
            
            buffer = buffer.Replace("%SHIPDATE", om.ShipDate);
            buffer = buffer.Replace("%COMMENT", om.Comment);
            buffer = buffer.Replace("%SUBTOTAL", om.MerchTotal);
            buffer = buffer.Replace("%TAXTOTAL", om.TaxTotal);
            buffer = buffer.Replace("%TOTAL", om.GrandTotal);

            string polines = "";


            foreach (var item in om.Lines)
            {

                string poline = "<tr>";

                poline += "<td>" + item.LineNum + "</td>";
                poline += "<td>" + item.QTY + "</td>";
                poline += "<td>" + item.UOM + "</td>";
                poline += "<td>" + item.ProductCode + "</td>";
                poline += "<td>" + item.ProductDescription + "</td>";
                poline += "<td>" + item.InventoryItem.SummaryMsg + "</td>";
                poline += "<td style='text-align:right'>" + item.UnitAmount + "</td>";
                poline += "<td style='text-align:right'>" + item.TotalWeight + "</td>";
                poline += "<td style='text-align:right'>" + item.TotalAmount + "</td>";
                poline += "</tr>";

                polines += poline;
            }
            return buffer.Replace("%POLINES", polines);

        }
    }

}


