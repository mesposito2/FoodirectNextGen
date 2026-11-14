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
	public partial class WtaPoBO : esWtaPoBO
	{
        public string BizName { get; set; }

        private WtaPoLineCollection polines = null;

        public WtaPoLineCollection POlines
        {
            get
            {
                if (polines == null)
                {


                    polines = new WtaPoLineCollection();


                    var q = new WtaPoLineQuery();
                    q.Where(q.Poid.Equal(this.Poid.Value));
                    polines.Load(q);
                }
                return polines;
            }
           
        }
       public void RefreshLines()
       {
           polines = null; ;
        
       }
       override public bool LoadByPrimaryKey(int poid)
       {

           esParameters p = new esParameters();

           p.Add(new esParameter("poid", poid));



           string sql = @"

select  u.bizname,p.*  from wta_po p join users u on p.mid=u.custid where poid=@poid";



           bool retVal = this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql, p);

           if (retVal)
           {

               BizName = u.ObjToString(this.GetColumn("BizName"));

           }



           return retVal;

       }
        public bool LoadByFDRInvoice(string fdrInvoice)
        {
            esParameters p = new esParameters();
            p.Add(new esParameter("fdrInvoice", fdrInvoice));

            string sql = @"

select  u.bizname,p.*  from wta_po p join users u on p.mid=u.custid where FDRInvoice=@fdrInvoice";

            bool retVal = this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql,p);

            if (retVal)
            {
                BizName = u.ObjToString(this.GetColumn("BizName"));
            }

            return retVal;

        }

        //Load By PONUM takeinto account a PONUM gets a character 
        //added to it when it comes and or is reffered to by Foodirect.
        public bool LoadByPONumAndMember(string poNum,string mid)
       {
            //esParameters p = new esParameters();
            //p.Add(new esParameter("poid", poid));

            string sql = @"

select  u.bizname,p.*  from wta_po p join users u on p.mid=u.custid where poNum like '%" + poNum + "' and mid='"+mid+"'";

            bool retVal = this.Load(EntitySpaces.DynamicQuery.esQueryType.Text, sql);

            if (retVal)
            {
                BizName = u.ObjToString(this.GetColumn("BizName"));
            }
            
            return retVal;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poid"></param>
        public void KillAllLines(int poid)
        {
            esParameters p = new esParameters();
            p.Add(new esParameter("poid", poid));

            string sql = @"

delete from wta_po_line where poid=@poid";

           int retval=this.ExecuteNonQuery(EntitySpaces.DynamicQuery.esQueryType.Text, sql,p);

         
            return;

        }



    }
}
