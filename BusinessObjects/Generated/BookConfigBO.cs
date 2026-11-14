/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 4/29/2015 9:02:10 PM
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
	abstract public class esBookConfigCollection : esEntityCollection
	{
		public esBookConfigCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "BookConfigCollection";
		}

		#region Query Logic
		protected void InitQuery(esBookConfigQuery query)
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
			this.InitQuery(query as esBookConfigQuery);
		}
		#endregion
		
		virtual public BookConfigBO DetachEntity(BookConfigBO entity)
		{
			return base.DetachEntity(entity) as BookConfigBO;
		}
		
		virtual public BookConfigBO AttachEntity(BookConfigBO entity)
		{
			return base.AttachEntity(entity) as BookConfigBO;
		}
		
		virtual public void Combine(BookConfigCollection collection)
		{
			base.Combine(collection);
		}
		
		new public BookConfigBO this[int index]
		{
			get
			{
				return base[index] as BookConfigBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(BookConfigBO);
		}
	}



	[Serializable]
	abstract public class esBookConfigBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esBookConfigQuery GetDynamicQuery()
		{
			return null;
		}

		public esBookConfigBO()
		{

		}

		public esBookConfigBO(DataRow row)
			: base(row)
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
			esBookConfigQuery query = this.GetDynamicQuery();
			query.Where(query.BookConfigID == bookConfigID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 bookConfigID)
		{
			esParameters parms = new esParameters();
			parms.Add("BookConfigID",bookConfigID);
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
						case "BookConfigID": this.str.BookConfigID = (string)value; break;							
						case "IsCurrent": this.str.IsCurrent = (string)value; break;							
						case "ShowPrices": this.str.ShowPrices = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "Createdby": this.str.Createdby = (string)value; break;							
						case "LastUpdatedby": this.str.LastUpdatedby = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "BookConfigID":
						
							if (value == null || value is System.Int32)
								this.BookConfigID = (System.Int32?)value;
							break;
						
						case "IsCurrent":
						
							if (value == null || value is System.Boolean)
								this.IsCurrent = (System.Boolean?)value;
							break;
						
						case "ShowPrices":
						
							if (value == null || value is System.Boolean)
								this.ShowPrices = (System.Boolean?)value;
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
		/// Maps to BookConfig.BookConfigID
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.BookConfigID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.IsCurrent
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.IsCurrent));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.ShowPrices
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.ShowPrices));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.CreateDate
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.LastUpdate
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.Createdby
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.Createdby));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfig.LastUpdatedby
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigMetadata.PropertyNames.LastUpdatedby));
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
			public esStrings(esBookConfigBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String BookConfigID
			{
				get
				{
					System.Int32? data = entity.BookConfigID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BookConfigID = null;
					else entity.BookConfigID = Convert.ToInt32(value);
				}
			}
				
			public System.String IsCurrent
			{
				get
				{
					System.Boolean? data = entity.IsCurrent;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsCurrent = null;
					else entity.IsCurrent = Convert.ToBoolean(value);
				}
			}
				
			public System.String ShowPrices
			{
				get
				{
					System.Boolean? data = entity.ShowPrices;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ShowPrices = null;
					else entity.ShowPrices = Convert.ToBoolean(value);
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
				
			public System.String Createdby
			{
				get
				{
					System.String data = entity.Createdby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Createdby = null;
					else entity.Createdby = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdatedby
			{
				get
				{
					System.String data = entity.LastUpdatedby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdatedby = null;
					else entity.LastUpdatedby = Convert.ToString(value);
				}
			}
			

			private esBookConfigBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esBookConfigQuery query)
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
				throw new Exception("esBookConfigBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esBookConfigQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigMetadata.Meta();
			}
		}	
		

		public esQueryItem BookConfigID
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.BookConfigID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem IsCurrent
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.IsCurrent, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem ShowPrices
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.ShowPrices, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Createdby
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.Createdby, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdatedby
		{
			get
			{
				return new esQueryItem(this, BookConfigMetadata.ColumnNames.LastUpdatedby, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("BookConfigCollection")]
	public partial class BookConfigCollection : esBookConfigCollection, IEnumerable<BookConfigBO>
	{
		public BookConfigCollection()
		{

		}
		
		public static implicit operator List<BookConfigBO>(BookConfigCollection coll)
		{
			List<BookConfigBO> list = new List<BookConfigBO>();
			
			foreach (BookConfigBO emp in coll)
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
				return  BookConfigMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new BookConfigBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new BookConfigBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public BookConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(BookConfigQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public BookConfigBO AddNew()
		{
			BookConfigBO entity = base.AddNewEntity() as BookConfigBO;
			
			return entity;
		}

		public BookConfigBO FindByPrimaryKey(System.Int32 bookConfigID)
		{
			return base.FindByPrimaryKey(bookConfigID) as BookConfigBO;
		}


		#region IEnumerable<BookConfigBO> Members

		IEnumerator<BookConfigBO> IEnumerable<BookConfigBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as BookConfigBO;
			}
		}

		#endregion
		
		private BookConfigQuery query;
	}


	/// <summary>
	/// Encapsulates the 'BookConfig' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("BookConfigBO ({BookConfigID})")]
	[Serializable]
	public partial class BookConfigBO : esBookConfigBO
	{
		public BookConfigBO()
		{

		}
	
		public BookConfigBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigMetadata.Meta();
			}
		}
		
		
		
		override protected esBookConfigQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BookConfigQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public BookConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(BookConfigQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private BookConfigQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class BookConfigQuery : esBookConfigQuery
	{
		public BookConfigQuery()
		{

		}		
		
		public BookConfigQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "BookConfigQuery";
        }
		
			
	}


	[Serializable]
	public partial class BookConfigMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BookConfigMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.BookConfigID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigMetadata.PropertyNames.BookConfigID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.IsCurrent, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = BookConfigMetadata.PropertyNames.IsCurrent;
			c.HasDefault = true;
			c.Default = @"((1))";
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.ShowPrices, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = BookConfigMetadata.PropertyNames.ShowPrices;
			c.HasDefault = true;
			c.Default = @"((1))";
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = BookConfigMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = BookConfigMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = BookConfigMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigMetadata.ColumnNames.LastUpdatedby, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = BookConfigMetadata.PropertyNames.LastUpdatedby;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public BookConfigMetadata Meta()
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BookConfigMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
