
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
	/// Encapsulates the 'produce' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProduceBO))]	
	[XmlType("ProduceBO")]
	public partial class ProduceBO : esProduceBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProduceBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 produceID)
		{
			var obj = new ProduceBO();
			obj.ProduceID = produceID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 produceID, esSqlAccessType sqlAccessType)
		{
			var obj = new ProduceBO();
			obj.ProduceID = produceID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProduceCollection")]
	public partial class ProduceCollection : esProduceCollection, IEnumerable<ProduceBO>
	{
		public ProduceBO FindByPrimaryKey(System.Int32 produceID)
		{
			return this.SingleOrDefault(e => e.ProduceID == produceID);
		}

		
				
	}



	[Serializable]	
	public partial class ProduceQuery : esProduceQuery
	{
		public ProduceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProduceQuery(string joinAlias, out ProduceQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProduceQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProduceQuery query)
		{
			return ProduceQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProduceQuery(string query)
		{
			return (ProduceQuery)ProduceQuery.SerializeHelper.FromXml(query, typeof(ProduceQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProduceBO : esEntity
	{
		public esProduceBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 produceID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(produceID);
			else
				return LoadByPrimaryKeyStoredProcedure(produceID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 produceID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(produceID);
			else
				return LoadByPrimaryKeyStoredProcedure(produceID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 produceID)
		{
			ProduceQuery query = new ProduceQuery();
			query.Where(query.ProduceID == produceID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 produceID)
		{
			esParameters parms = new esParameters();
			parms.Add("ProduceID", produceID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to produce.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.colnum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.Colnum, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Colnum);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.line
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.Line, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Line);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.sdescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(ProduceMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(ProduceMetadata.ColumnNames.Sdescription, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Sdescription);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.slbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(ProduceMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProduceMetadata.ColumnNames.Slbcs, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Slbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.sjlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(ProduceMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProduceMetadata.ColumnNames.Sjlbcs, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.Sjlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to produce.produceID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ProduceID
		{
			get
			{
				return base.GetSystemInt32(ProduceMetadata.ColumnNames.ProduceID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProduceMetadata.ColumnNames.ProduceID, value))
				{
					OnPropertyChanged(ProduceMetadata.PropertyNames.ProduceID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProduceMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProduceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProduceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProduceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProduceQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProduceQuery query;		
	}



	[Serializable]
	abstract public partial class esProduceCollection : esEntityCollection<ProduceBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProduceMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProduceCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProduceQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProduceQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProduceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProduceQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProduceQuery)query);
		}

		#endregion
		
		private ProduceQuery query;
	}



	[Serializable]
	abstract public partial class esProduceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProduceMetadata.Meta();
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
				case "ProduceID": return this.ProduceID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Colnum
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Colnum, esSystemType.Int32); }
		} 
		
		public esQueryItem Line
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Line, esSystemType.Int32); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Sdescription
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Sdescription, esSystemType.String); }
		} 
		
		public esQueryItem Slbcs
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Slbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Sjlbcs
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.Sjlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem ProduceID
		{
			get { return new esQueryItem(this, ProduceMetadata.ColumnNames.ProduceID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ProduceBO : esProduceBO
	{

		
		
	}
	



	[Serializable]
	public partial class ProduceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProduceMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Colnum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Line, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Productcode, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Sdescription, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProduceMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Slbcs, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProduceMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.Sjlbcs, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProduceMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProduceMetadata.ColumnNames.ProduceID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProduceMetadata.PropertyNames.ProduceID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProduceMetadata Meta()
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
			 public const string ProduceID = "produceID";
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
			 public const string ProduceID = "ProduceID";
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
			lock (typeof(ProduceMetadata))
			{
				if(ProduceMetadata.mapDelegates == null)
				{
					ProduceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProduceMetadata.meta == null)
				{
					ProduceMetadata.meta = new ProduceMetadata();
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
				meta.AddTypeMap("ProduceID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "produce";
				meta.Destination = "produce";
				
				meta.spInsert = "proc_produceInsert";				
				meta.spUpdate = "proc_produceUpdate";		
				meta.spDelete = "proc_produceDelete";
				meta.spLoadAll = "proc_produceLoadAll";
				meta.spLoadByPrimaryKey = "proc_produceLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProduceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
