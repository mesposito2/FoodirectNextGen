
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:13 PM
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
	/// Encapsulates the 'catneg' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatnegBO))]	
	[XmlType("CatnegBO")]
	public partial class CatnegBO : esCatnegBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatnegBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatnegCollection")]
	public partial class CatnegCollection : esCatnegCollection, IEnumerable<CatnegBO>
	{

		
				
	}



	[Serializable]	
	public partial class CatnegQuery : esCatnegQuery
	{
		public CatnegQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatnegQuery(string joinAlias, out CatnegQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatnegQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatnegQuery query)
		{
			return CatnegQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatnegQuery(string query)
		{
			return (CatnegQuery)CatnegQuery.SerializeHelper.FromXml(query, typeof(CatnegQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatnegBO : esEntity
	{
		public esCatnegBO()
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
			CatnegQuery query = new CatnegQuery();
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
		/// Maps to catneg.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(CatnegMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(CatnegMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catneg.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(CatnegMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(CatnegMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catneg.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatnegMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(CatnegMetadata.PropertyNames.Catid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatnegMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatnegQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatnegQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatnegQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatnegQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatnegQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatnegQuery query;		
	}



	[Serializable]
	abstract public partial class esCatnegCollection : esEntityCollection<CatnegBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatnegMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatnegCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatnegQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatnegQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatnegQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatnegQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatnegQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatnegQuery)query);
		}

		#endregion
		
		private CatnegQuery query;
	}



	[Serializable]
	abstract public partial class esCatnegQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatnegMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Custid": return this.Custid;
				case "Catid": return this.Catid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, CatnegMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, CatnegMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, CatnegMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CatnegBO : esCatnegBO
	{

		
		
	}
	



	[Serializable]
	public partial class CatnegMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatnegMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatnegMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatnegMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatnegMetadata.ColumnNames.Catid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatnegMetadata Meta()
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
			 public const string Mid = "mid";
			 public const string Custid = "custid";
			 public const string Catid = "catid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Catid = "Catid";
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
			lock (typeof(CatnegMetadata))
			{
				if(CatnegMetadata.mapDelegates == null)
				{
					CatnegMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatnegMetadata.meta == null)
				{
					CatnegMetadata.meta = new CatnegMetadata();
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


				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "catneg";
				meta.Destination = "catneg";
				
				meta.spInsert = "proc_catnegInsert";				
				meta.spUpdate = "proc_catnegUpdate";		
				meta.spDelete = "proc_catnegDelete";
				meta.spLoadAll = "proc_catnegLoadAll";
				meta.spLoadByPrimaryKey = "proc_catnegLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatnegMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
