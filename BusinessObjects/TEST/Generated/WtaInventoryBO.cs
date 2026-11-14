
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:17 PM
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
	/// Encapsulates the 'wta_inventory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaInventoryBO))]	
	[XmlType("WtaInventoryBO")]
	public partial class WtaInventoryBO : esWtaInventoryBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaInventoryBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaInventoryCollection")]
	public partial class WtaInventoryCollection : esWtaInventoryCollection, IEnumerable<WtaInventoryBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaInventoryQuery : esWtaInventoryQuery
	{
		public WtaInventoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaInventoryQuery(string joinAlias, out WtaInventoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaInventoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaInventoryQuery query)
		{
			return WtaInventoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaInventoryQuery(string query)
		{
			return (WtaInventoryQuery)WtaInventoryQuery.SerializeHelper.FromXml(query, typeof(WtaInventoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaInventoryBO : esEntity
	{
		public esWtaInventoryBO()
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
			WtaInventoryQuery query = new WtaInventoryQuery();
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
		/// Maps to wta_inventory.iid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Iid
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Iid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Iid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Iid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.iSourceID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ISourceID
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.ISourceID);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.ISourceID, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.ISourceID);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaInventoryMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaInventoryMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Qty);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaInventoryMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaInventoryMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.um
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Um
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Um);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Um, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Um);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Casecount, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaInventoryMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaInventoryMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.createdbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Createdbyname, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Createdbyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.poid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Poid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Poid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Poid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.polid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Polid
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Polid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Polid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Polid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.ponum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Ponum
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Ponum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Ponum, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Ponum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.wprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wprice
		{
			get
			{
				return base.GetSystemDouble(WtaInventoryMetadata.ColumnNames.Wprice);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaInventoryMetadata.ColumnNames.Wprice, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Wprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.assigneddate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Assigneddate
		{
			get
			{
				return base.GetSystemDateTime(WtaInventoryMetadata.ColumnNames.Assigneddate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaInventoryMetadata.ColumnNames.Assigneddate, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Assigneddate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.assignedby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Assignedby
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Assignedby);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Assignedby, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Assignedby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.assignedbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Assignedbyname
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Assignedbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Assignedbyname, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Assignedbyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaInventoryMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaInventoryMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.lastupdateby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdateby
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Lastupdateby);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Lastupdateby, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Lastupdateby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.lastupdatebyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdatebyname
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Lastupdatebyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Lastupdatebyname, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Lastupdatebyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.tid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tid
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Tid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Tid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Tid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.tlid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tlid
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Tlid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Tlid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Tlid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.invoice_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? InvoiceId
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.InvoiceId);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.InvoiceId, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.InvoiceId);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.customer
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customer
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Customer);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Customer, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Customer);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.customerid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerid
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Customerid);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Customerid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Customerid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.vendorcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Vendorcode, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Vendorcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.vendordescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Vendordescription, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Vendordescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.vendormid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Vendormid, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Vendormid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.vendorname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Vendorname, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Vendorname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.note
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Note
		{
			get
			{
				return base.GetSystemString(WtaInventoryMetadata.ColumnNames.Note);
			}
			
			set
			{
				if(base.SetSystemString(WtaInventoryMetadata.ColumnNames.Note, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Note);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.breakable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Breakable
		{
			get
			{
				return base.GetSystemInt16(WtaInventoryMetadata.ColumnNames.Breakable);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaInventoryMetadata.ColumnNames.Breakable, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Breakable);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.jwitem
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Jwitem
		{
			get
			{
				return base.GetSystemChar(WtaInventoryMetadata.ColumnNames.Jwitem);
			}
			
			set
			{
				if(base.SetSystemChar(WtaInventoryMetadata.ColumnNames.Jwitem, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Jwitem);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.um_style
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.UmStyle, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.UmStyle);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.productweight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Productweight
		{
			get
			{
				return base.GetSystemDouble(WtaInventoryMetadata.ColumnNames.Productweight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaInventoryMetadata.ColumnNames.Productweight, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Productweight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.wasbroken
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Wasbroken
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.Wasbroken);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.Wasbroken, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.Wasbroken);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_inventory.brokenIID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? BrokenIID
		{
			get
			{
				return base.GetSystemInt32(WtaInventoryMetadata.ColumnNames.BrokenIID);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaInventoryMetadata.ColumnNames.BrokenIID, value))
				{
					OnPropertyChanged(WtaInventoryMetadata.PropertyNames.BrokenIID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaInventoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaInventoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaInventoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaInventoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaInventoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaInventoryQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaInventoryQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaInventoryCollection : esEntityCollection<WtaInventoryBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaInventoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaInventoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaInventoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaInventoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaInventoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaInventoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaInventoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaInventoryQuery)query);
		}

		#endregion
		
		private WtaInventoryQuery query;
	}



	[Serializable]
	abstract public partial class esWtaInventoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaInventoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Iid": return this.Iid;
				case "ISourceID": return this.ISourceID;
				case "Mid": return this.Mid;
				case "Qty": return this.Qty;
				case "Weight": return this.Weight;
				case "Um": return this.Um;
				case "Casecount": return this.Casecount;
				case "Createdate": return this.Createdate;
				case "Createdby": return this.Createdby;
				case "Createdbyname": return this.Createdbyname;
				case "Poid": return this.Poid;
				case "Polid": return this.Polid;
				case "Ponum": return this.Ponum;
				case "Status": return this.Status;
				case "Wprice": return this.Wprice;
				case "Assigneddate": return this.Assigneddate;
				case "Assignedby": return this.Assignedby;
				case "Assignedbyname": return this.Assignedbyname;
				case "Lastupdate": return this.Lastupdate;
				case "Lastupdateby": return this.Lastupdateby;
				case "Lastupdatebyname": return this.Lastupdatebyname;
				case "Tid": return this.Tid;
				case "Tlid": return this.Tlid;
				case "InvoiceId": return this.InvoiceId;
				case "Customer": return this.Customer;
				case "Customerid": return this.Customerid;
				case "Productcode": return this.Productcode;
				case "Description": return this.Description;
				case "Vendorcode": return this.Vendorcode;
				case "Vendordescription": return this.Vendordescription;
				case "Vendormid": return this.Vendormid;
				case "Vendorname": return this.Vendorname;
				case "Note": return this.Note;
				case "Breakable": return this.Breakable;
				case "Jwitem": return this.Jwitem;
				case "UmStyle": return this.UmStyle;
				case "Productweight": return this.Productweight;
				case "Wasbroken": return this.Wasbroken;
				case "BrokenIID": return this.BrokenIID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Iid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Iid, esSystemType.Int32); }
		} 
		
		public esQueryItem ISourceID
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.ISourceID, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Um
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Um, esSystemType.String); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Createdbyname
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Createdbyname, esSystemType.String); }
		} 
		
		public esQueryItem Poid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Poid, esSystemType.Int32); }
		} 
		
		public esQueryItem Polid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Polid, esSystemType.Int32); }
		} 
		
		public esQueryItem Ponum
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Ponum, esSystemType.Int32); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem Wprice
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Wprice, esSystemType.Double); }
		} 
		
		public esQueryItem Assigneddate
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Assigneddate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Assignedby
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Assignedby, esSystemType.String); }
		} 
		
		public esQueryItem Assignedbyname
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Assignedbyname, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdateby
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Lastupdateby, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdatebyname
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Lastupdatebyname, esSystemType.String); }
		} 
		
		public esQueryItem Tid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Tid, esSystemType.Int32); }
		} 
		
		public esQueryItem Tlid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Tlid, esSystemType.Int32); }
		} 
		
		public esQueryItem InvoiceId
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.InvoiceId, esSystemType.Int32); }
		} 
		
		public esQueryItem Customer
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Customer, esSystemType.String); }
		} 
		
		public esQueryItem Customerid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Customerid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcode
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Vendorcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendordescription
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Vendordescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendormid
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Vendormid, esSystemType.String); }
		} 
		
		public esQueryItem Vendorname
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Vendorname, esSystemType.String); }
		} 
		
		public esQueryItem Note
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Note, esSystemType.String); }
		} 
		
		public esQueryItem Breakable
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Breakable, esSystemType.Int16); }
		} 
		
		public esQueryItem Jwitem
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Jwitem, esSystemType.Char); }
		} 
		
		public esQueryItem UmStyle
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.UmStyle, esSystemType.Int32); }
		} 
		
		public esQueryItem Productweight
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Productweight, esSystemType.Double); }
		} 
		
		public esQueryItem Wasbroken
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.Wasbroken, esSystemType.Int32); }
		} 
		
		public esQueryItem BrokenIID
		{
			get { return new esQueryItem(this, WtaInventoryMetadata.ColumnNames.BrokenIID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaInventoryBO : esWtaInventoryBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaInventoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaInventoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Iid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Iid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.ISourceID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.ISourceID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Mid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Qty, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Weight, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Um, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Um;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Casecount, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Createdate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Createdby, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Createdbyname, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Poid, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Poid;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Polid, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Polid;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Ponum, 12, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Ponum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Status, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Wprice, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Wprice;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Assigneddate, 15, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Assigneddate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Assignedby, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Assignedby;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Assignedbyname, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Assignedbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Lastupdate, 18, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Lastupdateby, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Lastupdateby;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Lastupdatebyname, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Lastupdatebyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Tid, 21, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Tid;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Tlid, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Tlid;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.InvoiceId, 23, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.InvoiceId;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Customer, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Customer;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Customerid, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Customerid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Productcode, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Description, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Vendorcode, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Vendordescription, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Vendormid, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Vendorname, 31, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Note, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Note;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Breakable, 33, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Breakable;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Jwitem, 34, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Jwitem;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.UmStyle, 35, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Productweight, 36, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Productweight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.Wasbroken, 37, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.Wasbroken;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaInventoryMetadata.ColumnNames.BrokenIID, 38, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaInventoryMetadata.PropertyNames.BrokenIID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaInventoryMetadata Meta()
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
			 public const string Iid = "iid";
			 public const string ISourceID = "iSourceID";
			 public const string Mid = "mid";
			 public const string Qty = "qty";
			 public const string Weight = "weight";
			 public const string Um = "um";
			 public const string Casecount = "casecount";
			 public const string Createdate = "createdate";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
			 public const string Poid = "poid";
			 public const string Polid = "polid";
			 public const string Ponum = "ponum";
			 public const string Status = "status";
			 public const string Wprice = "wprice";
			 public const string Assigneddate = "assigneddate";
			 public const string Assignedby = "assignedby";
			 public const string Assignedbyname = "assignedbyname";
			 public const string Lastupdate = "lastupdate";
			 public const string Lastupdateby = "lastupdateby";
			 public const string Lastupdatebyname = "lastupdatebyname";
			 public const string Tid = "tid";
			 public const string Tlid = "tlid";
			 public const string InvoiceId = "invoice_id";
			 public const string Customer = "customer";
			 public const string Customerid = "customerid";
			 public const string Productcode = "productcode";
			 public const string Description = "description";
			 public const string Vendorcode = "vendorcode";
			 public const string Vendordescription = "vendordescription";
			 public const string Vendormid = "vendormid";
			 public const string Vendorname = "vendorname";
			 public const string Note = "note";
			 public const string Breakable = "breakable";
			 public const string Jwitem = "jwitem";
			 public const string UmStyle = "um_style";
			 public const string Productweight = "productweight";
			 public const string Wasbroken = "wasbroken";
			 public const string BrokenIID = "brokenIID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Iid = "Iid";
			 public const string ISourceID = "ISourceID";
			 public const string Mid = "Mid";
			 public const string Qty = "Qty";
			 public const string Weight = "Weight";
			 public const string Um = "Um";
			 public const string Casecount = "Casecount";
			 public const string Createdate = "Createdate";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
			 public const string Poid = "Poid";
			 public const string Polid = "Polid";
			 public const string Ponum = "Ponum";
			 public const string Status = "Status";
			 public const string Wprice = "Wprice";
			 public const string Assigneddate = "Assigneddate";
			 public const string Assignedby = "Assignedby";
			 public const string Assignedbyname = "Assignedbyname";
			 public const string Lastupdate = "Lastupdate";
			 public const string Lastupdateby = "Lastupdateby";
			 public const string Lastupdatebyname = "Lastupdatebyname";
			 public const string Tid = "Tid";
			 public const string Tlid = "Tlid";
			 public const string InvoiceId = "InvoiceId";
			 public const string Customer = "Customer";
			 public const string Customerid = "Customerid";
			 public const string Productcode = "Productcode";
			 public const string Description = "Description";
			 public const string Vendorcode = "Vendorcode";
			 public const string Vendordescription = "Vendordescription";
			 public const string Vendormid = "Vendormid";
			 public const string Vendorname = "Vendorname";
			 public const string Note = "Note";
			 public const string Breakable = "Breakable";
			 public const string Jwitem = "Jwitem";
			 public const string UmStyle = "UmStyle";
			 public const string Productweight = "Productweight";
			 public const string Wasbroken = "Wasbroken";
			 public const string BrokenIID = "BrokenIID";
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
			lock (typeof(WtaInventoryMetadata))
			{
				if(WtaInventoryMetadata.mapDelegates == null)
				{
					WtaInventoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaInventoryMetadata.meta == null)
				{
					WtaInventoryMetadata.meta = new WtaInventoryMetadata();
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


				meta.AddTypeMap("Iid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ISourceID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Um", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Polid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Ponum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Wprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Assigneddate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Assignedby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Assignedbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdateby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdatebyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Tid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Tlid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("InvoiceId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Customer", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Customerid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendordescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendormid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Note", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Breakable", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Jwitem", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("UmStyle", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productweight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wasbroken", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("BrokenIID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "wta_inventory";
				meta.Destination = "wta_inventory";
				
				meta.spInsert = "proc_wta_inventoryInsert";				
				meta.spUpdate = "proc_wta_inventoryUpdate";		
				meta.spDelete = "proc_wta_inventoryDelete";
				meta.spLoadAll = "proc_wta_inventoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_inventoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaInventoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
