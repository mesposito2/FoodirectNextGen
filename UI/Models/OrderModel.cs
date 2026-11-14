using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u = CSA.UTILITY.MyUtility;
using System.Data;



namespace UI.MODELS
{
    public class OrderQueryAndViewModel
    {
        public OrdersXParmsModel XparmsModel { get; set; }
        public OrderViewModel ViewModel { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public OrderQueryAndViewModel(OrdersXParmsModel x, OrderViewModel v)
        {
            Page = 1;
            PageSize = 20;
            XparmsModel = x;
            ViewModel = v;

        }

    }
    public class OrdersXParmsModel
    {
        public string FilterType { get; set;}
        public string QueryType { get; set; }
        public string Filter { get; set; }
        public string Title { get; set; }
        public string SortOrder { get; set; }
        public string SortField { get; set; }
        public string Search { get; set; }
       
        
        public OrdersXParmsModel()
        {
        
            QueryType = "'ALL'";
            Filter = "''";
            Title = "Your Order";
            FilterType = "JSON";
            Search = "";
        }


    }

    public  class Ager
    {
        public double CurrentWeek { get; set; }
        public double Week1 { get; set; }
        public double Week2 { get; set; }
        public double Week3 { get; set; }
        public double Week4 { get; set; }
        public double Week5 { get; set; }
        public double Week6 { get; set; }
        public double TotalAmount { get; set; }

        public Ager(BusinessObjects.UsersBO user)
        {
            CurrentWeek = 0;
            Week1 = 0;
            Week2 = 0;
            Week3 = 0;
            Week4 = 0;
            Week5 = 0;
            Week6 = 0;
            TotalAmount = 0;

            if (user.AgerCurrent.HasValue)
                CurrentWeek = user.AgerCurrent.Value;

            if (user.AgerWeek1.HasValue)
                Week1 = user.AgerWeek1.Value;

            if (user.AgerWeek2.HasValue)
                Week2 = user.AgerWeek2.Value;

            if (user.AgerWeek3.HasValue)
                Week3 = user.AgerWeek3.Value;

            if (user.AgerWeek4.HasValue)
                Week4 = user.AgerWeek4.Value;

            if (user.AgerWeek5.HasValue)
                Week5 = user.AgerWeek5.Value;

            if (user.AgerWeek6.HasValue)
                Week6 = user.AgerWeek6.Value;

            TotalAmount = CurrentWeek + Week1 + Week2 + Week3 + Week4 + Week5 + Week6;
            TotalAmount = Math.Round(TotalAmount, 2);

        }
    }



    /// <summary>
    /// Product View Model for Kendo - Contains Just a list 
    /// </summary>
    public class OrderViewModel
    {
        public List<OrderModel> Orders { get; set; }
        public int TotalCount { get; set; }
        public double TotalCost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Ager Ager { get; set; }

    }



    /// <summary>
    /// Product List Model
    /// </summary>
    public class OrdersListModel : List<OrderModel>
    {
        public OrdersListModel()
        {
        }
        public OrdersListModel(DataSet ds,BusinessObjects.UsersBO user,double totalAmountLimit=0)
        {

            double totalAmount=0; 

            foreach (DataRow drOrder in ds.Tables[0].Rows)
            {
                var m = new MODELS.OrderModel(drOrder, user);
                this.Add(m);
           

                if (totalAmountLimit > 0)
                {
                    totalAmount += m.GrandTotalValue;
                    if (totalAmountLimit>=totalAmount)
                    {
                        break;
                    }
                }

            }
        }
    }


    /// <summary>
    /// This is the main Order Model 
    /// It includes a list of OrderItem Models. 
    /// </summary>
    public class OrderModel
    {
        public string PrintLinkHashGuid { get; set; }
        public bool HasProduceProducts {
            get {
                var flag = false;
                if (this.Lines != null)
                {
                    foreach (var l in this.Lines)
                    {
                        if (l.IsProduce)
                        {
                            flag = true;
                        }
                    }
                }
                return flag;
            }
        }
        public bool HasNoStockProducts
        {
            //does not apply to produce items - those are always orderd the next day - so just return false those... 


            get
            {

                var flag = false;
                if (this.Lines != null)
                {
                    foreach (var l in this.Lines)
                    {
                        if (l.InventoryItem.SummaryMsg == "Not In-stock" && l.IsProduce == false)
                        {
                            flag = true;
                        }
                    }
                }
                return flag;
            }
        }
        public bool HasReducedInvProducts
        {
            //does not apply to produce items - those are always orderd the next day - so just return false for those... 

            get
            {
                var flag = false;
                if (this.Lines != null)
                {
                    foreach (var l in this.Lines)
                    {
                        if (l.InventoryItem.SummaryMsg != "Not In-stock" && l.IsProduce == false)
                        {
                            if (l.UOM == "CS" && l.QTY > l.InventoryItem.CaseQty)
                            {
                                flag = true;
                            }
                            if (l.UOM == "PC" && l.QTY > l.InventoryItem.PieceQty)
                            {
                                flag = true;
                            }
                        }

                    }
                }
                return flag;
            }
        }

        public List<OrderItemModel> Lines
        {
            get;
            set;
        }

        public string LogisticsModel { get; set; }
        public string NameComment { get; set; }
        public string SpecialMessage { get; set; } = string.Empty;

        public int Poid { get; set; }
        public string Custid { get; set; }
        public string BizName { get; set; }
        //public string ShipAddress {get;set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }

        public string PostDate { get; set; }

        public string StatusUCode { get; set; }
        public string ShipDate { get; set; }
        public string Ponum { get; set; }
        public string FDRInvoice { get; set; }
        public string TaxTotal { get; set; }
        public string MerchTotal { get; set; }
        public string FDRSalesMan { get; set; }
        public int TotalCount { get; set; }
        public string GrandTotal { get; set; }
        public double GrandTotalValue { get; set; }
        public int ItemCount { get; set; }
        public bool CanEdit { get; set; }

        public string Comment { get; set; }
        //public string RequestedDeliveryTime { get; set; }
        public string RequestedDeliveryDateAndTime { get; set; }

        public OrderModel(DataRow drOrder, BusinessObjects.UsersBO user)
        {
            var o = new BusinessObjects.WtaPoBO(drOrder);
            //This should be done in the BLL
            o.BizName = u.ObjToString(drOrder["bizname"]);


            fromBO(o, user);
        }

        public OrderModel(BusinessObjects.WtaPoBO order, BusinessObjects.UsersBO user)
        {
            fromBO(order, user);
        }
        void fromBO(BusinessObjects.WtaPoBO order, BusinessObjects.UsersBO user)
        {


            LogisticsModel = u.ObjToString(order.LogisticsModel);
            if (LogisticsModel == string.Empty)
            {
                LogisticsModel = "P";
            }
            NameComment = u.ObjToString(order.NameComment);

            Poid = order.Poid.Value;
            Custid = order.Mid;
            BizName = order.BizName;
            //ShipAddress = user.Addrjess1 + "<br>" + user.Address2 + "<br>" + user.City + " " + user.State + " " + user.Zip + "-" + user.Zip4;
            CreateDate = order.Createdate.Value.ToShortDateString();
            PostDate = order.Postdate.Value.ToShortDateString();
            CreatedBy = order.Createdbyname;
            StatusUCode = order.StatusUCode;
            ShipDate = order.Shipdate.HasValue ? order.Shipdate.Value.ToShortDateString() : "";
            Ponum = order.Ponum;
            Comment = order.Pocomment==null?"":order.Pocomment;
            FDRInvoice = order.FDRInvoice;
            var mt = order.MerchTotal.HasValue ? order.MerchTotal.Value : 0;
            //3/9//2023 - do not take the rebate off the fina price
            //Per Jason
            //mt += order.TotalRebate.HasValue ? order.TotalRebate.Value : 0;
            
            var tt = order.TaxTotal.HasValue ? order.TaxTotal.Value : 0;

            //7/13/2023 - use 4 decinals 

            /*
            TaxTotal = u.FormatCurrency(tt);
            MerchTotal = u.FormatCurrency(mt);
            GrandTotal = u.FormatCurrency(mt);
            */


            TaxTotal = OBJECTS.ProductHelper.FormatCurrency4Dec(tt);
            MerchTotal = OBJECTS.ProductHelper.FormatCurrency4Dec(mt);
            GrandTotal = OBJECTS.ProductHelper.FormatCurrency4Dec(mt);


            GrandTotalValue = mt;


            RequestedDeliveryDateAndTime = UI.OBJECTS.MyHelper.MakeSimpleDateTimeString(order.RequestedDeliveryTime);



            bool hasRolandWarning = false;

            FDRSalesMan = order.FDRSalesMan;
            Lines = new List<OrderItemModel>();

            foreach (var line in order.POlines)
            {
                var oim = new OrderItemModel(line,order.StatusUCode);
                Lines.Add(oim);

                //Figure out here if we need special Message
                //Bad hardcoding.... bad bad... 
                if (oim.ProductCode == "RMO")
                {
                    hasRolandWarning = true;
                }

            }
            ItemCount = Lines.Count();
            CanEdit = order.StatusUCode == "NEW"  && !OBJECTS.SecurityHelper.IsAdmin(); //|| order.StatusUCode == "READY";

            if (hasRolandWarning)
            {
                SpecialMessage += @"
<b>ROLAND MANDARIN ORANGES 24/11OZ #64006</b>
<br>
Consuming this product can expose you to chemicals including lead, 
which is known to the state of California to cause birth defects or other reproductive harm. 
For more information go to <a href='http://www.P65Warnings.ca.gov/food' target='_blank'>www.P65Warnings.ca.gov/food</a>
";
            }


         }
    
    }
    /// <summary>
    /// This is the OrderItem Model 
    /// It is used for an individual Order Line Item
    /// </summary>
    public class OrderItemModel
    {
        public int Polid { get; set; }
        public int LineNum { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int QTY { get; set; }
        public string UOM { get; set; }
        //public double UnitWeight { get; set; }
        public string UnitAmount { get; set; }
        public string TotalWeight { get; set; }
        public string ProductWeight { get; set; }
        //added 8/20/2021
        public string WeightType { get; set; }

        public string TotalAmount { get; set; }
        public string Taxamount { get; set; }
        public int CaseCount { get; set; }
        public string CatID { get; set; }
        public string ScatID { get; set; }

        public InventoryItemModel InventoryItem { get; set; }
        public string Comment { get; set; }
        public string LineType { get; set; }
        public bool IsProduce { get; set; }

        public OrderItemModel()
        {
            InventoryItem = new InventoryItemModel(); 
        }

        public OrderItemModel(BusinessObjects.WtaPoLineBO line,string statusUCODE)
        {
            
            InventoryItem = new InventoryItemModel();

            //not sure if this is the right field or not here.
            //But the model will not care. 
            Comment = line.VendorComment;

            Polid = line.Polid.Value;
            LineNum = line.LineNum.Value;
            ProductCode = line.Productcode;
            CatID = line.Catid;
            ScatID = line.Scatid;
            ProductDescription = line.Productdescription;
            LineType = line.LineTypeUCode;
            //UNDONE Note when the A/V change is made - this will also change....
            IsProduce = OBJECTS.ProductHelper.IsProduce(line);

            QTY = 0;
            if (line.Qty.HasValue)
            {
                QTY = u.ObjToInt(line.Qty.Value);
            }
           UOM = line.Um;
            
           var p = line.Productweight.HasValue ? line.Productweight.Value : 0;
           ProductWeight = "";
           if (p > 0)
           {
                ProductWeight = String.Format("{0:0.00}", p);
            }
            var w = line.Weight.HasValue?line.Weight.Value:0;
            TotalWeight = String.Format("{0:0.00}",w);


            if (IsProduce && (statusUCODE == "NEW" || statusUCODE == "POSTED" || statusUCODE == "READY"))
            {
                UnitAmount = "Market Price";
                TotalAmount = "";
                Taxamount = "";
            }
            else
            {


                //7/13/2023 - use 4 decinal places
                /*
                UnitAmount = u.FormatCurrency(line.Wprice.HasValue ? line.Wprice.Value : 0);
                TotalAmount = u.FormatCurrency(line.Amount.HasValue ? line.Amount.Value : 0);
                Taxamount = u.FormatCurrency(line.Taxamount.HasValue ? line.Taxamount.Value : 0);
                */
                //OBJECTS.ProductHelper.FormatCurrency4Dec(prod.Lbpc.Value)

                UnitAmount = OBJECTS.ProductHelper.FormatCurrency4Dec(line.Wprice.HasValue ? line.Wprice.Value : 0);
                TotalAmount = OBJECTS.ProductHelper.FormatCurrency4Dec(line.Amount.HasValue ? line.Amount.Value : 0);
                Taxamount = OBJECTS.ProductHelper.FormatCurrency4Dec(line.Taxamount.HasValue ? line.Taxamount.Value : 0);



                if (statusUCODE == "NEW" || statusUCODE == "POSTED" || statusUCODE == "READY")
                {

                    if (u.ObjToString(line.WeightType) == "W")
                    {
                        TotalWeight = "EST " + TotalWeight;
                    }
                }
            }
            CaseCount = line.Casecount.HasValue?line.Casecount.Value:1;
            CaseCount = CaseCount == 0 ? 1 : CaseCount;

            if (LineType == "REBATE")
            {
                ProductDescription = "* REBATE ON THE ABOVE LINE *";
                //UnitAmount = "";
                //TotalWeight = "";
            }
        }
    }

    /// <summary>
    /// This is the Order Model that is used for the Order Item Add Dialog that gets Popped up when someone is adding a 
    /// Order Item from a product list. 
    /// </summary>
    public class OrderAddItemModel
    {
        [Required(ErrorMessage = "Please enter an Quantity")]
        [Display(Name = "Quantity")]
        public int QTY { get; set; }
 
        [Required(ErrorMessage = "Please enter a unit of Measure")]
        [Display(Name = "Unit of Measure")]
        public string UOM { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [Display(Name = "Inventory Info:")]
        public string InventoryInfo { get; set; }


        public int CaseCount { get; set; }

        public OrderAddItemModel()
        {
            QTY = 1;
            UOM = "CS";
            CaseCount = 1;
        }

    }
}