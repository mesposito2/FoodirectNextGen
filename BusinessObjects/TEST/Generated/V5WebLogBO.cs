
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
	/// Encapsulates the 'v5WebLog' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5WebLogBO))]	
	[XmlType("V5WebLogBO")]
	public partial class V5WebLogBO : esV5WebLogBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5WebLogBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 weblogID)
		{
			var obj = new V5WebLogBO();
			obj.WeblogID = weblogID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 weblogID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5WebLogBO();
			obj.WeblogID = weblogID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5WebLogCollection")]
	public partial class V5WebLogCollection : esV5WebLogCollection, IEnumerable<V5WebLogBO>
	{
		public V5WebLogBO FindByPrimaryKey(System.Int32 weblogID)
		{
			return this.SingleOrDefault(e => e.WeblogID == weblogID);
		}

		
				
	}



	[Serializable]	
	public partial class V5WebLogQuery : esV5WebLogQuery
	{
		public V5WebLogQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5WebLogQuery(string joinAlias, out V5WebLogQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5WebLogQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5WebLogQuery query)
		{
			return V5WebLogQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5WebLogQuery(string query)
		{
			return (V5WebLogQuery)V5WebLogQuery.SerializeHelper.FromXml(query, typeof(V5WebLogQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5WebLogBO : esEntity
	{
		public esV5WebLogBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 weblogID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(weblogID);
			else
				return LoadByPrimaryKeyStoredProcedure(weblogID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 weblogID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(weblogID);
			else
				return LoadByPrimaryKeyStoredProcedure(weblogID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 weblogID)
		{
			V5WebLogQuery query = new V5WebLogQuery();
			query.Where(query.WeblogID == weblogID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 weblogID)
		{
			esParameters parms = new esParameters();
			parms.Add("WeblogID", weblogID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to v5WebLog.WeblogID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? WeblogID
		{
			get
			{
				return base.GetSystemInt32(V5WebLogMetadata.ColumnNames.WeblogID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5WebLogMetadata.ColumnNames.WeblogID, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.WeblogID);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.ip
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Ip
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Ip);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Ip, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Ip);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.createDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDateTime
		{
			get
			{
				return base.GetSystemDateTime(V5WebLogMetadata.ColumnNames.CreateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5WebLogMetadata.ColumnNames.CreateDateTime, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.CreateDateTime);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.message
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Message
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Message);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Message, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Message);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Type
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.action
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Action
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Action);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Action, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Action);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.User
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String User
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.User);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.User, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.User);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Page
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Page
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Page);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Page, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Page);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Reported
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Reported
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.Reported);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.Reported, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Reported);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.IsAjax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsAjax
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.IsAjax);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.IsAjax, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.IsAjax);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.HttpReferer
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HttpReferer
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.HttpReferer);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.HttpReferer, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.HttpReferer);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.HttpUserAgent
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String HttpUserAgent
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.HttpUserAgent);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.HttpUserAgent, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.HttpUserAgent);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Https
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Https
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Https);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Https, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.Https);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.ResponseCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ResponseCode
		{
			get
			{
				return base.GetSystemInt32(V5WebLogMetadata.ColumnNames.ResponseCode);
			}
			
			set
			{
				if(base.SetSystemInt32(V5WebLogMetadata.ColumnNames.ResponseCode, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.ResponseCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.IsNotFound
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsNotFound
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.IsNotFound);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.IsNotFound, value))
				{
					OnPropertyChanged(V5WebLogMetadata.PropertyNames.IsNotFound);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5WebLogMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5WebLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5WebLogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5WebLogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5WebLogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5WebLogQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5WebLogQuery query;		
	}



	[Serializable]
	abstract public partial class esV5WebLogCollection : esEntityCollection<V5WebLogBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5WebLogMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5WebLogCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5WebLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5WebLogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5WebLogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5WebLogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5WebLogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5WebLogQuery)query);
		}

		#endregion
		
		private V5WebLogQuery query;
	}



	[Serializable]
	abstract public partial class esV5WebLogQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5WebLogMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "WeblogID": return this.WeblogID;
				case "Ip": return this.Ip;
				case "CreateDateTime": return this.CreateDateTime;
				case "Message": return this.Message;
				case "Type": return this.Type;
				case "Action": return this.Action;
				case "User": return this.User;
				case "Page": return this.Page;
				case "Reported": return this.Reported;
				case "IsAjax": return this.IsAjax;
				case "HttpReferer": return this.HttpReferer;
				case "HttpUserAgent": return this.HttpUserAgent;
				case "Https": return this.Https;
				case "ResponseCode": return this.ResponseCode;
				case "IsNotFound": return this.IsNotFound;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem WeblogID
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.WeblogID, esSystemType.Int32); }
		} 
		
		public esQueryItem Ip
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Ip, esSystemType.String); }
		} 
		
		public esQueryItem CreateDateTime
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem Message
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Message, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Type, esSystemType.String); }
		} 
		
		public esQueryItem Action
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Action, esSystemType.String); }
		} 
		
		public esQueryItem User
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.User, esSystemType.String); }
		} 
		
		public esQueryItem Page
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Page, esSystemType.String); }
		} 
		
		public esQueryItem Reported
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Reported, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsAjax
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.IsAjax, esSystemType.Boolean); }
		} 
		
		public esQueryItem HttpReferer
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.HttpReferer, esSystemType.String); }
		} 
		
		public esQueryItem HttpUserAgent
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.HttpUserAgent, esSystemType.String); }
		} 
		
		public esQueryItem Https
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Https, esSystemType.String); }
		} 
		
		public esQueryItem ResponseCode
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.ResponseCode, esSystemType.Int32); }
		} 
		
		public esQueryItem IsNotFound
		{
			get { return new esQueryItem(this, V5WebLogMetadata.ColumnNames.IsNotFound, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class V5WebLogBO : esV5WebLogBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5WebLogMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5WebLogMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.WeblogID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5WebLogMetadata.PropertyNames.WeblogID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Ip, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Ip;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.CreateDateTime, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5WebLogMetadata.PropertyNames.CreateDateTime;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Message, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Message;
			c.CharacterMaxLength = 1073741823;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Type, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Type;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Action, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Action;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.User, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.User;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Page, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Page;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Reported, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Reported;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.IsAjax, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.IsAjax;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.HttpReferer, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.HttpReferer;
			c.CharacterMaxLength = 300;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.HttpUserAgent, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.HttpUserAgent;
			c.CharacterMaxLength = 300;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Https, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Https;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.ResponseCode, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5WebLogMetadata.PropertyNames.ResponseCode;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.IsNotFound, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.IsNotFound;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5WebLogMetadata Meta()
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
			 public const string WeblogID = "WeblogID";
			 public const string Ip = "ip";
			 public const string CreateDateTime = "createDateTime";
			 public const string Message = "message";
			 public const string Type = "type";
			 public const string Action = "action";
			 public const string User = "User";
			 public const string Page = "Page";
			 public const string Reported = "Reported";
			 public const string IsAjax = "IsAjax";
			 public const string HttpReferer = "HttpReferer";
			 public const string HttpUserAgent = "HttpUserAgent";
			 public const string Https = "Https";
			 public const string ResponseCode = "ResponseCode";
			 public const string IsNotFound = "IsNotFound";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string WeblogID = "WeblogID";
			 public const string Ip = "Ip";
			 public const string CreateDateTime = "CreateDateTime";
			 public const string Message = "Message";
			 public const string Type = "Type";
			 public const string Action = "Action";
			 public const string User = "User";
			 public const string Page = "Page";
			 public const string Reported = "Reported";
			 public const string IsAjax = "IsAjax";
			 public const string HttpReferer = "HttpReferer";
			 public const string HttpUserAgent = "HttpUserAgent";
			 public const string Https = "Https";
			 public const string ResponseCode = "ResponseCode";
			 public const string IsNotFound = "IsNotFound";
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
			lock (typeof(V5WebLogMetadata))
			{
				if(V5WebLogMetadata.mapDelegates == null)
				{
					V5WebLogMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5WebLogMetadata.meta == null)
				{
					V5WebLogMetadata.meta = new V5WebLogMetadata();
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


				meta.AddTypeMap("WeblogID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Ip", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Message", new esTypeMap("ntext", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Action", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("User", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Page", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Reported", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsAjax", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("HttpReferer", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HttpUserAgent", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Https", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ResponseCode", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsNotFound", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "v5WebLog";
				meta.Destination = "v5WebLog";
				
				meta.spInsert = "proc_v5WebLogInsert";				
				meta.spUpdate = "proc_v5WebLogUpdate";		
				meta.spDelete = "proc_v5WebLogDelete";
				meta.spLoadAll = "proc_v5WebLogLoadAll";
				meta.spLoadByPrimaryKey = "proc_v5WebLogLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5WebLogMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
