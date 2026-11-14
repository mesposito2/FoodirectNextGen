/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 5/6/2023 2:34:54 PM
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
	abstract public class esProdCustGuideCollection : esEntityCollection
	{
		public esProdCustGuideCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ProdCustGuideCollection";
		}

		#region Query Logic
		protected void InitQuery(esProdCustGuideQuery query)
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
			this.InitQuery(query as esProdCustGuideQuery);
		}
		#endregion
		
		virtual public ProdCustGuideBO DetachEntity(ProdCustGuideBO entity)
		{
			return base.DetachEntity(entity) as ProdCustGuideBO;
		}
		
		virtual public ProdCustGuideBO AttachEntity(ProdCustGuideBO entity)
		{
			return base.AttachEntity(entity) as ProdCustGuideBO;
		}
		
		virtual public void Combine(ProdCustGuideCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ProdCustGuideBO this[int index]
		{
			get
			{
				return base[index] as ProdCustGuideBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ProdCustGuideBO);
		}
	}



	[Serializable]
	abstract public class esProdCustGuideBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esProdCustGuideQuery GetDynamicQuery()
		{
			return null;
		}

		public esProdCustGuideBO()
		{

		}

		public esProdCustGuideBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 prodCustGuideID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(prodCustGuideID);
			else
				return LoadByPrimaryKeyStoredProcedure(prodCustGuideID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 prodCustGuideID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(prodCustGuideID);
			else
				return LoadByPrimaryKeyStoredProcedure(prodCustGuideID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 prodCustGuideID)
		{
			esProdCustGuideQuery query = this.GetDynamicQuery();
			query.Where(query.ProdCustGuideID == prodCustGuideID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 prodCustGuideID)
		{
			esParameters parms = new esParameters();
			parms.Add("ProdCustGuideID",prodCustGuideID);
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
						case "ProdCustGuideID": this.str.ProdCustGuideID = (string)value; break;							
						case "ProductCode": this.str.ProductCode = (string)value; break;							
						case "CustID": this.str.CustID = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "ProdCustGuideID":
						
							if (value == null || value is System.Int32)
								this.ProdCustGuideID = (System.Int32?)value;
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
		/// Maps to ProdCustGuide.ProdCustGuideID
		/// </summary>
		virtual public System.Int32? ProdCustGuideID
		{
			get
			{
				return base.GetSystemInt32(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.ProdCustGuideID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.ProductCode
		/// </summary>
		virtual public System.String ProductCode
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.ProductCode);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.ProductCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.ProductCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CustID
		/// </summary>
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.CustID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.CustID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(ProdCustGuideMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ProdCustGuideMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.LastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(ProdCustGuideMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ProdCustGuideMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.LastUpdatedBy
		/// </summary>
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdCustGuideMetadata.PropertyNames.LastUpdatedBy));
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
			public esStrings(esProdCustGuideBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String ProdCustGuideID
			{
				get
				{
					System.Int32? data = entity.ProdCustGuideID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProdCustGuideID = null;
					else entity.ProdCustGuideID = Convert.ToInt32(value);
				}
			}
				
			public System.String ProductCode
			{
				get
				{
					System.String data = entity.ProductCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductCode = null;
					else entity.ProductCode = Convert.ToString(value);
				}
			}
				
			public System.String CustID
			{
				get
				{
					System.String data = entity.CustID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CustID = null;
					else entity.CustID = Convert.ToString(value);
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
			

			private esProdCustGuideBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esProdCustGuideQuery query)
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
				throw new Exception("esProdCustGuideBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esProdCustGuideQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdCustGuideMetadata.Meta();
			}
		}	
		

		public esQueryItem ProdCustGuideID
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem ProductCode
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.ProductCode, esSystemType.String);
			}
		} 
		
		public esQueryItem CustID
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CustID, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
	}



	[Serializable]
	[XmlType("ProdCustGuideCollection")]
	public partial class ProdCustGuideCollection : esProdCustGuideCollection, IEnumerable<ProdCustGuideBO>
	{
		public ProdCustGuideCollection()
		{

		}
		
		public static implicit operator List<ProdCustGuideBO>(ProdCustGuideCollection coll)
		{
			List<ProdCustGuideBO> list = new List<ProdCustGuideBO>();
			
			foreach (ProdCustGuideBO emp in coll)
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
				return  ProdCustGuideMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdCustGuideQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ProdCustGuideBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ProdCustGuideBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ProdCustGuideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdCustGuideQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ProdCustGuideQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ProdCustGuideBO AddNew()
		{
			ProdCustGuideBO entity = base.AddNewEntity() as ProdCustGuideBO;
			
			return entity;
		}

		public ProdCustGuideBO FindByPrimaryKey(System.Int32 prodCustGuideID)
		{
			return base.FindByPrimaryKey(prodCustGuideID) as ProdCustGuideBO;
		}


		#region IEnumerable<ProdCustGuideBO> Members

		IEnumerator<ProdCustGuideBO> IEnumerable<ProdCustGuideBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ProdCustGuideBO;
			}
		}

		#endregion
		
		private ProdCustGuideQuery query;
	}


	/// <summary>
	/// Encapsulates the 'ProdCustGuide' table
	/// </summary>

	[Serializable]
	public partial class ProdCustGuideBO : esProdCustGuideBO
	{
		public ProdCustGuideBO()
		{

		}
	
		public ProdCustGuideBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdCustGuideMetadata.Meta();
			}
		}
		
		
		
		override protected esProdCustGuideQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdCustGuideQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ProdCustGuideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdCustGuideQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ProdCustGuideQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ProdCustGuideQuery query;
	}



	[Serializable]
		
	public partial class ProdCustGuideQuery : esProdCustGuideQuery
	{
		public ProdCustGuideQuery()
		{

		}		
		
		public ProdCustGuideQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ProdCustGuideQuery";
        }
		
			
	}


	[Serializable]
	public partial class ProdCustGuideMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdCustGuideMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.ProdCustGuideID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.ProductCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.ProductCode;
			c.CharacterMaxLength = 6;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CustID, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CreateDate;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CreatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.LastUpdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.LastUpdate;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdCustGuideMetadata Meta()
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
			 public const string ProdCustGuideID = "ProdCustGuideID";
			 public const string ProductCode = "ProductCode";
			 public const string CustID = "CustID";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ProdCustGuideID = "ProdCustGuideID";
			 public const string ProductCode = "ProductCode";
			 public const string CustID = "CustID";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(ProdCustGuideMetadata))
			{
				if(ProdCustGuideMetadata.mapDelegates == null)
				{
					ProdCustGuideMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdCustGuideMetadata.meta == null)
				{
					ProdCustGuideMetadata.meta = new ProdCustGuideMetadata();
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
				

				meta.AddTypeMap("ProdCustGuideID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ProductCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "ProdCustGuide";
				meta.Destination = "ProdCustGuide";
				
				meta.spInsert = "proc_ProdCustGuideInsert";				
				meta.spUpdate = "proc_ProdCustGuideUpdate";		
				meta.spDelete = "proc_ProdCustGuideDelete";
				meta.spLoadAll = "proc_ProdCustGuideLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProdCustGuideLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdCustGuideMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
