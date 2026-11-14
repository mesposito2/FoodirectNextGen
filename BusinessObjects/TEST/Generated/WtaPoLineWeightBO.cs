
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
	/// Encapsulates the 'wta_po_line_weight' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaPoLineWeightBO))]	
	[XmlType("WtaPoLineWeightBO")]
	public partial class WtaPoLineWeightBO : esWtaPoLineWeightBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaPoLineWeightBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaPoLineWeightCollection")]
	public partial class WtaPoLineWeightCollection : esWtaPoLineWeightCollection, IEnumerable<WtaPoLineWeightBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaPoLineWeightQuery : esWtaPoLineWeightQuery
	{
		public WtaPoLineWeightQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaPoLineWeightQuery(string joinAlias, out WtaPoLineWeightQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaPoLineWeightQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaPoLineWeightQuery query)
		{
			return WtaPoLineWeightQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaPoLineWeightQuery(string query)
		{
			return (WtaPoLineWeightQuery)WtaPoLineWeightQuery.SerializeHelper.FromXml(query, typeof(WtaPoLineWeightQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaPoLineWeightBO : esEntity
	{
		public esWtaPoLineWeightBO()
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
			WtaPoLineWeightQuery query = new WtaPoLineWeightQuery();
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
		/// Maps to wta_po_line_weight.polwid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Polwid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Polwid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Polwid, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Polwid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line_weight.polid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Polid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Polid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Polid, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Polid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line_weight.iid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Iid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Iid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineWeightMetadata.ColumnNames.Iid, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Iid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line_weight.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineWeightMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineWeightMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Qty);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line_weight.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineWeightMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineWeightMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line_weight.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoLineWeightMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoLineWeightMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaPoLineWeightMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineWeightMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaPoLineWeightQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineWeightQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoLineWeightQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaPoLineWeightQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoLineWeightQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaPoLineWeightQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaPoLineWeightCollection : esEntityCollection<WtaPoLineWeightBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineWeightMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaPoLineWeightCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaPoLineWeightQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineWeightQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaPoLineWeightQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoLineWeightQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaPoLineWeightQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaPoLineWeightQuery)query);
		}

		#endregion
		
		private WtaPoLineWeightQuery query;
	}



	[Serializable]
	abstract public partial class esWtaPoLineWeightQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineWeightMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Polwid": return this.Polwid;
				case "Polid": return this.Polid;
				case "Iid": return this.Iid;
				case "Qty": return this.Qty;
				case "Weight": return this.Weight;
				case "Createdate": return this.Createdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Polwid
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Polwid, esSystemType.Int32); }
		} 
		
		public esQueryItem Polid
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Polid, esSystemType.Int32); }
		} 
		
		public esQueryItem Iid
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Iid, esSystemType.Int32); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaPoLineWeightMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaPoLineWeightBO : esWtaPoLineWeightBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaPoLineWeightMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaPoLineWeightMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Polwid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Polwid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Polid, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Polid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Iid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Iid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Qty, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Weight, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineWeightMetadata.ColumnNames.Createdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoLineWeightMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaPoLineWeightMetadata Meta()
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
			 public const string Polwid = "polwid";
			 public const string Polid = "polid";
			 public const string Iid = "iid";
			 public const string Qty = "qty";
			 public const string Weight = "weight";
			 public const string Createdate = "createdate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Polwid = "Polwid";
			 public const string Polid = "Polid";
			 public const string Iid = "Iid";
			 public const string Qty = "Qty";
			 public const string Weight = "Weight";
			 public const string Createdate = "Createdate";
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
			lock (typeof(WtaPoLineWeightMetadata))
			{
				if(WtaPoLineWeightMetadata.mapDelegates == null)
				{
					WtaPoLineWeightMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaPoLineWeightMetadata.meta == null)
				{
					WtaPoLineWeightMetadata.meta = new WtaPoLineWeightMetadata();
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


				meta.AddTypeMap("Polwid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Polid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Iid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "wta_po_line_weight";
				meta.Destination = "wta_po_line_weight";
				
				meta.spInsert = "proc_wta_po_line_weightInsert";				
				meta.spUpdate = "proc_wta_po_line_weightUpdate";		
				meta.spDelete = "proc_wta_po_line_weightDelete";
				meta.spLoadAll = "proc_wta_po_line_weightLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_po_line_weightLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaPoLineWeightMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
