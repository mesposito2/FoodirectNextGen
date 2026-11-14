
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
	/// Encapsulates the 'saleadj_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SaleadjRollBO))]	
	[XmlType("SaleadjRollBO")]
	public partial class SaleadjRollBO : esSaleadjRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SaleadjRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SaleadjRollCollection")]
	public partial class SaleadjRollCollection : esSaleadjRollCollection, IEnumerable<SaleadjRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class SaleadjRollQuery : esSaleadjRollQuery
	{
		public SaleadjRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SaleadjRollQuery(string joinAlias, out SaleadjRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SaleadjRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SaleadjRollQuery query)
		{
			return SaleadjRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SaleadjRollQuery(string query)
		{
			return (SaleadjRollQuery)SaleadjRollQuery.SerializeHelper.FromXml(query, typeof(SaleadjRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSaleadjRollBO : esEntity
	{
		public esSaleadjRollBO()
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
			SaleadjRollQuery query = new SaleadjRollQuery();
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
		/// Maps to saleadj_roll.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(SaleadjRollMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(SaleadjRollMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(SaleadjRollMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj_roll.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SaleadjRollMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SaleadjRollMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SaleadjRollMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj_roll.a
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A
		{
			get
			{
				return base.GetSystemDouble(SaleadjRollMetadata.ColumnNames.A);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjRollMetadata.ColumnNames.A, value))
				{
					OnPropertyChanged(SaleadjRollMetadata.PropertyNames.A);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj_roll.b
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B
		{
			get
			{
				return base.GetSystemDouble(SaleadjRollMetadata.ColumnNames.B);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjRollMetadata.ColumnNames.B, value))
				{
					OnPropertyChanged(SaleadjRollMetadata.PropertyNames.B);
				}
			}
		}
		
		/// <summary>
		/// Maps to saleadj_roll.c
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C
		{
			get
			{
				return base.GetSystemDouble(SaleadjRollMetadata.ColumnNames.C);
			}
			
			set
			{
				if(base.SetSystemDouble(SaleadjRollMetadata.ColumnNames.C, value))
				{
					OnPropertyChanged(SaleadjRollMetadata.PropertyNames.C);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SaleadjRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SaleadjRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaleadjRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaleadjRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SaleadjRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SaleadjRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SaleadjRollQuery query;		
	}



	[Serializable]
	abstract public partial class esSaleadjRollCollection : esEntityCollection<SaleadjRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SaleadjRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SaleadjRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SaleadjRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SaleadjRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SaleadjRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SaleadjRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SaleadjRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SaleadjRollQuery)query);
		}

		#endregion
		
		private SaleadjRollQuery query;
	}



	[Serializable]
	abstract public partial class esSaleadjRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SaleadjRollMetadata.Meta();
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
			get { return new esQueryItem(this, SaleadjRollMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SaleadjRollMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem A
		{
			get { return new esQueryItem(this, SaleadjRollMetadata.ColumnNames.A, esSystemType.Double); }
		} 
		
		public esQueryItem B
		{
			get { return new esQueryItem(this, SaleadjRollMetadata.ColumnNames.B, esSystemType.Double); }
		} 
		
		public esQueryItem C
		{
			get { return new esQueryItem(this, SaleadjRollMetadata.ColumnNames.C, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class SaleadjRollBO : esSaleadjRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class SaleadjRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SaleadjRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SaleadjRollMetadata.ColumnNames.Jobberid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SaleadjRollMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjRollMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SaleadjRollMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjRollMetadata.ColumnNames.A, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjRollMetadata.PropertyNames.A;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjRollMetadata.ColumnNames.B, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjRollMetadata.PropertyNames.B;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SaleadjRollMetadata.ColumnNames.C, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SaleadjRollMetadata.PropertyNames.C;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SaleadjRollMetadata Meta()
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
			lock (typeof(SaleadjRollMetadata))
			{
				if(SaleadjRollMetadata.mapDelegates == null)
				{
					SaleadjRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SaleadjRollMetadata.meta == null)
				{
					SaleadjRollMetadata.meta = new SaleadjRollMetadata();
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
				
				
				
				meta.Source = "saleadj_roll";
				meta.Destination = "saleadj_roll";
				
				meta.spInsert = "proc_saleadj_rollInsert";				
				meta.spUpdate = "proc_saleadj_rollUpdate";		
				meta.spDelete = "proc_saleadj_rollDelete";
				meta.spLoadAll = "proc_saleadj_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_saleadj_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SaleadjRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
