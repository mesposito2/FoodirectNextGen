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
using u=CSA.UTILITY.MyUtility;

namespace BusinessObjects
{
    public partial class SalepCollection : esSalepCollection
    {
        /*
                public bool LoadSalesByCustIDOld(string custid)
                {
                    string sql = @"
        select
        salepID,
        @custid as custid,
        colnum,
        line,
        p.productCode,
        sdescription,
        sjlbcs,
        CASE
        WHEN isnull(m.lbcs,0)=0 THEN p.slbcs ELSE m.lbcs 
        END as slbcs
        from salep p 
        left join pricemaster m on m.productcode=p.productcode and m.custid=@custid
        order by p.line,p.colnum
        ";
                    var p = new esParameters();
                    p.Add("custid", custid);
                    return this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p);

                }
                */


    }
}