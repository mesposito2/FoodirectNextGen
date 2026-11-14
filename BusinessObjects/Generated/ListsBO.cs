/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/27/2015 1:27:48 PM
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
	abstract public class esListsCollection : esEntityCollection
	{
		public esListsCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ListsCollection";
		}

		#region Query Logic
		protected void InitQuery(esListsQuery query)
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
			this.InitQuery(query as esListsQuery);
		}
		#endregion
		
		virtual public ListsBO DetachEntity(ListsBO entity)
		{
			return base.DetachEntity(entity) as ListsBO;
		}
		
		virtual public ListsBO AttachEntity(ListsBO entity)
		{
			return base.AttachEntity(entity) as ListsBO;
		}
		
		virtual public void Combine(ListsCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ListsBO this[int index]
		{
			get
			{
				return base[index] as ListsBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ListsBO);
		}
	}



	[Serializable]
	abstract public class esListsBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esListsQuery GetDynamicQuery()
		{
			return null;
		}

		public esListsBO()
		{

		}

		public esListsBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 listsID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(listsID);
			else
				return LoadByPrimaryKeyStoredProcedure(listsID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 listsID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(listsID);
			else
				return LoadByPrimaryKeyStoredProcedure(listsID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 listsID)
		{
			esListsQuery query = this.GetDynamicQuery();
			query.Where(query.ListsID == listsID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 listsID)
		{
			esParameters parms = new esParameters();
			parms.Add("listsID",listsID);
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
						case "Lid": this.str.Lid = (string)value; break;							
						case "Lname": this.str.Lname = (string)value; break;							
						case "Lvalue": this.str.Lvalue = (string)value; break;							
						case "Lvalue2": this.str.Lvalue2 = (string)value; break;							
						case "ListsID": this.str.ListsID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Lid":
						
							if (value == null || value is System.Int32)
								this.Lid = (System.Int32?)value;
							break;
						
						case "ListsID":
						
							if (value == null || value is System.Int32)
								this.ListsID = (System.Int32?)value;
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
		/// Maps to lists.lid
		/// </summary>
		virtual public System.Int32? Lid
		{
			get
			{
				return base.GetSystemInt32(ListsMetadata.ColumnNames.Lid);
			}
			
			set
			{
				if(base.SetSystemInt32(ListsMetadata.ColumnNames.Lid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ListsMetadata.PropertyNames.Lid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lname
		/// </summary>
		virtual public System.String Lname
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lname);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lname, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ListsMetadata.PropertyNames.Lname));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lvalue
		/// </summary>
		virtual public System.String Lvalue
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lvalue);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lvalue, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ListsMetadata.PropertyNames.Lvalue));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lvalue2
		/// </summary>
		virtual public System.String Lvalue2
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lvalue2);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lvalue2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ListsMetadata.PropertyNames.Lvalue2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.listsID
		/// </summary>
		virtual public System.Int32? ListsID
		{
			get
			{
				return base.GetSystemInt32(ListsMetadata.ColumnNames.ListsID);
			}
			
			set
			{
				if(base.SetSystemInt32(ListsMetadata.ColumnNames.ListsID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ListsMetadata.PropertyNames.ListsID));
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
			public esStrings(esListsBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Lid
			{
				get
				{
					System.Int32? data = entity.Lid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lid = null;
					else entity.Lid = Convert.ToInt32(value);
				}
			}
				
			public System.String Lname
			{
				get
				{
					System.String data = entity.Lname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lname = null;
					else entity.Lname = Convert.ToString(value);
				}
			}
				
			public System.String Lvalue
			{
				get
				{
					System.String data = entity.Lvalue;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lvalue = null;
					else entity.Lvalue = Convert.ToString(value);
				}
			}
				
			public System.String Lvalue2
			{
				get
				{
					System.String data = entity.Lvalue2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lvalue2 = null;
					else entity.Lvalue2 = Convert.ToString(value);
				}
			}
				
			public System.String ListsID
			{
				get
				{
					System.Int32? data = entity.ListsID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ListsID = null;
					else entity.ListsID = Convert.ToInt32(value);
				}
			}
			

			private esListsBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esListsQuery query)
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
				throw new Exception("esListsBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esListsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ListsMetadata.Meta();
			}
		}	
		

		public esQueryItem Lid
		{
			get
			{
				return new esQueryItem(this, ListsMetadata.ColumnNames.Lid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Lname
		{
			get
			{
				return new esQueryItem(this, ListsMetadata.ColumnNames.Lname, esSystemType.String);
			}
		} 
		
		public esQueryItem Lvalue
		{
			get
			{
				return new esQueryItem(this, ListsMetadata.ColumnNames.Lvalue, esSystemType.String);
			}
		} 
		
		public esQueryItem Lvalue2
		{
			get
			{
				return new esQueryItem(this, ListsMetadata.ColumnNames.Lvalue2, esSystemType.String);
			}
		} 
		
		public esQueryItem ListsID
		{
			get
			{
				return new esQueryItem(this, ListsMetadata.ColumnNames.ListsID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ListsCollection")]
	public partial class ListsCollection : esListsCollection, IEnumerable<ListsBO>
	{
		public ListsCollection()
		{

		}
		
		public static implicit operator List<ListsBO>(ListsCollection coll)
		{
			List<ListsBO> list = new List<ListsBO>();
			
			foreach (ListsBO emp in coll)
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
				return  ListsMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ListsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ListsBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ListsBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ListsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ListsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ListsBO AddNew()
		{
			ListsBO entity = base.AddNewEntity() as ListsBO;
			
			return entity;
		}

		public ListsBO FindByPrimaryKey(System.Int32 listsID)
		{
			return base.FindByPrimaryKey(listsID) as ListsBO;
		}


		#region IEnumerable<ListsBO> Members

		IEnumerator<ListsBO> IEnumerable<ListsBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ListsBO;
			}
		}

		#endregion
		
		private ListsQuery query;
	}


	/// <summary>
	/// Encapsulates the 'lists' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("ListsBO ({ListsID})")]
	[Serializable]
	public partial class ListsBO : esListsBO
	{
		public ListsBO()
		{

		}
	
		public ListsBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ListsMetadata.Meta();
			}
		}
		
		
		
		override protected esListsQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ListsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ListsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ListsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ListsQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class ListsQuery : esListsQuery
	{
		public ListsQuery()
		{

		}		
		
		public ListsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ListsQuery";
        }
		
			
	}


	[Serializable]
	public partial class ListsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ListsMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ListsMetadata.PropertyNames.Lid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lvalue, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lvalue;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lvalue2, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lvalue2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.ListsID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ListsMetadata.PropertyNames.ListsID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ListsMetadata Meta()
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
			 public const string Lid = "lid";
			 public const string Lname = "lname";
			 public const string Lvalue = "lvalue";
			 public const string Lvalue2 = "lvalue2";
			 public const string ListsID = "listsID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Lid = "Lid";
			 public const string Lname = "Lname";
			 public const string Lvalue = "Lvalue";
			 public const string Lvalue2 = "Lvalue2";
			 public const string ListsID = "ListsID";
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
			lock (typeof(ListsMetadata))
			{
				if(ListsMetadata.mapDelegates == null)
				{
					ListsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ListsMetadata.meta == null)
				{
					ListsMetadata.meta = new ListsMetadata();
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
				

				meta.AddTypeMap("Lid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lvalue", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lvalue2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ListsID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "lists";
				meta.Destination = "lists";
				
				meta.spInsert = "proc_listsInsert";				
				meta.spUpdate = "proc_listsUpdate";		
				meta.spDelete = "proc_listsDelete";
				meta.spLoadAll = "proc_listsLoadAll";
				meta.spLoadByPrimaryKey = "proc_listsLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ListsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
