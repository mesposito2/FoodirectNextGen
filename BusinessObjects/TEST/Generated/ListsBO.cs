
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
	/// Encapsulates the 'lists' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ListsBO))]	
	[XmlType("ListsBO")]
	public partial class ListsBO : esListsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ListsBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 listsID)
		{
			var obj = new ListsBO();
			obj.ListsID = listsID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 listsID, esSqlAccessType sqlAccessType)
		{
			var obj = new ListsBO();
			obj.ListsID = listsID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ListsCollection")]
	public partial class ListsCollection : esListsCollection, IEnumerable<ListsBO>
	{
		public ListsBO FindByPrimaryKey(System.Int32 listsID)
		{
			return this.SingleOrDefault(e => e.ListsID == listsID);
		}

		
				
	}



	[Serializable]	
	public partial class ListsQuery : esListsQuery
	{
		public ListsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ListsQuery(string joinAlias, out ListsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ListsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ListsQuery query)
		{
			return ListsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ListsQuery(string query)
		{
			return (ListsQuery)ListsQuery.SerializeHelper.FromXml(query, typeof(ListsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esListsBO : esEntity
	{
		public esListsBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 listsID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(listsID);
			else
				return LoadByPrimaryKeyStoredProcedure(listsID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 listsID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(listsID);
			else
				return LoadByPrimaryKeyStoredProcedure(listsID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 listsID)
		{
			ListsQuery query = new ListsQuery();
			query.Where(query.ListsID == listsID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 listsID)
		{
			esParameters parms = new esParameters();
			parms.Add("ListsID", listsID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to lists.lid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Lid
		{
			get
			{
				return base.GetSystemInt32(ListsMetadata.ColumnNames.Lid);
			}
			
			set
			{
				if(base.SetSystemInt32(ListsMetadata.ColumnNames.Lid, value))
				{
					OnPropertyChanged(ListsMetadata.PropertyNames.Lid);
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lname
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lname);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lname, value))
				{
					OnPropertyChanged(ListsMetadata.PropertyNames.Lname);
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lvalue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lvalue
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lvalue);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lvalue, value))
				{
					OnPropertyChanged(ListsMetadata.PropertyNames.Lvalue);
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.lvalue2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lvalue2
		{
			get
			{
				return base.GetSystemString(ListsMetadata.ColumnNames.Lvalue2);
			}
			
			set
			{
				if(base.SetSystemString(ListsMetadata.ColumnNames.Lvalue2, value))
				{
					OnPropertyChanged(ListsMetadata.PropertyNames.Lvalue2);
				}
			}
		}
		
		/// <summary>
		/// Maps to lists.listsID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ListsID
		{
			get
			{
				return base.GetSystemInt32(ListsMetadata.ColumnNames.ListsID);
			}
			
			set
			{
				if(base.SetSystemInt32(ListsMetadata.ColumnNames.ListsID, value))
				{
					OnPropertyChanged(ListsMetadata.PropertyNames.ListsID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ListsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ListsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ListsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ListsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ListsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ListsQuery query;		
	}



	[Serializable]
	abstract public partial class esListsCollection : esEntityCollection<ListsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ListsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ListsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ListsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ListsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ListsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ListsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ListsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ListsQuery)query);
		}

		#endregion
		
		private ListsQuery query;
	}



	[Serializable]
	abstract public partial class esListsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ListsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Lid": return this.Lid;
				case "Lname": return this.Lname;
				case "Lvalue": return this.Lvalue;
				case "Lvalue2": return this.Lvalue2;
				case "ListsID": return this.ListsID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Lid
		{
			get { return new esQueryItem(this, ListsMetadata.ColumnNames.Lid, esSystemType.Int32); }
		} 
		
		public esQueryItem Lname
		{
			get { return new esQueryItem(this, ListsMetadata.ColumnNames.Lname, esSystemType.String); }
		} 
		
		public esQueryItem Lvalue
		{
			get { return new esQueryItem(this, ListsMetadata.ColumnNames.Lvalue, esSystemType.String); }
		} 
		
		public esQueryItem Lvalue2
		{
			get { return new esQueryItem(this, ListsMetadata.ColumnNames.Lvalue2, esSystemType.String); }
		} 
		
		public esQueryItem ListsID
		{
			get { return new esQueryItem(this, ListsMetadata.ColumnNames.ListsID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ListsBO : esListsBO
	{

		
		
	}
	



	[Serializable]
	public partial class ListsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ListsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ListsMetadata.PropertyNames.Lid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lvalue, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lvalue;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.Lvalue2, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ListsMetadata.PropertyNames.Lvalue2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ListsMetadata.ColumnNames.ListsID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ListsMetadata.PropertyNames.ListsID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ListsMetadata Meta()
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
			 public const string Lid = "lid";
			 public const string Lname = "lname";
			 public const string Lvalue = "lvalue";
			 public const string Lvalue2 = "lvalue2";
			 public const string ListsID = "listsID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Lid = "Lid";
			 public const string Lname = "Lname";
			 public const string Lvalue = "Lvalue";
			 public const string Lvalue2 = "Lvalue2";
			 public const string ListsID = "ListsID";
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
			lock (typeof(ListsMetadata))
			{
				if(ListsMetadata.mapDelegates == null)
				{
					ListsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ListsMetadata.meta == null)
				{
					ListsMetadata.meta = new ListsMetadata();
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


				meta.AddTypeMap("Lid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lvalue", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lvalue2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ListsID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "lists";
				meta.Destination = "lists";
				
				meta.spInsert = "proc_listsInsert";				
				meta.spUpdate = "proc_listsUpdate";		
				meta.spDelete = "proc_listsDelete";
				meta.spLoadAll = "proc_listsLoadAll";
				meta.spLoadByPrimaryKey = "proc_listsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ListsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
