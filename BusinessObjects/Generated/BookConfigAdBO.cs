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
	abstract public class esBookConfigAdCollection : esEntityCollection
	{
		public esBookConfigAdCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "BookConfigAdCollection";
		}

		#region Query Logic
		protected void InitQuery(esBookConfigAdQuery query)
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
			this.InitQuery(query as esBookConfigAdQuery);
		}
		#endregion
		
		virtual public BookConfigAdBO DetachEntity(BookConfigAdBO entity)
		{
			return base.DetachEntity(entity) as BookConfigAdBO;
		}
		
		virtual public BookConfigAdBO AttachEntity(BookConfigAdBO entity)
		{
			return base.AttachEntity(entity) as BookConfigAdBO;
		}
		
		virtual public void Combine(BookConfigAdCollection collection)
		{
			base.Combine(collection);
		}
		
		new public BookConfigAdBO this[int index]
		{
			get
			{
				return base[index] as BookConfigAdBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(BookConfigAdBO);
		}
	}



	[Serializable]
	abstract public class esBookConfigAdBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esBookConfigAdQuery GetDynamicQuery()
		{
			return null;
		}

		public esBookConfigAdBO()
		{

		}

		public esBookConfigAdBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 bookConfigAdID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bookConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(bookConfigAdID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 bookConfigAdID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bookConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(bookConfigAdID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 bookConfigAdID)
		{
			esBookConfigAdQuery query = this.GetDynamicQuery();
			query.Where(query.BookConfigAdID == bookConfigAdID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 bookConfigAdID)
		{
			esParameters parms = new esParameters();
			parms.Add("BookConfigAdID",bookConfigAdID);
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
						case "BookConfigAdID": this.str.BookConfigAdID = (string)value; break;							
						case "BookConfigID": this.str.BookConfigID = (string)value; break;							
						case "PageNum": this.str.PageNum = (string)value; break;							
						case "AdID": this.str.AdID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "BookConfigAdID":
						
							if (value == null || value is System.Int32)
								this.BookConfigAdID = (System.Int32?)value;
							break;
						
						case "BookConfigID":
						
							if (value == null || value is System.Int32)
								this.BookConfigID = (System.Int32?)value;
							break;
						
						case "PageNum":
						
							if (value == null || value is System.Int32)
								this.PageNum = (System.Int32?)value;
							break;
						
						case "AdID":
						
							if (value == null || value is System.Int32)
								this.AdID = (System.Int32?)value;
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
		/// Maps to BookConfigAd.BookConfigAdID
		/// </summary>
		virtual public System.Int32? BookConfigAdID
		{
			get
			{
				return base.GetSystemInt32(BookConfigAdMetadata.ColumnNames.BookConfigAdID);
			}
			
			set
			{
				if(base.SetSystemInt32(BookConfigAdMetadata.ColumnNames.BookConfigAdID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigAdMetadata.PropertyNames.BookConfigAdID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.BookConfigID
		/// </summary>
		virtual public System.Int32? BookConfigID
		{
			get
			{
				return base.GetSystemInt32(BookConfigAdMetadata.ColumnNames.BookConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(BookConfigAdMetadata.ColumnNames.BookConfigID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigAdMetadata.PropertyNames.BookConfigID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.PageNum
		/// </summary>
		virtual public System.Int32? PageNum
		{
			get
			{
				return base.GetSystemInt32(BookConfigAdMetadata.ColumnNames.PageNum);
			}
			
			set
			{
				if(base.SetSystemInt32(BookConfigAdMetadata.ColumnNames.PageNum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigAdMetadata.PropertyNames.PageNum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.AdID
		/// </summary>
		virtual public System.Int32? AdID
		{
			get
			{
				return base.GetSystemInt32(BookConfigAdMetadata.ColumnNames.AdID);
			}
			
			set
			{
				if(base.SetSystemInt32(BookConfigAdMetadata.ColumnNames.AdID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BookConfigAdMetadata.PropertyNames.AdID));
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
			public esStrings(esBookConfigAdBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String BookConfigAdID
			{
				get
				{
					System.Int32? data = entity.BookConfigAdID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BookConfigAdID = null;
					else entity.BookConfigAdID = Convert.ToInt32(value);
				}
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
				
			public System.String PageNum
			{
				get
				{
					System.Int32? data = entity.PageNum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PageNum = null;
					else entity.PageNum = Convert.ToInt32(value);
				}
			}
				
			public System.String AdID
			{
				get
				{
					System.Int32? data = entity.AdID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdID = null;
					else entity.AdID = Convert.ToInt32(value);
				}
			}
			

			private esBookConfigAdBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esBookConfigAdQuery query)
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
				throw new Exception("esBookConfigAdBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esBookConfigAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigAdMetadata.Meta();
			}
		}	
		

		public esQueryItem BookConfigAdID
		{
			get
			{
				return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.BookConfigAdID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem BookConfigID
		{
			get
			{
				return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.BookConfigID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PageNum
		{
			get
			{
				return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.PageNum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem AdID
		{
			get
			{
				return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.AdID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("BookConfigAdCollection")]
	public partial class BookConfigAdCollection : esBookConfigAdCollection, IEnumerable<BookConfigAdBO>
	{
		public BookConfigAdCollection()
		{

		}
		
		public static implicit operator List<BookConfigAdBO>(BookConfigAdCollection coll)
		{
			List<BookConfigAdBO> list = new List<BookConfigAdBO>();
			
			foreach (BookConfigAdBO emp in coll)
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
				return  BookConfigAdMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BookConfigAdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new BookConfigAdBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new BookConfigAdBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public BookConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigAdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(BookConfigAdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public BookConfigAdBO AddNew()
		{
			BookConfigAdBO entity = base.AddNewEntity() as BookConfigAdBO;
			
			return entity;
		}

		public BookConfigAdBO FindByPrimaryKey(System.Int32 bookConfigAdID)
		{
			return base.FindByPrimaryKey(bookConfigAdID) as BookConfigAdBO;
		}


		#region IEnumerable<BookConfigAdBO> Members

		IEnumerator<BookConfigAdBO> IEnumerable<BookConfigAdBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as BookConfigAdBO;
			}
		}

		#endregion
		
		private BookConfigAdQuery query;
	}


	/// <summary>
	/// Encapsulates the 'BookConfigAd' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("BookConfigAdBO ({BookConfigAdID})")]
	[Serializable]
	public partial class BookConfigAdBO : esBookConfigAdBO
	{
		public BookConfigAdBO()
		{

		}
	
		public BookConfigAdBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigAdMetadata.Meta();
			}
		}
		
		
		
		override protected esBookConfigAdQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BookConfigAdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public BookConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigAdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(BookConfigAdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private BookConfigAdQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class BookConfigAdQuery : esBookConfigAdQuery
	{
		public BookConfigAdQuery()
		{

		}		
		
		public BookConfigAdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "BookConfigAdQuery";
        }
		
			
	}


	[Serializable]
	public partial class BookConfigAdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BookConfigAdMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.BookConfigAdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.BookConfigAdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.BookConfigID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.BookConfigID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.PageNum, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.PageNum;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.AdID, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.AdID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public BookConfigAdMetadata Meta()
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
			 public const string BookConfigAdID = "BookConfigAdID";
			 public const string BookConfigID = "BookConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string BookConfigAdID = "BookConfigAdID";
			 public const string BookConfigID = "BookConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
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
			lock (typeof(BookConfigAdMetadata))
			{
				if(BookConfigAdMetadata.mapDelegates == null)
				{
					BookConfigAdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BookConfigAdMetadata.meta == null)
				{
					BookConfigAdMetadata.meta = new BookConfigAdMetadata();
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
				

				meta.AddTypeMap("BookConfigAdID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("BookConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PageNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "BookConfigAd";
				meta.Destination = "BookConfigAd";
				
				meta.spInsert = "proc_BookConfigAdInsert";				
				meta.spUpdate = "proc_BookConfigAdUpdate";		
				meta.spDelete = "proc_BookConfigAdDelete";
				meta.spLoadAll = "proc_BookConfigAdLoadAll";
				meta.spLoadByPrimaryKey = "proc_BookConfigAdLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BookConfigAdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
