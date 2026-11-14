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
	abstract public class esProduceCollection : esEntityCollection
	{
		public esProduceCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ProduceCollection";
		}

		#region Query Logic
		protected void InitQuery(esProduceQuery query)
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
			this.InitQuery(query as esProduceQuery);
		}
		#endregion
		
		virtual public ProduceBO DetachEntity(ProduceBO entity)
		{
			return base.DetachEntity(entity) as ProduceBO;
		}
		
		virtual public ProduceBO AttachEntity(ProduceBO entity)
		{
			return base.AttachEntity(entity) as ProduceBO;
		}
		
		virtual public void Combine(ProduceCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ProduceBO this[int index]
		{
			get
			{
				return base[index] as ProduceBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ProduceBO);
		}
	}



	[Serializable]
	abstract public class esProduceBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esProduceQuery GetDynamicQuery()
		{
			return null;
		}

		public esProduceBO()
		{

		}

		public esProduceBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 produceID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(produceID);
			else
				return LoadByPrimaryKeyStoredProcedure(produceID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 produceID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(produceID);
			else
				return LoadByPrimaryKeyStoredProcedure(produceID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 produceID)
		{
			esProduceQuery query = this.GetDynamicQuery();
			query.Where(query.ProduceID == produceID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 produceID)
		{
			esParameters parms = new esParameters();
			parms.Add("produceID",produceID);
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
						case "ProduceID": this.str.ProduceID = (string)value; break;
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
						
						case "ProduceID":
						
							if (value == null || value is System.Int32)
								this.ProduceID = (System.Int32?)value;
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
		/// Maps to produce.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.colnum
		/// </summary>
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.Colnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.line
		/// </summary>
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.Line, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.sdescription
		/// </summary>
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Sdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.slbcs
		/// </summary>
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(ProduceMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProduceMetadata.ColumnNames.Slbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.sjlbcs
		/// </summary>
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(ProduceMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProduceMetadata.ColumnNames.Sjlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.produceID
		/// </summary>
		virtual public System.Int32? ProduceID
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.ProduceID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.ProduceID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProduceMetadata.PropertyNames.ProduceID));
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
			public esStrings(esProduceBO entity)
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
				
			public System.String ProduceID
			{
				get
				{
					System.Int32? data = entity.ProduceID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProduceID = null;
					else entity.ProduceID = Convert.ToInt32(value);
				}
			}
			

			private esProduceBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esProduceQuery query)
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
				throw new Exception("esProduceBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esProduceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProduceMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem ProduceID
		{
			get
			{
				return new esQueryItem(this, ProduceMetadata.ColumnNames.ProduceID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ProduceCollection")]
	public partial class ProduceCollection : esProduceCollection, IEnumerable<ProduceBO>
	{
		public ProduceCollection()
		{

		}
		
		public static implicit operator List<ProduceBO>(ProduceCollection coll)
		{
			List<ProduceBO> list = new List<ProduceBO>();
			
			foreach (ProduceBO emp in coll)
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
				return  ProduceMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProduceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ProduceBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ProduceBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProduceQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ProduceQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ProduceBO AddNew()
		{
			ProduceBO entity = base.AddNewEntity() as ProduceBO;
			
			return entity;
		}

		public ProduceBO FindByPrimaryKey(System.Int32 produceID)
		{
			return base.FindByPrimaryKey(produceID) as ProduceBO;
		}


		#region IEnumerable<ProduceBO> Members

		IEnumerator<ProduceBO> IEnumerable<ProduceBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ProduceBO;
			}
		}

		#endregion
		
		private ProduceQuery query;
	}


	/// <summary>
	/// Encapsulates the 'produce' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("ProduceBO ({ProduceID})")]
	[Serializable]
	public partial class ProduceBO : esProduceBO
	{
		public ProduceBO()
		{

		}
	
		public ProduceBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProduceMetadata.Meta();
			}
		}
		
		
		
		override protected esProduceQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProduceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProduceQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ProduceQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ProduceQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class ProduceQuery : esProduceQuery
	{
		public ProduceQuery()
		{

		}		
		
		public ProduceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ProduceQuery";
        }
		
			
	}


	[Serializable]
	public partial class ProduceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProduceMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProduceMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProduceMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.ProduceID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.ProduceID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ProduceMetadata Meta()
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
			 public const string ProduceID = "produceID";
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
			 public const string ProduceID = "ProduceID";
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
			lock (typeof(ProduceMetadata))
			{
				if(ProduceMetadata.mapDelegates == null)
				{
					ProduceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProduceMetadata.meta == null)
				{
					ProduceMetadata.meta = new ProduceMetadata();
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
				meta.AddTypeMap("ProduceID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "produce";
				meta.Destination = "produce";
				
				meta.spInsert = "proc_produceInsert";				
				meta.spUpdate = "proc_produceUpdate";		
				meta.spDelete = "proc_produceDelete";
				meta.spLoadAll = "proc_produceLoadAll";
				meta.spLoadByPrimaryKey = "proc_produceLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProduceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
