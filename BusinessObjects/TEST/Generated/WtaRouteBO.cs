
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
	/// Encapsulates the 'wta_route' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaRouteBO))]	
	[XmlType("WtaRouteBO")]
	public partial class WtaRouteBO : esWtaRouteBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaRouteBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaRouteCollection")]
	public partial class WtaRouteCollection : esWtaRouteCollection, IEnumerable<WtaRouteBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaRouteQuery : esWtaRouteQuery
	{
		public WtaRouteQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaRouteQuery(string joinAlias, out WtaRouteQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaRouteQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaRouteQuery query)
		{
			return WtaRouteQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaRouteQuery(string query)
		{
			return (WtaRouteQuery)WtaRouteQuery.SerializeHelper.FromXml(query, typeof(WtaRouteQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaRouteBO : esEntity
	{
		public esWtaRouteBO()
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
			WtaRouteQuery query = new WtaRouteQuery();
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
		/// Maps to wta_route.rid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Rid
		{
			get
			{
				return base.GetSystemInt32(WtaRouteMetadata.ColumnNames.Rid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaRouteMetadata.ColumnNames.Rid, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Rid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaRouteMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaRouteMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(WtaRouteMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(WtaRouteMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Name);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaRouteMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaRouteMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.driver1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Driver1
		{
			get
			{
				return base.GetSystemString(WtaRouteMetadata.ColumnNames.Driver1);
			}
			
			set
			{
				if(base.SetSystemString(WtaRouteMetadata.ColumnNames.Driver1, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Driver1);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.driver2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Driver2
		{
			get
			{
				return base.GetSystemString(WtaRouteMetadata.ColumnNames.Driver2);
			}
			
			set
			{
				if(base.SetSystemString(WtaRouteMetadata.ColumnNames.Driver2, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Driver2);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Active
		{
			get
			{
				return base.GetSystemInt32(WtaRouteMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaRouteMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaRouteMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaRouteMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_route.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaRouteMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaRouteMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaRouteMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaRouteMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaRouteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaRouteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaRouteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaRouteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaRouteQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaRouteQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaRouteCollection : esEntityCollection<WtaRouteBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaRouteMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaRouteCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaRouteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaRouteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaRouteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaRouteQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaRouteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaRouteQuery)query);
		}

		#endregion
		
		private WtaRouteQuery query;
	}



	[Serializable]
	abstract public partial class esWtaRouteQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaRouteMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Rid": return this.Rid;
				case "Mid": return this.Mid;
				case "Name": return this.Name;
				case "Description": return this.Description;
				case "Driver1": return this.Driver1;
				case "Driver2": return this.Driver2;
				case "Active": return this.Active;
				case "Createdate": return this.Createdate;
				case "Lastupdate": return this.Lastupdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Rid
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Rid, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Driver1
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Driver1, esSystemType.String); }
		} 
		
		public esQueryItem Driver2
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Driver2, esSystemType.String); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Active, esSystemType.Int32); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaRouteMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaRouteBO : esWtaRouteBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaRouteMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaRouteMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Rid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Rid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Name, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Description, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Driver1, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Driver1;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Driver2, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Driver2;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Active, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Active;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Createdate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaRouteMetadata.ColumnNames.Lastupdate, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaRouteMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaRouteMetadata Meta()
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
			 public const string Rid = "rid";
			 public const string Mid = "mid";
			 public const string Name = "name";
			 public const string Description = "description";
			 public const string Driver1 = "driver1";
			 public const string Driver2 = "driver2";
			 public const string Active = "active";
			 public const string Createdate = "createdate";
			 public const string Lastupdate = "lastupdate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Rid = "Rid";
			 public const string Mid = "Mid";
			 public const string Name = "Name";
			 public const string Description = "Description";
			 public const string Driver1 = "Driver1";
			 public const string Driver2 = "Driver2";
			 public const string Active = "Active";
			 public const string Createdate = "Createdate";
			 public const string Lastupdate = "Lastupdate";
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
			lock (typeof(WtaRouteMetadata))
			{
				if(WtaRouteMetadata.mapDelegates == null)
				{
					WtaRouteMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaRouteMetadata.meta == null)
				{
					WtaRouteMetadata.meta = new WtaRouteMetadata();
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


				meta.AddTypeMap("Rid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Name", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Driver1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Driver2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "wta_route";
				meta.Destination = "wta_route";
				
				meta.spInsert = "proc_wta_routeInsert";				
				meta.spUpdate = "proc_wta_routeUpdate";		
				meta.spDelete = "proc_wta_routeDelete";
				meta.spLoadAll = "proc_wta_routeLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_routeLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaRouteMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
