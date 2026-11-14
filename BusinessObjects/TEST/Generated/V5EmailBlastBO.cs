
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
	/// Encapsulates the 'V5EmailBlast' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5EmailBlastBO))]	
	[XmlType("V5EmailBlastBO")]
	public partial class V5EmailBlastBO : esV5EmailBlastBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5EmailBlastBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 emailBlastID)
		{
			var obj = new V5EmailBlastBO();
			obj.EmailBlastID = emailBlastID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 emailBlastID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5EmailBlastBO();
			obj.EmailBlastID = emailBlastID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5EmailBlastCollection")]
	public partial class V5EmailBlastCollection : esV5EmailBlastCollection, IEnumerable<V5EmailBlastBO>
	{
		public V5EmailBlastBO FindByPrimaryKey(System.Int32 emailBlastID)
		{
			return this.SingleOrDefault(e => e.EmailBlastID == emailBlastID);
		}

		
				
	}



	[Serializable]	
	public partial class V5EmailBlastQuery : esV5EmailBlastQuery
	{
		public V5EmailBlastQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5EmailBlastQuery(string joinAlias, out V5EmailBlastQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5EmailBlastQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5EmailBlastQuery query)
		{
			return V5EmailBlastQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5EmailBlastQuery(string query)
		{
			return (V5EmailBlastQuery)V5EmailBlastQuery.SerializeHelper.FromXml(query, typeof(V5EmailBlastQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5EmailBlastBO : esEntity
	{
		public esV5EmailBlastBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 emailBlastID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 emailBlastID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 emailBlastID)
		{
			V5EmailBlastQuery query = new V5EmailBlastQuery();
			query.Where(query.EmailBlastID == emailBlastID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 emailBlastID)
		{
			esParameters parms = new esParameters();
			parms.Add("EmailBlastID", emailBlastID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to V5EmailBlast.EmailBlastID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastMetadata.ColumnNames.EmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastMetadata.ColumnNames.EmailBlastID, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.EmailBlastID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.CreatedByDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastMetadata.ColumnNames.CreatedByDate, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.CreatedByDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.SendDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? SendDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastMetadata.ColumnNames.SendDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastMetadata.ColumnNames.SendDate, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.SendDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.StatusUCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StatusUCODE
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.StatusUCODE);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.StatusUCODE, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.StatusUCODE);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.Subject
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Subject
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.Subject);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.Subject, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.Subject);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.EmailFrom
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String EmailFrom
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.EmailFrom);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.EmailFrom, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.EmailFrom);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToUCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ToUCODE
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToUCODE);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToUCODE, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.ToUCODE);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToOther
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ToOther
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToOther);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToOther, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.ToOther);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToSent
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ToSent
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToSent);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToSent, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.ToSent);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.Body
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Body
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.Body);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.Body, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.Body);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.OrginalEmailBlastID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? OrginalEmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.OrginalEmailBlastID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.LogFile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LogFile
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.LogFile);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.LogFile, value))
				{
					OnPropertyChanged(V5EmailBlastMetadata.PropertyNames.LogFile);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5EmailBlastQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5EmailBlastQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5EmailBlastQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5EmailBlastQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5EmailBlastQuery query;		
	}



	[Serializable]
	abstract public partial class esV5EmailBlastCollection : esEntityCollection<V5EmailBlastBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5EmailBlastCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5EmailBlastQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5EmailBlastQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5EmailBlastQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5EmailBlastQuery)query);
		}

		#endregion
		
		private V5EmailBlastQuery query;
	}



	[Serializable]
	abstract public partial class esV5EmailBlastQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "EmailBlastID": return this.EmailBlastID;
				case "CreatedByDate": return this.CreatedByDate;
				case "CreatedBy": return this.CreatedBy;
				case "SendDate": return this.SendDate;
				case "StatusUCODE": return this.StatusUCODE;
				case "Subject": return this.Subject;
				case "EmailFrom": return this.EmailFrom;
				case "ToUCODE": return this.ToUCODE;
				case "ToOther": return this.ToOther;
				case "ToSent": return this.ToSent;
				case "Body": return this.Body;
				case "OrginalEmailBlastID": return this.OrginalEmailBlastID;
				case "LogFile": return this.LogFile;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem EmailBlastID
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.EmailBlastID, esSystemType.Int32); }
		} 
		
		public esQueryItem CreatedByDate
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem SendDate
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.SendDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem StatusUCODE
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.StatusUCODE, esSystemType.String); }
		} 
		
		public esQueryItem Subject
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.Subject, esSystemType.String); }
		} 
		
		public esQueryItem EmailFrom
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.EmailFrom, esSystemType.String); }
		} 
		
		public esQueryItem ToUCODE
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToUCODE, esSystemType.String); }
		} 
		
		public esQueryItem ToOther
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToOther, esSystemType.String); }
		} 
		
		public esQueryItem ToSent
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToSent, esSystemType.String); }
		} 
		
		public esQueryItem Body
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.Body, esSystemType.String); }
		} 
		
		public esQueryItem OrginalEmailBlastID
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, esSystemType.Int32); }
		} 
		
		public esQueryItem LogFile
		{
			get { return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.LogFile, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class V5EmailBlastBO : esV5EmailBlastBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5EmailBlastMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5EmailBlastMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.EmailBlastID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.EmailBlastID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.CreatedByDate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.CreatedByDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.CreatedBy, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.SendDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.SendDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.StatusUCODE, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.StatusUCODE;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.Subject, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.Subject;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.EmailFrom, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.EmailFrom;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToUCODE, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToUCODE;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToOther, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToOther;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToSent, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToSent;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.Body, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.Body;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.OrginalEmailBlastID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.LogFile, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.LogFile;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5EmailBlastMetadata Meta()
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
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string SendDate = "SendDate";
			 public const string StatusUCODE = "StatusUCODE";
			 public const string Subject = "Subject";
			 public const string EmailFrom = "EmailFrom";
			 public const string ToUCODE = "ToUCODE";
			 public const string ToOther = "ToOther";
			 public const string ToSent = "ToSent";
			 public const string Body = "Body";
			 public const string OrginalEmailBlastID = "OrginalEmailBlastID";
			 public const string LogFile = "LogFile";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string SendDate = "SendDate";
			 public const string StatusUCODE = "StatusUCODE";
			 public const string Subject = "Subject";
			 public const string EmailFrom = "EmailFrom";
			 public const string ToUCODE = "ToUCODE";
			 public const string ToOther = "ToOther";
			 public const string ToSent = "ToSent";
			 public const string Body = "Body";
			 public const string OrginalEmailBlastID = "OrginalEmailBlastID";
			 public const string LogFile = "LogFile";
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
			lock (typeof(V5EmailBlastMetadata))
			{
				if(V5EmailBlastMetadata.mapDelegates == null)
				{
					V5EmailBlastMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5EmailBlastMetadata.meta == null)
				{
					V5EmailBlastMetadata.meta = new V5EmailBlastMetadata();
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


				meta.AddTypeMap("EmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SendDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("StatusUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Subject", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("EmailFrom", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToOther", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToSent", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Body", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OrginalEmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LogFile", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "V5EmailBlast";
				meta.Destination = "V5EmailBlast";
				
				meta.spInsert = "proc_V5EmailBlastInsert";				
				meta.spUpdate = "proc_V5EmailBlastUpdate";		
				meta.spDelete = "proc_V5EmailBlastDelete";
				meta.spLoadAll = "proc_V5EmailBlastLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5EmailBlastLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5EmailBlastMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
