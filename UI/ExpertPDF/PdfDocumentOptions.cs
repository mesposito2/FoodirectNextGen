namespace UI.EXPERTPDF
{
    /// <summary>
    /// This class is used as an Xml serializable version of the ExpertPdf PdfDocumentOptions object.
    /// Instances of this class are served up through the services interface and are used to set values
    /// in the ExpertPdf PdfDocumentOptions object.
    /// </summary>
    public class PdfDocumentOptions
    {
        private bool adjustCharSpacing;
        private int bkgTransparency;
        private int bottomMargin;
        private bool embedFonts;
        private bool generateSelectablePdf;
        private int imgTransparency;
        private bool isLandscape;
        private int leftMargin;
        private bool liveUrlsEnabled;
        private string pdfCompressionLevel;
        private string pdfPageOrientation;
        private int pdfPageSize;
        private int rightMargin;
        private bool showFooter;
        private bool showHeader;
        private int topMargin;
        private int pageHeight;
        private int pageWidth;

        public bool AdjustCharSpacing
        {
            get { return adjustCharSpacing; }
            set { adjustCharSpacing = value; }
        }

        public int BkgTransparency
        {
            get { return bkgTransparency; }
            set { bkgTransparency = value; }
        }

        public int BottomMargin
        {
            get { return bottomMargin; }
            set { bottomMargin = value; }
        }

        public bool EmbedFonts
        {
            get { return embedFonts; }
            set { embedFonts = value; }
        }

        public bool GenerateSelectablePdf
        {
            get { return generateSelectablePdf; }
            set { generateSelectablePdf = value; }
        }

        public int ImgTransparency
        {
            get { return imgTransparency; }
            set { imgTransparency = value; }
        }

        public bool IsLandscape
        {
            get { return isLandscape; }
            set { isLandscape = value; }
        }

        public int LeftMargin
        {
            get { return leftMargin; }
            set { leftMargin = value; }
        }

        public bool LiveUrlsEnabled
        {
            get { return liveUrlsEnabled; }
            set { liveUrlsEnabled = value; }
        }

        public string PdfCompressionLevel
        {
            get { return pdfCompressionLevel; }
            set { pdfCompressionLevel = value; }
        }

        public string PdfPageOrientation
        {
            get { return pdfPageOrientation; }
            set { pdfPageOrientation = value; }
        }

        public int PdfPageSize
        {
            get { return pdfPageSize; }
            set { pdfPageSize = value; }
        }

        public int RightMargin
        {
            get { return rightMargin; }
            set { rightMargin = value; }
        }

        public bool ShowFooter
        {
            get { return showFooter; }
            set { showFooter = value; }
        }

        public bool ShowHeader
        {
            get { return showHeader; }
            set { showHeader = value; }
        }

        public int TopMargin
        {
            get { return topMargin; }
            set { topMargin = value; }
        }

        /// <summary>
        /// Both the PageHeight and PageWidth must be set for each to have an effect.
        /// </summary>
        public int PageHeight
        {
            get { return pageHeight; }
            set { pageHeight = value; }
        }

        /// <summary>
        /// Both the PageHeight and PageWidth must be set for each to have an effect.
        /// </summary>
        public int PageWidth
        {
            get { return pageWidth; }
            set { pageWidth = value; }
        }
    }
}
