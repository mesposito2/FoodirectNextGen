
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
	/// Encapsulates the 'accday' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(AccdayBO))]	
	[XmlType("AccdayBO")]
	public partial class AccdayBO : esAccdayBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AccdayBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("AccdayCollection")]
	public partial class AccdayCollection : esAccdayCollection, IEnumerable<AccdayBO>
	{

		
				
	}



	[Serializable]	
	public partial class AccdayQuery : esAccdayQuery
	{
		public AccdayQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public AccdayQuery(string joinAlias, out AccdayQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "AccdayQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AccdayQuery query)
		{
			return AccdayQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AccdayQuery(string query)
		{
			return (AccdayQuery)AccdayQuery.SerializeHelper.FromXml(query, typeof(AccdayQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAccdayBO : esEntity
	{
		public esAccdayBO()
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
			AccdayQuery query = new AccdayQuery();
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
		/// Maps to accday.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(AccdayMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(AccdayMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(AccdayMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to accday.thisday
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Thisday
		{
			get
			{
				return base.GetSystemDateTime(AccdayMetadata.ColumnNames.Thisday);
			}
			
			set
			{
				if(base.SetSystemDateTime(AccdayMetadata.ColumnNames.Thisday, value))
				{
					OnPropertyChanged(AccdayMetadata.PropertyNames.Thisday);
				}
			}
		}
		
		/// <summary>
		/// Maps to accday.bill
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Bill
		{
			get
			{
				return base.GetSystemDouble(AccdayMetadata.ColumnNames.Bill);
			}
			
			set
			{
				if(base.SetSystemDouble(AccdayMetadata.ColumnNames.Bill, value))
				{
					OnPropertyChanged(AccdayMetadata.PropertyNames.Bill);
				}
			}
		}
		
		/// <summary>
		/// Maps to accday.pay
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Pay
		{
			get
			{
				return base.GetSystemDouble(AccdayMetadata.ColumnNames.Pay);
			}
			
			set
			{
				if(base.SetSystemDouble(AccdayMetadata.ColumnNames.Pay, value))
				{
					OnPropertyChanged(AccdayMetadata.PropertyNames.Pay);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AccdayMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AccdayQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AccdayQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AccdayQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(AccdayQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AccdayQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private AccdayQuery query;		
	}



	[Serializable]
	abstract public partial class esAccdayCollection : esEntityCollection<AccdayBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AccdayMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AccdayCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AccdayQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AccdayQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AccdayQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AccdayQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AccdayQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AccdayQuery)query);
		}

		#endregion
		
		private AccdayQuery query;
	}



	[Serializable]
	abstract public partial class esAccdayQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AccdayMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Jobberid": return this.Jobberid;
				case "Thisday": return this.Thisday;
				case "Bill": return this.Bill;
				case "Pay": return this.Pay;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, AccdayMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Thisday
		{
			get { return new esQueryItem(this, AccdayMetadata.ColumnNames.Thisday, esSystemType.DateTime); }
		} 
		
		public esQueryItem Bill
		{
			get { return new esQueryItem(this, AccdayMetadata.ColumnNames.Bill, esSystemType.Double); }
		} 
		
		public esQueryItem Pay
		{
			get { return new esQueryItem(this, AccdayMetadata.ColumnNames.Pay, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class AccdayBO : esAccdayBO
	{

		
		
	}
	



	[Serializable]
	public partial class AccdayMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AccdayMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AccdayMetadata.ColumnNames.Jobberid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = AccdayMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccdayMetadata.ColumnNames.Thisday, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AccdayMetadata.PropertyNames.Thisday;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccdayMetadata.ColumnNames.Bill, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AccdayMetadata.PropertyNames.Bill;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccdayMetadata.ColumnNames.Pay, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AccdayMetadata.PropertyNames.Pay;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AccdayMetadata Meta()
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
			 public const string Thisday = "thisday";
			 public const string Bill = "bill";
			 public const string Pay = "pay";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Jobberid = "Jobberid";
			 public const string Thisday = "Thisday";
			 public const string Bill = "Bill";
			 public const string Pay = "Pay";
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
			lock (typeof(AccdayMetadata))
			{
				if(AccdayMetadata.mapDelegates == null)
				{
					AccdayMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AccdayMetadata.meta == null)
				{
					AccdayMetadata.meta = new AccdayMetadata();
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
				meta.AddTypeMap("Thisday", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Bill", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pay", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "accday";
				meta.Destination = "accday";
				
				meta.spInsert = "proc_accdayInsert";				
				meta.spUpdate = "proc_accdayUpdate";		
				meta.spDelete = "proc_accdayDelete";
				meta.spLoadAll = "proc_accdayLoadAll";
				meta.spLoadByPrimaryKey = "proc_accdayLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AccdayMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
