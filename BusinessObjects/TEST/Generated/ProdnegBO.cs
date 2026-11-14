
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
	/// Encapsulates the 'prodneg' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdnegBO))]	
	[XmlType("ProdnegBO")]
	public partial class ProdnegBO : esProdnegBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdnegBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdnegCollection")]
	public partial class ProdnegCollection : esProdnegCollection, IEnumerable<ProdnegBO>
	{

		
				
	}



	[Serializable]	
	public partial class ProdnegQuery : esProdnegQuery
	{
		public ProdnegQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdnegQuery(string joinAlias, out ProdnegQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdnegQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdnegQuery query)
		{
			return ProdnegQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdnegQuery(string query)
		{
			return (ProdnegQuery)ProdnegQuery.SerializeHelper.FromXml(query, typeof(ProdnegQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdnegBO : esEntity
	{
		public esProdnegBO()
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
			ProdnegQuery query = new ProdnegQuery();
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
		/// Maps to prodneg.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(ProdnegMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(ProdnegMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodneg.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProdnegMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(ProdnegMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodneg.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productid
		{
			get
			{
				return base.GetSystemString(ProdnegMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProdnegMetadata.PropertyNames.Productid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdnegMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdnegQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdnegQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdnegQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdnegQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdnegQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdnegQuery query;		
	}



	[Serializable]
	abstract public partial class esProdnegCollection : esEntityCollection<ProdnegBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdnegMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdnegCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdnegQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdnegQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdnegQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdnegQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProdnegQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdnegQuery)query);
		}

		#endregion
		
		private ProdnegQuery query;
	}



	[Serializable]
	abstract public partial class esProdnegQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdnegMetadata.Meta();
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

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, ProdnegMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, ProdnegMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProdnegMetadata.ColumnNames.Productid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdnegBO : esProdnegBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProdnegMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdnegMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdnegMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdnegMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdnegMetadata.ColumnNames.Productid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegMetadata.PropertyNames.Productid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdnegMetadata Meta()
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
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Productid = "Productid";
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
			lock (typeof(ProdnegMetadata))
			{
				if(ProdnegMetadata.mapDelegates == null)
				{
					ProdnegMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdnegMetadata.meta == null)
				{
					ProdnegMetadata.meta = new ProdnegMetadata();
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
				
				
				
				meta.Source = "prodneg";
				meta.Destination = "prodneg";
				
				meta.spInsert = "proc_prodnegInsert";				
				meta.spUpdate = "proc_prodnegUpdate";		
				meta.spDelete = "proc_prodnegDelete";
				meta.spLoadAll = "proc_prodnegLoadAll";
				meta.spLoadByPrimaryKey = "proc_prodnegLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdnegMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
