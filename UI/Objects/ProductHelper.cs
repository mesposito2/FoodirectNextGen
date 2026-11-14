using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessObjects;
using u = CSA.UTILITY.MyUtility;
using System.Data;

namespace UI.OBJECTS
{
    public class ProductHelper
    {


        #region  formatting

        /// <summary>
        /// Take a double and format it as USD string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatCurrency4Dec(double value)
        {
            return string.Format("{0:$###,###.0000}", value);
        }


        public static string FormatCurrency4Dec(double? value)
        {
            string strRet = string.Format("{0:$###,###.0000}", value);
            return strRet;
        }

        #endregion


        #region public 
        /// <summary>
        /// Get all inventory for a ProductListModel
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static void GetInventoryForProductListModelAndSync(MODELS.ProductListModel list)
        {
            //create a DTO List to send to the method

            var listToSend = new List<UI.OBJECTS.AS400ProductDTO>();
            foreach (var pm in list)
            {
                listToSend.Add(new UI.OBJECTS.AS400ProductDTO { ProductCode = pm.ProductCode });
            }
            var listWithInventory = getInventoryListFromService(listToSend);

            foreach (var x in listWithInventory)
            {
                MODELS.ProductModel pm = list.Find(delegate (MODELS.ProductModel p) { return p.ProductCode == x.ProductCode.Trim(); });
                if (pm != null)
                {
                    OBJECTS.ProductHelper.UpdateInventoryItem(x, pm.IsProduce, u.ObjToInt(pm.CaseCount), pm.InventoryItem);
                }


            }
        }
        //Undone - change this to suport A/V Stuff
        public static bool IsProduce(BusinessObjects.ProdsBO p)
        {
            return (p.Catid == Config.PRODUCECATID);
        }
        public static bool IsProduce(BusinessObjects.WtaPoLineBO l)
        {
            return (l.Catid == Config.PRODUCECATID);
        }
        public static bool IsProduce(DataRow dr)
        {
            return (u.ObjToString(dr["catid"]) == Config.PRODUCECATID);
        }



        /// <summary>
        /// Get all inventory for a ProductListModel
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static void GetInventoryForOrderModelAndSync(MODELS.OrderModel order)
        {
            //create a DTO List to send to the method

            var listToSend = new List<UI.OBJECTS.AS400ProductDTO>();
            foreach (var oi in order.Lines)
            {
                listToSend.Add(new UI.OBJECTS.AS400ProductDTO { ProductCode = oi.ProductCode });
            }
            var listWithInventory = getInventoryListFromService(listToSend);
            
            foreach (var x in listWithInventory)
            {
                MODELS.OrderItemModel oi = order.Lines.Find(delegate (MODELS.OrderItemModel oip) { return oip.ProductCode == x.ProductCode.Trim(); });
                if (oi != null)
                {
                    OBJECTS.ProductHelper.UpdateInventoryItem(x, oi.IsProduce,oi.CaseCount, oi.InventoryItem);
                }
            }

        }

        /// <summary>
        /// Get a single ProductModel and Inventory Info based on a product code. 
        /// Method good to zoom in on a product 
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public static MODELS.ProductModel GetProductAndInventory(string productCode,string custID)
        {
            MODELS.ProductModel pm = null;

            var p = new BusinessObjects.ProdsBO();
            bool bOK=false;
            if (!string.IsNullOrEmpty(custID))
            {
                bOK=p.LoadByPrimaryKeyAndCustID(productCode,custID);
            }
           if (!bOK)
            {
                bOK=p.LoadByPrimaryKey(productCode);
            }
            if (bOK)
            {
                pm = new MODELS.ProductModel(p);
                UI.OBJECTS.AS400ProductDTO a = null;
                if (Config.REALINVENTORYFETCH)
                {
                    a = UI.OBJECTS.AS400Product.GetProduct(productCode);
                }
                if (a != null)
                {
                    UpdateInventoryItem(a, pm.IsProduce,u.ObjToInt(pm.CaseCount), pm.InventoryItem);
                }
            }
            else
            {
                pm = new MODELS.ProductModel();
                pm.ProductCode = productCode;
                pm.Description = "This product is no longer available";
            }


            return pm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productInventory"></param>
        /// <param name="nextDate"></param>
        /// <param name="count"></param>
        /// <param name="info"></param>
        public static void UpdateInventoryItem(UI.OBJECTS.AS400ProductDTO productInventory, bool isProduce,  int caseCount, MODELS.InventoryItemModel inventoryItem)
        {

            inventoryItem.NextDelivery = "There is no pending delivery";
            if (productInventory.InventoryNextDate.HasValue)
            {
                inventoryItem.NextDelivery = productInventory.InventoryNextDate.Value.ToLongDateString();
            }

           
            if (productInventory.InventoryPieces == 0)
            {
                if (!isProduce)
                {
                    inventoryItem.OutOfStockInfo = "This product is out of stock. Please contact your vendor for re-stocking details";
                    inventoryItem.SummaryMsg = "Not In-stock";
                }
                else
                {
                    inventoryItem.OutOfStockInfo = "Produce Items are Ordered Fresh Daily";
                    inventoryItem.SummaryMsg = "Ordered Fresh!";
                }
            }
            else
            {
                inventoryItem.OutOfStockInfo = "";

                var iLoosePieces = u.ObjToInt(productInventory.InventoryPieces % caseCount);
                var iCases = u.ObjToInt((productInventory.InventoryPieces - iLoosePieces) / caseCount);

                inventoryItem.CaseQty = iCases;
                inventoryItem.PieceQty = productInventory.InventoryPieces;

                //CaseInfo
                if (iCases == 0)
                {
                    inventoryItem.CaseInfo = "There are no cases available";
                }
                else
                {
                    inventoryItem.CaseInfo = iCases.ToString() + " case(s)";
                }
                //Case Breakable Info
                inventoryItem.CaseBreakableInfo = "";
                if (caseCount > 1)
                {
                    inventoryItem.CaseBreakableInfo = "Each case is made up of " + caseCount.ToString() + " breakable pieces.";
                }

                if (caseCount == 1)
                {

                    inventoryItem.PieceInfo = "This product is only sold by CASE";
                }
                else
                {
                    inventoryItem.PieceInfo = iLoosePieces.ToString() + " piece(s)";
                }


                if (SecurityHelper.MemberCanViewInventory || SecurityHelper.IsSales() || SecurityHelper.IsAdmin())
                {
                    inventoryItem.SummaryMsg = "In-stock (";
                    inventoryItem.SummaryMsg += iCases.ToString() + " cs";
                    if (iLoosePieces > 0)
                    {
                        inventoryItem.SummaryMsg += " " + iLoosePieces + " pc";
                    }
                    inventoryItem.SummaryMsg += ")";

                }
                else
                {
                    inventoryItem.SummaryMsg = "In-stock ";
                }
            } 
        }
     
        public static bool FavoriteToggle(string userName, string productCode)
        {
            //find if its there
            bool retVal=false;
            var f = new FavoriteBO();
            if (!f.LoadByCustIDAndProductCode(userName, productCode))
            {

                //If not there add it 
                f = null;
                f = new FavoriteBO();
                f.ProductCode = productCode;
                f.CustID = userName;
                f.CreatedBy = userName;
                f.LastUpdatedBy = userName;
                f.Save();
                retVal = true;

            }
            else
            {
                //If there delete it 
                f.MarkAsDeleted();
                f.Save();
                retVal = false;
            }
            return retVal;
        }

        public static bool CreateCSVFileFromSQL(string sql, bool bShowInventory, string fileName)
        {

            //Product code
            //Product description
            //Unit of measure (e.g. case (10 lb)
            //Price
            var text = "";

            string fields = @"
productcode,
description,
lbpc,
lbcs,
weight,
casecount";

            var fieldic = new Dictionary<string, string>();
            fieldic.Add("lbpc", "PricePerPiece");
            fieldic.Add("lbcs", "PricePerCase");

            
            var col = new BusinessObjects.ProdsCollection();
            var ds = col.GetDataSet(sql);
            var DQ = @"""";
            List<UI.OBJECTS.AS400ProductDTO> listWithInventory=null;


            //Get Inventory stuff
            if (bShowInventory)
            {
                int i = 0;
                var listToSend = new List<UI.OBJECTS.AS400ProductDTO>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    var pc = u.ObjToString(dr["productcode"]);

                    listToSend.Add(new UI.OBJECTS.AS400ProductDTO { ProductCode = pc });
                    i++;
                    if (i== OBJECTS.Config.AS400_INV_BATCH)
                    {
                        break;
                    }


                }
                listWithInventory = getInventoryListFromService(listToSend);
                //end getting inventory.... 
            }



            //do column line
            foreach (DataColumn dc in ds.Tables[0].Columns)
            {
                if (fields.IndexOf(dc.ColumnName) > 0)
                {   //do quick translate here
                    var t = dc.ColumnName;
                    if (fieldic.ContainsKey(dc.ColumnName))
                    {
                        t = u.ObjToString(fieldic[dc.ColumnName]);
                    }
                    text += DQ + t + DQ + ",";
                }
            }

            if (bShowInventory)
            {
                //Add extra field for Inventory
                text += DQ + "Inventory" + DQ + ",";
                //end Inventory
            }

            text = u.Chop(text) + "\n";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    if (fields.IndexOf(dc.ColumnName) > 0)
                    {
                        text += DQ + dr[dc.ColumnName] + DQ + ",";
                    }
                }

                if (bShowInventory)
                {

                    //Add extra field for inventory
                    var i = new MODELS.InventoryItemModel();
                    var pc = u.ObjToString(dr["productcode"]);
                    var isProduce = IsProduce(dr);
                    var cc = u.ObjToInt(dr["casecount"]);
                    UI.OBJECTS.AS400ProductDTO dto = listWithInventory.Find(delegate (UI.OBJECTS.AS400ProductDTO dto1) { return dto1.ProductCode.Trim() == pc.Trim(); });
                    if (dto != null)
                    {
                        OBJECTS.ProductHelper.UpdateInventoryItem(dto, isProduce, cc, i);
                    }
                    else
                    {
                        i.SummaryMsg = "";
                    }
                    
                    text += DQ + i.SummaryMsg + DQ + ",";
                    //end inventory
                }
                text = u.Chop(text) + "\n";
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            file.WriteLine(text);
            file.Close();
            return true;
        }
    
    #endregion

    #region private


    /// <summary>
    /// Get a List of Product DTOS with Inventory Info
    /// </summary>
    /// <param name="listToSend">Product DTO List </param>
    /// <returns>Product DTO List with Inventory Intems</returns>
    private static List<OBJECTS.AS400ProductDTO> getInventoryListFromService(List<OBJECTS.AS400ProductDTO> listToSend)
        {
            List<OBJECTS.AS400ProductDTO> retVal;
            try
            {
                if (listToSend.Count == 0)
                    return listToSend;


                if (Config.REALINVENTORYFETCH)
                {
                    retVal = UI.OBJECTS.AS400Product.GetProducts(listToSend); 

                }
                else
                {
                    retVal = listToSend;
                }
            }
            catch (System.Exception ex)
            {
                LogHelper.WebLogAdd(WebMsgType.ERR,ex.ToString() ,WebLogAction.SYSTEM_ERROR);
                retVal = listToSend;

            }
            return retVal;
        }

#endregion

    }
}