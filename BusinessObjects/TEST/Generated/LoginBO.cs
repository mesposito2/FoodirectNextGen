
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:14 PM
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
	/// Encapsulates the 'login' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(LoginBO))]	
	[XmlType("LoginBO")]
	public partial class LoginBO : esLoginBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new LoginBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("LoginCollection")]
	public partial class LoginCollection : esLoginCollection, IEnumerable<LoginBO>
	{

		
				
	}



	[Serializable]	
	public partial class LoginQuery : esLoginQuery
	{
		public LoginQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public LoginQuery(string joinAlias, out LoginQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "LoginQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(LoginQuery query)
		{
			return LoginQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator LoginQuery(string query)
		{
			return (LoginQuery)LoginQuery.SerializeHelper.FromXml(query, typeof(LoginQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esLoginBO : esEntity
	{
		public esLoginBO()
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
			LoginQuery query = new LoginQuery();
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
		/// Maps to login.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(LoginMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(LoginMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(LoginMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to login.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Type
		{
			get
			{
				return base.GetSystemInt16(LoginMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt16(LoginMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(LoginMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to login.internetid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Internetid
		{
			get
			{
				return base.GetSystemString(LoginMetadata.ColumnNames.Internetid);
			}
			
			set
			{
				if(base.SetSystemString(LoginMetadata.ColumnNames.Internetid, value))
				{
					OnPropertyChanged(LoginMetadata.PropertyNames.Internetid);
				}
			}
		}
		
		/// <summary>
		/// Maps to login.access
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Access
		{
			get
			{
				return base.GetSystemInt32(LoginMetadata.ColumnNames.Access);
			}
			
			set
			{
				if(base.SetSystemInt32(LoginMetadata.ColumnNames.Access, value))
				{
					OnPropertyChanged(LoginMetadata.PropertyNames.Access);
				}
			}
		}
		
		/// <summary>
		/// Maps to login.notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(LoginMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(LoginMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(LoginMetadata.PropertyNames.Notes);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return LoginMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public LoginQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new LoginQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(LoginQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(LoginQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((LoginQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private LoginQuery query;		
	}



	[Serializable]
	abstract public partial class esLoginCollection : esEntityCollection<LoginBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return LoginMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "LoginCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public LoginQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new LoginQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(LoginQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new LoginQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(LoginQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((LoginQuery)query);
		}

		#endregion
		
		private LoginQuery query;
	}



	[Serializable]
	abstract public partial class esLoginQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return LoginMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Type": return this.Type;
				case "Internetid": return this.Internetid;
				case "Access": return this.Access;
				case "Notes": return this.Notes;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, LoginMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, LoginMetadata.ColumnNames.Type, esSystemType.Int16); }
		} 
		
		public esQueryItem Internetid
		{
			get { return new esQueryItem(this, LoginMetadata.ColumnNames.Internetid, esSystemType.String); }
		} 
		
		public esQueryItem Access
		{
			get { return new esQueryItem(this, LoginMetadata.ColumnNames.Access, esSystemType.Int32); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, LoginMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class LoginBO : esLoginBO
	{

		
		
	}
	



	[Serializable]
	public partial class LoginMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected LoginMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(LoginMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = LoginMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(LoginMetadata.ColumnNames.Type, 1, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = LoginMetadata.PropertyNames.Type;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(LoginMetadata.ColumnNames.Internetid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = LoginMetadata.PropertyNames.Internetid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(LoginMetadata.ColumnNames.Access, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = LoginMetadata.PropertyNames.Access;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(LoginMetadata.ColumnNames.Notes, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = LoginMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public LoginMetadata Meta()
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
			 public const string Custid = "custid";
			 public const string Type = "type";
			 public const string Internetid = "internetid";
			 public const string Access = "access";
			 public const string Notes = "notes";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Type = "Type";
			 public const string Internetid = "Internetid";
			 public const string Access = "Access";
			 public const string Notes = "Notes";
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
			lock (typeof(LoginMetadata))
			{
				if(LoginMetadata.mapDelegates == null)
				{
					LoginMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (LoginMetadata.meta == null)
				{
					LoginMetadata.meta = new LoginMetadata();
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


				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Internetid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Access", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Notes", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "login";
				meta.Destination = "login";
				
				meta.spInsert = "proc_loginInsert";				
				meta.spUpdate = "proc_loginUpdate";		
				meta.spDelete = "proc_loginDelete";
				meta.spLoadAll = "proc_loginLoadAll";
				meta.spLoadByPrimaryKey = "proc_loginLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private LoginMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
