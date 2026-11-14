/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 11/21/2013 11:26:59 PM
===============================================================================
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using u = CSA.UTILITY.MyUtility;
using EntitySpaces.Interfaces;
using EntitySpaces.Core;

namespace BusinessObjects
{
	public partial class WtaPoCollection : esWtaPoCollection
	{


        public bool LoadAllReadyPOSForToday()
        {
            string sql;
            sql = @"select * from wta_po where postdate<@Tommorow and statusUCode =@statusUcode";
            var p = new esParameters();
            p.Add("Tommorow", DateTime.Now.AddDays(1).ToShortDateString());
            p.Add("statusUCode", "READY");
            return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p);
        }

        public DataSet FindOrders(string s)
        {
            string sql = @"
select * from wta_po 
where 
(
(FDRInvoice like '%@search%')
or
(cast(poid as varchar(100)) like '%@search%') 
)";
            
            esParameters parms = new esParameters();
            parms.Add("search", s);
            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql, parms);
            return ds;
        }

        public DataSet GetTop100Bills(string custid)
        {
            string sql = @"
select top 100 u.bizname,p.*  
from wta_po p 
join users u on p.mid=u.custid  
where 1=1 
and MID=@custid
and statusUCODE='CLOSED'
order by createDate desc
";

            esParameters parms = new esParameters();
            parms.Add("custid", custid);
      
            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql, parms);
            
            return ds;

        }
        
        public DataSet GetBills(string custid, DateTime startDate, DateTime endDate, ref int totalCount, ref double totalCost)
        {
            string sql = @"
select  u.bizname,p.*  
from wta_po p 
join users u on p.mid=u.custid  
where 1=1 
and MID=@custid
and statusUCODE='CLOSED'

and shipDate>=@startDate
and shipDate<=@endDate

";

//9/12/Look at Post date 
/*
and createDate>=@startDate
and createDate<=@endDate
*/


            startDate = u.ObjToDateTime(startDate.ToShortDateString()+" 00:00:00");
            endDate = u.ObjToDateTime(endDate.ToShortDateString()+" 23:59:59");


            esParameters parms = new esParameters();
            parms.Add("custid", custid);
            parms.Add("startDate", startDate);
            parms.Add("endDate", endDate);
            
            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql, parms);
            totalCount = ds.Tables[0].Rows.Count;
            totalCost = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                totalCost += u.ObjToDouble(dr["merchTotal"]) + u.ObjToDouble(dr["TaxTotal"]) + u.ObjToDouble(dr["FreightTotal"]);
            }

            //now get the total cost 
            //var sqlcost = "select  sum(IsNull(merchtotal,0)+IsNull(TaxTotal,0)+IsNull(FreightTotal,0)) from (" + sql + ") as x";
            //totalCost = u.ObjToDouble(ExecuteScalar(EntitySpaces.DynamicQuery.esQueryType.Text, sqlcost));
            return ds;

        }
        public DataSet GetPagedView(bool isAdmin, int pageNumber, int pageSize, string orderBy, ref int totalCount, string custid, string filterExpression)
        {
            string coreSQL = @"select  u.bizname,p.*  from wta_po  p join users u on p.mid=u.custid";

            //If an admin - show all - of not - don't show. 
            if (!isAdmin)
            {
                coreSQL += " where MID='" + custid + "' ";
            }
            else
            {
                coreSQL += " where 1=1 ";
            }


            if (!string.IsNullOrEmpty(filterExpression))
            {
                coreSQL += " AND (" + filterExpression + ")";
            }


            string sql = "sp_Get_Paged_Recordset";

            esParameters parms = new esParameters();
            if (orderBy.Trim() == "")
            {
                orderBy = "createdate desc";
            }


            parms.Add("PageNumber", pageNumber);
            parms.Add("PageSize", pageSize);
            parms.Add("CoreSql", coreSQL);
            parms.Add("OrderBy", orderBy);
            parms.Add("TotalRecords", esParameterDirection.Output, DbType.Int32, 0);


            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, sql, parms);
            totalCount = u.ObjToInt(parms["TotalRecords"].Value);
            return ds;
        }
        
	}
}
