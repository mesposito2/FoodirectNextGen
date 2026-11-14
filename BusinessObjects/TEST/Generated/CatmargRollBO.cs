
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
	/// Encapsulates the 'catmarg_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatmargRollBO))]	
	[XmlType("CatmargRollBO")]
	public partial class CatmargRollBO : esCatmargRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatmargRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatmargRollCollection")]
	public partial class CatmargRollCollection : esCatmargRollCollection, IEnumerable<CatmargRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class CatmargRollQuery : esCatmargRollQuery
	{
		public CatmargRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatmargRollQuery(string joinAlias, out CatmargRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatmargRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatmargRollQuery query)
		{
			return CatmargRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatmargRollQuery(string query)
		{
			return (CatmargRollQuery)CatmargRollQuery.SerializeHelper.FromXml(query, typeof(CatmargRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatmargRollBO : esEntity
	{
		public esCatmargRollBO()
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
			CatmargRollQuery query = new CatmargRollQuery();
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
		/// Maps to catmarg_roll.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(CatmargRollMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargRollMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(CatmargRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatmargRollMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargRollMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.dmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Dmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Dmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Dmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.pmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Pmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Pmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Pmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.sdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sdmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Sdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Sdmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Sdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.spmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Spmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Spmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Spmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Spmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.pdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pdmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Pdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Pdmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Pdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg_roll.ppmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ppmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargRollMetadata.ColumnNames.Ppmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargRollMetadata.ColumnNames.Ppmarg, value))
				{
					OnPropertyChanged(CatmargRollMetadata.PropertyNames.Ppmarg);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatmargRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatmargRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatmargRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatmargRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatmargRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatmargRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatmargRollQuery query;		
	}



	[Serializable]
	abstract public partial class esCatmargRollCollection : esEntityCollection<CatmargRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatmargRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatmargRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatmargRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatmargRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatmargRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatmargRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatmargRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatmargRollQuery)query);
		}

		#endregion
		
		private CatmargRollQuery query;
	}



	[Serializable]
	abstract public partial class esCatmargRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatmargRollMetadata.Meta();
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
				case "Dmarg": return this.Dmarg;
				case "Pmarg": return this.Pmarg;
				case "Sdmarg": return this.Sdmarg;
				case "Spmarg": return this.Spmarg;
				case "Pdmarg": return this.Pdmarg;
				case "Ppmarg": return this.Ppmarg;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Dmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Dmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Pmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Sdmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Sdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Spmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Spmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pdmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Pdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Ppmarg
		{
			get { return new esQueryItem(this, CatmargRollMetadata.ColumnNames.Ppmarg, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class CatmargRollBO : esCatmargRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class CatmargRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatmargRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Catid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Dmarg, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Dmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Pmarg, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Pmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Sdmarg, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Sdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Spmarg, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Spmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Pdmarg, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Pdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargRollMetadata.ColumnNames.Ppmarg, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargRollMetadata.PropertyNames.Ppmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatmargRollMetadata Meta()
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
			 public const string Dmarg = "dmarg";
			 public const string Pmarg = "pmarg";
			 public const string Sdmarg = "sdmarg";
			 public const string Spmarg = "spmarg";
			 public const string Pdmarg = "pdmarg";
			 public const string Ppmarg = "ppmarg";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Catid = "Catid";
			 public const string Dmarg = "Dmarg";
			 public const string Pmarg = "Pmarg";
			 public const string Sdmarg = "Sdmarg";
			 public const string Spmarg = "Spmarg";
			 public const string Pdmarg = "Pdmarg";
			 public const string Ppmarg = "Ppmarg";
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
			lock (typeof(CatmargRollMetadata))
			{
				if(CatmargRollMetadata.mapDelegates == null)
				{
					CatmargRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatmargRollMetadata.meta == null)
				{
					CatmargRollMetadata.meta = new CatmargRollMetadata();
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
				meta.AddTypeMap("Dmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sdmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Spmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pdmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ppmarg", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "catmarg_roll";
				meta.Destination = "catmarg_roll";
				
				meta.spInsert = "proc_catmarg_rollInsert";				
				meta.spUpdate = "proc_catmarg_rollUpdate";		
				meta.spDelete = "proc_catmarg_rollDelete";
				meta.spLoadAll = "proc_catmarg_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_catmarg_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatmargRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
