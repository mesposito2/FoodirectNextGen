
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
	/// Encapsulates the 'wta_sales_tax' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaSalesTaxBO))]	
	[XmlType("WtaSalesTaxBO")]
	public partial class WtaSalesTaxBO : esWtaSalesTaxBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaSalesTaxBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 sid)
		{
			var obj = new WtaSalesTaxBO();
			obj.Sid = sid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 sid, esSqlAccessType sqlAccessType)
		{
			var obj = new WtaSalesTaxBO();
			obj.Sid = sid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaSalesTaxCollection")]
	public partial class WtaSalesTaxCollection : esWtaSalesTaxCollection, IEnumerable<WtaSalesTaxBO>
	{
		public WtaSalesTaxBO FindByPrimaryKey(System.Int32 sid)
		{
			return this.SingleOrDefault(e => e.Sid == sid);
		}

		
				
	}



	[Serializable]	
	public partial class WtaSalesTaxQuery : esWtaSalesTaxQuery
	{
		public WtaSalesTaxQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaSalesTaxQuery(string joinAlias, out WtaSalesTaxQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaSalesTaxQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaSalesTaxQuery query)
		{
			return WtaSalesTaxQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaSalesTaxQuery(string query)
		{
			return (WtaSalesTaxQuery)WtaSalesTaxQuery.SerializeHelper.FromXml(query, typeof(WtaSalesTaxQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaSalesTaxBO : esEntity
	{
		public esWtaSalesTaxBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 sid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(sid);
			else
				return LoadByPrimaryKeyStoredProcedure(sid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 sid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(sid);
			else
				return LoadByPrimaryKeyStoredProcedure(sid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 sid)
		{
			WtaSalesTaxQuery query = new WtaSalesTaxQuery();
			query.Where(query.Sid == sid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 sid)
		{
			esParameters parms = new esParameters();
			parms.Add("Sid", sid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_sales_tax.code
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Code
		{
			get
			{
				return base.GetSystemString(WtaSalesTaxMetadata.ColumnNames.Code);
			}
			
			set
			{
				if(base.SetSystemString(WtaSalesTaxMetadata.ColumnNames.Code, value))
				{
					OnPropertyChanged(WtaSalesTaxMetadata.PropertyNames.Code);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaSalesTaxMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaSalesTaxMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaSalesTaxMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.rate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Rate
		{
			get
			{
				return base.GetSystemDouble(WtaSalesTaxMetadata.ColumnNames.Rate);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaSalesTaxMetadata.ColumnNames.Rate, value))
				{
					OnPropertyChanged(WtaSalesTaxMetadata.PropertyNames.Rate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.sid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Sid
		{
			get
			{
				return base.GetSystemInt32(WtaSalesTaxMetadata.ColumnNames.Sid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaSalesTaxMetadata.ColumnNames.Sid, value))
				{
					OnPropertyChanged(WtaSalesTaxMetadata.PropertyNames.Sid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaSalesTaxMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaSalesTaxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaSalesTaxQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaSalesTaxQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaSalesTaxQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaSalesTaxQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaSalesTaxQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaSalesTaxCollection : esEntityCollection<WtaSalesTaxBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaSalesTaxMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaSalesTaxCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaSalesTaxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaSalesTaxQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaSalesTaxQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaSalesTaxQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaSalesTaxQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaSalesTaxQuery)query);
		}

		#endregion
		
		private WtaSalesTaxQuery query;
	}



	[Serializable]
	abstract public partial class esWtaSalesTaxQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaSalesTaxMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Code": return this.Code;
				case "Description": return this.Description;
				case "Rate": return this.Rate;
				case "Sid": return this.Sid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Code
		{
			get { return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Code, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Rate
		{
			get { return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Rate, esSystemType.Double); }
		} 
		
		public esQueryItem Sid
		{
			get { return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Sid, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaSalesTaxBO : esWtaSalesTaxBO
	{

		#region UsersBOCollection - Zero To Many (FK_users_sales_tax_region)
		
		static public esPrefetchMap Prefetch_UsersBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.WtaSalesTaxBO.UsersBOCollection_Delegate,
					PropertyName = "UsersBOCollection",
					MyColumnName = "sales_tax_region",
					ParentColumnName = "code",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void UsersBOCollection_Delegate(esPrefetchParameters data)
		{
			WtaSalesTaxQuery parent = new WtaSalesTaxQuery(data.NextAlias());

			UsersQuery me = data.You != null ? data.You as UsersQuery : new UsersQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Code == me.SalesTaxRegion);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_users_sales_tax_region
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
				
					if (this.Code != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._UsersBOCollection.Query.Where(this._UsersBOCollection.Query.SalesTaxRegion == this.Code);
							this._UsersBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._UsersBOCollection.fks.Add(UsersMetadata.ColumnNames.SalesTaxRegion, this.Code);
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
				Apply(this._UsersBOCollection, "SalesTaxRegion", this.Code);
			}
		}
		
	}
	



	[Serializable]
	public partial class WtaSalesTaxMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaSalesTaxMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Code, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Code;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Rate, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Rate;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Sid, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Sid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaSalesTaxMetadata Meta()
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
			 public const string Code = "code";
			 public const string Description = "description";
			 public const string Rate = "rate";
			 public const string Sid = "sid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Code = "Code";
			 public const string Description = "Description";
			 public const string Rate = "Rate";
			 public const string Sid = "Sid";
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
			lock (typeof(WtaSalesTaxMetadata))
			{
				if(WtaSalesTaxMetadata.mapDelegates == null)
				{
					WtaSalesTaxMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaSalesTaxMetadata.meta == null)
				{
					WtaSalesTaxMetadata.meta = new WtaSalesTaxMetadata();
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


				meta.AddTypeMap("Code", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Rate", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sid", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "wta_sales_tax";
				meta.Destination = "wta_sales_tax";
				
				meta.spInsert = "proc_wta_sales_taxInsert";				
				meta.spUpdate = "proc_wta_sales_taxUpdate";		
				meta.spDelete = "proc_wta_sales_taxDelete";
				meta.spLoadAll = "proc_wta_sales_taxLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_sales_taxLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaSalesTaxMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
