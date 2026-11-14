
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
	/// Encapsulates the 'BookConfigAd' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(BookConfigAdBO))]	
	[XmlType("BookConfigAdBO")]
	public partial class BookConfigAdBO : esBookConfigAdBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new BookConfigAdBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 bookConfigAdID)
		{
			var obj = new BookConfigAdBO();
			obj.BookConfigAdID = bookConfigAdID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 bookConfigAdID, esSqlAccessType sqlAccessType)
		{
			var obj = new BookConfigAdBO();
			obj.BookConfigAdID = bookConfigAdID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("BookConfigAdCollection")]
	public partial class BookConfigAdCollection : esBookConfigAdCollection, IEnumerable<BookConfigAdBO>
	{
		public BookConfigAdBO FindByPrimaryKey(System.Int32 bookConfigAdID)
		{
			return this.SingleOrDefault(e => e.BookConfigAdID == bookConfigAdID);
		}

		
				
	}



	[Serializable]	
	public partial class BookConfigAdQuery : esBookConfigAdQuery
	{
		public BookConfigAdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public BookConfigAdQuery(string joinAlias, out BookConfigAdQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "BookConfigAdQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(BookConfigAdQuery query)
		{
			return BookConfigAdQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator BookConfigAdQuery(string query)
		{
			return (BookConfigAdQuery)BookConfigAdQuery.SerializeHelper.FromXml(query, typeof(BookConfigAdQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esBookConfigAdBO : esEntity
	{
		public esBookConfigAdBO()
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
			BookConfigAdQuery query = new BookConfigAdQuery();
			query.Where(query.BookConfigAdID == bookConfigAdID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 bookConfigAdID)
		{
			esParameters parms = new esParameters();
			parms.Add("BookConfigAdID", bookConfigAdID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to BookConfigAd.BookConfigAdID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(BookConfigAdMetadata.PropertyNames.BookConfigAdID);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.BookConfigID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._BookConfigBO = null;
					this.OnPropertyChanged("BookConfigBO");
					OnPropertyChanged(BookConfigAdMetadata.PropertyNames.BookConfigID);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.PageNum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(BookConfigAdMetadata.PropertyNames.PageNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to BookConfigAd.AdID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._AdBO = null;
					this.OnPropertyChanged("AdBO");
					OnPropertyChanged(BookConfigAdMetadata.PropertyNames.AdID);
				}
			}
		}
		
		internal protected AdBO _AdBO;
		internal protected BookConfigBO _BookConfigBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return BookConfigAdMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public BookConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigAdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BookConfigAdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(BookConfigAdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BookConfigAdQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private BookConfigAdQuery query;		
	}



	[Serializable]
	abstract public partial class esBookConfigAdCollection : esEntityCollection<BookConfigAdBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigAdMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "BookConfigAdCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public BookConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BookConfigAdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BookConfigAdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(BookConfigAdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BookConfigAdQuery)query);
		}

		#endregion
		
		private BookConfigAdQuery query;
	}



	[Serializable]
	abstract public partial class esBookConfigAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BookConfigAdMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "BookConfigAdID": return this.BookConfigAdID;
				case "BookConfigID": return this.BookConfigID;
				case "PageNum": return this.PageNum;
				case "AdID": return this.AdID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem BookConfigAdID
		{
			get { return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.BookConfigAdID, esSystemType.Int32); }
		} 
		
		public esQueryItem BookConfigID
		{
			get { return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.BookConfigID, esSystemType.Int32); }
		} 
		
		public esQueryItem PageNum
		{
			get { return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.PageNum, esSystemType.Int32); }
		} 
		
		public esQueryItem AdID
		{
			get { return new esQueryItem(this, BookConfigAdMetadata.ColumnNames.AdID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class BookConfigAdBO : esBookConfigAdBO
	{

		
		#region AdBO - Many To One (FK_BookConfigAd_AdID)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeAdBO()
		{
		    return this._AdBO != null ? true : false;
		}
		

		[DataMember(Name="AdBO", EmitDefaultValue = false)]
					
		public AdBO AdBO
		{
			get
			{
                if (this._AdBO == null)
                {
                    this._AdBO = new AdBO();
                    this._AdBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("AdBO", this._AdBO);

					if(this._AdBO == null && AdID != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._AdBO.Query.Where(this._AdBO.Query.AdID == this.AdID);
							this._AdBO.Query.Load();
                        }
                    }
                }

				return this._AdBO;
			}
			
			set
			{
				this.RemovePreSave("AdBO");
				

				if(value == null)
				{
					this.AdID = null;
					this._AdBO = null;
				}
				else
				{
					this.AdID = value.AdID;
					this._AdBO = value;
					this.SetPreSave("AdBO", this._AdBO);
				}
				
			}
		}
		#endregion
		

		
		#region BookConfigBO - Many To One (FK_BookConfigAd_BookConfigID)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeBookConfigBO()
		{
		    return this._BookConfigBO != null ? true : false;
		}
		

		[DataMember(Name="BookConfigBO", EmitDefaultValue = false)]
					
		public BookConfigBO BookConfigBO
		{
			get
			{
                if (this._BookConfigBO == null)
                {
                    this._BookConfigBO = new BookConfigBO();
                    this._BookConfigBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("BookConfigBO", this._BookConfigBO);

					if(this._BookConfigBO == null && BookConfigID != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._BookConfigBO.Query.Where(this._BookConfigBO.Query.BookConfigID == this.BookConfigID);
							this._BookConfigBO.Query.Load();
                        }
                    }
                }

				return this._BookConfigBO;
			}
			
			set
			{
				this.RemovePreSave("BookConfigBO");
				

				if(value == null)
				{
					this.BookConfigID = null;
					this._BookConfigBO = null;
				}
				else
				{
					this.BookConfigID = value.BookConfigID;
					this._BookConfigBO = value;
					this.SetPreSave("BookConfigBO", this._BookConfigBO);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._AdBO != null)
			{
				this.AdID = this._AdBO.AdID;
			}
			if(!this.es.IsDeleted && this._BookConfigBO != null)
			{
				this.BookConfigID = this._BookConfigBO.BookConfigID;
			}
		}
		
	}
	



	[Serializable]
	public partial class BookConfigAdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BookConfigAdMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.BookConfigAdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.BookConfigAdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.BookConfigID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.BookConfigID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.PageNum, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.PageNum;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BookConfigAdMetadata.ColumnNames.AdID, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BookConfigAdMetadata.PropertyNames.AdID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public BookConfigAdMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BookConfigAdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
