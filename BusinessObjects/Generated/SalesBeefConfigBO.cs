/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 4/29/2015 9:02:10 PM
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
	abstract public class esSalesBeefConfigCollection : esEntityCollection
	{
		public esSalesBeefConfigCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SalesBeefConfigCollection";
		}

		#region Query Logic
		protected void InitQuery(esSalesBeefConfigQuery query)
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
			this.InitQuery(query as esSalesBeefConfigQuery);
		}
		#endregion
		
		virtual public SalesBeefConfigBO DetachEntity(SalesBeefConfigBO entity)
		{
			return base.DetachEntity(entity) as SalesBeefConfigBO;
		}
		
		virtual public SalesBeefConfigBO AttachEntity(SalesBeefConfigBO entity)
		{
			return base.AttachEntity(entity) as SalesBeefConfigBO;
		}
		
		virtual public void Combine(SalesBeefConfigCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SalesBeefConfigBO this[int index]
		{
			get
			{
				return base[index] as SalesBeefConfigBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SalesBeefConfigBO);
		}
	}



	[Serializable]
	abstract public class esSalesBeefConfigBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSalesBeefConfigQuery GetDynamicQuery()
		{
			return null;
		}

		public esSalesBeefConfigBO()
		{

		}

		public esSalesBeefConfigBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesBeefConfigID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesBeefConfigID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesBeefConfigID)
		{
			esSalesBeefConfigQuery query = this.GetDynamicQuery();
			query.Where(query.SalesBeefConfigID == salesBeefConfigID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesBeefConfigID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesBeefConfigID",salesBeefConfigID);
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
						case "SalesBeefConfigID": this.str.SalesBeefConfigID = (string)value; break;							
						case "IsCurrent": this.str.IsCurrent = (string)value; break;							
						case "Title": this.str.Title = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "Createdby": this.str.Createdby = (string)value; break;							
						case "LastUpdatedby": this.str.LastUpdatedby = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "SalesBeefConfigID":
						
							if (value == null || value is System.Int32)
								this.SalesBeefConfigID = (System.Int32?)value;
							break;
						
						case "IsCurrent":
						
							if (value == null || value is System.Boolean)
								this.IsCurrent = (System.Boolean?)value;
							break;
						
						case "Title":
						
							if (value == null || value is System.Boolean)
								this.Title = (System.Boolean?)value;
							break;
						
						case "CreateDate":
						
							if (value == null || value is System.DateTime)
								this.CreateDate = (System.DateTime?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
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
		/// Maps to SalesBeefConfig.SalesBeefConfigID
		/// </summary>
		virtual public System.Int32? SalesBeefConfigID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.SalesBeefConfigID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.IsCurrent
		/// </summary>
		virtual public System.Boolean? IsCurrent
		{
			get
			{
				return base.GetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.IsCurrent);
			}
			
			set
			{
				if(base.SetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.IsCurrent, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.IsCurrent));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.Title
		/// </summary>
		virtual public System.Boolean? Title
		{
			get
			{
				return base.GetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemBoolean(SalesBeefConfigMetadata.ColumnNames.Title, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.Title));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.LastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SalesBeefConfigMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.Createdby
		/// </summary>
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(SalesBeefConfigMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(SalesBeefConfigMetadata.ColumnNames.Createdby, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.Createdby));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfig.LastUpdatedby
		/// </summary>
		virtual public System.String LastUpdatedby
		{
			get
			{
				return base.GetSystemString(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby);
			}
			
			set
			{
				if(base.SetSystemString(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigMetadata.PropertyNames.LastUpdatedby));
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
			public esStrings(esSalesBeefConfigBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String SalesBeefConfigID
			{
				get
				{
					System.Int32? data = entity.SalesBeefConfigID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalesBeefConfigID = null;
					else entity.SalesBeefConfigID = Convert.ToInt32(value);
				}
			}
				
			public System.String IsCurrent
			{
				get
				{
					System.Boolean? data = entity.IsCurrent;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsCurrent = null;
					else entity.IsCurrent = Convert.ToBoolean(value);
				}
			}
				
			public System.String Title
			{
				get
				{
					System.Boolean? data = entity.Title;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Title = null;
					else entity.Title = Convert.ToBoolean(value);
				}
			}
				
			public System.String CreateDate
			{
				get
				{
					System.DateTime? data = entity.CreateDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreateDate = null;
					else entity.CreateDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String LastUpdate
			{
				get
				{
					System.DateTime? data = entity.LastUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdate = null;
					else entity.LastUpdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Createdby
			{
				get
				{
					System.String data = entity.Createdby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Createdby = null;
					else entity.Createdby = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdatedby
			{
				get
				{
					System.String data = entity.LastUpdatedby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdatedby = null;
					else entity.LastUpdatedby = Convert.ToString(value);
				}
			}
			

			private esSalesBeefConfigBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSalesBeefConfigQuery query)
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
				throw new Exception("esSalesBeefConfigBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSalesBeefConfigQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigMetadata.Meta();
			}
		}	
		

		public esQueryItem SalesBeefConfigID
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem IsCurrent
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.IsCurrent, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Title
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.Title, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Createdby
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.Createdby, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdatedby
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("SalesBeefConfigCollection")]
	public partial class SalesBeefConfigCollection : esSalesBeefConfigCollection, IEnumerable<SalesBeefConfigBO>
	{
		public SalesBeefConfigCollection()
		{

		}
		
		public static implicit operator List<SalesBeefConfigBO>(SalesBeefConfigCollection coll)
		{
			List<SalesBeefConfigBO> list = new List<SalesBeefConfigBO>();
			
			foreach (SalesBeefConfigBO emp in coll)
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
				return  SalesBeefConfigMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SalesBeefConfigBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SalesBeefConfigBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SalesBeefConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SalesBeefConfigQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SalesBeefConfigBO AddNew()
		{
			SalesBeefConfigBO entity = base.AddNewEntity() as SalesBeefConfigBO;
			
			return entity;
		}

		public SalesBeefConfigBO FindByPrimaryKey(System.Int32 salesBeefConfigID)
		{
			return base.FindByPrimaryKey(salesBeefConfigID) as SalesBeefConfigBO;
		}


		#region IEnumerable<SalesBeefConfigBO> Members

		IEnumerator<SalesBeefConfigBO> IEnumerable<SalesBeefConfigBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SalesBeefConfigBO;
			}
		}

		#endregion
		
		private SalesBeefConfigQuery query;
	}


	/// <summary>
	/// Encapsulates the 'SalesBeefConfig' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("SalesBeefConfigBO ({SalesBeefConfigID})")]
	[Serializable]
	public partial class SalesBeefConfigBO : esSalesBeefConfigBO
	{
		public SalesBeefConfigBO()
		{

		}
	
		public SalesBeefConfigBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigMetadata.Meta();
			}
		}
		
		
		
		override protected esSalesBeefConfigQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SalesBeefConfigQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SalesBeefConfigQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SalesBeefConfigQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class SalesBeefConfigQuery : esSalesBeefConfigQuery
	{
		public SalesBeefConfigQuery()
		{

		}		
		
		public SalesBeefConfigQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SalesBeefConfigQuery";
        }
		
			
	}


	[Serializable]
	public partial class SalesBeefConfigMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalesBeefConfigMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.SalesBeefConfigID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.SalesBeefConfigID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.IsCurrent, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.IsCurrent;
			c.HasDefault = true;
			c.Default = @"((1))";
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.Title, 2, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.Title;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.LastUpdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigMetadata.ColumnNames.LastUpdatedby, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = SalesBeefConfigMetadata.PropertyNames.LastUpdatedby;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SalesBeefConfigMetadata Meta()
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
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string Title = "Title";
			 public const string CreateDate = "CreateDate";
			 public const string LastUpdate = "LastUpdate";
			 public const string Createdby = "Createdby";
			 public const string LastUpdatedby = "LastUpdatedby";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string IsCurrent = "IsCurrent";
			 public const string Title = "Title";
			 public const string CreateDate = "CreateDate";
			 public const string LastUpdate = "LastUpdate";
			 public const string Createdby = "Createdby";
			 public const string LastUpdatedby = "LastUpdatedby";
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
			lock (typeof(SalesBeefConfigMetadata))
			{
				if(SalesBeefConfigMetadata.mapDelegates == null)
				{
					SalesBeefConfigMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalesBeefConfigMetadata.meta == null)
				{
					SalesBeefConfigMetadata.meta = new SalesBeefConfigMetadata();
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
				

				meta.AddTypeMap("SalesBeefConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsCurrent", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Title", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedby", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "SalesBeefConfig";
				meta.Destination = "SalesBeefConfig";
				
				meta.spInsert = "proc_SalesBeefConfigInsert";				
				meta.spUpdate = "proc_SalesBeefConfigUpdate";		
				meta.spDelete = "proc_SalesBeefConfigDelete";
				meta.spLoadAll = "proc_SalesBeefConfigLoadAll";
				meta.spLoadByPrimaryKey = "proc_SalesBeefConfigLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalesBeefConfigMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
