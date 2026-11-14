
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
	/// Encapsulates the 'groupa' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(GroupaBO))]	
	[XmlType("GroupaBO")]
	public partial class GroupaBO : esGroupaBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new GroupaBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 groupaID)
		{
			var obj = new GroupaBO();
			obj.GroupaID = groupaID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 groupaID, esSqlAccessType sqlAccessType)
		{
			var obj = new GroupaBO();
			obj.GroupaID = groupaID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("GroupaCollection")]
	public partial class GroupaCollection : esGroupaCollection, IEnumerable<GroupaBO>
	{
		public GroupaBO FindByPrimaryKey(System.Int32 groupaID)
		{
			return this.SingleOrDefault(e => e.GroupaID == groupaID);
		}

		
				
	}



	[Serializable]	
	public partial class GroupaQuery : esGroupaQuery
	{
		public GroupaQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public GroupaQuery(string joinAlias, out GroupaQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "GroupaQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(GroupaQuery query)
		{
			return GroupaQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator GroupaQuery(string query)
		{
			return (GroupaQuery)GroupaQuery.SerializeHelper.FromXml(query, typeof(GroupaQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esGroupaBO : esEntity
	{
		public esGroupaBO()
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
			GroupaQuery query = new GroupaQuery();
			query.Where(query.GroupaID == groupaID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 groupaID)
		{
			esParameters parms = new esParameters();
			parms.Add("GroupaID", groupaID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to groupa.groupcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._GroupdBO = null;
					this.OnPropertyChanged("GroupdBO");
					OnPropertyChanged(GroupaMetadata.PropertyNames.Groupcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._ProdsBO = null;
					this.OnPropertyChanged("ProdsBO");
					OnPropertyChanged(GroupaMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.brandcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(GroupaMetadata.PropertyNames.Brandcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(GroupaMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to groupa.GroupaID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(GroupaMetadata.PropertyNames.GroupaID);
				}
			}
		}
		
		internal protected GroupdBO _GroupdBO;
		internal protected ProdsBO _ProdsBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return GroupaMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public GroupaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupaQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(GroupaQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(GroupaQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((GroupaQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private GroupaQuery query;		
	}



	[Serializable]
	abstract public partial class esGroupaCollection : esEntityCollection<GroupaBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return GroupaMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "GroupaCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public GroupaQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new GroupaQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(GroupaQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(GroupaQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((GroupaQuery)query);
		}

		#endregion
		
		private GroupaQuery query;
	}



	[Serializable]
	abstract public partial class esGroupaQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return GroupaMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Groupcode": return this.Groupcode;
				case "Productcode": return this.Productcode;
				case "Brandcode": return this.Brandcode;
				case "Scatid": return this.Scatid;
				case "GroupaID": return this.GroupaID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Groupcode
		{
			get { return new esQueryItem(this, GroupaMetadata.ColumnNames.Groupcode, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, GroupaMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Brandcode
		{
			get { return new esQueryItem(this, GroupaMetadata.ColumnNames.Brandcode, esSystemType.String); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, GroupaMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem GroupaID
		{
			get { return new esQueryItem(this, GroupaMetadata.ColumnNames.GroupaID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class GroupaBO : esGroupaBO
	{

		
		#region GroupdBO - Many To One (FK_groupa_groupcode)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeGroupdBO()
		{
		    return this._GroupdBO != null ? true : false;
		}
		

		[DataMember(Name="GroupdBO", EmitDefaultValue = false)]
					
		public GroupdBO GroupdBO
		{
			get
			{
                if (this._GroupdBO == null)
                {
                    this._GroupdBO = new GroupdBO();
                    this._GroupdBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("GroupdBO", this._GroupdBO);

					if(this._GroupdBO == null && Groupcode != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._GroupdBO.Query.Where(this._GroupdBO.Query.Groupcode == this.Groupcode);
							this._GroupdBO.Query.Load();
                        }
                    }
                }

				return this._GroupdBO;
			}
			
			set
			{
				this.RemovePreSave("GroupdBO");
				

				if(value == null)
				{
					this.Groupcode = null;
					this._GroupdBO = null;
				}
				else
				{
					this.Groupcode = value.Groupcode;
					this._GroupdBO = value;
					this.SetPreSave("GroupdBO", this._GroupdBO);
				}
				
			}
		}
		#endregion
		

		
		#region ProdsBO - Many To One (FK_groupa_productcode)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeProdsBO()
		{
		    return this._ProdsBO != null ? true : false;
		}
		

		[DataMember(Name="ProdsBO", EmitDefaultValue = false)]
					
		public ProdsBO ProdsBO
		{
			get
			{
                if (this._ProdsBO == null)
                {
                    this._ProdsBO = new ProdsBO();
                    this._ProdsBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("ProdsBO", this._ProdsBO);

					if(this._ProdsBO == null && Productcode != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._ProdsBO.Query.Where(this._ProdsBO.Query.Productcode == this.Productcode);
							this._ProdsBO.Query.Load();
                        }
                    }
                }

				return this._ProdsBO;
			}
			
			set
			{
				this.RemovePreSave("ProdsBO");
				

				if(value == null)
				{
					this.Productcode = null;
					this._ProdsBO = null;
				}
				else
				{
					this.Productcode = value.Productcode;
					this._ProdsBO = value;
					this.SetPreSave("ProdsBO", this._ProdsBO);
				}
				
			}
		}
		#endregion
		

		
		
	}
	



	[Serializable]
	public partial class GroupaMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected GroupaMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Groupcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Groupcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Brandcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Brandcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.Scatid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = GroupaMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(GroupaMetadata.ColumnNames.GroupaID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = GroupaMetadata.PropertyNames.GroupaID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public GroupaMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private GroupaMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
