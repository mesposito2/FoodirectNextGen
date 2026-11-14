
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:17 PM
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
	/// Encapsulates the 'wta_alerts' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaAlertsBO))]	
	[XmlType("WtaAlertsBO")]
	public partial class WtaAlertsBO : esWtaAlertsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaAlertsBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaAlertsCollection")]
	public partial class WtaAlertsCollection : esWtaAlertsCollection, IEnumerable<WtaAlertsBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaAlertsQuery : esWtaAlertsQuery
	{
		public WtaAlertsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaAlertsQuery(string joinAlias, out WtaAlertsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaAlertsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaAlertsQuery query)
		{
			return WtaAlertsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaAlertsQuery(string query)
		{
			return (WtaAlertsQuery)WtaAlertsQuery.SerializeHelper.FromXml(query, typeof(WtaAlertsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaAlertsBO : esEntity
	{
		public esWtaAlertsBO()
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
			WtaAlertsQuery query = new WtaAlertsQuery();
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
		/// Maps to wta_alerts.aid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Aid
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.Aid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.Aid, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Aid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaAlertsMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaAlertsMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaAlertsMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaAlertsMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaAlertsMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaAlertsMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.atype
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Atype
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.Atype);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.Atype, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Atype);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaAlertsMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaAlertsMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.documentType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DocumentType
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.DocumentType);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.DocumentType, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.DocumentType);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.documentid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Documentid
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.Documentid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.Documentid, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Documentid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.document_num
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DocumentNum
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.DocumentNum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.DocumentNum, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.DocumentNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.alevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Alevel
		{
			get
			{
				return base.GetSystemInt32(WtaAlertsMetadata.ColumnNames.Alevel);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaAlertsMetadata.ColumnNames.Alevel, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Alevel);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_alerts.msg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Msg
		{
			get
			{
				return base.GetSystemString(WtaAlertsMetadata.ColumnNames.Msg);
			}
			
			set
			{
				if(base.SetSystemString(WtaAlertsMetadata.ColumnNames.Msg, value))
				{
					OnPropertyChanged(WtaAlertsMetadata.PropertyNames.Msg);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaAlertsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaAlertsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaAlertsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaAlertsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaAlertsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaAlertsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaAlertsQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaAlertsCollection : esEntityCollection<WtaAlertsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaAlertsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaAlertsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaAlertsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaAlertsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaAlertsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaAlertsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaAlertsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaAlertsQuery)query);
		}

		#endregion
		
		private WtaAlertsQuery query;
	}



	[Serializable]
	abstract public partial class esWtaAlertsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaAlertsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Aid": return this.Aid;
				case "Mid": return this.Mid;
				case "Createdate": return this.Createdate;
				case "Createdby": return this.Createdby;
				case "Atype": return this.Atype;
				case "Productcode": return this.Productcode;
				case "DocumentType": return this.DocumentType;
				case "Documentid": return this.Documentid;
				case "DocumentNum": return this.DocumentNum;
				case "Alevel": return this.Alevel;
				case "Msg": return this.Msg;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Aid
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Aid, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Atype
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Atype, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem DocumentType
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.DocumentType, esSystemType.Int32); }
		} 
		
		public esQueryItem Documentid
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Documentid, esSystemType.Int32); }
		} 
		
		public esQueryItem DocumentNum
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.DocumentNum, esSystemType.Int32); }
		} 
		
		public esQueryItem Alevel
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Alevel, esSystemType.Int32); }
		} 
		
		public esQueryItem Msg
		{
			get { return new esQueryItem(this, WtaAlertsMetadata.ColumnNames.Msg, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaAlertsBO : esWtaAlertsBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaAlertsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaAlertsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Aid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Aid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Createdate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Createdby, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Atype, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Atype;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Productcode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.DocumentType, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.DocumentType;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Documentid, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Documentid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.DocumentNum, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.DocumentNum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Alevel, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Alevel;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAlertsMetadata.ColumnNames.Msg, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAlertsMetadata.PropertyNames.Msg;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaAlertsMetadata Meta()
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
			 public const string Aid = "aid";
			 public const string Mid = "mid";
			 public const string Createdate = "createdate";
			 public const string Createdby = "createdby";
			 public const string Atype = "atype";
			 public const string Productcode = "productcode";
			 public const string DocumentType = "documentType";
			 public const string Documentid = "documentid";
			 public const string DocumentNum = "document_num";
			 public const string Alevel = "alevel";
			 public const string Msg = "msg";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Aid = "Aid";
			 public const string Mid = "Mid";
			 public const string Createdate = "Createdate";
			 public const string Createdby = "Createdby";
			 public const string Atype = "Atype";
			 public const string Productcode = "Productcode";
			 public const string DocumentType = "DocumentType";
			 public const string Documentid = "Documentid";
			 public const string DocumentNum = "DocumentNum";
			 public const string Alevel = "Alevel";
			 public const string Msg = "Msg";
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
			lock (typeof(WtaAlertsMetadata))
			{
				if(WtaAlertsMetadata.mapDelegates == null)
				{
					WtaAlertsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaAlertsMetadata.meta == null)
				{
					WtaAlertsMetadata.meta = new WtaAlertsMetadata();
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


				meta.AddTypeMap("Aid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Atype", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DocumentType", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Documentid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DocumentNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Alevel", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Msg", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_alerts";
				meta.Destination = "wta_alerts";
				
				meta.spInsert = "proc_wta_alertsInsert";				
				meta.spUpdate = "proc_wta_alertsUpdate";		
				meta.spDelete = "proc_wta_alertsDelete";
				meta.spLoadAll = "proc_wta_alertsLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_alertsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaAlertsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
