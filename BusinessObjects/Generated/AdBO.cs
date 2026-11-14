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
	abstract public class esAdCollection : esEntityCollection
	{
		public esAdCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "AdCollection";
		}

		#region Query Logic
		protected void InitQuery(esAdQuery query)
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
			this.InitQuery(query as esAdQuery);
		}
		#endregion
		
		virtual public AdBO DetachEntity(AdBO entity)
		{
			return base.DetachEntity(entity) as AdBO;
		}
		
		virtual public AdBO AttachEntity(AdBO entity)
		{
			return base.AttachEntity(entity) as AdBO;
		}
		
		virtual public void Combine(AdCollection collection)
		{
			base.Combine(collection);
		}
		
		new public AdBO this[int index]
		{
			get
			{
				return base[index] as AdBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(AdBO);
		}
	}



	[Serializable]
	abstract public class esAdBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esAdQuery GetDynamicQuery()
		{
			return null;
		}

		public esAdBO()
		{

		}

		public esAdBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 adID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(adID);
			else
				return LoadByPrimaryKeyStoredProcedure(adID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 adID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(adID);
			else
				return LoadByPrimaryKeyStoredProcedure(adID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 adID)
		{
			esAdQuery query = this.GetDynamicQuery();
			query.Where(query.AdID == adID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 adID)
		{
			esParameters parms = new esParameters();
			parms.Add("AdID",adID);
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
						case "AdID": this.str.AdID = (string)value; break;							
						case "AdName": this.str.AdName = (string)value; break;							
						case "AdImage": this.str.AdImage = (string)value; break;							
						case "AltText": this.str.AltText = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;							
						case "Active": this.str.Active = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "AdID":
						
							if (value == null || value is System.Int32)
								this.AdID = (System.Int32?)value;
							break;
						
						case "CreateDate":
						
							if (value == null || value is System.DateTime)
								this.CreateDate = (System.DateTime?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
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
		/// Maps to Ad.AdID
		/// </summary>
		virtual public System.Int32? AdID
		{
			get
			{
				return base.GetSystemInt32(AdMetadata.ColumnNames.AdID);
			}
			
			set
			{
				if(base.SetSystemInt32(AdMetadata.ColumnNames.AdID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.AdID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AdName
		/// </summary>
		virtual public System.String AdName
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AdName);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AdName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.AdName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AdImage
		/// </summary>
		virtual public System.String AdImage
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AdImage);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AdImage, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.AdImage));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.AltText
		/// </summary>
		virtual public System.String AltText
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.AltText);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.AltText, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.AltText));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(AdMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AdMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.LastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(AdMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AdMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.LastUpdatedBy
		/// </summary>
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(AdMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(AdMetadata.ColumnNames.LastUpdatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.LastUpdatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Ad.Active
		/// </summary>
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(AdMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(AdMetadata.ColumnNames.Active, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(AdMetadata.PropertyNames.Active));
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
			public esStrings(esAdBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String AdID
			{
				get
				{
					System.Int32? data = entity.AdID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdID = null;
					else entity.AdID = Convert.ToInt32(value);
				}
			}
				
			public System.String AdName
			{
				get
				{
					System.String data = entity.AdName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdName = null;
					else entity.AdName = Convert.ToString(value);
				}
			}
				
			public System.String AdImage
			{
				get
				{
					System.String data = entity.AdImage;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdImage = null;
					else entity.AdImage = Convert.ToString(value);
				}
			}
				
			public System.String AltText
			{
				get
				{
					System.String data = entity.AltText;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AltText = null;
					else entity.AltText = Convert.ToString(value);
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
			

			private esAdBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esAdQuery query)
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
				throw new Exception("esAdBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AdMetadata.Meta();
			}
		}	
		

		public esQueryItem AdID
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.AdID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem AdName
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.AdName, esSystemType.String);
			}
		} 
		
		public esQueryItem AdImage
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.AdImage, esSystemType.String);
			}
		} 
		
		public esQueryItem AltText
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.AltText, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem Active
		{
			get
			{
				return new esQueryItem(this, AdMetadata.ColumnNames.Active, esSystemType.Boolean);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("AdCollection")]
	public partial class AdCollection : esAdCollection, IEnumerable<AdBO>
	{
		public AdCollection()
		{

		}
		
		public static implicit operator List<AdBO>(AdCollection coll)
		{
			List<AdBO> list = new List<AdBO>();
			
			foreach (AdBO emp in coll)
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
				return  AdMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new AdBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new AdBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public AdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(AdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public AdBO AddNew()
		{
			AdBO entity = base.AddNewEntity() as AdBO;
			
			return entity;
		}

		public AdBO FindByPrimaryKey(System.Int32 adID)
		{
			return base.FindByPrimaryKey(adID) as AdBO;
		}


		#region IEnumerable<AdBO> Members

		IEnumerator<AdBO> IEnumerable<AdBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as AdBO;
			}
		}

		#endregion
		
		private AdQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Ad' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("AdBO ({AdID})")]
	[Serializable]
	public partial class AdBO : esAdBO
	{
		public AdBO()
		{

		}
	
		public AdBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AdMetadata.Meta();
			}
		}
		
		
		
		override protected esAdQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public AdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(AdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private AdQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class AdQuery : esAdQuery
	{
		public AdQuery()
		{

		}		
		
		public AdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "AdQuery";
        }
		
			
	}


	[Serializable]
	public partial class AdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AdMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AdMetadata.ColumnNames.AdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AdMetadata.PropertyNames.AdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AdName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AdName;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AdImage, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AdImage;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.AltText, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.AltText;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.CreateDate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AdMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.CreatedBy, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.LastUpdate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AdMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.LastUpdatedBy, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = AdMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(AdMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = AdMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((1))";
			_columns.Add(c);
				
		}
		#endregion	
	
		static public AdMetadata Meta()
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
			 public const string AdID = "AdID";
			 public const string AdName = "AdName";
			 public const string AdImage = "AdImage";
			 public const string AltText = "AltText";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
			 public const string Active = "Active";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AdID = "AdID";
			 public const string AdName = "AdName";
			 public const string AdImage = "AdImage";
			 public const string AltText = "AltText";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(AdMetadata))
			{
				if(AdMetadata.mapDelegates == null)
				{
					AdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AdMetadata.meta == null)
				{
					AdMetadata.meta = new AdMetadata();
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
				

				meta.AddTypeMap("AdID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AdImage", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AltText", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "Ad";
				meta.Destination = "Ad";
				
				meta.spInsert = "proc_AdInsert";				
				meta.spUpdate = "proc_AdUpdate";		
				meta.spDelete = "proc_AdDelete";
				meta.spLoadAll = "proc_AdLoadAll";
				meta.spLoadByPrimaryKey = "proc_AdLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
