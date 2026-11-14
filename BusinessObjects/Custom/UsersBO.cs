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
	public partial class UsersBO : esUsersBO
	{
        public bool LoadByCustID(string custID)
        {
            var q = GetDynamicQuery();
            q.Where(query.Custid  == custID);
            return query.Load();
        }
        public bool LoadByInternetID(string internetID)
        {
            var q = GetDynamicQuery();
            q.Where(query.Internetid == internetID);
            return query.Load();
        }
        public double GetSalesTaxRate()
        {
            double retVal=0; 

            if (this.SalesTaxType.HasValue && u.ObjToBool(this.SalesTaxType.Value))
            {
                var sr=this.SalesTaxRegion;
                if (string.IsNullOrEmpty(sr))
                {
                    sr= "FD";
                }
                var s = new WtaSalesTaxBO();
                s.LoadByRegion(this.SalesTaxRegion);
                retVal = u.ObjToDouble(s.Rate);
            }
            return retVal;
        }
	}
}
