
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
	/// Encapsulates the 'keyvalue' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(KeyvalueBO))]	
	[XmlType("KeyvalueBO")]
	public partial class KeyvalueBO : esKeyvalueBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new KeyvalueBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("KeyvalueCollection")]
	public partial class KeyvalueCollection : esKeyvalueCollection, IEnumerable<KeyvalueBO>
	{

		
				
	}



	[Serializable]	
	public partial class KeyvalueQuery : esKeyvalueQuery
	{
		public KeyvalueQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public KeyvalueQuery(string joinAlias, out KeyvalueQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "KeyvalueQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(KeyvalueQuery query)
		{
			return KeyvalueQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator KeyvalueQuery(string query)
		{
			return (KeyvalueQuery)KeyvalueQuery.SerializeHelper.FromXml(query, typeof(KeyvalueQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esKeyvalueBO : esEntity
	{
		public esKeyvalueBO()
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
			KeyvalueQuery query = new KeyvalueQuery();
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
		/// Maps to keyvalue.thiskey
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Thiskey
		{
			get
			{
				return base.GetSystemString(KeyvalueMetadata.ColumnNames.Thiskey);
			}
			
			set
			{
				if(base.SetSystemString(KeyvalueMetadata.ColumnNames.Thiskey, value))
				{
					OnPropertyChanged(KeyvalueMetadata.PropertyNames.Thiskey);
				}
			}
		}
		
		/// <summary>
		/// Maps to keyvalue.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Type
		{
			get
			{
				return base.GetSystemString(KeyvalueMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemString(KeyvalueMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(KeyvalueMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to keyvalue.value
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Value
		{
			get
			{
				return base.GetSystemString(KeyvalueMetadata.ColumnNames.Value);
			}
			
			set
			{
				if(base.SetSystemString(KeyvalueMetadata.ColumnNames.Value, value))
				{
					OnPropertyChanged(KeyvalueMetadata.PropertyNames.Value);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return KeyvalueMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public KeyvalueQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KeyvalueQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KeyvalueQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(KeyvalueQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((KeyvalueQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private KeyvalueQuery query;		
	}



	[Serializable]
	abstract public partial class esKeyvalueCollection : esEntityCollection<KeyvalueBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return KeyvalueMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "KeyvalueCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public KeyvalueQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new KeyvalueQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(KeyvalueQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new KeyvalueQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(KeyvalueQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((KeyvalueQuery)query);
		}

		#endregion
		
		private KeyvalueQuery query;
	}



	[Serializable]
	abstract public partial class esKeyvalueQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return KeyvalueMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Thiskey": return this.Thiskey;
				case "Type": return this.Type;
				case "Value": return this.Value;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Thiskey
		{
			get { return new esQueryItem(this, KeyvalueMetadata.ColumnNames.Thiskey, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, KeyvalueMetadata.ColumnNames.Type, esSystemType.String); }
		} 
		
		public esQueryItem Value
		{
			get { return new esQueryItem(this, KeyvalueMetadata.ColumnNames.Value, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class KeyvalueBO : esKeyvalueBO
	{

		
		
	}
	



	[Serializable]
	public partial class KeyvalueMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected KeyvalueMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(KeyvalueMetadata.ColumnNames.Thiskey, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = KeyvalueMetadata.PropertyNames.Thiskey;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KeyvalueMetadata.ColumnNames.Type, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = KeyvalueMetadata.PropertyNames.Type;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(KeyvalueMetadata.ColumnNames.Value, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = KeyvalueMetadata.PropertyNames.Value;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public KeyvalueMetadata Meta()
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
			 public const string Thiskey = "thiskey";
			 public const string Type = "type";
			 public const string Value = "value";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Thiskey = "Thiskey";
			 public const string Type = "Type";
			 public const string Value = "Value";
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
			lock (typeof(KeyvalueMetadata))
			{
				if(KeyvalueMetadata.mapDelegates == null)
				{
					KeyvalueMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (KeyvalueMetadata.meta == null)
				{
					KeyvalueMetadata.meta = new KeyvalueMetadata();
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


				meta.AddTypeMap("Thiskey", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Value", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "keyvalue";
				meta.Destination = "keyvalue";
				
				meta.spInsert = "proc_keyvalueInsert";				
				meta.spUpdate = "proc_keyvalueUpdate";		
				meta.spDelete = "proc_keyvalueDelete";
				meta.spLoadAll = "proc_keyvalueLoadAll";
				meta.spLoadByPrimaryKey = "proc_keyvalueLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private KeyvalueMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
