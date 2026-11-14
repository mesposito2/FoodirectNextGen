
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:18 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'wta_ticket_line' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaTicketLineBO))]	
	[XmlType("WtaTicketLineBO")]
	public partial class WtaTicketLineBO : esWtaTicketLineBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaTicketLineBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaTicketLineCollection")]
	public partial class WtaTicketLineCollection : esWtaTicketLineCollection, IEnumerable<WtaTicketLineBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaTicketLineQuery : esWtaTicketLineQuery
	{
		public WtaTicketLineQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaTicketLineQuery(string joinAlias, out WtaTicketLineQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaTicketLineQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaTicketLineQuery query)
		{
			return WtaTicketLineQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaTicketLineQuery(string query)
		{
			return (WtaTicketLineQuery)WtaTicketLineQuery.SerializeHelper.FromXml(query, typeof(WtaTicketLineQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaTicketLineBO : esEntity
	{
		public esWtaTicketLineBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey()
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, )
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		private bool LoadByPrimaryKeyDynamic()
		{
			WtaTicketLineQuery query = new WtaTicketLineQuery();
			query.Where();
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure()
		{
			esParameters parms = new esParameters();

			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_ticket_line.tid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Tid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Tid, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Tid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.tlid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tlid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Tlid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Tlid, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Tlid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.line_num
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? LineNum
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.LineNum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.LineNum, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.LineNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.productdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productdescription
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Productdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Productdescription, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Productdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.productaltcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productaltcode
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Productaltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Productaltcode, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Productaltcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.productaltdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productaltdescription
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Productaltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Productaltdescription, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Productaltdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Qty);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.rprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rprice
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Rprice);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Rprice, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Rprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.wprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wprice
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wprice);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wprice, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Wprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.wtaxamount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wtaxamount
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wtaxamount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wtaxamount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Wtaxamount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.taxamount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Taxamount
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Taxamount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Taxamount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Taxamount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.wamount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wamount
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wamount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Wamount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Wamount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Amount
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Amount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Amount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Amount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Casecount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendorcasecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Vendorcasecount
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Vendorcasecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Vendorcasecount, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendorcasecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.totalcost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Totalcost
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Totalcost);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Totalcost, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Totalcost);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.truck_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TruckComment
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.TruckComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.TruckComment, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.TruckComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendor_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VendorComment
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.VendorComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.VendorComment, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.VendorComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.cust_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustComment
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.CustComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.CustComment, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.CustComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.state
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? State
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.State, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.State);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.um
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Um
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Um);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Um, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Um);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendorcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendorcode, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendorcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendormid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendormid, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendormid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendorname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendorname, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendorname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendordescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendordescription, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendordescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendoraltcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendoraltcode
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendoraltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendoraltcode, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendoraltcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.vendoraltdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendoraltdescription
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Vendoraltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Vendoraltdescription, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Vendoraltdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.multiple_weights
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? MultipleWeights
		{
			get
			{
				return base.GetSystemInt16(WtaTicketLineMetadata.ColumnNames.MultipleWeights);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaTicketLineMetadata.ColumnNames.MultipleWeights, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.MultipleWeights);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.customername
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customername
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Customername);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Customername, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Customername);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.directprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Directprice
		{
			get
			{
				return base.GetSystemBoolean(WtaTicketLineMetadata.ColumnNames.Directprice);
			}
			
			set
			{
				if(base.SetSystemBoolean(WtaTicketLineMetadata.ColumnNames.Directprice, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Directprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.poid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Poid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Poid, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Poid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketLineMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketLineMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.xtype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Xtype
		{
			get
			{
				return base.GetSystemString(WtaTicketLineMetadata.ColumnNames.Xtype);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketLineMetadata.ColumnNames.Xtype, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Xtype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Taxable
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.um_style
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.UmStyle, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.UmStyle);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.productweight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Productweight
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineMetadata.ColumnNames.Productweight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineMetadata.ColumnNames.Productweight, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Productweight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.forceprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Forceprice
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Forceprice);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Forceprice, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Forceprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.jwitem
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Jwitem
		{
			get
			{
				return base.GetSystemChar(WtaTicketLineMetadata.ColumnNames.Jwitem);
			}
			
			set
			{
				if(base.SetSystemChar(WtaTicketLineMetadata.ColumnNames.Jwitem, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Jwitem);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.templatex
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Templatex
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Templatex);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Templatex, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Templatex);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.wasbroken
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Wasbroken
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineMetadata.ColumnNames.Wasbroken);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineMetadata.ColumnNames.Wasbroken, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Wasbroken);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line.recordcheck
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Recordcheck
		{
			get
			{
				return base.GetSystemByteArray(WtaTicketLineMetadata.ColumnNames.Recordcheck);
			}
			
			set
			{
				if(base.SetSystemByteArray(WtaTicketLineMetadata.ColumnNames.Recordcheck, value))
				{
					OnPropertyChanged(WtaTicketLineMetadata.PropertyNames.Recordcheck);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaTicketLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketLineQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketLineQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaTicketLineQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketLineQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaTicketLineQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaTicketLineCollection : esEntityCollection<WtaTicketLineBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaTicketLineCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaTicketLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketLineQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketLineQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaTicketLineQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaTicketLineQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketLineQuery)query);
		}

		#endregion
		
		private WtaTicketLineQuery query;
	}



	[Serializable]
	abstract public partial class esWtaTicketLineQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Tid": return this.Tid;
				case "Tlid": return this.Tlid;
				case "LineNum": return this.LineNum;
				case "Productcode": return this.Productcode;
				case "Productdescription": return this.Productdescription;
				case "Productaltcode": return this.Productaltcode;
				case "Productaltdescription": return this.Productaltdescription;
				case "Qty": return this.Qty;
				case "Rprice": return this.Rprice;
				case "Wprice": return this.Wprice;
				case "Wtaxamount": return this.Wtaxamount;
				case "Taxamount": return this.Taxamount;
				case "Wamount": return this.Wamount;
				case "Amount": return this.Amount;
				case "Weight": return this.Weight;
				case "Casecount": return this.Casecount;
				case "Vendorcasecount": return this.Vendorcasecount;
				case "Totalcost": return this.Totalcost;
				case "TruckComment": return this.TruckComment;
				case "VendorComment": return this.VendorComment;
				case "CustComment": return this.CustComment;
				case "Status": return this.Status;
				case "State": return this.State;
				case "Um": return this.Um;
				case "Vendorcode": return this.Vendorcode;
				case "Vendormid": return this.Vendormid;
				case "Vendorname": return this.Vendorname;
				case "Vendordescription": return this.Vendordescription;
				case "Vendoraltcode": return this.Vendoraltcode;
				case "Vendoraltdescription": return this.Vendoraltdescription;
				case "MultipleWeights": return this.MultipleWeights;
				case "Custid": return this.Custid;
				case "Customername": return this.Customername;
				case "Directprice": return this.Directprice;
				case "Poid": return this.Poid;
				case "CreateDate": return this.CreateDate;
				case "Xtype": return this.Xtype;
				case "Taxable": return this.Taxable;
				case "UmStyle": return this.UmStyle;
				case "Productweight": return this.Productweight;
				case "Forceprice": return this.Forceprice;
				case "Jwitem": return this.Jwitem;
				case "Templatex": return this.Templatex;
				case "Wasbroken": return this.Wasbroken;
				case "Recordcheck": return this.Recordcheck;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Tid
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Tid, esSystemType.Int32); }
		} 
		
		public esQueryItem Tlid
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Tlid, esSystemType.Int32); }
		} 
		
		public esQueryItem LineNum
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.LineNum, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Productdescription
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Productdescription, esSystemType.String); }
		} 
		
		public esQueryItem Productaltcode
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Productaltcode, esSystemType.String); }
		} 
		
		public esQueryItem Productaltdescription
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Productaltdescription, esSystemType.String); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		public esQueryItem Rprice
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Rprice, esSystemType.Double); }
		} 
		
		public esQueryItem Wprice
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Wprice, esSystemType.Double); }
		} 
		
		public esQueryItem Wtaxamount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Wtaxamount, esSystemType.Double); }
		} 
		
		public esQueryItem Taxamount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Taxamount, esSystemType.Double); }
		} 
		
		public esQueryItem Wamount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Wamount, esSystemType.Double); }
		} 
		
		public esQueryItem Amount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Amount, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Vendorcasecount
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendorcasecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Totalcost
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Totalcost, esSystemType.Double); }
		} 
		
		public esQueryItem TruckComment
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.TruckComment, esSystemType.String); }
		} 
		
		public esQueryItem VendorComment
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.VendorComment, esSystemType.String); }
		} 
		
		public esQueryItem CustComment
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.CustComment, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem State
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.State, esSystemType.Int32); }
		} 
		
		public esQueryItem Um
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Um, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcode
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendorcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendormid
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendormid, esSystemType.String); }
		} 
		
		public esQueryItem Vendorname
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendorname, esSystemType.String); }
		} 
		
		public esQueryItem Vendordescription
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendordescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendoraltcode
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendoraltcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendoraltdescription
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Vendoraltdescription, esSystemType.String); }
		} 
		
		public esQueryItem MultipleWeights
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.MultipleWeights, esSystemType.Int16); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Customername
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Customername, esSystemType.String); }
		} 
		
		public esQueryItem Directprice
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Directprice, esSystemType.Boolean); }
		} 
		
		public esQueryItem Poid
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Poid, esSystemType.Int32); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Xtype
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Xtype, esSystemType.String); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Taxable, esSystemType.Int32); }
		} 
		
		public esQueryItem UmStyle
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.UmStyle, esSystemType.Int32); }
		} 
		
		public esQueryItem Productweight
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Productweight, esSystemType.Double); }
		} 
		
		public esQueryItem Forceprice
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Forceprice, esSystemType.Int32); }
		} 
		
		public esQueryItem Jwitem
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Jwitem, esSystemType.Char); }
		} 
		
		public esQueryItem Templatex
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Templatex, esSystemType.Int32); }
		} 
		
		public esQueryItem Wasbroken
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Wasbroken, esSystemType.Int32); }
		} 
		
		public esQueryItem Recordcheck
		{
			get { return new esQueryItem(this, WtaTicketLineMetadata.ColumnNames.Recordcheck, esSystemType.ByteArray); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaTicketLineBO : esWtaTicketLineBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaTicketLineMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaTicketLineMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Tid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Tid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Tlid, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Tlid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.LineNum, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.LineNum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Productdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Productdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Productaltcode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Productaltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Productaltdescription, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Productaltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Qty, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Rprice, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Rprice;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Wprice, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Wprice;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Wtaxamount, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Wtaxamount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Taxamount, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Taxamount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Wamount, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Wamount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Amount, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Amount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Weight, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Casecount, 15, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendorcasecount, 16, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendorcasecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Totalcost, 17, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Totalcost;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.TruckComment, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.TruckComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.VendorComment, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.VendorComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.CustComment, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.CustComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Status, 21, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.State, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.State;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Um, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Um;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendorcode, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendormid, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendorname, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendordescription, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendoraltcode, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendoraltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Vendoraltdescription, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Vendoraltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.MultipleWeights, 30, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.MultipleWeights;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Custid, 31, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Customername, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Customername;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Directprice, 33, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Directprice;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Poid, 34, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Poid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.CreateDate, 35, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Xtype, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Xtype;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Taxable, 37, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Taxable;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.UmStyle, 38, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Productweight, 39, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Productweight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Forceprice, 40, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Forceprice;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Jwitem, 41, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Jwitem;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Templatex, 42, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Templatex;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Wasbroken, 43, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Wasbroken;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineMetadata.ColumnNames.Recordcheck, 44, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = WtaTicketLineMetadata.PropertyNames.Recordcheck;
			c.CharacterMaxLength = 8;
			c.IsNullable = true;
			c.IsComputed = true;
			c.IsConcurrency = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaTicketLineMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Tid = "tid";
			 public const string Tlid = "tlid";
			 public const string LineNum = "line_num";
			 public const string Productcode = "productcode";
			 public const string Productdescription = "productdescription";
			 public const string Productaltcode = "productaltcode";
			 public const string Productaltdescription = "productaltdescription";
			 public const string Qty = "qty";
			 public const string Rprice = "rprice";
			 public const string Wprice = "wprice";
			 public const string Wtaxamount = "wtaxamount";
			 public const string Taxamount = "taxamount";
			 public const string Wamount = "wamount";
			 public const string Amount = "amount";
			 public const string Weight = "weight";
			 public const string Casecount = "casecount";
			 public const string Vendorcasecount = "vendorcasecount";
			 public const string Totalcost = "totalcost";
			 public const string TruckComment = "truck_comment";
			 public const string VendorComment = "vendor_comment";
			 public const string CustComment = "cust_comment";
			 public const string Status = "status";
			 public const string State = "state";
			 public const string Um = "um";
			 public const string Vendorcode = "vendorcode";
			 public const string Vendormid = "vendormid";
			 public const string Vendorname = "vendorname";
			 public const string Vendordescription = "vendordescription";
			 public const string Vendoraltcode = "vendoraltcode";
			 public const string Vendoraltdescription = "vendoraltdescription";
			 public const string MultipleWeights = "multiple_weights";
			 public const string Custid = "custid";
			 public const string Customername = "customername";
			 public const string Directprice = "directprice";
			 public const string Poid = "poid";
			 public const string CreateDate = "CreateDate";
			 public const string Xtype = "xtype";
			 public const string Taxable = "taxable";
			 public const string UmStyle = "um_style";
			 public const string Productweight = "productweight";
			 public const string Forceprice = "forceprice";
			 public const string Jwitem = "jwitem";
			 public const string Templatex = "templatex";
			 public const string Wasbroken = "wasbroken";
			 public const string Recordcheck = "recordcheck";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tid = "Tid";
			 public const string Tlid = "Tlid";
			 public const string LineNum = "LineNum";
			 public const string Productcode = "Productcode";
			 public const string Productdescription = "Productdescription";
			 public const string Productaltcode = "Productaltcode";
			 public const string Productaltdescription = "Productaltdescription";
			 public const string Qty = "Qty";
			 public const string Rprice = "Rprice";
			 public const string Wprice = "Wprice";
			 public const string Wtaxamount = "Wtaxamount";
			 public const string Taxamount = "Taxamount";
			 public const string Wamount = "Wamount";
			 public const string Amount = "Amount";
			 public const string Weight = "Weight";
			 public const string Casecount = "Casecount";
			 public const string Vendorcasecount = "Vendorcasecount";
			 public const string Totalcost = "Totalcost";
			 public const string TruckComment = "TruckComment";
			 public const string VendorComment = "VendorComment";
			 public const string CustComment = "CustComment";
			 public const string Status = "Status";
			 public const string State = "State";
			 public const string Um = "Um";
			 public const string Vendorcode = "Vendorcode";
			 public const string Vendormid = "Vendormid";
			 public const string Vendorname = "Vendorname";
			 public const string Vendordescription = "Vendordescription";
			 public const string Vendoraltcode = "Vendoraltcode";
			 public const string Vendoraltdescription = "Vendoraltdescription";
			 public const string MultipleWeights = "MultipleWeights";
			 public const string Custid = "Custid";
			 public const string Customername = "Customername";
			 public const string Directprice = "Directprice";
			 public const string Poid = "Poid";
			 public const string CreateDate = "CreateDate";
			 public const string Xtype = "Xtype";
			 public const string Taxable = "Taxable";
			 public const string UmStyle = "UmStyle";
			 public const string Productweight = "Productweight";
			 public const string Forceprice = "Forceprice";
			 public const string Jwitem = "Jwitem";
			 public const string Templatex = "Templatex";
			 public const string Wasbroken = "Wasbroken";
			 public const string Recordcheck = "Recordcheck";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(WtaTicketLineMetadata))
			{
				if(WtaTicketLineMetadata.mapDelegates == null)
				{
					WtaTicketLineMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaTicketLineMetadata.meta == null)
				{
					WtaTicketLineMetadata.meta = new WtaTicketLineMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Tid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Tlid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LineNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Rprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wtaxamount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Taxamount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wamount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Amount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Vendorcasecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Totalcost", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("TruckComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("VendorComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CustComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("State", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Um", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendormid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendordescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("MultipleWeights", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Customername", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Directprice", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Xtype", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Taxable", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("UmStyle", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productweight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Forceprice", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Jwitem", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("Templatex", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Wasbroken", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Recordcheck", new esTypeMap("timestamp", "System.Byte[]"));			
				
				
				
				meta.Source = "wta_ticket_line";
				meta.Destination = "wta_ticket_line";
				
				meta.spInsert = "proc_wta_ticket_lineInsert";				
				meta.spUpdate = "proc_wta_ticket_lineUpdate";		
				meta.spDelete = "proc_wta_ticket_lineDelete";
				meta.spLoadAll = "proc_wta_ticket_lineLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_ticket_lineLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaTicketLineMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
