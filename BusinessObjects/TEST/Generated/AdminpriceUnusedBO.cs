
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:12 PM
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
	/// Encapsulates the 'adminprice_unused' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(AdminpriceUnusedBO))]	
	[XmlType("AdminpriceUnusedBO")]
	public partial class AdminpriceUnusedBO : esAdminpriceUnusedBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AdminpriceUnusedBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("AdminpriceUnusedCollection")]
	public partial class AdminpriceUnusedCollection : esAdminpriceUnusedCollection, IEnumerable<AdminpriceUnusedBO>
	{

		
				
	}



	[Serializable]	
	public partial class AdminpriceUnusedQuery : esAdminpriceUnusedQuery
	{
		public AdminpriceUnusedQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public AdminpriceUnusedQuery(string joinAlias, out AdminpriceUnusedQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "AdminpriceUnusedQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AdminpriceUnusedQuery query)
		{
			return AdminpriceUnusedQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AdminpriceUnusedQuery(string query)
		{
			return (AdminpriceUnusedQuery)AdminpriceUnusedQuery.SerializeHelper.FromXml(query, typeof(AdminpriceUnusedQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAdminpriceUnusedBO : esEntity
	{
		public esAdminpriceUnusedBO()
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
			AdminpriceUnusedQuery query = new AdminpriceUnusedQuery();
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
		/// Maps to adminprice_unused.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(AdminpriceUnusedMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(AdminpriceUnusedMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Type
		{
			get
			{
				return base.GetSystemChar(AdminpriceUnusedMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemChar(AdminpriceUnusedMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.icode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Icode
		{
			get
			{
				return base.GetSystemString(AdminpriceUnusedMetadata.ColumnNames.Icode);
			}
			
			set
			{
				if(base.SetSystemString(AdminpriceUnusedMetadata.ColumnNames.Icode, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Icode);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.dcase
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dcase
		{
			get
			{
				return base.GetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Dcase);
			}
			
			set
			{
				if(base.SetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Dcase, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Dcase);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.pcase
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pcase
		{
			get
			{
				return base.GetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Pcase);
			}
			
			set
			{
				if(base.SetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Pcase, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Pcase);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.dpiece
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Dpiece
		{
			get
			{
				return base.GetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Dpiece);
			}
			
			set
			{
				if(base.SetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Dpiece, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Dpiece);
				}
			}
		}
		
		/// <summary>
		/// Maps to adminprice_unused.ppiece
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ppiece
		{
			get
			{
				return base.GetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Ppiece);
			}
			
			set
			{
				if(base.SetSystemDouble(AdminpriceUnusedMetadata.ColumnNames.Ppiece, value))
				{
					OnPropertyChanged(AdminpriceUnusedMetadata.PropertyNames.Ppiece);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AdminpriceUnusedMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AdminpriceUnusedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdminpriceUnusedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AdminpriceUnusedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(AdminpriceUnusedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AdminpriceUnusedQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private AdminpriceUnusedQuery query;		
	}



	[Serializable]
	abstract public partial class esAdminpriceUnusedCollection : esEntityCollection<AdminpriceUnusedBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AdminpriceUnusedMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AdminpriceUnusedCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AdminpriceUnusedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AdminpriceUnusedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AdminpriceUnusedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AdminpriceUnusedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AdminpriceUnusedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AdminpriceUnusedQuery)query);
		}

		#endregion
		
		private AdminpriceUnusedQuery query;
	}



	[Serializable]
	abstract public partial class esAdminpriceUnusedQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AdminpriceUnusedMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Type": return this.Type;
				case "Icode": return this.Icode;
				case "Dcase": return this.Dcase;
				case "Pcase": return this.Pcase;
				case "Dpiece": return this.Dpiece;
				case "Ppiece": return this.Ppiece;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Type, esSystemType.Char); }
		} 
		
		public esQueryItem Icode
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Icode, esSystemType.String); }
		} 
		
		public esQueryItem Dcase
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Dcase, esSystemType.Double); }
		} 
		
		public esQueryItem Pcase
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Pcase, esSystemType.Double); }
		} 
		
		public esQueryItem Dpiece
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Dpiece, esSystemType.Double); }
		} 
		
		public esQueryItem Ppiece
		{
			get { return new esQueryItem(this, AdminpriceUnusedMetadata.ColumnNames.Ppiece, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class AdminpriceUnusedBO : esAdminpriceUnusedBO
	{

		
		
	}
	



	[Serializable]
	public partial class AdminpriceUnusedMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AdminpriceUnusedMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Type, 1, typeof(System.Char), esSystemType.Char);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Type;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Icode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Icode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Dcase, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Dcase;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Pcase, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Pcase;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Dpiece, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Dpiece;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AdminpriceUnusedMetadata.ColumnNames.Ppiece, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AdminpriceUnusedMetadata.PropertyNames.Ppiece;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AdminpriceUnusedMetadata Meta()
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
			 public const string Type = "type";
			 public const string Icode = "icode";
			 public const string Dcase = "dcase";
			 public const string Pcase = "pcase";
			 public const string Dpiece = "dpiece";
			 public const string Ppiece = "ppiece";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Type = "Type";
			 public const string Icode = "Icode";
			 public const string Dcase = "Dcase";
			 public const string Pcase = "Pcase";
			 public const string Dpiece = "Dpiece";
			 public const string Ppiece = "Ppiece";
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
			lock (typeof(AdminpriceUnusedMetadata))
			{
				if(AdminpriceUnusedMetadata.mapDelegates == null)
				{
					AdminpriceUnusedMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AdminpriceUnusedMetadata.meta == null)
				{
					AdminpriceUnusedMetadata.meta = new AdminpriceUnusedMetadata();
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
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("Icode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Dcase", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcase", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Dpiece", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ppiece", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "adminprice_unused";
				meta.Destination = "adminprice_unused";
				
				meta.spInsert = "proc_adminprice_unusedInsert";				
				meta.spUpdate = "proc_adminprice_unusedUpdate";		
				meta.spDelete = "proc_adminprice_unusedDelete";
				meta.spLoadAll = "proc_adminprice_unusedLoadAll";
				meta.spLoadByPrimaryKey = "proc_adminprice_unusedLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AdminpriceUnusedMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
