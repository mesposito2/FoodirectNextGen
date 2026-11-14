
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
	/// Encapsulates the 'ProdCustGuide' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdCustGuideBO))]	
	[XmlType("ProdCustGuideBO")]
	public partial class ProdCustGuideBO : esProdCustGuideBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdCustGuideBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 prodCustGuideID)
		{
			var obj = new ProdCustGuideBO();
			obj.ProdCustGuideID = prodCustGuideID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 prodCustGuideID, esSqlAccessType sqlAccessType)
		{
			var obj = new ProdCustGuideBO();
			obj.ProdCustGuideID = prodCustGuideID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdCustGuideCollection")]
	public partial class ProdCustGuideCollection : esProdCustGuideCollection, IEnumerable<ProdCustGuideBO>
	{
		public ProdCustGuideBO FindByPrimaryKey(System.Int32 prodCustGuideID)
		{
			return this.SingleOrDefault(e => e.ProdCustGuideID == prodCustGuideID);
		}

		
				
	}



	[Serializable]	
	public partial class ProdCustGuideQuery : esProdCustGuideQuery
	{
		public ProdCustGuideQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdCustGuideQuery(string joinAlias, out ProdCustGuideQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdCustGuideQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdCustGuideQuery query)
		{
			return ProdCustGuideQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdCustGuideQuery(string query)
		{
			return (ProdCustGuideQuery)ProdCustGuideQuery.SerializeHelper.FromXml(query, typeof(ProdCustGuideQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdCustGuideBO : esEntity
	{
		public esProdCustGuideBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 prodCustGuideID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(prodCustGuideID);
			else
				return LoadByPrimaryKeyStoredProcedure(prodCustGuideID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 prodCustGuideID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(prodCustGuideID);
			else
				return LoadByPrimaryKeyStoredProcedure(prodCustGuideID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 prodCustGuideID)
		{
			ProdCustGuideQuery query = new ProdCustGuideQuery();
			query.Where(query.ProdCustGuideID == prodCustGuideID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 prodCustGuideID)
		{
			esParameters parms = new esParameters();
			parms.Add("ProdCustGuideID", prodCustGuideID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ProdCustGuide.ProdCustGuideID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ProdCustGuideID
		{
			get
			{
				return base.GetSystemInt32(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.ProdCustGuideID);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.ProductCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProductCode
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.ProductCode);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.ProductCode, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.ProductCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CustID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.CustID, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.CustID);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(ProdCustGuideMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ProdCustGuideMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(ProdCustGuideMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ProdCustGuideMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to ProdCustGuide.LastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, value))
				{
					OnPropertyChanged(ProdCustGuideMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdCustGuideMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdCustGuideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdCustGuideQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdCustGuideQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdCustGuideQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdCustGuideQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdCustGuideQuery query;		
	}



	[Serializable]
	abstract public partial class esProdCustGuideCollection : esEntityCollection<ProdCustGuideBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdCustGuideMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdCustGuideCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdCustGuideQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdCustGuideQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdCustGuideQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdCustGuideQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProdCustGuideQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdCustGuideQuery)query);
		}

		#endregion
		
		private ProdCustGuideQuery query;
	}



	[Serializable]
	abstract public partial class esProdCustGuideQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdCustGuideMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ProdCustGuideID": return this.ProdCustGuideID;
				case "ProductCode": return this.ProductCode;
				case "CustID": return this.CustID;
				case "CreateDate": return this.CreateDate;
				case "CreatedBy": return this.CreatedBy;
				case "LastUpdate": return this.LastUpdate;
				case "LastUpdatedBy": return this.LastUpdatedBy;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ProdCustGuideID
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductCode
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.ProductCode, esSystemType.String); }
		} 
		
		public esQueryItem CustID
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CustID, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CreateDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdCustGuideBO : esProdCustGuideBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProdCustGuideMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdCustGuideMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.ProdCustGuideID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.ProdCustGuideID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.ProductCode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.ProductCode;
			c.CharacterMaxLength = 6;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CustID, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CreateDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.CreatedBy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.LastUpdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.LastUpdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdCustGuideMetadata.ColumnNames.LastUpdatedBy, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdCustGuideMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdCustGuideMetadata Meta()
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
			 public const string ProdCustGuideID = "ProdCustGuideID";
			 public const string ProductCode = "ProductCode";
			 public const string CustID = "CustID";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ProdCustGuideID = "ProdCustGuideID";
			 public const string ProductCode = "ProductCode";
			 public const string CustID = "CustID";
			 public const string CreateDate = "CreateDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(ProdCustGuideMetadata))
			{
				if(ProdCustGuideMetadata.mapDelegates == null)
				{
					ProdCustGuideMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdCustGuideMetadata.meta == null)
				{
					ProdCustGuideMetadata.meta = new ProdCustGuideMetadata();
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


				meta.AddTypeMap("ProdCustGuideID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ProductCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "ProdCustGuide";
				meta.Destination = "ProdCustGuide";
				
				meta.spInsert = "proc_ProdCustGuideInsert";				
				meta.spUpdate = "proc_ProdCustGuideUpdate";		
				meta.spDelete = "proc_ProdCustGuideDelete";
				meta.spLoadAll = "proc_ProdCustGuideLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProdCustGuideLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdCustGuideMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
