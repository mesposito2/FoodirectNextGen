using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u = CSA.UTILITY.MyUtility;



namespace UI.MODELS
{


    public class MarketingEmailBlastListModel
    {
        public List<MarketingEmailBlastModel> Items
        {
            get;
            set;
        }


        public MarketingEmailBlastListModel()
        {
           
        }
        public MarketingEmailBlastListModel(BusinessObjects.V5EmailBlastCollection col)
        {

            Items = new List<MarketingEmailBlastModel>();

            foreach (BusinessObjects.V5EmailBlastBO i in col)
            {
                Items.Add(new MODELS.MarketingEmailBlastModel(i));
            }
        }
    }

    public class MarketingEmailBlastAttachmentModel
    {
        public int EmailBlastAttachmentID { get; set; }
        public int EmailBlastID { get; set; }
        public DateTime CreatedByDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public String AttachmentPath{ get; set; }
        public String OriginalFileName { get; set; }
        


        public MarketingEmailBlastAttachmentModel(BusinessObjects.V5EmailBlastAttachmentBO item)
        {
            EmailBlastAttachmentID = u.ObjToInt(item.EmailBlastAttachmentID);
            EmailBlastID = u.ObjToInt(item.EmailBlastID.Value);
            CreatedByDate = u.ObjToDateTime(item.CreatedByDate);
            CreatedBy = u.ObjToDateTime(item.CreatedBy);
            AttachmentPath = u.ObjToString(item.AttachmentPath);
            OriginalFileName = u.ObjToString(item.OriginalFileName);

        }
    }
    public class MarketingEmailBlastModel
    {



        public int EmailBlastID { get; set; }
        public DateTime CreatedByDate { get; set; }
        public string CreatedBy { get; set; }

        public DateTime SentDate { get; set; }
        public string StatusUCODE { get; set; }
        public string DisplayMode { get; set; }



        [Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; }


        public string EmailFrom { get; set; }
        public string ToUCODE { get; set; }


        //[Required(ErrorMessage = "Please enter custom TO email adress(es).")]
        public string ToOther { get; set; }
        public string ToOtherValidationMsg { get; set; }

        public string ToSent { get; set; }

        [Required(ErrorMessage = "Please enter a message body.")]
        [Display(Name = "Body")]
        public string Body { get; set; }

        public int OriginalEmailBlastID { get; set; }
        public string LogFile { get; set; }

        public List<MarketingEmailBlastAttachmentModel> Attachments { get; set; }

        public MarketingEmailBlastModel()
        {
            EmailBlastID = 0;
            CreatedBy = OBJECTS.SecurityHelper.UserName;
            StatusUCODE = "NEW";
            Subject = "";
            EmailFrom = "";
            ToUCODE = "NONEU";
            ToOther = "";
            ToSent = "";
            Body = "";
            ToOtherValidationMsg = "";
            DisplayMode = "EDIT";
            LogFile = "";
            Attachments = new List<MarketingEmailBlastAttachmentModel>();
        }

        public MarketingEmailBlastModel(BusinessObjects.V5EmailBlastBO item)
        {

            EmailBlastID = u.ObjToInt(item.EmailBlastID.Value);
            CreatedByDate = u.ObjToDateTime(item.CreatedByDate);
            CreatedBy = u.ObjToString(item.CreatedBy);

            SentDate = u.ObjToDateTime(item.SendDate);
            StatusUCODE = u.ObjToString(item.StatusUCODE);
            Subject = u.ObjToString(item.Subject);

            EmailFrom = u.ObjToString(item.EmailFrom);
            ToUCODE = u.ObjToString(item.ToUCODE);
            ToOther = u.ObjToString(item.ToOther);
            ToSent = u.ObjToString(item.ToSent);
            Body = u.ObjToString(item.Body);
            OriginalEmailBlastID = u.ObjToInt(item.OrginalEmailBlastID);
            DisplayMode = "EDIT";
            LogFile = u.ObjToString(item.LogFile);
            Attachments = new List<MarketingEmailBlastAttachmentModel>();

            //Attachments
            foreach (BusinessObjects.V5EmailBlastAttachmentBO oi in item.Attachments)
            {
                Attachments.Add(new MODELS.MarketingEmailBlastAttachmentModel(oi));
            }
        }
        
    }
}