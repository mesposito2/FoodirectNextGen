/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/27/2015 1:27:49 PM
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
	abstract public class esSpeedCollection : esEntityCollection
	{
		public esSpeedCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SpeedCollection";
		}

		#region Query Logic
		protected void InitQuery(esSpeedQuery query)
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
			this.InitQuery(query as esSpeedQuery);
		}
		#endregion
		
		virtual public SpeedBO DetachEntity(SpeedBO entity)
		{
			return base.DetachEntity(entity) as SpeedBO;
		}
		
		virtual public SpeedBO AttachEntity(SpeedBO entity)
		{
			return base.AttachEntity(entity) as SpeedBO;
		}
		
		virtual public void Combine(SpeedCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SpeedBO this[int index]
		{
			get
			{
				return base[index] as SpeedBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SpeedBO);
		}
	}



	[Serializable]
	abstract public class esSpeedBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSpeedQuery GetDynamicQuery()
		{
			return null;
		}

		public esSpeedBO()
		{

		}

		public esSpeedBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 speedID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(speedID);
			else
				return LoadByPrimaryKeyStoredProcedure(speedID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 speedID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(speedID);
			else
				return LoadByPrimaryKeyStoredProcedure(speedID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 speedID)
		{
			esSpeedQuery query = this.GetDynamicQuery();
			query.Where(query.SpeedID == speedID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 speedID)
		{
			esParameters parms = new esParameters();
			parms.Add("speedID",speedID);
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
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Scatid": this.str.Scatid = (string)value; break;							
						case "Lastdate": this.str.Lastdate = (string)value; break;							
						case "Qty": this.str.Qty = (string)value; break;							
						case "Uom": this.str.Uom = (string)value; break;							
						case "Lastprice": this.str.Lastprice = (string)value; break;							
						case "SpeedID": this.str.SpeedID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Lastdate":
						
							if (value == null || value is System.DateTime)
								this.Lastdate = (System.DateTime?)value;
							break;
						
						case "Qty":
						
							if (value == null || value is System.Int32)
								this.Qty = (System.Int32?)value;
							break;
						
						case "Lastprice":
						
							if (value == null || value is System.Double)
								this.Lastprice = (System.Double?)value;
							break;
						
						case "SpeedID":
						
							if (value == null || value is System.Int32)
								this.SpeedID = (System.Int32?)value;
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
		/// Maps to speed.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.scatid
		/// </summary>
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Scatid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.lastdate
		/// </summary>
		virtual public System.DateTime? Lastdate
		{
			get
			{
				return base.GetSystemDateTime(SpeedMetadata.ColumnNames.Lastdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SpeedMetadata.ColumnNames.Lastdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Lastdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.qty
		/// </summary>
		virtual public System.Int32? Qty
		{
			get
			{
				return base.GetSystemInt32(SpeedMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemInt32(SpeedMetadata.ColumnNames.Qty, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Qty));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.uom
		/// </summary>
		virtual public System.String Uom
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Uom);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Uom, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Uom));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.lastprice
		/// </summary>
		virtual public System.Double? Lastprice
		{
			get
			{
				return base.GetSystemDouble(SpeedMetadata.ColumnNames.Lastprice);
			}
			
			set
			{
				if(base.SetSystemDouble(SpeedMetadata.ColumnNames.Lastprice, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.Lastprice));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.speedID
		/// </summary>
		virtual public System.Int32? SpeedID
		{
			get
			{
				return base.GetSystemInt32(SpeedMetadata.ColumnNames.SpeedID);
			}
			
			set
			{
				if(base.SetSystemInt32(SpeedMetadata.ColumnNames.SpeedID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SpeedMetadata.PropertyNames.SpeedID));
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
			public esStrings(esSpeedBO entity)
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
				
			public System.String Scatid
			{
				get
				{
					System.String data = entity.Scatid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid = null;
					else entity.Scatid = Convert.ToString(value);
				}
			}
				
			public System.String Lastdate
			{
				get
				{
					System.DateTime? data = entity.Lastdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastdate = null;
					else entity.Lastdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Qty
			{
				get
				{
					System.Int32? data = entity.Qty;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qty = null;
					else entity.Qty = Convert.ToInt32(value);
				}
			}
				
			public System.String Uom
			{
				get
				{
					System.String data = entity.Uom;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Uom = null;
					else entity.Uom = Convert.ToString(value);
				}
			}
				
			public System.String Lastprice
			{
				get
				{
					System.Double? data = entity.Lastprice;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastprice = null;
					else entity.Lastprice = Convert.ToDouble(value);
				}
			}
				
			public System.String SpeedID
			{
				get
				{
					System.Int32? data = entity.SpeedID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SpeedID = null;
					else entity.SpeedID = Convert.ToInt32(value);
				}
			}
			

			private esSpeedBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSpeedQuery query)
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
				throw new Exception("esSpeedBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSpeedQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SpeedMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastdate
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Lastdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Qty
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Qty, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Uom
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Uom, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastprice
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.Lastprice, esSystemType.Double);
			}
		} 
		
		public esQueryItem SpeedID
		{
			get
			{
				return new esQueryItem(this, SpeedMetadata.ColumnNames.SpeedID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("SpeedCollection")]
	public partial class SpeedCollection : esSpeedCollection, IEnumerable<SpeedBO>
	{
		public SpeedCollection()
		{

		}
		
		public static implicit operator List<SpeedBO>(SpeedCollection coll)
		{
			List<SpeedBO> list = new List<SpeedBO>();
			
			foreach (SpeedBO emp in coll)
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
				return  SpeedMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SpeedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SpeedBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SpeedBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SpeedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SpeedQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SpeedQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SpeedBO AddNew()
		{
			SpeedBO entity = base.AddNewEntity() as SpeedBO;
			
			return entity;
		}

		public SpeedBO FindByPrimaryKey(System.Int32 speedID)
		{
			return base.FindByPrimaryKey(speedID) as SpeedBO;
		}


		#region IEnumerable<SpeedBO> Members

		IEnumerator<SpeedBO> IEnumerable<SpeedBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SpeedBO;
			}
		}

		#endregion
		
		private SpeedQuery query;
	}


	/// <summary>
	/// Encapsulates the 'speed' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("SpeedBO ({SpeedID})")]
	[Serializable]
	public partial class SpeedBO : esSpeedBO
	{
		public SpeedBO()
		{

		}
	
		public SpeedBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SpeedMetadata.Meta();
			}
		}
		
		
		
		override protected esSpeedQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SpeedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SpeedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SpeedQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SpeedQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SpeedQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class SpeedQuery : esSpeedQuery
	{
		public SpeedQuery()
		{

		}		
		
		public SpeedQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SpeedQuery";
        }
		
			
	}


	[Serializable]
	public partial class SpeedMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SpeedMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Scatid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Lastdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SpeedMetadata.PropertyNames.Lastdate;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Qty, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SpeedMetadata.PropertyNames.Qty;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Uom, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Uom;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Lastprice, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SpeedMetadata.PropertyNames.Lastprice;
			c.NumericPrecision = 15;
			_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.SpeedID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SpeedMetadata.PropertyNames.SpeedID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SpeedMetadata Meta()
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
			 public const string Productcode = "productcode";
			 public const string Scatid = "scatid";
			 public const string Lastdate = "lastdate";
			 public const string Qty = "qty";
			 public const string Uom = "uom";
			 public const string Lastprice = "lastprice";
			 public const string SpeedID = "speedID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Productcode = "Productcode";
			 public const string Scatid = "Scatid";
			 public const string Lastdate = "Lastdate";
			 public const string Qty = "Qty";
			 public const string Uom = "Uom";
			 public const string Lastprice = "Lastprice";
			 public const string SpeedID = "SpeedID";
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
			lock (typeof(SpeedMetadata))
			{
				if(SpeedMetadata.mapDelegates == null)
				{
					SpeedMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SpeedMetadata.meta == null)
				{
					SpeedMetadata.meta = new SpeedMetadata();
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
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastdate", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Uom", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SpeedID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "speed";
				meta.Destination = "speed";
				
				meta.spInsert = "proc_speedInsert";				
				meta.spUpdate = "proc_speedUpdate";		
				meta.spDelete = "proc_speedDelete";
				meta.spLoadAll = "proc_speedLoadAll";
				meta.spLoadByPrimaryKey = "proc_speedLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SpeedMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
