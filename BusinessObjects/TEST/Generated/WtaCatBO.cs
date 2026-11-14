
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
	/// Encapsulates the 'wta_cat' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaCatBO))]	
	[XmlType("WtaCatBO")]
	public partial class WtaCatBO : esWtaCatBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaCatBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaCatCollection")]
	public partial class WtaCatCollection : esWtaCatCollection, IEnumerable<WtaCatBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaCatQuery : esWtaCatQuery
	{
		public WtaCatQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaCatQuery(string joinAlias, out WtaCatQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaCatQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaCatQuery query)
		{
			return WtaCatQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaCatQuery(string query)
		{
			return (WtaCatQuery)WtaCatQuery.SerializeHelper.FromXml(query, typeof(WtaCatQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaCatBO : esEntity
	{
		public esWtaCatBO()
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
			WtaCatQuery query = new WtaCatQuery();
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
		/// Maps to wta_cat.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaCatMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.parentid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Parentid
		{
			get
			{
				return base.GetSystemString(WtaCatMetadata.ColumnNames.Parentid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatMetadata.ColumnNames.Parentid, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Parentid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(WtaCatMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaCatMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaCatMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Active
		{
			get
			{
				return base.GetSystemInt16(WtaCatMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaCatMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_cat.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaCatMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaCatMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaCatMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaCatMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaCatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaCatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaCatQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaCatCollection : esEntityCollection<WtaCatBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaCatCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaCatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaCatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaCatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaCatQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaCatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaCatQuery)query);
		}

		#endregion
		
		private WtaCatQuery query;
	}



	[Serializable]
	abstract public partial class esWtaCatQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaCatMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Parentid": return this.Parentid;
				case "Catid": return this.Catid;
				case "Description": return this.Description;
				case "Active": return this.Active;
				case "Lastupdate": return this.Lastupdate;
				case "Createdate": return this.Createdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Parentid
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Parentid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Active, esSystemType.Int16); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaCatMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaCatBO : esWtaCatBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaCatMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaCatMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Parentid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatMetadata.PropertyNames.Parentid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Catid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Description, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaCatMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Active, 4, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaCatMetadata.PropertyNames.Active;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Lastupdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaCatMetadata.ColumnNames.Createdate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaCatMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaCatMetadata Meta()
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
			 public const string Parentid = "parentid";
			 public const string Catid = "catid";
			 public const string Description = "description";
			 public const string Active = "active";
			 public const string Lastupdate = "lastupdate";
			 public const string Createdate = "createdate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Parentid = "Parentid";
			 public const string Catid = "Catid";
			 public const string Description = "Description";
			 public const string Active = "Active";
			 public const string Lastupdate = "Lastupdate";
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
			lock (typeof(WtaCatMetadata))
			{
				if(WtaCatMetadata.mapDelegates == null)
				{
					WtaCatMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaCatMetadata.meta == null)
				{
					WtaCatMetadata.meta = new WtaCatMetadata();
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
				meta.AddTypeMap("Parentid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "wta_cat";
				meta.Destination = "wta_cat";
				
				meta.spInsert = "proc_wta_catInsert";				
				meta.spUpdate = "proc_wta_catUpdate";		
				meta.spDelete = "proc_wta_catDelete";
				meta.spLoadAll = "proc_wta_catLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_catLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaCatMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
