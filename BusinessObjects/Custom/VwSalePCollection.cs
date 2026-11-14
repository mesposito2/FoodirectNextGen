/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 10/29/2015 8:54:20 AM
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
    public partial class VwSalePCollection : esVwSalePCollection
    {
        public bool LoadSalesByCustID(string custid,int currentOrderID)
        {
            string sql = @"
select
casecount,
ismaster,
salepID,
@custid as custid,
colnum,
line,
p.productCode,
sdescription,
sjlbcs,
(slbcs * @tier) as slbcs
from vwsalep p 

";
 if (currentOrderID != 0)
                {
                    var temp = @"
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

     sql = temp.Replace("%SQL", sql);
     sql = sql.Replace("%ORDERID", currentOrderID.ToString());
 }

 sql = sql + " order by line,colnum";
            var p = new esParameters();
            p.Add("custid", custid);

            UsersBO ox = new UsersBO();
            if (!ox.LoadByCustID(custid))
            {
                throw new ApplicationException("Could not weekly specials data for customer with id: " + custid);
            }
            float t = 1;

            if (ox.TierPCT.HasValue)
            {
                t = u.ObjToInt(ox.TierPCT.Value);
                t = t / 10000;
                t = t + 1;
            }
            p.Add("tier", t);



            return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p);

        }

    }

}
