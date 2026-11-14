/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 8/27/2019 11:02:11 PM
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
	abstract public class esCatsubCollection : esEntityCollection
	{
		public esCatsubCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "CatsubCollection";
		}

		#region Query Logic
		protected void InitQuery(esCatsubQuery query)
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
			this.InitQuery(query as esCatsubQuery);
		}
		#endregion
		
		virtual public CatsubBO DetachEntity(CatsubBO entity)
		{
			return base.DetachEntity(entity) as CatsubBO;
		}
		
		virtual public CatsubBO AttachEntity(CatsubBO entity)
		{
			return base.AttachEntity(entity) as CatsubBO;
		}
		
		virtual public void Combine(CatsubCollection collection)
		{
			base.Combine(collection);
		}
		
		new public CatsubBO this[int index]
		{
			get
			{
				return base[index] as CatsubBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(CatsubBO);
		}
	}



	[Serializable]
	abstract public class esCatsubBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esCatsubQuery GetDynamicQuery()
		{
			return null;
		}

		public esCatsubBO()
		{

		}

		public esCatsubBO(DataRow row)
			: base(row)
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
			esCatsubQuery query = this.GetDynamicQuery();
			query.Where(query.Scatid == scatid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String scatid)
		{
			esParameters parms = new esParameters();
			parms.Add("scatid",scatid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
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
						case "Scatid": this.str.Scatid = (string)value; break;							
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
		/// Maps to catsub.scatid
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(CatsubMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to catsub.description
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(CatsubMetadata.PropertyNames.Description));
					}
				}
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
			public esStrings(esCatsubBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Scatid
			{
				get
				{
					System.String data = entity.Scatid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid = null;
					else entity.Scatid = Convert.ToString(value);
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
			

			private esCatsubBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esCatsubQuery query)
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
				throw new Exception("esCatsubBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esCatsubQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatsubMetadata.Meta();
			}
		}	
		

		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, CatsubMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, CatsubMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("CatsubCollection")]
	public partial class CatsubCollection : esCatsubCollection, IEnumerable<CatsubBO>
	{
		public CatsubCollection()
		{

		}
		
		public static implicit operator List<CatsubBO>(CatsubCollection coll)
		{
			List<CatsubBO> list = new List<CatsubBO>();
			
			foreach (CatsubBO emp in coll)
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
				return  CatsubMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new CatsubBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new CatsubBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public CatsubQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatsubQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(CatsubQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public CatsubBO AddNew()
		{
			CatsubBO entity = base.AddNewEntity() as CatsubBO;
			
			return entity;
		}

		public CatsubBO FindByPrimaryKey(System.String scatid)
		{
			return base.FindByPrimaryKey(scatid) as CatsubBO;
		}


		#region IEnumerable<CatsubBO> Members

		IEnumerator<CatsubBO> IEnumerable<CatsubBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as CatsubBO;
			}
		}

		#endregion
		
		private CatsubQuery query;
	}


	/// <summary>
	/// Encapsulates the 'catsub' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("CatsubBO ({Scatid})")]
	[Serializable]
	public partial class CatsubBO : esCatsubBO
	{
		public CatsubBO()
		{

		}
	
		public CatsubBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatsubMetadata.Meta();
			}
		}
		
		
		
		override protected esCatsubQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatsubQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public CatsubQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatsubQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(CatsubQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private CatsubQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class CatsubQuery : esCatsubQuery
	{
		public CatsubQuery()
		{

		}		
		
		public CatsubQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "CatsubQuery";
        }
		
			
	}


	[Serializable]
	public partial class CatsubMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatsubMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatsubMetadata.ColumnNames.Scatid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatsubMetadata.PropertyNames.Scatid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 3;
			_columns.Add(c);
				
			c = new esColumnMetadata(CatsubMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatsubMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public CatsubMetadata Meta()
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatsubMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
