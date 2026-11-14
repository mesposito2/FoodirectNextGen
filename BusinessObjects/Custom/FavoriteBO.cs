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
	public partial class FavoriteBO : esFavoriteBO
	{
        public bool LoadByCustIDAndProductCode(string userName, string productCode)
        {
            var q = GetDynamicQuery();
            q.Where(q.And(query.CustID.Equal(userName),q.ProductCode.Equal(productCode)));
            return query.Load();
        }
    }
}
