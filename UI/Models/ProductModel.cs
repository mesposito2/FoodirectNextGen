using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using u = CSA.UTILITY.MyUtility;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{

    public class ProductQueryAndViewModel
    {
       public ProductsXParmsModel XparmsModel {get; set;}
       public ProductViewModel ViewModel {get; set;}
       public int Page { get; set; }
       public int PageSize { get; set; }
     

     public ProductQueryAndViewModel(ProductsXParmsModel x,ProductViewModel v)
     {
         Page = 1;
         PageSize = 20;
         XparmsModel = x;
         ViewModel = v;
         
     }

    }
    public class ProductsXParmsModel
    {
        public string QueryType { get; set; }
        public string Filter { get; set; }
        public string Title { get; set; }
        public string DisplayMode {get;set;}
        public string SubSearch { get; set; }
        public string SortOrder { get; set; }
        public string SortField { get; set; }

        public SelectList CatSelectList { get; set; }
        public SelectList ScatSelectList { get; set; }
        public SelectList GroupSelectList { get; set; }

        public string QS_Mode {get;set;}
        public string QS_ProductAutoComplete {get;set;} 
        public string QS_XLabel {get;set;}
        public string QS_XData {get;set;}
        public string QS_ProductABC { get; set; }

       public ProductsXParmsModel(List<MODELS.NameValuePairModel> catList, 
           string catSelectedValue, 
           List<MODELS.NameValuePairModel> groupList, 
           string groupSelectedValue,
           List<MODELS.NameValuePairModel> scatList=null, 
           string scatSelectedValue="")
        {
                  //should look like - single quotes OK
                  /*
                    data: {
                           queryType:"DEFAULT",
                           filter: { filters: [{ field: "Mike", operator: "eq", value: "Keelin" }], logic: "and" } 
                           }
                    */
    
            QueryType = "'DEFAULT'";
            Filter = "''";
            Title = "Products";
            DisplayMode = "PRODUCT";
            CatSelectList =  new SelectList(catList,"Value","Name",catSelectedValue);
            GroupSelectList = new SelectList(groupList, "Value", "Name",groupSelectedValue);
          
            if (scatList!=null)
            {
                ScatSelectList = new SelectList(scatList, "Value", "Name", scatSelectedValue);
            }

        }


     }


    public class InventoryItemModel
    {
         [Display(Name = "Inventory Pieces")]
         public string PieceInfo { get; set; }
         [Display(Name = "Inventory Cases")]
         public string CaseInfo { get; set; }
         [Display(Name = "Breakable?")]
         public string CaseBreakableInfo { get; set; }
         [Display(Name = "Next Delivery")]
         public string NextDelivery { get; set; }
         
        
         
         [Display(Name = "In Stock?")]
         public string OutOfStockInfo { get; set; }
         [Display(Name = "Inventory Summary")]
         public string SummaryMsg { get; set; }

         public int PieceQty { get; set; }
         public int CaseQty { get; set; }


        public InventoryItemModel()
        {
            var na = "(Not Available)";
            PieceInfo = na;
            CaseInfo = na;
            CaseBreakableInfo ="";
            NextDelivery = na;
          
            OutOfStockInfo = na;
            SummaryMsg = na;

            PieceQty = 0;
            CaseQty = 0;
        }
    

    }



    
    public class ProductSearch
    {
        public string ProductSearchText { get; set; }
    }

    public class ProductModel
    {
        
        
        [Display(Name = "DBDescription")]
        public string DBDescription { get; set; }

        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [Display(Name = "Product Name")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        [Display(Name = "Sub Cat")]
        public string SubCategoryName { get; set; }


        [Display(Name = "Business")]
        public string Business { get; set; }


        [Display(Name = "Case lb/unit")]
        public string Weight { get; set; }

        [Display(Name = "Case Price")]
        public string LBCS { get; set; }

        [Display(Name = "Piece Price")]
        public string LBPC { get; set; }

        [Display(Name = "Pieces Per Case")]
        public string PiecesPerCase { get; set; }

        [Display(Name = "Case Count")]
        public string CaseCount { get; set; }


        [Display(Name = "Average Weight")]
        public string AverageWeight { get; set; }

        [Display(Name = "On Price List?")]
        public string OnPriceList { get; set; }


        [Display(Name = "Price Increase?")]
        public string PriceIncrease
        {
            get;
            set;

        }
        [Display(Name = "Last Order Date")]
        public string LastDate
        {
            get;
            set;

        }

        public InventoryItemModel InventoryItem
        {
            get;
            set;
        }

        [Display(Name = "Is Favorite")]
        public bool IsFavorite { get; set; }

        [Display(Name = "On Speed List")]
        public bool OnSpeedList { get; set; }

        [Display(Name = "On Current Order")]
        public bool OnCurrentOrder { get; set; }


        //12/10/17 for SalesMan View
        [Display(Name = "Average Cost")]
        public string AVGCost { get; set; }

        [Display(Name = "Market Cost")]
        public string MARKETCost { get; set; }

        [Display(Name = "Salesman Display Cost")]
        public string SALESDISPLAYCost { get; set; }


        public bool IsProduce { get; set; }

        //4/22/2024 - Additional Fields
        [Display(Name = "Product Substitution Code")]
        public string ProductCodeSub { get; set; }
        [Display(Name = "Do Not Sell")]
        public bool DoNotSell { get; set; }
        [Display(Name = "Arrow Prod")]
        public bool ArrowProd { get; set; }




        /// <summary>
        /// 
        /// </summary>
        public ProductModel()
        {
            InventoryItem = new InventoryItemModel();
        }
        /// <summary>
        /// Constructor - Create a Product Model from the data row 
        /// </summary>
        /// <param name="dr">Data Row from vwProds - This done to get the fields that are a nornal part of the Prods record</param>
        public ProductModel(DataRow dr)
        {
            InventoryItem = new InventoryItemModel();
            ///
            var prod = new BusinessObjects.ProdsBO(dr);


            this.CategoryName = dr["categoryname"].ToString();
            this.SubCategoryName = dr["subcategoryname"].ToString();

            this.OnCurrentOrder = false;
            this.OnSpeedList = false;
            this.IsFavorite = false;
            this.LastDate = "";         
            if (dr.Table.Columns.Contains("oncurrentorder"))
                this.OnCurrentOrder = u.ObjToBool(dr["oncurrentorder"]);

            if (dr.Table.Columns.Contains("onspeedlist"))
                this.OnSpeedList = u.ObjToBool(dr["onspeedlist"]);

              if (dr.Table.Columns.Contains("lastDate"))
            {
                var x = u.ObjToDateTime(dr["lastDate"]);
                if (x != DateTime.MinValue)
                {
                    this.LastDate = x.ToShortDateString();
                }
            }

            if (dr.Table.Columns.Contains("isfavorite"))
                this.IsFavorite = u.ObjToBool(dr["isfavorite"]);

            if (dr.Table.Columns.Contains("groupcode"))
                this.Business= u.ObjToString(dr["groupcode"]);
       
            //Populate some additional fields. 
            fromBO(prod);
        }
        
        /// <summary>
        /// Create a Product Model from an BO Object 
        /// </summary>
        /// <param name="prod">prod - </param>
        public ProductModel(BusinessObjects.ProdsBO prod)
        {
            InventoryItem = new InventoryItemModel();
            fromBO(prod);
        }
        /// <summary>
        /// update a product model with data from a ProdBO
        /// use for all constructors - created by a DR or  by a Prods Object
        /// </summary>
        /// <param name="prod"></param>
        void fromBO(BusinessObjects.ProdsBO prod)
        {
            bool showPrice = true;
            this.OnPriceList = "Yes";
            if (prod.OnPriceList.HasValue)
            {
                this.OnPriceList = (prod.OnPriceList.Value ? "Yes" : "No");
                showPrice = prod.OnPriceList.Value;
            }
            
            
            
            this.ProductCode = prod.Productcode;
            this.DBDescription = prod.Description;
            this.Description = ProductCode + " - " + DBDescription;
            this.Business = ""; //not in BO object yet
           

            var w = prod.Weight.HasValue ? prod.Weight.Value : 1;
            this.Weight = w.ToString() + (w == 1 ? " unit" : " lb");
             
            var cc = prod.Casecount.HasValue ? prod.Casecount.Value : 1;
            cc = cc == 0 ?  1 : cc;
            this.CaseCount = cc.ToString();
            var bPiece = (cc > 1);
            this.PiecesPerCase = bPiece ? cc.ToString() : "";


            this.AverageWeight = "";
            this.LBPC = "";
            if (bPiece)
            {
                AverageWeight = string.Format("{0:0.00}", (w / cc)) + " lb";
             //   this.LBPC = prod.Lbpc.HasValue ? u.FormatCurrency(prod.Lbpc.Value) : "";
                this.LBPC = prod.Lbpc.HasValue ? OBJECTS.ProductHelper.FormatCurrency4Dec(prod.Lbpc.Value) : "";

                if (!showPrice)
                {
                    this.LBPC = "na";
                }
            }
            this.LBCS = prod.Lbcs.HasValue ? OBJECTS.ProductHelper.FormatCurrency4Dec(prod.Lbcs.Value) : "";
            if (!showPrice)
            {
                this.LBCS = "na";
            }

            this.PriceIncrease = "No";
            if (prod.LastPOCost.HasValue && prod.NextCost.HasValue)
            {
                if (prod.LastPOCost.Value != 0 && prod.NextCost.Value != 0)
                {
                    if (prod.NextCost > prod.LastPOCost)
                    {
                        this.PriceIncrease = "Yes";
                    }
                }
            }

            //12/10/2017 - Average and Market Costs for Salesman
            //Per Jason the database may be out of sync. 
            //In the meantine - make the switch in the model
            //"So I feel like your AVG COST field should say MRKT COST.  
            //Your ADJCOST should say AVG COST.  Make sense?  Like your database is labeled backwards."
           
            //Only show if case price is OK...
            if (this.LBCS == "na")
            {
                this.SALESDISPLAYCost = "na";

            }
            else
            {
                this.MARKETCost = prod.AvgCost.HasValue ? u.FormatCurrency(prod.AvgCost.Value) : "na"; //Always show this
                this.AVGCost = prod.AdjCost.HasValue ? u.FormatCurrency(prod.AdjCost.Value) : "na"; //Only show this in there is no Market Cost
                this.SALESDISPLAYCost = AVGCost;
            }

            //UNDONE Note when the A/V change is made - this will also change....
            this.IsProduce = UI.OBJECTS.ProductHelper.IsProduce(prod);


            //4/22/2024 - Additional Fields
            ProductCodeSub = u.ObjToString(prod.ProductCodeSub);
            DoNotSell = prod.DoNotSell.HasValue ? prod.DoNotSell.Value : false;
            ArrowProd = prod.ArrowProd.HasValue ? prod.ArrowProd.Value : false;

        }
    }
    /// <summary>
    /// Product View Model for Kendo - Contains Just a list 
    /// </summary>
    public class ProductViewModel
    {
        public List<ProductModel> Products { get; set; }
        public int TotalCount { get; set; }
  }


    
    /// <summary>
    /// Product List Model
    /// </summary>
        public class ProductListModel : List<ProductModel>
        {
            public ProductListModel()
            {
            }
            public ProductListModel(DataSet ds)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    this.Add(new MODELS.ProductModel(dr));
                }
            }
        }
    
}