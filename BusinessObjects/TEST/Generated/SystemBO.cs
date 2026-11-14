
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
	/// Encapsulates the 'system' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(SystemBO))]	
	[XmlType("SystemBO")]
	public partial class SystemBO : esSystemBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new SystemBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Guid systemID)
		{
			var obj = new SystemBO();
			obj.SystemID = systemID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Guid systemID, esSqlAccessType sqlAccessType)
		{
			var obj = new SystemBO();
			obj.SystemID = systemID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SystemCollection")]
	public partial class SystemCollection : esSystemCollection, IEnumerable<SystemBO>
	{
		public SystemBO FindByPrimaryKey(System.Guid systemID)
		{
			return this.SingleOrDefault(e => e.SystemID == systemID);
		}

		
				
	}



	[Serializable]	
	public partial class SystemQuery : esSystemQuery
	{
		public SystemQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SystemQuery(string joinAlias, out SystemQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SystemQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SystemQuery query)
		{
			return SystemQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SystemQuery(string query)
		{
			return (SystemQuery)SystemQuery.SerializeHelper.FromXml(query, typeof(SystemQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSystemBO : esEntity
	{
		public esSystemBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Guid systemID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(systemID);
			else
				return LoadByPrimaryKeyStoredProcedure(systemID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Guid systemID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(systemID);
			else
				return LoadByPrimaryKeyStoredProcedure(systemID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Guid systemID)
		{
			SystemQuery query = new SystemQuery();
			query.Where(query.SystemID == systemID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Guid systemID)
		{
			esParameters parms = new esParameters();
			parms.Add("SystemID", systemID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to system.str1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Str1
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str1);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str1, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Str1);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.str2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Str2
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str2);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str2, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Str2);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.str3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Str3
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str3);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str3, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Str3);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Bool1
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool1);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool1, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Bool1);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Bool2
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool2);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool2, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Bool2);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Bool3
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool3);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool3, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Bool3);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Int1
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int1);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int1, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Int1);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Int2
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int2);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int2, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Int2);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Int3
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int3);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int3, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Int3);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Dbl1
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl1);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl1, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Dbl1);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Dbl2
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl2);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl2, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Dbl2);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Dbl3
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl3);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl3, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Dbl3);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.displaypriceexpire
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Displaypriceexpire
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.Displaypriceexpire);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.Displaypriceexpire, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Displaypriceexpire);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfposcdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastfposcdate
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.Lastfposcdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.Lastfposcdate, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Lastfposcdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfposversion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Lastfposversion
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Lastfposversion);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Lastfposversion, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Lastfposversion);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfdpfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Lastfdpfile
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Lastfdpfile);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Lastfdpfile, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.Lastfdpfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.systemID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Guid? SystemID
		{
			get
			{
				return base.GetSystemGuid(SystemMetadata.ColumnNames.SystemID);
			}
			
			set
			{
				if(base.SetSystemGuid(SystemMetadata.ColumnNames.SystemID, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.SystemID);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.systemUCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SystemUCODE
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.SystemUCODE);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.SystemUCODE, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.SystemUCODE);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastUpdatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.LastUpdatedBy, value))
				{
					OnPropertyChanged(SystemMetadata.PropertyNames.LastUpdatedBy);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SystemMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SystemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SystemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SystemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(SystemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SystemQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private SystemQuery query;		
	}



	[Serializable]
	abstract public partial class esSystemCollection : esEntityCollection<SystemBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SystemMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SystemCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SystemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SystemQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SystemQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SystemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SystemQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SystemQuery)query);
		}

		#endregion
		
		private SystemQuery query;
	}



	[Serializable]
	abstract public partial class esSystemQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SystemMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Str1": return this.Str1;
				case "Str2": return this.Str2;
				case "Str3": return this.Str3;
				case "Bool1": return this.Bool1;
				case "Bool2": return this.Bool2;
				case "Bool3": return this.Bool3;
				case "Int1": return this.Int1;
				case "Int2": return this.Int2;
				case "Int3": return this.Int3;
				case "Dbl1": return this.Dbl1;
				case "Dbl2": return this.Dbl2;
				case "Dbl3": return this.Dbl3;
				case "Displaypriceexpire": return this.Displaypriceexpire;
				case "Lastfposcdate": return this.Lastfposcdate;
				case "Lastfposversion": return this.Lastfposversion;
				case "Lastfdpfile": return this.Lastfdpfile;
				case "SystemID": return this.SystemID;
				case "SystemUCODE": return this.SystemUCODE;
				case "LastUpdate": return this.LastUpdate;
				case "LastUpdatedBy": return this.LastUpdatedBy;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Str1
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Str1, esSystemType.String); }
		} 
		
		public esQueryItem Str2
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Str2, esSystemType.String); }
		} 
		
		public esQueryItem Str3
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Str3, esSystemType.String); }
		} 
		
		public esQueryItem Bool1
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Bool1, esSystemType.Boolean); }
		} 
		
		public esQueryItem Bool2
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Bool2, esSystemType.Boolean); }
		} 
		
		public esQueryItem Bool3
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Bool3, esSystemType.Boolean); }
		} 
		
		public esQueryItem Int1
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Int1, esSystemType.Int32); }
		} 
		
		public esQueryItem Int2
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Int2, esSystemType.Int32); }
		} 
		
		public esQueryItem Int3
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Int3, esSystemType.Int32); }
		} 
		
		public esQueryItem Dbl1
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl1, esSystemType.Int32); }
		} 
		
		public esQueryItem Dbl2
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl2, esSystemType.Int32); }
		} 
		
		public esQueryItem Dbl3
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl3, esSystemType.Int32); }
		} 
		
		public esQueryItem Displaypriceexpire
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Displaypriceexpire, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastfposcdate
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfposcdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastfposversion
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfposversion, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastfdpfile
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfdpfile, esSystemType.Int32); }
		} 
		
		public esQueryItem SystemID
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.SystemID, esSystemType.Guid); }
		} 
		
		public esQueryItem SystemUCODE
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.SystemUCODE, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.LastUpdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get { return new esQueryItem(this, SystemMetadata.ColumnNames.LastUpdatedBy, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class SystemBO : esSystemBO
	{

		
		
	}
	



	[Serializable]
	public partial class SystemMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SystemMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str1, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str1;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str2, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str2;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str3, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str3;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool1, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool2, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool3, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int1, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int1;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int2, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int2;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int3, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int3;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl1, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl1;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl2, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl2;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl3, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl3;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Displaypriceexpire, 12, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.Displaypriceexpire;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfposcdate, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfposcdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfposversion, 14, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfposversion;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfdpfile, 15, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfdpfile;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.SystemID, 16, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = SystemMetadata.PropertyNames.SystemID;
			c.IsInPrimaryKey = true;
			c.HasDefault = true;
			c.Default = @"(newid())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.SystemUCODE, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.SystemUCODE;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.LastUpdate, 18, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.LastUpdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.LastUpdatedBy, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SystemMetadata Meta()
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
			 public const string Str1 = "str1";
			 public const string Str2 = "str2";
			 public const string Str3 = "str3";
			 public const string Bool1 = "bool1";
			 public const string Bool2 = "bool2";
			 public const string Bool3 = "bool3";
			 public const string Int1 = "int1";
			 public const string Int2 = "int2";
			 public const string Int3 = "int3";
			 public const string Dbl1 = "dbl1";
			 public const string Dbl2 = "dbl2";
			 public const string Dbl3 = "dbl3";
			 public const string Displaypriceexpire = "displaypriceexpire";
			 public const string Lastfposcdate = "lastfposcdate";
			 public const string Lastfposversion = "lastfposversion";
			 public const string Lastfdpfile = "lastfdpfile";
			 public const string SystemID = "systemID";
			 public const string SystemUCODE = "systemUCODE";
			 public const string LastUpdate = "lastUpdate";
			 public const string LastUpdatedBy = "lastUpdatedBy";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Str1 = "Str1";
			 public const string Str2 = "Str2";
			 public const string Str3 = "Str3";
			 public const string Bool1 = "Bool1";
			 public const string Bool2 = "Bool2";
			 public const string Bool3 = "Bool3";
			 public const string Int1 = "Int1";
			 public const string Int2 = "Int2";
			 public const string Int3 = "Int3";
			 public const string Dbl1 = "Dbl1";
			 public const string Dbl2 = "Dbl2";
			 public const string Dbl3 = "Dbl3";
			 public const string Displaypriceexpire = "Displaypriceexpire";
			 public const string Lastfposcdate = "Lastfposcdate";
			 public const string Lastfposversion = "Lastfposversion";
			 public const string Lastfdpfile = "Lastfdpfile";
			 public const string SystemID = "SystemID";
			 public const string SystemUCODE = "SystemUCODE";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(SystemMetadata))
			{
				if(SystemMetadata.mapDelegates == null)
				{
					SystemMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SystemMetadata.meta == null)
				{
					SystemMetadata.meta = new SystemMetadata();
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


				meta.AddTypeMap("Str1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Str2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Str3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Bool1", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Bool2", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Bool3", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Int1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Int2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Int3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Displaypriceexpire", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastfposcdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastfposversion", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lastfdpfile", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SystemID", new esTypeMap("uniqueidentifier", "System.Guid"));
				meta.AddTypeMap("SystemUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "system";
				meta.Destination = "system";
				
				meta.spInsert = "proc_systemInsert";				
				meta.spUpdate = "proc_systemUpdate";		
				meta.spDelete = "proc_systemDelete";
				meta.spLoadAll = "proc_systemLoadAll";
				meta.spLoadByPrimaryKey = "proc_systemLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SystemMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
