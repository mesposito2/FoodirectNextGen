/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/5/2023 9:02:44 PM
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
	abstract public class esV5EmailBlastAttachmentCollection : esEntityCollection
	{
		public esV5EmailBlastAttachmentCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5EmailBlastAttachmentCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5EmailBlastAttachmentQuery query)
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
			this.InitQuery(query as esV5EmailBlastAttachmentQuery);
		}
		#endregion
		
		virtual public V5EmailBlastAttachmentBO DetachEntity(V5EmailBlastAttachmentBO entity)
		{
			return base.DetachEntity(entity) as V5EmailBlastAttachmentBO;
		}
		
		virtual public V5EmailBlastAttachmentBO AttachEntity(V5EmailBlastAttachmentBO entity)
		{
			return base.AttachEntity(entity) as V5EmailBlastAttachmentBO;
		}
		
		virtual public void Combine(V5EmailBlastAttachmentCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5EmailBlastAttachmentBO this[int index]
		{
			get
			{
				return base[index] as V5EmailBlastAttachmentBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5EmailBlastAttachmentBO);
		}
	}



	[Serializable]
	abstract public class esV5EmailBlastAttachmentBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5EmailBlastAttachmentQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5EmailBlastAttachmentBO()
		{

		}

		public esV5EmailBlastAttachmentBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 emailBlastAttachmentID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastAttachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastAttachmentID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 emailBlastAttachmentID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastAttachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastAttachmentID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 emailBlastAttachmentID)
		{
			esV5EmailBlastAttachmentQuery query = this.GetDynamicQuery();
			query.Where(query.EmailBlastAttachmentID == emailBlastAttachmentID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 emailBlastAttachmentID)
		{
			esParameters parms = new esParameters();
			parms.Add("EmailBlastAttachmentID",emailBlastAttachmentID);
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
						case "EmailBlastAttachmentID": this.str.EmailBlastAttachmentID = (string)value; break;							
						case "EmailBlastID": this.str.EmailBlastID = (string)value; break;							
						case "CreatedByDate": this.str.CreatedByDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "AttachmentPath": this.str.AttachmentPath = (string)value; break;							
						case "OriginalFileName": this.str.OriginalFileName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "EmailBlastAttachmentID":
						
							if (value == null || value is System.Int32)
								this.EmailBlastAttachmentID = (System.Int32?)value;
							break;
						
						case "EmailBlastID":
						
							if (value == null || value is System.Int32)
								this.EmailBlastID = (System.Int32?)value;
							break;
						
						case "CreatedByDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedByDate = (System.DateTime?)value;
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
		/// Maps to V5EmailBlastAttachment.EmailBlastAttachmentID
		/// </summary>
		virtual public System.Int32? EmailBlastAttachmentID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastAttachmentID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.EmailBlastID
		/// </summary>
		virtual public System.Int32? EmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.CreatedByDate
		/// </summary>
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.CreatedByDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.AttachmentPath
		/// </summary>
		virtual public System.String AttachmentPath
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.AttachmentPath));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.OriginalFileName
		/// </summary>
		virtual public System.String OriginalFileName
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastAttachmentMetadata.PropertyNames.OriginalFileName));
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
			public esStrings(esV5EmailBlastAttachmentBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String EmailBlastAttachmentID
			{
				get
				{
					System.Int32? data = entity.EmailBlastAttachmentID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EmailBlastAttachmentID = null;
					else entity.EmailBlastAttachmentID = Convert.ToInt32(value);
				}
			}
				
			public System.String EmailBlastID
			{
				get
				{
					System.Int32? data = entity.EmailBlastID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EmailBlastID = null;
					else entity.EmailBlastID = Convert.ToInt32(value);
				}
			}
				
			public System.String CreatedByDate
			{
				get
				{
					System.DateTime? data = entity.CreatedByDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedByDate = null;
					else entity.CreatedByDate = Convert.ToDateTime(value);
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
				
			public System.String AttachmentPath
			{
				get
				{
					System.String data = entity.AttachmentPath;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AttachmentPath = null;
					else entity.AttachmentPath = Convert.ToString(value);
				}
			}
				
			public System.String OriginalFileName
			{
				get
				{
					System.String data = entity.OriginalFileName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OriginalFileName = null;
					else entity.OriginalFileName = Convert.ToString(value);
				}
			}
			

			private esV5EmailBlastAttachmentBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5EmailBlastAttachmentQuery query)
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
				throw new Exception("esV5EmailBlastAttachmentBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esV5EmailBlastAttachmentQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastAttachmentMetadata.Meta();
			}
		}	
		

		public esQueryItem EmailBlastAttachmentID
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem EmailBlastID
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem CreatedByDate
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem AttachmentPath
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, esSystemType.String);
			}
		} 
		
		public esQueryItem OriginalFileName
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("V5EmailBlastAttachmentCollection")]
	public partial class V5EmailBlastAttachmentCollection : esV5EmailBlastAttachmentCollection, IEnumerable<V5EmailBlastAttachmentBO>
	{
		public V5EmailBlastAttachmentCollection()
		{

		}
		
		public static implicit operator List<V5EmailBlastAttachmentBO>(V5EmailBlastAttachmentCollection coll)
		{
			List<V5EmailBlastAttachmentBO> list = new List<V5EmailBlastAttachmentBO>();
			
			foreach (V5EmailBlastAttachmentBO emp in coll)
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
				return  V5EmailBlastAttachmentMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastAttachmentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5EmailBlastAttachmentBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5EmailBlastAttachmentBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5EmailBlastAttachmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastAttachmentQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5EmailBlastAttachmentQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5EmailBlastAttachmentBO AddNew()
		{
			V5EmailBlastAttachmentBO entity = base.AddNewEntity() as V5EmailBlastAttachmentBO;
			
			return entity;
		}

		public V5EmailBlastAttachmentBO FindByPrimaryKey(System.Int32 emailBlastAttachmentID)
		{
			return base.FindByPrimaryKey(emailBlastAttachmentID) as V5EmailBlastAttachmentBO;
		}


		#region IEnumerable<V5EmailBlastAttachmentBO> Members

		IEnumerator<V5EmailBlastAttachmentBO> IEnumerable<V5EmailBlastAttachmentBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5EmailBlastAttachmentBO;
			}
		}

		#endregion
		
		private V5EmailBlastAttachmentQuery query;
	}


	/// <summary>
	/// Encapsulates the 'V5EmailBlastAttachment' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("V5EmailBlastAttachmentBO ({EmailBlastAttachmentID})")]
	[Serializable]
	public partial class V5EmailBlastAttachmentBO : esV5EmailBlastAttachmentBO
	{
		public V5EmailBlastAttachmentBO()
		{

		}
	
		public V5EmailBlastAttachmentBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastAttachmentMetadata.Meta();
			}
		}
		
		
		
		override protected esV5EmailBlastAttachmentQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastAttachmentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5EmailBlastAttachmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastAttachmentQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5EmailBlastAttachmentQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5EmailBlastAttachmentQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class V5EmailBlastAttachmentQuery : esV5EmailBlastAttachmentQuery
	{
		public V5EmailBlastAttachmentQuery()
		{

		}		
		
		public V5EmailBlastAttachmentQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5EmailBlastAttachmentQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5EmailBlastAttachmentMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5EmailBlastAttachmentMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastAttachmentID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.CreatedByDate;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.AttachmentPath;
			c.CharacterMaxLength = 500;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.OriginalFileName;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5EmailBlastAttachmentMetadata Meta()
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
			 public const string EmailBlastAttachmentID = "EmailBlastAttachmentID";
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string OriginalFileName = "OriginalFileName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string EmailBlastAttachmentID = "EmailBlastAttachmentID";
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string OriginalFileName = "OriginalFileName";
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
			lock (typeof(V5EmailBlastAttachmentMetadata))
			{
				if(V5EmailBlastAttachmentMetadata.mapDelegates == null)
				{
					V5EmailBlastAttachmentMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5EmailBlastAttachmentMetadata.meta == null)
				{
					V5EmailBlastAttachmentMetadata.meta = new V5EmailBlastAttachmentMetadata();
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
				

				meta.AddTypeMap("EmailBlastAttachmentID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("EmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AttachmentPath", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OriginalFileName", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "V5EmailBlastAttachment";
				meta.Destination = "V5EmailBlastAttachment";
				
				meta.spInsert = "proc_V5EmailBlastAttachmentInsert";				
				meta.spUpdate = "proc_V5EmailBlastAttachmentUpdate";		
				meta.spDelete = "proc_V5EmailBlastAttachmentDelete";
				meta.spLoadAll = "proc_V5EmailBlastAttachmentLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5EmailBlastAttachmentLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5EmailBlastAttachmentMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
