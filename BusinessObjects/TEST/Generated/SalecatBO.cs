
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
	/// Encapsulates the 'salecat' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalecatBO))]	
	[XmlType("SalecatBO")]
	public partial class SalecatBO : esSalecatBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalecatBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalecatCollection")]
	public partial class SalecatCollection : esSalecatCollection, IEnumerable<SalecatBO>
	{

		
				
	}



	[Serializable]	
	public partial class SalecatQuery : esSalecatQuery
	{
		public SalecatQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalecatQuery(string joinAlias, out SalecatQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalecatQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalecatQuery query)
		{
			return SalecatQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalecatQuery(string query)
		{
			return (SalecatQuery)SalecatQuery.SerializeHelper.FromXml(query, typeof(SalecatQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalecatBO : esEntity
	{
		public esSalecatBO()
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
			SalecatQuery query = new SalecatQuery();
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
		/// Maps to salecat.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalecatMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalecatMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(SalecatMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to salecat.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalecatMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalecatMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SalecatMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to salecat.cat
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cat
		{
			get
			{
				return base.GetSystemString(SalecatMetadata.ColumnNames.Cat);
			}
			
			set
			{
				if(base.SetSystemString(SalecatMetadata.ColumnNames.Cat, value))
				{
					OnPropertyChanged(SalecatMetadata.PropertyNames.Cat);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalecatMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalecatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalecatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalecatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalecatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalecatQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalecatQuery query;		
	}



	[Serializable]
	abstract public partial class esSalecatCollection : esEntityCollection<SalecatBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalecatMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalecatCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalecatQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalecatQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalecatQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalecatQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalecatQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalecatQuery)query);
		}

		#endregion
		
		private SalecatQuery query;
	}



	[Serializable]
	abstract public partial class esSalecatQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalecatMetadata.Meta();
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
			get { return new esQueryItem(this, SalecatMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SalecatMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Cat
		{
			get { return new esQueryItem(this, SalecatMetadata.ColumnNames.Cat, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class SalecatBO : esSalecatBO
	{

		
		
	}
	



	[Serializable]
	public partial class SalecatMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalecatMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalecatMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalecatMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalecatMetadata.ColumnNames.Cat, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SalecatMetadata.PropertyNames.Cat;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalecatMetadata Meta()
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
			lock (typeof(SalecatMetadata))
			{
				if(SalecatMetadata.mapDelegates == null)
				{
					SalecatMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalecatMetadata.meta == null)
				{
					SalecatMetadata.meta = new SalecatMetadata();
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
				
				
				
				meta.Source = "salecat";
				meta.Destination = "salecat";
				
				meta.spInsert = "proc_salecatInsert";				
				meta.spUpdate = "proc_salecatUpdate";		
				meta.spDelete = "proc_salecatDelete";
				meta.spLoadAll = "proc_salecatLoadAll";
				meta.spLoadByPrimaryKey = "proc_salecatLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalecatMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
