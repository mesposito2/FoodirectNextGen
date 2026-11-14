
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:13 PM
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
	/// Encapsulates the 'Chain' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ChainBO))]	
	[XmlType("ChainBO")]
	public partial class ChainBO : esChainBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ChainBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 chainID)
		{
			var obj = new ChainBO();
			obj.ChainID = chainID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 chainID, esSqlAccessType sqlAccessType)
		{
			var obj = new ChainBO();
			obj.ChainID = chainID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ChainCollection")]
	public partial class ChainCollection : esChainCollection, IEnumerable<ChainBO>
	{
		public ChainBO FindByPrimaryKey(System.Int32 chainID)
		{
			return this.SingleOrDefault(e => e.ChainID == chainID);
		}

		
				
	}



	[Serializable]	
	public partial class ChainQuery : esChainQuery
	{
		public ChainQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ChainQuery(string joinAlias, out ChainQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ChainQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ChainQuery query)
		{
			return ChainQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ChainQuery(string query)
		{
			return (ChainQuery)ChainQuery.SerializeHelper.FromXml(query, typeof(ChainQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esChainBO : esEntity
	{
		public esChainBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 chainID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(chainID);
			else
				return LoadByPrimaryKeyStoredProcedure(chainID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 chainID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(chainID);
			else
				return LoadByPrimaryKeyStoredProcedure(chainID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 chainID)
		{
			ChainQuery query = new ChainQuery();
			query.Where(query.ChainID == chainID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 chainID)
		{
			esParameters parms = new esParameters();
			parms.Add("ChainID", chainID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Chain.ChainID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChainID
		{
			get
			{
				return base.GetSystemInt32(ChainMetadata.ColumnNames.ChainID);
			}
			
			set
			{
				if(base.SetSystemInt32(ChainMetadata.ColumnNames.ChainID, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.ChainID);
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.ChainCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ChainCode
		{
			get
			{
				return base.GetSystemString(ChainMetadata.ColumnNames.ChainCode);
			}
			
			set
			{
				if(base.SetSystemString(ChainMetadata.ColumnNames.ChainCode, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.ChainCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(ChainMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ChainMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(ChainMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ChainMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(ChainMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ChainMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.LastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(ChainMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ChainMetadata.ColumnNames.LastUpdatedBy, value))
				{
					OnPropertyChanged(ChainMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ChainMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ChainQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ChainQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ChainQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ChainQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ChainQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ChainQuery query;		
	}



	[Serializable]
	abstract public partial class esChainCollection : esEntityCollection<ChainBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ChainMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ChainCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ChainQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ChainQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ChainQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ChainQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ChainQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ChainQuery)query);
		}

		#endregion
		
		private ChainQuery query;
	}



	[Serializable]
	abstract public partial class esChainQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ChainMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ChainID": return this.ChainID;
				case "ChainCode": return this.ChainCode;
				case "CreateDate": return this.CreateDate;
				case "CreatedBy": return this.CreatedBy;
				case "LastUpdate": return this.LastUpdate;
				case "LastUpdatedBy": return this.LastUpdatedBy;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ChainID
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.ChainID, esSystemType.Int32); }
		} 
		
		public esQueryItem ChainCode
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.ChainCode, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, ChainMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ChainBO : esChainBO
	{

		#region UsersBOCollection - Zero To Many (UN_Users_ChainCode)
		
		static public esPrefetchMap Prefetch_UsersBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.ChainBO.UsersBOCollection_Delegate,
					PropertyName = "UsersBOCollection",
					MyColumnName = "ChainCode",
					ParentColumnName = "ChainCode",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void UsersBOCollection_Delegate(esPrefetchParameters data)
		{
			ChainQuery parent = new ChainQuery(data.NextAlias());

			UsersQuery me = data.You != null ? data.You as UsersQuery : new UsersQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.ChainCode == me.ChainCode);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - UN_Users_ChainCode
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBOCollection()
		{
		    if(this._UsersBOCollection != null && this._UsersBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="UsersBOCollection", EmitDefaultValue = false)]
		public UsersCollection UsersBOCollection
		{
			get
			{
				if(this._UsersBOCollection == null)
				{
					this._UsersBOCollection = new UsersCollection();
					this._UsersBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("UsersBOCollection", this._UsersBOCollection);
				
					if (this.ChainCode != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._UsersBOCollection.Query.Where(this._UsersBOCollection.Query.ChainCode == this.ChainCode);
							this._UsersBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._UsersBOCollection.fks.Add(UsersMetadata.ColumnNames.ChainCode, this.ChainCode);
					}
				}

				return this._UsersBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._UsersBOCollection != null) 
				{ 
					this.RemovePostSave("UsersBOCollection"); 
					this._UsersBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private UsersCollection _UsersBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "UsersBOCollection":
					coll = this.UsersBOCollection;
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
			
			props.Add(new esPropertyDescriptor(this, "UsersBOCollection", typeof(UsersCollection), new UsersBO()));
		
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
			if(this._UsersBOCollection != null)
			{
				Apply(this._UsersBOCollection, "ChainCode", this.ChainCode);
			}
		}
		
	}
	



	[Serializable]
	public partial class ChainMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ChainMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ChainMetadata.ColumnNames.ChainID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ChainMetadata.PropertyNames.ChainID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.ChainCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.ChainCode;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.CreateDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ChainMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.CreatedBy, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ChainMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.LastUpdatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ChainMetadata Meta()
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
			 public const string ChainID = "ChainID";
			 public const string ChainCode = "ChainCode";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ChainID = "ChainID";
			 public const string ChainCode = "ChainCode";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(ChainMetadata))
			{
				if(ChainMetadata.mapDelegates == null)
				{
					ChainMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ChainMetadata.meta == null)
				{
					ChainMetadata.meta = new ChainMetadata();
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


				meta.AddTypeMap("ChainID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ChainCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Chain";
				meta.Destination = "Chain";
				
				meta.spInsert = "proc_ChainInsert";				
				meta.spUpdate = "proc_ChainUpdate";		
				meta.spDelete = "proc_ChainDelete";
				meta.spLoadAll = "proc_ChainLoadAll";
				meta.spLoadByPrimaryKey = "proc_ChainLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ChainMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
