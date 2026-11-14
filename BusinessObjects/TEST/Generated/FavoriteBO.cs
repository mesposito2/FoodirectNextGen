
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
	/// Encapsulates the 'Favorite' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(FavoriteBO))]	
	[XmlType("FavoriteBO")]
	public partial class FavoriteBO : esFavoriteBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new FavoriteBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 favoriteID)
		{
			var obj = new FavoriteBO();
			obj.FavoriteID = favoriteID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 favoriteID, esSqlAccessType sqlAccessType)
		{
			var obj = new FavoriteBO();
			obj.FavoriteID = favoriteID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("FavoriteCollection")]
	public partial class FavoriteCollection : esFavoriteCollection, IEnumerable<FavoriteBO>
	{
		public FavoriteBO FindByPrimaryKey(System.Int32 favoriteID)
		{
			return this.SingleOrDefault(e => e.FavoriteID == favoriteID);
		}

		
				
	}



	[Serializable]	
	public partial class FavoriteQuery : esFavoriteQuery
	{
		public FavoriteQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public FavoriteQuery(string joinAlias, out FavoriteQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "FavoriteQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(FavoriteQuery query)
		{
			return FavoriteQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator FavoriteQuery(string query)
		{
			return (FavoriteQuery)FavoriteQuery.SerializeHelper.FromXml(query, typeof(FavoriteQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esFavoriteBO : esEntity
	{
		public esFavoriteBO()
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
			FavoriteQuery query = new FavoriteQuery();
			query.Where(query.FavoriteID == favoriteID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 favoriteID)
		{
			esParameters parms = new esParameters();
			parms.Add("FavoriteID", favoriteID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Favorite.FavoriteID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.FavoriteID);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.custID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._UsersBO = null;
					this.OnPropertyChanged("UsersBO");
					OnPropertyChanged(FavoriteMetadata.PropertyNames.CustID);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.productCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.ProductCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.LastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to Favorite.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(FavoriteMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		internal protected UsersBO _UsersBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return FavoriteMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public FavoriteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FavoriteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FavoriteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(FavoriteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FavoriteQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private FavoriteQuery query;		
	}



	[Serializable]
	abstract public partial class esFavoriteCollection : esEntityCollection<FavoriteBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FavoriteMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "FavoriteCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public FavoriteQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FavoriteQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FavoriteQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(FavoriteQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FavoriteQuery)query);
		}

		#endregion
		
		private FavoriteQuery query;
	}



	[Serializable]
	abstract public partial class esFavoriteQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FavoriteMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "FavoriteID": return this.FavoriteID;
				case "CustID": return this.CustID;
				case "ProductCode": return this.ProductCode;
				case "LastUpdate": return this.LastUpdate;
				case "CreatedBy": return this.CreatedBy;
				case "LastUpdatedBy": return this.LastUpdatedBy;
				case "CreateDate": return this.CreateDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem FavoriteID
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.FavoriteID, esSystemType.Int32); }
		} 
		
		public esQueryItem CustID
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.CustID, esSystemType.String); }
		} 
		
		public esQueryItem ProductCode
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.ProductCode, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, FavoriteMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class FavoriteBO : esFavoriteBO
	{

		
		#region UsersBO - Many To One (FK_favorite_custid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBO()
		{
		    return this._UsersBO != null ? true : false;
		}
		

		[DataMember(Name="UsersBO", EmitDefaultValue = false)]
					
		public UsersBO UsersBO
		{
			get
			{
                if (this._UsersBO == null)
                {
                    this._UsersBO = new UsersBO();
                    this._UsersBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("UsersBO", this._UsersBO);

					if(this._UsersBO == null && CustID != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._UsersBO.Query.Where(this._UsersBO.Query.Custid == this.CustID);
							this._UsersBO.Query.Load();
                        }
                    }
                }

				return this._UsersBO;
			}
			
			set
			{
				this.RemovePreSave("UsersBO");
				

				if(value == null)
				{
					this.CustID = null;
					this._UsersBO = null;
				}
				else
				{
					this.CustID = value.Custid;
					this._UsersBO = value;
					this.SetPreSave("UsersBO", this._UsersBO);
				}
				
			}
		}
		#endregion
		

		
		
	}
	



	[Serializable]
	public partial class FavoriteMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FavoriteMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.FavoriteID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FavoriteMetadata.PropertyNames.FavoriteID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.ProductCode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.ProductCode;
			c.CharacterMaxLength = 6;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.LastUpdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FavoriteMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CreatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.LastUpdatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = FavoriteMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FavoriteMetadata.ColumnNames.CreateDate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FavoriteMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public FavoriteMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FavoriteMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
