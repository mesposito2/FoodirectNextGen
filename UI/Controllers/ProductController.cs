using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bo = BusinessObjects;
using EntitySpaces.Interfaces;
using EntitySpaces.Core;
using EntitySpaces.DynamicQuery;
using System.Web.Script.Serialization;
using UI.OBJECTS;



using u = CSA.UTILITY.MyUtility;
using UI.MODELS;

namespace UI.Controllers
{
    public class ProductController : BaseController
    {

        public ActionResult SalesProducts(string mode, string ProductAutoComplete = "",
            string xLabel = "", string xData = "",
            string productABC = "", string sf = "productcode",
            string so = "asc", int page = 1,
            string subsearch = "")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.ThrowSQLInjection(mode, ProductAutoComplete, xLabel, xData, productABC, sf, so, subsearch);

            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.SALES);

            if (string.IsNullOrEmpty(mode))
            {
                mode = "PRODUCT";
            }

            string catSelectValue = "";
            string scatSelectValue = "";
            string groupSelectValue = "";
            if (mode == "CAT")
            {
                catSelectValue = xData;
            }
            else if (mode == "GROUP")
            {
                groupSelectValue = xData;

            }
            else if (mode == "SCAT")
            {
                scatSelectValue = xData;
                catSelectValue = xData.Substring(0, 2);
            }
            var cat = getProductFilterCat();
            var group = getProductFilterGroup();
            List<NameValuePairModel> scat = null;
            if (mode == "CAT" || mode == "SCAT")
            {
                scat = getProductFilterScat(catSelectValue);
            }
            var m = new MODELS.ProductsXParmsModel(cat, catSelectValue, group, groupSelectValue, scat, scatSelectValue);
            m.Title = "Sales Products";
            m.DisplayMode = mode;
            m.SubSearch = subsearch;

            m.SortField = sf;
            m.SortOrder = so;

            //keep the raw data round in case we want a query (like abc) to retain the information already set
            //and effectively do a sub search

            m.QS_Mode = mode;
            m.QS_ProductAutoComplete = ProductAutoComplete;
            m.QS_XData = xData;
            m.QS_XLabel = xLabel;
            m.QS_ProductABC = productABC;

            var productABCFilter = "";
            var productABCFilterCore = "";
            var productABCTitle = "";
            productABC = productABC.Trim();
            if (productABC.Length == 1)
            {
                productABCFilterCore = "{ field: 'description', operator: 'startswith', value: '" + productABC + "' }";
                productABCFilter = "," + productABCFilterCore;
                productABCTitle = " that start with '" + productABC + "'";
            }

            if (mode == "PRODUCT")
            {
                if (!string.IsNullOrEmpty(ProductAutoComplete))
                {
                    m.Title = "Search: " + ProductAutoComplete;
                    m.QueryType = "'DEFAULT'";
                    m.Filter = "{ filters: [{ field: 'productcode', operator: 'contains', value: '" + ProductAutoComplete + "' },{ field: 'description', operator: 'contains', value: '" + ProductAutoComplete + "' }], logic: 'or' }";
                }
                else if (!string.IsNullOrEmpty(productABC))
                {
                    m.Title = "Products " + productABCTitle;
                    m.QueryType = "'DEFAULT'";
                    m.Filter = "{ filters: [" + productABCFilterCore + "], logic: 'and' }";
                }
                else
                {
                    //do nothing
                }
            }


            if (mode == "FAVORITE")
            {
                OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

                m.Title = "My Favorites" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'isfavorite', operator: 'eq', value: '1' }" + productABCFilter + "], logic: 'and' }";

            }
            if (mode == "SPEED")
            {
                OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

                m.Title = "Speed List" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'onspeedlist', operator: 'eq', value: '1' }" + productABCFilter + "], logic: 'and' }";

            }
            if (mode == "GROUP")
            {

                m.Title = "Products for " + xLabel + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'groupcode', operator: 'contains', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }
            if (mode == "CAT")
            {
                m.Title = xLabel + " products" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'catid', operator: 'eq', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }
            if (mode == "SCAT")
            {
                m.Title = xLabel + " products" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'scatid', operator: 'eq', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }

            //add subsearch to the titke string
            if (!string.IsNullOrEmpty(m.SubSearch))
            {
                m.Title = m.Title + " - Results refined by " + m.SubSearch;
            }

            var s = new JavaScriptSerializer();
            if (m.Filter == "''")
            { m.Filter = ""; }
            var f = s.Deserialize<GridFilters>(m.Filter);
            //This was only broken out into two functions with the 
            //Jsaon serialized filter - as the original version with Kendo
            //used the products_read method as an ajax callback. 
            // we do not need to do this anymore. 
            var v = Products_Read(m.QueryType, page, 15, sf + " " + so, f, m.SubSearch);



            var pq = new ProductQueryAndViewModel(m, v);
            pq.PageSize = 15;
            pq.Page = page;

            return View(pq);
        }
    

         
        public ActionResult CSVProducts(bool bShowInventory=false)
        {
            // Write the string to a file.
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var fileName = System.IO.Path.Combine(OBJECTS.Config.TEMPEXPORTPATH, "FDProdExport_" + Guid.NewGuid().ToString() + ".csv");
            var col = new BusinessObjects.ProdsCollection();
            var sql = OBJECTS.MySession.LASTPRODSQL;

            if (string.IsNullOrEmpty(sql))
            {
                throw new ApplicationException("Last database query (sql) could not be discerned");
            }

            if (!OBJECTS.ProductHelper.CreateCSVFileFromSQL(sql, bShowInventory, fileName))
            {
                throw new ApplicationException("Temp CSV Product file could not be created.");
            }

            return File(fileName, "text/csv", "Foodirect_" + OBJECTS.SecurityHelper.CustID + ".csv");
        }
        public ActionResult ProductBook()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var hash = new Dictionary<string, string>();
            hash.Add("custid", OBJECTS.SecurityHelper.CustID );
            ViewBag.PrintGuid = FDSHARED.HashHelper.Set(hash);
            
            return View();
        }
        /// <summary>
        /// This method is used by the web site and also by the Job
        /// TODO - Make this use the HASH method only. 
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="custid"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        /*
        public ActionResult SalesAndBeefPrint(string guid = "")
        {
            ensureSSL();
            var m = new SalesBeefModel();
            if (guid.Trim() == "")
            {
                throw new ApplicationException("Key Required");

            }
            var h = FDSHARED.HashHelper.Get(guid);
            if (h == null)
            {
                throw new ApplicationException("Could not load secure hash data with key " + guid);
            }
            var mode = h["mode"];
            var custid = h["custid"];

            m.Mode = mode.ToUpper();
            m.WeeklySpecialsListModel = getSalesModel(custid);
            m.BeefSpecialsViewModel = getBeefModel(custid);

            var p = new BusinessObjects.UsersBO();
            if (!p.LoadByCustID(custid))
            {
                throw new ApplicationException(custid + " custid not found.");
            }
            m.PersonModel = new PersonModel(p);

            return View(m);
        }
        */
        public ActionResult SalesAndBeefPrintV2(string guid = "")
        {
            //don't require SSL here
            //is if we have to call by local IP 
            // there is no cert
            //ensureSSL();
            var m = new SalesBeefModelV2();

            if (guid.Trim() == "")
            {
                throw new ApplicationException("Key Required");

            }
            var h = FDSHARED.HashHelper.Get(guid);
            if (h == null)
            {
                throw new ApplicationException("Could not load secure hash data with key " + guid);
            }
            var mode = h["mode"];
            var custid = h["custid"];


            m.Mode = mode.ToUpper();

            if (mode.IndexOf("SALES") != -1)
            {
                m.WeeklySpecialsListModel = getSalesModel(custid);
            }

            if (mode.IndexOf("BEEF") != -1)
            {
                m.BeefSpecialsListModel = getBeefModelV2(custid);
            }

            if (mode.IndexOf("PRODUCE") != -1)
            {
                m.ProduceSpecialsListModel = getProduceModel(custid);
            }

            var p = new BusinessObjects.UsersBO();
            if (!p.LoadByCustID(custid))
            {
                throw new ApplicationException(custid + " custid not found.");
            }
            m.PersonModel = new PersonModel(p);

            return View(m);
        }
        public ActionResult WeeklySpecials()
        {
            ensureSSL();

            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
            var model = getSalesModel(OBJECTS.SecurityHelper.CustID);

            //PDF Printing
            var h = new Dictionary<string, string>();
            h.Add("custid", OBJECTS.SecurityHelper.CustID);
            h.Add("mode", "SALES");
            ViewBag.PrintGUID = FDSHARED.HashHelper.Set(h);


            //test PDF Printing - combosheet
            h = new Dictionary<string, string>();
            h.Add("custid", OBJECTS.SecurityHelper.CustID);
            h.Add("mode", "SALESBEEF");
            ViewBag.PrintGUIDCOMBO = FDSHARED.HashHelper.Set(h);





            return View(model);
        }
        private ProduceSpecialsListModel getProduceModel(string custid)
        {

            var col = new BusinessObjects.VwProduceCollection();

            if (string.IsNullOrEmpty(custid))
            {
                custid = OBJECTS.SecurityHelper.CustID;
            }
            var currentOrderID = UI.OBJECTS.MySession.ORDERID;
            col.LoadSalesByCustID(custid, currentOrderID);

            return new MODELS.ProduceSpecialsListModel(col.ToList());
                

        }

        private WeeklySpecialsListModel getSalesModel(string custid)
        {

            var col = new BusinessObjects.VwSalePCollection();

            if (string.IsNullOrEmpty(custid))
            {
                custid = OBJECTS.SecurityHelper.CustID;
            }
            var currentOrderID = UI.OBJECTS.MySession.ORDERID;
            col.LoadSalesByCustID(custid, currentOrderID);

            return new MODELS.WeeklySpecialsListModel(col.ToList());

        }
        private BeefSpecialsListModelV2 getBeefModelV2(string custid)
        {

            var col = new BusinessObjects.VwBeefCollection();

            if (string.IsNullOrEmpty(custid))
            {
                custid = OBJECTS.SecurityHelper.CustID;
            }

            var currentOrderID = UI.OBJECTS.MySession.ORDERID;
            col.LoadSalesByCustID(custid, currentOrderID);

            //This is not needed in V2
            //var headerCol = new BusinessObjects.ListsCollection();
            //headerCol.Query.OrderBy(headerCol.Query.Lid.Ascending, headerCol.Query.Lname.Ascending);
            //headerCol.Query.Where(headerCol.Query.Lid.Equal(1000));
            //headerCol.LoadAll();

            return new MODELS.BeefSpecialsListModelV2(col);

        }
        private BeefSpecialsViewModel getBeefModel(string custid)
        {


            var col = new BusinessObjects.VwBeefCollection();

            if (string.IsNullOrEmpty(custid))
            {
                custid = OBJECTS.SecurityHelper.CustID;
            }

            var currentOrderID = UI.OBJECTS.MySession.ORDERID;
            col.LoadSalesByCustID(custid, currentOrderID);

            var headerCol = new BusinessObjects.ListsCollection();
            headerCol.Query.OrderBy(headerCol.Query.Lid.Ascending, headerCol.Query.Lname.Ascending);
            headerCol.Query.Where(headerCol.Query.Lid.Equal(1000));
            headerCol.LoadAll();


            return new MODELS.BeefSpecialsViewModel(headerCol, col);


        }
        /// <summary>
        /// Produce specials just like weekly specials
        /// </summary>
        /// <returns></returns>
        public ActionResult ProduceSpecials()
        {

            ensureSSL();

            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
            var model = getProduceModel(OBJECTS.SecurityHelper.CustID);

            //PDF Printing
            var h = new Dictionary<string, string>();
            h.Add("custid", OBJECTS.SecurityHelper.CustID);
            h.Add("mode", "PRODUCE");
            ViewBag.PrintGUID = FDSHARED.HashHelper.Set(h);

            return View(model);
        }
        /// <summary>
        /// Old Beef specials - This is unused... 
        /// </summary>
        /// <returns></returns>
        public ActionResult BeefSpecials()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

            var model = getBeefModel(OBJECTS.SecurityHelper.CustID);
            return View(model);
        }
        public ActionResult BeefSpecialsV2()
        {
            ensureSSL();
            OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);



            //PDF Printing
            var h = new Dictionary<string, string>();
            h.Add("custid", OBJECTS.SecurityHelper.CustID);
            h.Add("mode", "BEEF");
            ViewBag.PrintGUID = FDSHARED.HashHelper.Set(h);

            h = new Dictionary<string, string>();
            h.Add("custid", OBJECTS.SecurityHelper.CustID);
            h.Add("mode", "SALESBEEF");
            ViewBag.PrintGUIDCOMBO = FDSHARED.HashHelper.Set(h);




            var model = getBeefModelV2(OBJECTS.SecurityHelper.CustID);
            return View(model);
        }



        /// <summary>
        /// Get a single prodict
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public ActionResult Product(string productCode)
        {
            ensureSSL();
            if (!string.IsNullOrEmpty(productCode))
            {

                MODELS.ProductModel pm = OBJECTS.ProductHelper.GetProductAndInventory(productCode, OBJECTS.SecurityHelper.CustID);
                return View(pm);

            }
            else
            {
                return View();

                //throw new ApplicationException("page requires a productcode parameter");
            }
        }


        public ActionResult Products(string mode, string ProductAutoComplete = "",
            string xLabel = "", string xData = "",
            string productABC = "", string sf = "productcode",
            string so = "asc", int page = 1,
            string subsearch = "")
        {
            ensureSSL();
            OBJECTS.SecurityHelper.ThrowSQLInjection(mode, ProductAutoComplete, xLabel, xData, productABC, sf, so, subsearch);

            if (string.IsNullOrEmpty(mode))
            {
                mode = "PRODUCT";
            }

            string catSelectValue = "";
            string scatSelectValue = "";
            string groupSelectValue = "";
            if (mode == "CAT")
            {
                catSelectValue = xData;
            }
            else if (mode == "GROUP")
            {
                groupSelectValue = xData;

            }
            else if (mode == "SCAT")
            {
                scatSelectValue = xData;
                catSelectValue = xData.Substring(0, 2);
            }
            var cat = getProductFilterCat();
            var group = getProductFilterGroup();
            List<NameValuePairModel> scat = null;
            if (mode == "CAT" || mode == "SCAT")
            {
                scat = getProductFilterScat(catSelectValue);
            }
            var m = new MODELS.ProductsXParmsModel(cat, catSelectValue, group, groupSelectValue, scat, scatSelectValue);

            m.DisplayMode = mode;
            m.SubSearch = subsearch;

            m.SortField = sf;
            m.SortOrder = so;

            //keep the raw data round in case we want a query (like abc) to retain the information already set
            //and effectively do a sub search

            m.QS_Mode = mode;
            m.QS_ProductAutoComplete = ProductAutoComplete;
            m.QS_XData = xData;
            m.QS_XLabel = xLabel;
            m.QS_ProductABC = productABC;

            var productABCFilter = "";
            var productABCFilterCore = "";
            var productABCTitle = "";
            productABC = productABC.Trim();
            if (productABC.Length == 1)
            {
                productABCFilterCore = "{ field: 'description', operator: 'startswith', value: '" + productABC + "' }";
                productABCFilter = "," + productABCFilterCore;
                productABCTitle = " that start with '" + productABC + "'";
            }

            if (mode == "PRODUCT")
            {
                if (!string.IsNullOrEmpty(ProductAutoComplete))
                {
                    m.Title = "Search: " + ProductAutoComplete;
                    m.QueryType = "'DEFAULT'";
                    m.Filter = "{ filters: [{ field: 'productcode', operator: 'contains', value: '" + ProductAutoComplete + "' },{ field: 'description', operator: 'contains', value: '" + ProductAutoComplete + "' }], logic: 'or' }";
                }
                else if (!string.IsNullOrEmpty(productABC))
                {
                    m.Title = "Products " + productABCTitle;
                    m.QueryType = "'DEFAULT'";
                    m.Filter = "{ filters: [" + productABCFilterCore + "], logic: 'and' }";
                }
                else
                {
                    //do nothing
                }
            }


            if (mode == "ORDERGUIDE")
            {
                OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);
                m.Title = "Order Guide for " + m.QS_XLabel + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'ProdCustGuideID', operator: 'neq', value: '0'}" + productABCFilter+"] , logic: 'and' }";

            }
            if (mode == "FAVORITE")
            {
                OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

                m.Title = "My Favorites" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'isfavorite', operator: 'eq', value: '1' }" + productABCFilter + "], logic: 'and' }";

            }
            if (mode == "SPEED")
            {
                OBJECTS.SecurityHelper.VerifyAccess(OBJECTS.Roles.MEMBER);

                m.Title = "Speed List" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'onspeedlist', operator: 'eq', value: '1' }" + productABCFilter + "], logic: 'and' }";

            }
            if (mode == "GROUP")
            {

                m.Title = "Products for " + xLabel + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'groupcode', operator: 'contains', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }
            if (mode == "CAT")
            {
                m.Title = xLabel + " products" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'catid', operator: 'eq', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }
            if (mode == "SCAT")
            {
                m.Title = xLabel + " products" + productABCTitle;
                m.QueryType = "'DEFAULT'";
                m.Filter = "{ filters: [{ field: 'scatid', operator: 'eq', value: '" + xData + "' }" + productABCFilter + "], logic: 'and' }";
            }

            //add subsearch to the titke string
            if (!string.IsNullOrEmpty(m.SubSearch))
            {
                m.Title = m.Title + " - Results refined by " + m.SubSearch;
            }

            var s = new JavaScriptSerializer();
            if (m.Filter == "''")
            { m.Filter = ""; }
            var f = s.Deserialize<GridFilters>(m.Filter);
            //This was only broken out into two functions with the 
            //Jsaon serialized filter - as the original version with Kendo
            //used the products_read method as an ajax callback. 
            // we do not need to do this anymore. 
            var v = Products_Read(m.QueryType, page, 15, sf + " " + so, f, m.SubSearch);



            var pq = new ProductQueryAndViewModel(m, v);
            pq.PageSize = 15;
            pq.Page = page;

            return View(pq);
        }
        /// <summary>
        /// Read the actual products from the database... 
        /// </summary>
        /// <param name="queryType"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="subsearch"></param>
        /// <returns></returns>
        public ProductViewModel Products_Read(string queryType, int page, int pageSize, string orderBy, GridFilters filter = null, string subsearch = "" )
        {

            var col = new BusinessObjects.ProdsCollection();
            string filterExpression = base.makeFilterExpression(filter);
            int totalCount = 0;

            string custID = "";
            int currentOrderID = 0;
            if (UI.OBJECTS.SecurityHelper.IsAuthenticated())
            {
                custID = UI.OBJECTS.SecurityHelper.CustID;
                currentOrderID = UI.OBJECTS.MySession.ORDERID;
            }
            string sqlOut = "";
            bool adminQuery = OBJECTS.SecurityHelper.IsAdmin() || OBJECTS.SecurityHelper.IsSales();
            bool forceOrderGuide = OBJECTS.SecurityHelper.ForceOrderGuide;

            var ds = col.GetPagedView(adminQuery, page, pageSize, orderBy, ref totalCount, custID, currentOrderID, filterExpression, subsearch, forceOrderGuide, ref sqlOut);
            var p = new MODELS.ProductListModel(ds);
            //ViewBag.LASTSQL=sqlOut;
            OBJECTS.MySession.LASTPRODSQL = sqlOut;
            //If this is not a guest - get the the inventory items and sync them up 
            if (OBJECTS.SecurityHelper.Role != OBJECTS.Roles.GUEST)
            {
                OBJECTS.ProductHelper.GetInventoryForProductListModelAndSync(p);

            }

            //Create  the encapsulating view model -
            //This is so we can get Total count out where the Kendo Grid can use it 
            var pvm = new MODELS.ProductViewModel
            {
                Products = p,
                TotalCount = totalCount
            };
            return (pvm);
        }

        [HttpPost]
        public ActionResult Products()
        {

            var order = OrderHelper.GetCreateExistingOrder(SecurityHelper.UserName);
            int count = 0;

            foreach (string s in Request.Params.Keys)
            {
                if (s.Contains("EDITQTY"))
                {
                    var pc = OBJECTS.MyHelper.StrExtract(s, "_", 1);
                    var qty = u.ObjToInt(Request[s]);
                    var uom = u.ObjToString(Request["EDITUOM_" + pc]).Trim();
                    if (uom=="")
                    {
                        uom = "CS";
                    }

                    if (u.ObjToInt(qty) > 0)
                    {
                        OrderHelper.AddItemToOrder(order, pc, qty, uom, "", ref count);
                    }
                }
            }
                    //Response.Write(s.ToString() + ":" + Request.Params[s] + "<br>");
                

            return RedirectToAction("Order", "Order");
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<MODELS.NameValuePairModel> getProductFilterGroup()
        {
            var col = new BusinessObjects.ProdsCollection();
            var ds = col.GetDataSet("select * from groupd order by description");

            var list = new List<MODELS.NameValuePairModel>();

            var x = new NameValuePairModel();
            x.Name = "--select--";
            x.Value = "";
            list.Add(x);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var i = new NameValuePairModel();
                i.Name = u.ObjToString(dr["description"]); 
                i.Value = u.ObjToString(dr["groupcode"]);
                list.Add(i);
            }
            return list;
        }

        private List<MODELS.NameValuePairModel> getProductFilterScat(string catid)
        {
            var col = new BusinessObjects.ProdsCollection();
            var ds = col.GetDataSet("select * from catsub where scatid like '" + catid + "%'  order by description");

            var list = new List<MODELS.NameValuePairModel>();

            var x = new NameValuePairModel();
            x.Name = "--select--";
            x.Value = "";
            list.Add(x);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var i = new NameValuePairModel();
                i.Name = u.ObjToString(dr["description"]);
                i.Value = u.ObjToString(dr["scatid"]);
                list.Add(i);
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<MODELS.NameValuePairModel> getProductFilterCat()
        {
            var col = new BusinessObjects.ProdsCollection();
            var ds = col.GetDataSet("select * from cat order by description");

            var list = new List<MODELS.NameValuePairModel>();

            var x = new NameValuePairModel();
            x.Name = "--select--";
            x.Value = "";
            list.Add(x);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var i = new NameValuePairModel();
                i.Name = u.ObjToString(dr["description"]);
                i.Value = u.ObjToString(dr["catid"]);
                list.Add(i);
            }
            return list;
        }
        /// <summary>
        /// This is used for the ajax version of the category list
        /// </summary>
        /// <returns></returns>
        public JsonResult GetProductFilterCat()
        {

            var list = getProductFilterCat();
            JsonResult jsonResult;
            jsonResult = Json(list, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        /// <summary>
        /// for drop down on main page
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public JsonResult GetProductsForDropDown(MODELS.AutoCompleteFilters filter)
        {
            //string s = u.ObjToString(text);
            var col = new BusinessObjects.ProdsCollection();
            string s = "";
            if (filter.filters != null && filter.filters.Count > 0)
            {
                s = u.ObjToString(filter.filters[0].value);
            }
           var ds = col.GetAllProductsThatContain(s,OBJECTS.SecurityHelper.ForceOrderGuide, OBJECTS.SecurityHelper.CustID);
            var p = new MODELS.NameValuePairListModel();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var np = new NameValuePairModel();
                np.Name = u.ObjToString(dr["description"]);
                np.Value = u.ObjToString(dr["productcode"]);
                p.Add(np);
            }

            JsonResult jsonResult;
            jsonResult = Json(p, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;

        }
        [HttpPost]
        public JsonResult FavoriteToggle(string productCode)
        {
            bool retVal = true;
            var toggledState = UI.OBJECTS.ProductHelper.FavoriteToggle(UI.OBJECTS.SecurityHelper.CustID, productCode);

            return Json(new { RetVal = retVal, ToggledState = toggledState });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        public ActionResult BookPrint(string guid)
        {
            if (string.IsNullOrEmpty(guid))
            {
                throw new ApplicationException("Key is required");
            }

            var h = FDSHARED.HashHelper.Get(guid);
            if (h == null)
            {
                throw new ApplicationException("Could not load secure hash data with key " + guid);
            }
            var id = u.ObjToString(h["custid"]);


            if (string.IsNullOrEmpty(id))
            {
                throw new ApplicationException("The Customer ID could not be discerned");
            }
            var col = new BusinessObjects.ProdsCollection();
            var ds = col.GetBook(id);
            var products = new ProductListModel(ds);

            var business = new PersonModel(id);
            
            var m = new BookModel(business, DateTime.Now, products);

            return View(m);

        }


    }
}
