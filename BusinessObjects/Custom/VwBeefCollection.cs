/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 10/30/2015 9:41:15 PM
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
	public partial class VwBeefCollection : esVwBeefCollection
	{
        public bool LoadSalesByCustID(string custid, int currentOrderID)
        {
            string sql = @"
select

   casecount1
   ,casecount2
,casecount3
,casecount4
,casecount5
,casecount6
,casecount7
,casecount8
,casecount9
,casecount10
,casecount11

,description1
,description2
,description3
,description4
,description5
,description6
,description7
,description8
,description9
,description10
,description11



     ,catid1
     ,catid2
  ,catid3
  ,catid4
  ,catid5
  ,catid6
  ,catid7
  ,catid8
  ,catid9
  ,catid10
  ,catid11

   scatid1
  ,scatid2
  ,scatid3
  ,scatid4
  ,scatid5
  ,scatid6
  ,scatid7
  ,scatid8
  ,scatid9
  ,scatid10
  ,scatid11

    ,IsMaster1
    ,IsMaster2
    ,IsMaster3
    ,IsMaster4
    ,IsMaster5
    ,IsMaster6
    ,IsMaster7
    ,IsMaster8
    ,IsMaster9
    ,IsMaster10
    ,IsMaster11
    ,description      
    ,[pcode1]
      ,[pcode2]
      ,[pcode3]
      ,[pcode4]
      ,[pcode5]
      ,[pcode6]
      ,[pcode7]
      ,[pcode8]
      ,[pcode9]
      ,[pcode10]
      ,[pcode11]
	 
	  ,[jprice1]
      ,[jprice2]
      ,[jprice3]
      ,[jprice4]
      ,[jprice5]
      ,[jprice6]
      ,[jprice7]
      ,[jprice8]
      ,[jprice9]
      ,[jprice10]
      ,[jprice11]
      ,[beefID]

,(ROUND(b.price1 * @tier,2) * @beef)  as price1
,(ROUND(b.price2 * @tier,2) * @beef) as price2
,(ROUND(b.price3 * @tier,2) * @beef)  as price3
,(ROUND(b.price4 * @tier,2) * @beef)  as price4
,(ROUND(b.price5 * @tier,2) * @beef)  as price5
,(ROUND(b.price6 * @tier,2) * @beef)  as price6
,(ROUND(b.price7 * @tier,2) * @beef)  as price7
,(ROUND(b.price8 * @tier,2) * @beef)  as price8
,(ROUND(b.price9 * @tier,2) * @beef)  as price9
,(ROUND(b.price10 * @tier,2) * @beef)  as price10
,(ROUND(b.price11 * @tier,2) * @beef)  as price11

from vwbeef b 
";
if (currentOrderID != 0)
            {
    /*
                var temp = @"
select * from 
(
select 
CASE WHEN isnull(w1.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder1,
CASE WHEN isnull(w2.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder2,
CASE WHEN isnull(w3.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder3,
CASE WHEN isnull(w4.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder4,
CASE WHEN isnull(w5.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder5,
CASE WHEN isnull(w6.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder6,
CASE WHEN isnull(w7.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder7,
CASE WHEN isnull(w8.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder8,
CASE WHEN isnull(w9.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder9,
CASE WHEN isnull(w10.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder10,
CASE WHEN isnull(w11.polid,0)=0 THEN 0 ELSE 1 END oncurrentorder11,
cs.* 
from 
(%SQL) as cs 
    
left join wta_po_line w1 on w1.poid=%ORDERID and w1.productcode=cs.pcode1
left join wta_po_line w2 on w2.poid=%ORDERID and w2.productcode=cs.pcode2
left join wta_po_line w3 on w3.poid=%ORDERID and w3.productcode=cs.pcode3
left join wta_po_line w4 on w4.poid=%ORDERID and w4.productcode=cs.pcode4
left join wta_po_line w5 on w5.poid=%ORDERID and w5.productcode=cs.pcode5
left join wta_po_line w6 on w6.poid=%ORDERID and w6.productcode=cs.pcode6
left join wta_po_line w7 on w7.poid=%ORDERID and w7.productcode=cs.pcode7
left join wta_po_line w8 on w8.poid=%ORDERID and w8.productcode=cs.pcode8
left join wta_po_line w9 on w9.poid=%ORDERID and w9.productcode=cs.pcode9
left join wta_po_line w10 on w10.poid=%ORDERID and w10.productcode=cs.pcode10
left join wta_po_line w11 on w11.poid=%ORDERID and w11.productcode=cs.pcode11

) as o
";
     */


             
                        var temp = @"
        select * from 
        (
        select 
        CASE WHEN isnull(w1.qty,0)=0 THEN 0 ELSE w1.qty END oncurrentorder1,
        CASE WHEN isnull(w2.qty,0)=0 THEN 0 ELSE w2.qty END oncurrentorder2,
        CASE WHEN isnull(w3.qty,0)=0 THEN 0 ELSE w3.qty END oncurrentorder3,
        CASE WHEN isnull(w4.qty,0)=0 THEN 0 ELSE w4.qty END oncurrentorder4,
        CASE WHEN isnull(w5.qty,0)=0 THEN 0 ELSE w5.qty END oncurrentorder5,
        CASE WHEN isnull(w6.qty,0)=0 THEN 0 ELSE w6.qty END oncurrentorder6,
        CASE WHEN isnull(w7.qty,0)=0 THEN 0 ELSE w7.qty END oncurrentorder7,
        CASE WHEN isnull(w8.qty,0)=0 THEN 0 ELSE w8.qty END oncurrentorder8,
        CASE WHEN isnull(w9.qty,0)=0 THEN 0 ELSE w9.qty END oncurrentorder9,
        CASE WHEN isnull(w10.qty,0)=0 THEN 0 ELSE w10.qty END oncurrentorder10,
        CASE WHEN isnull(w11.qty,0)=0 THEN 0 ELSE w11.qty END oncurrentorder11,
        cs.* 
        from 
        (%SQL) as cs 
    
        left join wta_po_line w1 on w1.poid=%ORDERID and w1.productcode=cs.pcode1
        left join wta_po_line w2 on w2.poid=%ORDERID and w2.productcode=cs.pcode2
        left join wta_po_line w3 on w3.poid=%ORDERID and w3.productcode=cs.pcode3
        left join wta_po_line w4 on w4.poid=%ORDERID and w4.productcode=cs.pcode4
        left join wta_po_line w5 on w5.poid=%ORDERID and w5.productcode=cs.pcode5
        left join wta_po_line w6 on w6.poid=%ORDERID and w6.productcode=cs.pcode6
        left join wta_po_line w7 on w7.poid=%ORDERID and w7.productcode=cs.pcode7
        left join wta_po_line w8 on w8.poid=%ORDERID and w8.productcode=cs.pcode8
        left join wta_po_line w9 on w9.poid=%ORDERID and w9.productcode=cs.pcode9
        left join wta_po_line w10 on w10.poid=%ORDERID and w10.productcode=cs.pcode10
        left join wta_po_line w11 on w11.poid=%ORDERID and w11.productcode=cs.pcode11

        ) as o
        ";
             
                sql = temp.Replace("%SQL", sql);
                sql = sql.Replace("%ORDERID", currentOrderID.ToString());
            }



sql = sql + " order by beefid";

            var p = new esParameters();
            p.Add("custid", custid);


            UsersBO ox = new UsersBO();
            if (!ox.LoadByCustID(custid))
            {
                throw new ApplicationException("Could not load customer with id: " + custid);
            }
            float t = 1;

            if (ox.TierPCT.HasValue)
            {
                t = u.ObjToInt(ox.TierPCT.Value);
                t = t / 10000;
                t = t + 1;
            }
            p.Add("tier", t);


            float b = 1;

            if (ox.BeefMarkup.HasValue)
            {
                b = u.ObjToInt(ox.BeefMarkup.Value);
                b = b / 1000;
                b = b + 1;
            }
            p.Add("beef", b);

            return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p);

        }
	}
}
