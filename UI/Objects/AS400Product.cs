using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using u = CSA.UTILITY.MyUtility;
using System.Configuration;

namespace UI.OBJECTS
{

    public class AS400ProductDTO
    {
        public string ProductCode { get; set; }
        public int InventoryPieces { get; set; }
        public DateTime? InventoryNextDate { get; set; }
    }


    public class AS400Product
    {
        static OdbcConnection findODBCConnection(string label, ref string msg)
        {
            OdbcConnection conn = null;
            try
            {
                string[] a = new string[]
                {  "FDAS400_PRIMARY",
                   "FDAS400_SECONDARY",
                   "FDAS400_TERTIARY"
                };
                foreach (string cname in a)
                {

                    var c = ConfigurationManager.ConnectionStrings[cname].ConnectionString;
                    conn = new OdbcConnection(c);
                    try
                    {
                        conn.Open();
                        LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, "ODBC Connection to the AS400 Established via: " + cname, BusinessObjects.WebLogAction.INFO);
                        break;
                    }
                    catch (System.Exception ex)
                    {
                        conn = null;
                        LogHelper.WebLogAdd(BusinessObjects.WebMsgType.WAR, "ODBC Connection to the AS400 via:" + cname + " could NOT be estbalished. Will Proceed with Secondary. Error:" + ex.ToString(), BusinessObjects.WebLogAction.AS400_FAILOVER);
                    }
                }

                if (conn == null)
                {
                    msg = "AS400 ODBC Connection could not be found - after trying all providers.";
                    LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg, BusinessObjects.WebLogAction.AS400_FAILOVER);
                }

            }
            catch (System.Exception ex)
            {
                msg = "Application Error- - Could not find to create AS400 ODBC connection.";
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.ERR, msg + " Error: " + ex.ToString(), BusinessObjects.WebLogAction.AS400_FAILOVER);
                conn = null;
            }

            return conn;
        }

        /// <summary>
        /// Get A single AS400 product as a DTO
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public static AS400ProductDTO GetProduct(string productCode)
        {

            var p = new AS400ProductDTO();
            p.ProductCode = productCode;
            var l = new List<AS400ProductDTO>();
            l.Add(p);
            var rList = getAS400Products(l);
            if (rList.Count() > 0)
                return rList.First();
            else
                return null;
        }

        /// <summary>
        /// Public Wrapper for getAS400Products - unclear why this is needed 
        /// </summary>
        /// <param name="list">List of AS400 DTOs to get</param>
        /// <returns></returns>
        public static List<AS400ProductDTO> GetProducts(List<AS400ProductDTO> list)
        {
            return getAS400Products(list);
        }
        /// <summary>
        /// Get the actual AS400 Products
        /// This uses a data reader for speed (and not a data set)
        /// </summary>
        /// <param name="list">List of AS400 DTOs to get</param>
        /// <returns></returns>
        private static List<AS400ProductDTO> getAS400Products(List<AS400ProductDTO> list)
        {
            OdbcConnection conn = null;
            OdbcDataReader rdr = null;

            var retVal = new List<AS400ProductDTO>();

            try
            {
                var c = ConfigurationManager.ConnectionStrings["FDAS400_PRIMARY"].ConnectionString;


                string a = "";
                foreach (var p in list)
                {
                    a += "'" + p.ProductCode + "'" + ",";
                }
                a = u.Chop(a);

                string sql = string.Format(Config.AS400_INV_SQL, a);
                sql = sql.Replace("~", "\"");

                var omsg = "";
                conn = findODBCConnection("GETAS400ProductsList", ref omsg);
                if (conn == null)
                {
                    throw new ApplicationException("Could not establish an AS400 ODBC connection: " + omsg);
                }

                rdr = null;

                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, "Execute AS400 SQL: " + sql, BusinessObjects.WebLogAction.INFO);

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    string x = u.ObjToString(rdr["pieces"]);
                    string y = u.ObjToString(rdr["nexdat"]);
                    string z = u.ObjToString(rdr["prodcd"]);

                    var p = new AS400ProductDTO();
                    p.ProductCode = z;
                    p.InventoryNextDate = null;

                    // 2//12/2022  This is wrong - the date comes through in a different format
                    //if (u.ObjToDateTime(y) != DateTime.MinValue)
                    //{
                    //    p.InventoryNextDate = u.ObjToDateTime(y);
                    //
                    //}
                    //

                    //  2//12/2022 -  If it is not 0 then do a special Parse
                    
                    if (u.ObjToInt(y) != 0)
                    {
                        //drop the last 0 if need be....
                        p.InventoryNextDate = MyHelper.MakeDateFromFD(y);

                    }

                    p.InventoryPieces = u.ObjToInt(x);

                    retVal.Add(p);
                }
            }
            catch (System.Exception ex)
            {
                throw new ApplicationException("Error in AS400 Call for Products.", ex);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return retVal;
        }
        /// <summary>
        /// Get a dataset from the 400 - based on a query
        /// </summary>
        /// <param name="sql">400 SQL statement</param>
        /// <returns></returns>
        public static bool AS400GetDataSet(string sql, ref DataSet ds, ref string msg)
        {
            var retVal = true;
            OdbcConnection conn = null;
            ds = new DataSet();
            try
            {
                string omsg = "";
                conn = findODBCConnection("GETAS400DataSet", ref omsg);
                if (conn == null)
                {
                    throw new ApplicationException("Could not establish an AS400 ODBC connection: " + omsg);
                }
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, "Execute AS400 SQL: " + sql, BusinessObjects.WebLogAction.INFO);


                OdbcDataAdapter adapter = new OdbcDataAdapter(sql, conn);
                adapter.Fill(ds);

                int rows = 0;
                if (ds.Tables != null && ds.Tables.Count > 0)
                {
                    rows = ds.Tables[0].Rows.Count;
                }

                msg = "AS400 Query OK - Returned (" + rows.ToString() + ") rows.";



            }
            catch (System.Exception ex)
            {
                msg="Error in AS400 Call for SQL execution:" +  ex.Message;
                retVal = false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return retVal; 
        }
        /// <summary>
        /// ExecuteAS400command- execute a command (not a salar) on the AS400
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ds"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AS400ExecuteNonQuery(string sql, ref string msg)
        {
            var retVal = true;
            OdbcConnection conn = null;
            try
            {
                string omsg = "";
                conn = findODBCConnection("GETAS400DataSet", ref omsg);
                if (conn == null)
                {
                    throw new ApplicationException("Could not establish an AS400 ODBC connection: " + omsg);
                }
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.OK, "Execute AS400 SQL: " + sql, BusinessObjects.WebLogAction.INFO);


                OdbcCommand command = new OdbcCommand(sql, conn);
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                
                msg = "AS400 Non Query command executed OK: "+sql;


            }
            catch (System.ArithmeticException aex)
            {
                //do nothing - there is a bug n 400 code... 
                LogHelper.WebLogAdd(BusinessObjects.WebMsgType.WAR, "Arithmatic Error in AS400 Call - will ignore:" + aex.Message, BusinessObjects.WebLogAction.INFO);
            }
            catch (System.Exception ex)
            {
                msg = "Error in AS400 Call for SQL non query execution:" + ex.Message;
                retVal = false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return retVal;
        }


        /// <summary>
        /// Get the  EOW status set on the AS400
        /// This is used for the weeky email job
        /// </summary>
        /// <param name="status"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        static public bool GetEOWStatus(ref string status, ref string msg)
        {
            bool retVal = false;
            string sql = Config.AS400_EOW_SQL_GET;
            string gmsg = "";
            DataSet ds = null;

            status = "";
            msg = "";

            sql = sql.Replace("~", "\"");
            if (AS400GetDataSet(sql,ref ds,ref gmsg))
            {
                if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
                {
                    status = u.ObjToString(ds.Tables[0].Rows[0]["DSCFLG1"]);
                    retVal = true;
                }
                else
                {
                    msg = "AS400Product.GetEOWStatus Query Executed OK but returned no data.";
                    retVal = false;
                }
            }
            else
            {
                msg= "AS400Product.GetEOWStatus Could not get the EOW Status: " + gmsg;
                retVal = false;
            }


            return retVal;
        }
        /// <summary>
        /// Set the EOW Status - 
        /// This is used for the weeky email job
        /// </summary>
        /// <param name="status"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        static public bool SetEOWStatus(string status, ref string msg)
        {
            bool retVal = false;
            string sql = Config.AS400_EOW_SQL_SET;
            string gmsg = "";
         
            //status = "";
            msg = "";

            sql = string.Format(sql, status);
            sql = sql.Replace("~", "\"");
           

            if (AS400ExecuteNonQuery(sql,  ref gmsg))
            {
                retVal = true;
            }
            else
            {
                msg = "AS400Product.SetEOWStatus Could not set the EOW Status: " + gmsg;
                retVal = false;
            }


            return retVal;
        }
    }
}

