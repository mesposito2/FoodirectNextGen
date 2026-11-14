using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using u = CSA.UTILITY.MyUtility;
using e = CSA.UTILITY.MyEncrypt;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{

    public class TOCBookModel
    {
        public string Category { get; set; }
        public int Page { get; set; }
        public List<TOCBookModel> SubCats { get; set; }

        public TOCBookModel()
        {
            SubCats = new List<TOCBookModel>();
        }
    }
    public class PageBookModel
    {

        public int PageNum { get; set; }
        public string Type { get; set; }

        //stuff for an Add
        public string AdImage { get; set; }
        public string AdAltText { get; set; }

        //Stuff for a page of Text
        public string CategoryName { get; set; }

        public Dictionary<string, int> SubCats { get; set; }

        public MODELS.ProductListModel Products { get; set; }

        public PageBookModel()
        {
            SubCats = new Dictionary<string, int>();
        }

    }

    public class BookModel
    {

        //defaults - we can set these n the CSHTML
        //number of TOC Lines in a TOC Page
        public int TocPageSize { get; set; } = 50;

        //Number of Products Per Page
        public  int ProductPageSize { get; set; } = 35;

        //How many subcats should be shown per TOC subnat row. 
        public int TocSubCatCol { get; set; } = 4;

        //how many lines does a cat need in the TOC
        public int TocCatLead { get; set; } = 2;

        //How many lines does a subcat need in the TOC
        public int TocSubCatLead { get; set; } = 1;



        ProductListModel products;
        int bookConfigID;

        public bool ShowPrices { get; set; }
        public PersonModel Business { get; set; }
        public DateTime CurrenDate { get; set; }
        public List<PageBookModel> Pages { get; set; }

        public List<List<TOCBookModel>> TOC;



        public BookModel(PersonModel business, DateTime currentDate, ProductListModel products)
        {
            this.Business = business;
            this.CurrenDate = currentDate;
            this.products = products;

            var col = new BusinessObjects.BookConfigCollection();
            var q = new BusinessObjects.BookConfigQuery();
            q.Where(q.IsCurrent.Equal(true));
            if (!col.Load(q))
            {
                throw new ApplicationException("Could not find current book settings");
            }
            bookConfigID = col[0].BookConfigID.Value;
            this.ShowPrices = u.ObjToBool(col[0].ShowPrices.Value);
            //Never show prices for Foodirect
            if (business.CustID == "FOODD")
            {
                this.ShowPrices = false;
            }



            buildPages();
            buildTOC();
        }

        private void buildPages()
        {
            //get the ads
            var ads = new Dictionary<int, AdModel>();
            var col = new BusinessObjects.BookConfigAdCollection();
            var q = new BusinessObjects.BookConfigAdQuery();
            q.Where(q.BookConfigID.Equal(this.bookConfigID));
            if (col.Load(q))
            {
                foreach (var o in col)
                {
                    var ad = new BusinessObjects.AdBO();
                    ad.LoadByPrimaryKey(o.AdID.Value);
                    ads.Add(o.PageNum.Value, new AdModel(ad));
                }
            }

            //now build out pages

            int pageCtr = 0;
            int pageLineCtr = 0;
            PageBookModel page = null;
            this.Pages = new List<PageBookModel>();
            string oldCat = "";




            foreach (var p in products)
            {

                if (p.LBCS == "na")
                    p.LBCS = "";

                if (p.LBPC == "na")
                    p.LBPC = "";




                //var currentCat = u.ObjToString(p.CategoryName).Trim().ToUpper();
                //7/12/2021 - Per Jason - include sub cats

                var currentCat = u.ObjToString(p.CategoryName).Trim().ToUpper();
                var currentSubCat = u.ObjToString(p.SubCategoryName).Trim().ToUpper();


                if (currentCat != oldCat || pageLineCtr == ProductPageSize)
                {

                    oldCat = currentCat;
                    //new page
                    pageCtr++;

                    //If this page is supposed to be an image - add it
                    if (ads.ContainsKey(pageCtr))
                    {
                        page = new PageBookModel();
                        page.PageNum = pageCtr;
                        page.Type = "AD";
                        var ad = ads[pageCtr];
                        page.AdImage = ad.AdImage;
                        page.AdAltText = ad.AltText;
                        this.Pages.Add(page);
                        pageCtr++;
                    }

                    //continue with the page break code 
                    //and add the page we would do normally
                    pageLineCtr = 0;
                    page = new PageBookModel();
                    page.PageNum = pageCtr;
                    page.CategoryName = oldCat;
                    page.Products = new MODELS.ProductListModel();
                    page.Type = "PRODUCTS";
                    this.Pages.Add(page);

                }
                if (!page.SubCats.ContainsKey(currentSubCat))
                {
                    page.SubCats.Add(currentSubCat, pageCtr);
                }
                page.Products.Add(p);
                pageLineCtr++;

            }

        }
        private void buildTOC()
        {
            this.TOC = new List<List<TOCBookModel>>();
            var oldcat = "";
            int tocLineCTR = 0;
            int tocSubCatCtr = 0;
            

            //var lineCounter;
            List<TOCBookModel> l = null;
            l = new List<TOCBookModel>();
            var bGo = true;
            TOCBookModel t = null;

            while (bGo)
            {
                for (var i = 0; i < this.Pages.Count; i++)
                {
                    var p = this.Pages[i];

                    //collate table of contents entries
                    var newCat = p.CategoryName;
                    if ((newCat != oldcat) && p.Type != "AD")
                    {
                        if (t != null)
                        {
                            l.Add(t);
                          
                        }

                        t = new TOCBookModel();
                        oldcat = newCat;
                        t.Category = newCat;
                        t.Page = p.PageNum;
                        tocLineCTR += TocCatLead;                        
                    }

                    //Add this pages subcatrs to the existing t
                    foreach (var s in p.SubCats)
                    {
                        var xt = new TOCBookModel();
                        xt.Page = s.Value;
                        xt.Category = s.Key;
                        var check = t.SubCats.FirstOrDefault(item => item.Category == xt.Category);
                        if (check == null)
                        {
                            t.SubCats.Add(xt);
                            tocSubCatCtr++;
                            //4 is the  4 columns
                            if ((tocSubCatCtr % TocSubCatCol)==0)
                            {
                                tocLineCTR += TocSubCatLead;
                                tocSubCatCtr = 0;
                            }
                            
                        }

                   }

                    
                    //Add the last one... 
                    if (i == this.Pages.Count - 1)
                    {
                        l.Add(t);
                        bGo = false;
                    }

                    //start a new TOC Page
                    if (tocLineCTR >= TocPageSize)
                    {
                        tocLineCTR = 0;
                        TOC.Add(l);
                        l = new List<TOCBookModel>();
                    }
                }
            }
        }
    }
}

    
    

