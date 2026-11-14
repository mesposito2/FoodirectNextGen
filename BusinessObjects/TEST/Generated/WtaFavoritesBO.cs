
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
	/// Encapsulates the 'wta_favorites' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaFavoritesBO))]	
	[XmlType("WtaFavoritesBO")]
	public partial class WtaFavoritesBO : esWtaFavoritesBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaFavoritesBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaFavoritesCollection")]
	public partial class WtaFavoritesCollection : esWtaFavoritesCollection, IEnumerable<WtaFavoritesBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaFavoritesQuery : esWtaFavoritesQuery
	{
		public WtaFavoritesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaFavoritesQuery(string joinAlias, out WtaFavoritesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaFavoritesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaFavoritesQuery query)
		{
			return WtaFavoritesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaFavoritesQuery(string query)
		{
			return (WtaFavoritesQuery)WtaFavoritesQuery.SerializeHelper.FromXml(query, typeof(WtaFavoritesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaFavoritesBO : esEntity
	{
		public esWtaFavoritesBO()
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
			WtaFavoritesQuery query = new WtaFavoritesQuery();
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
		/// Maps to wta_favorites.fid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Fid
		{
			get
			{
				return base.GetSystemDecimal(WtaFavoritesMetadata.ColumnNames.Fid);
			}
			
			set
			{
				if(base.SetSystemDecimal(WtaFavoritesMetadata.ColumnNames.Fid, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Fid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.name
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Name
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Name);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Name, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Name);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.frequency
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Frequency
		{
			get
			{
				return base.GetSystemDecimal(WtaFavoritesMetadata.ColumnNames.Frequency);
			}
			
			set
			{
				if(base.SetSystemDecimal(WtaFavoritesMetadata.ColumnNames.Frequency, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Frequency);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.lastdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastdate
		{
			get
			{
				return base.GetSystemDateTime(WtaFavoritesMetadata.ColumnNames.Lastdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaFavoritesMetadata.ColumnNames.Lastdate, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Lastdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Comment
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Comment);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Comment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaFavoritesMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaFavoritesMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_favorites.createdbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaFavoritesMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaFavoritesMetadata.ColumnNames.Createdbyname, value))
				{
					OnPropertyChanged(WtaFavoritesMetadata.PropertyNames.Createdbyname);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaFavoritesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFavoritesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFavoritesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaFavoritesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFavoritesQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaFavoritesQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaFavoritesCollection : esEntityCollection<WtaFavoritesBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaFavoritesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaFavoritesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaFavoritesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaFavoritesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaFavoritesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaFavoritesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaFavoritesQuery)query);
		}

		#endregion
		
		private WtaFavoritesQuery query;
	}



	[Serializable]
	abstract public partial class esWtaFavoritesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaFavoritesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Fid": return this.Fid;
				case "Mid": return this.Mid;
				case "Custid": return this.Custid;
				case "Name": return this.Name;
				case "Frequency": return this.Frequency;
				case "Lastdate": return this.Lastdate;
				case "Comment": return this.Comment;
				case "Createdate": return this.Createdate;
				case "Createdby": return this.Createdby;
				case "Createdbyname": return this.Createdbyname;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Fid
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Fid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Name
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Name, esSystemType.String); }
		} 
		
		public esQueryItem Frequency
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Frequency, esSystemType.Decimal); }
		} 
		
		public esQueryItem Lastdate
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Lastdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Comment
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Comment, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Createdbyname
		{
			get { return new esQueryItem(this, WtaFavoritesMetadata.ColumnNames.Createdbyname, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaFavoritesBO : esWtaFavoritesBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaFavoritesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaFavoritesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Fid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Fid;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Custid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Name, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Name;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Frequency, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Frequency;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Lastdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Lastdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Comment, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Comment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Createdate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Createdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Createdby, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaFavoritesMetadata.ColumnNames.Createdbyname, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaFavoritesMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaFavoritesMetadata Meta()
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
			 public const string Fid = "fid";
			 public const string Mid = "mid";
			 public const string Custid = "custid";
			 public const string Name = "name";
			 public const string Frequency = "frequency";
			 public const string Lastdate = "lastdate";
			 public const string Comment = "comment";
			 public const string Createdate = "createdate";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Fid = "Fid";
			 public const string Mid = "Mid";
			 public const string Custid = "Custid";
			 public const string Name = "Name";
			 public const string Frequency = "Frequency";
			 public const string Lastdate = "Lastdate";
			 public const string Comment = "Comment";
			 public const string Createdate = "Createdate";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
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
			lock (typeof(WtaFavoritesMetadata))
			{
				if(WtaFavoritesMetadata.mapDelegates == null)
				{
					WtaFavoritesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaFavoritesMetadata.meta == null)
				{
					WtaFavoritesMetadata.meta = new WtaFavoritesMetadata();
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


				meta.AddTypeMap("Fid", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Name", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Frequency", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Lastdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Comment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_favorites";
				meta.Destination = "wta_favorites";
				
				meta.spInsert = "proc_wta_favoritesInsert";				
				meta.spUpdate = "proc_wta_favoritesUpdate";		
				meta.spDelete = "proc_wta_favoritesDelete";
				meta.spLoadAll = "proc_wta_favoritesLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_favoritesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaFavoritesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
