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
	abstract public class esSalesBeefConfigAdCollection : esEntityCollection
	{
		public esSalesBeefConfigAdCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SalesBeefConfigAdCollection";
		}

		#region Query Logic
		protected void InitQuery(esSalesBeefConfigAdQuery query)
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
			this.InitQuery(query as esSalesBeefConfigAdQuery);
		}
		#endregion
		
		virtual public SalesBeefConfigAdBO DetachEntity(SalesBeefConfigAdBO entity)
		{
			return base.DetachEntity(entity) as SalesBeefConfigAdBO;
		}
		
		virtual public SalesBeefConfigAdBO AttachEntity(SalesBeefConfigAdBO entity)
		{
			return base.AttachEntity(entity) as SalesBeefConfigAdBO;
		}
		
		virtual public void Combine(SalesBeefConfigAdCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SalesBeefConfigAdBO this[int index]
		{
			get
			{
				return base[index] as SalesBeefConfigAdBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SalesBeefConfigAdBO);
		}
	}



	[Serializable]
	abstract public class esSalesBeefConfigAdBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSalesBeefConfigAdQuery GetDynamicQuery()
		{
			return null;
		}

		public esSalesBeefConfigAdBO()
		{

		}

		public esSalesBeefConfigAdBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesBeefConfigAdID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigAdID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesBeefConfigAdID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigAdID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesBeefConfigAdID)
		{
			esSalesBeefConfigAdQuery query = this.GetDynamicQuery();
			query.Where(query.SalesBeefConfigAdID == salesBeefConfigAdID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesBeefConfigAdID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesBeefConfigAdID",salesBeefConfigAdID);
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
						case "SalesBeefConfigAdID": this.str.SalesBeefConfigAdID = (string)value; break;							
						case "SalesBeefConfigID": this.str.SalesBeefConfigID = (string)value; break;							
						case "PageNum": this.str.PageNum = (string)value; break;							
						case "AdID": this.str.AdID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "SalesBeefConfigAdID":
						
							if (value == null || value is System.Int32)
								this.SalesBeefConfigAdID = (System.Int32?)value;
							break;
						
						case "SalesBeefConfigID":
						
							if (value == null || value is System.Int32)
								this.SalesBeefConfigID = (System.Int32?)value;
							break;
						
						case "PageNum":
						
							if (value == null || value is System.Int32)
								this.PageNum = (System.Int32?)value;
							break;
						
						case "AdID":
						
							if (value == null || value is System.Int32)
								this.AdID = (System.Int32?)value;
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
		/// Maps to SalesBeefConfigAd.SalesBeefConfigAdID
		/// </summary>
		virtual public System.Int32? SalesBeefConfigAdID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigAdID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.SalesBeefConfigID
		/// </summary>
		virtual public System.Int32? SalesBeefConfigID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.PageNum
		/// </summary>
		virtual public System.Int32? PageNum
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.PageNum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.PageNum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigAdMetadata.PropertyNames.PageNum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.AdID
		/// </summary>
		virtual public System.Int32? AdID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.AdID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.AdID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalesBeefConfigAdMetadata.PropertyNames.AdID));
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
			public esStrings(esSalesBeefConfigAdBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String SalesBeefConfigAdID
			{
				get
				{
					System.Int32? data = entity.SalesBeefConfigAdID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalesBeefConfigAdID = null;
					else entity.SalesBeefConfigAdID = Convert.ToInt32(value);
				}
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
				
			public System.String PageNum
			{
				get
				{
					System.Int32? data = entity.PageNum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PageNum = null;
					else entity.PageNum = Convert.ToInt32(value);
				}
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
			

			private esSalesBeefConfigAdBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSalesBeefConfigAdQuery query)
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
				throw new Exception("esSalesBeefConfigAdBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSalesBeefConfigAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigAdMetadata.Meta();
			}
		}	
		

		public esQueryItem SalesBeefConfigAdID
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SalesBeefConfigID
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PageNum
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.PageNum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem AdID
		{
			get
			{
				return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.AdID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("SalesBeefConfigAdCollection")]
	public partial class SalesBeefConfigAdCollection : esSalesBeefConfigAdCollection, IEnumerable<SalesBeefConfigAdBO>
	{
		public SalesBeefConfigAdCollection()
		{

		}
		
		public static implicit operator List<SalesBeefConfigAdBO>(SalesBeefConfigAdCollection coll)
		{
			List<SalesBeefConfigAdBO> list = new List<SalesBeefConfigAdBO>();
			
			foreach (SalesBeefConfigAdBO emp in coll)
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
				return  SalesBeefConfigAdMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigAdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SalesBeefConfigAdBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SalesBeefConfigAdBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SalesBeefConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigAdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SalesBeefConfigAdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SalesBeefConfigAdBO AddNew()
		{
			SalesBeefConfigAdBO entity = base.AddNewEntity() as SalesBeefConfigAdBO;
			
			return entity;
		}

		public SalesBeefConfigAdBO FindByPrimaryKey(System.Int32 salesBeefConfigAdID)
		{
			return base.FindByPrimaryKey(salesBeefConfigAdID) as SalesBeefConfigAdBO;
		}


		#region IEnumerable<SalesBeefConfigAdBO> Members

		IEnumerator<SalesBeefConfigAdBO> IEnumerable<SalesBeefConfigAdBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SalesBeefConfigAdBO;
			}
		}

		#endregion
		
		private SalesBeefConfigAdQuery query;
	}


	/// <summary>
	/// Encapsulates the 'SalesBeefConfigAd' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("SalesBeefConfigAdBO ({SalesBeefConfigAdID})")]
	[Serializable]
	public partial class SalesBeefConfigAdBO : esSalesBeefConfigAdBO
	{
		public SalesBeefConfigAdBO()
		{

		}
	
		public SalesBeefConfigAdBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigAdMetadata.Meta();
			}
		}
		
		
		
		override protected esSalesBeefConfigAdQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigAdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SalesBeefConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigAdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SalesBeefConfigAdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SalesBeefConfigAdQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class SalesBeefConfigAdQuery : esSalesBeefConfigAdQuery
	{
		public SalesBeefConfigAdQuery()
		{

		}		
		
		public SalesBeefConfigAdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SalesBeefConfigAdQuery";
        }
		
			
	}


	[Serializable]
	public partial class SalesBeefConfigAdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalesBeefConfigAdMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigAdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.PageNum, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.PageNum;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.AdID, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.AdID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SalesBeefConfigAdMetadata Meta()
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
			 public const string SalesBeefConfigAdID = "SalesBeefConfigAdID";
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesBeefConfigAdID = "SalesBeefConfigAdID";
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
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
			lock (typeof(SalesBeefConfigAdMetadata))
			{
				if(SalesBeefConfigAdMetadata.mapDelegates == null)
				{
					SalesBeefConfigAdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalesBeefConfigAdMetadata.meta == null)
				{
					SalesBeefConfigAdMetadata.meta = new SalesBeefConfigAdMetadata();
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
				

				meta.AddTypeMap("SalesBeefConfigAdID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SalesBeefConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PageNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "SalesBeefConfigAd";
				meta.Destination = "SalesBeefConfigAd";
				
				meta.spInsert = "proc_SalesBeefConfigAdInsert";				
				meta.spUpdate = "proc_SalesBeefConfigAdUpdate";		
				meta.spDelete = "proc_SalesBeefConfigAdDelete";
				meta.spLoadAll = "proc_SalesBeefConfigAdLoadAll";
				meta.spLoadByPrimaryKey = "proc_SalesBeefConfigAdLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalesBeefConfigAdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
