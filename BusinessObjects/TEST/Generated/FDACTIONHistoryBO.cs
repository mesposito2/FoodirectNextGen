
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
	/// Encapsulates the 'FDACTIONHistory' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(FDACTIONHistoryBO))]	
	[XmlType("FDACTIONHistoryBO")]
	public partial class FDACTIONHistoryBO : esFDACTIONHistoryBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new FDACTIONHistoryBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 fDActionHistoryID)
		{
			var obj = new FDACTIONHistoryBO();
			obj.FDActionHistoryID = fDActionHistoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 fDActionHistoryID, esSqlAccessType sqlAccessType)
		{
			var obj = new FDACTIONHistoryBO();
			obj.FDActionHistoryID = fDActionHistoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("FDACTIONHistoryCollection")]
	public partial class FDACTIONHistoryCollection : esFDACTIONHistoryCollection, IEnumerable<FDACTIONHistoryBO>
	{
		public FDACTIONHistoryBO FindByPrimaryKey(System.Int32 fDActionHistoryID)
		{
			return this.SingleOrDefault(e => e.FDActionHistoryID == fDActionHistoryID);
		}

		
				
	}



	[Serializable]	
	public partial class FDACTIONHistoryQuery : esFDACTIONHistoryQuery
	{
		public FDACTIONHistoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public FDACTIONHistoryQuery(string joinAlias, out FDACTIONHistoryQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "FDACTIONHistoryQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(FDACTIONHistoryQuery query)
		{
			return FDACTIONHistoryQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator FDACTIONHistoryQuery(string query)
		{
			return (FDACTIONHistoryQuery)FDACTIONHistoryQuery.SerializeHelper.FromXml(query, typeof(FDACTIONHistoryQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esFDACTIONHistoryBO : esEntity
	{
		public esFDACTIONHistoryBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 fDActionHistoryID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionHistoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionHistoryID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 fDActionHistoryID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionHistoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionHistoryID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 fDActionHistoryID)
		{
			FDACTIONHistoryQuery query = new FDACTIONHistoryQuery();
			query.Where(query.FDActionHistoryID == fDActionHistoryID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 fDActionHistoryID)
		{
			esParameters parms = new esParameters();
			parms.Add("FDActionHistoryID", fDActionHistoryID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to FDACTIONHistory.FDActionHistoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? FDActionHistoryID
		{
			get
			{
				return base.GetSystemInt32(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.FDActionHistoryID);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.token
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Token
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Token);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Token, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Token);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastlogfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastlogfile
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Lastlogfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastrun
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastrun
		{
			get
			{
				return base.GetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.Lastrun);
			}
			
			set
			{
				if(base.SetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.Lastrun, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Lastrun);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastresult
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Lastresult
		{
			get
			{
				return base.GetSystemDecimal(FDACTIONHistoryMetadata.ColumnNames.Lastresult);
			}
			
			set
			{
				if(base.SetSystemDecimal(FDACTIONHistoryMetadata.ColumnNames.Lastresult, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Lastresult);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastmsg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastmsg
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastmsg);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastmsg, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Lastmsg);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.msgfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Msgfile
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Msgfile);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Msgfile, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Msgfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(FDACTIONHistoryMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(FDACTIONHistoryMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.LastRunStart
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastRunStart
		{
			get
			{
				return base.GetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.LastRunStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.LastRunStart, value))
				{
					OnPropertyChanged(FDACTIONHistoryMetadata.PropertyNames.LastRunStart);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return FDACTIONHistoryMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public FDACTIONHistoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FDACTIONHistoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FDACTIONHistoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(FDACTIONHistoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FDACTIONHistoryQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private FDACTIONHistoryQuery query;		
	}



	[Serializable]
	abstract public partial class esFDACTIONHistoryCollection : esEntityCollection<FDACTIONHistoryBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FDACTIONHistoryMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "FDACTIONHistoryCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public FDACTIONHistoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FDACTIONHistoryQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FDACTIONHistoryQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FDACTIONHistoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(FDACTIONHistoryQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FDACTIONHistoryQuery)query);
		}

		#endregion
		
		private FDACTIONHistoryQuery query;
	}



	[Serializable]
	abstract public partial class esFDACTIONHistoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FDACTIONHistoryMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "FDActionHistoryID": return this.FDActionHistoryID;
				case "Token": return this.Token;
				case "Description": return this.Description;
				case "Lastlogfile": return this.Lastlogfile;
				case "Lastrun": return this.Lastrun;
				case "Lastresult": return this.Lastresult;
				case "Lastmsg": return this.Lastmsg;
				case "Msgfile": return this.Msgfile;
				case "Active": return this.Active;
				case "LastRunStart": return this.LastRunStart;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem FDActionHistoryID
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, esSystemType.Int32); }
		} 
		
		public esQueryItem Token
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Token, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Lastlogfile
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, esSystemType.String); }
		} 
		
		public esQueryItem Lastrun
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastrun, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastresult
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastresult, esSystemType.Decimal); }
		} 
		
		public esQueryItem Lastmsg
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastmsg, esSystemType.String); }
		} 
		
		public esQueryItem Msgfile
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Msgfile, esSystemType.String); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Active, esSystemType.Boolean); }
		} 
		
		public esQueryItem LastRunStart
		{
			get { return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.LastRunStart, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class FDACTIONHistoryBO : esFDACTIONHistoryBO
	{

		
		
	}
	



	[Serializable]
	public partial class FDACTIONHistoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FDACTIONHistoryMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.FDActionHistoryID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Token, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Token;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastlogfile;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastrun, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastrun;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastresult, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastresult;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastmsg, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastmsg;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Msgfile, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Msgfile;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.LastRunStart, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.LastRunStart;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public FDACTIONHistoryMetadata Meta()
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
			 public const string FDActionHistoryID = "FDActionHistoryID";
			 public const string Token = "token";
			 public const string Description = "description";
			 public const string Lastlogfile = "lastlogfile";
			 public const string Lastrun = "lastrun";
			 public const string Lastresult = "lastresult";
			 public const string Lastmsg = "lastmsg";
			 public const string Msgfile = "msgfile";
			 public const string Active = "active";
			 public const string LastRunStart = "LastRunStart";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string FDActionHistoryID = "FDActionHistoryID";
			 public const string Token = "Token";
			 public const string Description = "Description";
			 public const string Lastlogfile = "Lastlogfile";
			 public const string Lastrun = "Lastrun";
			 public const string Lastresult = "Lastresult";
			 public const string Lastmsg = "Lastmsg";
			 public const string Msgfile = "Msgfile";
			 public const string Active = "Active";
			 public const string LastRunStart = "LastRunStart";
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
			lock (typeof(FDACTIONHistoryMetadata))
			{
				if(FDACTIONHistoryMetadata.mapDelegates == null)
				{
					FDACTIONHistoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (FDACTIONHistoryMetadata.meta == null)
				{
					FDACTIONHistoryMetadata.meta = new FDACTIONHistoryMetadata();
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


				meta.AddTypeMap("FDActionHistoryID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Token", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastlogfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastrun", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastresult", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Lastmsg", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Msgfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastRunStart", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "FDACTIONHistory";
				meta.Destination = "FDACTIONHistory";
				
				meta.spInsert = "proc_FDACTIONHistoryInsert";				
				meta.spUpdate = "proc_FDACTIONHistoryUpdate";		
				meta.spDelete = "proc_FDACTIONHistoryDelete";
				meta.spLoadAll = "proc_FDACTIONHistoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_FDACTIONHistoryLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FDACTIONHistoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
