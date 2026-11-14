
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:14 PM
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
	/// Encapsulates the 'PriceMaster' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(PriceMasterBO))]	
	[XmlType("PriceMasterBO")]
	public partial class PriceMasterBO : esPriceMasterBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new PriceMasterBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 priceMasterID)
		{
			var obj = new PriceMasterBO();
			obj.PriceMasterID = priceMasterID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 priceMasterID, esSqlAccessType sqlAccessType)
		{
			var obj = new PriceMasterBO();
			obj.PriceMasterID = priceMasterID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("PriceMasterCollection")]
	public partial class PriceMasterCollection : esPriceMasterCollection, IEnumerable<PriceMasterBO>
	{
		public PriceMasterBO FindByPrimaryKey(System.Int32 priceMasterID)
		{
			return this.SingleOrDefault(e => e.PriceMasterID == priceMasterID);
		}

		
				
	}



	[Serializable]	
	public partial class PriceMasterQuery : esPriceMasterQuery
	{
		public PriceMasterQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public PriceMasterQuery(string joinAlias, out PriceMasterQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "PriceMasterQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(PriceMasterQuery query)
		{
			return PriceMasterQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator PriceMasterQuery(string query)
		{
			return (PriceMasterQuery)PriceMasterQuery.SerializeHelper.FromXml(query, typeof(PriceMasterQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esPriceMasterBO : esEntity
	{
		public esPriceMasterBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 priceMasterID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(priceMasterID);
			else
				return LoadByPrimaryKeyStoredProcedure(priceMasterID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 priceMasterID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(priceMasterID);
			else
				return LoadByPrimaryKeyStoredProcedure(priceMasterID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 priceMasterID)
		{
			PriceMasterQuery query = new PriceMasterQuery();
			query.Where(query.PriceMasterID == priceMasterID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 priceMasterID)
		{
			esParameters parms = new esParameters();
			parms.Add("PriceMasterID", priceMasterID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to PriceMaster.PriceMasterID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PriceMasterID
		{
			get
			{
				return base.GetSystemInt32(PriceMasterMetadata.ColumnNames.PriceMasterID);
			}
			
			set
			{
				if(base.SetSystemInt32(PriceMasterMetadata.ColumnNames.PriceMasterID, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.PriceMasterID);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.CustID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.CustID, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.CustID);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(PriceMasterMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.lbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lbcs
		{
			get
			{
				return base.GetSystemDouble(PriceMasterMetadata.ColumnNames.Lbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterMetadata.ColumnNames.Lbcs, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.Lbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.lbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lbpc
		{
			get
			{
				return base.GetSystemDouble(PriceMasterMetadata.ColumnNames.Lbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterMetadata.ColumnNames.Lbpc, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.Lbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.CaseSourceCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? CaseSourceCode
		{
			get
			{
				return base.GetSystemChar(PriceMasterMetadata.ColumnNames.CaseSourceCode);
			}
			
			set
			{
				if(base.SetSystemChar(PriceMasterMetadata.ColumnNames.CaseSourceCode, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.CaseSourceCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMaster.PieceSourceCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? PieceSourceCode
		{
			get
			{
				return base.GetSystemChar(PriceMasterMetadata.ColumnNames.PieceSourceCode);
			}
			
			set
			{
				if(base.SetSystemChar(PriceMasterMetadata.ColumnNames.PieceSourceCode, value))
				{
					OnPropertyChanged(PriceMasterMetadata.PropertyNames.PieceSourceCode);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public PriceMasterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(PriceMasterQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(PriceMasterQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((PriceMasterQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private PriceMasterQuery query;		
	}



	[Serializable]
	abstract public partial class esPriceMasterCollection : esEntityCollection<PriceMasterBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "PriceMasterCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public PriceMasterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(PriceMasterQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new PriceMasterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(PriceMasterQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((PriceMasterQuery)query);
		}

		#endregion
		
		private PriceMasterQuery query;
	}



	[Serializable]
	abstract public partial class esPriceMasterQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "PriceMasterID": return this.PriceMasterID;
				case "CustID": return this.CustID;
				case "Productcode": return this.Productcode;
				case "Lbcs": return this.Lbcs;
				case "Lbpc": return this.Lbpc;
				case "CaseSourceCode": return this.CaseSourceCode;
				case "PieceSourceCode": return this.PieceSourceCode;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem PriceMasterID
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.PriceMasterID, esSystemType.Int32); }
		} 
		
		public esQueryItem CustID
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.CustID, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Lbcs
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Lbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Lbpc
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.Lbpc, esSystemType.Double); }
		} 
		
		public esQueryItem CaseSourceCode
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.CaseSourceCode, esSystemType.Char); }
		} 
		
		public esQueryItem PieceSourceCode
		{
			get { return new esQueryItem(this, PriceMasterMetadata.ColumnNames.PieceSourceCode, esSystemType.Char); }
		} 
		
		#endregion
		
	}


	
	public partial class PriceMasterBO : esPriceMasterBO
	{

		
		
	}
	



	[Serializable]
	public partial class PriceMasterMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected PriceMasterMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.PriceMasterID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = PriceMasterMetadata.PropertyNames.PriceMasterID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Lbcs, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.Lbpc, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.CaseSourceCode, 5, typeof(System.Char), esSystemType.Char);
			c.PropertyName = PriceMasterMetadata.PropertyNames.CaseSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterMetadata.ColumnNames.PieceSourceCode, 6, typeof(System.Char), esSystemType.Char);
			c.PropertyName = PriceMasterMetadata.PropertyNames.PieceSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public PriceMasterMetadata Meta()
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
			 public const string PriceMasterID = "PriceMasterID";
			 public const string CustID = "CustID";
			 public const string Productcode = "productcode";
			 public const string Lbcs = "lbcs";
			 public const string Lbpc = "lbpc";
			 public const string CaseSourceCode = "CaseSourceCode";
			 public const string PieceSourceCode = "PieceSourceCode";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string PriceMasterID = "PriceMasterID";
			 public const string CustID = "CustID";
			 public const string Productcode = "Productcode";
			 public const string Lbcs = "Lbcs";
			 public const string Lbpc = "Lbpc";
			 public const string CaseSourceCode = "CaseSourceCode";
			 public const string PieceSourceCode = "PieceSourceCode";
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
			lock (typeof(PriceMasterMetadata))
			{
				if(PriceMasterMetadata.mapDelegates == null)
				{
					PriceMasterMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (PriceMasterMetadata.meta == null)
				{
					PriceMasterMetadata.meta = new PriceMasterMetadata();
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


				meta.AddTypeMap("PriceMasterID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CustID", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("CaseSourceCode", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("PieceSourceCode", new esTypeMap("nvarchar", "System.Char"));			
				
				
				
				meta.Source = "PriceMaster";
				meta.Destination = "PriceMaster";
				
				meta.spInsert = "proc_PriceMasterInsert";				
				meta.spUpdate = "proc_PriceMasterUpdate";		
				meta.spDelete = "proc_PriceMasterDelete";
				meta.spLoadAll = "proc_PriceMasterLoadAll";
				meta.spLoadByPrimaryKey = "proc_PriceMasterLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private PriceMasterMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
