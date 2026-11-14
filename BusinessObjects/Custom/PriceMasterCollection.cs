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
using System.Runtime.InteropServices.WindowsRuntime;

namespace BusinessObjects
{
    public partial class PriceMasterCollection : esPriceMasterCollection
    {


  
        public bool ImportClosePriceMaster(ref string msg)
        {
            bool retVal = true;
            try
            {
                ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, "prClosePriceMaster");
                retVal = true;
            }
            catch (Exception ex)
            {
                retVal = false;
                msg = "There was an issue executing PriceMaster Table Swaps in with proc prClosePriceMaster: " + ex.Message;
            }

            return retVal;

        }
        public bool ImportInsertPriceMaster(string custid, string productcode, double  lbcs, double lbpc, string caseSourceCode, string pieceSourceCode, ref string msg)
        {
            bool retVal = true;

            try
            {
                var sql = @"
INSERT INTO [dbo].[PriceMasterSTG]
           ([CustID]
           ,[productcode]
           ,[lbcs]
           ,[lbpc]
           ,[CaseSourceCode]
           ,[PieceSourceCode])
     VALUES
           (@custid
           ,@productcode
           ,@lbcs
           ,@lbpc
           ,@CaseSourceCode
           ,@PieceSourceCode)
";

                esParameters parms = new esParameters();

                parms.Add("custid", custid);
                parms.Add("productcode", productcode);
                parms.Add("lbcs", lbcs);
                parms.Add("lbpc", lbpc);
                parms.Add("CaseSourceCode", caseSourceCode);
                parms.Add("PieceSourceCode", pieceSourceCode);


                var rows = ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, sql, parms);
                if (rows == 0)
                {
                    retVal = false;
                    msg = "Execute NonQuery returned no rows.";
                }
            }
            catch (Exception ex)
            {
                retVal = false;
                msg = "Could not import the record into the stgPriceMaster: " + ex.Message;
            }

            return retVal;
        }

    }
}
