/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 11/21/2013 11:26:58 PM
===============================================================================
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;
using u = CSA.UTILITY.MyUtility;

namespace BusinessObjects
{
    public partial class ProdsCollection : esProdsCollection
    {

        public DataSet GetBook(string custID)
        {

            var SQL = "";
            SQL = @"
 select 0 as onspeedlist
,'' as LastDate
,0 as isfavorite
,0 as oncurrentorder
,p.productcode
,p.description
,p.brandcode
,p.onPriceList
,p.CategoryName
,p.SubCategoryName
,p.catid
,p.scatid
,p.keywords
,p.weight
,p.groupcode
,p.PresentInLastImport
,p.qtyonhand
,CASE
     WHEN isnull(m.lbcs,0)=0 THEN p.lbcs ELSE m.lbcs 
END as lbcs
,CASE
     WHEN isnull(m.lbpc,0)=0 THEN p.lbpc ELSE m.lbpc 
END as lbpc
,p.casecount
 from vwProds p
left join catsub cs on p.scatid=cs.scatid
left join pricemaster m on m.productcode=p.productcode and custid='%custID'
Where 1=1
";
            SQL = SQL.Replace("%custID", custID);
            //}
            //else
            //{
            //    SQL = @"select 0 as onspeedlist, '' as LastDate,0 as isfavorite, 0 as oncurrentorder ,p.* from vwProds p";
            //
            //}
            SQL += " order by p.CategoryName,cs.Description";
            DataSet ds = null;

            try
            {
                ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, SQL);
            }
            catch (System.Exception ex)
            {
                throw new ApplicationException(SQL, ex);
            }
            return ds;
        }

        public DataSet GetPagedView(bool isAdmin, int pageNumber, int pageSize, string orderBy, ref int totalCount, string custid, int currentOrderID, string filterExpression, string subsearch, bool forceOrderGuide, ref string sqlOut)
        {


            //isMaster check is built into vwProds

            //Default core sql used for admin and basic anon users            
            string coreSQL = @"select 0 as onspeedlist, '' as LastDate,0 as isfavorite, 0 as oncurrentorder ,p.* from vwProds p";

            //If a customer associated with the query look up their prices, order stuff speed list etc.  
            if (!string.IsNullOrEmpty(custid) && !isAdmin)
            {
                string priceSQL = "";

                //Admins have no specific prices - so just show regular
                if (!isAdmin)
                {
                    priceSQL = @"

 select 
 p.productcode
,p.description
,p.brandcode
,p.onPriceList
,p.CategoryName
,p.SubCategoryName
,p.catid
,p.scatid
,p.keywords
,p.weight
,p.groupcode
,p.PresentInLastImport
,p.qtyonhand
,p.AvgCost
,p.AdjCost
,p.ProductCodeSub
,CASE
     WHEN isnull(m.lbcs,0)=0 THEN p.lbcs ELSE m.lbcs 
END as lbcs
,CASE
     WHEN isnull(m.lbpc,0)=0 THEN p.lbpc ELSE m.lbpc 
END as lbpc
,p.casecount
 from vwProds p
join pricemaster m on m.productcode=p.productcode
where custid='%custid'";
                }


                coreSQL = @"
select distinct  
speedid,
CASE
     WHEN isnull(speedid,0)=0 THEN 0 ELSE 1 
END onspeedlist,
s.lastDate,
CASE
     WHEN isnull(favoriteid,0)=0 THEN 0 ELSE 1 
END isfavorite,
f.*,
IsNull(pcg.ProdCustGuideID,0) as ProdCustGuideID
from 
(
select distinct favoriteid ,y.* 
from 
(
%priceSQL
) y
left join favorite as fx on fx.productcode=y.productcode and fx.custid='%custid'
) as f  
left join speed as s on s.productcode=f.productcode and s.custid='%custid'
left join ProdCustGuide as pcg on pcg.productcode=f.productcode and pcg.custid='%custid'
";

                coreSQL = coreSQL.Replace("%priceSQL", priceSQL);
                coreSQL = coreSQL.Replace("%custid", custid);
                var sqlR = coreSQL;

                //now if an order was passed in
                if (currentOrderID != 0)
                {
                    coreSQL = @"
select * from 
(
select 
CASE
     WHEN isnull(w.polid,0)=0 THEN 0 ELSE 1 
END oncurrentorder,
cs.* 
from 
(%SQL) as cs 
left join wta_po_line w on w.poid=%ORDERID and w.productcode=cs.productcode
) as o
";
                }
                else
                {
                    coreSQL = @"
select * from 
(
select 0 as oncurrentorder,
* 
from 
(%SQL) as c
) as o
";
                } //order

                coreSQL = coreSQL.Replace("%SQL", sqlR);
                coreSQL = coreSQL.Replace("%ORDERID", currentOrderID.ToString());
            }//custid
             //end code to build special core sql code for customers

            coreSQL += " WHERE 1=1 and PresentInLastImport=1 ";
            if (forceOrderGuide)
            {
                coreSQL += "  and ProdCustGuideID<>0 ";
            }
            if (!string.IsNullOrEmpty(filterExpression))
            {
                coreSQL += "  AND (" + filterExpression + ")";
            }

            if (!string.IsNullOrEmpty(subsearch))
            {
                coreSQL = "select * from (" + coreSQL + ") as cs where 1=1 and (keywords like '%" + subsearch + "%' or productcode like '%" + subsearch + "%'  or description like '%" + subsearch + "%')";
            }

            sqlOut = coreSQL;

            string sql = "sp_Get_Paged_Recordset";

            esParameters parms = new esParameters();
            if (orderBy.Trim() == "")
            {
                orderBy = "productcode asc";
            }
            //always order by the quantity on hand.
            orderBy = "dbo.IntHasValue(qtyonHand) desc," + orderBy;




            parms.Add("PageNumber", pageNumber);
            parms.Add("PageSize", pageSize);
            parms.Add("CoreSql", coreSQL);
            parms.Add("OrderBy", orderBy);
            parms.Add("TotalRecords", esParameterDirection.Output, DbType.Int32, 0);


            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, sql, parms);
            totalCount = u.ObjToInt(parms["TotalRecords"].Value);
            return ds;
        }
        public DataSet GetAllProducts()
        {
            string sql = @"select * from vwProds where PresentInLastImport=1 order by dbo.IntHasValue(qtyonHand) desc,description";

            return FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
        }
        public DataSet GetAllProductsThatContain(string s, bool forceOrderGuide = false, string custId = "")
        {
            s = s.Trim();
            string sql1 = "";
            string sql2 = "";

            if (forceOrderGuide && custId != string.Empty)
            {
                sql1 = @"
select * from prods p
join ProdCustGuide pcg  on pcg.ProductCode=p.productcode and custid='{0}'
where  (PresentInLastImport=1 and isMaster=0) and
(
(p.productcode like '%{1}%')
or
(description like '%{1}%')
or
(keywords like '%{1}%')
)
order by dbo.IntHasValue(qtyonHand) desc,description asc";

                sql1 = string.Format(sql1, custId, s);

                sql2 = @"

select top 100 from prods p 
join ProdCustGuide pcg  on pcg.ProductCode=p.productcode and custid='{0}'
order by dbo.IntHasValue(qtyonHand) desc, description asc";

                sql2 = string.Format(sql2, custId);

            }
            else
            {
                sql1 = @"

select * from prods where  (PresentInLastImport=1 and isMaster=0) and

(
(productcode like '%{0}%')
or
(description like '%{0}%')
or
(keywords like '%{0}%')

)
order by dbo.IntHasValue(qtyonHand) desc,description asc";
                sql1 = string.Format(sql1, s);


                sql2 = @"select top 100 from prods order by dbo.IntHasValue(qtyonHand) desc, description asc";
            }


            string sql = "";
            if (s == string.Empty)
            {
                sql = sql2;
            }
            else
            {
                sql = sql1;
            }
            return FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
        }


        /// <summary>
        /// Get a data set based on sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql)
        {
            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
            return ds;
        }



        public void ImportPrepareProds()
        {
            ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, "prImportPrepareProds");
        }
    }
}
