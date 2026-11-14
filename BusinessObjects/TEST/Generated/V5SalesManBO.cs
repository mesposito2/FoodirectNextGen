
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
	/// Encapsulates the 'v5SalesMan' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5SalesManBO))]	
	[XmlType("V5SalesManBO")]
	public partial class V5SalesManBO : esV5SalesManBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5SalesManBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 salesManID)
		{
			var obj = new V5SalesManBO();
			obj.SalesManID = salesManID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 salesManID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5SalesManBO();
			obj.SalesManID = salesManID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5SalesManCollection")]
	public partial class V5SalesManCollection : esV5SalesManCollection, IEnumerable<V5SalesManBO>
	{
		public V5SalesManBO FindByPrimaryKey(System.Int32 salesManID)
		{
			return this.SingleOrDefault(e => e.SalesManID == salesManID);
		}

		
				
	}



	[Serializable]	
	public partial class V5SalesManQuery : esV5SalesManQuery
	{
		public V5SalesManQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5SalesManQuery(string joinAlias, out V5SalesManQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5SalesManQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5SalesManQuery query)
		{
			return V5SalesManQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5SalesManQuery(string query)
		{
			return (V5SalesManQuery)V5SalesManQuery.SerializeHelper.FromXml(query, typeof(V5SalesManQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5SalesManBO : esEntity
	{
		public esV5SalesManBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesManID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesManID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesManID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesManID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesManID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesManID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesManID)
		{
			V5SalesManQuery query = new V5SalesManQuery();
			query.Where(query.SalesManID == salesManID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesManID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesManID", salesManID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to v5SalesMan.SalesManID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalesManID
		{
			get
			{
				return base.GetSystemInt32(V5SalesManMetadata.ColumnNames.SalesManID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5SalesManMetadata.ColumnNames.SalesManID, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.SalesManID);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Initial
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Initial
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Initial);
			}
			
			set
			{
				if(base.SetSystemString(V5SalesManMetadata.ColumnNames.Initial, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.Initial);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(V5SalesManMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.Name);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(V5SalesManMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.Email);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.LastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5SalesManMetadata.ColumnNames.LastUpdatedBy, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(V5SalesManMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5SalesManMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5SalesManMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.CreatedByDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5SalesManMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5SalesManMetadata.ColumnNames.CreatedByDate, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.CreatedByDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(V5SalesManMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5SalesManMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(V5SalesManMetadata.PropertyNames.Active);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5SalesManMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5SalesManQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5SalesManQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5SalesManQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5SalesManQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5SalesManQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5SalesManQuery query;		
	}



	[Serializable]
	abstract public partial class esV5SalesManCollection : esEntityCollection<V5SalesManBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5SalesManMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5SalesManCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5SalesManQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5SalesManQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5SalesManQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5SalesManQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5SalesManQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5SalesManQuery)query);
		}

		#endregion
		
		private V5SalesManQuery query;
	}



	[Serializable]
	abstract public partial class esV5SalesManQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5SalesManMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SalesManID": return this.SalesManID;
				case "Initial": return this.Initial;
				case "Name": return this.Name;
				case "Email": return this.Email;
				case "LastUpdatedBy": return this.LastUpdatedBy;
				case "LastUpdate": return this.LastUpdate;
				case "CreatedBy": return this.CreatedBy;
				case "CreatedByDate": return this.CreatedByDate;
				case "Active": return this.Active;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SalesManID
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.SalesManID, esSystemType.Int32); }
		} 
		
		public esQueryItem Initial
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Initial, esSystemType.String); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem CreatedByDate
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Active, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class V5SalesManBO : esV5SalesManBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5SalesManMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5SalesManMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.SalesManID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5SalesManMetadata.PropertyNames.SalesManID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Initial, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Initial;
			c.CharacterMaxLength = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Name, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Email, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.LastUpdatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.LastUpdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5SalesManMetadata.PropertyNames.LastUpdate;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.CreatedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.CreatedByDate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5SalesManMetadata.PropertyNames.CreatedByDate;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5SalesManMetadata Meta()
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
			 public const string SalesManID = "SalesManID";
			 public const string Initial = "Initial";
			 public const string Name = "Name";
			 public const string Email = "Email";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string Active = "active";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesManID = "SalesManID";
			 public const string Initial = "Initial";
			 public const string Name = "Name";
			 public const string Email = "Email";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string Active = "Active";
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
			lock (typeof(V5SalesManMetadata))
			{
				if(V5SalesManMetadata.mapDelegates == null)
				{
					V5SalesManMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5SalesManMetadata.meta == null)
				{
					V5SalesManMetadata.meta = new V5SalesManMetadata();
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


				meta.AddTypeMap("SalesManID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Initial", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Name", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "v5SalesMan";
				meta.Destination = "v5SalesMan";
				
				meta.spInsert = "proc_v5SalesManInsert";				
				meta.spUpdate = "proc_v5SalesManUpdate";		
				meta.spDelete = "proc_v5SalesManDelete";
				meta.spLoadAll = "proc_v5SalesManLoadAll";
				meta.spLoadByPrimaryKey = "proc_v5SalesManLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5SalesManMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
