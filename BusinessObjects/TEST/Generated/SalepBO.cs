
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
	/// Encapsulates the 'salep' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalepBO))]	
	[XmlType("SalepBO")]
	public partial class SalepBO : esSalepBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalepBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 salepID)
		{
			var obj = new SalepBO();
			obj.SalepID = salepID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 salepID, esSqlAccessType sqlAccessType)
		{
			var obj = new SalepBO();
			obj.SalepID = salepID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalepCollection")]
	public partial class SalepCollection : esSalepCollection, IEnumerable<SalepBO>
	{
		public SalepBO FindByPrimaryKey(System.Int32 salepID)
		{
			return this.SingleOrDefault(e => e.SalepID == salepID);
		}

		
				
	}



	[Serializable]	
	public partial class SalepQuery : esSalepQuery
	{
		public SalepQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalepQuery(string joinAlias, out SalepQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalepQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalepQuery query)
		{
			return SalepQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalepQuery(string query)
		{
			return (SalepQuery)SalepQuery.SerializeHelper.FromXml(query, typeof(SalepQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalepBO : esEntity
	{
		public esSalepBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salepID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepID);
			else
				return LoadByPrimaryKeyStoredProcedure(salepID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salepID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salepID);
			else
				return LoadByPrimaryKeyStoredProcedure(salepID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salepID)
		{
			SalepQuery query = new SalepQuery();
			query.Where(query.SalepID == salepID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salepID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalepID", salepID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to salep.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.colnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.Colnum, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Colnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.line
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.Line, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Line);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.sdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(SalepMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(SalepMetadata.ColumnNames.Sdescription, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Sdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.slbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(SalepMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepMetadata.ColumnNames.Slbcs, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Slbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.sjlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(SalepMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(SalepMetadata.ColumnNames.Sjlbcs, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.Sjlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to salep.salepID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalepID
		{
			get
			{
				return base.GetSystemInt32(SalepMetadata.ColumnNames.SalepID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalepMetadata.ColumnNames.SalepID, value))
				{
					OnPropertyChanged(SalepMetadata.PropertyNames.SalepID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalepMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalepQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalepQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalepQuery query;		
	}



	[Serializable]
	abstract public partial class esSalepCollection : esEntityCollection<SalepBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalepMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalepCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalepQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalepQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalepQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalepQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalepQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalepQuery)query);
		}

		#endregion
		
		private SalepQuery query;
	}



	[Serializable]
	abstract public partial class esSalepQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalepMetadata.Meta();
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
				case "SalepID": return this.SalepID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Colnum
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Colnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Line
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Line, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Sdescription
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Sdescription, esSystemType.String); }
		} 
		
		public esQueryItem Slbcs
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Slbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Sjlbcs
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.Sjlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem SalepID
		{
			get { return new esQueryItem(this, SalepMetadata.ColumnNames.SalepID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class SalepBO : esSalepBO
	{

		
		
	}
	



	[Serializable]
	public partial class SalepMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalepMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalepMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SalepMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SalepMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalepMetadata.ColumnNames.SalepID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalepMetadata.PropertyNames.SalepID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalepMetadata Meta()
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
			 public const string SalepID = "salepID";
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
			 public const string SalepID = "SalepID";
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
			lock (typeof(SalepMetadata))
			{
				if(SalepMetadata.mapDelegates == null)
				{
					SalepMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalepMetadata.meta == null)
				{
					SalepMetadata.meta = new SalepMetadata();
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
				meta.AddTypeMap("SalepID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "salep";
				meta.Destination = "salep";
				
				meta.spInsert = "proc_salepInsert";				
				meta.spUpdate = "proc_salepUpdate";		
				meta.spDelete = "proc_salepDelete";
				meta.spLoadAll = "proc_salepLoadAll";
				meta.spLoadByPrimaryKey = "proc_salepLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalepMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
