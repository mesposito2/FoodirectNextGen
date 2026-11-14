using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using UI.OBJECTS;
using UI.MODELS;
using u = CSA.UTILITY.MyUtility;
using System.Diagnostics;
using System.Web.Script.Serialization;
using System.IO;


namespace UI.Controllers
{
    public class OrderController :  BaseController
    {

        public ActionResult RequestPrice(int polid)
        {

            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            
            //Build ViewBag & Model
            var line = new BusinessObjects.WtaPoLineBO();
            if (!line.LoadByPrimaryKey(polid))
            {
                throw new ApplicationException("PO Line does not exist" + u.ObjToString(polid));
            }
            var custID = SecurityHelper.CustID;
            var o = new BusinessObjects.UsersBO();
            if (!o.LoadByCustID(custID))
            {
                throw new ApplicationException("Could not load CustID :" + custID);
            }

            var ini = o.SlmInit;
            var s = new BusinessObjects.V5SalesManBO();

            if (!s.LoadByInitial(ini))
            {
                throw new ApplicationException("Could not load with Salesman INI :" + ini);
            }
            ViewBag.SalesManName = s.Name + " (" + s.Initial + ")";
            ViewBag.ProductName = line.Productdescription+" ("+line.Productcode + ")";
            //end view bag

            var m = new MODELS.SalesMessageModel();
            m.POLID = polid;
            m.Message = "What is the latest price for " + ViewBag.ProductName + "?";


            return View(m);
        }
        [HttpPost]
        public ActionResult RequestPrice(MODELS.SalesMessageModel m)
        {



            ensureSSL();
            //Build ViewBag & Model
            var line = new BusinessObjects.WtaPoLineBO();
            if (!line.LoadByPrimaryKey(m.POLID))
            {
                throw new ApplicationException("PO Line does not exist" + u.ObjToString(m.POLID));
            }
            var custID = SecurityHelper.CustID;
            var o = new BusinessObjects.UsersBO();
            if (!o.LoadByCustID(custID))
            {
                throw new ApplicationException("Could not load CustID :" + custID);
            }

            var ini = o.SlmInit;
            var s = new BusinessObjects.V5SalesManBO();

            if (!s.LoadByInitial(ini))
            {
                throw new ApplicationException("Could not load with Salesman INI :" + ini);
            }
            ViewBag.SalesManName = s.Name + " (" + s.Initial + ")";
            ViewBag.ProductName = line.Productcode + "-" + line.Productdescription;
            //end view bag

            if (EmailHelper.SendSalesmanPriceEmail(m.POLID, m.Message))
            {
                return RedirectToAction("Order", "Order", new { poid=line.Poid,msg = Server.HtmlEncode("Price Message sent to Salesman OK") });
            }
            else
            {
                base.SetDisplayMsg(WebMsgType.ERR, "Your sales rep could not be contacted", WebLogAction.UIMSG);
                return View(m);
            }
            
        }

        public ActionResult OrderFind()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.ADMIN);
            return View();
        }
        /// <summary>
        /// Show orders - main order list
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public ActionResult Orders(string mode,string startDT, string endDT,  string sf="createdate", string so="desc",  int page=1, string search = "")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
            OBJECTS.SecurityHelper.ThrowSQLInjection( mode, sf, so);

            var m = new MODELS.OrdersXParmsModel();
            m.SortField = sf;
            m.SortOrder = so;
            var orderBy = sf + " " + so;

            //This whole way of doing the filters as Json strings and then deserializing them was to 
            //support the old ajax Grid - We could as easily now make inline sql
            string memberFilter ="";
            string memberFilterSQL = "";
            if (OBJECTS.SecurityHelper.IsMember())
            {

                memberFilter = ",{field:'mid',operator:'eq',value:'"+OBJECTS.SecurityHelper.CustID + "'}";
                memberFilterSQL = "and (mid='"+ OBJECTS.SecurityHelper.CustID+"')";
            }


            
            if (string.IsNullOrEmpty(mode) || mode == "DEFAULT" || mode == "ALL")
            {
                m.Title = "All Orders";
                m.QueryType = "DEFAULT";
                m.Filter = "{ filters: [{ field: 'statusucode', operator: 'neq', value: 'NEWX' }"+memberFilter + "], logic: 'and' }";
            }
            if (mode=="SEARCH")
            {
                //The only reason we ever did this JSON Flter tyoe is when we did this with the old Kendo Grid
                //But now that we chucked that there is no reason to go through the brain damage of doing that 
                //so just create a SQL Version

                m.FilterType = "SQL";
                m.Title = "Search Orders for: "+search;
                m.Search = search;
                m.QueryType = "SEARCH";
                m.Filter = @"
(
    (FDRInvoice like '%@search%')
     or
    (ponum like '%@search%') 
     or
    (cast(poid as varchar(100)) like '%@search%') 
)";
                m.Filter=m.Filter.Replace("@search", search) + memberFilterSQL;

            }
            if (mode=="OPEN")
            {
                m.Title = " Open Orders";
                m.QueryType = "OPEN";
                m.Filter = "{ filters: [{ field: 'statusucode', operator: 'eq', value: 'NEW' }" + memberFilter + "], logic: 'and' }";
            }
            if (mode == "READY") //READY
            {
                m.Title = "Waiting to be Sent to Foodirect";
                m.QueryType = "READY";
                m.Filter = "{ filters: [{ field: 'statusucode', operator: 'eq', value: 'READY' }" + memberFilter + "], logic: 'and' }";
            } 
            if (mode == "POSTED") //Picked up
            {
                m.Title = "Posted";
                m.QueryType = "POSTED";
                m.Filter = "{ filters: [{ field: 'statusucode', operator: 'eq', value: 'POSTED' }" + memberFilter + "], logic: 'and' }";
            }
            //Priced does not look like it is used. 
            if (mode == "CLOSED")
            {
                m.Title = "Closed in the Last 30 days";
                m.QueryType = "CLOSED";
                string dtStart=DateTime.Today.AddDays(-30).ToShortDateString();

                m.Filter = "{ filters: [{ field: 'statusucode', operator: 'eq', value: 'CLOSED' },{ field: 'createdate', operator: 'gt', value: '" + dtStart + "' }" + memberFilter + "], logic: 'and' }";
            }
            var s = new JavaScriptSerializer();

            string filter = "";
            if (m.FilterType == "JSON")
            {
                if (m.Filter == "''")
                {
                    m.Filter = "";
                }
                var f = s.Deserialize<GridFilters>(m.Filter);
                filter = base.makeFilterExpression(f);
                //end Json filter coding and deserializatipon
            }
            else
            {
                filter = m.Filter;
            }
            //get the data
            var col = new BusinessObjects.WtaPoCollection();
            int totalCount = 0;
            string custID = "";
            custID = UI.OBJECTS.SecurityHelper.CustID;
            var user = new BusinessObjects.UsersBO();
            user.LoadByPrimaryKey(custID);
            var ds = col.GetPagedView(SecurityHelper.IsAdmin(), page, 15, orderBy, ref totalCount, custID, filter);
            var p = new MODELS.OrdersListModel(ds, user);

            //Create  the encapsulating view model -
            //This is so we can get Total count out where the Kendo Grid can use it 
            var pvm = new MODELS.OrderViewModel();
            pvm.Orders = p;
            pvm.TotalCount = totalCount;

            //we are not getting the total for this - 
            //but we will when we use the same model for 
            //The Bills. 
            pvm.TotalCost = 0;

            var pq = new OrderQueryAndViewModel(m, pvm);
            pq.PageSize = 15;
            pq.Page = page;

            return View(pq);
        }


        /// <summary>
        /// Print Order CSV
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ActionResult OrderCSV(string guid)
        {
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
            ensureSSL();
            
            var h = FDSHARED.HashHelper.Get(guid);
            if (h == null)
            {
                throw new ApplicationException("Could not load secure hash data with id: " + guid);

            }
            var poid = u.ObjToInt(h["poid"]);
            
            var order = new BusinessObjects.WtaPoBO();
            if (!order.LoadByPrimaryKey(poid))
            {
                throw new ApplicationException("Could not load PO with POID of " + poid);

            }
            var user = new UsersBO();
            user.LoadByPrimaryKey(order.Mid);
            var om = new MODELS.OrderModel(order, user);
            OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(om);


         
            var fileName = System.IO.Path.Combine(OBJECTS.Config.TEMPEXPORTPATH, "OrderExport_" + order.Ponum +"_" + Guid.NewGuid().ToString() + ".csv");

            // To write all of the text to the file
            string text = "";
            OrderHelper.BuildCSVOrder(om, ref text);
            System.IO.File.WriteAllText(fileName, text);

            //return View(om);
            return File(fileName, "text/csv", "Foodirect_Order_"+order.Ponum+".csv");
        }
        /// <summary>
        /// Print Order for Print or PDF Gen 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ActionResult OrderPrint(string guid,string mode)
        {
            //ensureSSL();

            ViewBag.MODE = mode;
        
        
            var h=FDSHARED.HashHelper.Get(guid);
            if (h == null)
            {
                throw new ApplicationException("Could not load secure hash data with id: " + guid);

            }
            var poid = u.ObjToInt(h["poid"]);
            //var title = h["title"];
         

            var order = new BusinessObjects.WtaPoBO();
            if (!order.LoadByPrimaryKey(poid))
            {
                throw new ApplicationException("Could not load PO with POID of " + poid);

            }
            var user = new UsersBO();
            user.LoadByPrimaryKey(order.Mid);
            var om = new MODELS.OrderModel(order, user);
            OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(om);
            return View(om);
        }
        /// <summary>
        /// View an Order
        /// </summary>
        /// <returns></returns>
        public ActionResult Order(string poid, string msg)
        {
            ensureSSL();



            var s = DateTime.Now.ToShortDateString() + " " + UI.OBJECTS.Config.ORDERCUTOFF;
            @ViewBag.CutOffDateTime = u.ObjToDateTime(s).ToShortDateString() + " " + u.ObjToDateTime(s).ToShortTimeString();

            var p = DateTime.Now.ToShortDateString() + " " + UI.OBJECTS.Config.PRODUCECUTOFF;
            @ViewBag.ProduceCutOffDateTime = u.ObjToDateTime(p).ToShortDateString() + " " + u.ObjToDateTime(p).ToShortTimeString();



            if (!string.IsNullOrEmpty(msg))
            {
                base.SetDisplayMsg(WebMsgType.OK, Server.HtmlDecode(msg), WebLogAction.UIMSG);
            }

            BusinessObjects.WtaPoBO order = null;
            BusinessObjects.UsersBO user = null;

            if (string.IsNullOrEmpty(poid)) //If there is no POID
            {
                //If they can order - create a new Order.
                if (SecurityHelper.Role == Roles.MEMBER && SecurityHelper.CANORDER)
                {
                    order = OrderHelper.GetCreateExistingOrder(SecurityHelper.UserName);
                    if (order == null)
                    {
                        //order has not been created yet
                        //Let's just chuck an error for now. 
                        throw new ApplicationException("An order has not been created yet.");
                    }
                }
                else//If they cannot order - yell at them. 
                {

                    //throw new ApplicationException("PO Number Required");
                    //throw new ApplicationException("You do not have the priviledges to edit or create an open order (1).");
                    //return RedirectToAction("register", "membership");
                    var msg1 = "You do not have the priviledges to edit or create an open order (1).";
                    LogHelper.WebLogAdd(WebMsgType.WAR, msg1, WebLogAction.ACCESS_DENIED);
                    RedirectAccessDenied(msg1);
                    return View();
                }
            }
            else //If there is a POID
            {
                order = new BusinessObjects.WtaPoBO();
                if (!order.LoadByPrimaryKey(u.ObjToInt(poid)))
                {
                    throw new ApplicationException("Could not load PO with POID of " + poid);

                }
                //If they cannot edit an order - and this order is not close - yell at them.
                if (!SecurityHelper.CANORDER && order.StatusUCode != "CLOSED")
                {

                    //throw new ApplicationException("You do not have the priviledges to edit or create an open order (2)." + poid);
                    var msg2 = "You do not have the priviledges to edit or create an open order (2).";
                    LogHelper.WebLogAdd(WebMsgType.WAR, msg2, WebLogAction.ACCESS_DENIED);
                    RedirectAccessDenied(msg2);
                    return View();
                }                
            }



            //Ok Now lets Process the order 

            //check to see of this is the right user
            if (SecurityHelper.Role == Roles.MEMBER)
            {
                if (order.Mid != SecurityHelper.CustID)
                {


                    var m = String.Format("SECURITY ALERT, An Order is being access w/o the correct Member ID - POID:{0} - PO Cust ID:{1} - Logged in ID:{2}.",
                        poid,
                        order.Mid,
                        SecurityHelper.CustID);
                    LogHelper.WebLogAdd(WebMsgType.ERR, m, WebLogAction.ACCESS_DENIED);
                    RedirectAccessDenied("You do not have the access to the Order.");
                }
            }
            
            //now we have cleared that - we can make the order. 
            user = new UsersBO();
            user.LoadByPrimaryKey(order.Mid);
            var om = new MODELS.OrderModel(order, user);
            if (om.StatusUCode != "PRICED" && om.StatusUCode != "CLOSED")
            {
                OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(om);
            }
            //stuff for the print link

            var h = new Dictionary<string, string>();
            h.Add("poid", om.Poid.ToString());
            om.PrintLinkHashGuid = FDSHARED.HashHelper.Set(h);

            //if they are editing an existing - set it as the current
            if (om.StatusUCode == "NEW")
            {
                MySession.ORDERID = om.Poid;
            }

            return View(om);

        }
        /// <summary>
        /// Post Back on an Order Form - Not yet Used. 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
         [HttpPost]
        public ActionResult Order()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var s = DateTime.Now.ToShortDateString() + " " + UI.OBJECTS.Config.ORDERCUTOFF;
            @ViewBag.CutOffDateTime = u.ObjToDateTime(s).ToShortDateString() + " " + u.ObjToDateTime(s).ToShortTimeString();
            s = DateTime.Now.ToShortDateString() + " " + UI.OBJECTS.Config.PRODUCECUTOFF;
            @ViewBag.ProduceCutOffDateTime = u.ObjToDateTime(s).ToShortDateString() + " " + u.ObjToDateTime(s).ToShortTimeString();

           
            var delPolid = u.ObjToInt(Request["delpolid"]);
            var poid=u.ObjToInt(Request["poid"]);
            var orderAction = u.ObjToString(Request["orderaction"]);
            var comment=u.ObjToString(Request["tacomment"]);
            var nameComment=u.ObjToString(Request["tanamecomment"]);
            var rDate = u.ObjToString(Request["datepicker"]);
            var rTime = u.ObjToString(Request["timepicker"]);
            var logisticsModel = u.ObjToString(Request["dlLogisticsModel"]);
            

            if (orderAction == "COPY")
            {
                var usc = new UsersBO();
                usc.LoadByInternetID(SecurityHelper.UserName);
                BusinessObjects.WtaPoBO oc = OrderHelper.CopyOrder(poid, usc);
                var omc = new MODELS.OrderModel(oc, usc);          
                OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(omc);
                base.SetDisplayMsg(WebMsgType.OK, "Order copied OK to "+omc.Ponum.ToString(), WebLogAction.UIMSG);
                return View(omc);
            }
       

             //otherwise process
             var addProductCode = u.ObjToString(Request["addProductCode"]);
             var addUom = u.ObjToString(Request["EDITUOM_0"]);
             var addComment = u.ObjToString(Request["EDITCOMMENT_0"]);
             if (string.IsNullOrEmpty(addUom))
             {
                 addUom="CS";
             }

             var addQty = u.ObjToInt(Request["EDITUOM_QTY"]);
             if (addQty==0)
             {
                 addQty=1;
             }

            var orderx=new WtaPoBO();
            orderx.LoadByPrimaryKey(poid);
           //only do this if you can edit
            if (!(orderx.StatusUCode == "NEW"))          // || orderx.StatusUCode == "READY"))
            {
                throw new ApplicationException("You cannot edit this order when it is in "+orderx.StatusUCode +" mode");
            }

            var dt = u.ObjToDateTime(rDate + " " + rTime);
            if (dt != DateTime.MinValue)
            {
                orderx.RequestedDeliveryTime = dt;
                //Make sure ship date reflexs requested date - Only the date. 
                orderx.Shipdate = orderx.RequestedDeliveryTime.Value.Date;
            }
            else
            {
                orderx.RequestedDeliveryTime = null;
            }
             orderx.Pocomment=comment;
             orderx.NameComment = nameComment;

            //
            logisticsModel =logisticsModel.Trim();
            if (logisticsModel.Trim() == "")
            {
                logisticsModel = "P";
            }
            orderx.LogisticsModel = logisticsModel;

             //collection and update the quantities. 
            foreach (var l in orderx.POlines)
            {


                var k = "EDITUOM_" + l.Polid.Value.ToString();
                var v = Request[k];
                var uom = "CS";
                if (!string.IsNullOrEmpty(v))
                {
                    uom = v;
                }
                l.Um = uom;

                k="EDITQTY_" + l.Polid.Value.ToString();
                v = Request[k];
                int qty = u.ObjToInt(v);

                //comment
                k = "EDITCOMMENT_" + l.Polid.Value.ToString();
                v = Request[k];
                comment = u.ObjToString(v);
                l.VendorComment = comment;


                var orderIsTommorow=false;
            

                if (orderx.RequestedDeliveryTime.HasValue)
                {
                    orderIsTommorow = (DateTime.Now.Date.AddDays(1) == orderx.RequestedDeliveryTime.Value.Date);
                    if (orderIsTommorow)
                    {
                        /* 6/10/2018 - Do not Reduce quantity - Just leave this alone */
                        /* This will make the Order process go fast too by the way... */
                        /*
                         MODELS.ProductModel pm=ProductHelper.GetProductAndInventory(l.Productcode,"");
                        if (uom=="CS")
                        {
                            qty=System.Math.Min(qty,pm.InventoryItem.CaseQty);
                        }
                        else
                        {
                            qty = System.Math.Min(qty,pm.InventoryItem.PieceQty);
                        }
                        */ 
                    }
                }




                if ( 
                    (qty == 0) || 
                    (orderAction == "DELETE" && delPolid == l.Polid.Value)
                    )
                {
                    l.MarkAsDeleted();
                }
                else
                {
                    l.Qty = qty;
                }

               //don't do any setting of fields here as a deleted record will through an error.  

            }
            orderx.POlines.Save();

            if (orderAction == "ADD")
            {
                int count = 0;
                //this will do a save.
                OrderHelper.AddItemToOrder(orderx, addProductCode, addQty, addUom, addComment, ref count);
            }
            else
            {
                //Note this does not work - when you are logged in as admin
                //admin's probaly should nbot be able to edit orders. 
                OrderHelper.RecalcAndSaveOrder(orderx,SecurityHelper.CustID);
            }
         
             //set the status if we need to 
            if (orderAction == "PROCESS")
            {

                
                orderx.Postdate = DateTime.Now; 
                orderx.StatusUCode = OBJECTS.OrderStatus.READY.ToString();
                orderx.Status= u.ObjToInt(OBJECTS.OrderStatus.READY);
                orderx.Save();
                string msg="";

                LogHelper.WebLogAdd(WebMsgType.OK, orderx.BizName + " Posted Order: " + orderx.Poid.Value.ToString(), WebLogAction.UIMSG);



                //Code to create a PDF file
                var h = new Dictionary<string, string>();
                h.Add("poid", orderx.Poid.ToString());
                var guid = FDSHARED.HashHelper.Set(h);
                string url = "/Order/OrderPrint?guid=" + guid;
                url = base.expandFullUrlPath(url,Config.LOCALURL,false);
                byte[] PDFbuffer = null;
                string title = "";
                string fileName = "";

                //OK - if this blows chunks don't throw an error - just send the email with a link
                if (!PDFHelper.GetPDFFileBufferFromURL(url, ref PDFbuffer, ref title, ref fileName, ref msg))
                {
                    LogHelper.WebLogAdd(WebMsgType.ERR, "OrderController - PDF Buffer could not be generated. Email will not include attached PDF. "+msg, WebLogAction.SYSTEM_ERROR);

                }
                else
                {
                    LogHelper.WebLogAdd(WebMsgType.OK, "OrderController - PDF Buffer Genned OK", WebLogAction.UIMSG);

                    fileName = System.IO.Path.Combine(UI.OBJECTS.Config.TEMPEXPORTPATH, fileName);
                    //now save the byte string to file
                    u.ByteArrayToFile(PDFbuffer, fileName);
                    LogHelper.WebLogAdd(WebMsgType.OK, "PDF File Saved OK for attachment send: "+fileName, WebLogAction.UIMSG);

                    //End code to create a PDF file
                }
                //send member email
                EmailHelper.SendPOEmailToMember(orderx,fileName, guid, ref msg);
                
                //send admin email
                EmailHelper.SendPOEmailToAdmin(orderx, fileName, guid, ref msg);

                MySession.ORDERID = 0;
            }
            //now create the outgoing Model 
            var us = new UsersBO();
            us.LoadByInternetID(SecurityHelper.UserName);
            var om = new MODELS.OrderModel(orderx, us);
            OBJECTS.ProductHelper.GetInventoryForOrderModelAndSync(om);
         
            //Write a message to the screen 
            if (orderAction == "DELETE")
            {
                base.SetDisplayMsg(WebMsgType.OK, "The item has been deleted.", WebLogAction.UIMSG );
            }
            else if (orderAction == "RECALC")
            {
                base.SetDisplayMsg(WebMsgType.OK, "The order was saved and recalculated OK.", WebLogAction.UIMSG);
            }
            else if (orderAction == "ADD")
            {
                base.SetDisplayMsg(WebMsgType.OK, "The item was added OK.", WebLogAction.UIMSG );
            }
            else
            {
                //PROCESS
                return RedirectToAction("Orders", new { mode = "READY" });
            }

            //stuff for the print link
            
            var ha = new Dictionary<string, string>();
            ha.Add("poid", om.Poid.ToString());
            om.PrintLinkHashGuid = FDSHARED.HashHelper.Set(ha);

            return View(om);
          }
        /// <summary>
        /// Add Order Item Dialog - UNDONE - verify case and peice info - Put some inventory info on this. 
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public ActionResult OrderAddItem(string productCode)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var p=new BusinessObjects.ProdsBO();
            if (!p.LoadByPrimaryKey(productCode))
            {

            }
            var model=new MODELS.OrderAddItemModel();
            model.ProductCode=p.Productcode;
            model.Description=p.Description;

            model.InventoryInfo = "";
            if (p.OnPriceList.HasValue)
            {
                if (!p.OnPriceList.Value)
                {
                    model.InventoryInfo = "This product is currently not in stock - but you may include it on the order and we will make every attempt to provide the product.";
                }
            }
            
            model.CaseCount = p.Casecount.HasValue?p.Casecount.Value:1;
            return View(model);
        }
       
        /// <summary>
        /// Add an Item to an order. Done as a Jason call from Jquery - not a full postback
        /// http://stackoverflow.com/questions/18883923/calling-non-action-methods-from-view-mvc-net
        /// </summary>
        /// <param name="oam"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OrderAddItem(MODELS.OrderAddItemModel  oam)
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var order = OrderHelper.GetCreateExistingOrder(SecurityHelper.UserName);
            int count = 0;

            //Per Sal - 4/1/2020 - Make this a Toggle
            bool retVal = true;
            /*if (OrderHelper.ItemExists(oam.ProductCode))
            {
                OrderHelper.RemoveItemOnOrder(oam.ProductCode);
                count = 0;
            }
            else
            {*/
                retVal = OrderHelper.AddItemToOrder(order, oam.ProductCode, oam.QTY, oam.UOM, "", ref count);
            //}
            return Json(new {RetVal=retVal,Count=count});
        }
        public ActionResult OrderSendTest(string poid)
        {
            var order = new BusinessObjects.WtaPoBO();
            if (!order.LoadByPrimaryKey(u.ObjToInt(poid)))
            {
                base.SetDisplayMsg(WebMsgType.ERR,"Could not load the order with the POID: "+poid, WebLogAction.UIMSG);
             
            }
            else
            {
                //Code to create a PDF file
                var h = new Dictionary<string, string>();
                h.Add("poid", order.Poid.ToString());
                var guid = FDSHARED.HashHelper.Set(h);
                string url = "/Order/OrderPrint?guid=" + guid;
                url = base.expandFullUrlPath(url,Config.LOCALURL,false);
                byte[] PDFbuffer = null;
                string title = "";
                string fileName = "";
                string msg = "";
                if (!PDFHelper.GetPDFFileBufferFromURL(url, ref PDFbuffer, ref title, ref fileName, ref msg))
                {
                    throw new ApplicationException(msg);
                }
                fileName = System.IO.Path.Combine(UI.OBJECTS.Config.TEMPEXPORTPATH, fileName);
                //now save the byte string to file
                u.ByteArrayToFile(PDFbuffer, fileName);
                //End code to create a PDF file


                if (EmailHelper.SendPOTestEmailToAdmin(order,fileName,ref msg))
                {
                    base.SetDisplayMsg(WebMsgType.OK, "Admin Order Test email sent OK!", WebLogAction.UIMSG);
                }
                else
                {
                    base.SetDisplayMsg(WebMsgType.ERR, "Admin Order Test email not sent - check out the log for more info.", WebLogAction.UIMSG);
                }
            }

            return View();
        }
    }
}
