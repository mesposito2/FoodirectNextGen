/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/2/2014 12:57:42 PM
===============================================================================
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;
using u=CSA.UTILITY.MyUtility;

namespace BusinessObjects
{
    public partial class V5WebLogCollection : esV5WebLogCollection
    {
        public DataSet GetPagedView(int pageNumber, int pageSize, string orderBy, ref int totalCount, string filterExpression)
        {
            string coreSQL = @"select  * from v5WebLog where 1=1";


            if (!string.IsNullOrEmpty(filterExpression))
            {
                coreSQL += " AND (" + filterExpression + ")";
            }


            string sql = "sp_Get_Paged_Recordset";

            esParameters parms = new esParameters();
            if (orderBy.Trim() == "")
            {
                orderBy = "createdatetime desc";
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
        /// Execute Generic SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ds"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool ExecuteSQL(string sql, ref DataSet ds, ref string msg)
        {
            bool retVal = true;
            msg = "";
            try
            {
                ds = this.FillDataSet(EntitySpaces.DynamicQuery.esQueryType.Text, sql);
                int rows = 0;
                if (ds.Tables != null && ds.Tables.Count > 0)
                {
                    rows = ds.Tables[0].Rows.Count;
                }
                msg = "Query OK - Returned (" + rows.ToString() + ") rows.";
            }
            catch (System.Exception ex)
            {
                msg = "Error executing query: " + ex.Message;
                retVal = false;
            }
            return retVal;
        }
        public bool ExecuteNonQuery(string sql,  ref string msg)
        {
            bool retVal = true;
            msg = "";
            try
            {
                int rows= this.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text,sql);
                msg = "Query OK  - Affected  (" + rows.ToString() + ") rows.";
            }
            catch (System.Exception ex)
            {
                msg = "Error executing query: " + ex.Message;
                retVal = false;
            }
            return retVal;
        }


    }

}
