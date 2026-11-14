/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/27/2015 1:27:46 PM
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
	abstract public class esFavoriteCollection : esEntityCollection
	{
		public esFavoriteCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "FavoriteCollection";
		}

		#region Query Logic
		protected void InitQuery(esFavoriteQuery query)
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
			this.InitQuery(query as esFavoriteQuery);
		}
		#endregion
		
		virtual public FavoriteBO DetachEntity(FavoriteBO entity)
		{
			return base.DetachEntity(entity) as FavoriteBO;
		}
		
		virtual public FavoriteBO AttachEntity(FavoriteBO entity)
		{
			return base.AttachEntity(entity) as FavoriteBO;
		}
		
		virtual public void Combine(FavoriteCollection collection)
		{
			base.Combine(collection);
		}
		
		new public FavoriteBO this[int index]
		{
			get
			{
				return base[index] as FavoriteBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(FavoriteBO);
		}
	}



	[Serializable]
	abstract public class esFavoriteBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esFavoriteQuery GetDynamicQuery()
		{
			return null;
		}

		public esFavoriteBO()
		{

		}

		public esFavoriteBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 favoriteID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(favoriteID);
			else
				return LoadByPrimaryKeyStoredProcedure(favoriteID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 favoriteID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(favoriteID);
			else
				return LoadByPrimaryKeyStoredProcedure(favoriteID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 favoriteID)
		{
			esFavoriteQuery query = this.GetDynamicQuery();
			query.Where(query.FavoriteID == favoriteID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 favoriteID)
		{
			esParameters parms = new esParameters();
			parms.Add("FavoriteID",favoriteID);
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
						case "FavoriteID": this.str.FavoriteID = (string)value; break;							
						case "CustID": this.str.CustID = (string)value; break;							
						case "ProductCode": this.str.ProductCode = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "FavoriteID":
						
							if (value == null || value is System.Int32)
								this.FavoriteID = (System.Int32?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
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
		/// Maps to Favorite.FavoriteID
		/// </summary>
		virtual public System.Int32? FavoriteID
		{
			get
			{
				return base.GetSystemInt32(FavoriteMetadata.ColumnNames.FavoriteID);
			}
			
			set
			{
				if(base.SetSystemInt32(FavoriteMetadata.ColumnNames.FavoriteID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.FavoriteID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.custID
		/// </summary>
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(FavoriteMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(FavoriteMetadata.ColumnNames.CustID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.CustID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.productCode
		/// </summary>
		virtual public System.String ProductCode
		{
			get
			{
				return base.GetSystemString(FavoriteMetadata.ColumnNames.ProductCode);
			}
			
			set
			{
				if(base.SetSystemString(FavoriteMetadata.ColumnNames.ProductCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.ProductCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.LastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(FavoriteMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(FavoriteMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(FavoriteMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(FavoriteMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.LastUpdatedBy
		/// </summary>
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(FavoriteMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(FavoriteMetadata.ColumnNames.LastUpdatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.LastUpdatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(FavoriteMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(FavoriteMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FavoriteMetadata.PropertyNames.CreateDate));
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
			public esStrings(esFavoriteBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String FavoriteID
			{
				get
				{
					System.Int32? data = entity.FavoriteID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FavoriteID = null;
					else entity.FavoriteID = Convert.ToInt32(value);
				}
			}
				
			public System.String CustID
			{
				get
				{
					System.String data = entity.CustID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CustID = null;
					else entity.CustID = Convert.ToString(value);
				}
			}
				
			public System.String ProductCode
			{
				get
				{
					System.String data = entity.ProductCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductCode = null;
					else entity.ProductCode = Convert.ToString(value);
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
			

			private esFavoriteBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esFavoriteQuery query)
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
				throw new Exception("esFavoriteBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esFavoriteQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FavoriteMetadata.Meta();
			}
		}	
		

		public esQueryItem FavoriteID
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.FavoriteID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem CustID
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.CustID, esSystemType.String);
			}
		} 
		
		public esQueryItem ProductCode
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.ProductCode, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, FavoriteMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("FavoriteCollection")]
	public partial class FavoriteCollection : esFavoriteCollection, IEnumerable<FavoriteBO>
	{
		public FavoriteCollection()
		{

		}
		
		public static implicit operator List<FavoriteBO>(FavoriteCollection coll)
		{
			List<FavoriteBO> list = new List<FavoriteBO>();
			
			foreach (FavoriteBO emp in coll)
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
				return  FavoriteMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FavoriteQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new FavoriteBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new FavoriteBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public FavoriteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FavoriteQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(FavoriteQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public FavoriteBO AddNew()
		{
			FavoriteBO entity = base.AddNewEntity() as FavoriteBO;
			
			return entity;
		}

		public FavoriteBO FindByPrimaryKey(System.Int32 favoriteID)
		{
			return base.FindByPrimaryKey(favoriteID) as FavoriteBO;
		}


		#region IEnumerable<FavoriteBO> Members

		IEnumerator<FavoriteBO> IEnumerable<FavoriteBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as FavoriteBO;
			}
		}

		#endregion
		
		private FavoriteQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Favorite' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("FavoriteBO ({FavoriteID})")]
	[Serializable]
	public partial class FavoriteBO : esFavoriteBO
	{
		public FavoriteBO()
		{

		}
	
		public FavoriteBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FavoriteMetadata.Meta();
			}
		}
		
		
		
		override protected esFavoriteQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FavoriteQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public FavoriteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FavoriteQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(FavoriteQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private FavoriteQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class FavoriteQuery : esFavoriteQuery
	{
		public FavoriteQuery()
		{

		}		
		
		public FavoriteQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "FavoriteQuery";
        }
		
			
	}


	[Serializable]
	public partial class FavoriteMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FavoriteMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.FavoriteID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FavoriteMetadata.PropertyNames.FavoriteID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.ProductCode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.ProductCode;
			c.CharacterMaxLength = 6;
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.LastUpdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FavoriteMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CreatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.LastUpdatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CreateDate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FavoriteMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
		}
		#endregion	
	
		static public FavoriteMetadata Meta()
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
			 public const string FavoriteID = "FavoriteID";
			 public const string CustID = "custID";
			 public const string ProductCode = "productCode";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string CreateDate = "CreateDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string FavoriteID = "FavoriteID";
			 public const string CustID = "CustID";
			 public const string ProductCode = "ProductCode";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(FavoriteMetadata))
			{
				if(FavoriteMetadata.mapDelegates == null)
				{
					FavoriteMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (FavoriteMetadata.meta == null)
				{
					FavoriteMetadata.meta = new FavoriteMetadata();
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
				

				meta.AddTypeMap("FavoriteID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ProductCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "Favorite";
				meta.Destination = "Favorite";
				
				meta.spInsert = "proc_FavoriteInsert";				
				meta.spUpdate = "proc_FavoriteUpdate";		
				meta.spDelete = "proc_FavoriteDelete";
				meta.spLoadAll = "proc_FavoriteLoadAll";
				meta.spLoadByPrimaryKey = "proc_FavoriteLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FavoriteMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
