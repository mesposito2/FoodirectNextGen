
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
	/// Encapsulates the 'wta_catalog' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaCatalogBO))]	
	[XmlType("WtaCatalogBO")]
	public partial class WtaCatalogBO : esWtaCatalogBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaCatalogBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaCatalogCollection")]
	public partial class WtaCatalogCollection : esWtaCatalogCollection, IEnumerable<WtaCatalogBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaCatalogQuery : esWtaCatalogQuery
	{
		public WtaCatalogQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaCatalogQuery(string joinAlias, out WtaCatalogQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaCatalogQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaCatalogQuery query)
		{
			return WtaCatalogQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaCatalogQuery(string query)
		{
			return (WtaCatalogQuery)WtaCatalogQuery.SerializeHelper.FromXml(query, typeof(WtaCatalogQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaCatalogBO : esEntity
	{
		public esWtaCatalogBO()
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
			WtaCatalogQuery query = new WtaCatalogQuery();
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
		/// Maps to wta_catalog.prodid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Prodid
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.Prodid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.Prodid, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Prodid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.vendormid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Vendormid, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Vendormid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.vendorname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Vendorname, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Vendorname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.vendorcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Vendorcode, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Vendorcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.vendordescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Vendordescription, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Vendordescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.vendorcasecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Vendorcasecount
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.Vendorcasecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.Vendorcasecount, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Vendorcasecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.wlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Wlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Wlbcs, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Wlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.wlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Wlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Wlbpc, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Wlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.rlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Rlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Rlbcs, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Rlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.rlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Rlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Rlbpc, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Rlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Taxable
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.lastwlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lastwlbcs
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Lastwlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Lastwlbcs, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Lastwlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.lastwlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lastwlbpc
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Lastwlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Lastwlbpc, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Lastwlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaCatalogMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaCatalogMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.Casecount, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Scatid, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatalogMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatalogMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatalogMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatalogMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Active
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.xtype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Xtype
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Xtype);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Xtype, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Xtype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Comment
		{
			get
			{
				return base.GetSystemString(WtaCatalogMetadata.ColumnNames.Comment);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatalogMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.Comment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.weight_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? WeightType
		{
			get
			{
				return base.GetSystemChar(WtaCatalogMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemChar(WtaCatalogMetadata.ColumnNames.WeightType, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.WeightType);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_catalog.um_style
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaCatalogMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaCatalogMetadata.ColumnNames.UmStyle, value))
				{
					OnPropertyChanged(WtaCatalogMetadata.PropertyNames.UmStyle);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaCatalogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatalogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatalogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaCatalogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatalogQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaCatalogQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaCatalogCollection : esEntityCollection<WtaCatalogBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaCatalogCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaCatalogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatalogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatalogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaCatalogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaCatalogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatalogQuery)query);
		}

		#endregion
		
		private WtaCatalogQuery query;
	}



	[Serializable]
	abstract public partial class esWtaCatalogQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatalogMetadata.Meta();
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
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Prodid, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Vendormid
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Vendormid, esSystemType.String); }
		} 
		
		public esQueryItem Vendorname
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Vendorname, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcode
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Vendorcode, esSystemType.String); }
		} 
		
		public esQueryItem Vendordescription
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Vendordescription, esSystemType.String); }
		} 
		
		public esQueryItem Vendorcasecount
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Vendorcasecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Wlbcs
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Wlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Wlbpc
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Wlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Rlbcs
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Rlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Rlbpc
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Rlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Taxable, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastwlbcs
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Lastwlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Lastwlbpc
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Lastwlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Active, esSystemType.Int32); }
		} 
		
		public esQueryItem Xtype
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Xtype, esSystemType.String); }
		} 
		
		public esQueryItem Comment
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.Comment, esSystemType.String); }
		} 
		
		public esQueryItem WeightType
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.WeightType, esSystemType.Char); }
		} 
		
		public esQueryItem UmStyle
		{
			get { return new esQueryItem(this, WtaCatalogMetadata.ColumnNames.UmStyle, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaCatalogBO : esWtaCatalogBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaCatalogMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaCatalogMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Prodid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Prodid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Description, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Vendormid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Vendorname, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Vendorcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Vendordescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Vendorcasecount, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Vendorcasecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Wlbcs, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Wlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Wlbpc, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Wlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Rlbcs, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Rlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Rlbpc, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Rlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Taxable, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Taxable;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Lastwlbcs, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Lastwlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Lastwlbpc, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Lastwlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Weight, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Casecount, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Scatid, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Catid, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Createdate, 20, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Lastupdate, 21, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Active, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Active;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Xtype, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Xtype;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.Comment, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.Comment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.WeightType, 25, typeof(System.Char), esSystemType.Char);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatalogMetadata.ColumnNames.UmStyle, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaCatalogMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaCatalogMetadata Meta()
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
			lock (typeof(WtaCatalogMetadata))
			{
				if(WtaCatalogMetadata.mapDelegates == null)
				{
					WtaCatalogMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaCatalogMetadata.meta == null)
				{
					WtaCatalogMetadata.meta = new WtaCatalogMetadata();
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
				
				
				
				meta.Source = "wta_catalog";
				meta.Destination = "wta_catalog";
				
				meta.spInsert = "proc_wta_catalogInsert";				
				meta.spUpdate = "proc_wta_catalogUpdate";		
				meta.spDelete = "proc_wta_catalogDelete";
				meta.spLoadAll = "proc_wta_catalogLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_catalogLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaCatalogMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
