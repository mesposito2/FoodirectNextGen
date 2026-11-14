/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 10/8/2015 6:01:36 PM
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
	abstract public class esV5SalesManCollection : esEntityCollection
	{
		public esV5SalesManCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5SalesManCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5SalesManQuery query)
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
			this.InitQuery(query as esV5SalesManQuery);
		}
		#endregion
		
		virtual public V5SalesManBO DetachEntity(V5SalesManBO entity)
		{
			return base.DetachEntity(entity) as V5SalesManBO;
		}
		
		virtual public V5SalesManBO AttachEntity(V5SalesManBO entity)
		{
			return base.AttachEntity(entity) as V5SalesManBO;
		}
		
		virtual public void Combine(V5SalesManCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5SalesManBO this[int index]
		{
			get
			{
				return base[index] as V5SalesManBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5SalesManBO);
		}
	}



	[Serializable]
	abstract public class esV5SalesManBO : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5SalesManQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5SalesManBO()
		{

		}

		public esV5SalesManBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesManID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesManID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesManID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesManID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesManID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesManID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesManID)
		{
			esV5SalesManQuery query = this.GetDynamicQuery();
			query.Where(query.SalesManID == salesManID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesManID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesManID",salesManID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
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
						case "SalesManID": this.str.SalesManID = (string)value; break;							
						case "Initial": this.str.Initial = (string)value; break;							
						case "Name": this.str.Name = (string)value; break;							
						case "Email": this.str.Email = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "CreatedByDate": this.str.CreatedByDate = (string)value; break;							
						case "Active": this.str.Active = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "SalesManID":
						
							if (value == null || value is System.Int32)
								this.SalesManID = (System.Int32?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
							break;
						
						case "CreatedByDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedByDate = (System.DateTime?)value;
							break;
						
						case "Active":
						
							if (value == null || value is System.Boolean)
								this.Active = (System.Boolean?)value;
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
		/// Maps to v5SalesMan.SalesManID
		/// </summary>
		virtual public System.Int32? SalesManID
		{
			get
			{
				return base.GetSystemInt32(V5SalesManMetadata.ColumnNames.SalesManID);
			}
			
			set
			{
				base.SetSystemInt32(V5SalesManMetadata.ColumnNames.SalesManID, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Initial
		/// </summary>
		virtual public System.String Initial
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Initial);
			}
			
			set
			{
				base.SetSystemString(V5SalesManMetadata.ColumnNames.Initial, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Name
		/// </summary>
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Name);
			}
			
			set
			{
				base.SetSystemString(V5SalesManMetadata.ColumnNames.Name, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.Email
		/// </summary>
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.Email);
			}
			
			set
			{
				base.SetSystemString(V5SalesManMetadata.ColumnNames.Email, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.LastUpdatedBy
		/// </summary>
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				base.SetSystemString(V5SalesManMetadata.ColumnNames.LastUpdatedBy, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.LastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(V5SalesManMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				base.SetSystemDateTime(V5SalesManMetadata.ColumnNames.LastUpdate, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5SalesManMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				base.SetSystemString(V5SalesManMetadata.ColumnNames.CreatedBy, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.CreatedByDate
		/// </summary>
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5SalesManMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				base.SetSystemDateTime(V5SalesManMetadata.ColumnNames.CreatedByDate, value);
			}
		}
		
		/// <summary>
		/// Maps to v5SalesMan.active
		/// </summary>
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(V5SalesManMetadata.ColumnNames.Active);
			}
			
			set
			{
				base.SetSystemBoolean(V5SalesManMetadata.ColumnNames.Active, value);
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
			public esStrings(esV5SalesManBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String SalesManID
			{
				get
				{
					System.Int32? data = entity.SalesManID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalesManID = null;
					else entity.SalesManID = Convert.ToInt32(value);
				}
			}
				
			public System.String Initial
			{
				get
				{
					System.String data = entity.Initial;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Initial = null;
					else entity.Initial = Convert.ToString(value);
				}
			}
				
			public System.String Name
			{
				get
				{
					System.String data = entity.Name;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Name = null;
					else entity.Name = Convert.ToString(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdatedBy
			{
				get
				{
					System.String data = entity.LastUpdatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdatedBy = null;
					else entity.LastUpdatedBy = Convert.ToString(value);
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
				
			public System.String Active
			{
				get
				{
					System.Boolean? data = entity.Active;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Active = null;
					else entity.Active = Convert.ToBoolean(value);
				}
			}
			

			private esV5SalesManBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5SalesManQuery query)
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
				throw new Exception("esV5SalesManBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class V5SalesManBO : esV5SalesManBO
	{

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esV5SalesManQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5SalesManMetadata.Meta();
			}
		}	
		

		public esQueryItem SalesManID
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.SalesManID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Initial
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Initial, esSystemType.String);
			}
		} 
		
		public esQueryItem Name
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Name, esSystemType.String);
			}
		} 
		
		public esQueryItem Email
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Email, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem CreatedByDate
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Active
		{
			get
			{
				return new esQueryItem(this, V5SalesManMetadata.ColumnNames.Active, esSystemType.Boolean);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("V5SalesManCollection")]
	public partial class V5SalesManCollection : esV5SalesManCollection, IEnumerable<V5SalesManBO>
	{
		public V5SalesManCollection()
		{

		}
		
		public static implicit operator List<V5SalesManBO>(V5SalesManCollection coll)
		{
			List<V5SalesManBO> list = new List<V5SalesManBO>();
			
			foreach (V5SalesManBO emp in coll)
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
				return  V5SalesManMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5SalesManQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5SalesManBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5SalesManBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5SalesManQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5SalesManQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5SalesManQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5SalesManBO AddNew()
		{
			V5SalesManBO entity = base.AddNewEntity() as V5SalesManBO;
			
			return entity;
		}

		public V5SalesManBO FindByPrimaryKey(System.Int32 salesManID)
		{
			return base.FindByPrimaryKey(salesManID) as V5SalesManBO;
		}


		#region IEnumerable<V5SalesManBO> Members

		IEnumerator<V5SalesManBO> IEnumerable<V5SalesManBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5SalesManBO;
			}
		}

		#endregion
		
		private V5SalesManQuery query;
	}


	/// <summary>
	/// Encapsulates the 'v5SalesMan' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("V5SalesManBO ({SalesManID})")]
	[Serializable]
	public partial class V5SalesManBO : esV5SalesManBO
	{
		public V5SalesManBO()
		{

		}
	
		public V5SalesManBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5SalesManMetadata.Meta();
			}
		}
		
		
		
		override protected esV5SalesManQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5SalesManQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5SalesManQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5SalesManQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5SalesManQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5SalesManQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class V5SalesManQuery : esV5SalesManQuery
	{
		public V5SalesManQuery()
		{

		}		
		
		public V5SalesManQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5SalesManQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5SalesManMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5SalesManMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.SalesManID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5SalesManMetadata.PropertyNames.SalesManID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Initial, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Initial;
			c.CharacterMaxLength = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Name, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Email, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.LastUpdatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.LastUpdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5SalesManMetadata.PropertyNames.LastUpdate;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.CreatedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5SalesManMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.CreatedByDate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5SalesManMetadata.PropertyNames.CreatedByDate;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5SalesManMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5SalesManMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5SalesManMetadata Meta()
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
			 public const string SalesManID = "SalesManID";
			 public const string Initial = "Initial";
			 public const string Name = "Name";
			 public const string Email = "Email";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string Active = "active";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesManID = "SalesManID";
			 public const string Initial = "Initial";
			 public const string Name = "Name";
			 public const string Email = "Email";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string Active = "Active";
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
			lock (typeof(V5SalesManMetadata))
			{
				if(V5SalesManMetadata.mapDelegates == null)
				{
					V5SalesManMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5SalesManMetadata.meta == null)
				{
					V5SalesManMetadata.meta = new V5SalesManMetadata();
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
				

				meta.AddTypeMap("SalesManID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Initial", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Name", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("date", "System.DateTime"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "v5SalesMan";
				meta.Destination = "v5SalesMan";
				
				meta.spInsert = "proc_v5SalesManInsert";				
				meta.spUpdate = "proc_v5SalesManUpdate";		
				meta.spDelete = "proc_v5SalesManDelete";
				meta.spLoadAll = "proc_v5SalesManLoadAll";
				meta.spLoadByPrimaryKey = "proc_v5SalesManLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5SalesManMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
