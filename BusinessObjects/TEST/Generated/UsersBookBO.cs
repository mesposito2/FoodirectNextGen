
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:16 PM
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
	/// Encapsulates the 'UsersBook' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(UsersBookBO))]	
	[XmlType("UsersBookBO")]
	public partial class UsersBookBO : esUsersBookBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new UsersBookBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("UsersBookCollection")]
	public partial class UsersBookCollection : esUsersBookCollection, IEnumerable<UsersBookBO>
	{

		
				
	}



	[Serializable]	
	public partial class UsersBookQuery : esUsersBookQuery
	{
		public UsersBookQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public UsersBookQuery(string joinAlias, out UsersBookQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "UsersBookQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(UsersBookQuery query)
		{
			return UsersBookQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator UsersBookQuery(string query)
		{
			return (UsersBookQuery)UsersBookQuery.SerializeHelper.FromXml(query, typeof(UsersBookQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esUsersBookBO : esEntity
	{
		public esUsersBookBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey()
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, )
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		private bool LoadByPrimaryKeyDynamic()
		{
			UsersBookQuery query = new UsersBookQuery();
			query.Where();
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure()
		{
			esParameters parms = new esParameters();

			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to UsersBook.UsersBookID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UsersBookID
		{
			get
			{
				return base.GetSystemInt32(UsersBookMetadata.ColumnNames.UsersBookID);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersBookMetadata.ColumnNames.UsersBookID, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.UsersBookID);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.custID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.CustID, value))
				{
					this._UsersBO = null;
					this.OnPropertyChanged("UsersBO");
					OnPropertyChanged(UsersBookMetadata.PropertyNames.CustID);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.PDFPartialURL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PDFPartialURL
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.PDFPartialURL);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.PDFPartialURL, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.PDFPartialURL);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.PDFFile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PDFFile
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.PDFFile);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.PDFFile, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.PDFFile);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.GenerateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? GenerateDate
		{
			get
			{
				return base.GetSystemDateTime(UsersBookMetadata.ColumnNames.GenerateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(UsersBookMetadata.ColumnNames.GenerateDate, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.GenerateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.GenerateStatusCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String GenerateStatusCode
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.GenerateStatusCode);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.GenerateStatusCode, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.GenerateStatusCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.GenerateMessage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String GenerateMessage
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.GenerateMessage);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.GenerateMessage, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.GenerateMessage);
				}
			}
		}
		
		/// <summary>
		/// Maps to UsersBook.GenerateURL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String GenerateURL
		{
			get
			{
				return base.GetSystemString(UsersBookMetadata.ColumnNames.GenerateURL);
			}
			
			set
			{
				if(base.SetSystemString(UsersBookMetadata.ColumnNames.GenerateURL, value))
				{
					OnPropertyChanged(UsersBookMetadata.PropertyNames.GenerateURL);
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
				return UsersBookMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public UsersBookQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersBookQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsersBookQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(UsersBookQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UsersBookQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private UsersBookQuery query;		
	}



	[Serializable]
	abstract public partial class esUsersBookCollection : esEntityCollection<UsersBookBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UsersBookMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "UsersBookCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public UsersBookQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersBookQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsersBookQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UsersBookQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(UsersBookQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UsersBookQuery)query);
		}

		#endregion
		
		private UsersBookQuery query;
	}



	[Serializable]
	abstract public partial class esUsersBookQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UsersBookMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UsersBookID": return this.UsersBookID;
				case "CustID": return this.CustID;
				case "PDFPartialURL": return this.PDFPartialURL;
				case "PDFFile": return this.PDFFile;
				case "GenerateDate": return this.GenerateDate;
				case "GenerateStatusCode": return this.GenerateStatusCode;
				case "GenerateMessage": return this.GenerateMessage;
				case "GenerateURL": return this.GenerateURL;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UsersBookID
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.UsersBookID, esSystemType.Int32); }
		} 
		
		public esQueryItem CustID
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.CustID, esSystemType.String); }
		} 
		
		public esQueryItem PDFPartialURL
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.PDFPartialURL, esSystemType.String); }
		} 
		
		public esQueryItem PDFFile
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.PDFFile, esSystemType.String); }
		} 
		
		public esQueryItem GenerateDate
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.GenerateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem GenerateStatusCode
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.GenerateStatusCode, esSystemType.String); }
		} 
		
		public esQueryItem GenerateMessage
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.GenerateMessage, esSystemType.String); }
		} 
		
		public esQueryItem GenerateURL
		{
			get { return new esQueryItem(this, UsersBookMetadata.ColumnNames.GenerateURL, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class UsersBookBO : esUsersBookBO
	{

		
		#region UsersBO - Many To One (FK_UsersBook_CustID)
		
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
	public partial class UsersBookMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UsersBookMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.UsersBookID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersBookMetadata.PropertyNames.UsersBookID;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.PDFPartialURL, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.PDFPartialURL;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.PDFFile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.PDFFile;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.GenerateDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = UsersBookMetadata.PropertyNames.GenerateDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.GenerateStatusCode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.GenerateStatusCode;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.GenerateMessage, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.GenerateMessage;
			c.CharacterMaxLength = 1000;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersBookMetadata.ColumnNames.GenerateURL, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersBookMetadata.PropertyNames.GenerateURL;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public UsersBookMetadata Meta()
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
			 public const string UsersBookID = "UsersBookID";
			 public const string CustID = "custID";
			 public const string PDFPartialURL = "PDFPartialURL";
			 public const string PDFFile = "PDFFile";
			 public const string GenerateDate = "GenerateDate";
			 public const string GenerateStatusCode = "GenerateStatusCode";
			 public const string GenerateMessage = "GenerateMessage";
			 public const string GenerateURL = "GenerateURL";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UsersBookID = "UsersBookID";
			 public const string CustID = "CustID";
			 public const string PDFPartialURL = "PDFPartialURL";
			 public const string PDFFile = "PDFFile";
			 public const string GenerateDate = "GenerateDate";
			 public const string GenerateStatusCode = "GenerateStatusCode";
			 public const string GenerateMessage = "GenerateMessage";
			 public const string GenerateURL = "GenerateURL";
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
			lock (typeof(UsersBookMetadata))
			{
				if(UsersBookMetadata.mapDelegates == null)
				{
					UsersBookMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (UsersBookMetadata.meta == null)
				{
					UsersBookMetadata.meta = new UsersBookMetadata();
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


				meta.AddTypeMap("UsersBookID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PDFPartialURL", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("PDFFile", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("GenerateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("GenerateStatusCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("GenerateMessage", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("GenerateURL", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "UsersBook";
				meta.Destination = "UsersBook";
				
				meta.spInsert = "proc_UsersBookInsert";				
				meta.spUpdate = "proc_UsersBookUpdate";		
				meta.spDelete = "proc_UsersBookDelete";
				meta.spLoadAll = "proc_UsersBookLoadAll";
				meta.spLoadByPrimaryKey = "proc_UsersBookLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UsersBookMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
