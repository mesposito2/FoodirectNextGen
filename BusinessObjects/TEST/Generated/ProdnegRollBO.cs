
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
	/// Encapsulates the 'prodneg_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdnegRollBO))]	
	[XmlType("ProdnegRollBO")]
	public partial class ProdnegRollBO : esProdnegRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdnegRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdnegRollCollection")]
	public partial class ProdnegRollCollection : esProdnegRollCollection, IEnumerable<ProdnegRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class ProdnegRollQuery : esProdnegRollQuery
	{
		public ProdnegRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdnegRollQuery(string joinAlias, out ProdnegRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdnegRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdnegRollQuery query)
		{
			return ProdnegRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdnegRollQuery(string query)
		{
			return (ProdnegRollQuery)ProdnegRollQuery.SerializeHelper.FromXml(query, typeof(ProdnegRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdnegRollBO : esEntity
	{
		public esProdnegRollBO()
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
			ProdnegRollQuery query = new ProdnegRollQuery();
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
		/// Maps to prodneg_roll.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(ProdnegRollMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegRollMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(ProdnegRollMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodneg_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProdnegRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(ProdnegRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prodneg_roll.productid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productid
		{
			get
			{
				return base.GetSystemString(ProdnegRollMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemString(ProdnegRollMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProdnegRollMetadata.PropertyNames.Productid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdnegRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdnegRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdnegRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdnegRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdnegRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdnegRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdnegRollQuery query;		
	}



	[Serializable]
	abstract public partial class esProdnegRollCollection : esEntityCollection<ProdnegRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdnegRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdnegRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdnegRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdnegRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdnegRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdnegRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProdnegRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdnegRollQuery)query);
		}

		#endregion
		
		private ProdnegRollQuery query;
	}



	[Serializable]
	abstract public partial class esProdnegRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdnegRollMetadata.Meta();
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
			get { return new esQueryItem(this, ProdnegRollMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, ProdnegRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProdnegRollMetadata.ColumnNames.Productid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdnegRollBO : esProdnegRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProdnegRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdnegRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdnegRollMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegRollMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdnegRollMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdnegRollMetadata.ColumnNames.Productid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdnegRollMetadata.PropertyNames.Productid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdnegRollMetadata Meta()
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
			lock (typeof(ProdnegRollMetadata))
			{
				if(ProdnegRollMetadata.mapDelegates == null)
				{
					ProdnegRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdnegRollMetadata.meta == null)
				{
					ProdnegRollMetadata.meta = new ProdnegRollMetadata();
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
				
				
				
				meta.Source = "prodneg_roll";
				meta.Destination = "prodneg_roll";
				
				meta.spInsert = "proc_prodneg_rollInsert";				
				meta.spUpdate = "proc_prodneg_rollUpdate";		
				meta.spDelete = "proc_prodneg_rollDelete";
				meta.spLoadAll = "proc_prodneg_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_prodneg_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdnegRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
