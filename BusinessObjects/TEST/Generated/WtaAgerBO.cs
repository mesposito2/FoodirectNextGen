
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:16 PM
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
	/// Encapsulates the 'wta_ager' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaAgerBO))]	
	[XmlType("WtaAgerBO")]
	public partial class WtaAgerBO : esWtaAgerBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaAgerBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaAgerCollection")]
	public partial class WtaAgerCollection : esWtaAgerCollection, IEnumerable<WtaAgerBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaAgerQuery : esWtaAgerQuery
	{
		public WtaAgerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaAgerQuery(string joinAlias, out WtaAgerQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaAgerQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaAgerQuery query)
		{
			return WtaAgerQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaAgerQuery(string query)
		{
			return (WtaAgerQuery)WtaAgerQuery.SerializeHelper.FromXml(query, typeof(WtaAgerQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaAgerBO : esEntity
	{
		public esWtaAgerBO()
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
			WtaAgerQuery query = new WtaAgerQuery();
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
		/// Maps to wta_ager.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaAgerMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaAgerMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(WtaAgerMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(WtaAgerMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.ager1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ager1
		{
			get
			{
				return base.GetSystemDouble(WtaAgerMetadata.ColumnNames.Ager1);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaAgerMetadata.ColumnNames.Ager1, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Ager1);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.ager2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ager2
		{
			get
			{
				return base.GetSystemDouble(WtaAgerMetadata.ColumnNames.Ager2);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaAgerMetadata.ColumnNames.Ager2, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Ager2);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.ager3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ager3
		{
			get
			{
				return base.GetSystemDouble(WtaAgerMetadata.ColumnNames.Ager3);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaAgerMetadata.ColumnNames.Ager3, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Ager3);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.ager4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Ager4
		{
			get
			{
				return base.GetSystemDouble(WtaAgerMetadata.ColumnNames.Ager4);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaAgerMetadata.ColumnNames.Ager4, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Ager4);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.total
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Total
		{
			get
			{
				return base.GetSystemDouble(WtaAgerMetadata.ColumnNames.Total);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaAgerMetadata.ColumnNames.Total, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Total);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ager.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaAgerMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaAgerMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaAgerMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaAgerMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaAgerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaAgerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaAgerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaAgerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaAgerQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaAgerQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaAgerCollection : esEntityCollection<WtaAgerBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaAgerMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaAgerCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaAgerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaAgerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaAgerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaAgerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaAgerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaAgerQuery)query);
		}

		#endregion
		
		private WtaAgerQuery query;
	}



	[Serializable]
	abstract public partial class esWtaAgerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaAgerMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Custid": return this.Custid;
				case "Ager1": return this.Ager1;
				case "Ager2": return this.Ager2;
				case "Ager3": return this.Ager3;
				case "Ager4": return this.Ager4;
				case "Total": return this.Total;
				case "Lastupdate": return this.Lastupdate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Ager1
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Ager1, esSystemType.Double); }
		} 
		
		public esQueryItem Ager2
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Ager2, esSystemType.Double); }
		} 
		
		public esQueryItem Ager3
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Ager3, esSystemType.Double); }
		} 
		
		public esQueryItem Ager4
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Ager4, esSystemType.Double); }
		} 
		
		public esQueryItem Total
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Total, esSystemType.Double); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaAgerMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaAgerBO : esWtaAgerBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaAgerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaAgerMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Ager1, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Ager1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Ager2, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Ager2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Ager3, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Ager3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Ager4, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Ager4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Total, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Total;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaAgerMetadata.ColumnNames.Lastupdate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaAgerMetadata.PropertyNames.Lastupdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaAgerMetadata Meta()
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
			 public const string Ager1 = "ager1";
			 public const string Ager2 = "ager2";
			 public const string Ager3 = "ager3";
			 public const string Ager4 = "ager4";
			 public const string Total = "total";
			 public const string Lastupdate = "lastupdate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Ager1 = "Ager1";
			 public const string Ager2 = "Ager2";
			 public const string Ager3 = "Ager3";
			 public const string Ager4 = "Ager4";
			 public const string Total = "Total";
			 public const string Lastupdate = "Lastupdate";
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
			lock (typeof(WtaAgerMetadata))
			{
				if(WtaAgerMetadata.mapDelegates == null)
				{
					WtaAgerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaAgerMetadata.meta == null)
				{
					WtaAgerMetadata.meta = new WtaAgerMetadata();
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
				meta.AddTypeMap("Ager1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ager2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ager3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Ager4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Total", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "wta_ager";
				meta.Destination = "wta_ager";
				
				meta.spInsert = "proc_wta_agerInsert";				
				meta.spUpdate = "proc_wta_agerUpdate";		
				meta.spDelete = "proc_wta_agerDelete";
				meta.spLoadAll = "proc_wta_agerLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_agerLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaAgerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
