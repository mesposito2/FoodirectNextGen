
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
	/// Encapsulates the 'wta_favorites_item' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaFavoritesItemBO))]	
	[XmlType("WtaFavoritesItemBO")]
	public partial class WtaFavoritesItemBO : esWtaFavoritesItemBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaFavoritesItemBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaFavoritesItemCollection")]
	public partial class WtaFavoritesItemCollection : esWtaFavoritesItemCollection, IEnumerable<WtaFavoritesItemBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaFavoritesItemQuery : esWtaFavoritesItemQuery
	{
		public WtaFavoritesItemQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaFavoritesItemQuery(string joinAlias, out WtaFavoritesItemQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaFavoritesItemQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaFavoritesItemQuery query)
		{
			return WtaFavoritesItemQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaFavoritesItemQuery(string query)
		{
			return (WtaFavoritesItemQuery)WtaFavoritesItemQuery.SerializeHelper.FromXml(query, typeof(WtaFavoritesItemQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaFavoritesItemBO : esEntity
	{
		public esWtaFavoritesItemBO()
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
			WtaFavoritesItemQuery query = new WtaFavoritesItemQuery();
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
		/// Maps to wta_favorites_item.fid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fid
		{
			get
			{
				return base.GetSystemString(WtaFavoritesItemMetadata.ColumnNames.Fid);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesItemMetadata.ColumnNames.Fid, value))
				{
					OnPropertyChanged(WtaFavoritesItemMetadata.PropertyNames.Fid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites_item.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaFavoritesItemMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesItemMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaFavoritesItemMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites_item.um
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Um
		{
			get
			{
				return base.GetSystemString(WtaFavoritesItemMetadata.ColumnNames.Um);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesItemMetadata.ColumnNames.Um, value))
				{
					OnPropertyChanged(WtaFavoritesItemMetadata.PropertyNames.Um);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites_item.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaFavoritesItemMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaFavoritesItemMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaFavoritesItemMetadata.PropertyNames.Qty);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesItemMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaFavoritesItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFavoritesItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFavoritesItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaFavoritesItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFavoritesItemQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaFavoritesItemQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaFavoritesItemCollection : esEntityCollection<WtaFavoritesItemBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesItemMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaFavoritesItemCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaFavoritesItemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFavoritesItemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFavoritesItemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaFavoritesItemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaFavoritesItemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFavoritesItemQuery)query);
		}

		#endregion
		
		private WtaFavoritesItemQuery query;
	}



	[Serializable]
	abstract public partial class esWtaFavoritesItemQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesItemMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Fid": return this.Fid;
				case "Productcode": return this.Productcode;
				case "Um": return this.Um;
				case "Qty": return this.Qty;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Fid
		{
			get { return new esQueryItem(this, WtaFavoritesItemMetadata.ColumnNames.Fid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaFavoritesItemMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Um
		{
			get { return new esQueryItem(this, WtaFavoritesItemMetadata.ColumnNames.Um, esSystemType.String); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaFavoritesItemMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaFavoritesItemBO : esWtaFavoritesItemBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaFavoritesItemMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaFavoritesItemMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaFavoritesItemMetadata.ColumnNames.Fid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesItemMetadata.PropertyNames.Fid;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesItemMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesItemMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesItemMetadata.ColumnNames.Um, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesItemMetadata.PropertyNames.Um;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesItemMetadata.ColumnNames.Qty, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaFavoritesItemMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaFavoritesItemMetadata Meta()
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
			 public const string Fid = "fid";
			 public const string Productcode = "productcode";
			 public const string Um = "um";
			 public const string Qty = "qty";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Fid = "Fid";
			 public const string Productcode = "Productcode";
			 public const string Um = "Um";
			 public const string Qty = "Qty";
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
			lock (typeof(WtaFavoritesItemMetadata))
			{
				if(WtaFavoritesItemMetadata.mapDelegates == null)
				{
					WtaFavoritesItemMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaFavoritesItemMetadata.meta == null)
				{
					WtaFavoritesItemMetadata.meta = new WtaFavoritesItemMetadata();
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


				meta.AddTypeMap("Fid", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Um", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "wta_favorites_item";
				meta.Destination = "wta_favorites_item";
				
				meta.spInsert = "proc_wta_favorites_itemInsert";				
				meta.spUpdate = "proc_wta_favorites_itemUpdate";		
				meta.spDelete = "proc_wta_favorites_itemDelete";
				meta.spLoadAll = "proc_wta_favorites_itemLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_favorites_itemLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaFavoritesItemMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
