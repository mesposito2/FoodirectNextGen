
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:17 PM
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
	/// Encapsulates the 'wta_fdpx_struct' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaFdpxStructBO))]	
	[XmlType("WtaFdpxStructBO")]
	public partial class WtaFdpxStructBO : esWtaFdpxStructBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaFdpxStructBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Guid structID)
		{
			var obj = new WtaFdpxStructBO();
			obj.StructID = structID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Guid structID, esSqlAccessType sqlAccessType)
		{
			var obj = new WtaFdpxStructBO();
			obj.StructID = structID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaFdpxStructCollection")]
	public partial class WtaFdpxStructCollection : esWtaFdpxStructCollection, IEnumerable<WtaFdpxStructBO>
	{
		public WtaFdpxStructBO FindByPrimaryKey(System.Guid structID)
		{
			return this.SingleOrDefault(e => e.StructID == structID);
		}

		
				
	}



	[Serializable]	
	public partial class WtaFdpxStructQuery : esWtaFdpxStructQuery
	{
		public WtaFdpxStructQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaFdpxStructQuery(string joinAlias, out WtaFdpxStructQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaFdpxStructQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaFdpxStructQuery query)
		{
			return WtaFdpxStructQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaFdpxStructQuery(string query)
		{
			return (WtaFdpxStructQuery)WtaFdpxStructQuery.SerializeHelper.FromXml(query, typeof(WtaFdpxStructQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaFdpxStructBO : esEntity
	{
		public esWtaFdpxStructBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Guid structID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(structID);
			else
				return LoadByPrimaryKeyStoredProcedure(structID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Guid structID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(structID);
			else
				return LoadByPrimaryKeyStoredProcedure(structID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Guid structID)
		{
			WtaFdpxStructQuery query = new WtaFdpxStructQuery();
			query.Where(query.StructID == structID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Guid structID)
		{
			esParameters parms = new esParameters();
			parms.Add("StructID", structID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_fdpx_struct.tableid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Tableid
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Tableid);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Tableid, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Tableid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Fnum
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Fnum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Fnum, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Fnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fname
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Fname);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Fname, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Fname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.length
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Length
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Length);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Length, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Length);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.startpos
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Startpos
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Startpos);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Startpos, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Startpos);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.endpos
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Endpos
		{
			get
			{
				return base.GetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Endpos);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaFdpxStructMetadata.ColumnNames.Endpos, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Endpos);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.fdesc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fdesc
		{
			get
			{
				return base.GetSystemString(WtaFdpxStructMetadata.ColumnNames.Fdesc);
			}
			
			set
			{
				if(base.SetSystemString(WtaFdpxStructMetadata.ColumnNames.Fdesc, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.Fdesc);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_fdpx_struct.structID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Guid? StructID
		{
			get
			{
				return base.GetSystemGuid(WtaFdpxStructMetadata.ColumnNames.StructID);
			}
			
			set
			{
				if(base.SetSystemGuid(WtaFdpxStructMetadata.ColumnNames.StructID, value))
				{
					OnPropertyChanged(WtaFdpxStructMetadata.PropertyNames.StructID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaFdpxStructMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaFdpxStructQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFdpxStructQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFdpxStructQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaFdpxStructQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFdpxStructQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaFdpxStructQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaFdpxStructCollection : esEntityCollection<WtaFdpxStructBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaFdpxStructMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaFdpxStructCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaFdpxStructQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFdpxStructQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFdpxStructQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaFdpxStructQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaFdpxStructQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFdpxStructQuery)query);
		}

		#endregion
		
		private WtaFdpxStructQuery query;
	}



	[Serializable]
	abstract public partial class esWtaFdpxStructQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaFdpxStructMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Tableid": return this.Tableid;
				case "Fnum": return this.Fnum;
				case "Fname": return this.Fname;
				case "Length": return this.Length;
				case "Startpos": return this.Startpos;
				case "Endpos": return this.Endpos;
				case "Fdesc": return this.Fdesc;
				case "StructID": return this.StructID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Tableid
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Tableid, esSystemType.String); }
		} 
		
		public esQueryItem Fnum
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Fname
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fname, esSystemType.String); }
		} 
		
		public esQueryItem Length
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Length, esSystemType.Int32); }
		} 
		
		public esQueryItem Startpos
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Startpos, esSystemType.Int32); }
		} 
		
		public esQueryItem Endpos
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Endpos, esSystemType.Int32); }
		} 
		
		public esQueryItem Fdesc
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.Fdesc, esSystemType.String); }
		} 
		
		public esQueryItem StructID
		{
			get { return new esQueryItem(this, WtaFdpxStructMetadata.ColumnNames.StructID, esSystemType.Guid); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaFdpxStructBO : esWtaFdpxStructBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaFdpxStructMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaFdpxStructMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Tableid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Tableid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fname;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Length, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Length;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Startpos, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Startpos;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Endpos, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Endpos;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.Fdesc, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.Fdesc;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFdpxStructMetadata.ColumnNames.StructID, 7, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = WtaFdpxStructMetadata.PropertyNames.StructID;
			c.IsInPrimaryKey = true;
			c.HasDefault = true;
			c.Default = @"(newid())";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaFdpxStructMetadata Meta()
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
			 public const string Tableid = "tableid";
			 public const string Fnum = "fnum";
			 public const string Fname = "fname";
			 public const string Length = "length";
			 public const string Startpos = "startpos";
			 public const string Endpos = "endpos";
			 public const string Fdesc = "fdesc";
			 public const string StructID = "structID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tableid = "Tableid";
			 public const string Fnum = "Fnum";
			 public const string Fname = "Fname";
			 public const string Length = "Length";
			 public const string Startpos = "Startpos";
			 public const string Endpos = "Endpos";
			 public const string Fdesc = "Fdesc";
			 public const string StructID = "StructID";
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
			lock (typeof(WtaFdpxStructMetadata))
			{
				if(WtaFdpxStructMetadata.mapDelegates == null)
				{
					WtaFdpxStructMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaFdpxStructMetadata.meta == null)
				{
					WtaFdpxStructMetadata.meta = new WtaFdpxStructMetadata();
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


				meta.AddTypeMap("Tableid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Fnum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Fname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Length", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Startpos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Endpos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Fdesc", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("StructID", new esTypeMap("uniqueidentifier", "System.Guid"));			
				
				
				
				meta.Source = "wta_fdpx_struct";
				meta.Destination = "wta_fdpx_struct";
				
				meta.spInsert = "proc_wta_fdpx_structInsert";				
				meta.spUpdate = "proc_wta_fdpx_structUpdate";		
				meta.spDelete = "proc_wta_fdpx_structDelete";
				meta.spLoadAll = "proc_wta_fdpx_structLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_fdpx_structLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaFdpxStructMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
