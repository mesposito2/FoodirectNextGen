
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
	/// Encapsulates the 'UserType' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(UserTypeBO))]	
	[XmlType("UserTypeBO")]
	public partial class UserTypeBO : esUserTypeBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new UserTypeBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int16 userTypeID)
		{
			var obj = new UserTypeBO();
			obj.UserTypeID = userTypeID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int16 userTypeID, esSqlAccessType sqlAccessType)
		{
			var obj = new UserTypeBO();
			obj.UserTypeID = userTypeID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("UserTypeCollection")]
	public partial class UserTypeCollection : esUserTypeCollection, IEnumerable<UserTypeBO>
	{
		public UserTypeBO FindByPrimaryKey(System.Int16 userTypeID)
		{
			return this.SingleOrDefault(e => e.UserTypeID == userTypeID);
		}

		
				
	}



	[Serializable]	
	public partial class UserTypeQuery : esUserTypeQuery
	{
		public UserTypeQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public UserTypeQuery(string joinAlias, out UserTypeQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "UserTypeQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(UserTypeQuery query)
		{
			return UserTypeQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator UserTypeQuery(string query)
		{
			return (UserTypeQuery)UserTypeQuery.SerializeHelper.FromXml(query, typeof(UserTypeQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esUserTypeBO : esEntity
	{
		public esUserTypeBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int16 userTypeID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userTypeID);
			else
				return LoadByPrimaryKeyStoredProcedure(userTypeID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int16 userTypeID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userTypeID);
			else
				return LoadByPrimaryKeyStoredProcedure(userTypeID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int16 userTypeID)
		{
			UserTypeQuery query = new UserTypeQuery();
			query.Where(query.UserTypeID == userTypeID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int16 userTypeID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserTypeID", userTypeID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to UserType.UserTypeID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? UserTypeID
		{
			get
			{
				return base.GetSystemInt16(UserTypeMetadata.ColumnNames.UserTypeID);
			}
			
			set
			{
				if(base.SetSystemInt16(UserTypeMetadata.ColumnNames.UserTypeID, value))
				{
					OnPropertyChanged(UserTypeMetadata.PropertyNames.UserTypeID);
				}
			}
		}
		
		/// <summary>
		/// Maps to UserType.UserType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserType
		{
			get
			{
				return base.GetSystemString(UserTypeMetadata.ColumnNames.UserType);
			}
			
			set
			{
				if(base.SetSystemString(UserTypeMetadata.ColumnNames.UserType, value))
				{
					OnPropertyChanged(UserTypeMetadata.PropertyNames.UserType);
				}
			}
		}
		
		/// <summary>
		/// Maps to UserType.UserTypeCD
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserTypeCD
		{
			get
			{
				return base.GetSystemString(UserTypeMetadata.ColumnNames.UserTypeCD);
			}
			
			set
			{
				if(base.SetSystemString(UserTypeMetadata.ColumnNames.UserTypeCD, value))
				{
					OnPropertyChanged(UserTypeMetadata.PropertyNames.UserTypeCD);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return UserTypeMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public UserTypeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UserTypeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UserTypeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(UserTypeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UserTypeQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private UserTypeQuery query;		
	}



	[Serializable]
	abstract public partial class esUserTypeCollection : esEntityCollection<UserTypeBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UserTypeMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "UserTypeCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public UserTypeQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UserTypeQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UserTypeQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UserTypeQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(UserTypeQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UserTypeQuery)query);
		}

		#endregion
		
		private UserTypeQuery query;
	}



	[Serializable]
	abstract public partial class esUserTypeQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UserTypeMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserTypeID": return this.UserTypeID;
				case "UserType": return this.UserType;
				case "UserTypeCD": return this.UserTypeCD;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserTypeID
		{
			get { return new esQueryItem(this, UserTypeMetadata.ColumnNames.UserTypeID, esSystemType.Int16); }
		} 
		
		public esQueryItem UserType
		{
			get { return new esQueryItem(this, UserTypeMetadata.ColumnNames.UserType, esSystemType.String); }
		} 
		
		public esQueryItem UserTypeCD
		{
			get { return new esQueryItem(this, UserTypeMetadata.ColumnNames.UserTypeCD, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class UserTypeBO : esUserTypeBO
	{

		#region UsersBOCollection - Zero To Many (FK_users_UserType)
		
		static public esPrefetchMap Prefetch_UsersBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.UserTypeBO.UsersBOCollection_Delegate,
					PropertyName = "UsersBOCollection",
					MyColumnName = "type",
					ParentColumnName = "UserTypeID",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void UsersBOCollection_Delegate(esPrefetchParameters data)
		{
			UserTypeQuery parent = new UserTypeQuery(data.NextAlias());

			UsersQuery me = data.You != null ? data.You as UsersQuery : new UsersQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.UserTypeID == me.Type);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_users_UserType
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBOCollection()
		{
		    if(this._UsersBOCollection != null && this._UsersBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="UsersBOCollection", EmitDefaultValue = false)]
		public UsersCollection UsersBOCollection
		{
			get
			{
				if(this._UsersBOCollection == null)
				{
					this._UsersBOCollection = new UsersCollection();
					this._UsersBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("UsersBOCollection", this._UsersBOCollection);
				
					if (this.UserTypeID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._UsersBOCollection.Query.Where(this._UsersBOCollection.Query.Type == this.UserTypeID);
							this._UsersBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._UsersBOCollection.fks.Add(UsersMetadata.ColumnNames.Type, this.UserTypeID);
					}
				}

				return this._UsersBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._UsersBOCollection != null) 
				{ 
					this.RemovePostSave("UsersBOCollection"); 
					this._UsersBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private UsersCollection _UsersBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "UsersBOCollection":
					coll = this.UsersBOCollection;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "UsersBOCollection", typeof(UsersCollection), new UsersBO()));
		
			return props;
		}
		
	}
	



	[Serializable]
	public partial class UserTypeMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UserTypeMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UserTypeMetadata.ColumnNames.UserTypeID, 0, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = UserTypeMetadata.PropertyNames.UserTypeID;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 5;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UserTypeMetadata.ColumnNames.UserType, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = UserTypeMetadata.PropertyNames.UserType;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UserTypeMetadata.ColumnNames.UserTypeCD, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UserTypeMetadata.PropertyNames.UserTypeCD;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public UserTypeMetadata Meta()
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
			 public const string UserTypeID = "UserTypeID";
			 public const string UserType = "UserType";
			 public const string UserTypeCD = "UserTypeCD";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserTypeID = "UserTypeID";
			 public const string UserType = "UserType";
			 public const string UserTypeCD = "UserTypeCD";
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
			lock (typeof(UserTypeMetadata))
			{
				if(UserTypeMetadata.mapDelegates == null)
				{
					UserTypeMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (UserTypeMetadata.meta == null)
				{
					UserTypeMetadata.meta = new UserTypeMetadata();
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


				meta.AddTypeMap("UserTypeID", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("UserType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("UserTypeCD", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "UserType";
				meta.Destination = "UserType";
				
				meta.spInsert = "proc_UserTypeInsert";				
				meta.spUpdate = "proc_UserTypeUpdate";		
				meta.spDelete = "proc_UserTypeDelete";
				meta.spLoadAll = "proc_UserTypeLoadAll";
				meta.spLoadByPrimaryKey = "proc_UserTypeLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UserTypeMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
