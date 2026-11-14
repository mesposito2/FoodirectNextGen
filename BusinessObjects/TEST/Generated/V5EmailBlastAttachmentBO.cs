
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:16 PM
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
	/// Encapsulates the 'V5EmailBlastAttachment' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5EmailBlastAttachmentBO))]	
	[XmlType("V5EmailBlastAttachmentBO")]
	public partial class V5EmailBlastAttachmentBO : esV5EmailBlastAttachmentBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5EmailBlastAttachmentBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 emailBlastAttachmentID)
		{
			var obj = new V5EmailBlastAttachmentBO();
			obj.EmailBlastAttachmentID = emailBlastAttachmentID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 emailBlastAttachmentID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5EmailBlastAttachmentBO();
			obj.EmailBlastAttachmentID = emailBlastAttachmentID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5EmailBlastAttachmentCollection")]
	public partial class V5EmailBlastAttachmentCollection : esV5EmailBlastAttachmentCollection, IEnumerable<V5EmailBlastAttachmentBO>
	{
		public V5EmailBlastAttachmentBO FindByPrimaryKey(System.Int32 emailBlastAttachmentID)
		{
			return this.SingleOrDefault(e => e.EmailBlastAttachmentID == emailBlastAttachmentID);
		}

		
				
	}



	[Serializable]	
	public partial class V5EmailBlastAttachmentQuery : esV5EmailBlastAttachmentQuery
	{
		public V5EmailBlastAttachmentQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5EmailBlastAttachmentQuery(string joinAlias, out V5EmailBlastAttachmentQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5EmailBlastAttachmentQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5EmailBlastAttachmentQuery query)
		{
			return V5EmailBlastAttachmentQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5EmailBlastAttachmentQuery(string query)
		{
			return (V5EmailBlastAttachmentQuery)V5EmailBlastAttachmentQuery.SerializeHelper.FromXml(query, typeof(V5EmailBlastAttachmentQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5EmailBlastAttachmentBO : esEntity
	{
		public esV5EmailBlastAttachmentBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 emailBlastAttachmentID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastAttachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastAttachmentID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 emailBlastAttachmentID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastAttachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastAttachmentID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 emailBlastAttachmentID)
		{
			V5EmailBlastAttachmentQuery query = new V5EmailBlastAttachmentQuery();
			query.Where(query.EmailBlastAttachmentID == emailBlastAttachmentID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 emailBlastAttachmentID)
		{
			esParameters parms = new esParameters();
			parms.Add("EmailBlastAttachmentID", emailBlastAttachmentID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.EmailBlastAttachmentID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmailBlastAttachmentID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastAttachmentID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.EmailBlastID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.CreatedByDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.CreatedByDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.AttachmentPath
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AttachmentPath
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.AttachmentPath);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlastAttachment.OriginalFileName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String OriginalFileName
		{
			get
			{
				return base.GetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, value))
				{
					OnPropertyChanged(V5EmailBlastAttachmentMetadata.PropertyNames.OriginalFileName);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastAttachmentMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5EmailBlastAttachmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastAttachmentQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5EmailBlastAttachmentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5EmailBlastAttachmentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5EmailBlastAttachmentQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5EmailBlastAttachmentQuery query;		
	}



	[Serializable]
	abstract public partial class esV5EmailBlastAttachmentCollection : esEntityCollection<V5EmailBlastAttachmentBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastAttachmentMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5EmailBlastAttachmentCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5EmailBlastAttachmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastAttachmentQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5EmailBlastAttachmentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastAttachmentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5EmailBlastAttachmentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5EmailBlastAttachmentQuery)query);
		}

		#endregion
		
		private V5EmailBlastAttachmentQuery query;
	}



	[Serializable]
	abstract public partial class esV5EmailBlastAttachmentQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastAttachmentMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "EmailBlastAttachmentID": return this.EmailBlastAttachmentID;
				case "EmailBlastID": return this.EmailBlastID;
				case "CreatedByDate": return this.CreatedByDate;
				case "CreatedBy": return this.CreatedBy;
				case "AttachmentPath": return this.AttachmentPath;
				case "OriginalFileName": return this.OriginalFileName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem EmailBlastAttachmentID
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, esSystemType.Int32); }
		} 
		
		public esQueryItem EmailBlastID
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, esSystemType.Int32); }
		} 
		
		public esQueryItem CreatedByDate
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem AttachmentPath
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, esSystemType.String); }
		} 
		
		public esQueryItem OriginalFileName
		{
			get { return new esQueryItem(this, V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class V5EmailBlastAttachmentBO : esV5EmailBlastAttachmentBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5EmailBlastAttachmentMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5EmailBlastAttachmentMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastAttachmentID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastAttachmentID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.EmailBlastID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.EmailBlastID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedByDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.CreatedByDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.CreatedBy, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.AttachmentPath, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.AttachmentPath;
			c.CharacterMaxLength = 500;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastAttachmentMetadata.ColumnNames.OriginalFileName, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastAttachmentMetadata.PropertyNames.OriginalFileName;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5EmailBlastAttachmentMetadata Meta()
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
			 public const string EmailBlastAttachmentID = "EmailBlastAttachmentID";
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string OriginalFileName = "OriginalFileName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string EmailBlastAttachmentID = "EmailBlastAttachmentID";
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string OriginalFileName = "OriginalFileName";
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
			lock (typeof(V5EmailBlastAttachmentMetadata))
			{
				if(V5EmailBlastAttachmentMetadata.mapDelegates == null)
				{
					V5EmailBlastAttachmentMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5EmailBlastAttachmentMetadata.meta == null)
				{
					V5EmailBlastAttachmentMetadata.meta = new V5EmailBlastAttachmentMetadata();
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


				meta.AddTypeMap("EmailBlastAttachmentID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("EmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AttachmentPath", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OriginalFileName", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "V5EmailBlastAttachment";
				meta.Destination = "V5EmailBlastAttachment";
				
				meta.spInsert = "proc_V5EmailBlastAttachmentInsert";				
				meta.spUpdate = "proc_V5EmailBlastAttachmentUpdate";		
				meta.spDelete = "proc_V5EmailBlastAttachmentDelete";
				meta.spLoadAll = "proc_V5EmailBlastAttachmentLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5EmailBlastAttachmentLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5EmailBlastAttachmentMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
