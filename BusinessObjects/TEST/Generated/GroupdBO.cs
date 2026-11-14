
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:14 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'groupd' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(GroupdBO))]	
	[XmlType("GroupdBO")]
	public partial class GroupdBO : esGroupdBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new GroupdBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String groupcode)
		{
			var obj = new GroupdBO();
			obj.Groupcode = groupcode;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String groupcode, esSqlAccessType sqlAccessType)
		{
			var obj = new GroupdBO();
			obj.Groupcode = groupcode;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("GroupdCollection")]
	public partial class GroupdCollection : esGroupdCollection, IEnumerable<GroupdBO>
	{
		public GroupdBO FindByPrimaryKey(System.String groupcode)
		{
			return this.SingleOrDefault(e => e.Groupcode == groupcode);
		}

		
				
	}



	[Serializable]	
	public partial class GroupdQuery : esGroupdQuery
	{
		public GroupdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public GroupdQuery(string joinAlias, out GroupdQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "GroupdQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(GroupdQuery query)
		{
			return GroupdQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator GroupdQuery(string query)
		{
			return (GroupdQuery)GroupdQuery.SerializeHelper.FromXml(query, typeof(GroupdQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esGroupdBO : esEntity
	{
		public esGroupdBO()
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
			GroupdQuery query = new GroupdQuery();
			query.Where(query.Groupcode == groupcode);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String groupcode)
		{
			esParameters parms = new esParameters();
			parms.Add("Groupcode", groupcode);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to groupd.groupcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(GroupdMetadata.PropertyNames.Groupcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to groupd.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(GroupdMetadata.PropertyNames.Description);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return GroupdMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public GroupdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(GroupdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(GroupdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((GroupdQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private GroupdQuery query;		
	}



	[Serializable]
	abstract public partial class esGroupdCollection : esEntityCollection<GroupdBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return GroupdMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "GroupdCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public GroupdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(GroupdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(GroupdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((GroupdQuery)query);
		}

		#endregion
		
		private GroupdQuery query;
	}



	[Serializable]
	abstract public partial class esGroupdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return GroupdMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Groupcode": return this.Groupcode;
				case "Description": return this.Description;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Groupcode
		{
			get { return new esQueryItem(this, GroupdMetadata.ColumnNames.Groupcode, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, GroupdMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class GroupdBO : esGroupdBO
	{

		#region GroupaBOCollection - Zero To Many (FK_groupa_groupcode)
		
		static public esPrefetchMap Prefetch_GroupaBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.GroupdBO.GroupaBOCollection_Delegate,
					PropertyName = "GroupaBOCollection",
					MyColumnName = "groupcode",
					ParentColumnName = "groupcode",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void GroupaBOCollection_Delegate(esPrefetchParameters data)
		{
			GroupdQuery parent = new GroupdQuery(data.NextAlias());

			GroupaQuery me = data.You != null ? data.You as GroupaQuery : new GroupaQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Groupcode == me.Groupcode);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_groupa_groupcode
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeGroupaBOCollection()
		{
		    if(this._GroupaBOCollection != null && this._GroupaBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="GroupaBOCollection", EmitDefaultValue = false)]
		public GroupaCollection GroupaBOCollection
		{
			get
			{
				if(this._GroupaBOCollection == null)
				{
					this._GroupaBOCollection = new GroupaCollection();
					this._GroupaBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("GroupaBOCollection", this._GroupaBOCollection);
				
					if (this.Groupcode != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._GroupaBOCollection.Query.Where(this._GroupaBOCollection.Query.Groupcode == this.Groupcode);
							this._GroupaBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._GroupaBOCollection.fks.Add(GroupaMetadata.ColumnNames.Groupcode, this.Groupcode);
					}
				}

				return this._GroupaBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._GroupaBOCollection != null) 
				{ 
					this.RemovePostSave("GroupaBOCollection"); 
					this._GroupaBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private GroupaCollection _GroupaBOCollection;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "GroupaBOCollection":
					coll = this.GroupaBOCollection;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "GroupaBOCollection", typeof(GroupaCollection), new GroupaBO()));
		
			return props;
		}
		
	}
	



	[Serializable]
	public partial class GroupdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected GroupdMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(GroupdMetadata.ColumnNames.Groupcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupdMetadata.PropertyNames.Groupcode;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 2;
			m_columns.Add(c);
				
			c = new esColumnMetadata(GroupdMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupdMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public GroupdMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private GroupdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
