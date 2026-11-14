/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 9/20/2019 8:23:19 PM
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
	public partial class PriceMasterBO : esPriceMasterBO
	{
        public bool LoadByCustIDProductCode( string custID, string productCode)
        {
            var q = GetDynamicQuery();
            q.Where(q.And(query.CustID.Equal(custID),query.Productcode.Equal(productCode)));
            return query.Load();
        }
    }
}
