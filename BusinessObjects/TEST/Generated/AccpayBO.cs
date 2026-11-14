
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
	/// Encapsulates the 'accpay' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(AccpayBO))]	
	[XmlType("AccpayBO")]
	public partial class AccpayBO : esAccpayBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new AccpayBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("AccpayCollection")]
	public partial class AccpayCollection : esAccpayCollection, IEnumerable<AccpayBO>
	{

		
				
	}



	[Serializable]	
	public partial class AccpayQuery : esAccpayQuery
	{
		public AccpayQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public AccpayQuery(string joinAlias, out AccpayQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "AccpayQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(AccpayQuery query)
		{
			return AccpayQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator AccpayQuery(string query)
		{
			return (AccpayQuery)AccpayQuery.SerializeHelper.FromXml(query, typeof(AccpayQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esAccpayBO : esEntity
	{
		public esAccpayBO()
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
			AccpayQuery query = new AccpayQuery();
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
		/// Maps to accpay.aid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Aid
		{
			get
			{
				return base.GetSystemInt32(AccpayMetadata.ColumnNames.Aid);
			}
			
			set
			{
				if(base.SetSystemInt32(AccpayMetadata.ColumnNames.Aid, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Aid);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.cdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Cdate
		{
			get
			{
				return base.GetSystemDateTime(AccpayMetadata.ColumnNames.Cdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(AccpayMetadata.ColumnNames.Cdate, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Cdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(AccpayMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(AccpayMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(AccpayMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(AccpayMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.jnumber
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jnumber
		{
			get
			{
				return base.GetSystemString(AccpayMetadata.ColumnNames.Jnumber);
			}
			
			set
			{
				if(base.SetSystemString(AccpayMetadata.ColumnNames.Jnumber, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Jnumber);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.week
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Week
		{
			get
			{
				return base.GetSystemDateTime(AccpayMetadata.ColumnNames.Week);
			}
			
			set
			{
				if(base.SetSystemDateTime(AccpayMetadata.ColumnNames.Week, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Week);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.debit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Debit
		{
			get
			{
				return base.GetSystemDouble(AccpayMetadata.ColumnNames.Debit);
			}
			
			set
			{
				if(base.SetSystemDouble(AccpayMetadata.ColumnNames.Debit, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Debit);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.credit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Credit
		{
			get
			{
				return base.GetSystemDouble(AccpayMetadata.ColumnNames.Credit);
			}
			
			set
			{
				if(base.SetSystemDouble(AccpayMetadata.ColumnNames.Credit, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Credit);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Comment
		{
			get
			{
				return base.GetSystemString(AccpayMetadata.ColumnNames.Comment);
			}
			
			set
			{
				if(base.SetSystemString(AccpayMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Comment);
				}
			}
		}
		
		/// <summary>
		/// Maps to accpay.flags
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Flags
		{
			get
			{
				return base.GetSystemInt32(AccpayMetadata.ColumnNames.Flags);
			}
			
			set
			{
				if(base.SetSystemInt32(AccpayMetadata.ColumnNames.Flags, value))
				{
					OnPropertyChanged(AccpayMetadata.PropertyNames.Flags);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return AccpayMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public AccpayQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AccpayQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AccpayQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(AccpayQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AccpayQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private AccpayQuery query;		
	}



	[Serializable]
	abstract public partial class esAccpayCollection : esEntityCollection<AccpayBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return AccpayMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "AccpayCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public AccpayQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new AccpayQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(AccpayQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new AccpayQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(AccpayQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((AccpayQuery)query);
		}

		#endregion
		
		private AccpayQuery query;
	}



	[Serializable]
	abstract public partial class esAccpayQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return AccpayMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Aid": return this.Aid;
				case "Cdate": return this.Cdate;
				case "Jobberid": return this.Jobberid;
				case "Custid": return this.Custid;
				case "Jnumber": return this.Jnumber;
				case "Week": return this.Week;
				case "Debit": return this.Debit;
				case "Credit": return this.Credit;
				case "Comment": return this.Comment;
				case "Flags": return this.Flags;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Aid
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Aid, esSystemType.Int32); }
		} 
		
		public esQueryItem Cdate
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Cdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Jnumber
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Jnumber, esSystemType.String); }
		} 
		
		public esQueryItem Week
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Week, esSystemType.DateTime); }
		} 
		
		public esQueryItem Debit
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Debit, esSystemType.Double); }
		} 
		
		public esQueryItem Credit
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Credit, esSystemType.Double); }
		} 
		
		public esQueryItem Comment
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Comment, esSystemType.String); }
		} 
		
		public esQueryItem Flags
		{
			get { return new esQueryItem(this, AccpayMetadata.ColumnNames.Flags, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class AccpayBO : esAccpayBO
	{

		
		
	}
	



	[Serializable]
	public partial class AccpayMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected AccpayMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Aid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AccpayMetadata.PropertyNames.Aid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Cdate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AccpayMetadata.PropertyNames.Cdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Jobberid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = AccpayMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Custid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = AccpayMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Jnumber, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = AccpayMetadata.PropertyNames.Jnumber;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Week, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = AccpayMetadata.PropertyNames.Week;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Debit, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AccpayMetadata.PropertyNames.Debit;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Credit, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = AccpayMetadata.PropertyNames.Credit;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Comment, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = AccpayMetadata.PropertyNames.Comment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(AccpayMetadata.ColumnNames.Flags, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = AccpayMetadata.PropertyNames.Flags;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public AccpayMetadata Meta()
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
			 public const string Aid = "aid";
			 public const string Cdate = "cdate";
			 public const string Jobberid = "jobberid";
			 public const string Custid = "custid";
			 public const string Jnumber = "jnumber";
			 public const string Week = "week";
			 public const string Debit = "debit";
			 public const string Credit = "credit";
			 public const string Comment = "comment";
			 public const string Flags = "flags";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Aid = "Aid";
			 public const string Cdate = "Cdate";
			 public const string Jobberid = "Jobberid";
			 public const string Custid = "Custid";
			 public const string Jnumber = "Jnumber";
			 public const string Week = "Week";
			 public const string Debit = "Debit";
			 public const string Credit = "Credit";
			 public const string Comment = "Comment";
			 public const string Flags = "Flags";
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
			lock (typeof(AccpayMetadata))
			{
				if(AccpayMetadata.mapDelegates == null)
				{
					AccpayMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (AccpayMetadata.meta == null)
				{
					AccpayMetadata.meta = new AccpayMetadata();
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


				meta.AddTypeMap("Aid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Cdate", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Jobberid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Jnumber", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Week", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Debit", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Credit", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Comment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Flags", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "accpay";
				meta.Destination = "accpay";
				
				meta.spInsert = "proc_accpayInsert";				
				meta.spUpdate = "proc_accpayUpdate";		
				meta.spDelete = "proc_accpayDelete";
				meta.spLoadAll = "proc_accpayLoadAll";
				meta.spLoadByPrimaryKey = "proc_accpayLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private AccpayMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
