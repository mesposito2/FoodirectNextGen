using System;

namespace UI.EXPERTPDF
{
    /// <summary>
    /// This class is used as an Xml serializable version of the ExpertPdf PdfDocumentInfo object.
    /// Instances of this class are served up through the services interface and are used to set values
    /// in the ExpertPdf PdfDocumentInfo object.  Each property in this object maps directly to
    /// a property in the ExpertPdf.HtmlToPdf.PdfDocumentInfo object.
    /// For documentation on each property, please refer to the docs for that object.
    /// </summary>
    public class PdfDocumentInfo
    {
        private string application;
        private string authorName;
        private DateTime createdDate;
        private string keywords;
        private string subject;
        private string title;

    
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public string Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
