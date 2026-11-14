/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 9/20/2019 8:26:12 PM
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
	abstract public class esPriceMasterCollection : esEntityCollection
	{
		public esPriceMasterCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "PriceMasterCollection";
		}

		#region Query Logic
		protected void InitQuery(esPriceMasterQuery query)
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
			this.InitQuery(query as esPriceMasterQuery);
		}
		#endregion
		
		virtual public PriceMasterBO DetachEntity(PriceMasterBO entity)
		{
			return base.DetachEntity(entity) as PriceMasterBO;
		}
		
		virtual public PriceMasterBO AttachEntity(PriceMasterBO entity)
		{
			return base.AttachEntity(entity) as PriceMasterBO;
		}
		
		virtual public void Combine(PriceMasterCollection collection)
		{
			base.Combine(collection);
		}
		
		new public PriceMasterBO this[int index]
		{
			get
			{
				return base[index] as PriceMasterBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(PriceMasterBO);
		}
	}



	[Serializable]
	abstract public class esPriceMasterBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esPriceMasterQuery GetDynamicQuery()
		{
			return null;
		}

		public esPriceMasterBO()
		{

		}

		public esPriceMasterBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 priceMasterID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(priceMasterID);
			else
				return LoadByPrimaryKeyStoredProcedure(priceMasterID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 priceMasterID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(priceMasterID);
			else
				return LoadByPrimaryKeyStoredProcedure(priceMasterID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 priceMasterID)
		{
			esPriceMasterQuery query = this.GetDynamicQuery();
			query.Where(query.PriceMasterID == priceMasterID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 priceMasterID)
		{
			esParameters parms = new esParameters();
			parms.Add("PriceMasterID",priceMasterID);
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
						case "PriceMasterID": this.str.PriceMasterID = (string)value; break;							
						case "CustID": this.str.CustID = (string)value; break;							
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Lbcs": this.str.Lbcs = (string)value; break;							
						case "Lbpc": this.str.Lbpc = (string)value; break;							
						case "CaseSourceCode": this.str.CaseSourceCode = (string)value; break;							
						case "PieceSourceCode": this.str.PieceSourceCode = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "PriceMasterID":
						
							if (value == null || value is System.Int32)
								this.PriceMasterID = (System.Int32?)value;
							break;
						
						case "Lbcs":
						
							if (value == null || value is System.Double)
								this.Lbcs = (System.Double?)value;
							break;
						
						case "Lbpc":
						
							if (value == null || value is System.Double)
								this.Lbpc = (System.Double?)value;
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
		/// Maps to PriceMaster.PriceMasterID
		/// </summary>
		virtual public System.Int32? PriceMasterID
		{
			get
			{
				return base.GetSystemInt32(PriceMasterMetadata.ColumnNames.PriceMasterID);
			}
			
			set
			{
				if(base.SetSystemInt32(PriceMasterMetadata.ColumnNames.PriceMasterID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.PriceMasterID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.CustID
		/// </summary>
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.CustID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.CustID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.lbcs
		/// </summary>
		virtual public System.Double? Lbcs
		{
			get
			{
				return base.GetSystemDouble(PriceMasterMetadata.ColumnNames.Lbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterMetadata.ColumnNames.Lbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.Lbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.lbpc
		/// </summary>
		virtual public System.Double? Lbpc
		{
			get
			{
				return base.GetSystemDouble(PriceMasterMetadata.ColumnNames.Lbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterMetadata.ColumnNames.Lbpc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.Lbpc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.CaseSourceCode
		/// </summary>
		virtual public System.String CaseSourceCode
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.CaseSourceCode);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.CaseSourceCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.CaseSourceCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.PieceSourceCode
		/// </summary>
		virtual public System.String PieceSourceCode
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.PieceSourceCode);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.PieceSourceCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(PriceMasterMetadata.PropertyNames.PieceSourceCode));
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
			public esStrings(esPriceMasterBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String PriceMasterID
			{
				get
				{
					System.Int32? data = entity.PriceMasterID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PriceMasterID = null;
					else entity.PriceMasterID = Convert.ToInt32(value);
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
				
			public System.String Lbcs
			{
				get
				{
					System.Double? data = entity.Lbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lbcs = null;
					else entity.Lbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String Lbpc
			{
				get
				{
					System.Double? data = entity.Lbpc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lbpc = null;
					else entity.Lbpc = Convert.ToDouble(value);
				}
			}
				
			public System.String CaseSourceCode
			{
				get
				{
					System.String data = entity.CaseSourceCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CaseSourceCode = null;
					else entity.CaseSourceCode = Convert.ToString(value);
				}
			}
				
			public System.String PieceSourceCode
			{
				get
				{
					System.String data = entity.PieceSourceCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PieceSourceCode = null;
					else entity.PieceSourceCode = Convert.ToString(value);
				}
			}
			

			private esPriceMasterBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esPriceMasterQuery query)
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
				throw new Exception("esPriceMasterBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esPriceMasterQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterMetadata.Meta();
			}
		}	
		

		public esQueryItem PriceMasterID
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.PriceMasterID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem CustID
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.CustID, esSystemType.String);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Lbcs
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Lbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Lbpc
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Lbpc, esSystemType.Double);
			}
		} 
		
		public esQueryItem CaseSourceCode
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.CaseSourceCode, esSystemType.String);
			}
		} 
		
		public esQueryItem PieceSourceCode
		{
			get
			{
				return new esQueryItem(this, PriceMasterMetadata.ColumnNames.PieceSourceCode, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("PriceMasterCollection")]
	public partial class PriceMasterCollection : esPriceMasterCollection, IEnumerable<PriceMasterBO>
	{
		public PriceMasterCollection()
		{

		}
		
		public static implicit operator List<PriceMasterBO>(PriceMasterCollection coll)
		{
			List<PriceMasterBO> list = new List<PriceMasterBO>();
			
			foreach (PriceMasterBO emp in coll)
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
				return  PriceMasterMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new PriceMasterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new PriceMasterBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new PriceMasterBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public PriceMasterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(PriceMasterQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public PriceMasterBO AddNew()
		{
			PriceMasterBO entity = base.AddNewEntity() as PriceMasterBO;
			
			return entity;
		}

		public PriceMasterBO FindByPrimaryKey(System.Int32 priceMasterID)
		{
			return base.FindByPrimaryKey(priceMasterID) as PriceMasterBO;
		}


		#region IEnumerable<PriceMasterBO> Members

		IEnumerator<PriceMasterBO> IEnumerable<PriceMasterBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as PriceMasterBO;
			}
		}

		#endregion
		
		private PriceMasterQuery query;
	}


	/// <summary>
	/// Encapsulates the 'PriceMaster' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("PriceMasterBO ({PriceMasterID})")]
	[Serializable]
	public partial class PriceMasterBO : esPriceMasterBO
	{
		public PriceMasterBO()
		{

		}
	
		public PriceMasterBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterMetadata.Meta();
			}
		}
		
		
		
		override protected esPriceMasterQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new PriceMasterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public PriceMasterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(PriceMasterQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private PriceMasterQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class PriceMasterQuery : esPriceMasterQuery
	{
		public PriceMasterQuery()
		{

		}		
		
		public PriceMasterQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "PriceMasterQuery";
        }
		
			
	}


	[Serializable]
	public partial class PriceMasterMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected PriceMasterMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.PriceMasterID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = PriceMasterMetadata.PropertyNames.PriceMasterID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Lbcs, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Lbpc, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.CaseSourceCode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.CaseSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.PieceSourceCode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.PieceSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public PriceMasterMetadata Meta()
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
			 public const string PriceMasterID = "PriceMasterID";
			 public const string CustID = "CustID";
			 public const string Productcode = "productcode";
			 public const string Lbcs = "lbcs";
			 public const string Lbpc = "lbpc";
			 public const string CaseSourceCode = "CaseSourceCode";
			 public const string PieceSourceCode = "PieceSourceCode";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string PriceMasterID = "PriceMasterID";
			 public const string CustID = "CustID";
			 public const string Productcode = "Productcode";
			 public const string Lbcs = "Lbcs";
			 public const string Lbpc = "Lbpc";
			 public const string CaseSourceCode = "CaseSourceCode";
			 public const string PieceSourceCode = "PieceSourceCode";
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
			lock (typeof(PriceMasterMetadata))
			{
				if(PriceMasterMetadata.mapDelegates == null)
				{
					PriceMasterMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (PriceMasterMetadata.meta == null)
				{
					PriceMasterMetadata.meta = new PriceMasterMetadata();
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
				

				meta.AddTypeMap("PriceMasterID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("CaseSourceCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PieceSourceCode", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "PriceMaster";
				meta.Destination = "PriceMaster";
				
				meta.spInsert = "proc_PriceMasterInsert";				
				meta.spUpdate = "proc_PriceMasterUpdate";		
				meta.spDelete = "proc_PriceMasterDelete";
				meta.spLoadAll = "proc_PriceMasterLoadAll";
				meta.spLoadByPrimaryKey = "proc_PriceMasterLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private PriceMasterMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
