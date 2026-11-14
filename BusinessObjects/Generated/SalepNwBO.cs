/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 9/15/2019 10:45:50 AM
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
	abstract public class esSalepNwCollection : esEntityCollection
	{
		public esSalepNwCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SalepNwCollection";
		}

		#region Query Logic
		protected void InitQuery(esSalepNwQuery query)
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
			this.InitQuery(query as esSalepNwQuery);
		}
		#endregion
		
		virtual public SalepNwBO DetachEntity(SalepNwBO entity)
		{
			return base.DetachEntity(entity) as SalepNwBO;
		}
		
		virtual public SalepNwBO AttachEntity(SalepNwBO entity)
		{
			return base.AttachEntity(entity) as SalepNwBO;
		}
		
		virtual public void Combine(SalepNwCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SalepNwBO this[int index]
		{
			get
			{
				return base[index] as SalepNwBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SalepNwBO);
		}
	}



	[Serializable]
	abstract public class esSalepNwBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSalepNwQuery GetDynamicQuery()
		{
			return null;
		}

		public esSalepNwBO()
		{

		}

		public esSalepNwBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salepNwId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(salepNwId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salepNwId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(salepNwId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salepNwId)
		{
			esSalepNwQuery query = this.GetDynamicQuery();
			query.Where(query.SalepNwId == salepNwId);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salepNwId)
		{
			esParameters parms = new esParameters();
			parms.Add("salep_nw_id",salepNwId);
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
						case "SalepNwId": this.str.SalepNwId = (string)value; break;
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
						
						case "SalepNwId":
						
							if (value == null || value is System.Int32)
								this.SalepNwId = (System.Int32?)value;
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
		/// Maps to salep_nw.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.colnum
		/// </summary>
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.Colnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.line
		/// </summary>
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.Line, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.sdescription
		/// </summary>
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Sdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.slbcs
		/// </summary>
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(SalepNwMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepNwMetadata.ColumnNames.Slbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.sjlbcs
		/// </summary>
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(SalepNwMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepNwMetadata.ColumnNames.Sjlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.salep_nw_id
		/// </summary>
		virtual public System.Int32? SalepNwId
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.SalepNwId);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.SalepNwId, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SalepNwMetadata.PropertyNames.SalepNwId));
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
			public esStrings(esSalepNwBO entity)
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
				
			public System.String SalepNwId
			{
				get
				{
					System.Int32? data = entity.SalepNwId;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalepNwId = null;
					else entity.SalepNwId = Convert.ToInt32(value);
				}
			}
			

			private esSalepNwBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSalepNwQuery query)
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
				throw new Exception("esSalepNwBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSalepNwQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalepNwMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem SalepNwId
		{
			get
			{
				return new esQueryItem(this, SalepNwMetadata.ColumnNames.SalepNwId, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("SalepNwCollection")]
	public partial class SalepNwCollection : esSalepNwCollection, IEnumerable<SalepNwBO>
	{
		public SalepNwCollection()
		{

		}
		
		public static implicit operator List<SalepNwBO>(SalepNwCollection coll)
		{
			List<SalepNwBO> list = new List<SalepNwBO>();
			
			foreach (SalepNwBO emp in coll)
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
				return  SalepNwMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepNwQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SalepNwBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SalepNwBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SalepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepNwQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SalepNwQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SalepNwBO AddNew()
		{
			SalepNwBO entity = base.AddNewEntity() as SalepNwBO;
			
			return entity;
		}

		public SalepNwBO FindByPrimaryKey(System.Int32 salepNwId)
		{
			return base.FindByPrimaryKey(salepNwId) as SalepNwBO;
		}


		#region IEnumerable<SalepNwBO> Members

		IEnumerator<SalepNwBO> IEnumerable<SalepNwBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SalepNwBO;
			}
		}

		#endregion
		
		private SalepNwQuery query;
	}


	/// <summary>
	/// Encapsulates the 'salep_nw' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("SalepNwBO ({SalepNwId})")]
	[Serializable]
	public partial class SalepNwBO : esSalepNwBO
	{
		public SalepNwBO()
		{

		}
	
		public SalepNwBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalepNwMetadata.Meta();
			}
		}
		
		
		
		override protected esSalepNwQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepNwQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SalepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepNwQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SalepNwQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SalepNwQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class SalepNwQuery : esSalepNwQuery
	{
		public SalepNwQuery()
		{

		}		
		
		public SalepNwQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SalepNwQuery";
        }
		
			
	}


	[Serializable]
	public partial class SalepNwMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalepNwMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepNwMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepNwMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.SalepNwId, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.SalepNwId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SalepNwMetadata Meta()
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
			 public const string SalepNwId = "salep_nw_id";
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
			 public const string SalepNwId = "SalepNwId";
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
			lock (typeof(SalepNwMetadata))
			{
				if(SalepNwMetadata.mapDelegates == null)
				{
					SalepNwMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalepNwMetadata.meta == null)
				{
					SalepNwMetadata.meta = new SalepNwMetadata();
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
				meta.AddTypeMap("SalepNwId", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "salep_nw";
				meta.Destination = "salep_nw";
				
				meta.spInsert = "proc_salep_nwInsert";				
				meta.spUpdate = "proc_salep_nwUpdate";		
				meta.spDelete = "proc_salep_nwDelete";
				meta.spLoadAll = "proc_salep_nwLoadAll";
				meta.spLoadByPrimaryKey = "proc_salep_nwLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalepNwMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
