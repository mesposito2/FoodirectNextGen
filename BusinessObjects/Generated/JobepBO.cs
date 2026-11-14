/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 9/15/2019 10:45:50 AM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{

	[Serializable]
	abstract public class esJobepCollection : esEntityCollection
	{
		public esJobepCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "JobepCollection";
		}

		#region Query Logic
		protected void InitQuery(esJobepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esJobepQuery);
		}
		#endregion
		
		virtual public JobepBO DetachEntity(JobepBO entity)
		{
			return base.DetachEntity(entity) as JobepBO;
		}
		
		virtual public JobepBO AttachEntity(JobepBO entity)
		{
			return base.AttachEntity(entity) as JobepBO;
		}
		
		virtual public void Combine(JobepCollection collection)
		{
			base.Combine(collection);
		}
		
		new public JobepBO this[int index]
		{
			get
			{
				return base[index] as JobepBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(JobepBO);
		}
	}



	[Serializable]
	abstract public class esJobepBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esJobepQuery GetDynamicQuery()
		{
			return null;
		}

		public esJobepBO()
		{

		}

		public esJobepBO(DataRow row)
			: base(row)
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
			esJobepQuery query = this.GetDynamicQuery();
			query.Where(query.JobepId == jobepId);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 jobepId)
		{
			esParameters parms = new esParameters();
			parms.Add("jobep_id",jobepId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Custid": this.str.Custid = (string)value; break;							
						case "Colnum": this.str.Colnum = (string)value; break;							
						case "Line": this.str.Line = (string)value; break;							
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Sdescription": this.str.Sdescription = (string)value; break;							
						case "Slbcs": this.str.Slbcs = (string)value; break;							
						case "Sjlbcs": this.str.Sjlbcs = (string)value; break;							
						case "JobepId": this.str.JobepId = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Colnum":
						
							if (value == null || value is System.Int32)
								this.Colnum = (System.Int32?)value;
							break;
						
						case "Line":
						
							if (value == null || value is System.Int32)
								this.Line = (System.Int32?)value;
							break;
						
						case "Slbcs":
						
							if (value == null || value is System.Double)
								this.Slbcs = (System.Double?)value;
							break;
						
						case "Sjlbcs":
						
							if (value == null || value is System.Double)
								this.Sjlbcs = (System.Double?)value;
							break;
						
						case "JobepId":
						
							if (value == null || value is System.Int32)
								this.JobepId = (System.Int32?)value;
							break;
					

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to jobep.custid
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.colnum
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.line
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.productcode
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.sdescription
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.slbcs
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.sjlbcs
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to jobep.jobep_id
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(JobepMetadata.PropertyNames.JobepId));
					}
				}
			}
		}
		
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
		sealed public class esStrings
		{
			public esStrings(esJobepBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Custid
			{
				get
				{
					System.String data = entity.Custid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Custid = null;
					else entity.Custid = Convert.ToString(value);
				}
			}
				
			public System.String Colnum
			{
				get
				{
					System.Int32? data = entity.Colnum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Colnum = null;
					else entity.Colnum = Convert.ToInt32(value);
				}
			}
				
			public System.String Line
			{
				get
				{
					System.Int32? data = entity.Line;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Line = null;
					else entity.Line = Convert.ToInt32(value);
				}
			}
				
			public System.String Productcode
			{
				get
				{
					System.String data = entity.Productcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productcode = null;
					else entity.Productcode = Convert.ToString(value);
				}
			}
				
			public System.String Sdescription
			{
				get
				{
					System.String data = entity.Sdescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sdescription = null;
					else entity.Sdescription = Convert.ToString(value);
				}
			}
				
			public System.String Slbcs
			{
				get
				{
					System.Double? data = entity.Slbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Slbcs = null;
					else entity.Slbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String Sjlbcs
			{
				get
				{
					System.Double? data = entity.Sjlbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sjlbcs = null;
					else entity.Sjlbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String JobepId
			{
				get
				{
					System.Int32? data = entity.JobepId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobepId = null;
					else entity.JobepId = Convert.ToInt32(value);
				}
			}
			

			private esJobepBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esJobepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esJobepBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esJobepQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return JobepMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem JobepId
		{
			get
			{
				return new esQueryItem(this, JobepMetadata.ColumnNames.JobepId, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("JobepCollection")]
	public partial class JobepCollection : esJobepCollection, IEnumerable<JobepBO>
	{
		public JobepCollection()
		{

		}
		
		public static implicit operator List<JobepBO>(JobepCollection coll)
		{
			List<JobepBO> list = new List<JobepBO>();
			
			foreach (JobepBO emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  JobepMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new JobepBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new JobepBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public JobepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(JobepQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public JobepBO AddNew()
		{
			JobepBO entity = base.AddNewEntity() as JobepBO;
			
			return entity;
		}

		public JobepBO FindByPrimaryKey(System.Int32 jobepId)
		{
			return base.FindByPrimaryKey(jobepId) as JobepBO;
		}


		#region IEnumerable<JobepBO> Members

		IEnumerator<JobepBO> IEnumerable<JobepBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as JobepBO;
			}
		}

		#endregion
		
		private JobepQuery query;
	}


	/// <summary>
	/// Encapsulates the 'jobep' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("JobepBO ({JobepId})")]
	[Serializable]
	public partial class JobepBO : esJobepBO
	{
		public JobepBO()
		{

		}
	
		public JobepBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return JobepMetadata.Meta();
			}
		}
		
		
		
		override protected esJobepQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new JobepQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public JobepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new JobepQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(JobepQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private JobepQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class JobepQuery : esJobepQuery
	{
		public JobepQuery()
		{

		}		
		
		public JobepQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "JobepQuery";
        }
		
			
	}


	[Serializable]
	public partial class JobepMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected JobepMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(JobepMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = JobepMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = JobepMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(JobepMetadata.ColumnNames.JobepId, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = JobepMetadata.PropertyNames.JobepId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public JobepMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private JobepMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
