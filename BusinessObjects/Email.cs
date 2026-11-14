using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using u = CSA.UTILITY.MyUtility;

namespace BusinessObjects
{



    public class Email
    {
        private string smtpServer;
        private bool useAuthentication;
        private string userName;
        private string userPassword;
        private string smtpPort;

        public Email()
        {
            this.smtpServer = "localhost";
            this.useAuthentication = false;
            this.userName = string.Empty;
            this.userPassword = string.Empty;
            this.smtpPort = string.Empty;
        }

        public Email(string smtpServer)
        {
            this.smtpServer = "localhost";
            this.useAuthentication = false;
            this.userName = string.Empty;
            this.userPassword = string.Empty;

            this.smtpServer = smtpServer;
        }
        public Email(string smtpServer, string port)
        {
            this.smtpServer = "localhost";
            this.useAuthentication = false;
            this.userName = string.Empty;
            this.userPassword = string.Empty;

            this.smtpServer = smtpServer;
            this.smtpPort = port;
        }


        public Email(string smtpServer, string port, string userName, string userPassword)
        {
            this.smtpServer = "localhost";
            this.userName = string.Empty;
            this.userPassword = string.Empty;

            this.smtpServer = smtpServer;
            this.useAuthentication = true;
            this.userName = userName;
            this.userPassword = userPassword;
            this.smtpPort = port;
      
        }
        public Email(string smtpServer,string userName, string userPassword)
        {
            this.smtpServer = "localhost";
            this.userName = string.Empty;
            this.userPassword = string.Empty;
            this.smtpPort = "";

            this.smtpServer = smtpServer;
            this.useAuthentication = true;
            this.userName = userName;
            this.userPassword = userPassword;
        }

        public void Send(EmailInfo ei)
        {
            MailMessage message = new MailMessage();
            string to = ei.To;
            char[] chArray1 = new char[1]
      {
        ';'
      };
            foreach (string str in to.Split(chArray1))
            {
                if (str.Trim() != string.Empty)
                    message.To.Add(str.Trim());
            }
            string cc = ei.CC;
            char[] chArray2 = new char[1]
      {
        ';'
      };
            foreach (string str in cc.Split(chArray2))
            {
                if (str.Trim() != string.Empty)
                    message.CC.Add(str.Trim());
            }
            string bcc = ei.BCC;
            char[] chArray3 = new char[1]
      {
        ';'
      };
            foreach (string str in bcc.Split(chArray3))
            {
                if (str.Trim() != string.Empty)
                    message.Bcc.Add(str.Trim());
            }
            if (ei.ReplyTo != string.Empty)
            {
                message.ReplyTo = new MailAddress(ei.ReplyTo);
            }
            message.Subject = ei.Subject;
            message.From = new MailAddress(ei.From);
            foreach (string fileName in ei.Attachments)
            {
                Attachment attachment = new Attachment(fileName);
                message.Attachments.Add(attachment);
                
            }
            if (ei.HTMLBody != string.Empty)
            {
                message.IsBodyHtml = true;
                message.Body = ei.HTMLBody;
            }
            else
            {
                message.IsBodyHtml = false;
                message.Body = ei.Body;
            }
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = this.smtpServer;
            if (u.ObjToInt(smtpPort) != 0)
            {
                smtpClient.Port = u.ObjToInt(smtpPort);
            }
            if (this.useAuthentication)
            {
                smtpClient.Host = this.smtpServer;
                if (!string.IsNullOrEmpty(this.userName) && !string.IsNullOrEmpty(this.userPassword))
                    smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential(this.userName, this.userPassword);
            }
           // if (false)
           // {
                smtpClient.Send(message);
            //}
        }

        public bool SendAndCatchError(EmailInfo ei, ref string msg, ref string info)
        {
            bool flag = true;
            try
            {
                    this.Send(ei);
            }
            catch (Exception ex)
            {
                flag = false;
                msg = string.Format("{0} - Mail Settings--host:{1}-port:{2}:account{3}", ex.Message, this.smtpServer, this.smtpPort, this.userName);
                info = ex.ToString();
            }
            return flag;
        }
    }
}

