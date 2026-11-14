using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessObjects;
using u = CSA.UTILITY.MyUtility;

namespace UI.OBJECTS
{
    public class OrderHelper
    {
        static void csvAddField(ref string line,string value)
        {
            if (line!=string.Empty)
            {
                line += ",";
            }
            //get Rid of double quotes
            value = value.Replace("\"", "'");
            //get rid of comments
            value = value.Replace(",", "_");

            line += String.Format("\"{0}\"",value);
        }


        public static bool BuildCSVOrder(MODELS.OrderModel m, ref string csvOutput)
        {
            csvOutput = "";
            var retVal = true;
            var line = "";


            line = "";
            csvAddField(ref line, "Message");
            csvAddField(ref line, m.SpecialMessage);
            csvOutput += line + "\n";



            line = "";
            csvAddField(ref line, "Web Order");
            csvAddField(ref line, m.Ponum);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Status");
            csvAddField(ref line, m.StatusUCode);
            csvOutput += line + "\n";

            line = "";
            if (m.StatusUCode == "CLOSED")
            {
                csvAddField(ref line, "Invoice Number");
                csvAddField(ref line, m.FDRInvoice);
                csvOutput += line + "\n";
            }

            line = "";
            csvAddField(ref line, "Customer ID");
            csvAddField(ref line, m.Custid);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Customer Name");
            csvAddField(ref line, m.BizName);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Order Date");
            csvAddField(ref line, m.CreateDate);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Logistics Model");
            csvAddField(ref line, m.LogisticsModel=="D"?"DELIVERY":"PICKUP");
            csvOutput += line + "\n";


            line = "";
            csvAddField(ref line, "Requested Date");
            csvAddField(ref line, m.RequestedDeliveryDateAndTime);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Ship/Pickup Date");
            csvAddField(ref line, m.ShipDate);
            csvOutput += line + "\n";


            line = "";
            csvAddField(ref line, "Route/Truck Name");
            csvAddField(ref line, m.NameComment);
            csvOutput += line + "\n";


            line = "";
            csvAddField(ref line, "Customer Comment");
            csvAddField(ref line, m.Comment);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Line Num");
            csvAddField(ref line, "QTY");
            csvAddField(ref line, "Code");
            csvAddField(ref line, "Description");
            csvAddField(ref line, "Comment");
            csvAddField(ref line, "Unit Price");
            csvAddField(ref line, "Total Weight");
            csvAddField(ref line, "UOM"); 
            csvAddField(ref line, "Total Price");
            csvOutput += line + "\n";


            foreach (var item in m.Lines)
            {

                line = "";

                if (item.LineType == "REBATE")
                {
                    csvAddField(ref line, "");
                    csvAddField(ref line, "");
                    csvAddField(ref line, "");
                    csvAddField(ref line, "*REBATE ON ABOVE LINE *");
                    csvAddField(ref line, "");

                }
                else
                {

                    csvAddField(ref line, u.ObjToString(item.LineNum));
                    csvAddField(ref line, u.ObjToString(item.QTY));
                     csvAddField(ref line, item.ProductCode);
                    csvAddField(ref line, item.ProductDescription);
                    csvAddField(ref line, item.Comment);
                }

                csvAddField(ref line, item.UnitAmount);
                csvAddField(ref line, item.TotalWeight);
                csvAddField(ref line, item.UOM);
                csvAddField(ref line, item.TotalAmount);
                csvOutput += line + "\n";

            }

            line = "";
            csvAddField(ref line, "Tax-Total");
            csvAddField(ref line, m.TaxTotal);
            csvOutput += line + "\n";

            line = "";
            csvAddField(ref line, "Total");
            csvAddField(ref line, m.GrandTotal);
            csvOutput += line + "\n";

            
            return retVal;
        }
        public static MODELS.OrderModel GetOrderModel(int poid)
        {
            BusinessObjects.WtaPoBO order = null;
            BusinessObjects.UsersBO user = null;

            if (SecurityHelper.Role == Roles.MEMBER)
            {
                order = OrderHelper.GetExistingOrder(SecurityHelper.UserName);
                if (order == null)
                {
                    //order has not been created yet
                    //Let's just chuck an error for now. 
                    throw new ApplicationException("An order has not been created yet.");
                }
            }
            else
            {
                order = new BusinessObjects.WtaPoBO();
                if (!order.LoadByPrimaryKey(u.ObjToInt(poid)))
                {
                    throw new ApplicationException("Could not load PO with POID of " + poid);

                }
                //check to see of this is the right user
                if (SecurityHelper.Role == Roles.MEMBER)
                {
                    if (order.Mid != SecurityHelper.CustID)
                    {
                        throw new ApplicationException("Opps!, are you trying to see someone else's order? " + poid);

                    }
                }
            }
            user = new UsersBO();
            user.LoadByPrimaryKey(order.Mid);
            var om = new MODELS.OrderModel(order, user);
            OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(om);

            return om;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static BusinessObjects.WtaPoBO GetCreateExistingOrder(string userName)
        {
            var us = new BusinessObjects.UsersBO();
            us.LoadByInternetID(userName);
            var oid = MySession.ORDERID;
            var order = new WtaPoBO();
            if (oid == 0)
            {
                order.Mid = us.Custid;
                order.Createdby = userName;
                order.Createdbyname = userName;
                order.Lastupdateby = userName;
                order.Lastupdatebyname = userName;
                
                order.StatusUCode = OBJECTS.OrderStatus.NEW.ToString();
                order.Status = u.ObjToInt(OBJECTS.OrderStatus.NEW);

                order.Vendormid = "FOODD";
                order.Vendorname = "Foodirect, Inc.";
                order.FDRSalesMan = "";
                //order.Shipdate = 

                order.RequestedDeliveryTime = OBJECTS.MyHelper.GetNextWeekDay(); 
                order.Ponum = Guid.NewGuid().ToString();
                order.Save();
                order.Ponum = makePONum(order.Poid.Value );                
                order.Save();
                MySession.ORDERID = order.Poid.Value;

            }
            else
            {
                order.LoadByPrimaryKey(oid);
            }

            return order;
        }
        static string makePONum(int poid)
        {
            var retVal=poid.ToString();
            retVal="W"+u.Replicate("0", 7 - retVal.Length)+retVal;
            return retVal;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static BusinessObjects.WtaPoBO GetExistingOrder(string userName)
        {
            var u = new BusinessObjects.UsersBO();
            u.LoadByInternetID(userName);
            var oid = MySession.ORDERID;
            WtaPoBO order=null; 
            if (oid != 0)
            {
                order = new WtaPoBO();
                if (!order.LoadByPrimaryKey(oid))
                {
                    order = null;
                }
            }

            return order;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetCurrentOrderItemCount(string username)
        {
            WtaPoBO order = GetExistingOrder(username);
            if (order == null)
            {
                return 0;
            }
            else
            {
                return order.POlines.Count();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poid"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static BusinessObjects.WtaPoBO CopyOrder(int poid, BusinessObjects.UsersBO user)
        {
            //first load the existing order
            
            var osource = new BusinessObjects.WtaPoBO();
            if (!osource.LoadByPrimaryKey(poid))
            {
                throw new ApplicationException("Could not load the Order with id: " + poid + " to copy to a new order.");
            }

            //now create a basic new order
            //UNDONE: This code is repeated above

            var order= new BusinessObjects.WtaPoBO();
                order.Mid = user.Custid;
                order.Createdby = SecurityHelper.CustID; 
                order.Createdbyname = SecurityHelper.UserName;
                order.Lastupdateby = SecurityHelper.CustID;
                order.Lastupdatebyname = SecurityHelper.UserName;
                
                order.StatusUCode = OBJECTS.OrderStatus.NEW.ToString();
                order.Status = u.ObjToInt(OBJECTS.OrderStatus.NEW);

                order.Vendormid = "FOODD";
                order.Vendorname = "Foodirect, Inc.";
                order.FDRSalesMan = "";
                order.Shipdate = OBJECTS.MyHelper.GetNextWeekDay(); 
                order.RequestedDeliveryTime = order.Shipdate;
                order.Ponum = Guid.NewGuid().ToString();
                //order.Ponum="testc";
                order.Save();
                order.Ponum = makePONum(order.Poid.Value);
                order.Save();
                order.Pocomment = osource.Pocomment;
                MySession.ORDERID = order.Poid.Value;
                order.Save();

            //now for each line item - 
            int c=0;

            foreach (var line in osource.POlines)
            {
                var b=AddItemToOrder(order,line.Productcode,u.ObjToInt(line.Qty.Value) ,line.Um,line.VendorComment, ref c);
            }

            return order;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="productCode"></param>
        /// <param name="QTY"></param>
        /// <param name="UOM"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool AddItemToOrder(BusinessObjects.WtaPoBO order, string productCode, int QTY, string UOM, string comment, ref int count)
        {
            bool lineExists = false;

            int lineID = 0;
            foreach (var line in order.POlines)
            {
                if (line.Productcode == productCode && line.Um == UOM)
                {
                    lineID = line.Polid.Value;
                    lineExists = true;
                }
            }
            var newline = new WtaPoLineBO();

            if (lineExists)
            {
                newline.LoadByPrimaryKey(lineID);
                newline.Qty += QTY;
            }
            else
            {
                int nextLineNum = order.POlines.Count + 1;
                //add a new line
                newline.Poid = order.Poid;
                newline.LineNum = nextLineNum;
                newline.Qty = QTY;
                newline.Um = UOM;
            }

            //4/22/2024-  Load the product but make sure to replace it with the product code sub if it exists, 
            var x = new ProdsBO();
            ProdsBO p;
            x.LoadByPrimaryKeyAndCustID(productCode, SecurityHelper.CustID);
            if (String.IsNullOrEmpty(x.ProductCodeSub))
            {
                p = x;
            }
            else
            {
                p=new ProdsBO();
                p.LoadByPrimaryKeyAndCustID(x.ProductCodeSub, SecurityHelper.CustID);

            }


            
            newline.VendorComment = comment;
            newline.Productcode = p.Productcode;
            newline.Catid = p.Catid;
            newline.Scatid = p.Scatid;
            newline.Productdescription = p.Description;
            //dup all in vendir fields
            //6/4/2024 - changed this fron productcode sub -
            //Unclear why this had been changed in the 4/22/2024 change
            //but was set to p,ProductCodeSub - which is not correct. 
            newline.Vendorcode = p.Productcode;

            newline.Casecount = p.Casecount;
            newline.Taxable = u.ObjToString(p.Taxable) == "T" ? 1 : 0;
            newline.WeightType = p.WeightType;


            //now calc line values   
            var ux = new UsersBO();
            ux.LoadByPrimaryKey(order.Mid);
            double salesTaxRate = ux.GetSalesTaxRate();
            //sales tax happens in the Recalc
            if (!UI.OBJECTS.ProductHelper.IsProduce(newline))
            {
                calcLine(newline, p, salesTaxRate, ux.Taxable);
            }
            newline.Save();
            
            RecalcAndSaveOrder(order,SecurityHelper.CustID ,false);
            count = order.POlines.Count;
            //order.Save();
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <param name="productCode"></param>
        static void  calcLine(WtaPoLineBO line, string productCode, double salesTaxRate,string custTaxableCode)
        {
            var p=new ProdsBO();
           if (p.LoadByPrimaryKeyAndCustID(productCode,SecurityHelper.CustID))
            {
                 calcLine(line, p, salesTaxRate,custTaxableCode);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <param name="p"></param>
        static void  calcLine(WtaPoLineBO line, BusinessObjects.ProdsBO p, double salesTaxRate,string custTaxableCode)
        {


            bool showPrice = true;
            if (p.OnPriceList.HasValue)
            {
                showPrice = p.OnPriceList.Value;
            }

            bool custTaxable = u.ObjToString(custTaxableCode) == "T";
            bool prodTaxable= u.ObjToString(p.Taxable)=="T"; 

            //force case count
            if (p.Casecount == 1)
            {
                line.Um = "CS";
            }



            line.Wprice = 0;
            if (line.Um == "CS")
            {
                if (showPrice)
                {
                    line.Wprice = p.Lbcs;
                }
               

                line.Weight = u.ObjToDouble(p.Weight * line.Qty);
            }
            else
            {
                if (showPrice)
                {
                    line.Wprice = p.Lbpc;
                }
                line.Weight = u.ObjToDouble(line.Qty * System.Math.Round(u.ObjToDouble(p.Weight / p.Casecount), 2));
            }


            //7/13/2023 - change rounding to 4 decials... 
            line.Amount=System.Math.Round(u.ObjToDouble(line.Wprice * line.Weight),4);

            if (custTaxable && prodTaxable)
            {
                line.Taxamount = System.Math.Round(u.ObjToDouble(line.Amount * salesTaxRate), 4);
            }
            else
            {
                line.Taxamount = 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="custid"></param>
        /// <param name="updateLines"></param>
        public static void RecalcAndSaveOrder(BusinessObjects.WtaPoBO order,string custid,bool updateLines=true)
        {
            order.RefreshLines();
            var ub = new UsersBO();
            ub.LoadByPrimaryKey(order.Mid);
            double salesTaxRate = ub.GetSalesTaxRate();

            order.MerchTotal = 0;
            order.TaxTotal = 0;
            foreach (var line in order.POlines)
            {
                if (updateLines)
                {
                    //don't show prices or calculate produce.... 
                    if (!UI.OBJECTS.ProductHelper.IsProduce(line))
                    {
                        calcLine(line, line.Productcode, salesTaxRate, ub.Taxable);
                    }
                }
                order.MerchTotal += u.ObjToDouble(line.Amount); //to double just in case its null
                order.TaxTotal += u.ObjToDouble(line.Taxamount);
            }

            order.Lastupdateby = custid;
            order.Lastupdate = DateTime.Now;
            //this.MerchTotal = 0;
            //this.TaxTotal = 0;
            //this.FreightTotal = 0;
            order.POlines.Save();
            order.Save();
        }

    }
}