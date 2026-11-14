
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
	/// Encapsulates the 'SalesBeefConfigAd' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SalesBeefConfigAdBO))]	
	[XmlType("SalesBeefConfigAdBO")]
	public partial class SalesBeefConfigAdBO : esSalesBeefConfigAdBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SalesBeefConfigAdBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 salesBeefConfigAdID)
		{
			var obj = new SalesBeefConfigAdBO();
			obj.SalesBeefConfigAdID = salesBeefConfigAdID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 salesBeefConfigAdID, esSqlAccessType sqlAccessType)
		{
			var obj = new SalesBeefConfigAdBO();
			obj.SalesBeefConfigAdID = salesBeefConfigAdID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SalesBeefConfigAdCollection")]
	public partial class SalesBeefConfigAdCollection : esSalesBeefConfigAdCollection, IEnumerable<SalesBeefConfigAdBO>
	{
		public SalesBeefConfigAdBO FindByPrimaryKey(System.Int32 salesBeefConfigAdID)
		{
			return this.SingleOrDefault(e => e.SalesBeefConfigAdID == salesBeefConfigAdID);
		}

		
				
	}



	[Serializable]	
	public partial class SalesBeefConfigAdQuery : esSalesBeefConfigAdQuery
	{
		public SalesBeefConfigAdQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SalesBeefConfigAdQuery(string joinAlias, out SalesBeefConfigAdQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SalesBeefConfigAdQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SalesBeefConfigAdQuery query)
		{
			return SalesBeefConfigAdQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SalesBeefConfigAdQuery(string query)
		{
			return (SalesBeefConfigAdQuery)SalesBeefConfigAdQuery.SerializeHelper.FromXml(query, typeof(SalesBeefConfigAdQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSalesBeefConfigAdBO : esEntity
	{
		public esSalesBeefConfigAdBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 salesBeefConfigAdID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigAdID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 salesBeefConfigAdID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(salesBeefConfigAdID);
			else
				return LoadByPrimaryKeyStoredProcedure(salesBeefConfigAdID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 salesBeefConfigAdID)
		{
			SalesBeefConfigAdQuery query = new SalesBeefConfigAdQuery();
			query.Where(query.SalesBeefConfigAdID == salesBeefConfigAdID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 salesBeefConfigAdID)
		{
			esParameters parms = new esParameters();
			parms.Add("SalesBeefConfigAdID", salesBeefConfigAdID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.SalesBeefConfigAdID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalesBeefConfigAdID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, value))
				{
					OnPropertyChanged(SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigAdID);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.SalesBeefConfigID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SalesBeefConfigID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, value))
				{
					this._SalesBeefConfigBO = null;
					this.OnPropertyChanged("SalesBeefConfigBO");
					OnPropertyChanged(SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigID);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.PageNum
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PageNum
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.PageNum);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.PageNum, value))
				{
					OnPropertyChanged(SalesBeefConfigAdMetadata.PropertyNames.PageNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to SalesBeefConfigAd.AdID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AdID
		{
			get
			{
				return base.GetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.AdID);
			}
			
			set
			{
				if(base.SetSystemInt32(SalesBeefConfigAdMetadata.ColumnNames.AdID, value))
				{
					this._AdBO = null;
					this.OnPropertyChanged("AdBO");
					OnPropertyChanged(SalesBeefConfigAdMetadata.PropertyNames.AdID);
				}
			}
		}
		
		internal protected AdBO _AdBO;
		internal protected SalesBeefConfigBO _SalesBeefConfigBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigAdMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SalesBeefConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigAdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesBeefConfigAdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SalesBeefConfigAdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalesBeefConfigAdQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SalesBeefConfigAdQuery query;		
	}



	[Serializable]
	abstract public partial class esSalesBeefConfigAdCollection : esEntityCollection<SalesBeefConfigAdBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigAdMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SalesBeefConfigAdCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SalesBeefConfigAdQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SalesBeefConfigAdQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SalesBeefConfigAdQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SalesBeefConfigAdQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SalesBeefConfigAdQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SalesBeefConfigAdQuery)query);
		}

		#endregion
		
		private SalesBeefConfigAdQuery query;
	}



	[Serializable]
	abstract public partial class esSalesBeefConfigAdQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SalesBeefConfigAdMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SalesBeefConfigAdID": return this.SalesBeefConfigAdID;
				case "SalesBeefConfigID": return this.SalesBeefConfigID;
				case "PageNum": return this.PageNum;
				case "AdID": return this.AdID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SalesBeefConfigAdID
		{
			get { return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, esSystemType.Int32); }
		} 
		
		public esQueryItem SalesBeefConfigID
		{
			get { return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, esSystemType.Int32); }
		} 
		
		public esQueryItem PageNum
		{
			get { return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.PageNum, esSystemType.Int32); }
		} 
		
		public esQueryItem AdID
		{
			get { return new esQueryItem(this, SalesBeefConfigAdMetadata.ColumnNames.AdID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class SalesBeefConfigAdBO : esSalesBeefConfigAdBO
	{

		
		#region AdBO - Many To One (FK_SalesBeefConfigAd_AdID)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeAdBO()
		{
		    return this._AdBO != null ? true : false;
		}
		

		[DataMember(Name="AdBO", EmitDefaultValue = false)]
					
		public AdBO AdBO
		{
			get
			{
                if (this._AdBO == null)
                {
                    this._AdBO = new AdBO();
                    this._AdBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("AdBO", this._AdBO);

					if(this._AdBO == null && AdID != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._AdBO.Query.Where(this._AdBO.Query.AdID == this.AdID);
							this._AdBO.Query.Load();
                        }
                    }
                }

				return this._AdBO;
			}
			
			set
			{
				this.RemovePreSave("AdBO");
				

				if(value == null)
				{
					this.AdID = null;
					this._AdBO = null;
				}
				else
				{
					this.AdID = value.AdID;
					this._AdBO = value;
					this.SetPreSave("AdBO", this._AdBO);
				}
				
			}
		}
		#endregion
		

		
		#region SalesBeefConfigBO - Many To One (FK_SalesBeefConfigAd_SalesBeefConfigID)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeSalesBeefConfigBO()
		{
		    return this._SalesBeefConfigBO != null ? true : false;
		}
		

		[DataMember(Name="SalesBeefConfigBO", EmitDefaultValue = false)]
					
		public SalesBeefConfigBO SalesBeefConfigBO
		{
			get
			{
                if (this._SalesBeefConfigBO == null)
                {
                    this._SalesBeefConfigBO = new SalesBeefConfigBO();
                    this._SalesBeefConfigBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("SalesBeefConfigBO", this._SalesBeefConfigBO);

					if(this._SalesBeefConfigBO == null && SalesBeefConfigID != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._SalesBeefConfigBO.Query.Where(this._SalesBeefConfigBO.Query.SalesBeefConfigID == this.SalesBeefConfigID);
							this._SalesBeefConfigBO.Query.Load();
                        }
                    }
                }

				return this._SalesBeefConfigBO;
			}
			
			set
			{
				this.RemovePreSave("SalesBeefConfigBO");
				

				if(value == null)
				{
					this.SalesBeefConfigID = null;
					this._SalesBeefConfigBO = null;
				}
				else
				{
					this.SalesBeefConfigID = value.SalesBeefConfigID;
					this._SalesBeefConfigBO = value;
					this.SetPreSave("SalesBeefConfigBO", this._SalesBeefConfigBO);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._AdBO != null)
			{
				this.AdID = this._AdBO.AdID;
			}
			if(!this.es.IsDeleted && this._SalesBeefConfigBO != null)
			{
				this.SalesBeefConfigID = this._SalesBeefConfigBO.SalesBeefConfigID;
			}
		}
		
	}
	



	[Serializable]
	public partial class SalesBeefConfigAdMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SalesBeefConfigAdMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigAdID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigAdID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.SalesBeefConfigID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.SalesBeefConfigID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.PageNum, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.PageNum;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SalesBeefConfigAdMetadata.ColumnNames.AdID, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SalesBeefConfigAdMetadata.PropertyNames.AdID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SalesBeefConfigAdMetadata Meta()
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
			 public const string SalesBeefConfigAdID = "SalesBeefConfigAdID";
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SalesBeefConfigAdID = "SalesBeefConfigAdID";
			 public const string SalesBeefConfigID = "SalesBeefConfigID";
			 public const string PageNum = "PageNum";
			 public const string AdID = "AdID";
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
			lock (typeof(SalesBeefConfigAdMetadata))
			{
				if(SalesBeefConfigAdMetadata.mapDelegates == null)
				{
					SalesBeefConfigAdMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SalesBeefConfigAdMetadata.meta == null)
				{
					SalesBeefConfigAdMetadata.meta = new SalesBeefConfigAdMetadata();
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


				meta.AddTypeMap("SalesBeefConfigAdID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SalesBeefConfigID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PageNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AdID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "SalesBeefConfigAd";
				meta.Destination = "SalesBeefConfigAd";
				
				meta.spInsert = "proc_SalesBeefConfigAdInsert";				
				meta.spUpdate = "proc_SalesBeefConfigAdUpdate";		
				meta.spDelete = "proc_SalesBeefConfigAdDelete";
				meta.spLoadAll = "proc_SalesBeefConfigAdLoadAll";
				meta.spLoadByPrimaryKey = "proc_SalesBeefConfigAdLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SalesBeefConfigAdMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
