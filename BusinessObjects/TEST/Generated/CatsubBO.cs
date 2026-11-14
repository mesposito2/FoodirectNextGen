
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
	/// Encapsulates the 'catsub' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatsubBO))]	
	[XmlType("CatsubBO")]
	public partial class CatsubBO : esCatsubBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatsubBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String scatid)
		{
			var obj = new CatsubBO();
			obj.Scatid = scatid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String scatid, esSqlAccessType sqlAccessType)
		{
			var obj = new CatsubBO();
			obj.Scatid = scatid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatsubCollection")]
	public partial class CatsubCollection : esCatsubCollection, IEnumerable<CatsubBO>
	{
		public CatsubBO FindByPrimaryKey(System.String scatid)
		{
			return this.SingleOrDefault(e => e.Scatid == scatid);
		}

		
				
	}



	[Serializable]	
	public partial class CatsubQuery : esCatsubQuery
	{
		public CatsubQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatsubQuery(string joinAlias, out CatsubQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatsubQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatsubQuery query)
		{
			return CatsubQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatsubQuery(string query)
		{
			return (CatsubQuery)CatsubQuery.SerializeHelper.FromXml(query, typeof(CatsubQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatsubBO : esEntity
	{
		public esCatsubBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String scatid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(scatid);
			else
				return LoadByPrimaryKeyStoredProcedure(scatid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String scatid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(scatid);
			else
				return LoadByPrimaryKeyStoredProcedure(scatid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String scatid)
		{
			CatsubQuery query = new CatsubQuery();
			query.Where(query.Scatid == scatid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String scatid)
		{
			esParameters parms = new esParameters();
			parms.Add("Scatid", scatid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to catsub.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(CatsubMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(CatsubMetadata.ColumnNames.Scatid, value))
				{
					OnPropertyChanged(CatsubMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catsub.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(CatsubMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(CatsubMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(CatsubMetadata.PropertyNames.Description);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatsubMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatsubQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatsubQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatsubQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatsubQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatsubQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatsubQuery query;		
	}



	[Serializable]
	abstract public partial class esCatsubCollection : esEntityCollection<CatsubBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatsubMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatsubCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatsubQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatsubQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatsubQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatsubQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatsubQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatsubQuery)query);
		}

		#endregion
		
		private CatsubQuery query;
	}



	[Serializable]
	abstract public partial class esCatsubQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatsubMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Scatid": return this.Scatid;
				case "Description": return this.Description;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, CatsubMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, CatsubMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CatsubBO : esCatsubBO
	{

		#region ProdsBOCollection - Zero To Many (FK_prods_scatid)
		
		static public esPrefetchMap Prefetch_ProdsBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.CatsubBO.ProdsBOCollection_Delegate,
					PropertyName = "ProdsBOCollection",
					MyColumnName = "scatid",
					ParentColumnName = "scatid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void ProdsBOCollection_Delegate(esPrefetchParameters data)
		{
			CatsubQuery parent = new CatsubQuery(data.NextAlias());

			ProdsQuery me = data.You != null ? data.You as ProdsQuery : new ProdsQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Scatid == me.Scatid);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_prods_scatid
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
				
					if (this.Scatid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ProdsBOCollection.Query.Where(this._ProdsBOCollection.Query.Scatid == this.Scatid);
							this._ProdsBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ProdsBOCollection.fks.Add(ProdsMetadata.ColumnNames.Scatid, this.Scatid);
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
	public partial class CatsubMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatsubMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatsubMetadata.ColumnNames.Scatid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatsubMetadata.PropertyNames.Scatid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 3;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatsubMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatsubMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatsubMetadata Meta()
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
			 public const string Scatid = "scatid";
			 public const string Description = "description";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Scatid = "Scatid";
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
			lock (typeof(CatsubMetadata))
			{
				if(CatsubMetadata.mapDelegates == null)
				{
					CatsubMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatsubMetadata.meta == null)
				{
					CatsubMetadata.meta = new CatsubMetadata();
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


				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "catsub";
				meta.Destination = "catsub";
				
				meta.spInsert = "proc_catsubInsert";				
				meta.spUpdate = "proc_catsubUpdate";		
				meta.spDelete = "proc_catsubDelete";
				meta.spLoadAll = "proc_catsubLoadAll";
				meta.spLoadByPrimaryKey = "proc_catsubLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatsubMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
