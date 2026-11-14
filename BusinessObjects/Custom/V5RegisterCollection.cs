/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 1/8/2014 10:13:08 PM
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
	public partial class V5RegisterCollection : esV5RegisterCollection
	{
        public DataSet GetPagedView( int pageNumber, int pageSize, string orderBy, ref int totalCount, string filterExpression)
        {
            string coreSQL = @"select * from v5Register";

                coreSQL += " where 1=1 ";
           

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
