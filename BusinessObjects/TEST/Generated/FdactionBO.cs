
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
	/// Encapsulates the 'FDACTION' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(FdactionBO))]	
	[XmlType("FdactionBO")]
	public partial class FdactionBO : esFdactionBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new FdactionBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 fDActionID)
		{
			var obj = new FdactionBO();
			obj.FDActionID = fDActionID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 fDActionID, esSqlAccessType sqlAccessType)
		{
			var obj = new FdactionBO();
			obj.FDActionID = fDActionID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("FdactionCollection")]
	public partial class FdactionCollection : esFdactionCollection, IEnumerable<FdactionBO>
	{
		public FdactionBO FindByPrimaryKey(System.Int32 fDActionID)
		{
			return this.SingleOrDefault(e => e.FDActionID == fDActionID);
		}

		
				
	}



	[Serializable]	
	public partial class FdactionQuery : esFdactionQuery
	{
		public FdactionQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public FdactionQuery(string joinAlias, out FdactionQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "FdactionQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(FdactionQuery query)
		{
			return FdactionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator FdactionQuery(string query)
		{
			return (FdactionQuery)FdactionQuery.SerializeHelper.FromXml(query, typeof(FdactionQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esFdactionBO : esEntity
	{
		public esFdactionBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 fDActionID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 fDActionID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 fDActionID)
		{
			FdactionQuery query = new FdactionQuery();
			query.Where(query.FDActionID == fDActionID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 fDActionID)
		{
			esParameters parms = new esParameters();
			parms.Add("FDActionID", fDActionID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to FDACTION.FDActionID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? FDActionID
		{
			get
			{
				return base.GetSystemInt32(FdactionMetadata.ColumnNames.FDActionID);
			}
			
			set
			{
				if(base.SetSystemInt32(FdactionMetadata.ColumnNames.FDActionID, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.FDActionID);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.token
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Token
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Token);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Token, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Token);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastlogfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastlogfile
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Lastlogfile);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Lastlogfile, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Lastlogfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastrun
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastrun
		{
			get
			{
				return base.GetSystemDateTime(FdactionMetadata.ColumnNames.Lastrun);
			}
			
			set
			{
				if(base.SetSystemDateTime(FdactionMetadata.ColumnNames.Lastrun, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Lastrun);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastresult
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Lastresult
		{
			get
			{
				return base.GetSystemDecimal(FdactionMetadata.ColumnNames.Lastresult);
			}
			
			set
			{
				if(base.SetSystemDecimal(FdactionMetadata.ColumnNames.Lastresult, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Lastresult);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastmsg
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastmsg
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Lastmsg);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Lastmsg, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Lastmsg);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.msgfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Msgfile
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Msgfile);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Msgfile, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Msgfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(FdactionMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(FdactionMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.LastRunStart
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastRunStart
		{
			get
			{
				return base.GetSystemDateTime(FdactionMetadata.ColumnNames.LastRunStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(FdactionMetadata.ColumnNames.LastRunStart, value))
				{
					OnPropertyChanged(FdactionMetadata.PropertyNames.LastRunStart);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return FdactionMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public FdactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FdactionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FdactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(FdactionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FdactionQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private FdactionQuery query;		
	}



	[Serializable]
	abstract public partial class esFdactionCollection : esEntityCollection<FdactionBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FdactionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "FdactionCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public FdactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FdactionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(FdactionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FdactionQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(FdactionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((FdactionQuery)query);
		}

		#endregion
		
		private FdactionQuery query;
	}



	[Serializable]
	abstract public partial class esFdactionQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FdactionMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "FDActionID": return this.FDActionID;
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

		public esQueryItem FDActionID
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.FDActionID, esSystemType.Int32); }
		} 
		
		public esQueryItem Token
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Token, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Lastlogfile
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastlogfile, esSystemType.String); }
		} 
		
		public esQueryItem Lastrun
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastrun, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastresult
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastresult, esSystemType.Decimal); }
		} 
		
		public esQueryItem Lastmsg
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastmsg, esSystemType.String); }
		} 
		
		public esQueryItem Msgfile
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Msgfile, esSystemType.String); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.Active, esSystemType.Boolean); }
		} 
		
		public esQueryItem LastRunStart
		{
			get { return new esQueryItem(this, FdactionMetadata.ColumnNames.LastRunStart, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class FdactionBO : esFdactionBO
	{

		
		
	}
	



	[Serializable]
	public partial class FdactionMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FdactionMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FdactionMetadata.ColumnNames.FDActionID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FdactionMetadata.PropertyNames.FDActionID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Token, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Token;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastlogfile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastlogfile;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastrun, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastrun;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastresult, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastresult;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastmsg, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastmsg;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Msgfile, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Msgfile;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = FdactionMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.LastRunStart, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FdactionMetadata.PropertyNames.LastRunStart;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public FdactionMetadata Meta()
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
			 public const string FDActionID = "FDActionID";
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
			 public const string FDActionID = "FDActionID";
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
			lock (typeof(FdactionMetadata))
			{
				if(FdactionMetadata.mapDelegates == null)
				{
					FdactionMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (FdactionMetadata.meta == null)
				{
					FdactionMetadata.meta = new FdactionMetadata();
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


				meta.AddTypeMap("FDActionID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Token", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastlogfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastrun", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastresult", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Lastmsg", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Msgfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastRunStart", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "FDACTION";
				meta.Destination = "FDACTION";
				
				meta.spInsert = "proc_FDACTIONInsert";				
				meta.spUpdate = "proc_FDACTIONUpdate";		
				meta.spDelete = "proc_FDACTIONDelete";
				meta.spLoadAll = "proc_FDACTIONLoadAll";
				meta.spLoadByPrimaryKey = "proc_FDACTIONLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FdactionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
