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
	abstract public class esSalepCollection : esEntityCollection
	{
		public esSalepCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SalepCollection";
		}

		#region Query Logic
		protected void InitQuery(esSalepQuery query)
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
			this.InitQuery(query as esSalepQuery);
		}
		#endregion
		
		virtual public SalepBO DetachEntity(SalepBO entity)
		{
			return base.DetachEntity(entity) as SalepBO;
		}
		
		virtual public SalepBO AttachEntity(SalepBO entity)
		{
			return base.AttachEntity(entity) as SalepBO;
		}
		
		virtual public void Combine(SalepCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SalepBO this[int index]
		{
			get
			{
				return base[index] as SalepBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SalepBO);
		}
	}



	[Serializable]
	abstract public class esSalepBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSalepQuery GetDynamicQuery()
		{
			return null;
		}

		public esSalepBO()
		{

		}

		public esSalepBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salepID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepID);
			else
				return LoadByPrimaryKeyStoredProcedure(salepID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salepID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepID);
			else
				return LoadByPrimaryKeyStoredProcedure(salepID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salepID)
		{
			esSalepQuery query = this.GetDynamicQuery();
			query.Where(query.SalepID == salepID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salepID)
		{
			esParameters parms = new esParameters();
			parms.Add("salepID",salepID);
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
						case "SalepID": this.str.SalepID = (string)value; break;
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
						
						case "SalepID":
						
							if (value == null || value is System.Int32)
								this.SalepID = (System.Int32?)value;
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
		/// Maps to salep.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.colnum
		/// </summary>
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.Colnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.line
		/// </summary>
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.Line, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.sdescription
		/// </summary>
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Sdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.slbcs
		/// </summary>
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(SalepMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepMetadata.ColumnNames.Slbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.sjlbcs
		/// </summary>
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(SalepMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepMetadata.ColumnNames.Sjlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.salepID
		/// </summary>
		virtual public System.Int32? SalepID
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.SalepID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.SalepID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepMetadata.PropertyNames.SalepID));
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
			public esStrings(esSalepBO entity)
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
				
			public System.String SalepID
			{
				get
				{
					System.Int32? data = entity.SalepID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalepID = null;
					else entity.SalepID = Convert.ToInt32(value);
				}
			}
			

			private esSalepBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSalepQuery query)
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
				throw new Exception("esSalepBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSalepQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalepMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem SalepID
		{
			get
			{
				return new esQueryItem(this, SalepMetadata.ColumnNames.SalepID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("SalepCollection")]
	public partial class SalepCollection : esSalepCollection, IEnumerable<SalepBO>
	{
		public SalepCollection()
		{

		}
		
		public static implicit operator List<SalepBO>(SalepCollection coll)
		{
			List<SalepBO> list = new List<SalepBO>();
			
			foreach (SalepBO emp in coll)
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
				return  SalepMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SalepBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SalepBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SalepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SalepQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SalepBO AddNew()
		{
			SalepBO entity = base.AddNewEntity() as SalepBO;
			
			return entity;
		}

		public SalepBO FindByPrimaryKey(System.Int32 salepID)
		{
			return base.FindByPrimaryKey(salepID) as SalepBO;
		}


		#region IEnumerable<SalepBO> Members

		IEnumerator<SalepBO> IEnumerable<SalepBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SalepBO;
			}
		}

		#endregion
		
		private SalepQuery query;
	}


	/// <summary>
	/// Encapsulates the 'salep' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("SalepBO ({SalepID})")]
	[Serializable]
	public partial class SalepBO : esSalepBO
	{
		public SalepBO()
		{

		}
	
		public SalepBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalepMetadata.Meta();
			}
		}
		
		
		
		override protected esSalepQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SalepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SalepQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SalepQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class SalepQuery : esSalepQuery
	{
		public SalepQuery()
		{

		}		
		
		public SalepQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SalepQuery";
        }
		
			
	}


	[Serializable]
	public partial class SalepMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalepMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalepMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.SalepID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.SalepID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SalepMetadata Meta()
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
			 public const string SalepID = "salepID";
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
			 public const string SalepID = "SalepID";
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
			lock (typeof(SalepMetadata))
			{
				if(SalepMetadata.mapDelegates == null)
				{
					SalepMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalepMetadata.meta == null)
				{
					SalepMetadata.meta = new SalepMetadata();
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
				meta.AddTypeMap("SalepID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "salep";
				meta.Destination = "salep";
				
				meta.spInsert = "proc_salepInsert";				
				meta.spUpdate = "proc_salepUpdate";		
				meta.spDelete = "proc_salepDelete";
				meta.spLoadAll = "proc_salepLoadAll";
				meta.spLoadByPrimaryKey = "proc_salepLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalepMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
