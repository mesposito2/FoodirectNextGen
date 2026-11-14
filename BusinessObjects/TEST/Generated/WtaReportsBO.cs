
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
	/// Encapsulates the 'wta_reports' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaReportsBO))]	
	[XmlType("WtaReportsBO")]
	public partial class WtaReportsBO : esWtaReportsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaReportsBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaReportsCollection")]
	public partial class WtaReportsCollection : esWtaReportsCollection, IEnumerable<WtaReportsBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaReportsQuery : esWtaReportsQuery
	{
		public WtaReportsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaReportsQuery(string joinAlias, out WtaReportsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaReportsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaReportsQuery query)
		{
			return WtaReportsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaReportsQuery(string query)
		{
			return (WtaReportsQuery)WtaReportsQuery.SerializeHelper.FromXml(query, typeof(WtaReportsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaReportsBO : esEntity
	{
		public esWtaReportsBO()
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
			WtaReportsQuery query = new WtaReportsQuery();
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
		/// Maps to wta_reports.rid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Rid
		{
			get
			{
				return base.GetSystemDecimal(WtaReportsMetadata.ColumnNames.Rid);
			}
			
			set
			{
				if(base.SetSystemDecimal(WtaReportsMetadata.ColumnNames.Rid, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Rid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.displayorder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Displayorder
		{
			get
			{
				return base.GetSystemDouble(WtaReportsMetadata.ColumnNames.Displayorder);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaReportsMetadata.ColumnNames.Displayorder, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Displayorder);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.title
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Title
		{
			get
			{
				return base.GetSystemString(WtaReportsMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemString(WtaReportsMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Title);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.tag
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Tag
		{
			get
			{
				return base.GetSystemString(WtaReportsMetadata.ColumnNames.Tag);
			}
			
			set
			{
				if(base.SetSystemString(WtaReportsMetadata.ColumnNames.Tag, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Tag);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(WtaReportsMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(WtaReportsMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.flags
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Flags
		{
			get
			{
				return base.GetSystemDecimal(WtaReportsMetadata.ColumnNames.Flags);
			}
			
			set
			{
				if(base.SetSystemDecimal(WtaReportsMetadata.ColumnNames.Flags, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Flags);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.active
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? Active
		{
			get
			{
				return base.GetSystemInt16(WtaReportsMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaReportsMetadata.ColumnNames.Active, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Active);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.sortfields
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sortfields
		{
			get
			{
				return base.GetSystemString(WtaReportsMetadata.ColumnNames.Sortfields);
			}
			
			set
			{
				if(base.SetSystemString(WtaReportsMetadata.ColumnNames.Sortfields, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Sortfields);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_reports.sortlabels
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Sortlabels
		{
			get
			{
				return base.GetSystemString(WtaReportsMetadata.ColumnNames.Sortlabels);
			}
			
			set
			{
				if(base.SetSystemString(WtaReportsMetadata.ColumnNames.Sortlabels, value))
				{
					OnPropertyChanged(WtaReportsMetadata.PropertyNames.Sortlabels);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaReportsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaReportsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaReportsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaReportsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaReportsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaReportsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaReportsQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaReportsCollection : esEntityCollection<WtaReportsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaReportsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaReportsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaReportsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaReportsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaReportsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaReportsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaReportsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaReportsQuery)query);
		}

		#endregion
		
		private WtaReportsQuery query;
	}



	[Serializable]
	abstract public partial class esWtaReportsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaReportsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Rid": return this.Rid;
				case "Displayorder": return this.Displayorder;
				case "Title": return this.Title;
				case "Tag": return this.Tag;
				case "Description": return this.Description;
				case "Flags": return this.Flags;
				case "Active": return this.Active;
				case "Sortfields": return this.Sortfields;
				case "Sortlabels": return this.Sortlabels;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Rid
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Rid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Displayorder
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Displayorder, esSystemType.Double); }
		} 
		
		public esQueryItem Title
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Title, esSystemType.String); }
		} 
		
		public esQueryItem Tag
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Tag, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Flags
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Flags, esSystemType.Decimal); }
		} 
		
		public esQueryItem Active
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Active, esSystemType.Int16); }
		} 
		
		public esQueryItem Sortfields
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Sortfields, esSystemType.String); }
		} 
		
		public esQueryItem Sortlabels
		{
			get { return new esQueryItem(this, WtaReportsMetadata.ColumnNames.Sortlabels, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaReportsBO : esWtaReportsBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaReportsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaReportsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Rid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Rid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 18;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Displayorder, 1, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Displayorder;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Title, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Title;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Tag, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Tag;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Description, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Flags, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Flags;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Active, 6, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Active;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Sortfields, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Sortfields;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaReportsMetadata.ColumnNames.Sortlabels, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaReportsMetadata.PropertyNames.Sortlabels;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaReportsMetadata Meta()
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
			 public const string Rid = "rid";
			 public const string Displayorder = "displayorder";
			 public const string Title = "title";
			 public const string Tag = "tag";
			 public const string Description = "description";
			 public const string Flags = "flags";
			 public const string Active = "active";
			 public const string Sortfields = "sortfields";
			 public const string Sortlabels = "sortlabels";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Rid = "Rid";
			 public const string Displayorder = "Displayorder";
			 public const string Title = "Title";
			 public const string Tag = "Tag";
			 public const string Description = "Description";
			 public const string Flags = "Flags";
			 public const string Active = "Active";
			 public const string Sortfields = "Sortfields";
			 public const string Sortlabels = "Sortlabels";
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
			lock (typeof(WtaReportsMetadata))
			{
				if(WtaReportsMetadata.mapDelegates == null)
				{
					WtaReportsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaReportsMetadata.meta == null)
				{
					WtaReportsMetadata.meta = new WtaReportsMetadata();
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


				meta.AddTypeMap("Rid", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Displayorder", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Title", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Tag", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Flags", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Active", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Sortfields", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sortlabels", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_reports";
				meta.Destination = "wta_reports";
				
				meta.spInsert = "proc_wta_reportsInsert";				
				meta.spUpdate = "proc_wta_reportsUpdate";		
				meta.spDelete = "proc_wta_reportsDelete";
				meta.spLoadAll = "proc_wta_reportsLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_reportsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaReportsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
