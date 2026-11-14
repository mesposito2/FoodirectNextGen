
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
	/// Encapsulates the 'saleadj' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SaleadjBO))]	
	[XmlType("SaleadjBO")]
	public partial class SaleadjBO : esSaleadjBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SaleadjBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SaleadjCollection")]
	public partial class SaleadjCollection : esSaleadjCollection, IEnumerable<SaleadjBO>
	{

		
				
	}



	[Serializable]	
	public partial class SaleadjQuery : esSaleadjQuery
	{
		public SaleadjQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SaleadjQuery(string joinAlias, out SaleadjQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SaleadjQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SaleadjQuery query)
		{
			return SaleadjQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SaleadjQuery(string query)
		{
			return (SaleadjQuery)SaleadjQuery.SerializeHelper.FromXml(query, typeof(SaleadjQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSaleadjBO : esEntity
	{
		public esSaleadjBO()
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
			SaleadjQuery query = new SaleadjQuery();
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
		/// Maps to saleadj.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(SaleadjMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(SaleadjMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(SaleadjMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SaleadjMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SaleadjMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SaleadjMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj.a
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A
		{
			get
			{
				return base.GetSystemDouble(SaleadjMetadata.ColumnNames.A);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjMetadata.ColumnNames.A, value))
				{
					OnPropertyChanged(SaleadjMetadata.PropertyNames.A);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj.b
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B
		{
			get
			{
				return base.GetSystemDouble(SaleadjMetadata.ColumnNames.B);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjMetadata.ColumnNames.B, value))
				{
					OnPropertyChanged(SaleadjMetadata.PropertyNames.B);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj.c
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C
		{
			get
			{
				return base.GetSystemDouble(SaleadjMetadata.ColumnNames.C);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjMetadata.ColumnNames.C, value))
				{
					OnPropertyChanged(SaleadjMetadata.PropertyNames.C);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SaleadjMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SaleadjQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaleadjQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaleadjQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SaleadjQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SaleadjQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SaleadjQuery query;		
	}



	[Serializable]
	abstract public partial class esSaleadjCollection : esEntityCollection<SaleadjBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SaleadjMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SaleadjCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SaleadjQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaleadjQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaleadjQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SaleadjQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SaleadjQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SaleadjQuery)query);
		}

		#endregion
		
		private SaleadjQuery query;
	}



	[Serializable]
	abstract public partial class esSaleadjQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SaleadjMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Jobberid": return this.Jobberid;
				case "Productcode": return this.Productcode;
				case "A": return this.A;
				case "B": return this.B;
				case "C": return this.C;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, SaleadjMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SaleadjMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem A
		{
			get { return new esQueryItem(this, SaleadjMetadata.ColumnNames.A, esSystemType.Double); }
		} 
		
		public esQueryItem B
		{
			get { return new esQueryItem(this, SaleadjMetadata.ColumnNames.B, esSystemType.Double); }
		} 
		
		public esQueryItem C
		{
			get { return new esQueryItem(this, SaleadjMetadata.ColumnNames.C, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class SaleadjBO : esSaleadjBO
	{

		
		
	}
	



	[Serializable]
	public partial class SaleadjMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SaleadjMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SaleadjMetadata.ColumnNames.Jobberid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SaleadjMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SaleadjMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjMetadata.ColumnNames.A, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjMetadata.PropertyNames.A;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjMetadata.ColumnNames.B, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjMetadata.PropertyNames.B;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjMetadata.ColumnNames.C, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjMetadata.PropertyNames.C;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SaleadjMetadata Meta()
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
			 public const string Jobberid = "jobberid";
			 public const string Productcode = "productcode";
			 public const string A = "a";
			 public const string B = "b";
			 public const string C = "c";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Jobberid = "Jobberid";
			 public const string Productcode = "Productcode";
			 public const string A = "A";
			 public const string B = "B";
			 public const string C = "C";
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
			lock (typeof(SaleadjMetadata))
			{
				if(SaleadjMetadata.mapDelegates == null)
				{
					SaleadjMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SaleadjMetadata.meta == null)
				{
					SaleadjMetadata.meta = new SaleadjMetadata();
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


				meta.AddTypeMap("Jobberid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("A", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "saleadj";
				meta.Destination = "saleadj";
				
				meta.spInsert = "proc_saleadjInsert";				
				meta.spUpdate = "proc_saleadjUpdate";		
				meta.spDelete = "proc_saleadjDelete";
				meta.spLoadAll = "proc_saleadjLoadAll";
				meta.spLoadByPrimaryKey = "proc_saleadjLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SaleadjMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
