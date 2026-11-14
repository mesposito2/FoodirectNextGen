/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 9/1/2019 1:06:41 PM
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
	abstract public class esGroupaCollection : esEntityCollection
	{
		public esGroupaCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "GroupaCollection";
		}

		#region Query Logic
		protected void InitQuery(esGroupaQuery query)
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
			this.InitQuery(query as esGroupaQuery);
		}
		#endregion
		
		virtual public GroupaBO DetachEntity(GroupaBO entity)
		{
			return base.DetachEntity(entity) as GroupaBO;
		}
		
		virtual public GroupaBO AttachEntity(GroupaBO entity)
		{
			return base.AttachEntity(entity) as GroupaBO;
		}
		
		virtual public void Combine(GroupaCollection collection)
		{
			base.Combine(collection);
		}
		
		new public GroupaBO this[int index]
		{
			get
			{
				return base[index] as GroupaBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(GroupaBO);
		}
	}



	[Serializable]
	abstract public class esGroupaBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esGroupaQuery GetDynamicQuery()
		{
			return null;
		}

		public esGroupaBO()
		{

		}

		public esGroupaBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 groupaID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(groupaID);
			else
				return LoadByPrimaryKeyStoredProcedure(groupaID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 groupaID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(groupaID);
			else
				return LoadByPrimaryKeyStoredProcedure(groupaID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 groupaID)
		{
			esGroupaQuery query = this.GetDynamicQuery();
			query.Where(query.GroupaID == groupaID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 groupaID)
		{
			esParameters parms = new esParameters();
			parms.Add("GroupaID",groupaID);
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
						case "Groupcode": this.str.Groupcode = (string)value; break;							
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Brandcode": this.str.Brandcode = (string)value; break;							
						case "Scatid": this.str.Scatid = (string)value; break;							
						case "GroupaID": this.str.GroupaID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "GroupaID":
						
							if (value == null || value is System.Int32)
								this.GroupaID = (System.Int32?)value;
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
		/// Maps to groupa.groupcode
		/// </summary>
		virtual public System.String Groupcode
		{
			get
			{
				return base.GetSystemString(GroupaMetadata.ColumnNames.Groupcode);
			}
			
			set
			{
				if(base.SetSystemString(GroupaMetadata.ColumnNames.Groupcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupaMetadata.PropertyNames.Groupcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(GroupaMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(GroupaMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupaMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.brandcode
		/// </summary>
		virtual public System.String Brandcode
		{
			get
			{
				return base.GetSystemString(GroupaMetadata.ColumnNames.Brandcode);
			}
			
			set
			{
				if(base.SetSystemString(GroupaMetadata.ColumnNames.Brandcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupaMetadata.PropertyNames.Brandcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.scatid
		/// </summary>
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(GroupaMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(GroupaMetadata.ColumnNames.Scatid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupaMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.GroupaID
		/// </summary>
		virtual public System.Int32? GroupaID
		{
			get
			{
				return base.GetSystemInt32(GroupaMetadata.ColumnNames.GroupaID);
			}
			
			set
			{
				if(base.SetSystemInt32(GroupaMetadata.ColumnNames.GroupaID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupaMetadata.PropertyNames.GroupaID));
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
			public esStrings(esGroupaBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Groupcode
			{
				get
				{
					System.String data = entity.Groupcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Groupcode = null;
					else entity.Groupcode = Convert.ToString(value);
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
				
			public System.String Brandcode
			{
				get
				{
					System.String data = entity.Brandcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Brandcode = null;
					else entity.Brandcode = Convert.ToString(value);
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
				
			public System.String GroupaID
			{
				get
				{
					System.Int32? data = entity.GroupaID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.GroupaID = null;
					else entity.GroupaID = Convert.ToInt32(value);
				}
			}
			

			private esGroupaBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esGroupaQuery query)
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
				throw new Exception("esGroupaBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esGroupaQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return GroupaMetadata.Meta();
			}
		}	
		

		public esQueryItem Groupcode
		{
			get
			{
				return new esQueryItem(this, GroupaMetadata.ColumnNames.Groupcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, GroupaMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Brandcode
		{
			get
			{
				return new esQueryItem(this, GroupaMetadata.ColumnNames.Brandcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, GroupaMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem GroupaID
		{
			get
			{
				return new esQueryItem(this, GroupaMetadata.ColumnNames.GroupaID, esSystemType.Int32);
			}
		} 
		
	}



	[Serializable]
	[XmlType("GroupaCollection")]
	public partial class GroupaCollection : esGroupaCollection, IEnumerable<GroupaBO>
	{
		public GroupaCollection()
		{

		}
		
		public static implicit operator List<GroupaBO>(GroupaCollection coll)
		{
			List<GroupaBO> list = new List<GroupaBO>();
			
			foreach (GroupaBO emp in coll)
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
				return  GroupaMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new GroupaQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new GroupaBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new GroupaBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public GroupaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupaQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(GroupaQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public GroupaBO AddNew()
		{
			GroupaBO entity = base.AddNewEntity() as GroupaBO;
			
			return entity;
		}

		public GroupaBO FindByPrimaryKey(System.Int32 groupaID)
		{
			return base.FindByPrimaryKey(groupaID) as GroupaBO;
		}


		#region IEnumerable<GroupaBO> Members

		IEnumerator<GroupaBO> IEnumerable<GroupaBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as GroupaBO;
			}
		}

		#endregion
		
		private GroupaQuery query;
	}


	/// <summary>
	/// Encapsulates the 'groupa' table
	/// </summary>

	[Serializable]
	public partial class GroupaBO : esGroupaBO
	{
		public GroupaBO()
		{

		}
	
		public GroupaBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return GroupaMetadata.Meta();
			}
		}
		
		
		
		override protected esGroupaQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new GroupaQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public GroupaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupaQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(GroupaQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private GroupaQuery query;
	}



	[Serializable]
		
	public partial class GroupaQuery : esGroupaQuery
	{
		public GroupaQuery()
		{

		}		
		
		public GroupaQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "GroupaQuery";
        }
		
			
	}


	[Serializable]
	public partial class GroupaMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected GroupaMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Groupcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Groupcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Brandcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Brandcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Scatid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.GroupaID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = GroupaMetadata.PropertyNames.GroupaID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public GroupaMetadata Meta()
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
			 public const string Groupcode = "groupcode";
			 public const string Productcode = "productcode";
			 public const string Brandcode = "brandcode";
			 public const string Scatid = "scatid";
			 public const string GroupaID = "GroupaID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Groupcode = "Groupcode";
			 public const string Productcode = "Productcode";
			 public const string Brandcode = "Brandcode";
			 public const string Scatid = "Scatid";
			 public const string GroupaID = "GroupaID";
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
			lock (typeof(GroupaMetadata))
			{
				if(GroupaMetadata.mapDelegates == null)
				{
					GroupaMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (GroupaMetadata.meta == null)
				{
					GroupaMetadata.meta = new GroupaMetadata();
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
				

				meta.AddTypeMap("Groupcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Brandcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("GroupaID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "groupa";
				meta.Destination = "groupa";
				
				meta.spInsert = "proc_groupaInsert";				
				meta.spUpdate = "proc_groupaUpdate";		
				meta.spDelete = "proc_groupaDelete";
				meta.spLoadAll = "proc_groupaLoadAll";
				meta.spLoadByPrimaryKey = "proc_groupaLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private GroupaMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
