
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
	/// Encapsulates the 'catneg_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatnegRollBO))]	
	[XmlType("CatnegRollBO")]
	public partial class CatnegRollBO : esCatnegRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatnegRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatnegRollCollection")]
	public partial class CatnegRollCollection : esCatnegRollCollection, IEnumerable<CatnegRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class CatnegRollQuery : esCatnegRollQuery
	{
		public CatnegRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatnegRollQuery(string joinAlias, out CatnegRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatnegRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatnegRollQuery query)
		{
			return CatnegRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatnegRollQuery(string query)
		{
			return (CatnegRollQuery)CatnegRollQuery.SerializeHelper.FromXml(query, typeof(CatnegRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatnegRollBO : esEntity
	{
		public esCatnegRollBO()
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
			CatnegRollQuery query = new CatnegRollQuery();
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
		/// Maps to catneg_roll.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(CatnegRollMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegRollMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(CatnegRollMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catneg_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(CatnegRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(CatnegRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catneg_roll.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatnegRollMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(CatnegRollMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(CatnegRollMetadata.PropertyNames.Catid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatnegRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatnegRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatnegRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatnegRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatnegRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatnegRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatnegRollQuery query;		
	}



	[Serializable]
	abstract public partial class esCatnegRollCollection : esEntityCollection<CatnegRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatnegRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatnegRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatnegRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatnegRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatnegRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatnegRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatnegRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatnegRollQuery)query);
		}

		#endregion
		
		private CatnegRollQuery query;
	}



	[Serializable]
	abstract public partial class esCatnegRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatnegRollMetadata.Meta();
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
			get { return new esQueryItem(this, CatnegRollMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, CatnegRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, CatnegRollMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class CatnegRollBO : esCatnegRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class CatnegRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatnegRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatnegRollMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegRollMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatnegRollMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatnegRollMetadata.ColumnNames.Catid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CatnegRollMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatnegRollMetadata Meta()
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
			lock (typeof(CatnegRollMetadata))
			{
				if(CatnegRollMetadata.mapDelegates == null)
				{
					CatnegRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatnegRollMetadata.meta == null)
				{
					CatnegRollMetadata.meta = new CatnegRollMetadata();
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
				
				
				
				meta.Source = "catneg_roll";
				meta.Destination = "catneg_roll";
				
				meta.spInsert = "proc_catneg_rollInsert";				
				meta.spUpdate = "proc_catneg_rollUpdate";		
				meta.spDelete = "proc_catneg_rollDelete";
				meta.spLoadAll = "proc_catneg_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_catneg_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatnegRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
