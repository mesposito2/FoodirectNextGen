
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
	/// Encapsulates the 'speed' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SpeedBO))]	
	[XmlType("SpeedBO")]
	public partial class SpeedBO : esSpeedBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SpeedBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 speedID)
		{
			var obj = new SpeedBO();
			obj.SpeedID = speedID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 speedID, esSqlAccessType sqlAccessType)
		{
			var obj = new SpeedBO();
			obj.SpeedID = speedID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SpeedCollection")]
	public partial class SpeedCollection : esSpeedCollection, IEnumerable<SpeedBO>
	{
		public SpeedBO FindByPrimaryKey(System.Int32 speedID)
		{
			return this.SingleOrDefault(e => e.SpeedID == speedID);
		}

		
				
	}



	[Serializable]	
	public partial class SpeedQuery : esSpeedQuery
	{
		public SpeedQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SpeedQuery(string joinAlias, out SpeedQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SpeedQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SpeedQuery query)
		{
			return SpeedQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SpeedQuery(string query)
		{
			return (SpeedQuery)SpeedQuery.SerializeHelper.FromXml(query, typeof(SpeedQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSpeedBO : esEntity
	{
		public esSpeedBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 speedID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(speedID);
			else
				return LoadByPrimaryKeyStoredProcedure(speedID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 speedID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(speedID);
			else
				return LoadByPrimaryKeyStoredProcedure(speedID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 speedID)
		{
			SpeedQuery query = new SpeedQuery();
			query.Where(query.SpeedID == speedID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 speedID)
		{
			esParameters parms = new esParameters();
			parms.Add("SpeedID", speedID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to speed.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Custid, value))
				{
					this._UsersBO = null;
					this.OnPropertyChanged("UsersBO");
					OnPropertyChanged(SpeedMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Productcode, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Scatid, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.lastdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastdate
		{
			get
			{
				return base.GetSystemDateTime(SpeedMetadata.ColumnNames.Lastdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SpeedMetadata.ColumnNames.Lastdate, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Lastdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.qty
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Qty
		{
			get
			{
				return base.GetSystemInt32(SpeedMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemInt32(SpeedMetadata.ColumnNames.Qty, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Qty);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.uom
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Uom
		{
			get
			{
				return base.GetSystemString(SpeedMetadata.ColumnNames.Uom);
			}
			
			set
			{
				if(base.SetSystemString(SpeedMetadata.ColumnNames.Uom, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Uom);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.lastprice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Lastprice
		{
			get
			{
				return base.GetSystemDouble(SpeedMetadata.ColumnNames.Lastprice);
			}
			
			set
			{
				if(base.SetSystemDouble(SpeedMetadata.ColumnNames.Lastprice, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.Lastprice);
				}
			}
		}
		
		/// <summary>
		/// Maps to speed.speedID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SpeedID
		{
			get
			{
				return base.GetSystemInt32(SpeedMetadata.ColumnNames.SpeedID);
			}
			
			set
			{
				if(base.SetSystemInt32(SpeedMetadata.ColumnNames.SpeedID, value))
				{
					OnPropertyChanged(SpeedMetadata.PropertyNames.SpeedID);
				}
			}
		}
		
		internal protected UsersBO _UsersBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SpeedMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SpeedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SpeedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SpeedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SpeedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SpeedQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SpeedQuery query;		
	}



	[Serializable]
	abstract public partial class esSpeedCollection : esEntityCollection<SpeedBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SpeedMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SpeedCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SpeedQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SpeedQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SpeedQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SpeedQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SpeedQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SpeedQuery)query);
		}

		#endregion
		
		private SpeedQuery query;
	}



	[Serializable]
	abstract public partial class esSpeedQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SpeedMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Productcode": return this.Productcode;
				case "Scatid": return this.Scatid;
				case "Lastdate": return this.Lastdate;
				case "Qty": return this.Qty;
				case "Uom": return this.Uom;
				case "Lastprice": return this.Lastprice;
				case "SpeedID": return this.SpeedID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem Lastdate
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Lastdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Qty
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Qty, esSystemType.Int32); }
		} 
		
		public esQueryItem Uom
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Uom, esSystemType.String); }
		} 
		
		public esQueryItem Lastprice
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.Lastprice, esSystemType.Double); }
		} 
		
		public esQueryItem SpeedID
		{
			get { return new esQueryItem(this, SpeedMetadata.ColumnNames.SpeedID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class SpeedBO : esSpeedBO
	{

		
		#region UsersBO - Many To One (FK_speed_custid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBO()
		{
		    return this._UsersBO != null ? true : false;
		}
		

		[DataMember(Name="UsersBO", EmitDefaultValue = false)]
					
		public UsersBO UsersBO
		{
			get
			{
                if (this._UsersBO == null)
                {
                    this._UsersBO = new UsersBO();
                    this._UsersBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("UsersBO", this._UsersBO);

					if(this._UsersBO == null && Custid != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._UsersBO.Query.Where(this._UsersBO.Query.Custid == this.Custid);
							this._UsersBO.Query.Load();
                        }
                    }
                }

				return this._UsersBO;
			}
			
			set
			{
				this.RemovePreSave("UsersBO");
				

				if(value == null)
				{
					this.Custid = null;
					this._UsersBO = null;
				}
				else
				{
					this.Custid = value.Custid;
					this._UsersBO = value;
					this.SetPreSave("UsersBO", this._UsersBO);
				}
				
			}
		}
		#endregion
		

		
		
	}
	



	[Serializable]
	public partial class SpeedMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SpeedMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Productcode, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Scatid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Lastdate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SpeedMetadata.PropertyNames.Lastdate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Qty, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SpeedMetadata.PropertyNames.Qty;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Uom, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SpeedMetadata.PropertyNames.Uom;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.Lastprice, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = SpeedMetadata.PropertyNames.Lastprice;
			c.NumericPrecision = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SpeedMetadata.ColumnNames.SpeedID, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SpeedMetadata.PropertyNames.SpeedID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SpeedMetadata Meta()
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
			 public const string Productcode = "productcode";
			 public const string Scatid = "scatid";
			 public const string Lastdate = "lastdate";
			 public const string Qty = "qty";
			 public const string Uom = "uom";
			 public const string Lastprice = "lastprice";
			 public const string SpeedID = "speedID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Productcode = "Productcode";
			 public const string Scatid = "Scatid";
			 public const string Lastdate = "Lastdate";
			 public const string Qty = "Qty";
			 public const string Uom = "Uom";
			 public const string Lastprice = "Lastprice";
			 public const string SpeedID = "SpeedID";
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
			lock (typeof(SpeedMetadata))
			{
				if(SpeedMetadata.mapDelegates == null)
				{
					SpeedMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SpeedMetadata.meta == null)
				{
					SpeedMetadata.meta = new SpeedMetadata();
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
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastdate", new esTypeMap("smalldatetime", "System.DateTime"));
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Uom", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SpeedID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "speed";
				meta.Destination = "speed";
				
				meta.spInsert = "proc_speedInsert";				
				meta.spUpdate = "proc_speedUpdate";		
				meta.spDelete = "proc_speedDelete";
				meta.spLoadAll = "proc_speedLoadAll";
				meta.spLoadByPrimaryKey = "proc_speedLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SpeedMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
