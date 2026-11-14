
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:18 PM
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
	/// Encapsulates the 'wta_ticket_line_weight' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaTicketLineWeightBO))]	
	[XmlType("WtaTicketLineWeightBO")]
	public partial class WtaTicketLineWeightBO : esWtaTicketLineWeightBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaTicketLineWeightBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaTicketLineWeightCollection")]
	public partial class WtaTicketLineWeightCollection : esWtaTicketLineWeightCollection, IEnumerable<WtaTicketLineWeightBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaTicketLineWeightQuery : esWtaTicketLineWeightQuery
	{
		public WtaTicketLineWeightQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaTicketLineWeightQuery(string joinAlias, out WtaTicketLineWeightQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaTicketLineWeightQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaTicketLineWeightQuery query)
		{
			return WtaTicketLineWeightQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaTicketLineWeightQuery(string query)
		{
			return (WtaTicketLineWeightQuery)WtaTicketLineWeightQuery.SerializeHelper.FromXml(query, typeof(WtaTicketLineWeightQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaTicketLineWeightBO : esEntity
	{
		public esWtaTicketLineWeightBO()
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
			WtaTicketLineWeightQuery query = new WtaTicketLineWeightQuery();
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
		/// Maps to wta_ticket_line_weight.tlwid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tlwid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Tlwid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Tlwid, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Tlwid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line_weight.iid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Iid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Iid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Iid, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Iid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line_weight.tlid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Tlid
		{
			get
			{
				return base.GetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Tlid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaTicketLineWeightMetadata.ColumnNames.Tlid, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Tlid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line_weight.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaTicketLineWeightMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaTicketLineWeightMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line_weight.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineWeightMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineWeightMetadata.ColumnNames.Weight, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_ticket_line_weight.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaTicketLineWeightMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaTicketLineWeightMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(WtaTicketLineWeightMetadata.PropertyNames.Qty);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineWeightMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaTicketLineWeightQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketLineWeightQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketLineWeightQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaTicketLineWeightQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketLineWeightQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaTicketLineWeightQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaTicketLineWeightCollection : esEntityCollection<WtaTicketLineWeightBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineWeightMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaTicketLineWeightCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaTicketLineWeightQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaTicketLineWeightQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaTicketLineWeightQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaTicketLineWeightQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaTicketLineWeightQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaTicketLineWeightQuery)query);
		}

		#endregion
		
		private WtaTicketLineWeightQuery query;
	}



	[Serializable]
	abstract public partial class esWtaTicketLineWeightQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaTicketLineWeightMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Tlwid": return this.Tlwid;
				case "Iid": return this.Iid;
				case "Tlid": return this.Tlid;
				case "Createdate": return this.Createdate;
				case "Weight": return this.Weight;
				case "Qty": return this.Qty;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Tlwid
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Tlwid, esSystemType.Int32); }
		} 
		
		public esQueryItem Iid
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Iid, esSystemType.Int32); }
		} 
		
		public esQueryItem Tlid
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Tlid, esSystemType.Int32); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, WtaTicketLineWeightMetadata.ColumnNames.Qty, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaTicketLineWeightBO : esWtaTicketLineWeightBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaTicketLineWeightMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaTicketLineWeightMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Tlwid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Tlwid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Iid, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Iid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Tlid, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Tlid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Createdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Weight, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaTicketLineWeightMetadata.ColumnNames.Qty, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaTicketLineWeightMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaTicketLineWeightMetadata Meta()
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
			 public const string Tlwid = "tlwid";
			 public const string Iid = "iid";
			 public const string Tlid = "tlid";
			 public const string Createdate = "createdate";
			 public const string Weight = "weight";
			 public const string Qty = "qty";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Tlwid = "Tlwid";
			 public const string Iid = "Iid";
			 public const string Tlid = "Tlid";
			 public const string Createdate = "Createdate";
			 public const string Weight = "Weight";
			 public const string Qty = "Qty";
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
			lock (typeof(WtaTicketLineWeightMetadata))
			{
				if(WtaTicketLineWeightMetadata.mapDelegates == null)
				{
					WtaTicketLineWeightMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaTicketLineWeightMetadata.meta == null)
				{
					WtaTicketLineWeightMetadata.meta = new WtaTicketLineWeightMetadata();
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


				meta.AddTypeMap("Tlwid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Iid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Tlid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "wta_ticket_line_weight";
				meta.Destination = "wta_ticket_line_weight";
				
				meta.spInsert = "proc_wta_ticket_line_weightInsert";				
				meta.spUpdate = "proc_wta_ticket_line_weightUpdate";		
				meta.spDelete = "proc_wta_ticket_line_weightDelete";
				meta.spLoadAll = "proc_wta_ticket_line_weightLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_ticket_line_weightLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaTicketLineWeightMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
