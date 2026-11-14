
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
	/// Encapsulates the 'catmarg' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(CatmargBO))]	
	[XmlType("CatmargBO")]
	public partial class CatmargBO : esCatmargBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new CatmargBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CatmargCollection")]
	public partial class CatmargCollection : esCatmargCollection, IEnumerable<CatmargBO>
	{

		
				
	}



	[Serializable]	
	public partial class CatmargQuery : esCatmargQuery
	{
		public CatmargQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CatmargQuery(string joinAlias, out CatmargQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CatmargQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CatmargQuery query)
		{
			return CatmargQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CatmargQuery(string query)
		{
			return (CatmargQuery)CatmargQuery.SerializeHelper.FromXml(query, typeof(CatmargQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCatmargBO : esEntity
	{
		public esCatmargBO()
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
			CatmargQuery query = new CatmargQuery();
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
		/// Maps to catmarg.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(CatmargMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(CatmargMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(CatmargMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(CatmargMetadata.ColumnNames.Catid, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.dmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Dmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Dmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Dmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.pmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Pmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Pmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Pmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.sdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sdmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Sdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Sdmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Sdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.spmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Spmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Spmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Spmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Spmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.pdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pdmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Pdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Pdmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Pdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to catmarg.ppmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ppmarg
		{
			get
			{
				return base.GetSystemDouble(CatmargMetadata.ColumnNames.Ppmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(CatmargMetadata.ColumnNames.Ppmarg, value))
				{
					OnPropertyChanged(CatmargMetadata.PropertyNames.Ppmarg);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CatmargMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CatmargQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatmargQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatmargQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(CatmargQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatmargQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private CatmargQuery query;		
	}



	[Serializable]
	abstract public partial class esCatmargCollection : esEntityCollection<CatmargBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CatmargMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CatmargCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CatmargQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CatmargQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CatmargQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CatmargQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CatmargQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CatmargQuery)query);
		}

		#endregion
		
		private CatmargQuery query;
	}



	[Serializable]
	abstract public partial class esCatmargQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CatmargMetadata.Meta();
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
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Dmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Dmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Pmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Sdmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Sdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Spmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Spmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pdmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Pdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Ppmarg
		{
			get { return new esQueryItem(this, CatmargMetadata.ColumnNames.Ppmarg, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class CatmargBO : esCatmargBO
	{

		
		
	}
	



	[Serializable]
	public partial class CatmargMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CatmargMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Catid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CatmargMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Dmarg, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Dmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Pmarg, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Pmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Sdmarg, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Sdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Spmarg, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Spmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Pdmarg, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Pdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CatmargMetadata.ColumnNames.Ppmarg, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = CatmargMetadata.PropertyNames.Ppmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CatmargMetadata Meta()
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
			lock (typeof(CatmargMetadata))
			{
				if(CatmargMetadata.mapDelegates == null)
				{
					CatmargMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CatmargMetadata.meta == null)
				{
					CatmargMetadata.meta = new CatmargMetadata();
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
				
				
				
				meta.Source = "catmarg";
				meta.Destination = "catmarg";
				
				meta.spInsert = "proc_catmargInsert";				
				meta.spUpdate = "proc_catmargUpdate";		
				meta.spDelete = "proc_catmargDelete";
				meta.spLoadAll = "proc_catmargLoadAll";
				meta.spLoadByPrimaryKey = "proc_catmargLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CatmargMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
