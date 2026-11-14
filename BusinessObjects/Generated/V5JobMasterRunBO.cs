/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 4/11/2020 11:21:52 AM
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
	abstract public class esV5JobMasterRunCollection : esEntityCollection
	{
		public esV5JobMasterRunCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5JobMasterRunCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5JobMasterRunQuery query)
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
			this.InitQuery(query as esV5JobMasterRunQuery);
		}
		#endregion
		
		virtual public V5JobMasterRunBO DetachEntity(V5JobMasterRunBO entity)
		{
			return base.DetachEntity(entity) as V5JobMasterRunBO;
		}
		
		virtual public V5JobMasterRunBO AttachEntity(V5JobMasterRunBO entity)
		{
			return base.AttachEntity(entity) as V5JobMasterRunBO;
		}
		
		virtual public void Combine(V5JobMasterRunCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5JobMasterRunBO this[int index]
		{
			get
			{
				return base[index] as V5JobMasterRunBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5JobMasterRunBO);
		}
	}



	[Serializable]
	abstract public class esV5JobMasterRunBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5JobMasterRunQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5JobMasterRunBO()
		{

		}

		public esV5JobMasterRunBO(DataRow row)
			: base(row)
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
			esV5JobMasterRunQuery query = this.GetDynamicQuery();
			query.Where(query.JobMasterRunID == jobMasterRunID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 jobMasterRunID)
		{
			esParameters parms = new esParameters();
			parms.Add("JobMasterRunID",jobMasterRunID);
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
						case "JobMasterRunID": this.str.JobMasterRunID = (string)value; break;							
						case "CreatedByDate": this.str.CreatedByDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "StatusUcode": this.str.StatusUcode = (string)value; break;							
						case "Parameters": this.str.Parameters = (string)value; break;							
						case "Output": this.str.Output = (string)value; break;							
						case "RunDateTime": this.str.RunDateTime = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "JobMasterRunID":
						
							if (value == null || value is System.Int32)
								this.JobMasterRunID = (System.Int32?)value;
							break;
						
						case "CreatedByDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedByDate = (System.DateTime?)value;
							break;
						
						case "RunDateTime":
						
							if (value == null || value is System.DateTime)
								this.RunDateTime = (System.DateTime?)value;
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
		/// Maps to V5JobMasterRun.JobMasterRunID
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.JobMasterRunID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.CreatedByDate
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.CreatedByDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.CreatedBy
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Status_Ucode
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.StatusUcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Parameters
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.Parameters));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.Output
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.Output));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5JobMasterRun.RunDateTime
		/// </summary>
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
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5JobMasterRunMetadata.PropertyNames.RunDateTime));
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
			public esStrings(esV5JobMasterRunBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String JobMasterRunID
			{
				get
				{
					System.Int32? data = entity.JobMasterRunID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobMasterRunID = null;
					else entity.JobMasterRunID = Convert.ToInt32(value);
				}
			}
				
			public System.String CreatedByDate
			{
				get
				{
					System.DateTime? data = entity.CreatedByDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedByDate = null;
					else entity.CreatedByDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String CreatedBy
			{
				get
				{
					System.String data = entity.CreatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedBy = null;
					else entity.CreatedBy = Convert.ToString(value);
				}
			}
				
			public System.String StatusUcode
			{
				get
				{
					System.String data = entity.StatusUcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StatusUcode = null;
					else entity.StatusUcode = Convert.ToString(value);
				}
			}
				
			public System.String Parameters
			{
				get
				{
					System.String data = entity.Parameters;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Parameters = null;
					else entity.Parameters = Convert.ToString(value);
				}
			}
				
			public System.String Output
			{
				get
				{
					System.String data = entity.Output;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Output = null;
					else entity.Output = Convert.ToString(value);
				}
			}
				
			public System.String RunDateTime
			{
				get
				{
					System.DateTime? data = entity.RunDateTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RunDateTime = null;
					else entity.RunDateTime = Convert.ToDateTime(value);
				}
			}
			

			private esV5JobMasterRunBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5JobMasterRunQuery query)
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
				throw new Exception("esV5JobMasterRunBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esV5JobMasterRunQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5JobMasterRunMetadata.Meta();
			}
		}	
		

		public esQueryItem JobMasterRunID
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.JobMasterRunID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem CreatedByDate
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem StatusUcode
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.StatusUcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Parameters
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.Parameters, esSystemType.String);
			}
		} 
		
		public esQueryItem Output
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.Output, esSystemType.String);
			}
		} 
		
		public esQueryItem RunDateTime
		{
			get
			{
				return new esQueryItem(this, V5JobMasterRunMetadata.ColumnNames.RunDateTime, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("V5JobMasterRunCollection")]
	public partial class V5JobMasterRunCollection : esV5JobMasterRunCollection, IEnumerable<V5JobMasterRunBO>
	{
		public V5JobMasterRunCollection()
		{

		}
		
		public static implicit operator List<V5JobMasterRunBO>(V5JobMasterRunCollection coll)
		{
			List<V5JobMasterRunBO> list = new List<V5JobMasterRunBO>();
			
			foreach (V5JobMasterRunBO emp in coll)
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
				return  V5JobMasterRunMetadata.Meta();
			}
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
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5JobMasterRunBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5JobMasterRunBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5JobMasterRunQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5JobMasterRunQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5JobMasterRunQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5JobMasterRunBO AddNew()
		{
			V5JobMasterRunBO entity = base.AddNewEntity() as V5JobMasterRunBO;
			
			return entity;
		}

		public V5JobMasterRunBO FindByPrimaryKey(System.Int32 jobMasterRunID)
		{
			return base.FindByPrimaryKey(jobMasterRunID) as V5JobMasterRunBO;
		}


		#region IEnumerable<V5JobMasterRunBO> Members

		IEnumerator<V5JobMasterRunBO> IEnumerable<V5JobMasterRunBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5JobMasterRunBO;
			}
		}

		#endregion
		
		private V5JobMasterRunQuery query;
	}


	/// <summary>
	/// Encapsulates the 'V5JobMasterRun' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("V5JobMasterRunBO ({JobMasterRunID})")]
	[Serializable]
	public partial class V5JobMasterRunBO : esV5JobMasterRunBO
	{
		public V5JobMasterRunBO()
		{

		}
	
		public V5JobMasterRunBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5JobMasterRunMetadata.Meta();
			}
		}
		
		
		
		override protected esV5JobMasterRunQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5JobMasterRunQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5JobMasterRunQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5JobMasterRunQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5JobMasterRunQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5JobMasterRunQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class V5JobMasterRunQuery : esV5JobMasterRunQuery
	{
		public V5JobMasterRunQuery()
		{

		}		
		
		public V5JobMasterRunQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5JobMasterRunQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5JobMasterRunMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5JobMasterRunMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.JobMasterRunID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.JobMasterRunID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.CreatedByDate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.CreatedByDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.CreatedBy, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.StatusUcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.StatusUcode;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.Parameters, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.Parameters;
			c.CharacterMaxLength = 255;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.Output, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.Output;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5JobMasterRunMetadata.ColumnNames.RunDateTime, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5JobMasterRunMetadata.PropertyNames.RunDateTime;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5JobMasterRunMetadata Meta()
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
			if(!_providerMetadataMaps.ContainsKey(mapName))
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
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5JobMasterRunMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
