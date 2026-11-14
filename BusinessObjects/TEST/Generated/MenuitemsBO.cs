
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
	/// Encapsulates the 'menuitems' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(MenuitemsBO))]	
	[XmlType("MenuitemsBO")]
	public partial class MenuitemsBO : esMenuitemsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new MenuitemsBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("MenuitemsCollection")]
	public partial class MenuitemsCollection : esMenuitemsCollection, IEnumerable<MenuitemsBO>
	{

		
				
	}



	[Serializable]	
	public partial class MenuitemsQuery : esMenuitemsQuery
	{
		public MenuitemsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public MenuitemsQuery(string joinAlias, out MenuitemsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "MenuitemsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(MenuitemsQuery query)
		{
			return MenuitemsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator MenuitemsQuery(string query)
		{
			return (MenuitemsQuery)MenuitemsQuery.SerializeHelper.FromXml(query, typeof(MenuitemsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esMenuitemsBO : esEntity
	{
		public esMenuitemsBO()
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
			MenuitemsQuery query = new MenuitemsQuery();
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
		/// Maps to menuitems.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Mid
		{
			get
			{
				return base.GetSystemInt32(MenuitemsMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemInt32(MenuitemsMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(MenuitemsMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to menuitems.tid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tid
		{
			get
			{
				return base.GetSystemInt32(MenuitemsMetadata.ColumnNames.Tid);
			}
			
			set
			{
				if(base.SetSystemInt32(MenuitemsMetadata.ColumnNames.Tid, value))
				{
					OnPropertyChanged(MenuitemsMetadata.PropertyNames.Tid);
				}
			}
		}
		
		/// <summary>
		/// Maps to menuitems.name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(MenuitemsMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(MenuitemsMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(MenuitemsMetadata.PropertyNames.Name);
				}
			}
		}
		
		/// <summary>
		/// Maps to menuitems.link
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Link
		{
			get
			{
				return base.GetSystemString(MenuitemsMetadata.ColumnNames.Link);
			}
			
			set
			{
				if(base.SetSystemString(MenuitemsMetadata.ColumnNames.Link, value))
				{
					OnPropertyChanged(MenuitemsMetadata.PropertyNames.Link);
				}
			}
		}
		
		/// <summary>
		/// Maps to menuitems.dorder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Dorder
		{
			get
			{
				return base.GetSystemInt32(MenuitemsMetadata.ColumnNames.Dorder);
			}
			
			set
			{
				if(base.SetSystemInt32(MenuitemsMetadata.ColumnNames.Dorder, value))
				{
					OnPropertyChanged(MenuitemsMetadata.PropertyNames.Dorder);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return MenuitemsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public MenuitemsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MenuitemsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MenuitemsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(MenuitemsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MenuitemsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private MenuitemsQuery query;		
	}



	[Serializable]
	abstract public partial class esMenuitemsCollection : esEntityCollection<MenuitemsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MenuitemsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "MenuitemsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public MenuitemsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MenuitemsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MenuitemsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MenuitemsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(MenuitemsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MenuitemsQuery)query);
		}

		#endregion
		
		private MenuitemsQuery query;
	}



	[Serializable]
	abstract public partial class esMenuitemsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MenuitemsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Tid": return this.Tid;
				case "Name": return this.Name;
				case "Link": return this.Link;
				case "Dorder": return this.Dorder;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, MenuitemsMetadata.ColumnNames.Mid, esSystemType.Int32); }
		} 
		
		public esQueryItem Tid
		{
			get { return new esQueryItem(this, MenuitemsMetadata.ColumnNames.Tid, esSystemType.Int32); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, MenuitemsMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem Link
		{
			get { return new esQueryItem(this, MenuitemsMetadata.ColumnNames.Link, esSystemType.String); }
		} 
		
		public esQueryItem Dorder
		{
			get { return new esQueryItem(this, MenuitemsMetadata.ColumnNames.Dorder, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class MenuitemsBO : esMenuitemsBO
	{

		
		
	}
	



	[Serializable]
	public partial class MenuitemsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MenuitemsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MenuitemsMetadata.ColumnNames.Mid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenuitemsMetadata.PropertyNames.Mid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenuitemsMetadata.ColumnNames.Tid, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenuitemsMetadata.PropertyNames.Tid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenuitemsMetadata.ColumnNames.Name, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = MenuitemsMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenuitemsMetadata.ColumnNames.Link, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = MenuitemsMetadata.PropertyNames.Link;
			c.CharacterMaxLength = 200;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MenuitemsMetadata.ColumnNames.Dorder, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MenuitemsMetadata.PropertyNames.Dorder;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public MenuitemsMetadata Meta()
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
			 public const string Tid = "tid";
			 public const string Name = "name";
			 public const string Link = "link";
			 public const string Dorder = "dorder";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Tid = "Tid";
			 public const string Name = "Name";
			 public const string Link = "Link";
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
			lock (typeof(MenuitemsMetadata))
			{
				if(MenuitemsMetadata.mapDelegates == null)
				{
					MenuitemsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MenuitemsMetadata.meta == null)
				{
					MenuitemsMetadata.meta = new MenuitemsMetadata();
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


				meta.AddTypeMap("Mid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Tid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Name", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Link", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Dorder", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "menuitems";
				meta.Destination = "menuitems";
				
				meta.spInsert = "proc_menuitemsInsert";				
				meta.spUpdate = "proc_menuitemsUpdate";		
				meta.spDelete = "proc_menuitemsDelete";
				meta.spLoadAll = "proc_menuitemsLoadAll";
				meta.spLoadByPrimaryKey = "proc_menuitemsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MenuitemsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
