
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:15 PM
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
	/// Encapsulates the 'SalesBeefConfig' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalesBeefConfigBO))]	
	[XmlType("SalesBeefConfigBO")]
	public partial class SalesBeefConfigBO : esSalesBeefConfigBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalesBeefConfigBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 salesBeefConfigID)
		{
			var obj = new SalesBeefConfigBO();
			obj.SalesBeefConfigID = salesBeefConfigID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 salesBeefConfigID, esSqlAccessType sqlAccessType)
		{
			var obj = new SalesBeefConfigBO();
			obj.SalesBeefConfigID = salesBeefConfigID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalesBeefConfigCollection")]
	public partial class SalesBeefConfigCollection : esSalesBeefConfigCollection, IEnumerable<SalesBeefConfigBO>
	{
		public SalesBeefConfigBO FindByPrimaryKey(System.Int32 salesBeefConfigID)
		{
			return this.SingleOrDefault(e => e.SalesBeefConfigID == salesBeefConfigID);
		}

		
				
	}



	[Serializable]	
	public partial class SalesBeefConfigQuery : esSalesBeefConfigQuery
	{
		public SalesBeefConfigQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalesBeefConfigQuery(string joinAlias, out SalesBeefConfigQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalesBeefConfigQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalesBeefConfigQuery query)
		{
			return SalesBeefConfigQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalesBeefConfigQuery(string query)
		{
			return (SalesBeefConfigQuery)SalesBeefConfigQuery.SerializeHelper.FromXml(query, typeof(SalesBeefConfigQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalesBeefConfigBO : esEntity
	{
		public esSalesBeefConfigBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesBeefConfigID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesBeefConfigID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesBeefConfigID)
		{
			SalesBeefConfigQuery query = new SalesBeefConfigQuery();
			query.Where(query.SalesBeefConfigID == salesBeefConfigID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesBeefConfigID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesBeefConfigID", salesBeefConfigID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to SalesBeefConfig.SalesBeefConfigID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalesBeefConfigID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.SalesBeefConfigID);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.IsCurrent
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsCurrent
		{
			get
			{
				return base.GetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.IsCurrent);
			}
			
			set
			{
				if(base.SetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.IsCurrent, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.IsCurrent);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.Title
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Title
		{
			get
			{
				return base.GetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.Title);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.Createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(SalesBeefConfigMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(SalesBeefConfigMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.LastUpdatedby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedby
		{
			get
			{
				return base.GetSystemString(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby);
			}
			
			set
			{
				if(base.SetSystemString(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, value))
				{
					OnPropertyChanged(SalesBeefConfigMetadata.PropertyNames.LastUpdatedby);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalesBeefConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesBeefConfigQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalesBeefConfigQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalesBeefConfigQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalesBeefConfigQuery query;		
	}



	[Serializable]
	abstract public partial class esSalesBeefConfigCollection : esEntityCollection<SalesBeefConfigBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalesBeefConfigCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalesBeefConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesBeefConfigQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalesBeefConfigQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalesBeefConfigQuery)query);
		}

		#endregion
		
		private SalesBeefConfigQuery query;
	}



	[Serializable]
	abstract public partial class esSalesBeefConfigQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SalesBeefConfigID": return this.SalesBeefConfigID;
				case "IsCurrent": return this.IsCurrent;
				case "Title": return this.Title;
				case "CreateDate": return this.CreateDate;
				case "LastUpdate": return this.LastUpdate;
				case "Createdby": return this.Createdby;
				case "LastUpdatedby": return this.LastUpdatedby;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SalesBeefConfigID
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, esSystemType.Int32); }
		} 
		
		public esQueryItem IsCurrent
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.IsCurrent, esSystemType.Boolean); }
		} 
		
		public esQueryItem Title
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.Title, esSystemType.Boolean); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdatedby
		{
			get { return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class SalesBeefConfigBO : esSalesBeefConfigBO
	{

		#region SalesBeefConfigAdBOCollection - Zero To Many (FK_SalesBeefConfigAd_SalesBeefConfigID)
		
		static public esPrefetchMap Prefetch_SalesBeefConfigAdBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.SalesBeefConfigBO.SalesBeefConfigAdBOCollection_Delegate,
					PropertyName = "SalesBeefConfigAdBOCollection",
					MyColumnName = "SalesBeefConfigID",
					ParentColumnName = "SalesBeefConfigID",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void SalesBeefConfigAdBOCollection_Delegate(esPrefetchParameters data)
		{
			SalesBeefConfigQuery parent = new SalesBeefConfigQuery(data.NextAlias());

			SalesBeefConfigAdQuery me = data.You != null ? data.You as SalesBeefConfigAdQuery : new SalesBeefConfigAdQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.SalesBeefConfigID == me.SalesBeefConfigID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_SalesBeefConfigAd_SalesBeefConfigID
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeSalesBeefConfigAdBOCollection()
		{
		    if(this._SalesBeefConfigAdBOCollection != null && this._SalesBeefConfigAdBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="SalesBeefConfigAdBOCollection", EmitDefaultValue = false)]
		public SalesBeefConfigAdCollection SalesBeefConfigAdBOCollection
		{
			get
			{
				if(this._SalesBeefConfigAdBOCollection == null)
				{
					this._SalesBeefConfigAdBOCollection = new SalesBeefConfigAdCollection();
					this._SalesBeefConfigAdBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("SalesBeefConfigAdBOCollection", this._SalesBeefConfigAdBOCollection);
				
					if (this.SalesBeefConfigID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._SalesBeefConfigAdBOCollection.Query.Where(this._SalesBeefConfigAdBOCollection.Query.SalesBeefConfigID == this.SalesBeefConfigID);
							this._SalesBeefConfigAdBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._SalesBeefConfigAdBOCollection.fks.Add(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, this.SalesBeefConfigID);
					}
				}

				return this._SalesBeefConfigAdBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._SalesBeefConfigAdBOCollection != null) 
				{ 
					this.RemovePostSave("SalesBeefConfigAdBOCollection"); 
					this._SalesBeefConfigAdBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private SalesBeefConfigAdCollection _SalesBeefConfigAdBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "SalesBeefConfigAdBOCollection":
					coll = this.SalesBeefConfigAdBOCollection;
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
			
			props.Add(new esPropertyDescriptor(this, "SalesBeefConfigAdBOCollection", typeof(SalesBeefConfigAdCollection), new SalesBeefConfigAdBO()));
		
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
			if(this._SalesBeefConfigAdBOCollection != null)
			{
				Apply(this._SalesBeefConfigAdBOCollection, "SalesBeefConfigID", this.SalesBeefConfigID);
			}
		}
		
	}
	



	[Serializable]
	public partial class SalesBeefConfigMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalesBeefConfigMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.SalesBeefConfigID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.IsCurrent, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.IsCurrent;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.Title, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.Title;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.LastUpdatedby;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalesBeefConfigMetadata Meta()
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
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string Title = "Title";
			 public const string CreateDate = "CreateDate";
			 public const string LastUpdate = "LastUpdate";
			 public const string Createdby = "Createdby";
			 public const string LastUpdatedby = "LastUpdatedby";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string Title = "Title";
			 public const string CreateDate = "CreateDate";
			 public const string LastUpdate = "LastUpdate";
			 public const string Createdby = "Createdby";
			 public const string LastUpdatedby = "LastUpdatedby";
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
			lock (typeof(SalesBeefConfigMetadata))
			{
				if(SalesBeefConfigMetadata.mapDelegates == null)
				{
					SalesBeefConfigMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalesBeefConfigMetadata.meta == null)
				{
					SalesBeefConfigMetadata.meta = new SalesBeefConfigMetadata();
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


				meta.AddTypeMap("SalesBeefConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsCurrent", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Title", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedby", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "SalesBeefConfig";
				meta.Destination = "SalesBeefConfig";
				
				meta.spInsert = "proc_SalesBeefConfigInsert";				
				meta.spUpdate = "proc_SalesBeefConfigUpdate";		
				meta.spDelete = "proc_SalesBeefConfigDelete";
				meta.spLoadAll = "proc_SalesBeefConfigLoadAll";
				meta.spLoadByPrimaryKey = "proc_SalesBeefConfigLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalesBeefConfigMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
