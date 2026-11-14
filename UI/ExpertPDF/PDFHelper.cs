using System;
using System.Data;
using System.Configuration;
using System.Web;
using ExpertPdf.HtmlToPdf;

namespace UI.EXPERTPDF
{
    public class PDFHelper
    {
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfDocumentInfo"></param>
        /// <param name="pdfDocumentOptions"></param>
        /// <returns></returns>
        public static ExpertPdf.HtmlToPdf.PdfConverter GetPdfConverter(PdfDocumentInfo pdfDocumentInfo, PdfDocumentOptions pdfDocumentOptions)
        {
            ExpertPdf.HtmlToPdf.PdfConverter pdfConverter;

            if (pdfDocumentOptions == null)
                throw new ApplicationException("GetPdfConverter - document info cannot be null.");

            //if the document options is null, then get a converter set with "standard" options - you know, the base model
            //if (pdfDocumentOptions == null)
            //    pdfConverter = GetStdPdfConverter();
            //else
                pdfConverter = new ExpertPdf.HtmlToPdf.PdfConverter();

            //Old version
            if (UI.OBJECTS.Config.EXPERTPDF != "")
            {
                pdfConverter.LicenseKey = UI.OBJECTS.Config.EXPERTPDF;
            }
            //new version

            //set the expertpdf doc options from the object served up over the services interface
            SetExpertPdfDocOptions(ref pdfConverter, pdfDocumentOptions);

            //set the expertpdf doc info from the object served up over the services interface
            SetExpertPdfDocInfo(ref pdfConverter, pdfDocumentInfo);

            return pdfConverter;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfConverter"></param>
        /// <param name="pdfDocumentInfo"></param>
        public static void GetExpertPdfDocInfo(ref ExpertPdf.HtmlToPdf.PdfConverter pdfConverter, PdfDocumentInfo pdfDocumentInfo)
        {
            if (pdfConverter != null && pdfDocumentInfo != null)
            {
            
                pdfConverter.PdfDocumentInfo.AuthorName = pdfDocumentInfo.AuthorName;
                pdfConverter.PdfDocumentInfo.CreatedDate = pdfDocumentInfo.CreatedDate;
                pdfConverter.PdfDocumentInfo.Keywords = pdfDocumentInfo.Keywords;
                pdfConverter.PdfDocumentInfo.Subject = pdfDocumentInfo.Subject;
                pdfConverter.PdfDocumentInfo.Title = pdfDocumentInfo.Title;
            }
        }

       public static void SetExpertPdfDocInfo(ref ExpertPdf.HtmlToPdf.PdfConverter pdfConverter, PdfDocumentInfo pdfDocumentInfo)
        {
            if (pdfConverter != null && pdfDocumentInfo != null)
            {
                //pdfConverter.PdfDocumentInfo.Application = pdfDocumentInfo.Application;
                pdfConverter.PdfDocumentInfo.AuthorName = pdfDocumentInfo.AuthorName;
                pdfConverter.PdfDocumentInfo.CreatedDate = pdfDocumentInfo.CreatedDate;
                pdfConverter.PdfDocumentInfo.Keywords = pdfDocumentInfo.Keywords;
                pdfConverter.PdfDocumentInfo.Subject = pdfDocumentInfo.Subject;
                pdfConverter.PdfDocumentInfo.Title = pdfDocumentInfo.Title;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdfConverter"></param>
        /// <param name="pdfDocumentOptions"></param>
        public static void SetExpertPdfDocOptions(ref ExpertPdf.HtmlToPdf.PdfConverter pdfConverter, PdfDocumentOptions pdfDocumentOptions)
        {
            if (pdfConverter != null && pdfDocumentOptions != null)
            {
                //Not supported ? 
                //pdfConverter.PdfDocumentOptions.AdjustCharSpacing = pdfDocumentOptions.AdjustCharSpacing;
                //pdfConverter.PdfDocumentOptions.BkgTransparency = pdfDocumentOptions.BkgTransparency;
                //pdfConverter.PdfDocumentOptions.ImgTransparency = pdfDocumentOptions.ImgTransparency;
                
                pdfConverter.PdfDocumentOptions.EmbedFonts = pdfDocumentOptions.EmbedFonts;
                pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = pdfDocumentOptions.GenerateSelectablePdf;
                pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = pdfDocumentOptions.LiveUrlsEnabled;
                pdfConverter.PdfDocumentOptions.PdfPageOrientation = pdfDocumentOptions.IsLandscape ? PDFPageOrientation.Landscape : PDFPageOrientation.Portrait;
                pdfConverter.PdfDocumentOptions.ShowFooter = pdfDocumentOptions.ShowFooter;
                pdfConverter.PdfDocumentOptions.ShowHeader = pdfDocumentOptions.ShowHeader;

                pdfConverter.PdfDocumentOptions.BottomMargin = pdfDocumentOptions.BottomMargin;
                pdfConverter.PdfDocumentOptions.TopMargin = pdfDocumentOptions.TopMargin;
                pdfConverter.PdfDocumentOptions.LeftMargin = pdfDocumentOptions.LeftMargin;
                pdfConverter.PdfDocumentOptions.RightMargin = pdfDocumentOptions.RightMargin;
                
                pdfConverter.PageHeight = pdfDocumentOptions.PageHeight;
                pdfConverter.PageWidth = pdfDocumentOptions.PageWidth;

                //hard-coded values; these could be mapped to the CSA.Services.PdfDocumentOptions object later
                pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
                pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.Letter;
            }
        }

        /// <summary>
        /// Returns a pdf converter with "standard" document options.
        /// </summary>
        /// <returns></returns>
        /// 
        /*
        public static ExpertPdf.HtmlToPdf.PdfConverter GetStdPdfConverter()
        {
            ExpertPdf.HtmlToPdf.PdfConverter pdfConverter = new ExpertPdf.HtmlToPdf.PdfConverter();

            //set std options for the document
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.Letter;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            int margin = 20;
            pdfConverter.PdfDocumentOptions.LeftMargin = margin;
            pdfConverter.PdfDocumentOptions.RightMargin = margin;
            pdfConverter.PdfDocumentOptions.TopMargin = margin;
            pdfConverter.PdfDocumentOptions.BottomMargin = margin;

            pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = true;

            return pdfConverter;
        } */
        #endregion

    }
}
