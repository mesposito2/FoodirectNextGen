
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
	/// Encapsulates the 'jobep' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(JobepBO))]	
	[XmlType("JobepBO")]
	public partial class JobepBO : esJobepBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new JobepBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 jobepId)
		{
			var obj = new JobepBO();
			obj.JobepId = jobepId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 jobepId, esSqlAccessType sqlAccessType)
		{
			var obj = new JobepBO();
			obj.JobepId = jobepId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("JobepCollection")]
	public partial class JobepCollection : esJobepCollection, IEnumerable<JobepBO>
	{
		public JobepBO FindByPrimaryKey(System.Int32 jobepId)
		{
			return this.SingleOrDefault(e => e.JobepId == jobepId);
		}

		
				
	}



	[Serializable]	
	public partial class JobepQuery : esJobepQuery
	{
		public JobepQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public JobepQuery(string joinAlias, out JobepQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "JobepQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(JobepQuery query)
		{
			return JobepQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator JobepQuery(string query)
		{
			return (JobepQuery)JobepQuery.SerializeHelper.FromXml(query, typeof(JobepQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esJobepBO : esEntity
	{
		public esJobepBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 jobepId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobepId);
			else
				return LoadByPrimaryKeyStoredProcedure(jobepId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 jobepId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobepId);
			else
				return LoadByPrimaryKeyStoredProcedure(jobepId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 jobepId)
		{
			JobepQuery query = new JobepQuery();
			query.Where(query.JobepId == jobepId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 jobepId)
		{
			esParameters parms = new esParameters();
			parms.Add("JobepId", jobepId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to jobep.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(JobepMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(JobepMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.colnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(JobepMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepMetadata.ColumnNames.Colnum, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Colnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.line
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(JobepMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepMetadata.ColumnNames.Line, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Line);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(JobepMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(JobepMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.sdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(JobepMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(JobepMetadata.ColumnNames.Sdescription, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Sdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.slbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(JobepMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(JobepMetadata.ColumnNames.Slbcs, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Slbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.sjlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(JobepMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(JobepMetadata.ColumnNames.Sjlbcs, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.Sjlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.jobep_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? JobepId
		{
			get
			{
				return base.GetSystemInt32(JobepMetadata.ColumnNames.JobepId);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepMetadata.ColumnNames.JobepId, value))
				{
					OnPropertyChanged(JobepMetadata.PropertyNames.JobepId);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return JobepMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public JobepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(JobepQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(JobepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((JobepQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private JobepQuery query;		
	}



	[Serializable]
	abstract public partial class esJobepCollection : esEntityCollection<JobepBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return JobepMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "JobepCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public JobepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(JobepQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new JobepQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(JobepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((JobepQuery)query);
		}

		#endregion
		
		private JobepQuery query;
	}



	[Serializable]
	abstract public partial class esJobepQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return JobepMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Colnum": return this.Colnum;
				case "Line": return this.Line;
				case "Productcode": return this.Productcode;
				case "Sdescription": return this.Sdescription;
				case "Slbcs": return this.Slbcs;
				case "Sjlbcs": return this.Sjlbcs;
				case "JobepId": return this.JobepId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Colnum
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Colnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Line
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Line, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Sdescription
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Sdescription, esSystemType.String); }
		} 
		
		public esQueryItem Slbcs
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Slbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Sjlbcs
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.Sjlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem JobepId
		{
			get { return new esQueryItem(this, JobepMetadata.ColumnNames.JobepId, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class JobepBO : esJobepBO
	{

		
		
	}
	



	[Serializable]
	public partial class JobepMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected JobepMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(JobepMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.JobepId, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.JobepId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public JobepMetadata Meta()
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
			 public const string Colnum = "colnum";
			 public const string Line = "line";
			 public const string Productcode = "productcode";
			 public const string Sdescription = "sdescription";
			 public const string Slbcs = "slbcs";
			 public const string Sjlbcs = "sjlbcs";
			 public const string JobepId = "jobep_id";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Colnum = "Colnum";
			 public const string Line = "Line";
			 public const string Productcode = "Productcode";
			 public const string Sdescription = "Sdescription";
			 public const string Slbcs = "Slbcs";
			 public const string Sjlbcs = "Sjlbcs";
			 public const string JobepId = "JobepId";
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
			lock (typeof(JobepMetadata))
			{
				if(JobepMetadata.mapDelegates == null)
				{
					JobepMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (JobepMetadata.meta == null)
				{
					JobepMetadata.meta = new JobepMetadata();
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
				meta.AddTypeMap("Colnum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Line", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Slbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sjlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("JobepId", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "jobep";
				meta.Destination = "jobep";
				
				meta.spInsert = "proc_jobepInsert";				
				meta.spUpdate = "proc_jobepUpdate";		
				meta.spDelete = "proc_jobepDelete";
				meta.spLoadAll = "proc_jobepLoadAll";
				meta.spLoadByPrimaryKey = "proc_jobepLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private JobepMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
