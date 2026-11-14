/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 12/27/2015 5:24:07 PM
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
	abstract public class esV5HashCollection : esEntityCollection
	{
		public esV5HashCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5HashCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5HashQuery query)
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
			this.InitQuery(query as esV5HashQuery);
		}
		#endregion
		
		virtual public V5HashBO DetachEntity(V5HashBO entity)
		{
			return base.DetachEntity(entity) as V5HashBO;
		}
		
		virtual public V5HashBO AttachEntity(V5HashBO entity)
		{
			return base.AttachEntity(entity) as V5HashBO;
		}
		
		virtual public void Combine(V5HashCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5HashBO this[int index]
		{
			get
			{
				return base[index] as V5HashBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5HashBO);
		}
	}



	[Serializable]
	abstract public class esV5HashBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5HashQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5HashBO()
		{

		}

		public esV5HashBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 hashItemID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(hashItemID);
			else
				return LoadByPrimaryKeyStoredProcedure(hashItemID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 hashItemID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(hashItemID);
			else
				return LoadByPrimaryKeyStoredProcedure(hashItemID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 hashItemID)
		{
			esV5HashQuery query = this.GetDynamicQuery();
			query.Where(query.HashItemID == hashItemID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 hashItemID)
		{
			esParameters parms = new esParameters();
			parms.Add("HashItemID",hashItemID);
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
						case "HashItemID": this.str.HashItemID = (string)value; break;							
						case "HashGUID": this.str.HashGUID = (string)value; break;							
						case "HashKey": this.str.HashKey = (string)value; break;							
						case "HashValue": this.str.HashValue = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "HashItemID":
						
							if (value == null || value is System.Int32)
								this.HashItemID = (System.Int32?)value;
							break;
						
						case "CreateDate":
						
							if (value == null || value is System.DateTime)
								this.CreateDate = (System.DateTime?)value;
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
		/// Maps to V5Hash.HashItemID
		/// </summary>
		virtual public System.Int32? HashItemID
		{
			get
			{
				return base.GetSystemInt32(V5HashMetadata.ColumnNames.HashItemID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5HashMetadata.ColumnNames.HashItemID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5HashMetadata.PropertyNames.HashItemID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashGUID
		/// </summary>
		virtual public System.String HashGUID
		{
			get
			{
				return base.GetSystemString(V5HashMetadata.ColumnNames.HashGUID);
			}
			
			set
			{
				if(base.SetSystemString(V5HashMetadata.ColumnNames.HashGUID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5HashMetadata.PropertyNames.HashGUID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashKey
		/// </summary>
		virtual public System.String HashKey
		{
			get
			{
				return base.GetSystemString(V5HashMetadata.ColumnNames.HashKey);
			}
			
			set
			{
				if(base.SetSystemString(V5HashMetadata.ColumnNames.HashKey, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5HashMetadata.PropertyNames.HashKey));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashValue
		/// </summary>
		virtual public System.String HashValue
		{
			get
			{
				return base.GetSystemString(V5HashMetadata.ColumnNames.HashValue);
			}
			
			set
			{
				if(base.SetSystemString(V5HashMetadata.ColumnNames.HashValue, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5HashMetadata.PropertyNames.HashValue));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(V5HashMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5HashMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5HashMetadata.PropertyNames.CreateDate));
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
			public esStrings(esV5HashBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String HashItemID
			{
				get
				{
					System.Int32? data = entity.HashItemID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HashItemID = null;
					else entity.HashItemID = Convert.ToInt32(value);
				}
			}
				
			public System.String HashGUID
			{
				get
				{
					System.String data = entity.HashGUID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HashGUID = null;
					else entity.HashGUID = Convert.ToString(value);
				}
			}
				
			public System.String HashKey
			{
				get
				{
					System.String data = entity.HashKey;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HashKey = null;
					else entity.HashKey = Convert.ToString(value);
				}
			}
				
			public System.String HashValue
			{
				get
				{
					System.String data = entity.HashValue;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HashValue = null;
					else entity.HashValue = Convert.ToString(value);
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
			

			private esV5HashBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5HashQuery query)
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
				throw new Exception("esV5HashBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esV5HashQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5HashMetadata.Meta();
			}
		}	
		

		public esQueryItem HashItemID
		{
			get
			{
				return new esQueryItem(this, V5HashMetadata.ColumnNames.HashItemID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem HashGUID
		{
			get
			{
				return new esQueryItem(this, V5HashMetadata.ColumnNames.HashGUID, esSystemType.String);
			}
		} 
		
		public esQueryItem HashKey
		{
			get
			{
				return new esQueryItem(this, V5HashMetadata.ColumnNames.HashKey, esSystemType.String);
			}
		} 
		
		public esQueryItem HashValue
		{
			get
			{
				return new esQueryItem(this, V5HashMetadata.ColumnNames.HashValue, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, V5HashMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("V5HashCollection")]
	public partial class V5HashCollection : esV5HashCollection, IEnumerable<V5HashBO>
	{
		public V5HashCollection()
		{

		}
		
		public static implicit operator List<V5HashBO>(V5HashCollection coll)
		{
			List<V5HashBO> list = new List<V5HashBO>();
			
			foreach (V5HashBO emp in coll)
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
				return  V5HashMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5HashQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5HashBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5HashBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5HashQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5HashQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5HashQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5HashBO AddNew()
		{
			V5HashBO entity = base.AddNewEntity() as V5HashBO;
			
			return entity;
		}

		public V5HashBO FindByPrimaryKey(System.Int32 hashItemID)
		{
			return base.FindByPrimaryKey(hashItemID) as V5HashBO;
		}


		#region IEnumerable<V5HashBO> Members

		IEnumerator<V5HashBO> IEnumerable<V5HashBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5HashBO;
			}
		}

		#endregion
		
		private V5HashQuery query;
	}


	/// <summary>
	/// Encapsulates the 'V5Hash' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("V5HashBO ({HashItemID})")]
	[Serializable]
	public partial class V5HashBO : esV5HashBO
	{
		public V5HashBO()
		{

		}
	
		public V5HashBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5HashMetadata.Meta();
			}
		}
		
		
		
		override protected esV5HashQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5HashQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5HashQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5HashQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5HashQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5HashQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class V5HashQuery : esV5HashQuery
	{
		public V5HashQuery()
		{

		}		
		
		public V5HashQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5HashQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5HashMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5HashMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashItemID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5HashMetadata.PropertyNames.HashItemID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashGUID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashGUID;
			c.CharacterMaxLength = 500;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashKey, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashKey;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashValue, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashValue;
			c.CharacterMaxLength = 2147483647;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.CreateDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5HashMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5HashMetadata Meta()
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
			 public const string HashItemID = "HashItemID";
			 public const string HashGUID = "HashGUID";
			 public const string HashKey = "HashKey";
			 public const string HashValue = "HashValue";
			 public const string CreateDate = "CreateDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string HashItemID = "HashItemID";
			 public const string HashGUID = "HashGUID";
			 public const string HashKey = "HashKey";
			 public const string HashValue = "HashValue";
			 public const string CreateDate = "CreateDate";
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
			lock (typeof(V5HashMetadata))
			{
				if(V5HashMetadata.mapDelegates == null)
				{
					V5HashMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5HashMetadata.meta == null)
				{
					V5HashMetadata.meta = new V5HashMetadata();
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
				

				meta.AddTypeMap("HashItemID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("HashGUID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HashKey", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HashValue", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "V5Hash";
				meta.Destination = "V5Hash";
				
				meta.spInsert = "proc_V5HashInsert";				
				meta.spUpdate = "proc_V5HashUpdate";		
				meta.spDelete = "proc_V5HashDelete";
				meta.spLoadAll = "proc_V5HashLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5HashLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5HashMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
