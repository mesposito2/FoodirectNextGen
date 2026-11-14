
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
	/// Encapsulates the 'salep_nw' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalepNwBO))]	
	[XmlType("SalepNwBO")]
	public partial class SalepNwBO : esSalepNwBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalepNwBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 salepNwId)
		{
			var obj = new SalepNwBO();
			obj.SalepNwId = salepNwId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 salepNwId, esSqlAccessType sqlAccessType)
		{
			var obj = new SalepNwBO();
			obj.SalepNwId = salepNwId;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalepNwCollection")]
	public partial class SalepNwCollection : esSalepNwCollection, IEnumerable<SalepNwBO>
	{
		public SalepNwBO FindByPrimaryKey(System.Int32 salepNwId)
		{
			return this.SingleOrDefault(e => e.SalepNwId == salepNwId);
		}

		
				
	}



	[Serializable]	
	public partial class SalepNwQuery : esSalepNwQuery
	{
		public SalepNwQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalepNwQuery(string joinAlias, out SalepNwQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalepNwQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalepNwQuery query)
		{
			return SalepNwQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalepNwQuery(string query)
		{
			return (SalepNwQuery)SalepNwQuery.SerializeHelper.FromXml(query, typeof(SalepNwQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalepNwBO : esEntity
	{
		public esSalepNwBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salepNwId)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(salepNwId);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salepNwId)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepNwId);
			else
				return LoadByPrimaryKeyStoredProcedure(salepNwId);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salepNwId)
		{
			SalepNwQuery query = new SalepNwQuery();
			query.Where(query.SalepNwId == salepNwId);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salepNwId)
		{
			esParameters parms = new esParameters();
			parms.Add("SalepNwId", salepNwId);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to salep_nw.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.colnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.Colnum, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Colnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.line
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.Line, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Line);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.sdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(SalepNwMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(SalepNwMetadata.ColumnNames.Sdescription, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Sdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.slbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(SalepNwMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepNwMetadata.ColumnNames.Slbcs, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Slbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.sjlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(SalepNwMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepNwMetadata.ColumnNames.Sjlbcs, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.Sjlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep_nw.salep_nw_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalepNwId
		{
			get
			{
				return base.GetSystemInt32(SalepNwMetadata.ColumnNames.SalepNwId);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepNwMetadata.ColumnNames.SalepNwId, value))
				{
					OnPropertyChanged(SalepNwMetadata.PropertyNames.SalepNwId);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalepNwMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepNwQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalepNwQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalepNwQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalepNwQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalepNwQuery query;		
	}



	[Serializable]
	abstract public partial class esSalepNwCollection : esEntityCollection<SalepNwBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalepNwMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalepNwCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalepNwQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepNwQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalepNwQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepNwQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalepNwQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalepNwQuery)query);
		}

		#endregion
		
		private SalepNwQuery query;
	}



	[Serializable]
	abstract public partial class esSalepNwQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalepNwMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Colnum": return this.Colnum;
				case "Line": return this.Line;
				case "Productcode": return this.Productcode;
				case "Sdescription": return this.Sdescription;
				case "Slbcs": return this.Slbcs;
				case "Sjlbcs": return this.Sjlbcs;
				case "SalepNwId": return this.SalepNwId;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Colnum
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Colnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Line
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Line, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Sdescription
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Sdescription, esSystemType.String); }
		} 
		
		public esQueryItem Slbcs
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Slbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Sjlbcs
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.Sjlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem SalepNwId
		{
			get { return new esQueryItem(this, SalepNwMetadata.ColumnNames.SalepNwId, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class SalepNwBO : esSalepNwBO
	{

		
		
	}
	



	[Serializable]
	public partial class SalepNwMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalepNwMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepNwMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepNwMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepNwMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepNwMetadata.ColumnNames.SalepNwId, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepNwMetadata.PropertyNames.SalepNwId;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalepNwMetadata Meta()
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
			 public const string Custid = "custid";
			 public const string Colnum = "colnum";
			 public const string Line = "line";
			 public const string Productcode = "productcode";
			 public const string Sdescription = "sdescription";
			 public const string Slbcs = "slbcs";
			 public const string Sjlbcs = "sjlbcs";
			 public const string SalepNwId = "salep_nw_id";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Colnum = "Colnum";
			 public const string Line = "Line";
			 public const string Productcode = "Productcode";
			 public const string Sdescription = "Sdescription";
			 public const string Slbcs = "Slbcs";
			 public const string Sjlbcs = "Sjlbcs";
			 public const string SalepNwId = "SalepNwId";
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
			lock (typeof(SalepNwMetadata))
			{
				if(SalepNwMetadata.mapDelegates == null)
				{
					SalepNwMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalepNwMetadata.meta == null)
				{
					SalepNwMetadata.meta = new SalepNwMetadata();
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


				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Colnum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Line", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Slbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sjlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SalepNwId", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "salep_nw";
				meta.Destination = "salep_nw";
				
				meta.spInsert = "proc_salep_nwInsert";				
				meta.spUpdate = "proc_salep_nwUpdate";		
				meta.spDelete = "proc_salep_nwDelete";
				meta.spLoadAll = "proc_salep_nwLoadAll";
				meta.spLoadByPrimaryKey = "proc_salep_nwLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalepNwMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
