
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:17 PM
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
	/// Encapsulates the 'wta_lists' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaListsBO))]	
	[XmlType("WtaListsBO")]
	public partial class WtaListsBO : esWtaListsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaListsBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaListsCollection")]
	public partial class WtaListsCollection : esWtaListsCollection, IEnumerable<WtaListsBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaListsQuery : esWtaListsQuery
	{
		public WtaListsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaListsQuery(string joinAlias, out WtaListsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaListsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaListsQuery query)
		{
			return WtaListsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaListsQuery(string query)
		{
			return (WtaListsQuery)WtaListsQuery.SerializeHelper.FromXml(query, typeof(WtaListsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaListsBO : esEntity
	{
		public esWtaListsBO()
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
			WtaListsQuery query = new WtaListsQuery();
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
		/// Maps to wta_lists.lid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Lid
		{
			get
			{
				return base.GetSystemInt32(WtaListsMetadata.ColumnNames.Lid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaListsMetadata.ColumnNames.Lid, value))
				{
					OnPropertyChanged(WtaListsMetadata.PropertyNames.Lid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_lists.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaListsMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaListsMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaListsMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_lists.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Type
		{
			get
			{
				return base.GetSystemInt32(WtaListsMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaListsMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(WtaListsMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_lists.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaListsMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaListsMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaListsMetadata.PropertyNames.Mid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaListsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaListsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaListsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaListsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaListsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaListsQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaListsCollection : esEntityCollection<WtaListsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaListsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaListsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaListsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaListsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaListsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaListsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaListsQuery)query);
		}

		#endregion
		
		private WtaListsQuery query;
	}



	[Serializable]
	abstract public partial class esWtaListsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaListsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Lid": return this.Lid;
				case "Description": return this.Description;
				case "Type": return this.Type;
				case "Mid": return this.Mid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Lid
		{
			get { return new esQueryItem(this, WtaListsMetadata.ColumnNames.Lid, esSystemType.Int32); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaListsMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, WtaListsMetadata.ColumnNames.Type, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaListsMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaListsBO : esWtaListsBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaListsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaListsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaListsMetadata.ColumnNames.Lid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaListsMetadata.PropertyNames.Lid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaListsMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaListsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaListsMetadata.ColumnNames.Type, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaListsMetadata.PropertyNames.Type;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaListsMetadata.ColumnNames.Mid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaListsMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaListsMetadata Meta()
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
			 public const string Lid = "lid";
			 public const string Description = "description";
			 public const string Type = "type";
			 public const string Mid = "mid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Lid = "Lid";
			 public const string Description = "Description";
			 public const string Type = "Type";
			 public const string Mid = "Mid";
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
			lock (typeof(WtaListsMetadata))
			{
				if(WtaListsMetadata.mapDelegates == null)
				{
					WtaListsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaListsMetadata.meta == null)
				{
					WtaListsMetadata.meta = new WtaListsMetadata();
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


				meta.AddTypeMap("Lid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_lists";
				meta.Destination = "wta_lists";
				
				meta.spInsert = "proc_wta_listsInsert";				
				meta.spUpdate = "proc_wta_listsUpdate";		
				meta.spDelete = "proc_wta_listsDelete";
				meta.spLoadAll = "proc_wta_listsLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_listsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaListsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
