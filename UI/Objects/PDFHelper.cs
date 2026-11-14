using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

using u = CSA.UTILITY.MyUtility;
using System.Net;
using ExpertPdf.HtmlToPdf;
using BusinessObjects;

namespace UI.OBJECTS
{
    public class PDFHelper
    {
        /// <summary>
        /// Get a ready to go byte based PDF Buffer, derived title and derived file name from a URL
        /// </summary>
        /// <param name="url">Input URL</param>
        /// <param name="bufferOut">Output Byte Buffer</param>
        /// <param name="title">Output Title</param>
        /// <param name="fileName">Output fileName</param>
        /// <param name="msg">Output Message</param>
        /// <returns>True or False - If False - then msg will have a reason</returns>
        public static bool GetPDFFileBufferFromURL(string url, ref byte[] bufferOut, ref string title, ref string fileName, ref string msg)
        {
          
            bool retVal = true;
            try
            {
                string htmlBuffer = "";
                UI.OBJECTS.MyHelper.URLToHTML(url, "", ref htmlBuffer);
                if (htmlBuffer == "")
                {
                    retVal = false;
                    msg = "Could not get HTML for the path: " + url;
                }
                title = UI.OBJECTS.MyHelper.GetTitleFromHTML(htmlBuffer);
                bufferOut = null;
                var xMsg = "";
                if (!UI.OBJECTS.PDFHelper.MakePDFBuffer(htmlBuffer, title, ref bufferOut, ref xMsg))
                {

                    retVal = false;
                    msg += "GetPDFFileBufferFromURL - Could not create PDF Binary Buffer from - "+url +" : "+ xMsg;
                }

                fileName = UI.OBJECTS.MyHelper.CreateFileName(title) + ".pdf";

            }
            catch (System.Exception ex)
            {
                msg += "GetPDFFileBufferFromUR  - Exception Creating PDF Binary Buffer from - "+url+" : " + ex.Message;
                LogHelper.WebLogAdd(WebMsgType.ERR, ex.ToString(), WebLogAction.SYSTEM_ERROR);

                retVal = false;

            }
            return retVal;
        }
        /// <summary>
        /// Get a ready to rock PDF Buffer from an HTML string
        /// </summary>
        /// <param name="htmlFileBuffer">HTML string </param>
        /// <param name="title">Title to encode into the PDF Buffer</param>
        /// <param name="bufferOut">PDF Buffer Out</param>
        /// <param name="msg">Output Message</param>
        /// <returns>True or False - If False - then msg will have a reason</returns>
        public static bool MakePDFBuffer(string htmlFileBuffer, string title, ref byte[] bufferOut, ref string msg)
        {

            DateTime startdt;
            DateTime enddt;
            bool retVal = true;

            try
            {
                string serverVerify = string.Empty;
                string pdfName = string.Empty;

                var pdfConverter = new ExpertPdf.HtmlToPdf.PdfConverter();

                //Old version
                if (UI.OBJECTS.Config.EXPERTPDF != "")
                {
                    pdfConverter.LicenseKey = UI.OBJECTS.Config.EXPERTPDF;
                }     
                //Get this stuff from a config file. 
                pdfConverter.PdfDocumentInfo.AuthorName = Config.AUTHORNAME;
                pdfConverter.PdfDocumentInfo.CreatedDate = DateTime.Now;
                pdfConverter.PdfDocumentInfo.Title = title;
                pdfConverter.PdfDocumentInfo.Keywords = title;
                pdfConverter.PdfDocumentInfo.Subject = title;


                //set to only what the FDJobmaster has 
               
                pdfConverter.PageWidth = 750;
                pdfConverter.PdfDocumentOptions.LeftMargin = 15;
                pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = true;



                //pdfConverter.PdfDocumentOptions.TopMargin = 20; 
                //pdfConverter.PdfDocumentOptions.LeftMargin = 20; 
                //pdfConverter.PdfDocumentOptions.RightMargin = 20; 
                //pdfConverter.PdfDocumentOptions.BottomMargin = 20;
                //pdfConverter.PageWidth = 1024; //set both to the default

                //pdfConverter.PdfDocumentOptions.FitWidth = false;
                //pdfConverter.PdfDocumentOptions.AutoSizePdfPage =true;
                //pdfConverter.PageHeight = 0;

                //pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = true;
                //pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
                //pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.Letter;


                //string htmlString = CSA.UTILITY.MyUtility.ReadFromFile(htmlFile);
                startdt = DateTime.Now;
              
                bufferOut = pdfConverter.GetPdfBytesFromHtmlString(htmlFileBuffer);
          
                enddt = DateTime.Now;
                TimeSpan duration = enddt - startdt;
                //l.Msg("PDF file retrieved in: " + duration.Hours.ToString() + ":" + duration.Minutes.ToString() + ":" + duration.Seconds.ToString());
                retVal = true;

            }
            catch (System.Exception ex)
            {
                msg = "makePDFBuffer Error " + ex.ToString();
                retVal = false;
            }
            return retVal;
        }
    }
}