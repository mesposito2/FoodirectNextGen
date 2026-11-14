
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
	/// Encapsulates the 'V5JobMasterRun' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5JobMasterRunBO))]	
	[XmlType("V5JobMasterRunBO")]
	public partial class V5JobMasterRunBO : esV5JobMasterRunBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5JobMasterRunBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 jobMasterRunID)
		{
			var obj = new V5JobMasterRunBO();
			obj.JobMasterRunID = jobMasterRunID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 jobMasterRunID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5JobMasterRunBO();
			obj.JobMasterRunID = jobMasterRunID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5JobMasterRunCollection")]
	public partial class V5JobMasterRunCollection : esV5JobMasterRunCollection, IEnumerable<V5JobMasterRunBO>
	{
		public V5JobMasterRunBO FindByPrimaryKey(System.Int32 jobMasterRunID)
		{
			return this.SingleOrDefault(e => e.JobMasterRunID == jobMasterRunID);
		}

		
				
	}



	[Serializable]	
	public partial class V5JobMasterRunQuery : esV5JobMasterRunQuery
	{
		public V5JobMasterRunQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5JobMasterRunQuery(string joinAlias, out V5JobMasterRunQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5JobMasterRunQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5JobMasterRunQuery query)
		{
			return V5JobMasterRunQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5JobMasterRunQuery(string query)
		{
			return (V5JobMasterRunQuery)V5JobMasterRunQuery.SerializeHelper.FromXml(query, typeof(V5JobMasterRunQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5JobMasterRunBO : esEntity
	{
		public esV5JobMasterRunBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 jobMasterRunID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobMasterRunID);
			else
				return LoadByPrimaryKeyStoredProcedure(jobMasterRunID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 jobMasterRunID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobMasterRunID);
			else
				return LoadByPrimaryKeyStoredProcedure(jobMasterRunID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 jobMasterRunID)
		{
			V5JobMasterRunQuery query = new V5JobMasterRunQuery();
			query.Where(query.JobMasterRunID == jobMasterRunID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 jobMasterRunID)
		{
			esParameters parms = new esParameters();
			parms.Add("JobMasterRunID", jobMasterRunID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to V5JobMasterRun.JobMasterRunID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? JobMasterRunID
		{
			get
			{
				return base.GetSystemInt32(V5JobMasterRunMetadata.ColumnNames.JobMasterRunID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5JobMasterRunMetadata.ColumnNames.JobMasterRunID, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.JobMasterRunID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.CreatedByDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5JobMasterRunMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5JobMasterRunMetadata.ColumnNames.CreatedByDate, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.CreatedByDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5JobMasterRunMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5JobMasterRunMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Status_Ucode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StatusUcode
		{
			get
			{
				return base.GetSystemString(V5JobMasterRunMetadata.ColumnNames.StatusUcode);
			}
			
			set
			{
				if(base.SetSystemString(V5JobMasterRunMetadata.ColumnNames.StatusUcode, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.StatusUcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Parameters
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Parameters
		{
			get
			{
				return base.GetSystemString(V5JobMasterRunMetadata.ColumnNames.Parameters);
			}
			
			set
			{
				if(base.SetSystemString(V5JobMasterRunMetadata.ColumnNames.Parameters, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.Parameters);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Output
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Output
		{
			get
			{
				return base.GetSystemString(V5JobMasterRunMetadata.ColumnNames.Output);
			}
			
			set
			{
				if(base.SetSystemString(V5JobMasterRunMetadata.ColumnNames.Output, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.Output);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.RunDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? RunDateTime
		{
			get
			{
				return base.GetSystemDateTime(V5JobMasterRunMetadata.ColumnNames.RunDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5JobMasterRunMetadata.ColumnNames.RunDateTime, value))
				{
					OnPropertyChanged(V5JobMasterRunMetadata.PropertyNames.RunDateTime);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5JobMasterRunMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5JobMasterRunQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5JobMasterRunQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5JobMasterRunQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5JobMasterRunQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5JobMasterRunQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5JobMasterRunQuery query;		
	}



	[Serializable]
	abstract public partial class esV5JobMasterRunCollection : esEntityCollection<V5JobMasterRunBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5JobMasterRunMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5JobMasterRunCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5JobMasterRunQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5JobMasterRunQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5JobMasterRunQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5JobMasterRunQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5JobMasterRunQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5JobMasterRunQuery)query);
		}

		#endregion
		
		private V5JobMasterRunQuery query;
	}



	[Serializable]
	abstract public partial class esV5JobMasterRunQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5JobMasterRunMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "JobMasterRunID": return this.JobMasterRunID;
				case "CreatedByDate": return this.CreatedByDate;
				case "CreatedBy": return this.CreatedBy;
				case "StatusUcode": return this.StatusUcode;
				case "Parameters": return this.Parameters;
				case "Output": return this.Output;
				case "RunDateTime": return this.RunDateTime;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem JobMasterRunID
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.JobMasterRunID, esSystemType.Int32); }
		} 
		
		public esQueryItem CreatedByDate
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem StatusUcode
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.StatusUcode, esSystemType.String); }
		} 
		
		public esQueryItem Parameters
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.Parameters, esSystemType.String); }
		} 
		
		public esQueryItem Output
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.Output, esSystemType.String); }
		} 
		
		public esQueryItem RunDateTime
		{
			get { return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.RunDateTime, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class V5JobMasterRunBO : esV5JobMasterRunBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5JobMasterRunMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5JobMasterRunMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.JobMasterRunID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.JobMasterRunID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.CreatedByDate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.CreatedByDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.CreatedBy, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.StatusUcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.StatusUcode;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.Parameters, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.Parameters;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.Output, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.Output;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.RunDateTime, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.RunDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5JobMasterRunMetadata Meta()
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
			 public const string JobMasterRunID = "JobMasterRunID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string StatusUcode = "Status_Ucode";
			 public const string Parameters = "Parameters";
			 public const string Output = "Output";
			 public const string RunDateTime = "RunDateTime";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string JobMasterRunID = "JobMasterRunID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string StatusUcode = "StatusUcode";
			 public const string Parameters = "Parameters";
			 public const string Output = "Output";
			 public const string RunDateTime = "RunDateTime";
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
			lock (typeof(V5JobMasterRunMetadata))
			{
				if(V5JobMasterRunMetadata.mapDelegates == null)
				{
					V5JobMasterRunMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5JobMasterRunMetadata.meta == null)
				{
					V5JobMasterRunMetadata.meta = new V5JobMasterRunMetadata();
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


				meta.AddTypeMap("JobMasterRunID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("StatusUcode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Parameters", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Output", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("RunDateTime", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "V5JobMasterRun";
				meta.Destination = "V5JobMasterRun";
				
				meta.spInsert = "proc_V5JobMasterRunInsert";				
				meta.spUpdate = "proc_V5JobMasterRunUpdate";		
				meta.spDelete = "proc_V5JobMasterRunDelete";
				meta.spLoadAll = "proc_V5JobMasterRunLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5JobMasterRunLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5JobMasterRunMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
