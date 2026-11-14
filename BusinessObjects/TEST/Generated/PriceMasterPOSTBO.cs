
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
	/// Encapsulates the 'PriceMasterPOST' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(PriceMasterPOSTBO))]	
	[XmlType("PriceMasterPOSTBO")]
	public partial class PriceMasterPOSTBO : esPriceMasterPOSTBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new PriceMasterPOSTBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("PriceMasterPOSTCollection")]
	public partial class PriceMasterPOSTCollection : esPriceMasterPOSTCollection, IEnumerable<PriceMasterPOSTBO>
	{

		
				
	}



	[Serializable]	
	public partial class PriceMasterPOSTQuery : esPriceMasterPOSTQuery
	{
		public PriceMasterPOSTQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public PriceMasterPOSTQuery(string joinAlias, out PriceMasterPOSTQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "PriceMasterPOSTQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(PriceMasterPOSTQuery query)
		{
			return PriceMasterPOSTQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator PriceMasterPOSTQuery(string query)
		{
			return (PriceMasterPOSTQuery)PriceMasterPOSTQuery.SerializeHelper.FromXml(query, typeof(PriceMasterPOSTQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esPriceMasterPOSTBO : esEntity
	{
		public esPriceMasterPOSTBO()
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
			PriceMasterPOSTQuery query = new PriceMasterPOSTQuery();
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
		/// Maps to PriceMasterPOST.PriceMasterID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PriceMasterID
		{
			get
			{
				return base.GetSystemInt32(PriceMasterPOSTMetadata.ColumnNames.PriceMasterID);
			}
			
			set
			{
				if(base.SetSystemInt32(PriceMasterPOSTMetadata.ColumnNames.PriceMasterID, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.PriceMasterID);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.CustID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustID
		{
			get
			{
				return base.GetSystemString(PriceMasterPOSTMetadata.ColumnNames.CustID);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterPOSTMetadata.ColumnNames.CustID, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.CustID);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(PriceMasterPOSTMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(PriceMasterPOSTMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.lbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lbcs
		{
			get
			{
				return base.GetSystemDouble(PriceMasterPOSTMetadata.ColumnNames.Lbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterPOSTMetadata.ColumnNames.Lbcs, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.Lbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.lbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lbpc
		{
			get
			{
				return base.GetSystemDouble(PriceMasterPOSTMetadata.ColumnNames.Lbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(PriceMasterPOSTMetadata.ColumnNames.Lbpc, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.Lbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.CaseSourceCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? CaseSourceCode
		{
			get
			{
				return base.GetSystemChar(PriceMasterPOSTMetadata.ColumnNames.CaseSourceCode);
			}
			
			set
			{
				if(base.SetSystemChar(PriceMasterPOSTMetadata.ColumnNames.CaseSourceCode, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.CaseSourceCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to PriceMasterPOST.PieceSourceCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? PieceSourceCode
		{
			get
			{
				return base.GetSystemChar(PriceMasterPOSTMetadata.ColumnNames.PieceSourceCode);
			}
			
			set
			{
				if(base.SetSystemChar(PriceMasterPOSTMetadata.ColumnNames.PieceSourceCode, value))
				{
					OnPropertyChanged(PriceMasterPOSTMetadata.PropertyNames.PieceSourceCode);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterPOSTMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public PriceMasterPOSTQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterPOSTQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(PriceMasterPOSTQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(PriceMasterPOSTQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((PriceMasterPOSTQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private PriceMasterPOSTQuery query;		
	}



	[Serializable]
	abstract public partial class esPriceMasterPOSTCollection : esEntityCollection<PriceMasterPOSTBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterPOSTMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "PriceMasterPOSTCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public PriceMasterPOSTQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new PriceMasterPOSTQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(PriceMasterPOSTQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new PriceMasterPOSTQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(PriceMasterPOSTQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((PriceMasterPOSTQuery)query);
		}

		#endregion
		
		private PriceMasterPOSTQuery query;
	}



	[Serializable]
	abstract public partial class esPriceMasterPOSTQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return PriceMasterPOSTMetadata.Meta();
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
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.PriceMasterID, esSystemType.Int32); }
		} 
		
		public esQueryItem CustID
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.CustID, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Lbcs
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.Lbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Lbpc
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.Lbpc, esSystemType.Double); }
		} 
		
		public esQueryItem CaseSourceCode
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.CaseSourceCode, esSystemType.Char); }
		} 
		
		public esQueryItem PieceSourceCode
		{
			get { return new esQueryItem(this, PriceMasterPOSTMetadata.ColumnNames.PieceSourceCode, esSystemType.Char); }
		} 
		
		#endregion
		
	}


	
	public partial class PriceMasterPOSTBO : esPriceMasterPOSTBO
	{

		
		
	}
	



	[Serializable]
	public partial class PriceMasterPOSTMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected PriceMasterPOSTMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.PriceMasterID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.PriceMasterID;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.CustID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.CustID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.Lbcs, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.Lbpc, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.CaseSourceCode, 5, typeof(System.Char), esSystemType.Char);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.CaseSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(PriceMasterPOSTMetadata.ColumnNames.PieceSourceCode, 6, typeof(System.Char), esSystemType.Char);
			c.PropertyName = PriceMasterPOSTMetadata.PropertyNames.PieceSourceCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public PriceMasterPOSTMetadata Meta()
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
			lock (typeof(PriceMasterPOSTMetadata))
			{
				if(PriceMasterPOSTMetadata.mapDelegates == null)
				{
					PriceMasterPOSTMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (PriceMasterPOSTMetadata.meta == null)
				{
					PriceMasterPOSTMetadata.meta = new PriceMasterPOSTMetadata();
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
				
				
				
				meta.Source = "PriceMasterPOST";
				meta.Destination = "PriceMasterPOST";
				
				meta.spInsert = "proc_PriceMasterPOSTInsert";				
				meta.spUpdate = "proc_PriceMasterPOSTUpdate";		
				meta.spDelete = "proc_PriceMasterPOSTDelete";
				meta.spLoadAll = "proc_PriceMasterPOSTLoadAll";
				meta.spLoadByPrimaryKey = "proc_PriceMasterPOSTLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private PriceMasterPOSTMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
