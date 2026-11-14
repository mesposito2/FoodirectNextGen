
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
	/// Encapsulates the 'prodmarg_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdmargRollBO))]	
	[XmlType("ProdmargRollBO")]
	public partial class ProdmargRollBO : esProdmargRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdmargRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdmargRollCollection")]
	public partial class ProdmargRollCollection : esProdmargRollCollection, IEnumerable<ProdmargRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class ProdmargRollQuery : esProdmargRollQuery
	{
		public ProdmargRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdmargRollQuery(string joinAlias, out ProdmargRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdmargRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdmargRollQuery query)
		{
			return ProdmargRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdmargRollQuery(string query)
		{
			return (ProdmargRollQuery)ProdmargRollQuery.SerializeHelper.FromXml(query, typeof(ProdmargRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdmargRollBO : esEntity
	{
		public esProdmargRollBO()
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
			ProdmargRollQuery query = new ProdmargRollQuery();
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
		/// Maps to prodmarg_roll.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(ProdmargRollMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargRollMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProdmargRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productid
		{
			get
			{
				return base.GetSystemString(ProdmargRollMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemString(ProdmargRollMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Productid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.dmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Dmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Dmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Dmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.pmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Pmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Pmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Pmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.sdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sdmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Sdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Sdmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Sdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.spmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Spmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Spmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Spmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Spmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.pdmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pdmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Pdmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Pdmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Pdmarg);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodmarg_roll.ppmarg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ppmarg
		{
			get
			{
				return base.GetSystemDouble(ProdmargRollMetadata.ColumnNames.Ppmarg);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdmargRollMetadata.ColumnNames.Ppmarg, value))
				{
					OnPropertyChanged(ProdmargRollMetadata.PropertyNames.Ppmarg);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdmargRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdmargRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdmargRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdmargRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdmargRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdmargRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdmargRollQuery query;		
	}



	[Serializable]
	abstract public partial class esProdmargRollCollection : esEntityCollection<ProdmargRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdmargRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdmargRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdmargRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdmargRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdmargRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdmargRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProdmargRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdmargRollQuery)query);
		}

		#endregion
		
		private ProdmargRollQuery query;
	}



	[Serializable]
	abstract public partial class esProdmargRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdmargRollMetadata.Meta();
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
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Productid, esSystemType.String); }
		} 
		
		public esQueryItem Dmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Dmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Pmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Sdmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Sdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Spmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Spmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Pdmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Pdmarg, esSystemType.Double); }
		} 
		
		public esQueryItem Ppmarg
		{
			get { return new esQueryItem(this, ProdmargRollMetadata.ColumnNames.Ppmarg, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdmargRollBO : esProdmargRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProdmargRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdmargRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Productid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Productid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Dmarg, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Dmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Pmarg, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Pmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Sdmarg, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Sdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Spmarg, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Spmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Pdmarg, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Pdmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdmargRollMetadata.ColumnNames.Ppmarg, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdmargRollMetadata.PropertyNames.Ppmarg;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdmargRollMetadata Meta()
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
			lock (typeof(ProdmargRollMetadata))
			{
				if(ProdmargRollMetadata.mapDelegates == null)
				{
					ProdmargRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdmargRollMetadata.meta == null)
				{
					ProdmargRollMetadata.meta = new ProdmargRollMetadata();
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
				
				
				
				meta.Source = "prodmarg_roll";
				meta.Destination = "prodmarg_roll";
				
				meta.spInsert = "proc_prodmarg_rollInsert";				
				meta.spUpdate = "proc_prodmarg_rollUpdate";		
				meta.spDelete = "proc_prodmarg_rollDelete";
				meta.spLoadAll = "proc_prodmarg_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_prodmarg_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdmargRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
