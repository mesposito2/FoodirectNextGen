using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class EmailInfo
    {
        private string to;
        private string replyTo;
        private string from;
        private string cc;
        private string bcc;
        private string htmlBody;
        private string body;
        private string subject;
        private ArrayList attachments;

        public string To
        {
            get
            {
                return this.to;
            }
            set
            {
                this.to = value;
            }
        }

        public string ReplyTo
        {
            get
            {
                return this.replyTo;
            }
            set
            {
                this.replyTo = value;
            }
        }

        public string From
        {
            get
            {
                return this.from;
            }
            set
            {
                this.from = value;
            }
        }

        public string CC
        {
            get
            {
                return this.cc;
            }
            set
            {
                this.cc = value;
            }
        }

        public string BCC
        {
            get
            {
                return this.bcc;
            }
            set
            {
                this.bcc = value;
            }
        }

        public string HTMLBody
        {
            get
            {
                return this.htmlBody;
            }
            set
            {
                this.htmlBody = value;
            }
        }

        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.body = value;
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }

        public ArrayList Attachments
        {
            get
            {
                return this.attachments;
            }
        }

        public EmailInfo()
        {
            this.to = string.Empty;
            this.replyTo = string.Empty;
            this.from = string.Empty;
            this.cc = string.Empty;
            this.bcc = string.Empty;
            this.htmlBody = string.Empty;
            this.body = string.Empty;
            this.subject = string.Empty;
            this.attachments = new ArrayList();

        }

        public override string ToString()
        {
            return string.Format("To:{0}\nFrom:{1}\nSubject: {2}", (object)this.To, (object)this.From, (object)this.Subject);
        }
    }
}