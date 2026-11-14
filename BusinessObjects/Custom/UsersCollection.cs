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

using EntitySpaces.Interfaces;
using EntitySpaces.Core;
using u = CSA.UTILITY.MyUtility;

namespace BusinessObjects
{
	public partial class UsersCollection : esUsersCollection
	{
        public bool ExecuteSQL(string sql, ref DataSet ds, ref string msg)
        {
            bool retVal = true;
            msg = "";
            try
            {
                
                ds = this.FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
                int rows = 0;
                if (ds.Tables!=null && ds.Tables.Count>0)
                {
                    rows = ds.Tables[0].Rows.Count;
                }

                    msg = "Query OK - Returned ("+rows.ToString()+") rows.";

            }
            catch (System.Exception ex)
            {
                msg = "Error executing query: " + ex.Message;
                retVal = false;
            }

            return retVal;
        }
        
        public void UpdateSalesMan()
        {
            ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, "prUpdateSalesMan");
        }

        public void DisableImportUsers()
        {
            ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, "update users set flags=2 where (type<>4 and type<>5)");
        }
        public void ClearLastBookfile()
        {
            ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text,"update users set LastBookFile=null");
        }
        public bool PurgeAccount(string custid, ref string msg)
        {
            bool retVal = true;
            try
            {
                esParameters parms = new esParameters();
                parms.Add("pcustid", custid);
                var SQL = "SP_CUSTSCRUB";
                ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure,SQL,parms);
            }
            catch (System.Exception ex)
            {
                retVal = false;
                msg = ex.ToString();
            }
            return retVal;
        }

        public DataSet GetPersonsOfInterest(ref int totalCount)
        {
            string coreSQL = @"select * from users";

            coreSQL += " where (type=5 or type=4) ";
            /*

            if (!string.IsNullOrEmpty(filterExpression))
            {
                coreSQL += " AND (" + filterExpression + ")";
            }
            */


            string sql = coreSQL;
            esParameters parms = new esParameters();
            

            var ds = FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql, parms);
            totalCount = 0;
            if (ds.Tables[0] != null)
            {
                totalCount = ds.Tables[0].Rows.Count;
            }
            return ds;
        }

        public DataSet GetPagedView(int pageNumber, int pageSize, string orderBy, ref int totalCount, string filterExpression)
        {
            string coreSQL = @"select * from users";

            coreSQL += " where 1=1 ";


            if (!string.IsNullOrEmpty(filterExpression))
            {
                coreSQL += " AND (" + filterExpression + ")";
            }

            string sql = "sp_Get_Paged_Recordset";

            esParameters parms = new esParameters();
            if (orderBy.Trim() == "")
            {
                orderBy = "bizname asc";
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
        /// <summary>
        /// Flag=0 active web member
        /// Flag =1 active non web
        /// Flag=2 - inactive
        /// types = FDLegacyRoles
        /// 
        /// </summary>
        /// <returns></returns>
        public bool LoadWebMembers()
        {
                string sql;

            
            //all
            sql = @"
   
select * from users  
where (type=2 or type=3 or type=7)  
and (flags=0)
order by bizname
";
            //var p = new esParameters();
            //p.Add("custid", custid);
            //return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p)
              return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
       
        
    
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">ALL -all, NONEU - whole salers (non eu), EU End users</param>
        /// <returns></returns>
        public bool LoadActiveMarketingUsers(string filter)
        {
            string sql;

            //all
            sql = @"
   
select * from users  
where (type=2 or type=3 or type=7)  
and (flags=0  or flags=1)
order by bizname
";

            if (filter == "NONEU")
            {
                sql = @"
   
select * from users  
where (type=3 or type=7)  
and (flags=0  or flags=1)
order by bizname
";
            }
            else if (filter == "EU")
            {
                sql = @"
   
select * from users  
where (type=2)  
and (flags=0  or flags=1)
order by bizname
";
            }
            //var p = new esParameters();
            //p.Add("custid", custid);
            //return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p)
              return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
       
        }
    }
 
}
