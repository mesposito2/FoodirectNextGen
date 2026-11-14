
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
	/// Encapsulates the 'cat' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatBO))]	
	[XmlType("CatBO")]
	public partial class CatBO : esCatBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String catid)
		{
			var obj = new CatBO();
			obj.Catid = catid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String catid, esSqlAccessType sqlAccessType)
		{
			var obj = new CatBO();
			obj.Catid = catid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatCollection")]
	public partial class CatCollection : esCatCollection, IEnumerable<CatBO>
	{
		public CatBO FindByPrimaryKey(System.String catid)
		{
			return this.SingleOrDefault(e => e.Catid == catid);
		}

		
				
	}



	[Serializable]	
	public partial class CatQuery : esCatQuery
	{
		public CatQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatQuery(string joinAlias, out CatQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatQuery query)
		{
			return CatQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatQuery(string query)
		{
			return (CatQuery)CatQuery.SerializeHelper.FromXml(query, typeof(CatQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatBO : esEntity
	{
		public esCatBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String catid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(catid);
			else
				return LoadByPrimaryKeyStoredProcedure(catid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String catid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(catid);
			else
				return LoadByPrimaryKeyStoredProcedure(catid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String catid)
		{
			CatQuery query = new CatQuery();
			query.Where(query.Catid == catid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String catid)
		{
			esParameters parms = new esParameters();
			parms.Add("Catid", catid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to cat.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(CatMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(CatMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to cat.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(CatMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(CatMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(CatMetadata.PropertyNames.Description);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatQuery query;		
	}



	[Serializable]
	abstract public partial class esCatCollection : esEntityCollection<CatBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatQuery)query);
		}

		#endregion
		
		private CatQuery query;
	}



	[Serializable]
	abstract public partial class esCatQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Catid": return this.Catid;
				case "Description": return this.Description;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Catid
		{
			get { return new esQueryItem(this, CatMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, CatMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CatBO : esCatBO
	{

		#region ProdsBOCollection - Zero To Many (FK_prods_catid)
		
		static public esPrefetchMap Prefetch_ProdsBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.CatBO.ProdsBOCollection_Delegate,
					PropertyName = "ProdsBOCollection",
					MyColumnName = "catid",
					ParentColumnName = "catid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void ProdsBOCollection_Delegate(esPrefetchParameters data)
		{
			CatQuery parent = new CatQuery(data.NextAlias());

			ProdsQuery me = data.You != null ? data.You as ProdsQuery : new ProdsQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Catid == me.Catid);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_prods_catid
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeProdsBOCollection()
		{
		    if(this._ProdsBOCollection != null && this._ProdsBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="ProdsBOCollection", EmitDefaultValue = false)]
		public ProdsCollection ProdsBOCollection
		{
			get
			{
				if(this._ProdsBOCollection == null)
				{
					this._ProdsBOCollection = new ProdsCollection();
					this._ProdsBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ProdsBOCollection", this._ProdsBOCollection);
				
					if (this.Catid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ProdsBOCollection.Query.Where(this._ProdsBOCollection.Query.Catid == this.Catid);
							this._ProdsBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ProdsBOCollection.fks.Add(ProdsMetadata.ColumnNames.Catid, this.Catid);
					}
				}

				return this._ProdsBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ProdsBOCollection != null) 
				{ 
					this.RemovePostSave("ProdsBOCollection"); 
					this._ProdsBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private ProdsCollection _ProdsBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ProdsBOCollection":
					coll = this.ProdsBOCollection;
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
			
			props.Add(new esPropertyDescriptor(this, "ProdsBOCollection", typeof(ProdsCollection), new ProdsBO()));
		
			return props;
		}
		
	}
	



	[Serializable]
	public partial class CatMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatMetadata.ColumnNames.Catid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatMetadata.PropertyNames.Catid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatMetadata Meta()
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
			 public const string Catid = "catid";
			 public const string Description = "description";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Catid = "Catid";
			 public const string Description = "Description";
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
			lock (typeof(CatMetadata))
			{
				if(CatMetadata.mapDelegates == null)
				{
					CatMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatMetadata.meta == null)
				{
					CatMetadata.meta = new CatMetadata();
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


				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "cat";
				meta.Destination = "cat";
				
				meta.spInsert = "proc_catInsert";				
				meta.spUpdate = "proc_catUpdate";		
				meta.spDelete = "proc_catDelete";
				meta.spLoadAll = "proc_catLoadAll";
				meta.spLoadByPrimaryKey = "proc_catLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
