
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
	/// Encapsulates the 'wta_ticket' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaTicketBO))]	
	[XmlType("WtaTicketBO")]
	public partial class WtaTicketBO : esWtaTicketBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaTicketBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaTicketCollection")]
	public partial class WtaTicketCollection : esWtaTicketCollection, IEnumerable<WtaTicketBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaTicketQuery : esWtaTicketQuery
	{
		public WtaTicketQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaTicketQuery(string joinAlias, out WtaTicketQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaTicketQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaTicketQuery query)
		{
			return WtaTicketQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaTicketQuery(string query)
		{
			return (WtaTicketQuery)WtaTicketQuery.SerializeHelper.FromXml(query, typeof(WtaTicketQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaTicketBO : esEntity
	{
		public esWtaTicketBO()
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
			WtaTicketQuery query = new WtaTicketQuery();
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
		/// Maps to wta_ticket.tid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Tid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Tid, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Tid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.invoice_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? InvoiceId
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.InvoiceId);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.InvoiceId, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.InvoiceId);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.offline
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Offline
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Offline);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Offline, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Offline);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.customername
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customername
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Customername);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Customername, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Customername);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.postdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Postdate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketMetadata.ColumnNames.Postdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketMetadata.ColumnNames.Postdate, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Postdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.duedate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Duedate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketMetadata.ColumnNames.Duedate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketMetadata.ColumnNames.Duedate, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Duedate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.createdbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Createdbyname, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Createdbyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.lastupdateby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdateby
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Lastupdateby);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Lastupdateby, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Lastupdateby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.lastupdatebyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdatebyname
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Lastupdatebyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Lastupdatebyname, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Lastupdatebyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.salesmanid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Salesmanid
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Salesmanid);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Salesmanid, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Salesmanid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.salesmanname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Salesmanname
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Salesmanname);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Salesmanname, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Salesmanname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.terms
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Terms
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Terms);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Terms, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Terms);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.shipmethod
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipmethod
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Shipmethod);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Shipmethod, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Shipmethod);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.paymethod
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Paymethod
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Paymethod);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Paymethod, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Paymethod);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.custrec
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custrec
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Custrec);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Custrec, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Custrec);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.cust_note
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustNote
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.CustNote);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.CustNote, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.CustNote);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.vendor_note
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VendorNote
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.VendorNote);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.VendorNote, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.VendorNote);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.route_note
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RouteNote
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.RouteNote);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.RouteNote, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.RouteNote);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.shipaddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipaddress
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Shipaddress);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Shipaddress, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Shipaddress);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.billaddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Billaddress
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Billaddress);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Billaddress, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Billaddress);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.WTaxTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? WTaxTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.WTaxTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.WTaxTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.WTaxTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.WMerchTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? WMerchTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.WMerchTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.WMerchTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.WMerchTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.MerchTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? MerchTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.MerchTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.MerchTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.MerchTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.TaxTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? TaxTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.TaxTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.TaxTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.TaxTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.WeightTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? WeightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.WeightTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.WeightTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.WeightTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.FreightTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? FreightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaTicketMetadata.ColumnNames.FreightTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketMetadata.ColumnNames.FreightTotal, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.FreightTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.routeid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Routeid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Routeid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Routeid, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Routeid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.routename
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Routename
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Routename);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Routename, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Routename);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Phone);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.templatetype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Templatetype
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Templatetype);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Templatetype, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Templatetype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.templatetitle
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Templatetitle
		{
			get
			{
				return base.GetSystemString(WtaTicketMetadata.ColumnNames.Templatetitle);
			}
			
			set
			{
				if(base.SetSystemString(WtaTicketMetadata.ColumnNames.Templatetitle, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Templatetitle);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.templatefrequency
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Templatefrequency
		{
			get
			{
				return base.GetSystemInt32(WtaTicketMetadata.ColumnNames.Templatefrequency);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketMetadata.ColumnNames.Templatefrequency, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Templatefrequency);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket.templatelastdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Templatelastdate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketMetadata.ColumnNames.Templatelastdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketMetadata.ColumnNames.Templatelastdate, value))
				{
					OnPropertyChanged(WtaTicketMetadata.PropertyNames.Templatelastdate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaTicketQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaTicketQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaTicketQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaTicketCollection : esEntityCollection<WtaTicketBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaTicketCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaTicketQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaTicketQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaTicketQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketQuery)query);
		}

		#endregion
		
		private WtaTicketQuery query;
	}



	[Serializable]
	abstract public partial class esWtaTicketQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Tid": return this.Tid;
				case "InvoiceId": return this.InvoiceId;
				case "Mid": return this.Mid;
				case "Custid": return this.Custid;
				case "Offline": return this.Offline;
				case "Customername": return this.Customername;
				case "Createdate": return this.Createdate;
				case "Lastupdate": return this.Lastupdate;
				case "Postdate": return this.Postdate;
				case "Duedate": return this.Duedate;
				case "Createdby": return this.Createdby;
				case "Createdbyname": return this.Createdbyname;
				case "Lastupdateby": return this.Lastupdateby;
				case "Lastupdatebyname": return this.Lastupdatebyname;
				case "Salesmanid": return this.Salesmanid;
				case "Salesmanname": return this.Salesmanname;
				case "Terms": return this.Terms;
				case "Shipmethod": return this.Shipmethod;
				case "Paymethod": return this.Paymethod;
				case "Custrec": return this.Custrec;
				case "CustNote": return this.CustNote;
				case "VendorNote": return this.VendorNote;
				case "RouteNote": return this.RouteNote;
				case "Status": return this.Status;
				case "Shipaddress": return this.Shipaddress;
				case "Billaddress": return this.Billaddress;
				case "WTaxTotal": return this.WTaxTotal;
				case "WMerchTotal": return this.WMerchTotal;
				case "MerchTotal": return this.MerchTotal;
				case "TaxTotal": return this.TaxTotal;
				case "WeightTotal": return this.WeightTotal;
				case "FreightTotal": return this.FreightTotal;
				case "Routeid": return this.Routeid;
				case "Routename": return this.Routename;
				case "Phone": return this.Phone;
				case "Templatetype": return this.Templatetype;
				case "Templatetitle": return this.Templatetitle;
				case "Templatefrequency": return this.Templatefrequency;
				case "Templatelastdate": return this.Templatelastdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Tid
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Tid, esSystemType.Int32); }
		} 
		
		public esQueryItem InvoiceId
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.InvoiceId, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Offline
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Offline, esSystemType.Int32); }
		} 
		
		public esQueryItem Customername
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Customername, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Postdate
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Postdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Duedate
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Duedate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Createdbyname
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Createdbyname, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdateby
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Lastupdateby, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdatebyname
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Lastupdatebyname, esSystemType.String); }
		} 
		
		public esQueryItem Salesmanid
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Salesmanid, esSystemType.String); }
		} 
		
		public esQueryItem Salesmanname
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Salesmanname, esSystemType.String); }
		} 
		
		public esQueryItem Terms
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Terms, esSystemType.Int32); }
		} 
		
		public esQueryItem Shipmethod
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Shipmethod, esSystemType.String); }
		} 
		
		public esQueryItem Paymethod
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Paymethod, esSystemType.String); }
		} 
		
		public esQueryItem Custrec
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Custrec, esSystemType.String); }
		} 
		
		public esQueryItem CustNote
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.CustNote, esSystemType.String); }
		} 
		
		public esQueryItem VendorNote
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.VendorNote, esSystemType.String); }
		} 
		
		public esQueryItem RouteNote
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.RouteNote, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem Shipaddress
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Shipaddress, esSystemType.String); }
		} 
		
		public esQueryItem Billaddress
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Billaddress, esSystemType.String); }
		} 
		
		public esQueryItem WTaxTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.WTaxTotal, esSystemType.Double); }
		} 
		
		public esQueryItem WMerchTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.WMerchTotal, esSystemType.Double); }
		} 
		
		public esQueryItem MerchTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.MerchTotal, esSystemType.Double); }
		} 
		
		public esQueryItem TaxTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.TaxTotal, esSystemType.Double); }
		} 
		
		public esQueryItem WeightTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.WeightTotal, esSystemType.Double); }
		} 
		
		public esQueryItem FreightTotal
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.FreightTotal, esSystemType.Double); }
		} 
		
		public esQueryItem Routeid
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Routeid, esSystemType.Int32); }
		} 
		
		public esQueryItem Routename
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Routename, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Templatetype
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Templatetype, esSystemType.Int32); }
		} 
		
		public esQueryItem Templatetitle
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Templatetitle, esSystemType.String); }
		} 
		
		public esQueryItem Templatefrequency
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Templatefrequency, esSystemType.Int32); }
		} 
		
		public esQueryItem Templatelastdate
		{
			get { return new esQueryItem(this, WtaTicketMetadata.ColumnNames.Templatelastdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaTicketBO : esWtaTicketBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaTicketMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaTicketMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Tid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Tid;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.InvoiceId, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.InvoiceId;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Mid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Custid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Offline, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Offline;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Customername, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Customername;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Createdate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Lastupdate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Postdate, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Postdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Duedate, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Duedate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Createdby, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Createdbyname, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Lastupdateby, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Lastupdateby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Lastupdatebyname, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Lastupdatebyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Salesmanid, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Salesmanid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Salesmanname, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Salesmanname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Terms, 16, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Terms;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Shipmethod, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Shipmethod;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Paymethod, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Paymethod;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Custrec, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Custrec;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.CustNote, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.CustNote;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.VendorNote, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.VendorNote;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.RouteNote, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.RouteNote;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Status, 23, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Shipaddress, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Shipaddress;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Billaddress, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Billaddress;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.WTaxTotal, 26, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.WTaxTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.WMerchTotal, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.WMerchTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.MerchTotal, 28, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.MerchTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.TaxTotal, 29, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.TaxTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.WeightTotal, 30, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.WeightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.FreightTotal, 31, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketMetadata.PropertyNames.FreightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Routeid, 32, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Routeid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Routename, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Routename;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Phone, 34, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Templatetype, 35, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Templatetype;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Templatetitle, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Templatetitle;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Templatefrequency, 37, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Templatefrequency;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketMetadata.ColumnNames.Templatelastdate, 38, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketMetadata.PropertyNames.Templatelastdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaTicketMetadata Meta()
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
			 public const string InvoiceId = "invoice_id";
			 public const string Mid = "mid";
			 public const string Custid = "custid";
			 public const string Offline = "offline";
			 public const string Customername = "customername";
			 public const string Createdate = "createdate";
			 public const string Lastupdate = "lastupdate";
			 public const string Postdate = "postdate";
			 public const string Duedate = "duedate";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
			 public const string Lastupdateby = "lastupdateby";
			 public const string Lastupdatebyname = "lastupdatebyname";
			 public const string Salesmanid = "salesmanid";
			 public const string Salesmanname = "salesmanname";
			 public const string Terms = "terms";
			 public const string Shipmethod = "shipmethod";
			 public const string Paymethod = "paymethod";
			 public const string Custrec = "custrec";
			 public const string CustNote = "cust_note";
			 public const string VendorNote = "vendor_note";
			 public const string RouteNote = "route_note";
			 public const string Status = "status";
			 public const string Shipaddress = "shipaddress";
			 public const string Billaddress = "billaddress";
			 public const string WTaxTotal = "WTaxTotal";
			 public const string WMerchTotal = "WMerchTotal";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string Routeid = "routeid";
			 public const string Routename = "routename";
			 public const string Phone = "phone";
			 public const string Templatetype = "templatetype";
			 public const string Templatetitle = "templatetitle";
			 public const string Templatefrequency = "templatefrequency";
			 public const string Templatelastdate = "templatelastdate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tid = "Tid";
			 public const string InvoiceId = "InvoiceId";
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Offline = "Offline";
			 public const string Customername = "Customername";
			 public const string Createdate = "Createdate";
			 public const string Lastupdate = "Lastupdate";
			 public const string Postdate = "Postdate";
			 public const string Duedate = "Duedate";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
			 public const string Lastupdateby = "Lastupdateby";
			 public const string Lastupdatebyname = "Lastupdatebyname";
			 public const string Salesmanid = "Salesmanid";
			 public const string Salesmanname = "Salesmanname";
			 public const string Terms = "Terms";
			 public const string Shipmethod = "Shipmethod";
			 public const string Paymethod = "Paymethod";
			 public const string Custrec = "Custrec";
			 public const string CustNote = "CustNote";
			 public const string VendorNote = "VendorNote";
			 public const string RouteNote = "RouteNote";
			 public const string Status = "Status";
			 public const string Shipaddress = "Shipaddress";
			 public const string Billaddress = "Billaddress";
			 public const string WTaxTotal = "WTaxTotal";
			 public const string WMerchTotal = "WMerchTotal";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string Routeid = "Routeid";
			 public const string Routename = "Routename";
			 public const string Phone = "Phone";
			 public const string Templatetype = "Templatetype";
			 public const string Templatetitle = "Templatetitle";
			 public const string Templatefrequency = "Templatefrequency";
			 public const string Templatelastdate = "Templatelastdate";
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
			lock (typeof(WtaTicketMetadata))
			{
				if(WtaTicketMetadata.mapDelegates == null)
				{
					WtaTicketMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaTicketMetadata.meta == null)
				{
					WtaTicketMetadata.meta = new WtaTicketMetadata();
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
				meta.AddTypeMap("InvoiceId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Offline", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Customername", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Postdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Duedate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdateby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdatebyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Salesmanid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Salesmanname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Terms", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Shipmethod", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Paymethod", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custrec", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CustNote", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("VendorNote", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RouteNote", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Shipaddress", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Billaddress", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("WTaxTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("WMerchTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("MerchTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("TaxTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("WeightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("FreightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Routeid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Routename", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Templatetype", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Templatetitle", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Templatefrequency", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Templatelastdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "wta_ticket";
				meta.Destination = "wta_ticket";
				
				meta.spInsert = "proc_wta_ticketInsert";				
				meta.spUpdate = "proc_wta_ticketUpdate";		
				meta.spDelete = "proc_wta_ticketDelete";
				meta.spLoadAll = "proc_wta_ticketLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_ticketLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaTicketMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
