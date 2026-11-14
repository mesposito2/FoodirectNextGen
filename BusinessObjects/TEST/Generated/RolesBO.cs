
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:15 PM
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
	/// Encapsulates the 'roles' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(RolesBO))]	
	[XmlType("RolesBO")]
	public partial class RolesBO : esRolesBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new RolesBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("RolesCollection")]
	public partial class RolesCollection : esRolesCollection, IEnumerable<RolesBO>
	{

		
				
	}



	[Serializable]	
	public partial class RolesQuery : esRolesQuery
	{
		public RolesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public RolesQuery(string joinAlias, out RolesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "RolesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(RolesQuery query)
		{
			return RolesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator RolesQuery(string query)
		{
			return (RolesQuery)RolesQuery.SerializeHelper.FromXml(query, typeof(RolesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esRolesBO : esEntity
	{
		public esRolesBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey()
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, )
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		private bool LoadByPrimaryKeyDynamic()
		{
			RolesQuery query = new RolesQuery();
			query.Where();
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure()
		{
			esParameters parms = new esParameters();

			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to roles.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Type
		{
			get
			{
				return base.GetSystemInt32(RolesMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt32(RolesMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(RolesMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to roles.access
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Access
		{
			get
			{
				return base.GetSystemInt32(RolesMetadata.ColumnNames.Access);
			}
			
			set
			{
				if(base.SetSystemInt32(RolesMetadata.ColumnNames.Access, value))
				{
					OnPropertyChanged(RolesMetadata.PropertyNames.Access);
				}
			}
		}
		
		/// <summary>
		/// Maps to roles.name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(RolesMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(RolesMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(RolesMetadata.PropertyNames.Name);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return RolesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public RolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(RolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RolesQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private RolesQuery query;		
	}



	[Serializable]
	abstract public partial class esRolesCollection : esEntityCollection<RolesBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RolesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "RolesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public RolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(RolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RolesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(RolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((RolesQuery)query);
		}

		#endregion
		
		private RolesQuery query;
	}



	[Serializable]
	abstract public partial class esRolesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RolesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Type": return this.Type;
				case "Access": return this.Access;
				case "Name": return this.Name;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Type
		{
			get { return new esQueryItem(this, RolesMetadata.ColumnNames.Type, esSystemType.Int32); }
		} 
		
		public esQueryItem Access
		{
			get { return new esQueryItem(this, RolesMetadata.ColumnNames.Access, esSystemType.Int32); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, RolesMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class RolesBO : esRolesBO
	{

		
		
	}
	



	[Serializable]
	public partial class RolesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RolesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RolesMetadata.ColumnNames.Type, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = RolesMetadata.PropertyNames.Type;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RolesMetadata.ColumnNames.Access, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = RolesMetadata.PropertyNames.Access;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(RolesMetadata.ColumnNames.Name, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = RolesMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public RolesMetadata Meta()
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
			 public const string Type = "type";
			 public const string Access = "access";
			 public const string Name = "name";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Type = "Type";
			 public const string Access = "Access";
			 public const string Name = "Name";
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
			lock (typeof(RolesMetadata))
			{
				if(RolesMetadata.mapDelegates == null)
				{
					RolesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RolesMetadata.meta == null)
				{
					RolesMetadata.meta = new RolesMetadata();
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


				meta.AddTypeMap("Type", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Access", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Name", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "roles";
				meta.Destination = "roles";
				
				meta.spInsert = "proc_rolesInsert";				
				meta.spUpdate = "proc_rolesUpdate";		
				meta.spDelete = "proc_rolesDelete";
				meta.spLoadAll = "proc_rolesLoadAll";
				meta.spLoadByPrimaryKey = "proc_rolesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RolesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
