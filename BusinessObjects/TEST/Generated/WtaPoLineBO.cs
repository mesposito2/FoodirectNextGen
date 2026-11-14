
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
	/// Encapsulates the 'wta_po_line' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaPoLineBO))]	
	[XmlType("WtaPoLineBO")]
	public partial class WtaPoLineBO : esWtaPoLineBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaPoLineBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 polid)
		{
			var obj = new WtaPoLineBO();
			obj.Polid = polid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 polid, esSqlAccessType sqlAccessType)
		{
			var obj = new WtaPoLineBO();
			obj.Polid = polid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaPoLineCollection")]
	public partial class WtaPoLineCollection : esWtaPoLineCollection, IEnumerable<WtaPoLineBO>
	{
		public WtaPoLineBO FindByPrimaryKey(System.Int32 polid)
		{
			return this.SingleOrDefault(e => e.Polid == polid);
		}

		
				
	}



	[Serializable]	
	public partial class WtaPoLineQuery : esWtaPoLineQuery
	{
		public WtaPoLineQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaPoLineQuery(string joinAlias, out WtaPoLineQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaPoLineQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaPoLineQuery query)
		{
			return WtaPoLineQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaPoLineQuery(string query)
		{
			return (WtaPoLineQuery)WtaPoLineQuery.SerializeHelper.FromXml(query, typeof(WtaPoLineQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaPoLineBO : esEntity
	{
		public esWtaPoLineBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 polid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(polid);
			else
				return LoadByPrimaryKeyStoredProcedure(polid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 polid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(polid);
			else
				return LoadByPrimaryKeyStoredProcedure(polid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 polid)
		{
			WtaPoLineQuery query = new WtaPoLineQuery();
			query.Where(query.Polid == polid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 polid)
		{
			esParameters parms = new esParameters();
			parms.Add("Polid", polid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_po_line.poid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Poid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Poid, value))
				{
					this._WtaPoBO = null;
					this.OnPropertyChanged("WtaPoBO");
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Poid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.line_num
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? LineNum
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.LineNum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.LineNum, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.LineNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productdescription, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Productdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productaltcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productaltcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productaltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productaltcode, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Productaltcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productaltdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productaltdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productaltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productaltdescription, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Productaltdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendorcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendorcode, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Vendorcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendordescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendordescription, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Vendordescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendoraltcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendoraltcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltcode, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Vendoraltcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendoraltdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendoraltdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltdescription, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Vendoraltdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.um
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Um
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Um);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Um, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Um);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Qty);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.wprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wprice
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Wprice);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Wprice, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Wprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Casecount, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.truck_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TruckComment
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.TruckComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.TruckComment, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.TruckComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendor_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VendorComment
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.VendorComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.VendorComment, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.VendorComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.state
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? State
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.State, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.State);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.multiple_weights
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? MultipleWeights
		{
			get
			{
				return base.GetSystemInt16(WtaPoLineMetadata.ColumnNames.MultipleWeights);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaPoLineMetadata.ColumnNames.MultipleWeights, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.MultipleWeights);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.amount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Amount
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Amount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Amount, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Amount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.taxamount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Taxamount
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Taxamount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Taxamount, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Taxamount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoLineMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoLineMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.jwitem
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Jwitem
		{
			get
			{
				return base.GetSystemChar(WtaPoLineMetadata.ColumnNames.Jwitem);
			}
			
			set
			{
				if(base.SetSystemChar(WtaPoLineMetadata.ColumnNames.Jwitem, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Jwitem);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.xtype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Xtype
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Xtype);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Xtype, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Xtype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Taxable
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.um_style
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.UmStyle, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.UmStyle);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productweight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Productweight
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Productweight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Productweight, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Productweight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.mw_buffer
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String MwBuffer
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.MwBuffer);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.MwBuffer, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.MwBuffer);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.SourceTicketInfo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SourceTicketInfo
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.SourceTicketInfo);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.SourceTicketInfo, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.SourceTicketInfo);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.polid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Polid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Polid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Polid, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Polid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Scatid, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.LineTypeUCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LineTypeUCode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.LineTypeUCode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.LineTypeUCode, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.LineTypeUCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.weight_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? WeightType
		{
			get
			{
				return base.GetSystemChar(WtaPoLineMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemChar(WtaPoLineMetadata.ColumnNames.WeightType, value))
				{
					OnPropertyChanged(WtaPoLineMetadata.PropertyNames.WeightType);
				}
			}
		}
		
		internal protected WtaPoBO _WtaPoBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaPoLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoLineQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaPoLineQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoLineQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaPoLineQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaPoLineCollection : esEntityCollection<WtaPoLineBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaPoLineCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaPoLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoLineQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoLineQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaPoLineQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoLineQuery)query);
		}

		#endregion
		
		private WtaPoLineQuery query;
	}



	[Serializable]
	abstract public partial class esWtaPoLineQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Poid": return this.Poid;
				case "LineNum": return this.LineNum;
				case "Productcode": return this.Productcode;
				case "Productdescription": return this.Productdescription;
				case "Productaltcode": return this.Productaltcode;
				case "Productaltdescription": return this.Productaltdescription;
				case "Vendorcode": return this.Vendorcode;
				case "Vendordescription": return this.Vendordescription;
				case "Vendoraltcode": return this.Vendoraltcode;
				case "Vendoraltdescription": return this.Vendoraltdescription;
				case "Um": return this.Um;
				case "Qty": return this.Qty;
				case "Wprice": return this.Wprice;
				case "Weight": return this.Weight;
				case "Casecount": return this.Casecount;
				case "TruckComment": return this.TruckComment;
				case "VendorComment": return this.VendorComment;
				case "Status": return this.Status;
				case "State": return this.State;
				case "MultipleWeights": return this.MultipleWeights;
				case "Amount": return this.Amount;
				case "Taxamount": return this.Taxamount;
				case "CreateDate": return this.CreateDate;
				case "Jwitem": return this.Jwitem;
				case "Xtype": return this.Xtype;
				case "Taxable": return this.Taxable;
				case "UmStyle": return this.UmStyle;
				case "Productweight": return this.Productweight;
				case "MwBuffer": return this.MwBuffer;
				case "SourceTicketInfo": return this.SourceTicketInfo;
				case "Polid": return this.Polid;
				case "Catid": return this.Catid;
				case "Scatid": return this.Scatid;
				case "LineTypeUCode": return this.LineTypeUCode;
				case "WeightType": return this.WeightType;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Poid
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Poid, esSystemType.Int32); }
		} 
		
		public esQueryItem LineNum
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.LineNum, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Productdescription
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productdescription, esSystemType.String); }
		} 
		
		public esQueryItem Productaltcode
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productaltcode, esSystemType.String); }
		} 
		
		public esQueryItem Productaltdescription
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productaltdescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcode
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendorcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendordescription
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendordescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendoraltcode
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendoraltcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendoraltdescription
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendoraltdescription, esSystemType.String); }
		} 
		
		public esQueryItem Um
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Um, esSystemType.String); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		public esQueryItem Wprice
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Wprice, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem TruckComment
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.TruckComment, esSystemType.String); }
		} 
		
		public esQueryItem VendorComment
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.VendorComment, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem State
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.State, esSystemType.Int32); }
		} 
		
		public esQueryItem MultipleWeights
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.MultipleWeights, esSystemType.Int16); }
		} 
		
		public esQueryItem Amount
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Amount, esSystemType.Double); }
		} 
		
		public esQueryItem Taxamount
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Taxamount, esSystemType.Double); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Jwitem
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Jwitem, esSystemType.Char); }
		} 
		
		public esQueryItem Xtype
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Xtype, esSystemType.String); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Taxable, esSystemType.Int32); }
		} 
		
		public esQueryItem UmStyle
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.UmStyle, esSystemType.Int32); }
		} 
		
		public esQueryItem Productweight
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productweight, esSystemType.Double); }
		} 
		
		public esQueryItem MwBuffer
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.MwBuffer, esSystemType.String); }
		} 
		
		public esQueryItem SourceTicketInfo
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.SourceTicketInfo, esSystemType.String); }
		} 
		
		public esQueryItem Polid
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Polid, esSystemType.Int32); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem LineTypeUCode
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.LineTypeUCode, esSystemType.String); }
		} 
		
		public esQueryItem WeightType
		{
			get { return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.WeightType, esSystemType.Char); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaPoLineBO : esWtaPoLineBO
	{

		
		#region WtaPoBO - Many To One (FK_wta_po_line_poid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeWtaPoBO()
		{
		    return this._WtaPoBO != null ? true : false;
		}
		

		[DataMember(Name="WtaPoBO", EmitDefaultValue = false)]
					
		public WtaPoBO WtaPoBO
		{
			get
			{
                if (this._WtaPoBO == null)
                {
                    this._WtaPoBO = new WtaPoBO();
                    this._WtaPoBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("WtaPoBO", this._WtaPoBO);

					if(this._WtaPoBO == null && Poid != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._WtaPoBO.Query.Where(this._WtaPoBO.Query.Poid == this.Poid);
							this._WtaPoBO.Query.Load();
                        }
                    }
                }

				return this._WtaPoBO;
			}
			
			set
			{
				this.RemovePreSave("WtaPoBO");
				

				if(value == null)
				{
					this.Poid = null;
					this._WtaPoBO = null;
				}
				else
				{
					this.Poid = value.Poid;
					this._WtaPoBO = value;
					this.SetPreSave("WtaPoBO", this._WtaPoBO);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._WtaPoBO != null)
			{
				this.Poid = this._WtaPoBO.Poid;
			}
		}
		
	}
	



	[Serializable]
	public partial class WtaPoLineMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaPoLineMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Poid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Poid;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.LineNum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.LineNum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productdescription, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productaltcode, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productaltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productaltdescription, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productaltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendorcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendordescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendoraltcode, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendoraltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendoraltdescription, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendoraltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Um, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Um;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Qty, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Wprice, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Wprice;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Weight, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Casecount, 14, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.TruckComment, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.TruckComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.VendorComment, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.VendorComment;
			c.CharacterMaxLength = 38;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Status, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.State, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.State;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.MultipleWeights, 19, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.MultipleWeights;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Amount, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Amount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Taxamount, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Taxamount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.CreateDate, 22, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Jwitem, 23, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Jwitem;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Xtype, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Xtype;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Taxable, 25, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Taxable;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.UmStyle, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productweight, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productweight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.MwBuffer, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.MwBuffer;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.SourceTicketInfo, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.SourceTicketInfo;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Polid, 30, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Polid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Catid, 31, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Scatid, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.LineTypeUCode, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.LineTypeUCode;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.WeightType, 34, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaPoLineMetadata Meta()
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
			 public const string Poid = "poid";
			 public const string LineNum = "line_num";
			 public const string Productcode = "productcode";
			 public const string Productdescription = "productdescription";
			 public const string Productaltcode = "productaltcode";
			 public const string Productaltdescription = "productaltdescription";
			 public const string Vendorcode = "vendorcode";
			 public const string Vendordescription = "vendordescription";
			 public const string Vendoraltcode = "vendoraltcode";
			 public const string Vendoraltdescription = "vendoraltdescription";
			 public const string Um = "um";
			 public const string Qty = "qty";
			 public const string Wprice = "wprice";
			 public const string Weight = "weight";
			 public const string Casecount = "casecount";
			 public const string TruckComment = "truck_comment";
			 public const string VendorComment = "vendor_comment";
			 public const string Status = "status";
			 public const string State = "state";
			 public const string MultipleWeights = "multiple_weights";
			 public const string Amount = "amount";
			 public const string Taxamount = "taxamount";
			 public const string CreateDate = "CreateDate";
			 public const string Jwitem = "jwitem";
			 public const string Xtype = "xtype";
			 public const string Taxable = "taxable";
			 public const string UmStyle = "um_style";
			 public const string Productweight = "productweight";
			 public const string MwBuffer = "mw_buffer";
			 public const string SourceTicketInfo = "SourceTicketInfo";
			 public const string Polid = "polid";
			 public const string Catid = "catid";
			 public const string Scatid = "scatid";
			 public const string LineTypeUCode = "LineTypeUCode";
			 public const string WeightType = "weight_type";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Poid = "Poid";
			 public const string LineNum = "LineNum";
			 public const string Productcode = "Productcode";
			 public const string Productdescription = "Productdescription";
			 public const string Productaltcode = "Productaltcode";
			 public const string Productaltdescription = "Productaltdescription";
			 public const string Vendorcode = "Vendorcode";
			 public const string Vendordescription = "Vendordescription";
			 public const string Vendoraltcode = "Vendoraltcode";
			 public const string Vendoraltdescription = "Vendoraltdescription";
			 public const string Um = "Um";
			 public const string Qty = "Qty";
			 public const string Wprice = "Wprice";
			 public const string Weight = "Weight";
			 public const string Casecount = "Casecount";
			 public const string TruckComment = "TruckComment";
			 public const string VendorComment = "VendorComment";
			 public const string Status = "Status";
			 public const string State = "State";
			 public const string MultipleWeights = "MultipleWeights";
			 public const string Amount = "Amount";
			 public const string Taxamount = "Taxamount";
			 public const string CreateDate = "CreateDate";
			 public const string Jwitem = "Jwitem";
			 public const string Xtype = "Xtype";
			 public const string Taxable = "Taxable";
			 public const string UmStyle = "UmStyle";
			 public const string Productweight = "Productweight";
			 public const string MwBuffer = "MwBuffer";
			 public const string SourceTicketInfo = "SourceTicketInfo";
			 public const string Polid = "Polid";
			 public const string Catid = "Catid";
			 public const string Scatid = "Scatid";
			 public const string LineTypeUCode = "LineTypeUCode";
			 public const string WeightType = "WeightType";
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
			lock (typeof(WtaPoLineMetadata))
			{
				if(WtaPoLineMetadata.mapDelegates == null)
				{
					WtaPoLineMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaPoLineMetadata.meta == null)
				{
					WtaPoLineMetadata.meta = new WtaPoLineMetadata();
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


				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LineNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendordescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Um", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TruckComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("VendorComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("State", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("MultipleWeights", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Amount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Taxamount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Jwitem", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("Xtype", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Taxable", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("UmStyle", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productweight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("MwBuffer", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SourceTicketInfo", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Polid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LineTypeUCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("WeightType", new esTypeMap("varchar", "System.Char"));			
				
				
				
				meta.Source = "wta_po_line";
				meta.Destination = "wta_po_line";
				
				meta.spInsert = "proc_wta_po_lineInsert";				
				meta.spUpdate = "proc_wta_po_lineUpdate";		
				meta.spDelete = "proc_wta_po_lineDelete";
				meta.spLoadAll = "proc_wta_po_lineLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_po_lineLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaPoLineMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
