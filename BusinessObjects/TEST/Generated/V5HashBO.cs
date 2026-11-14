
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
	/// Encapsulates the 'V5Hash' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5HashBO))]	
	[XmlType("V5HashBO")]
	public partial class V5HashBO : esV5HashBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5HashBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 hashItemID)
		{
			var obj = new V5HashBO();
			obj.HashItemID = hashItemID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 hashItemID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5HashBO();
			obj.HashItemID = hashItemID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5HashCollection")]
	public partial class V5HashCollection : esV5HashCollection, IEnumerable<V5HashBO>
	{
		public V5HashBO FindByPrimaryKey(System.Int32 hashItemID)
		{
			return this.SingleOrDefault(e => e.HashItemID == hashItemID);
		}

		
				
	}



	[Serializable]	
	public partial class V5HashQuery : esV5HashQuery
	{
		public V5HashQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5HashQuery(string joinAlias, out V5HashQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5HashQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5HashQuery query)
		{
			return V5HashQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5HashQuery(string query)
		{
			return (V5HashQuery)V5HashQuery.SerializeHelper.FromXml(query, typeof(V5HashQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5HashBO : esEntity
	{
		public esV5HashBO()
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
			V5HashQuery query = new V5HashQuery();
			query.Where(query.HashItemID == hashItemID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 hashItemID)
		{
			esParameters parms = new esParameters();
			parms.Add("HashItemID", hashItemID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to V5Hash.HashItemID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(V5HashMetadata.PropertyNames.HashItemID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashGUID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(V5HashMetadata.PropertyNames.HashGUID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashKey
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(V5HashMetadata.PropertyNames.HashKey);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.HashValue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(V5HashMetadata.PropertyNames.HashValue);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Hash.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(V5HashMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5HashMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5HashQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5HashQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5HashQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5HashQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5HashQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5HashQuery query;		
	}



	[Serializable]
	abstract public partial class esV5HashCollection : esEntityCollection<V5HashBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5HashMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5HashCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5HashQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5HashQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5HashQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(V5HashQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5HashQuery)query);
		}

		#endregion
		
		private V5HashQuery query;
	}



	[Serializable]
	abstract public partial class esV5HashQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5HashMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "HashItemID": return this.HashItemID;
				case "HashGUID": return this.HashGUID;
				case "HashKey": return this.HashKey;
				case "HashValue": return this.HashValue;
				case "CreateDate": return this.CreateDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem HashItemID
		{
			get { return new esQueryItem(this, V5HashMetadata.ColumnNames.HashItemID, esSystemType.Int32); }
		} 
		
		public esQueryItem HashGUID
		{
			get { return new esQueryItem(this, V5HashMetadata.ColumnNames.HashGUID, esSystemType.String); }
		} 
		
		public esQueryItem HashKey
		{
			get { return new esQueryItem(this, V5HashMetadata.ColumnNames.HashKey, esSystemType.String); }
		} 
		
		public esQueryItem HashValue
		{
			get { return new esQueryItem(this, V5HashMetadata.ColumnNames.HashValue, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, V5HashMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class V5HashBO : esV5HashBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5HashMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5HashMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashItemID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5HashMetadata.PropertyNames.HashItemID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashGUID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashGUID;
			c.CharacterMaxLength = 500;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashKey, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashKey;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.HashValue, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5HashMetadata.PropertyNames.HashValue;
			c.CharacterMaxLength = 2147483647;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5HashMetadata.ColumnNames.CreateDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5HashMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5HashMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5HashMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
