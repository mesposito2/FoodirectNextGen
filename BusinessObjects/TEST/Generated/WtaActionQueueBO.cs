
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
	/// Encapsulates the 'wta_action_queue' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaActionQueueBO))]	
	[XmlType("WtaActionQueueBO")]
	public partial class WtaActionQueueBO : esWtaActionQueueBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaActionQueueBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaActionQueueCollection")]
	public partial class WtaActionQueueCollection : esWtaActionQueueCollection, IEnumerable<WtaActionQueueBO>
	{

		
				
	}



	[Serializable]	
	public partial class WtaActionQueueQuery : esWtaActionQueueQuery
	{
		public WtaActionQueueQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaActionQueueQuery(string joinAlias, out WtaActionQueueQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaActionQueueQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaActionQueueQuery query)
		{
			return WtaActionQueueQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaActionQueueQuery(string query)
		{
			return (WtaActionQueueQuery)WtaActionQueueQuery.SerializeHelper.FromXml(query, typeof(WtaActionQueueQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaActionQueueBO : esEntity
	{
		public esWtaActionQueueBO()
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
			WtaActionQueueQuery query = new WtaActionQueueQuery();
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
		/// Maps to wta_action_queue.qid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Qid
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.Qid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.Qid, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Qid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Status);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.actiondatetime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Actiondatetime
		{
			get
			{
				return base.GetSystemDateTime(WtaActionQueueMetadata.ColumnNames.Actiondatetime);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaActionQueueMetadata.ColumnNames.Actiondatetime, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Actiondatetime);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.document_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DocumentType
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.DocumentType);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.DocumentType, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.DocumentType);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.document_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DocumentId
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.DocumentId);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.DocumentId, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.DocumentId);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.action
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Action
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.Action);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.Action, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Action);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.lastactionresult
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Lastactionresult
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.Lastactionresult);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.Lastactionresult, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Lastactionresult);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.lastactiondatetime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastactiondatetime
		{
			get
			{
				return base.GetSystemDateTime(WtaActionQueueMetadata.ColumnNames.Lastactiondatetime);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaActionQueueMetadata.ColumnNames.Lastactiondatetime, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Lastactiondatetime);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.actionlog
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Actionlog
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Actionlog);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Actionlog, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Actionlog);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.xfile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Xfile
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Xfile);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Xfile, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Xfile);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.bizname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Bizname
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Bizname);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Bizname, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Bizname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.contactname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Contactname, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Contactname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Email);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.telephone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Telephone
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Telephone);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Telephone, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Telephone);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Fax);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Type
		{
			get
			{
				return base.GetSystemInt32(WtaActionQueueMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaActionQueueMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_action_queue.runinterval
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Runinterval
		{
			get
			{
				return base.GetSystemString(WtaActionQueueMetadata.ColumnNames.Runinterval);
			}
			
			set
			{
				if(base.SetSystemString(WtaActionQueueMetadata.ColumnNames.Runinterval, value))
				{
					OnPropertyChanged(WtaActionQueueMetadata.PropertyNames.Runinterval);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaActionQueueMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaActionQueueQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaActionQueueQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaActionQueueQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaActionQueueQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaActionQueueQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaActionQueueQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaActionQueueCollection : esEntityCollection<WtaActionQueueBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaActionQueueMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaActionQueueCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaActionQueueQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaActionQueueQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaActionQueueQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaActionQueueQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaActionQueueQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaActionQueueQuery)query);
		}

		#endregion
		
		private WtaActionQueueQuery query;
	}



	[Serializable]
	abstract public partial class esWtaActionQueueQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaActionQueueMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Qid": return this.Qid;
				case "Status": return this.Status;
				case "Actiondatetime": return this.Actiondatetime;
				case "DocumentType": return this.DocumentType;
				case "DocumentId": return this.DocumentId;
				case "Action": return this.Action;
				case "Lastactionresult": return this.Lastactionresult;
				case "Lastactiondatetime": return this.Lastactiondatetime;
				case "Actionlog": return this.Actionlog;
				case "Xfile": return this.Xfile;
				case "Custid": return this.Custid;
				case "Mid": return this.Mid;
				case "Bizname": return this.Bizname;
				case "Contactname": return this.Contactname;
				case "Email": return this.Email;
				case "Telephone": return this.Telephone;
				case "Fax": return this.Fax;
				case "Type": return this.Type;
				case "Runinterval": return this.Runinterval;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Qid
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Qid, esSystemType.Int32); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Status, esSystemType.Int32); }
		} 
		
		public esQueryItem Actiondatetime
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Actiondatetime, esSystemType.DateTime); }
		} 
		
		public esQueryItem DocumentType
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.DocumentType, esSystemType.Int32); }
		} 
		
		public esQueryItem DocumentId
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.DocumentId, esSystemType.String); }
		} 
		
		public esQueryItem Action
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Action, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastactionresult
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Lastactionresult, esSystemType.Int32); }
		} 
		
		public esQueryItem Lastactiondatetime
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Lastactiondatetime, esSystemType.DateTime); }
		} 
		
		public esQueryItem Actionlog
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Actionlog, esSystemType.String); }
		} 
		
		public esQueryItem Xfile
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Xfile, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Bizname
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Bizname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Telephone
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Telephone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Type, esSystemType.Int32); }
		} 
		
		public esQueryItem Runinterval
		{
			get { return new esQueryItem(this, WtaActionQueueMetadata.ColumnNames.Runinterval, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaActionQueueBO : esWtaActionQueueBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaActionQueueMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaActionQueueMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Qid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Qid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Status, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Actiondatetime, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Actiondatetime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.DocumentType, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.DocumentType;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.DocumentId, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.DocumentId;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Action, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Action;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Lastactionresult, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Lastactionresult;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Lastactiondatetime, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Lastactiondatetime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Actionlog, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Actionlog;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Xfile, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Xfile;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Custid, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Mid, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Bizname, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Bizname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Contactname, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Contactname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Email, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Telephone, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Telephone;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Fax, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Type, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Type;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaActionQueueMetadata.ColumnNames.Runinterval, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaActionQueueMetadata.PropertyNames.Runinterval;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaActionQueueMetadata Meta()
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
			 public const string Qid = "qid";
			 public const string Status = "status";
			 public const string Actiondatetime = "actiondatetime";
			 public const string DocumentType = "document_type";
			 public const string DocumentId = "document_id";
			 public const string Action = "action";
			 public const string Lastactionresult = "lastactionresult";
			 public const string Lastactiondatetime = "lastactiondatetime";
			 public const string Actionlog = "actionlog";
			 public const string Xfile = "xfile";
			 public const string Custid = "custid";
			 public const string Mid = "mid";
			 public const string Bizname = "bizname";
			 public const string Contactname = "contactname";
			 public const string Email = "email";
			 public const string Telephone = "telephone";
			 public const string Fax = "fax";
			 public const string Type = "type";
			 public const string Runinterval = "runinterval";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Qid = "Qid";
			 public const string Status = "Status";
			 public const string Actiondatetime = "Actiondatetime";
			 public const string DocumentType = "DocumentType";
			 public const string DocumentId = "DocumentId";
			 public const string Action = "Action";
			 public const string Lastactionresult = "Lastactionresult";
			 public const string Lastactiondatetime = "Lastactiondatetime";
			 public const string Actionlog = "Actionlog";
			 public const string Xfile = "Xfile";
			 public const string Custid = "Custid";
			 public const string Mid = "Mid";
			 public const string Bizname = "Bizname";
			 public const string Contactname = "Contactname";
			 public const string Email = "Email";
			 public const string Telephone = "Telephone";
			 public const string Fax = "Fax";
			 public const string Type = "Type";
			 public const string Runinterval = "Runinterval";
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
			lock (typeof(WtaActionQueueMetadata))
			{
				if(WtaActionQueueMetadata.mapDelegates == null)
				{
					WtaActionQueueMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaActionQueueMetadata.meta == null)
				{
					WtaActionQueueMetadata.meta = new WtaActionQueueMetadata();
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


				meta.AddTypeMap("Qid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Actiondatetime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("DocumentType", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DocumentId", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Action", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lastactionresult", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lastactiondatetime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Actionlog", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Xfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Bizname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Contactname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telephone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Runinterval", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_action_queue";
				meta.Destination = "wta_action_queue";
				
				meta.spInsert = "proc_wta_action_queueInsert";				
				meta.spUpdate = "proc_wta_action_queueUpdate";		
				meta.spDelete = "proc_wta_action_queueDelete";
				meta.spLoadAll = "proc_wta_action_queueLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_action_queueLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaActionQueueMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
