/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/27/2015 1:28:53 PM
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
	abstract public class esWtaSalesTaxCollection : esEntityCollection
	{
		public esWtaSalesTaxCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "WtaSalesTaxCollection";
		}

		#region Query Logic
		protected void InitQuery(esWtaSalesTaxQuery query)
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
			this.InitQuery(query as esWtaSalesTaxQuery);
		}
		#endregion
		
		virtual public WtaSalesTaxBO DetachEntity(WtaSalesTaxBO entity)
		{
			return base.DetachEntity(entity) as WtaSalesTaxBO;
		}
		
		virtual public WtaSalesTaxBO AttachEntity(WtaSalesTaxBO entity)
		{
			return base.AttachEntity(entity) as WtaSalesTaxBO;
		}
		
		virtual public void Combine(WtaSalesTaxCollection collection)
		{
			base.Combine(collection);
		}
		
		new public WtaSalesTaxBO this[int index]
		{
			get
			{
				return base[index] as WtaSalesTaxBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(WtaSalesTaxBO);
		}
	}



	[Serializable]
	abstract public class esWtaSalesTaxBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esWtaSalesTaxQuery GetDynamicQuery()
		{
			return null;
		}

		public esWtaSalesTaxBO()
		{

		}

		public esWtaSalesTaxBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 sid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(sid);
			else
				return LoadByPrimaryKeyStoredProcedure(sid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 sid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(sid);
			else
				return LoadByPrimaryKeyStoredProcedure(sid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 sid)
		{
			esWtaSalesTaxQuery query = this.GetDynamicQuery();
			query.Where(query.Sid == sid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 sid)
		{
			esParameters parms = new esParameters();
			parms.Add("sid",sid);
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
						case "Code": this.str.Code = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;							
						case "Rate": this.str.Rate = (string)value; break;							
						case "Sid": this.str.Sid = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Rate":
						
							if (value == null || value is System.Double)
								this.Rate = (System.Double?)value;
							break;
						
						case "Sid":
						
							if (value == null || value is System.Int32)
								this.Sid = (System.Int32?)value;
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
		/// Maps to wta_sales_tax.code
		/// </summary>
		virtual public System.String Code
		{
			get
			{
				return base.GetSystemString(WtaSalesTaxMetadata.ColumnNames.Code);
			}
			
			set
			{
				if(base.SetSystemString(WtaSalesTaxMetadata.ColumnNames.Code, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaSalesTaxMetadata.PropertyNames.Code));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaSalesTaxMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaSalesTaxMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaSalesTaxMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.rate
		/// </summary>
		virtual public System.Double? Rate
		{
			get
			{
				return base.GetSystemDouble(WtaSalesTaxMetadata.ColumnNames.Rate);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaSalesTaxMetadata.ColumnNames.Rate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaSalesTaxMetadata.PropertyNames.Rate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_sales_tax.sid
		/// </summary>
		virtual public System.Int32? Sid
		{
			get
			{
				return base.GetSystemInt32(WtaSalesTaxMetadata.ColumnNames.Sid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaSalesTaxMetadata.ColumnNames.Sid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaSalesTaxMetadata.PropertyNames.Sid));
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
			public esStrings(esWtaSalesTaxBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Code
			{
				get
				{
					System.String data = entity.Code;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Code = null;
					else entity.Code = Convert.ToString(value);
				}
			}
				
			public System.String Description
			{
				get
				{
					System.String data = entity.Description;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description = null;
					else entity.Description = Convert.ToString(value);
				}
			}
				
			public System.String Rate
			{
				get
				{
					System.Double? data = entity.Rate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Rate = null;
					else entity.Rate = Convert.ToDouble(value);
				}
			}
				
			public System.String Sid
			{
				get
				{
					System.Int32? data = entity.Sid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sid = null;
					else entity.Sid = Convert.ToInt32(value);
				}
			}
			

			private esWtaSalesTaxBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esWtaSalesTaxQuery query)
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
				throw new Exception("esWtaSalesTaxBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esWtaSalesTaxQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaSalesTaxMetadata.Meta();
			}
		}	
		

		public esQueryItem Code
		{
			get
			{
				return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Code, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Rate
		{
			get
			{
				return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Rate, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sid
		{
			get
			{
				return new esQueryItem(this, WtaSalesTaxMetadata.ColumnNames.Sid, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("WtaSalesTaxCollection")]
	public partial class WtaSalesTaxCollection : esWtaSalesTaxCollection, IEnumerable<WtaSalesTaxBO>
	{
		public WtaSalesTaxCollection()
		{

		}
		
		public static implicit operator List<WtaSalesTaxBO>(WtaSalesTaxCollection coll)
		{
			List<WtaSalesTaxBO> list = new List<WtaSalesTaxBO>();
			
			foreach (WtaSalesTaxBO emp in coll)
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
				return  WtaSalesTaxMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaSalesTaxQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new WtaSalesTaxBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new WtaSalesTaxBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public WtaSalesTaxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaSalesTaxQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(WtaSalesTaxQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public WtaSalesTaxBO AddNew()
		{
			WtaSalesTaxBO entity = base.AddNewEntity() as WtaSalesTaxBO;
			
			return entity;
		}

		public WtaSalesTaxBO FindByPrimaryKey(System.Int32 sid)
		{
			return base.FindByPrimaryKey(sid) as WtaSalesTaxBO;
		}


		#region IEnumerable<WtaSalesTaxBO> Members

		IEnumerator<WtaSalesTaxBO> IEnumerable<WtaSalesTaxBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as WtaSalesTaxBO;
			}
		}

		#endregion
		
		private WtaSalesTaxQuery query;
	}


	/// <summary>
	/// Encapsulates the 'wta_sales_tax' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("WtaSalesTaxBO ({Sid})")]
	[Serializable]
	public partial class WtaSalesTaxBO : esWtaSalesTaxBO
	{
		public WtaSalesTaxBO()
		{

		}
	
		public WtaSalesTaxBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaSalesTaxMetadata.Meta();
			}
		}
		
		
		
		override protected esWtaSalesTaxQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaSalesTaxQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public WtaSalesTaxQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaSalesTaxQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(WtaSalesTaxQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private WtaSalesTaxQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class WtaSalesTaxQuery : esWtaSalesTaxQuery
	{
		public WtaSalesTaxQuery()
		{

		}		
		
		public WtaSalesTaxQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "WtaSalesTaxQuery";
        }
		
			
	}


	[Serializable]
	public partial class WtaSalesTaxMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaSalesTaxMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Code, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Code;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Rate, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Rate;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaSalesTaxMetadata.ColumnNames.Sid, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaSalesTaxMetadata.PropertyNames.Sid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaSalesTaxMetadata Meta()
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
			 public const string Code = "code";
			 public const string Description = "description";
			 public const string Rate = "rate";
			 public const string Sid = "sid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Code = "Code";
			 public const string Description = "Description";
			 public const string Rate = "Rate";
			 public const string Sid = "Sid";
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
			lock (typeof(WtaSalesTaxMetadata))
			{
				if(WtaSalesTaxMetadata.mapDelegates == null)
				{
					WtaSalesTaxMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaSalesTaxMetadata.meta == null)
				{
					WtaSalesTaxMetadata.meta = new WtaSalesTaxMetadata();
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
				

				meta.AddTypeMap("Code", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Rate", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sid", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "wta_sales_tax";
				meta.Destination = "wta_sales_tax";
				
				meta.spInsert = "proc_wta_sales_taxInsert";				
				meta.spUpdate = "proc_wta_sales_taxUpdate";		
				meta.spDelete = "proc_wta_sales_taxDelete";
				meta.spLoadAll = "proc_wta_sales_taxLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_sales_taxLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaSalesTaxMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
