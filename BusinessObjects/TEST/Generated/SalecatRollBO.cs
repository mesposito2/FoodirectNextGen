
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
	/// Encapsulates the 'salecat_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalecatRollBO))]	
	[XmlType("SalecatRollBO")]
	public partial class SalecatRollBO : esSalecatRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalecatRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalecatRollCollection")]
	public partial class SalecatRollCollection : esSalecatRollCollection, IEnumerable<SalecatRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class SalecatRollQuery : esSalecatRollQuery
	{
		public SalecatRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalecatRollQuery(string joinAlias, out SalecatRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalecatRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalecatRollQuery query)
		{
			return SalecatRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalecatRollQuery(string query)
		{
			return (SalecatRollQuery)SalecatRollQuery.SerializeHelper.FromXml(query, typeof(SalecatRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalecatRollBO : esEntity
	{
		public esSalecatRollBO()
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
			SalecatRollQuery query = new SalecatRollQuery();
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
		/// Maps to salecat_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalecatRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalecatRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(SalecatRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to salecat_roll.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalecatRollMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalecatRollMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SalecatRollMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to salecat_roll.cat
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cat
		{
			get
			{
				return base.GetSystemString(SalecatRollMetadata.ColumnNames.Cat);
			}
			
			set
			{
				if(base.SetSystemString(SalecatRollMetadata.ColumnNames.Cat, value))
				{
					OnPropertyChanged(SalecatRollMetadata.PropertyNames.Cat);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalecatRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalecatRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalecatRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalecatRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalecatRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalecatRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalecatRollQuery query;		
	}



	[Serializable]
	abstract public partial class esSalecatRollCollection : esEntityCollection<SalecatRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalecatRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalecatRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalecatRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalecatRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalecatRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalecatRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalecatRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalecatRollQuery)query);
		}

		#endregion
		
		private SalecatRollQuery query;
	}



	[Serializable]
	abstract public partial class esSalecatRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalecatRollMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Productcode": return this.Productcode;
				case "Cat": return this.Cat;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, SalecatRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SalecatRollMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Cat
		{
			get { return new esQueryItem(this, SalecatRollMetadata.ColumnNames.Cat, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class SalecatRollBO : esSalecatRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class SalecatRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalecatRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalecatRollMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalecatRollMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatRollMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalecatRollMetadata.ColumnNames.Cat, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatRollMetadata.PropertyNames.Cat;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalecatRollMetadata Meta()
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
			 public const string Custid = "custid";
			 public const string Productcode = "productcode";
			 public const string Cat = "cat";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Productcode = "Productcode";
			 public const string Cat = "Cat";
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
			lock (typeof(SalecatRollMetadata))
			{
				if(SalecatRollMetadata.mapDelegates == null)
				{
					SalecatRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalecatRollMetadata.meta == null)
				{
					SalecatRollMetadata.meta = new SalecatRollMetadata();
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


				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cat", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "salecat_roll";
				meta.Destination = "salecat_roll";
				
				meta.spInsert = "proc_salecat_rollInsert";				
				meta.spUpdate = "proc_salecat_rollUpdate";		
				meta.spDelete = "proc_salecat_rollDelete";
				meta.spLoadAll = "proc_salecat_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_salecat_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalecatRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
