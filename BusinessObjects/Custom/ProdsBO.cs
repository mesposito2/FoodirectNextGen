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

using EntitySpaces.Interfaces;
using EntitySpaces.Core;

namespace BusinessObjects
{
	public partial class ProdsBO : esProdsBO
	{

        const string coreSQL = @"
select 
 p.productcode
,p.description
,p.brandcode
,p.CategoryName
,p.catid
,p.scatid
,p.keywords
,p.weight
,p.weight_type
,p.OnPriceList
,p.groupcode
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
where custid='%custid'
and p.productCode='%productCode'
";
        public bool LoadByPrimaryKeyAndCustID(string productCode, string custID)
        {
            string sql=coreSQL.Replace("%custid",custID);
            sql=sql.Replace("%productCode",productCode);  
            var b=base.Load(EntitySpaces.DynamicQuery.esQueryType.Text,sql);
            return b;
        }


        public bool LoadByProductCode(string productCode)
        {
            var q = GetDynamicQuery();
            q.Where(query.Productcode ==productCode);
            return query.Load();
        }

    }
}
