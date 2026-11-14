/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 6/6/2018 7:00:30 PM
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
	abstract public class esWtaFdpxStructCollection : esEntityCollection
	{
		public esWtaFdpxStructCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "WtaFdpxStructCollection";
		}

		#region Query Logic
		protected void InitQuery(esWtaFdpxStructQuery query)
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
			this.InitQuery(query as esWtaFdpxStructQuery);
		}
		#endregion
		
		virtual public WtaFdpxStructBO DetachEntity(WtaFdpxStructBO entity)
		{
			return base.DetachEntity(entity) as WtaFdpxStructBO;
		}
		
		virtual public WtaFdpxStructBO AttachEntity(WtaFdpxStructBO entity)
		{
			return base.AttachEntity(entity) as WtaFdpxStructBO;
		}
		
		virtual public void Combine(WtaFdpxStructCollection collection)
		{
			base.Combine(collection);
		}
		
		new public WtaFdpxStructBO this[int index]
		{
			get
			{
				return base[index] as WtaFdpxStructBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(WtaFdpxStructBO);
		}
	}



	[Serializable]
	abstract public class esWtaFdpxStructBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esWtaFdpxStructQuery GetDynamicQuery()
		{
			return null;
		}

		public esWtaFdpxStructBO()
		{

		}

		public esWtaFdpxStructBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Guid structID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(structID);
			else
				return LoadByPrimaryKeyStoredProcedure(structID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Guid structID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(structID);
			else
				return LoadByPrimaryKeyStoredProcedure(structID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Guid structID)
		{
			esWtaFdpxStructQuery query = this.GetDynamicQuery();
			query.Where(query.StructID == structID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Guid structID)
		{
			esParameters parms = new esParameters();
			parms.Add("structID",structID);
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
						case "Tableid": this.str.Tableid = (string)value; break;							
						case "Fnum": this.str.Fnum = (string)value; break;							
						case "Fname": this.str.Fname = (string)value; break;							
						case "Length": this.str.Length = (string)value; break;							
						case "Startpos": this.str.Startpos = (string)value; break;							
						case "Endpos": this.str.Endpos = (string)value; break;							
						case "Fdesc": this.str.Fdesc = (string)value; break;							
						case "StructID": this.str.StructID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Fnum":
						
							if (value == null || value is System.Int32)
								this.Fnum = (System.Int32?)value;
							break;
						
						case "Length":
						
							if (value == null || value is System.Int32)
								this.Length = (System.Int32?)value;
							break;
						
						case "Startpos":
						
							if (value == null || value is System.Int32)
								this.Startpos = (System.Int32?)value;
							break;
						
						case "Endpos":
						
							if (value == null || value is System.Int32)
								this.Endpos = (System.Int32?)value;
							break;
						
						case "StructID":
						
							if (value == null || value is System.Guid)
								this.StructID = (System.Guid?)value;
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
		/// Maps to wta_fdpx_struct.tableid
		/// </summary>
		virtual public System.String Tableid
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Tableid);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Tableid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Tableid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fnum
		/// </summary>
		virtual public System.Int32? Fnum
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Fnum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Fnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Fnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fname
		/// </summary>
		virtual public System.String Fname
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Fname);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Fname, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Fname));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.length
		/// </summary>
		virtual public System.Int32? Length
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Length);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Length, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Length));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.startpos
		/// </summary>
		virtual public System.Int32? Startpos
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Startpos);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Startpos, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Startpos));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.endpos
		/// </summary>
		virtual public System.Int32? Endpos
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Endpos);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Endpos, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Endpos));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fdesc
		/// </summary>
		virtual public System.String Fdesc
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Fdesc);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Fdesc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.Fdesc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.structID
		/// </summary>
		virtual public System.Guid? StructID
		{
			get
			{
				return base.GetSystemGuid(WtaFdpxStructMetadata.ColumnNames.StructID);
			}
			
			set
			{
				if(base.SetSystemGuid(WtaFdpxStructMetadata.ColumnNames.StructID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaFdpxStructMetadata.PropertyNames.StructID));
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
			public esStrings(esWtaFdpxStructBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Tableid
			{
				get
				{
					System.String data = entity.Tableid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Tableid = null;
					else entity.Tableid = Convert.ToString(value);
				}
			}
				
			public System.String Fnum
			{
				get
				{
					System.Int32? data = entity.Fnum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fnum = null;
					else entity.Fnum = Convert.ToInt32(value);
				}
			}
				
			public System.String Fname
			{
				get
				{
					System.String data = entity.Fname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fname = null;
					else entity.Fname = Convert.ToString(value);
				}
			}
				
			public System.String Length
			{
				get
				{
					System.Int32? data = entity.Length;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Length = null;
					else entity.Length = Convert.ToInt32(value);
				}
			}
				
			public System.String Startpos
			{
				get
				{
					System.Int32? data = entity.Startpos;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Startpos = null;
					else entity.Startpos = Convert.ToInt32(value);
				}
			}
				
			public System.String Endpos
			{
				get
				{
					System.Int32? data = entity.Endpos;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Endpos = null;
					else entity.Endpos = Convert.ToInt32(value);
				}
			}
				
			public System.String Fdesc
			{
				get
				{
					System.String data = entity.Fdesc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fdesc = null;
					else entity.Fdesc = Convert.ToString(value);
				}
			}
				
			public System.String StructID
			{
				get
				{
					System.Guid? data = entity.StructID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StructID = null;
					else entity.StructID = new Guid(value);
				}
			}
			

			private esWtaFdpxStructBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esWtaFdpxStructQuery query)
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
				throw new Exception("esWtaFdpxStructBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esWtaFdpxStructQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaFdpxStructMetadata.Meta();
			}
		}	
		

		public esQueryItem Tableid
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Tableid, esSystemType.String);
			}
		} 
		
		public esQueryItem Fnum
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Fname
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fname, esSystemType.String);
			}
		} 
		
		public esQueryItem Length
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Length, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Startpos
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Startpos, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Endpos
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Endpos, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Fdesc
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fdesc, esSystemType.String);
			}
		} 
		
		public esQueryItem StructID
		{
			get
			{
				return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.StructID, esSystemType.Guid);
			}
		} 
		
	}



	[Serializable]
	[XmlType("WtaFdpxStructCollection")]
	public partial class WtaFdpxStructCollection : esWtaFdpxStructCollection, IEnumerable<WtaFdpxStructBO>
	{
		public WtaFdpxStructCollection()
		{

		}
		
		public static implicit operator List<WtaFdpxStructBO>(WtaFdpxStructCollection coll)
		{
			List<WtaFdpxStructBO> list = new List<WtaFdpxStructBO>();
			
			foreach (WtaFdpxStructBO emp in coll)
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
				return  WtaFdpxStructMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaFdpxStructQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new WtaFdpxStructBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new WtaFdpxStructBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public WtaFdpxStructQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFdpxStructQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(WtaFdpxStructQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public WtaFdpxStructBO AddNew()
		{
			WtaFdpxStructBO entity = base.AddNewEntity() as WtaFdpxStructBO;
			
			return entity;
		}

		public WtaFdpxStructBO FindByPrimaryKey(System.Guid structID)
		{
			return base.FindByPrimaryKey(structID) as WtaFdpxStructBO;
		}


		#region IEnumerable<WtaFdpxStructBO> Members

		IEnumerator<WtaFdpxStructBO> IEnumerable<WtaFdpxStructBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as WtaFdpxStructBO;
			}
		}

		#endregion
		
		private WtaFdpxStructQuery query;
	}


	/// <summary>
	/// Encapsulates the 'wta_fdpx_struct' table
	/// </summary>

	[Serializable]
	public partial class WtaFdpxStructBO : esWtaFdpxStructBO
	{
		public WtaFdpxStructBO()
		{

		}
	
		public WtaFdpxStructBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaFdpxStructMetadata.Meta();
			}
		}
		
		
		
		override protected esWtaFdpxStructQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaFdpxStructQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public WtaFdpxStructQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFdpxStructQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(WtaFdpxStructQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private WtaFdpxStructQuery query;
	}



	[Serializable]
		
	public partial class WtaFdpxStructQuery : esWtaFdpxStructQuery
	{
		public WtaFdpxStructQuery()
		{

		}		
		
		public WtaFdpxStructQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "WtaFdpxStructQuery";
        }
		
			
	}


	[Serializable]
	public partial class WtaFdpxStructMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaFdpxStructMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Tableid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Tableid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fname;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Length, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Length;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Startpos, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Startpos;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Endpos, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Endpos;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fdesc, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fdesc;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.StructID, 7, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.StructID;
			c.IsInPrimaryKey = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaFdpxStructMetadata Meta()
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
			 public const string Tableid = "tableid";
			 public const string Fnum = "fnum";
			 public const string Fname = "fname";
			 public const string Length = "length";
			 public const string Startpos = "startpos";
			 public const string Endpos = "endpos";
			 public const string Fdesc = "fdesc";
			 public const string StructID = "structID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tableid = "Tableid";
			 public const string Fnum = "Fnum";
			 public const string Fname = "Fname";
			 public const string Length = "Length";
			 public const string Startpos = "Startpos";
			 public const string Endpos = "Endpos";
			 public const string Fdesc = "Fdesc";
			 public const string StructID = "StructID";
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
			lock (typeof(WtaFdpxStructMetadata))
			{
				if(WtaFdpxStructMetadata.mapDelegates == null)
				{
					WtaFdpxStructMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaFdpxStructMetadata.meta == null)
				{
					WtaFdpxStructMetadata.meta = new WtaFdpxStructMetadata();
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
				

				meta.AddTypeMap("Tableid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Fnum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Fname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Length", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Startpos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Endpos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Fdesc", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("StructID", new esTypeMap("uniqueidentifier", "System.Guid"));			
				
				
				
				meta.Source = "wta_fdpx_struct";
				meta.Destination = "wta_fdpx_struct";
				
				meta.spInsert = "proc_wta_fdpx_structInsert";				
				meta.spUpdate = "proc_wta_fdpx_structUpdate";		
				meta.spDelete = "proc_wta_fdpx_structDelete";
				meta.spLoadAll = "proc_wta_fdpx_structLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_fdpx_structLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaFdpxStructMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
