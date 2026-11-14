using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Mail;

namespace BusinessObjects
{



    public class Email
    {
        private string smtpServer;
        private bool useAuthentication;
        private string userName;
        private string userPassword;

        public Email()
        {
            this.smtpServer = "localhost";
            this.useAuthentication = false;
            this.userName = string.Empty;
            this.userPassword = string.Empty;
        }

        public Email(string smtpServer)
        {
            this.smtpServer = "localhost";
            this.useAuthentication = false;
            this.userName = string.Empty;
            this.userPassword = string.Empty;

            this.smtpServer = smtpServer;
        }

        public Email(string smtpServer, string userName, string userPassword)
        {
            this.smtpServer = "localhost";
            this.userName = string.Empty;
            this.userPassword = string.Empty;

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
                message.ReplyTo = new MailAddress(ei.ReplyTo);
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
            if (this.useAuthentication)
            {
                smtpClient.Host = this.smtpServer;
                if (!string.IsNullOrEmpty(this.userName) && !string.IsNullOrEmpty(this.userPassword))
                    smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential(this.userName, this.userPassword);
            }
            smtpClient.Send(message);
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
                msg = ex.Message;
                info = ex.StackTrace;
            }
            return flag;
        }
    }
}

