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
	abstract public class esGroupdCollection : esEntityCollection
	{
		public esGroupdCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "GroupdCollection";
		}

		#region Query Logic
		protected void InitQuery(esGroupdQuery query)
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
			this.InitQuery(query as esGroupdQuery);
		}
		#endregion
		
		virtual public GroupdBO DetachEntity(GroupdBO entity)
		{
			return base.DetachEntity(entity) as GroupdBO;
		}
		
		virtual public GroupdBO AttachEntity(GroupdBO entity)
		{
			return base.AttachEntity(entity) as GroupdBO;
		}
		
		virtual public void Combine(GroupdCollection collection)
		{
			base.Combine(collection);
		}
		
		new public GroupdBO this[int index]
		{
			get
			{
				return base[index] as GroupdBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(GroupdBO);
		}
	}



	[Serializable]
	abstract public class esGroupdBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esGroupdQuery GetDynamicQuery()
		{
			return null;
		}

		public esGroupdBO()
		{

		}

		public esGroupdBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String groupcode)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(groupcode);
			else
				return LoadByPrimaryKeyStoredProcedure(groupcode);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String groupcode)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(groupcode);
			else
				return LoadByPrimaryKeyStoredProcedure(groupcode);
		}

		private bool LoadByPrimaryKeyDynamic(System.String groupcode)
		{
			esGroupdQuery query = this.GetDynamicQuery();
			query.Where(query.Groupcode == groupcode);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String groupcode)
		{
			esParameters parms = new esParameters();
			parms.Add("groupcode",groupcode);
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
						case "Description": this.str.Description = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{

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
		/// Maps to groupd.groupcode
		/// </summary>
		virtual public System.String Groupcode
		{
			get
			{
				return base.GetSystemString(GroupdMetadata.ColumnNames.Groupcode);
			}
			
			set
			{
				if(base.SetSystemString(GroupdMetadata.ColumnNames.Groupcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupdMetadata.PropertyNames.Groupcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to groupd.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(GroupdMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(GroupdMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(GroupdMetadata.PropertyNames.Description));
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
			public esStrings(esGroupdBO entity)
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
			

			private esGroupdBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esGroupdQuery query)
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
				throw new Exception("esGroupdBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esGroupdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return GroupdMetadata.Meta();
			}
		}	
		

		public esQueryItem Groupcode
		{
			get
			{
				return new esQueryItem(this, GroupdMetadata.ColumnNames.Groupcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, GroupdMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
	}



	[Serializable]
	[XmlType("GroupdCollection")]
	public partial class GroupdCollection : esGroupdCollection, IEnumerable<GroupdBO>
	{
		public GroupdCollection()
		{

		}
		
		public static implicit operator List<GroupdBO>(GroupdCollection coll)
		{
			List<GroupdBO> list = new List<GroupdBO>();
			
			foreach (GroupdBO emp in coll)
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
				return  GroupdMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new GroupdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new GroupdBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new GroupdBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public GroupdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(GroupdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public GroupdBO AddNew()
		{
			GroupdBO entity = base.AddNewEntity() as GroupdBO;
			
			return entity;
		}

		public GroupdBO FindByPrimaryKey(System.String groupcode)
		{
			return base.FindByPrimaryKey(groupcode) as GroupdBO;
		}


		#region IEnumerable<GroupdBO> Members

		IEnumerator<GroupdBO> IEnumerable<GroupdBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as GroupdBO;
			}
		}

		#endregion
		
		private GroupdQuery query;
	}


	/// <summary>
	/// Encapsulates the 'groupd' table
	/// </summary>

	[Serializable]
	public partial class GroupdBO : esGroupdBO
	{
		public GroupdBO()
		{

		}
	
		public GroupdBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return GroupdMetadata.Meta();
			}
		}
		
		
		
		override protected esGroupdQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new GroupdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public GroupdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupdQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(GroupdQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private GroupdQuery query;
	}



	[Serializable]
		
	public partial class GroupdQuery : esGroupdQuery
	{
		public GroupdQuery()
		{

		}		
		
		public GroupdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "GroupdQuery";
        }
		
			
	}


	[Serializable]
	public partial class GroupdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected GroupdMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(GroupdMetadata.ColumnNames.Groupcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupdMetadata.PropertyNames.Groupcode;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 2;
			_columns.Add(c);
				
			c = new esColumnMetadata(GroupdMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupdMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public GroupdMetadata Meta()
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
			 public const string Description = "description";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Groupcode = "Groupcode";
			 public const string Description = "Description";
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
			lock (typeof(GroupdMetadata))
			{
				if(GroupdMetadata.mapDelegates == null)
				{
					GroupdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (GroupdMetadata.meta == null)
				{
					GroupdMetadata.meta = new GroupdMetadata();
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
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "groupd";
				meta.Destination = "groupd";
				
				meta.spInsert = "proc_groupdInsert";				
				meta.spUpdate = "proc_groupdUpdate";		
				meta.spDelete = "proc_groupdDelete";
				meta.spLoadAll = "proc_groupdLoadAll";
				meta.spLoadByPrimaryKey = "proc_groupdLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private GroupdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
