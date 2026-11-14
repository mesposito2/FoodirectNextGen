
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:14 PM
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
	/// Encapsulates the 'menutabs' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(MenutabsBO))]	
	[XmlType("MenutabsBO")]
	public partial class MenutabsBO : esMenutabsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new MenutabsBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("MenutabsCollection")]
	public partial class MenutabsCollection : esMenutabsCollection, IEnumerable<MenutabsBO>
	{

		
				
	}



	[Serializable]	
	public partial class MenutabsQuery : esMenutabsQuery
	{
		public MenutabsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public MenutabsQuery(string joinAlias, out MenutabsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "MenutabsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(MenutabsQuery query)
		{
			return MenutabsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator MenutabsQuery(string query)
		{
			return (MenutabsQuery)MenutabsQuery.SerializeHelper.FromXml(query, typeof(MenutabsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esMenutabsBO : esEntity
	{
		public esMenutabsBO()
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
			MenutabsQuery query = new MenutabsQuery();
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
		/// Maps to menutabs.tid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tid
		{
			get
			{
				return base.GetSystemInt32(MenutabsMetadata.ColumnNames.Tid);
			}
			
			set
			{
				if(base.SetSystemInt32(MenutabsMetadata.ColumnNames.Tid, value))
				{
					OnPropertyChanged(MenutabsMetadata.PropertyNames.Tid);
				}
			}
		}
		
		/// <summary>
		/// Maps to menutabs.source
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Source
		{
			get
			{
				return base.GetSystemInt32(MenutabsMetadata.ColumnNames.Source);
			}
			
			set
			{
				if(base.SetSystemInt32(MenutabsMetadata.ColumnNames.Source, value))
				{
					OnPropertyChanged(MenutabsMetadata.PropertyNames.Source);
				}
			}
		}
		
		/// <summary>
		/// Maps to menutabs.roletype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Roletype
		{
			get
			{
				return base.GetSystemInt32(MenutabsMetadata.ColumnNames.Roletype);
			}
			
			set
			{
				if(base.SetSystemInt32(MenutabsMetadata.ColumnNames.Roletype, value))
				{
					OnPropertyChanged(MenutabsMetadata.PropertyNames.Roletype);
				}
			}
		}
		
		/// <summary>
		/// Maps to menutabs.tab
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Tab
		{
			get
			{
				return base.GetSystemString(MenutabsMetadata.ColumnNames.Tab);
			}
			
			set
			{
				if(base.SetSystemString(MenutabsMetadata.ColumnNames.Tab, value))
				{
					OnPropertyChanged(MenutabsMetadata.PropertyNames.Tab);
				}
			}
		}
		
		/// <summary>
		/// Maps to menutabs.dorder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Dorder
		{
			get
			{
				return base.GetSystemInt32(MenutabsMetadata.ColumnNames.Dorder);
			}
			
			set
			{
				if(base.SetSystemInt32(MenutabsMetadata.ColumnNames.Dorder, value))
				{
					OnPropertyChanged(MenutabsMetadata.PropertyNames.Dorder);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return MenutabsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public MenutabsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MenutabsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MenutabsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(MenutabsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MenutabsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private MenutabsQuery query;		
	}



	[Serializable]
	abstract public partial class esMenutabsCollection : esEntityCollection<MenutabsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MenutabsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "MenutabsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public MenutabsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MenutabsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MenutabsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MenutabsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(MenutabsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MenutabsQuery)query);
		}

		#endregion
		
		private MenutabsQuery query;
	}



	[Serializable]
	abstract public partial class esMenutabsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MenutabsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Tid": return this.Tid;
				case "Source": return this.Source;
				case "Roletype": return this.Roletype;
				case "Tab": return this.Tab;
				case "Dorder": return this.Dorder;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Tid
		{
			get { return new esQueryItem(this, MenutabsMetadata.ColumnNames.Tid, esSystemType.Int32); }
		} 
		
		public esQueryItem Source
		{
			get { return new esQueryItem(this, MenutabsMetadata.ColumnNames.Source, esSystemType.Int32); }
		} 
		
		public esQueryItem Roletype
		{
			get { return new esQueryItem(this, MenutabsMetadata.ColumnNames.Roletype, esSystemType.Int32); }
		} 
		
		public esQueryItem Tab
		{
			get { return new esQueryItem(this, MenutabsMetadata.ColumnNames.Tab, esSystemType.String); }
		} 
		
		public esQueryItem Dorder
		{
			get { return new esQueryItem(this, MenutabsMetadata.ColumnNames.Dorder, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class MenutabsBO : esMenutabsBO
	{

		
		
	}
	



	[Serializable]
	public partial class MenutabsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MenutabsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MenutabsMetadata.ColumnNames.Tid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenutabsMetadata.PropertyNames.Tid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenutabsMetadata.ColumnNames.Source, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenutabsMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenutabsMetadata.ColumnNames.Roletype, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenutabsMetadata.PropertyNames.Roletype;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenutabsMetadata.ColumnNames.Tab, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = MenutabsMetadata.PropertyNames.Tab;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenutabsMetadata.ColumnNames.Dorder, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenutabsMetadata.PropertyNames.Dorder;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public MenutabsMetadata Meta()
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
			 public const string Source = "source";
			 public const string Roletype = "roletype";
			 public const string Tab = "tab";
			 public const string Dorder = "dorder";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tid = "Tid";
			 public const string Source = "Source";
			 public const string Roletype = "Roletype";
			 public const string Tab = "Tab";
			 public const string Dorder = "Dorder";
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
			lock (typeof(MenutabsMetadata))
			{
				if(MenutabsMetadata.mapDelegates == null)
				{
					MenutabsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MenutabsMetadata.meta == null)
				{
					MenutabsMetadata.meta = new MenutabsMetadata();
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
				meta.AddTypeMap("Source", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Roletype", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Tab", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Dorder", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "menutabs";
				meta.Destination = "menutabs";
				
				meta.spInsert = "proc_menutabsInsert";				
				meta.spUpdate = "proc_menutabsUpdate";		
				meta.spDelete = "proc_menutabsDelete";
				meta.spLoadAll = "proc_menutabsLoadAll";
				meta.spLoadByPrimaryKey = "proc_menutabsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MenutabsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
