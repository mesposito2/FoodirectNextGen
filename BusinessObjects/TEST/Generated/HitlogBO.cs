
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
	/// Encapsulates the 'hitlog' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(HitlogBO))]	
	[XmlType("HitlogBO")]
	public partial class HitlogBO : esHitlogBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new HitlogBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("HitlogCollection")]
	public partial class HitlogCollection : esHitlogCollection, IEnumerable<HitlogBO>
	{

		
				
	}



	[Serializable]	
	public partial class HitlogQuery : esHitlogQuery
	{
		public HitlogQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public HitlogQuery(string joinAlias, out HitlogQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "HitlogQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(HitlogQuery query)
		{
			return HitlogQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator HitlogQuery(string query)
		{
			return (HitlogQuery)HitlogQuery.SerializeHelper.FromXml(query, typeof(HitlogQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esHitlogBO : esEntity
	{
		public esHitlogBO()
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
			HitlogQuery query = new HitlogQuery();
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
		/// Maps to hitlog.htime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Htime
		{
			get
			{
				return base.GetSystemDateTime(HitlogMetadata.ColumnNames.Htime);
			}
			
			set
			{
				if(base.SetSystemDateTime(HitlogMetadata.ColumnNames.Htime, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Htime);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.ip
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Ip
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Ip);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Ip, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Ip);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.page
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Page
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Page);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Page, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Page);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.refer
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Refer
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Refer);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Refer, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Refer);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.cname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cname
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Cname);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Cname, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Cname);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.role
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Role
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Role);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Role, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Role);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.rolename
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Rolename
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Rolename);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Rolename, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Rolename);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.membername
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Membername
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Membername);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Membername, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Membername);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.eventid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Eventid
		{
			get
			{
				return base.GetSystemInt32(HitlogMetadata.ColumnNames.Eventid);
			}
			
			set
			{
				if(base.SetSystemInt32(HitlogMetadata.ColumnNames.Eventid, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Eventid);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.data
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Data
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Data);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Data, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Data);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.source
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Source
		{
			get
			{
				return base.GetSystemInt32(HitlogMetadata.ColumnNames.Source);
			}
			
			set
			{
				if(base.SetSystemInt32(HitlogMetadata.ColumnNames.Source, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Source);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.browser
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Browser
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Browser);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Browser, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Browser);
				}
			}
		}
		
		/// <summary>
		/// Maps to hitlog.qs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Qs
		{
			get
			{
				return base.GetSystemString(HitlogMetadata.ColumnNames.Qs);
			}
			
			set
			{
				if(base.SetSystemString(HitlogMetadata.ColumnNames.Qs, value))
				{
					OnPropertyChanged(HitlogMetadata.PropertyNames.Qs);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return HitlogMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public HitlogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new HitlogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(HitlogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(HitlogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((HitlogQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private HitlogQuery query;		
	}



	[Serializable]
	abstract public partial class esHitlogCollection : esEntityCollection<HitlogBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return HitlogMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "HitlogCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public HitlogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new HitlogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(HitlogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new HitlogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(HitlogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((HitlogQuery)query);
		}

		#endregion
		
		private HitlogQuery query;
	}



	[Serializable]
	abstract public partial class esHitlogQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return HitlogMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Htime": return this.Htime;
				case "Ip": return this.Ip;
				case "Page": return this.Page;
				case "Refer": return this.Refer;
				case "Custid": return this.Custid;
				case "Cname": return this.Cname;
				case "Role": return this.Role;
				case "Rolename": return this.Rolename;
				case "Mid": return this.Mid;
				case "Membername": return this.Membername;
				case "Eventid": return this.Eventid;
				case "Data": return this.Data;
				case "Source": return this.Source;
				case "Browser": return this.Browser;
				case "Qs": return this.Qs;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Htime
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Htime, esSystemType.DateTime); }
		} 
		
		public esQueryItem Ip
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Ip, esSystemType.String); }
		} 
		
		public esQueryItem Page
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Page, esSystemType.String); }
		} 
		
		public esQueryItem Refer
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Refer, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Cname
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Cname, esSystemType.String); }
		} 
		
		public esQueryItem Role
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Role, esSystemType.String); }
		} 
		
		public esQueryItem Rolename
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Rolename, esSystemType.String); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Membername
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Membername, esSystemType.String); }
		} 
		
		public esQueryItem Eventid
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Eventid, esSystemType.Int32); }
		} 
		
		public esQueryItem Data
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Data, esSystemType.String); }
		} 
		
		public esQueryItem Source
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Source, esSystemType.Int32); }
		} 
		
		public esQueryItem Browser
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Browser, esSystemType.String); }
		} 
		
		public esQueryItem Qs
		{
			get { return new esQueryItem(this, HitlogMetadata.ColumnNames.Qs, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class HitlogBO : esHitlogBO
	{

		
		
	}
	



	[Serializable]
	public partial class HitlogMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected HitlogMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Htime, 0, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = HitlogMetadata.PropertyNames.Htime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Ip, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Ip;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Page, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Page;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Refer, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Refer;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Custid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Cname, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Cname;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Role, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Role;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Rolename, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Rolename;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Mid, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Membername, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Membername;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Eventid, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = HitlogMetadata.PropertyNames.Eventid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Data, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Data;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Source, 12, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = HitlogMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Browser, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Browser;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(HitlogMetadata.ColumnNames.Qs, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = HitlogMetadata.PropertyNames.Qs;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public HitlogMetadata Meta()
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
			 public const string Htime = "htime";
			 public const string Ip = "ip";
			 public const string Page = "page";
			 public const string Refer = "refer";
			 public const string Custid = "custid";
			 public const string Cname = "cname";
			 public const string Role = "role";
			 public const string Rolename = "rolename";
			 public const string Mid = "mid";
			 public const string Membername = "membername";
			 public const string Eventid = "eventid";
			 public const string Data = "data";
			 public const string Source = "source";
			 public const string Browser = "browser";
			 public const string Qs = "qs";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Htime = "Htime";
			 public const string Ip = "Ip";
			 public const string Page = "Page";
			 public const string Refer = "Refer";
			 public const string Custid = "Custid";
			 public const string Cname = "Cname";
			 public const string Role = "Role";
			 public const string Rolename = "Rolename";
			 public const string Mid = "Mid";
			 public const string Membername = "Membername";
			 public const string Eventid = "Eventid";
			 public const string Data = "Data";
			 public const string Source = "Source";
			 public const string Browser = "Browser";
			 public const string Qs = "Qs";
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
			lock (typeof(HitlogMetadata))
			{
				if(HitlogMetadata.mapDelegates == null)
				{
					HitlogMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (HitlogMetadata.meta == null)
				{
					HitlogMetadata.meta = new HitlogMetadata();
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


				meta.AddTypeMap("Htime", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Ip", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Page", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Refer", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Role", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Rolename", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Membername", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Eventid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Data", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Source", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Browser", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qs", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "hitlog";
				meta.Destination = "hitlog";
				
				meta.spInsert = "proc_hitlogInsert";				
				meta.spUpdate = "proc_hitlogUpdate";		
				meta.spDelete = "proc_hitlogDelete";
				meta.spLoadAll = "proc_hitlogLoadAll";
				meta.spLoadByPrimaryKey = "proc_hitlogLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private HitlogMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
