
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
	/// Encapsulates the 'wta_catalog_N_save' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaCatalogNSaveBO))]	
	[XmlType("WtaCatalogNSaveBO")]
	public partial class WtaCatalogNSaveBO : esWtaCatalogNSaveBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaCatalogNSaveBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaCatalogNSaveCollection")]
	public partial class WtaCatalogNSaveCollection : esWtaCatalogNSaveCollection, IEnumerable<WtaCatalogNSaveBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaCatalogNSaveQuery : esWtaCatalogNSaveQuery
	{
		public WtaCatalogNSaveQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaCatalogNSaveQuery(string joinAlias, out WtaCatalogNSaveQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaCatalogNSaveQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaCatalogNSaveQuery query)
		{
			return WtaCatalogNSaveQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaCatalogNSaveQuery(string query)
		{
			return (WtaCatalogNSaveQuery)WtaCatalogNSaveQuery.SerializeHelper.FromXml(query, typeof(WtaCatalogNSaveQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaCatalogNSaveBO : esEntity
	{
		public esWtaCatalogNSaveBO()
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
			WtaCatalogNSaveQuery query = new WtaCatalogNSaveQuery();
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
		/// Maps to wta_catalog_N_save.prodid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Prodid
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Prodid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Prodid, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Prodid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.vendormid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendormid, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Vendormid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.vendorname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendorname, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Vendorname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.vendorcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendorcode, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Vendorcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.vendordescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Vendordescription, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Vendordescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.vendorcasecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Vendorcasecount
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Vendorcasecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Vendorcasecount, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Vendorcasecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.wlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Wlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Wlbcs, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Wlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.wlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Wlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Wlbpc, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Wlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.rlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Rlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Rlbcs, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Rlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.rlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Rlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Rlbpc, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Rlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Taxable
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.lastwlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lastwlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbcs, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Lastwlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.lastwlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lastwlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbpc, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Lastwlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogNSaveMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Casecount, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Scatid, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatalogNSaveMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatalogNSaveMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatalogNSaveMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatalogNSaveMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Active
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.xtype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Xtype
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Xtype);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Xtype, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Xtype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Comment
		{
			get
			{
				return base.GetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Comment);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogNSaveMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.Comment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.weight_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? WeightType
		{
			get
			{
				return base.GetSystemChar(WtaCatalogNSaveMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemChar(WtaCatalogNSaveMetadata.ColumnNames.WeightType, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.WeightType);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog_N_save.um_style
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogNSaveMetadata.ColumnNames.UmStyle, value))
				{
					OnPropertyChanged(WtaCatalogNSaveMetadata.PropertyNames.UmStyle);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogNSaveMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaCatalogNSaveQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatalogNSaveQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatalogNSaveQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaCatalogNSaveQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatalogNSaveQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaCatalogNSaveQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaCatalogNSaveCollection : esEntityCollection<WtaCatalogNSaveBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogNSaveMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaCatalogNSaveCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaCatalogNSaveQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatalogNSaveQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatalogNSaveQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaCatalogNSaveQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaCatalogNSaveQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatalogNSaveQuery)query);
		}

		#endregion
		
		private WtaCatalogNSaveQuery query;
	}



	[Serializable]
	abstract public partial class esWtaCatalogNSaveQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogNSaveMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Prodid": return this.Prodid;
				case "Mid": return this.Mid;
				case "Productcode": return this.Productcode;
				case "Description": return this.Description;
				case "Vendormid": return this.Vendormid;
				case "Vendorname": return this.Vendorname;
				case "Vendorcode": return this.Vendorcode;
				case "Vendordescription": return this.Vendordescription;
				case "Vendorcasecount": return this.Vendorcasecount;
				case "Wlbcs": return this.Wlbcs;
				case "Wlbpc": return this.Wlbpc;
				case "Rlbcs": return this.Rlbcs;
				case "Rlbpc": return this.Rlbpc;
				case "Taxable": return this.Taxable;
				case "Lastwlbcs": return this.Lastwlbcs;
				case "Lastwlbpc": return this.Lastwlbpc;
				case "Weight": return this.Weight;
				case "Casecount": return this.Casecount;
				case "Scatid": return this.Scatid;
				case "Catid": return this.Catid;
				case "Createdate": return this.Createdate;
				case "Lastupdate": return this.Lastupdate;
				case "Active": return this.Active;
				case "Xtype": return this.Xtype;
				case "Comment": return this.Comment;
				case "WeightType": return this.WeightType;
				case "UmStyle": return this.UmStyle;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Prodid
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Prodid, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Vendormid
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Vendormid, esSystemType.String); }
		} 
		
		public esQueryItem Vendorname
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Vendorname, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcode
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Vendorcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendordescription
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Vendordescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcasecount
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Vendorcasecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Wlbcs
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Wlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Wlbpc
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Wlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Rlbcs
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Rlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Rlbpc
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Rlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Taxable, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastwlbcs
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Lastwlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Lastwlbpc
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Lastwlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Active, esSystemType.Int32); }
		} 
		
		public esQueryItem Xtype
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Xtype, esSystemType.String); }
		} 
		
		public esQueryItem Comment
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.Comment, esSystemType.String); }
		} 
		
		public esQueryItem WeightType
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.WeightType, esSystemType.Char); }
		} 
		
		public esQueryItem UmStyle
		{
			get { return new esQueryItem(this, WtaCatalogNSaveMetadata.ColumnNames.UmStyle, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaCatalogNSaveBO : esWtaCatalogNSaveBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaCatalogNSaveMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaCatalogNSaveMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Prodid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Prodid;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Description, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Vendormid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Vendorname, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Vendorcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Vendordescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Vendorcasecount, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Vendorcasecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Wlbcs, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Wlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Wlbpc, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Wlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Rlbcs, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Rlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Rlbpc, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Rlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Taxable, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Taxable;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbcs, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Lastwlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Lastwlbpc, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Lastwlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Weight, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Casecount, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Scatid, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Catid, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Createdate, 20, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Createdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Lastupdate, 21, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Active, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Active;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Xtype, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Xtype;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.Comment, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.Comment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.WeightType, 25, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogNSaveMetadata.ColumnNames.UmStyle, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogNSaveMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaCatalogNSaveMetadata Meta()
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
			 public const string Prodid = "prodid";
			 public const string Mid = "mid";
			 public const string Productcode = "productcode";
			 public const string Description = "description";
			 public const string Vendormid = "vendormid";
			 public const string Vendorname = "vendorname";
			 public const string Vendorcode = "vendorcode";
			 public const string Vendordescription = "vendordescription";
			 public const string Vendorcasecount = "vendorcasecount";
			 public const string Wlbcs = "wlbcs";
			 public const string Wlbpc = "wlbpc";
			 public const string Rlbcs = "rlbcs";
			 public const string Rlbpc = "rlbpc";
			 public const string Taxable = "taxable";
			 public const string Lastwlbcs = "lastwlbcs";
			 public const string Lastwlbpc = "lastwlbpc";
			 public const string Weight = "weight";
			 public const string Casecount = "casecount";
			 public const string Scatid = "scatid";
			 public const string Catid = "catid";
			 public const string Createdate = "createdate";
			 public const string Lastupdate = "lastupdate";
			 public const string Active = "active";
			 public const string Xtype = "xtype";
			 public const string Comment = "comment";
			 public const string WeightType = "weight_type";
			 public const string UmStyle = "um_style";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Prodid = "Prodid";
			 public const string Mid = "Mid";
			 public const string Productcode = "Productcode";
			 public const string Description = "Description";
			 public const string Vendormid = "Vendormid";
			 public const string Vendorname = "Vendorname";
			 public const string Vendorcode = "Vendorcode";
			 public const string Vendordescription = "Vendordescription";
			 public const string Vendorcasecount = "Vendorcasecount";
			 public const string Wlbcs = "Wlbcs";
			 public const string Wlbpc = "Wlbpc";
			 public const string Rlbcs = "Rlbcs";
			 public const string Rlbpc = "Rlbpc";
			 public const string Taxable = "Taxable";
			 public const string Lastwlbcs = "Lastwlbcs";
			 public const string Lastwlbpc = "Lastwlbpc";
			 public const string Weight = "Weight";
			 public const string Casecount = "Casecount";
			 public const string Scatid = "Scatid";
			 public const string Catid = "Catid";
			 public const string Createdate = "Createdate";
			 public const string Lastupdate = "Lastupdate";
			 public const string Active = "Active";
			 public const string Xtype = "Xtype";
			 public const string Comment = "Comment";
			 public const string WeightType = "WeightType";
			 public const string UmStyle = "UmStyle";
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
			lock (typeof(WtaCatalogNSaveMetadata))
			{
				if(WtaCatalogNSaveMetadata.mapDelegates == null)
				{
					WtaCatalogNSaveMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaCatalogNSaveMetadata.meta == null)
				{
					WtaCatalogNSaveMetadata.meta = new WtaCatalogNSaveMetadata();
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


				meta.AddTypeMap("Prodid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendormid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendordescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcasecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Wlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wlbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Rlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Rlbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Taxable", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lastwlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lastwlbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Active", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Xtype", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Comment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("WeightType", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("UmStyle", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "wta_catalog_N_save";
				meta.Destination = "wta_catalog_N_save";
				
				meta.spInsert = "proc_wta_catalog_N_saveInsert";				
				meta.spUpdate = "proc_wta_catalog_N_saveUpdate";		
				meta.spDelete = "proc_wta_catalog_N_saveDelete";
				meta.spLoadAll = "proc_wta_catalog_N_saveLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_catalog_N_saveLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaCatalogNSaveMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
