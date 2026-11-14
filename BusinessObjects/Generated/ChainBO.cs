/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 5/6/2023 2:34:52 PM
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
	abstract public class esChainCollection : esEntityCollection
	{
		public esChainCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ChainCollection";
		}

		#region Query Logic
		protected void InitQuery(esChainQuery query)
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
			this.InitQuery(query as esChainQuery);
		}
		#endregion
		
		virtual public ChainBO DetachEntity(ChainBO entity)
		{
			return base.DetachEntity(entity) as ChainBO;
		}
		
		virtual public ChainBO AttachEntity(ChainBO entity)
		{
			return base.AttachEntity(entity) as ChainBO;
		}
		
		virtual public void Combine(ChainCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ChainBO this[int index]
		{
			get
			{
				return base[index] as ChainBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ChainBO);
		}
	}



	[Serializable]
	abstract public class esChainBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esChainQuery GetDynamicQuery()
		{
			return null;
		}

		public esChainBO()
		{

		}

		public esChainBO(DataRow row)
			: base(row)
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
			esChainQuery query = this.GetDynamicQuery();
			query.Where(query.ChainID == chainID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 chainID)
		{
			esParameters parms = new esParameters();
			parms.Add("ChainID",chainID);
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
						case "ChainID": this.str.ChainID = (string)value; break;							
						case "ChainCode": this.str.ChainCode = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "ChainID":
						
							if (value == null || value is System.Int32)
								this.ChainID = (System.Int32?)value;
							break;
						
						case "CreateDate":
						
							if (value == null || value is System.DateTime)
								this.CreateDate = (System.DateTime?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
							break;
					

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
		/// Maps to Chain.ChainID
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.ChainID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.ChainCode
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.ChainCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.CreateDate
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.CreatedBy
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.LastUpdate
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Chain.LastUpdatedBy
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ChainMetadata.PropertyNames.LastUpdatedBy));
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
			public esStrings(esChainBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String ChainID
			{
				get
				{
					System.Int32? data = entity.ChainID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChainID = null;
					else entity.ChainID = Convert.ToInt32(value);
				}
			}
				
			public System.String ChainCode
			{
				get
				{
					System.String data = entity.ChainCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChainCode = null;
					else entity.ChainCode = Convert.ToString(value);
				}
			}
				
			public System.String CreateDate
			{
				get
				{
					System.DateTime? data = entity.CreateDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreateDate = null;
					else entity.CreateDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String CreatedBy
			{
				get
				{
					System.String data = entity.CreatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedBy = null;
					else entity.CreatedBy = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdate
			{
				get
				{
					System.DateTime? data = entity.LastUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdate = null;
					else entity.LastUpdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String LastUpdatedBy
			{
				get
				{
					System.String data = entity.LastUpdatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdatedBy = null;
					else entity.LastUpdatedBy = Convert.ToString(value);
				}
			}
			

			private esChainBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esChainQuery query)
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
				throw new Exception("esChainBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esChainQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ChainMetadata.Meta();
			}
		}	
		

		public esQueryItem ChainID
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.ChainID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem ChainCode
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.ChainCode, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, ChainMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
	}



	[Serializable]
	[XmlType("ChainCollection")]
	public partial class ChainCollection : esChainCollection, IEnumerable<ChainBO>
	{
		public ChainCollection()
		{

		}
		
		public static implicit operator List<ChainBO>(ChainCollection coll)
		{
			List<ChainBO> list = new List<ChainBO>();
			
			foreach (ChainBO emp in coll)
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
				return  ChainMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ChainBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ChainBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ChainQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ChainQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ChainQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ChainBO AddNew()
		{
			ChainBO entity = base.AddNewEntity() as ChainBO;
			
			return entity;
		}

		public ChainBO FindByPrimaryKey(System.Int32 chainID)
		{
			return base.FindByPrimaryKey(chainID) as ChainBO;
		}


		#region IEnumerable<ChainBO> Members

		IEnumerator<ChainBO> IEnumerable<ChainBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ChainBO;
			}
		}

		#endregion
		
		private ChainQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Chain' table
	/// </summary>

	[Serializable]
	public partial class ChainBO : esChainBO
	{
		public ChainBO()
		{

		}
	
		public ChainBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ChainMetadata.Meta();
			}
		}
		
		
		
		override protected esChainQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ChainQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ChainQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ChainQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ChainQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ChainQuery query;
	}



	[Serializable]
		
	public partial class ChainQuery : esChainQuery
	{
		public ChainQuery()
		{

		}		
		
		public ChainQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ChainQuery";
        }
		
			
	}


	[Serializable]
	public partial class ChainMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ChainMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ChainMetadata.ColumnNames.ChainID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ChainMetadata.PropertyNames.ChainID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.ChainCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.ChainCode;
			c.CharacterMaxLength = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.CreateDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ChainMetadata.PropertyNames.CreateDate;
			_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.CreatedBy, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ChainMetadata.PropertyNames.LastUpdate;
			_columns.Add(c);
				
			c = new esColumnMetadata(ChainMetadata.ColumnNames.LastUpdatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ChainMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ChainMetadata Meta()
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ChainMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
