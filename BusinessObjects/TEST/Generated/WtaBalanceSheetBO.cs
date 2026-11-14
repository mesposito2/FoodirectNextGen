
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
	/// Encapsulates the 'wta_balance_sheet' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(WtaBalanceSheetBO))]	
	[XmlType("WtaBalanceSheetBO")]
	public partial class WtaBalanceSheetBO : esWtaBalanceSheetBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new WtaBalanceSheetBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 bsid)
		{
			var obj = new WtaBalanceSheetBO();
			obj.Bsid = bsid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 bsid, esSqlAccessType sqlAccessType)
		{
			var obj = new WtaBalanceSheetBO();
			obj.Bsid = bsid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("WtaBalanceSheetCollection")]
	public partial class WtaBalanceSheetCollection : esWtaBalanceSheetCollection, IEnumerable<WtaBalanceSheetBO>
	{
		public WtaBalanceSheetBO FindByPrimaryKey(System.Int32 bsid)
		{
			return this.SingleOrDefault(e => e.Bsid == bsid);
		}

		
				
	}



	[Serializable]	
	public partial class WtaBalanceSheetQuery : esWtaBalanceSheetQuery
	{
		public WtaBalanceSheetQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public WtaBalanceSheetQuery(string joinAlias, out WtaBalanceSheetQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "WtaBalanceSheetQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(WtaBalanceSheetQuery query)
		{
			return WtaBalanceSheetQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator WtaBalanceSheetQuery(string query)
		{
			return (WtaBalanceSheetQuery)WtaBalanceSheetQuery.SerializeHelper.FromXml(query, typeof(WtaBalanceSheetQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esWtaBalanceSheetBO : esEntity
	{
		public esWtaBalanceSheetBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 bsid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bsid);
			else
				return LoadByPrimaryKeyStoredProcedure(bsid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 bsid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(bsid);
			else
				return LoadByPrimaryKeyStoredProcedure(bsid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 bsid)
		{
			WtaBalanceSheetQuery query = new WtaBalanceSheetQuery();
			query.Where(query.Bsid == bsid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 bsid)
		{
			esParameters parms = new esParameters();
			parms.Add("Bsid", bsid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to wta_balance_sheet.bsid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Bsid
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Bsid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Bsid, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Bsid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.postdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Postdate
		{
			get
			{
				return base.GetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Postdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Postdate, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Postdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.duedate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Duedate
		{
			get
			{
				return base.GetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Duedate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Duedate, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Duedate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.wsalestaxdue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wsalestaxdue
		{
			get
			{
				return base.GetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Wsalestaxdue);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Wsalestaxdue, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Wsalestaxdue);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.wamountdue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Wamountdue
		{
			get
			{
				return base.GetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Wamountdue);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Wamountdue, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Wamountdue);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.salestaxdue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Salestaxdue
		{
			get
			{
				return base.GetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Salestaxdue);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Salestaxdue, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Salestaxdue);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.amountdue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Amountdue
		{
			get
			{
				return base.GetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Amountdue);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Amountdue, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Amountdue);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.amountpaid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Amountpaid
		{
			get
			{
				return base.GetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Amountpaid);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaBalanceSheetMetadata.ColumnNames.Amountpaid, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Amountpaid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.label
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Label
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Label);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Label, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Label);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Type
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Type, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.document_id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DocumentId
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.DocumentId);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.DocumentId, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.DocumentId);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.document_num
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DocumentNum
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.DocumentNum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.DocumentNum, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.DocumentNum);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Comment
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Comment);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Comment, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Comment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.createdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Createdate, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Createdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.createdby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Createdby, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Createdby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.createdbyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Createdbyname, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Createdbyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.lastupdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.Lastupdate, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Lastupdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.lastupdateby
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdateby
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Lastupdateby);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Lastupdateby, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Lastupdateby);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.lastupdatebyname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastupdatebyname
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Lastupdatebyname);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Lastupdatebyname, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Lastupdatebyname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.cvid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cvid
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Cvid);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Cvid, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Cvid);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.cvname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Cvname
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.Cvname);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.Cvname, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Cvname);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.qbexport
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Qbexport
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Qbexport);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.Qbexport, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.Qbexport);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.qbexport_date
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? QbexportDate
		{
			get
			{
				return base.GetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.QbexportDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaBalanceSheetMetadata.ColumnNames.QbexportDate, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.QbexportDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.qbexport_comment
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String QbexportComment
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.QbexportComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.QbexportComment, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.QbexportComment);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.qbexport_result
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? QbexportResult
		{
			get
			{
				return base.GetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.QbexportResult);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaBalanceSheetMetadata.ColumnNames.QbexportResult, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.QbexportResult);
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_balance_sheet.qbexport_txnid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String QbexportTxnid
		{
			get
			{
				return base.GetSystemString(WtaBalanceSheetMetadata.ColumnNames.QbexportTxnid);
			}
			
			set
			{
				if(base.SetSystemString(WtaBalanceSheetMetadata.ColumnNames.QbexportTxnid, value))
				{
					OnPropertyChanged(WtaBalanceSheetMetadata.PropertyNames.QbexportTxnid);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return WtaBalanceSheetMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public WtaBalanceSheetQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaBalanceSheetQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaBalanceSheetQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(WtaBalanceSheetQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaBalanceSheetQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private WtaBalanceSheetQuery query;		
	}



	[Serializable]
	abstract public partial class esWtaBalanceSheetCollection : esEntityCollection<WtaBalanceSheetBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaBalanceSheetMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "WtaBalanceSheetCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public WtaBalanceSheetQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaBalanceSheetQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(WtaBalanceSheetQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaBalanceSheetQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(WtaBalanceSheetQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((WtaBalanceSheetQuery)query);
		}

		#endregion
		
		private WtaBalanceSheetQuery query;
	}



	[Serializable]
	abstract public partial class esWtaBalanceSheetQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaBalanceSheetMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Bsid": return this.Bsid;
				case "Mid": return this.Mid;
				case "Postdate": return this.Postdate;
				case "Duedate": return this.Duedate;
				case "Wsalestaxdue": return this.Wsalestaxdue;
				case "Wamountdue": return this.Wamountdue;
				case "Salestaxdue": return this.Salestaxdue;
				case "Amountdue": return this.Amountdue;
				case "Amountpaid": return this.Amountpaid;
				case "Label": return this.Label;
				case "Type": return this.Type;
				case "DocumentId": return this.DocumentId;
				case "DocumentNum": return this.DocumentNum;
				case "Comment": return this.Comment;
				case "Createdate": return this.Createdate;
				case "Createdby": return this.Createdby;
				case "Createdbyname": return this.Createdbyname;
				case "Lastupdate": return this.Lastupdate;
				case "Lastupdateby": return this.Lastupdateby;
				case "Lastupdatebyname": return this.Lastupdatebyname;
				case "Cvid": return this.Cvid;
				case "Cvname": return this.Cvname;
				case "Qbexport": return this.Qbexport;
				case "QbexportDate": return this.QbexportDate;
				case "QbexportComment": return this.QbexportComment;
				case "QbexportResult": return this.QbexportResult;
				case "QbexportTxnid": return this.QbexportTxnid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Bsid
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Bsid, esSystemType.Int32); }
		} 
		
		public esQueryItem Mid
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Mid, esSystemType.String); }
		} 
		
		public esQueryItem Postdate
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Postdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Duedate
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Duedate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Wsalestaxdue
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Wsalestaxdue, esSystemType.Double); }
		} 
		
		public esQueryItem Wamountdue
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Wamountdue, esSystemType.Double); }
		} 
		
		public esQueryItem Salestaxdue
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Salestaxdue, esSystemType.Double); }
		} 
		
		public esQueryItem Amountdue
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Amountdue, esSystemType.Double); }
		} 
		
		public esQueryItem Amountpaid
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Amountpaid, esSystemType.Double); }
		} 
		
		public esQueryItem Label
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Label, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Type, esSystemType.Int32); }
		} 
		
		public esQueryItem DocumentId
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.DocumentId, esSystemType.Int32); }
		} 
		
		public esQueryItem DocumentNum
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.DocumentNum, esSystemType.Int32); }
		} 
		
		public esQueryItem Comment
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Comment, esSystemType.String); }
		} 
		
		public esQueryItem Createdate
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Createdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Createdby
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Createdby, esSystemType.String); }
		} 
		
		public esQueryItem Createdbyname
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Createdbyname, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdate
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Lastupdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Lastupdateby
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Lastupdateby, esSystemType.String); }
		} 
		
		public esQueryItem Lastupdatebyname
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Lastupdatebyname, esSystemType.String); }
		} 
		
		public esQueryItem Cvid
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Cvid, esSystemType.String); }
		} 
		
		public esQueryItem Cvname
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Cvname, esSystemType.String); }
		} 
		
		public esQueryItem Qbexport
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.Qbexport, esSystemType.Int32); }
		} 
		
		public esQueryItem QbexportDate
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.QbexportDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem QbexportComment
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.QbexportComment, esSystemType.String); }
		} 
		
		public esQueryItem QbexportResult
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.QbexportResult, esSystemType.Int32); }
		} 
		
		public esQueryItem QbexportTxnid
		{
			get { return new esQueryItem(this, WtaBalanceSheetMetadata.ColumnNames.QbexportTxnid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class WtaBalanceSheetBO : esWtaBalanceSheetBO
	{

		
		
	}
	



	[Serializable]
	public partial class WtaBalanceSheetMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaBalanceSheetMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Bsid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Bsid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Mid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Postdate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Postdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Duedate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Duedate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Wsalestaxdue, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Wsalestaxdue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Wamountdue, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Wamountdue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Salestaxdue, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Salestaxdue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Amountdue, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Amountdue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Amountpaid, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Amountpaid;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Label, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Label;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Type, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Type;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.DocumentId, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.DocumentId;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.DocumentNum, 12, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.DocumentNum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Comment, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Comment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Createdate, 14, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Createdby, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Createdbyname, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Lastupdate, 17, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Lastupdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Lastupdateby, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Lastupdateby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Lastupdatebyname, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Lastupdatebyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Cvid, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Cvid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Cvname, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Cvname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.Qbexport, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.Qbexport;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.QbexportDate, 23, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.QbexportDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.QbexportComment, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.QbexportComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.QbexportResult, 25, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.QbexportResult;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(WtaBalanceSheetMetadata.ColumnNames.QbexportTxnid, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaBalanceSheetMetadata.PropertyNames.QbexportTxnid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaBalanceSheetMetadata Meta()
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
			 public const string Bsid = "bsid";
			 public const string Mid = "mid";
			 public const string Postdate = "postdate";
			 public const string Duedate = "duedate";
			 public const string Wsalestaxdue = "wsalestaxdue";
			 public const string Wamountdue = "wamountdue";
			 public const string Salestaxdue = "salestaxdue";
			 public const string Amountdue = "amountdue";
			 public const string Amountpaid = "amountpaid";
			 public const string Label = "label";
			 public const string Type = "type";
			 public const string DocumentId = "document_id";
			 public const string DocumentNum = "document_num";
			 public const string Comment = "comment";
			 public const string Createdate = "createdate";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
			 public const string Lastupdate = "lastupdate";
			 public const string Lastupdateby = "lastupdateby";
			 public const string Lastupdatebyname = "lastupdatebyname";
			 public const string Cvid = "cvid";
			 public const string Cvname = "cvname";
			 public const string Qbexport = "qbexport";
			 public const string QbexportDate = "qbexport_date";
			 public const string QbexportComment = "qbexport_comment";
			 public const string QbexportResult = "qbexport_result";
			 public const string QbexportTxnid = "qbexport_txnid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Bsid = "Bsid";
			 public const string Mid = "Mid";
			 public const string Postdate = "Postdate";
			 public const string Duedate = "Duedate";
			 public const string Wsalestaxdue = "Wsalestaxdue";
			 public const string Wamountdue = "Wamountdue";
			 public const string Salestaxdue = "Salestaxdue";
			 public const string Amountdue = "Amountdue";
			 public const string Amountpaid = "Amountpaid";
			 public const string Label = "Label";
			 public const string Type = "Type";
			 public const string DocumentId = "DocumentId";
			 public const string DocumentNum = "DocumentNum";
			 public const string Comment = "Comment";
			 public const string Createdate = "Createdate";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
			 public const string Lastupdate = "Lastupdate";
			 public const string Lastupdateby = "Lastupdateby";
			 public const string Lastupdatebyname = "Lastupdatebyname";
			 public const string Cvid = "Cvid";
			 public const string Cvname = "Cvname";
			 public const string Qbexport = "Qbexport";
			 public const string QbexportDate = "QbexportDate";
			 public const string QbexportComment = "QbexportComment";
			 public const string QbexportResult = "QbexportResult";
			 public const string QbexportTxnid = "QbexportTxnid";
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
			lock (typeof(WtaBalanceSheetMetadata))
			{
				if(WtaBalanceSheetMetadata.mapDelegates == null)
				{
					WtaBalanceSheetMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaBalanceSheetMetadata.meta == null)
				{
					WtaBalanceSheetMetadata.meta = new WtaBalanceSheetMetadata();
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


				meta.AddTypeMap("Bsid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Postdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Duedate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Wsalestaxdue", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wamountdue", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Salestaxdue", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Amountdue", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Amountpaid", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Label", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DocumentId", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DocumentNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Comment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdateby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdatebyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cvid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cvname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qbexport", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("QbexportDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("QbexportComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("QbexportResult", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("QbexportTxnid", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "wta_balance_sheet";
				meta.Destination = "wta_balance_sheet";
				
				meta.spInsert = "proc_wta_balance_sheetInsert";				
				meta.spUpdate = "proc_wta_balance_sheetUpdate";		
				meta.spDelete = "proc_wta_balance_sheetDelete";
				meta.spLoadAll = "proc_wta_balance_sheetLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_balance_sheetLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaBalanceSheetMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
