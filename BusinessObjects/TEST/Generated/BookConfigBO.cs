
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
	/// Encapsulates the 'BookConfig' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(BookConfigBO))]	
	[XmlType("BookConfigBO")]
	public partial class BookConfigBO : esBookConfigBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new BookConfigBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 bookConfigID)
		{
			var obj = new BookConfigBO();
			obj.BookConfigID = bookConfigID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 bookConfigID, esSqlAccessType sqlAccessType)
		{
			var obj = new BookConfigBO();
			obj.BookConfigID = bookConfigID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("BookConfigCollection")]
	public partial class BookConfigCollection : esBookConfigCollection, IEnumerable<BookConfigBO>
	{
		public BookConfigBO FindByPrimaryKey(System.Int32 bookConfigID)
		{
			return this.SingleOrDefault(e => e.BookConfigID == bookConfigID);
		}

		
				
	}



	[Serializable]	
	public partial class BookConfigQuery : esBookConfigQuery
	{
		public BookConfigQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public BookConfigQuery(string joinAlias, out BookConfigQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "BookConfigQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(BookConfigQuery query)
		{
			return BookConfigQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator BookConfigQuery(string query)
		{
			return (BookConfigQuery)BookConfigQuery.SerializeHelper.FromXml(query, typeof(BookConfigQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esBookConfigBO : esEntity
	{
		public esBookConfigBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 bookConfigID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bookConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(bookConfigID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 bookConfigID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bookConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(bookConfigID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 bookConfigID)
		{
			BookConfigQuery query = new BookConfigQuery();
			query.Where(query.BookConfigID == bookConfigID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 bookConfigID)
		{
			esParameters parms = new esParameters();
			parms.Add("BookConfigID", bookConfigID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to BookConfig.BookConfigID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? BookConfigID
		{
			get
			{
				return base.GetSystemInt32(BookConfigMetadata.ColumnNames.BookConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(BookConfigMetadata.ColumnNames.BookConfigID, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.BookConfigID);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.IsCurrent
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsCurrent
		{
			get
			{
				return base.GetSystemBoolean(BookConfigMetadata.ColumnNames.IsCurrent);
			}
			
			set
			{
				if(base.SetSystemBoolean(BookConfigMetadata.ColumnNames.IsCurrent, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.IsCurrent);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.ShowPrices
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? ShowPrices
		{
			get
			{
				return base.GetSystemBoolean(BookConfigMetadata.ColumnNames.ShowPrices);
			}
			
			set
			{
				if(base.SetSystemBoolean(BookConfigMetadata.ColumnNames.ShowPrices, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.ShowPrices);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(BookConfigMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(BookConfigMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(BookConfigMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(BookConfigMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.Createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(BookConfigMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(BookConfigMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.LastUpdatedby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedby
		{
			get
			{
				return base.GetSystemString(BookConfigMetadata.ColumnNames.LastUpdatedby);
			}
			
			set
			{
				if(base.SetSystemString(BookConfigMetadata.ColumnNames.LastUpdatedby, value))
				{
					OnPropertyChanged(BookConfigMetadata.PropertyNames.LastUpdatedby);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return BookConfigMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public BookConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BookConfigQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(BookConfigQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BookConfigQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private BookConfigQuery query;		
	}



	[Serializable]
	abstract public partial class esBookConfigCollection : esEntityCollection<BookConfigBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "BookConfigCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public BookConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BookConfigQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BookConfigQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(BookConfigQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BookConfigQuery)query);
		}

		#endregion
		
		private BookConfigQuery query;
	}



	[Serializable]
	abstract public partial class esBookConfigQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "BookConfigID": return this.BookConfigID;
				case "IsCurrent": return this.IsCurrent;
				case "ShowPrices": return this.ShowPrices;
				case "CreateDate": return this.CreateDate;
				case "LastUpdate": return this.LastUpdate;
				case "Createdby": return this.Createdby;
				case "LastUpdatedby": return this.LastUpdatedby;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem BookConfigID
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.BookConfigID, esSystemType.Int32); }
		} 
		
		public esQueryItem IsCurrent
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.IsCurrent, esSystemType.Boolean); }
		} 
		
		public esQueryItem ShowPrices
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.ShowPrices, esSystemType.Boolean); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdatedby
		{
			get { return new esQueryItem(this, BookConfigMetadata.ColumnNames.LastUpdatedby, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class BookConfigBO : esBookConfigBO
	{

		#region BookConfigAdBOCollection - Zero To Many (FK_BookConfigAd_BookConfigID)
		
		static public esPrefetchMap Prefetch_BookConfigAdBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.BookConfigBO.BookConfigAdBOCollection_Delegate,
					PropertyName = "BookConfigAdBOCollection",
					MyColumnName = "BookConfigID",
					ParentColumnName = "BookConfigID",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void BookConfigAdBOCollection_Delegate(esPrefetchParameters data)
		{
			BookConfigQuery parent = new BookConfigQuery(data.NextAlias());

			BookConfigAdQuery me = data.You != null ? data.You as BookConfigAdQuery : new BookConfigAdQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.BookConfigID == me.BookConfigID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_BookConfigAd_BookConfigID
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeBookConfigAdBOCollection()
		{
		    if(this._BookConfigAdBOCollection != null && this._BookConfigAdBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="BookConfigAdBOCollection", EmitDefaultValue = false)]
		public BookConfigAdCollection BookConfigAdBOCollection
		{
			get
			{
				if(this._BookConfigAdBOCollection == null)
				{
					this._BookConfigAdBOCollection = new BookConfigAdCollection();
					this._BookConfigAdBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("BookConfigAdBOCollection", this._BookConfigAdBOCollection);
				
					if (this.BookConfigID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._BookConfigAdBOCollection.Query.Where(this._BookConfigAdBOCollection.Query.BookConfigID == this.BookConfigID);
							this._BookConfigAdBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._BookConfigAdBOCollection.fks.Add(BookConfigAdMetadata.ColumnNames.BookConfigID, this.BookConfigID);
					}
				}

				return this._BookConfigAdBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._BookConfigAdBOCollection != null) 
				{ 
					this.RemovePostSave("BookConfigAdBOCollection"); 
					this._BookConfigAdBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private BookConfigAdCollection _BookConfigAdBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "BookConfigAdBOCollection":
					coll = this.BookConfigAdBOCollection;
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
			
			props.Add(new esPropertyDescriptor(this, "BookConfigAdBOCollection", typeof(BookConfigAdCollection), new BookConfigAdBO()));
		
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
			if(this._BookConfigAdBOCollection != null)
			{
				Apply(this._BookConfigAdBOCollection, "BookConfigID", this.BookConfigID);
			}
		}
		
	}
	



	[Serializable]
	public partial class BookConfigMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BookConfigMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.BookConfigID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigMetadata.PropertyNames.BookConfigID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.IsCurrent, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = BookConfigMetadata.PropertyNames.IsCurrent;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.ShowPrices, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = BookConfigMetadata.PropertyNames.ShowPrices;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = BookConfigMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = BookConfigMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = BookConfigMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.LastUpdatedby, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = BookConfigMetadata.PropertyNames.LastUpdatedby;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public BookConfigMetadata Meta()
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
			 public const string BookConfigID = "BookConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string ShowPrices = "ShowPrices";
			 public const string CreateDate = "CreateDate";
			 public const string LastUpdate = "LastUpdate";
			 public const string Createdby = "Createdby";
			 public const string LastUpdatedby = "LastUpdatedby";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string BookConfigID = "BookConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string ShowPrices = "ShowPrices";
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
			lock (typeof(BookConfigMetadata))
			{
				if(BookConfigMetadata.mapDelegates == null)
				{
					BookConfigMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BookConfigMetadata.meta == null)
				{
					BookConfigMetadata.meta = new BookConfigMetadata();
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


				meta.AddTypeMap("BookConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsCurrent", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ShowPrices", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedby", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "BookConfig";
				meta.Destination = "BookConfig";
				
				meta.spInsert = "proc_BookConfigInsert";				
				meta.spUpdate = "proc_BookConfigUpdate";		
				meta.spDelete = "proc_BookConfigDelete";
				meta.spLoadAll = "proc_BookConfigLoadAll";
				meta.spLoadByPrimaryKey = "proc_BookConfigLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BookConfigMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
