
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
	/// Encapsulates the 'wta_po' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaPoBO))]	
	[XmlType("WtaPoBO")]
	public partial class WtaPoBO : esWtaPoBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaPoBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 poid)
		{
			var obj = new WtaPoBO();
			obj.Poid = poid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 poid, esSqlAccessType sqlAccessType)
		{
			var obj = new WtaPoBO();
			obj.Poid = poid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaPoCollection")]
	public partial class WtaPoCollection : esWtaPoCollection, IEnumerable<WtaPoBO>
	{
		public WtaPoBO FindByPrimaryKey(System.Int32 poid)
		{
			return this.SingleOrDefault(e => e.Poid == poid);
		}

		
				
	}



	[Serializable]	
	public partial class WtaPoQuery : esWtaPoQuery
	{
		public WtaPoQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaPoQuery(string joinAlias, out WtaPoQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaPoQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaPoQuery query)
		{
			return WtaPoQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaPoQuery(string query)
		{
			return (WtaPoQuery)WtaPoQuery.SerializeHelper.FromXml(query, typeof(WtaPoQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaPoBO : esEntity
	{
		public esWtaPoBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 poid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(poid);
			else
				return LoadByPrimaryKeyStoredProcedure(poid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 poid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(poid);
			else
				return LoadByPrimaryKeyStoredProcedure(poid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 poid)
		{
			WtaPoQuery query = new WtaPoQuery();
			query.Where(query.Poid == poid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 poid)
		{
			esParameters parms = new esParameters();
			parms.Add("Poid", poid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_po.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Mid, value))
				{
					this._UsersBO = null;
					this.OnPropertyChanged("UsersBO");
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendormid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Vendormid, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Vendormid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendorname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Vendorname, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Vendorname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendoraddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendoraddress
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendoraddress);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Vendoraddress, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Vendoraddress);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Createdbyname, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Createdbyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdateby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdateby
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Lastupdateby);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Lastupdateby, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Lastupdateby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdatebyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdatebyname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Lastupdatebyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Lastupdatebyname, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Lastupdatebyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.postdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Postdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Postdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Postdate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Postdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.pocomment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pocomment
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Pocomment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Pocomment, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Pocomment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.shipdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Shipdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Shipdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Shipdate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Shipdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRCustid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FDRCustid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRCustid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.FDRCustid, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FDRCustid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRInvoice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FDRInvoice
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRInvoice);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.FDRInvoice, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FDRInvoice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRSalesMan
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FDRSalesMan
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRSalesMan);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.FDRSalesMan, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FDRSalesMan);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRLugger
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FDRLugger
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRLugger);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.FDRLugger, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FDRLugger);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.MerchTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? MerchTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.MerchTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoMetadata.ColumnNames.MerchTotal, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.MerchTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.TaxTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? TaxTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.TaxTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoMetadata.ColumnNames.TaxTotal, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.TaxTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.WeightTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? WeightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.WeightTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoMetadata.ColumnNames.WeightTotal, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.WeightTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FreightTotal
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? FreightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.FreightTotal);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoMetadata.ColumnNames.FreightTotal, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FreightTotal);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRChecker
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FDRChecker
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRChecker);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.FDRChecker, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.FDRChecker);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.returndate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Returndate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Returndate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Returndate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Returndate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.source
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Source
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Source);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Source, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Source);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentstatus
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Sentstatus
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Sentstatus);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Sentstatus, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Sentstatus);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Sentdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Sentdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Sentdate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Sentdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentmessage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sentmessage
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Sentmessage);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Sentmessage, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Sentmessage);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentmethod
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Sentmethod
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Sentmethod);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Sentmethod, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Sentmethod);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.routeid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Routeid
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Routeid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Routeid, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Routeid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.routename
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Routename
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Routename);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Routename, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Routename);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.poid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Poid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoMetadata.ColumnNames.Poid, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Poid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.statusUCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StatusUCode
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.StatusUCode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.StatusUCode, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.StatusUCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.requested_delivery_time
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? RequestedDeliveryTime
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.RequestedDeliveryTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoMetadata.ColumnNames.RequestedDeliveryTime, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.RequestedDeliveryTime);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.ponum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Ponum
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Ponum);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Ponum, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.Ponum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.LogisticsModel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? LogisticsModel
		{
			get
			{
				return base.GetSystemChar(WtaPoMetadata.ColumnNames.LogisticsModel);
			}
			
			set
			{
				if(base.SetSystemChar(WtaPoMetadata.ColumnNames.LogisticsModel, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.LogisticsModel);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.NameComment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String NameComment
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.NameComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.NameComment, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.NameComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.TotalRebate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? TotalRebate
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.TotalRebate);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoMetadata.ColumnNames.TotalRebate, value))
				{
					OnPropertyChanged(WtaPoMetadata.PropertyNames.TotalRebate);
				}
			}
		}
		
		internal protected UsersBO _UsersBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaPoMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaPoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaPoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaPoQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaPoCollection : esEntityCollection<WtaPoBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaPoCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaPoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaPoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoQuery)query);
		}

		#endregion
		
		private WtaPoQuery query;
	}



	[Serializable]
	abstract public partial class esWtaPoQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Status": return this.Status;
				case "Vendormid": return this.Vendormid;
				case "Vendorname": return this.Vendorname;
				case "Vendoraddress": return this.Vendoraddress;
				case "Createdby": return this.Createdby;
				case "Createdbyname": return this.Createdbyname;
				case "Lastupdateby": return this.Lastupdateby;
				case "Lastupdatebyname": return this.Lastupdatebyname;
				case "Createdate": return this.Createdate;
				case "Lastupdate": return this.Lastupdate;
				case "Postdate": return this.Postdate;
				case "Pocomment": return this.Pocomment;
				case "Shipdate": return this.Shipdate;
				case "FDRCustid": return this.FDRCustid;
				case "FDRInvoice": return this.FDRInvoice;
				case "FDRSalesMan": return this.FDRSalesMan;
				case "FDRLugger": return this.FDRLugger;
				case "MerchTotal": return this.MerchTotal;
				case "TaxTotal": return this.TaxTotal;
				case "WeightTotal": return this.WeightTotal;
				case "FreightTotal": return this.FreightTotal;
				case "FDRChecker": return this.FDRChecker;
				case "Returndate": return this.Returndate;
				case "Source": return this.Source;
				case "Sentstatus": return this.Sentstatus;
				case "Sentdate": return this.Sentdate;
				case "Sentmessage": return this.Sentmessage;
				case "Sentmethod": return this.Sentmethod;
				case "Routeid": return this.Routeid;
				case "Routename": return this.Routename;
				case "Poid": return this.Poid;
				case "StatusUCode": return this.StatusUCode;
				case "RequestedDeliveryTime": return this.RequestedDeliveryTime;
				case "Ponum": return this.Ponum;
				case "LogisticsModel": return this.LogisticsModel;
				case "NameComment": return this.NameComment;
				case "TotalRebate": return this.TotalRebate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem Vendormid
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendormid, esSystemType.String); }
		} 
		
		public esQueryItem Vendorname
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendorname, esSystemType.String); }
		} 
		
		public esQueryItem Vendoraddress
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendoraddress, esSystemType.String); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Createdbyname
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdbyname, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdateby
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdateby, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdatebyname
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdatebyname, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Postdate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Postdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Pocomment
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Pocomment, esSystemType.String); }
		} 
		
		public esQueryItem Shipdate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Shipdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem FDRCustid
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRCustid, esSystemType.String); }
		} 
		
		public esQueryItem FDRInvoice
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRInvoice, esSystemType.String); }
		} 
		
		public esQueryItem FDRSalesMan
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRSalesMan, esSystemType.String); }
		} 
		
		public esQueryItem FDRLugger
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRLugger, esSystemType.String); }
		} 
		
		public esQueryItem MerchTotal
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.MerchTotal, esSystemType.Double); }
		} 
		
		public esQueryItem TaxTotal
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.TaxTotal, esSystemType.Double); }
		} 
		
		public esQueryItem WeightTotal
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.WeightTotal, esSystemType.Double); }
		} 
		
		public esQueryItem FreightTotal
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FreightTotal, esSystemType.Double); }
		} 
		
		public esQueryItem FDRChecker
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRChecker, esSystemType.String); }
		} 
		
		public esQueryItem Returndate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Returndate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Source
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Source, esSystemType.Int32); }
		} 
		
		public esQueryItem Sentstatus
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentstatus, esSystemType.Int32); }
		} 
		
		public esQueryItem Sentdate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Sentmessage
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentmessage, esSystemType.String); }
		} 
		
		public esQueryItem Sentmethod
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentmethod, esSystemType.Int32); }
		} 
		
		public esQueryItem Routeid
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Routeid, esSystemType.Int32); }
		} 
		
		public esQueryItem Routename
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Routename, esSystemType.String); }
		} 
		
		public esQueryItem Poid
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Poid, esSystemType.Int32); }
		} 
		
		public esQueryItem StatusUCode
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.StatusUCode, esSystemType.String); }
		} 
		
		public esQueryItem RequestedDeliveryTime
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.RequestedDeliveryTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem Ponum
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.Ponum, esSystemType.String); }
		} 
		
		public esQueryItem LogisticsModel
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.LogisticsModel, esSystemType.Char); }
		} 
		
		public esQueryItem NameComment
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.NameComment, esSystemType.String); }
		} 
		
		public esQueryItem TotalRebate
		{
			get { return new esQueryItem(this, WtaPoMetadata.ColumnNames.TotalRebate, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaPoBO : esWtaPoBO
	{

		#region WtaPoLineBOCollection - Zero To Many (FK_wta_po_line_poid)
		
		static public esPrefetchMap Prefetch_WtaPoLineBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.WtaPoBO.WtaPoLineBOCollection_Delegate,
					PropertyName = "WtaPoLineBOCollection",
					MyColumnName = "poid",
					ParentColumnName = "poid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void WtaPoLineBOCollection_Delegate(esPrefetchParameters data)
		{
			WtaPoQuery parent = new WtaPoQuery(data.NextAlias());

			WtaPoLineQuery me = data.You != null ? data.You as WtaPoLineQuery : new WtaPoLineQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Poid == me.Poid);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_wta_po_line_poid
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeWtaPoLineBOCollection()
		{
		    if(this._WtaPoLineBOCollection != null && this._WtaPoLineBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="WtaPoLineBOCollection", EmitDefaultValue = false)]
		public WtaPoLineCollection WtaPoLineBOCollection
		{
			get
			{
				if(this._WtaPoLineBOCollection == null)
				{
					this._WtaPoLineBOCollection = new WtaPoLineCollection();
					this._WtaPoLineBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("WtaPoLineBOCollection", this._WtaPoLineBOCollection);
				
					if (this.Poid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._WtaPoLineBOCollection.Query.Where(this._WtaPoLineBOCollection.Query.Poid == this.Poid);
							this._WtaPoLineBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._WtaPoLineBOCollection.fks.Add(WtaPoLineMetadata.ColumnNames.Poid, this.Poid);
					}
				}

				return this._WtaPoLineBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._WtaPoLineBOCollection != null) 
				{ 
					this.RemovePostSave("WtaPoLineBOCollection"); 
					this._WtaPoLineBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private WtaPoLineCollection _WtaPoLineBOCollection;
		#endregion

		
		#region UsersBO - Many To One (FK_wta_po_mid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBO()
		{
		    return this._UsersBO != null ? true : false;
		}
		

		[DataMember(Name="UsersBO", EmitDefaultValue = false)]
					
		public UsersBO UsersBO
		{
			get
			{
                if (this._UsersBO == null)
                {
                    this._UsersBO = new UsersBO();
                    this._UsersBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("UsersBO", this._UsersBO);

					if(this._UsersBO == null && Mid != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._UsersBO.Query.Where(this._UsersBO.Query.Custid == this.Mid);
							this._UsersBO.Query.Load();
                        }
                    }
                }

				return this._UsersBO;
			}
			
			set
			{
				this.RemovePreSave("UsersBO");
				

				if(value == null)
				{
					this.Mid = null;
					this._UsersBO = null;
				}
				else
				{
					this.Mid = value.Custid;
					this._UsersBO = value;
					this.SetPreSave("UsersBO", this._UsersBO);
				}
				
			}
		}
		#endregion
		

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "WtaPoLineBOCollection":
					coll = this.WtaPoLineBOCollection;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "WtaPoLineBOCollection", typeof(WtaPoLineCollection), new WtaPoLineBO()));
		
			return props;
		}
		
		/// <summary>
		/// Called by ApplyPostSaveKeys 
		/// </summary>
		/// <param name="coll">The collection to enumerate over</param>
		/// <param name="key">"The column name</param>
		/// <param name="value">The column value</param>
		private void Apply(esEntityCollectionBase coll, string key, object value)
		{
			foreach (esEntity obj in coll)
			{
				if (obj.es.IsAdded)
				{
					obj.SetProperty(key, value);
				}
			}
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
			if(this._WtaPoLineBOCollection != null)
			{
				Apply(this._WtaPoLineBOCollection, "Poid", this.Poid);
			}
		}
		
	}
	



	[Serializable]
	public partial class WtaPoMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaPoMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Status, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendormid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendorname, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendoraddress, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendoraddress;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdbyname, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdateby, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdateby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdatebyname, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdatebyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdate, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdate, 10, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Postdate, 11, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Postdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Pocomment, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Pocomment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Shipdate, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Shipdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRCustid, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRCustid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRInvoice, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRInvoice;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRSalesMan, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRSalesMan;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRLugger, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRLugger;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.MerchTotal, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.MerchTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.TaxTotal, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.TaxTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.WeightTotal, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.WeightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FreightTotal, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.FreightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRChecker, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRChecker;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Returndate, 23, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Returndate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Source, 24, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentstatus, 25, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentstatus;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentdate, 26, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentmessage, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentmessage;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentmethod, 28, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentmethod;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Routeid, 29, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Routeid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Routename, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Routename;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Poid, 31, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Poid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.StatusUCode, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.StatusUCode;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.RequestedDeliveryTime, 33, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.RequestedDeliveryTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Ponum, 34, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Ponum;
			c.CharacterMaxLength = 200;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.LogisticsModel, 35, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaPoMetadata.PropertyNames.LogisticsModel;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('D')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.NameComment, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.NameComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.TotalRebate, 37, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.TotalRebate;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaPoMetadata Meta()
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
			 public const string Mid = "mid";
			 public const string Status = "status";
			 public const string Vendormid = "vendormid";
			 public const string Vendorname = "vendorname";
			 public const string Vendoraddress = "vendoraddress";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
			 public const string Lastupdateby = "lastupdateby";
			 public const string Lastupdatebyname = "lastupdatebyname";
			 public const string Createdate = "createdate";
			 public const string Lastupdate = "lastupdate";
			 public const string Postdate = "postdate";
			 public const string Pocomment = "pocomment";
			 public const string Shipdate = "shipdate";
			 public const string FDRCustid = "FDRCustid";
			 public const string FDRInvoice = "FDRInvoice";
			 public const string FDRSalesMan = "FDRSalesMan";
			 public const string FDRLugger = "FDRLugger";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string FDRChecker = "FDRChecker";
			 public const string Returndate = "returndate";
			 public const string Source = "source";
			 public const string Sentstatus = "sentstatus";
			 public const string Sentdate = "sentdate";
			 public const string Sentmessage = "sentmessage";
			 public const string Sentmethod = "sentmethod";
			 public const string Routeid = "routeid";
			 public const string Routename = "routename";
			 public const string Poid = "poid";
			 public const string StatusUCode = "statusUCode";
			 public const string RequestedDeliveryTime = "requested_delivery_time";
			 public const string Ponum = "ponum";
			 public const string LogisticsModel = "LogisticsModel";
			 public const string NameComment = "NameComment";
			 public const string TotalRebate = "TotalRebate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Status = "Status";
			 public const string Vendormid = "Vendormid";
			 public const string Vendorname = "Vendorname";
			 public const string Vendoraddress = "Vendoraddress";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
			 public const string Lastupdateby = "Lastupdateby";
			 public const string Lastupdatebyname = "Lastupdatebyname";
			 public const string Createdate = "Createdate";
			 public const string Lastupdate = "Lastupdate";
			 public const string Postdate = "Postdate";
			 public const string Pocomment = "Pocomment";
			 public const string Shipdate = "Shipdate";
			 public const string FDRCustid = "FDRCustid";
			 public const string FDRInvoice = "FDRInvoice";
			 public const string FDRSalesMan = "FDRSalesMan";
			 public const string FDRLugger = "FDRLugger";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string FDRChecker = "FDRChecker";
			 public const string Returndate = "Returndate";
			 public const string Source = "Source";
			 public const string Sentstatus = "Sentstatus";
			 public const string Sentdate = "Sentdate";
			 public const string Sentmessage = "Sentmessage";
			 public const string Sentmethod = "Sentmethod";
			 public const string Routeid = "Routeid";
			 public const string Routename = "Routename";
			 public const string Poid = "Poid";
			 public const string StatusUCode = "StatusUCode";
			 public const string RequestedDeliveryTime = "RequestedDeliveryTime";
			 public const string Ponum = "Ponum";
			 public const string LogisticsModel = "LogisticsModel";
			 public const string NameComment = "NameComment";
			 public const string TotalRebate = "TotalRebate";
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
			lock (typeof(WtaPoMetadata))
			{
				if(WtaPoMetadata.mapDelegates == null)
				{
					WtaPoMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaPoMetadata.meta == null)
				{
					WtaPoMetadata.meta = new WtaPoMetadata();
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


				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Vendormid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraddress", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdateby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdatebyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Postdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Pocomment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Shipdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("FDRCustid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRInvoice", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRSalesMan", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRLugger", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("MerchTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("TaxTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("WeightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("FreightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("FDRChecker", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Returndate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Source", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Sentstatus", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Sentdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Sentmessage", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sentmethod", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Routeid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Routename", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("StatusUCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("RequestedDeliveryTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Ponum", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LogisticsModel", new esTypeMap("varchar", "System.Char"));
				meta.AddTypeMap("NameComment", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TotalRebate", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "wta_po";
				meta.Destination = "wta_po";
				
				meta.spInsert = "proc_wta_poInsert";				
				meta.spUpdate = "proc_wta_poUpdate";		
				meta.spDelete = "proc_wta_poDelete";
				meta.spLoadAll = "proc_wta_poLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_poLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaPoMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
