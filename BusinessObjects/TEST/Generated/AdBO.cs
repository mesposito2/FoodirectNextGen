
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:12 PM
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
	/// Encapsulates the 'Ad' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(AdBO))]	
	[XmlType("AdBO")]
	public partial class AdBO : esAdBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AdBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 adID)
		{
			var obj = new AdBO();
			obj.AdID = adID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 adID, esSqlAccessType sqlAccessType)
		{
			var obj = new AdBO();
			obj.AdID = adID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("AdCollection")]
	public partial class AdCollection : esAdCollection, IEnumerable<AdBO>
	{
		public AdBO FindByPrimaryKey(System.Int32 adID)
		{
			return this.SingleOrDefault(e => e.AdID == adID);
		}

		
				
	}



	[Serializable]	
	public partial class AdQuery : esAdQuery
	{
		public AdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public AdQuery(string joinAlias, out AdQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "AdQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AdQuery query)
		{
			return AdQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AdQuery(string query)
		{
			return (AdQuery)AdQuery.SerializeHelper.FromXml(query, typeof(AdQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAdBO : esEntity
	{
		public esAdBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 adID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(adID);
			else
				return LoadByPrimaryKeyStoredProcedure(adID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 adID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(adID);
			else
				return LoadByPrimaryKeyStoredProcedure(adID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 adID)
		{
			AdQuery query = new AdQuery();
			query.Where(query.AdID == adID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 adID)
		{
			esParameters parms = new esParameters();
			parms.Add("AdID", adID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Ad.AdID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AdID
		{
			get
			{
				return base.GetSystemInt32(AdMetadata.ColumnNames.AdID);
			}
			
			set
			{
				if(base.SetSystemInt32(AdMetadata.ColumnNames.AdID, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.AdID);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AdName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AdName
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AdName);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AdName, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.AdName);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AdImage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AdImage
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AdImage);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AdImage, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.AdImage);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AltText
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AltText
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AltText);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AltText, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.AltText);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(AdMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AdMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(AdMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AdMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.LastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.LastUpdatedBy, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.Active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(AdMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(AdMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(AdMetadata.PropertyNames.Active);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AdMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(AdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AdQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private AdQuery query;		
	}



	[Serializable]
	abstract public partial class esAdCollection : esEntityCollection<AdBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AdMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AdCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AdQuery)query);
		}

		#endregion
		
		private AdQuery query;
	}



	[Serializable]
	abstract public partial class esAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AdMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "AdID": return this.AdID;
				case "AdName": return this.AdName;
				case "AdImage": return this.AdImage;
				case "AltText": return this.AltText;
				case "CreateDate": return this.CreateDate;
				case "CreatedBy": return this.CreatedBy;
				case "LastUpdate": return this.LastUpdate;
				case "LastUpdatedBy": return this.LastUpdatedBy;
				case "Active": return this.Active;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AdID
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.AdID, esSystemType.Int32); }
		} 
		
		public esQueryItem AdName
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.AdName, esSystemType.String); }
		} 
		
		public esQueryItem AdImage
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.AdImage, esSystemType.String); }
		} 
		
		public esQueryItem AltText
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.AltText, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, AdMetadata.ColumnNames.Active, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class AdBO : esAdBO
	{

		#region BookConfigAdBOCollection - Zero To Many (FK_BookConfigAd_AdID)
		
		static public esPrefetchMap Prefetch_BookConfigAdBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.AdBO.BookConfigAdBOCollection_Delegate,
					PropertyName = "BookConfigAdBOCollection",
					MyColumnName = "AdID",
					ParentColumnName = "AdID",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void BookConfigAdBOCollection_Delegate(esPrefetchParameters data)
		{
			AdQuery parent = new AdQuery(data.NextAlias());

			BookConfigAdQuery me = data.You != null ? data.You as BookConfigAdQuery : new BookConfigAdQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.AdID == me.AdID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_BookConfigAd_AdID
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
				
					if (this.AdID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._BookConfigAdBOCollection.Query.Where(this._BookConfigAdBOCollection.Query.AdID == this.AdID);
							this._BookConfigAdBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._BookConfigAdBOCollection.fks.Add(BookConfigAdMetadata.ColumnNames.AdID, this.AdID);
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

		#region SalesBeefConfigAdBOCollection - Zero To Many (FK_SalesBeefConfigAd_AdID)
		
		static public esPrefetchMap Prefetch_SalesBeefConfigAdBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.AdBO.SalesBeefConfigAdBOCollection_Delegate,
					PropertyName = "SalesBeefConfigAdBOCollection",
					MyColumnName = "AdID",
					ParentColumnName = "AdID",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void SalesBeefConfigAdBOCollection_Delegate(esPrefetchParameters data)
		{
			AdQuery parent = new AdQuery(data.NextAlias());

			SalesBeefConfigAdQuery me = data.You != null ? data.You as SalesBeefConfigAdQuery : new SalesBeefConfigAdQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.AdID == me.AdID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_SalesBeefConfigAd_AdID
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
				
					if (this.AdID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._SalesBeefConfigAdBOCollection.Query.Where(this._SalesBeefConfigAdBOCollection.Query.AdID == this.AdID);
							this._SalesBeefConfigAdBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._SalesBeefConfigAdBOCollection.fks.Add(SalesBeefConfigAdMetadata.ColumnNames.AdID, this.AdID);
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
				case "BookConfigAdBOCollection":
					coll = this.BookConfigAdBOCollection;
					break;
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
			
			props.Add(new esPropertyDescriptor(this, "BookConfigAdBOCollection", typeof(BookConfigAdCollection), new BookConfigAdBO()));
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
			if(this._BookConfigAdBOCollection != null)
			{
				Apply(this._BookConfigAdBOCollection, "AdID", this.AdID);
			}
			if(this._SalesBeefConfigAdBOCollection != null)
			{
				Apply(this._SalesBeefConfigAdBOCollection, "AdID", this.AdID);
			}
		}
		
	}
	



	[Serializable]
	public partial class AdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AdMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AdMetadata.ColumnNames.AdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AdMetadata.PropertyNames.AdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AdName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AdName;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AdImage, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AdImage;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AltText, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AltText;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.CreateDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AdMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.CreatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.LastUpdate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AdMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.LastUpdatedBy, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AdMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AdMetadata Meta()
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
			 public const string AdID = "AdID";
			 public const string AdName = "AdName";
			 public const string AdImage = "AdImage";
			 public const string AltText = "AltText";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string Active = "Active";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AdID = "AdID";
			 public const string AdName = "AdName";
			 public const string AdImage = "AdImage";
			 public const string AltText = "AltText";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string Active = "Active";
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
			lock (typeof(AdMetadata))
			{
				if(AdMetadata.mapDelegates == null)
				{
					AdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AdMetadata.meta == null)
				{
					AdMetadata.meta = new AdMetadata();
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


				meta.AddTypeMap("AdID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AdImage", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AltText", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "Ad";
				meta.Destination = "Ad";
				
				meta.spInsert = "proc_AdInsert";				
				meta.spUpdate = "proc_AdUpdate";		
				meta.spDelete = "proc_AdDelete";
				meta.spLoadAll = "proc_AdLoadAll";
				meta.spLoadByPrimaryKey = "proc_AdLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
