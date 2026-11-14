
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
	/// Encapsulates the 'jobep_nw' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(JobepNwBO))]	
	[XmlType("JobepNwBO")]
	public partial class JobepNwBO : esJobepNwBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new JobepNwBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 jobepNwId)
		{
			var obj = new JobepNwBO();
			obj.JobepNwId = jobepNwId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 jobepNwId, esSqlAccessType sqlAccessType)
		{
			var obj = new JobepNwBO();
			obj.JobepNwId = jobepNwId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("JobepNwCollection")]
	public partial class JobepNwCollection : esJobepNwCollection, IEnumerable<JobepNwBO>
	{
		public JobepNwBO FindByPrimaryKey(System.Int32 jobepNwId)
		{
			return this.SingleOrDefault(e => e.JobepNwId == jobepNwId);
		}

		
				
	}



	[Serializable]	
	public partial class JobepNwQuery : esJobepNwQuery
	{
		public JobepNwQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public JobepNwQuery(string joinAlias, out JobepNwQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "JobepNwQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(JobepNwQuery query)
		{
			return JobepNwQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator JobepNwQuery(string query)
		{
			return (JobepNwQuery)JobepNwQuery.SerializeHelper.FromXml(query, typeof(JobepNwQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esJobepNwBO : esEntity
	{
		public esJobepNwBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 jobepNwId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(jobepNwId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 jobepNwId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(jobepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(jobepNwId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 jobepNwId)
		{
			JobepNwQuery query = new JobepNwQuery();
			query.Where(query.JobepNwId == jobepNwId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 jobepNwId)
		{
			esParameters parms = new esParameters();
			parms.Add("JobepNwId", jobepNwId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to jobep_nw.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(JobepNwMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(JobepNwMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.colnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(JobepNwMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepNwMetadata.ColumnNames.Colnum, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Colnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.line
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(JobepNwMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepNwMetadata.ColumnNames.Line, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Line);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(JobepNwMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(JobepNwMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.sdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(JobepNwMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(JobepNwMetadata.ColumnNames.Sdescription, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Sdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.slbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(JobepNwMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(JobepNwMetadata.ColumnNames.Slbcs, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Slbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.sjlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(JobepNwMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(JobepNwMetadata.ColumnNames.Sjlbcs, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.Sjlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep_nw.jobep_nw_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? JobepNwId
		{
			get
			{
				return base.GetSystemInt32(JobepNwMetadata.ColumnNames.JobepNwId);
			}
			
			set
			{
				if(base.SetSystemInt32(JobepNwMetadata.ColumnNames.JobepNwId, value))
				{
					OnPropertyChanged(JobepNwMetadata.PropertyNames.JobepNwId);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return JobepNwMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public JobepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepNwQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(JobepNwQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(JobepNwQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((JobepNwQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private JobepNwQuery query;		
	}



	[Serializable]
	abstract public partial class esJobepNwCollection : esEntityCollection<JobepNwBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return JobepNwMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "JobepNwCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public JobepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepNwQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(JobepNwQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new JobepNwQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(JobepNwQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((JobepNwQuery)query);
		}

		#endregion
		
		private JobepNwQuery query;
	}



	[Serializable]
	abstract public partial class esJobepNwQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return JobepNwMetadata.Meta();
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
				case "JobepNwId": return this.JobepNwId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Colnum
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Colnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Line
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Line, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Sdescription
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Sdescription, esSystemType.String); }
		} 
		
		public esQueryItem Slbcs
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Slbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Sjlbcs
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.Sjlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem JobepNwId
		{
			get { return new esQueryItem(this, JobepNwMetadata.ColumnNames.JobepNwId, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class JobepNwBO : esJobepNwBO
	{

		
		
	}
	



	[Serializable]
	public partial class JobepNwMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected JobepNwMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepNwMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepNwMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepNwMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepNwMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepNwMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepNwMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepNwMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(JobepNwMetadata.ColumnNames.JobepNwId, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepNwMetadata.PropertyNames.JobepNwId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public JobepNwMetadata Meta()
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
			 public const string JobepNwId = "jobep_nw_id";
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
			 public const string JobepNwId = "JobepNwId";
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
			lock (typeof(JobepNwMetadata))
			{
				if(JobepNwMetadata.mapDelegates == null)
				{
					JobepNwMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (JobepNwMetadata.meta == null)
				{
					JobepNwMetadata.meta = new JobepNwMetadata();
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
				meta.AddTypeMap("JobepNwId", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "jobep_nw";
				meta.Destination = "jobep_nw";
				
				meta.spInsert = "proc_jobep_nwInsert";				
				meta.spUpdate = "proc_jobep_nwUpdate";		
				meta.spDelete = "proc_jobep_nwDelete";
				meta.spLoadAll = "proc_jobep_nwLoadAll";
				meta.spLoadByPrimaryKey = "proc_jobep_nwLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private JobepNwMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
