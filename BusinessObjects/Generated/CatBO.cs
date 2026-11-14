/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 1/2/2016 4:10:40 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{

	[Serializable]
	abstract public class esCatCollection : esEntityCollection
	{
		public esCatCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "CatCollection";
		}

		#region Query Logic
		protected void InitQuery(esCatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esCatQuery);
		}
		#endregion
		
		virtual public CatBO DetachEntity(CatBO entity)
		{
			return base.DetachEntity(entity) as CatBO;
		}
		
		virtual public CatBO AttachEntity(CatBO entity)
		{
			return base.AttachEntity(entity) as CatBO;
		}
		
		virtual public void Combine(CatCollection collection)
		{
			base.Combine(collection);
		}
		
		new public CatBO this[int index]
		{
			get
			{
				return base[index] as CatBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(CatBO);
		}
	}



	[Serializable]
	abstract public class esCatBO : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esCatQuery GetDynamicQuery()
		{
			return null;
		}

		public esCatBO()
		{

		}

		public esCatBO(DataRow row)
			: base(row)
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
			esCatQuery query = this.GetDynamicQuery();
			query.Where(query.Catid == catid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String catid)
		{
			esParameters parms = new esParameters();
			parms.Add("catid",catid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Catid": this.str.Catid = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to cat.catid
		/// </summary>
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatMetadata.ColumnNames.Catid);
			}
			
			set
			{
				base.SetSystemString(CatMetadata.ColumnNames.Catid, value);
			}
		}
		
		/// <summary>
		/// Maps to cat.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(CatMetadata.ColumnNames.Description);
			}
			
			set
			{
				base.SetSystemString(CatMetadata.ColumnNames.Description, value);
			}
		}
		
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
		sealed public class esStrings
		{
			public esStrings(esCatBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Catid
			{
				get
				{
					System.String data = entity.Catid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid = null;
					else entity.Catid = Convert.ToString(value);
				}
			}
				
			public System.String Description
			{
				get
				{
					System.String data = entity.Description;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description = null;
					else entity.Description = Convert.ToString(value);
				}
			}
			

			private esCatBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esCatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esCatBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class CatBO : esCatBO
	{

				
		#region ProdsBOCollectionByCatid - Zero To Many
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_prods_catid
		/// </summary>

		[XmlIgnore]
		public ProdsCollection ProdsBOCollectionByCatid
		{
			get
			{
				if(this._ProdsBOCollectionByCatid == null)
				{
					this._ProdsBOCollectionByCatid = new ProdsCollection();
					this._ProdsBOCollectionByCatid.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ProdsBOCollectionByCatid", this._ProdsBOCollectionByCatid);
				
					if(this.Catid != null)
					{
						this._ProdsBOCollectionByCatid.Query.Where(this._ProdsBOCollectionByCatid.Query.Catid == this.Catid);
						this._ProdsBOCollectionByCatid.Query.Load();

						// Auto-hookup Foreign Keys
						this._ProdsBOCollectionByCatid.fks.Add(ProdsMetadata.ColumnNames.Catid, this.Catid);
					}
				}

				return this._ProdsBOCollectionByCatid;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ProdsBOCollectionByCatid != null) 
				{ 
					this.RemovePostSave("ProdsBOCollectionByCatid"); 
					this._ProdsBOCollectionByCatid = null;
					
				} 
			} 			
		}

		private ProdsCollection _ProdsBOCollectionByCatid;
		#endregion

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "ProdsBOCollectionByCatid", typeof(ProdsCollection), new ProdsBO()));
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esCatQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatMetadata.Meta();
			}
		}	
		

		public esQueryItem Catid
		{
			get
			{
				return new esQueryItem(this, CatMetadata.ColumnNames.Catid, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, CatMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("CatCollection")]
	public partial class CatCollection : esCatCollection, IEnumerable<CatBO>
	{
		public CatCollection()
		{

		}
		
		public static implicit operator List<CatBO>(CatCollection coll)
		{
			List<CatBO> list = new List<CatBO>();
			
			foreach (CatBO emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  CatMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new CatBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new CatBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public CatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(CatQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public CatBO AddNew()
		{
			CatBO entity = base.AddNewEntity() as CatBO;
			
			return entity;
		}

		public CatBO FindByPrimaryKey(System.String catid)
		{
			return base.FindByPrimaryKey(catid) as CatBO;
		}


		#region IEnumerable<CatBO> Members

		IEnumerator<CatBO> IEnumerable<CatBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as CatBO;
			}
		}

		#endregion
		
		private CatQuery query;
	}


	/// <summary>
	/// Encapsulates the 'cat' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("CatBO ({Catid})")]
	[Serializable]
	public partial class CatBO : esCatBO
	{
		public CatBO()
		{

		}
	
		public CatBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatMetadata.Meta();
			}
		}
		
		
		
		override protected esCatQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public CatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(CatQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private CatQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class CatQuery : esCatQuery
	{
		public CatQuery()
		{

		}		
		
		public CatQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "CatQuery";
        }
		
			
	}


	[Serializable]
	public partial class CatMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatMetadata.ColumnNames.Catid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatMetadata.PropertyNames.Catid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 3;
			_columns.Add(c);
				
			c = new esColumnMetadata(CatMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public CatMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
