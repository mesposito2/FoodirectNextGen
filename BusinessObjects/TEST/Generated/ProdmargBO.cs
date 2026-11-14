
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
	/// Encapsulates the 'prodmarg' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdmargBO))]	
	[XmlType("ProdmargBO")]
	public partial class ProdmargBO : esProdmargBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdmargBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdmargCollection")]
	public partial class ProdmargCollection : esProdmargCollection, IEnumerable<ProdmargBO>
	{

		
				
	}



	[Serializable]	
	public partial class ProdmargQuery : esProdmargQuery
	{
		public ProdmargQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdmargQuery(string joinAlias, out ProdmargQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdmargQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdmargQuery query)
		{
			return ProdmargQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdmargQuery(string query)
		{
			return (ProdmargQuery)ProdmargQuery.SerializeHelper.FromXml(query, typeof(ProdmargQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdmargBO : esEntity
	{
		public esProdmargBO()
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
			ProdmargQuery query = new ProdmargQuery();
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
		/// Maps to prodmarg.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(ProdmargMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProdmargMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productid
		{
			get
			{
				return base.GetSystemString(ProdmargMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Productid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.dmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Dmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Dmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Dmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.pmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Pmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Pmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Pmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.sdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sdmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Sdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Sdmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Sdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.spmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Spmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Spmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Spmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Spmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.pdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pdmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Pdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Pdmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Pdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg.ppmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ppmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargMetadata.ColumnNames.Ppmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargMetadata.ColumnNames.Ppmarg, value))
				{
					OnPropertyChanged(ProdmargMetadata.PropertyNames.Ppmarg);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdmargMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdmargQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdmargQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdmargQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdmargQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdmargQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdmargQuery query;		
	}



	[Serializable]
	abstract public partial class esProdmargCollection : esEntityCollection<ProdmargBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdmargMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdmargCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdmargQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdmargQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdmargQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdmargQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProdmargQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdmargQuery)query);
		}

		#endregion
		
		private ProdmargQuery query;
	}



	[Serializable]
	abstract public partial class esProdmargQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdmargMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Custid": return this.Custid;
				case "Productid": return this.Productid;
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
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Productid, esSystemType.String); }
		} 
		
		public esQueryItem Dmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Dmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Pmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Sdmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Sdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Spmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Spmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pdmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Pdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Ppmarg
		{
			get { return new esQueryItem(this, ProdmargMetadata.ColumnNames.Ppmarg, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdmargBO : esProdmargBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProdmargMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdmargMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Productid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargMetadata.PropertyNames.Productid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Dmarg, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Dmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Pmarg, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Pmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Sdmarg, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Sdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Spmarg, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Spmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Pdmarg, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Pdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargMetadata.ColumnNames.Ppmarg, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargMetadata.PropertyNames.Ppmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdmargMetadata Meta()
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
			 public const string Productid = "productid";
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
			 public const string Productid = "Productid";
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
			lock (typeof(ProdmargMetadata))
			{
				if(ProdmargMetadata.mapDelegates == null)
				{
					ProdmargMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdmargMetadata.meta == null)
				{
					ProdmargMetadata.meta = new ProdmargMetadata();
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
				meta.AddTypeMap("Productid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Dmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sdmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Spmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pdmarg", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ppmarg", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "prodmarg";
				meta.Destination = "prodmarg";
				
				meta.spInsert = "proc_prodmargInsert";				
				meta.spUpdate = "proc_prodmargUpdate";		
				meta.spDelete = "proc_prodmargDelete";
				meta.spLoadAll = "proc_prodmargLoadAll";
				meta.spLoadByPrimaryKey = "proc_prodmargLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdmargMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
