/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 6/18/2018 9:17:06 AM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{

	[Serializable]
	abstract public class esWtaPoCollection : esEntityCollection
	{
		public esWtaPoCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "WtaPoCollection";
		}

		#region Query Logic
		protected void InitQuery(esWtaPoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esWtaPoQuery);
		}
		#endregion
		
		virtual public WtaPoBO DetachEntity(WtaPoBO entity)
		{
			return base.DetachEntity(entity) as WtaPoBO;
		}
		
		virtual public WtaPoBO AttachEntity(WtaPoBO entity)
		{
			return base.AttachEntity(entity) as WtaPoBO;
		}
		
		virtual public void Combine(WtaPoCollection collection)
		{
			base.Combine(collection);
		}
		
		new public WtaPoBO this[int index]
		{
			get
			{
				return base[index] as WtaPoBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(WtaPoBO);
		}
	}



	[Serializable]
	abstract public class esWtaPoBO : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esWtaPoQuery GetDynamicQuery()
		{
			return null;
		}

		public esWtaPoBO()
		{

		}

		public esWtaPoBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 poid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(poid);
			else
				return LoadByPrimaryKeyStoredProcedure(poid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 poid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(poid);
			else
				return LoadByPrimaryKeyStoredProcedure(poid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 poid)
		{
			esWtaPoQuery query = this.GetDynamicQuery();
			query.Where(query.Poid == poid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 poid)
		{
			esParameters parms = new esParameters();
			parms.Add("poid",poid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Mid": this.str.Mid = (string)value; break;							
						case "Status": this.str.Status = (string)value; break;							
						case "Vendormid": this.str.Vendormid = (string)value; break;							
						case "Vendorname": this.str.Vendorname = (string)value; break;							
						case "Vendoraddress": this.str.Vendoraddress = (string)value; break;							
						case "Createdby": this.str.Createdby = (string)value; break;							
						case "Createdbyname": this.str.Createdbyname = (string)value; break;							
						case "Lastupdateby": this.str.Lastupdateby = (string)value; break;							
						case "Lastupdatebyname": this.str.Lastupdatebyname = (string)value; break;							
						case "Createdate": this.str.Createdate = (string)value; break;							
						case "Lastupdate": this.str.Lastupdate = (string)value; break;							
						case "Postdate": this.str.Postdate = (string)value; break;							
						case "Pocomment": this.str.Pocomment = (string)value; break;							
						case "Shipdate": this.str.Shipdate = (string)value; break;							
						case "FDRCustid": this.str.FDRCustid = (string)value; break;							
						case "FDRInvoice": this.str.FDRInvoice = (string)value; break;							
						case "FDRSalesMan": this.str.FDRSalesMan = (string)value; break;							
						case "FDRLugger": this.str.FDRLugger = (string)value; break;							
						case "MerchTotal": this.str.MerchTotal = (string)value; break;							
						case "TaxTotal": this.str.TaxTotal = (string)value; break;							
						case "WeightTotal": this.str.WeightTotal = (string)value; break;							
						case "FreightTotal": this.str.FreightTotal = (string)value; break;							
						case "FDRChecker": this.str.FDRChecker = (string)value; break;							
						case "Returndate": this.str.Returndate = (string)value; break;							
						case "Source": this.str.Source = (string)value; break;							
						case "Sentstatus": this.str.Sentstatus = (string)value; break;							
						case "Sentdate": this.str.Sentdate = (string)value; break;							
						case "Sentmessage": this.str.Sentmessage = (string)value; break;							
						case "Sentmethod": this.str.Sentmethod = (string)value; break;							
						case "Routeid": this.str.Routeid = (string)value; break;							
						case "Routename": this.str.Routename = (string)value; break;							
						case "Poid": this.str.Poid = (string)value; break;							
						case "StatusUCode": this.str.StatusUCode = (string)value; break;							
						case "RequestedDeliveryTime": this.str.RequestedDeliveryTime = (string)value; break;							
						case "Ponum": this.str.Ponum = (string)value; break;							
						case "LogisticsModel": this.str.LogisticsModel = (string)value; break;							
						case "NameComment": this.str.NameComment = (string)value; break;							
						case "TotalRebate": this.str.TotalRebate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Status":
						
							if (value == null || value is System.Int32)
								this.Status = (System.Int32?)value;
							break;
						
						case "Createdate":
						
							if (value == null || value is System.DateTime)
								this.Createdate = (System.DateTime?)value;
							break;
						
						case "Lastupdate":
						
							if (value == null || value is System.DateTime)
								this.Lastupdate = (System.DateTime?)value;
							break;
						
						case "Postdate":
						
							if (value == null || value is System.DateTime)
								this.Postdate = (System.DateTime?)value;
							break;
						
						case "Shipdate":
						
							if (value == null || value is System.DateTime)
								this.Shipdate = (System.DateTime?)value;
							break;
						
						case "MerchTotal":
						
							if (value == null || value is System.Double)
								this.MerchTotal = (System.Double?)value;
							break;
						
						case "TaxTotal":
						
							if (value == null || value is System.Double)
								this.TaxTotal = (System.Double?)value;
							break;
						
						case "WeightTotal":
						
							if (value == null || value is System.Double)
								this.WeightTotal = (System.Double?)value;
							break;
						
						case "FreightTotal":
						
							if (value == null || value is System.Double)
								this.FreightTotal = (System.Double?)value;
							break;
						
						case "Returndate":
						
							if (value == null || value is System.DateTime)
								this.Returndate = (System.DateTime?)value;
							break;
						
						case "Source":
						
							if (value == null || value is System.Int32)
								this.Source = (System.Int32?)value;
							break;
						
						case "Sentstatus":
						
							if (value == null || value is System.Int32)
								this.Sentstatus = (System.Int32?)value;
							break;
						
						case "Sentdate":
						
							if (value == null || value is System.DateTime)
								this.Sentdate = (System.DateTime?)value;
							break;
						
						case "Sentmethod":
						
							if (value == null || value is System.Int32)
								this.Sentmethod = (System.Int32?)value;
							break;
						
						case "Routeid":
						
							if (value == null || value is System.Int32)
								this.Routeid = (System.Int32?)value;
							break;
						
						case "Poid":
						
							if (value == null || value is System.Int32)
								this.Poid = (System.Int32?)value;
							break;
						
						case "RequestedDeliveryTime":
						
							if (value == null || value is System.DateTime)
								this.RequestedDeliveryTime = (System.DateTime?)value;
							break;
						
						case "TotalRebate":
						
							if (value == null || value is System.Double)
								this.TotalRebate = (System.Double?)value;
							break;
					

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to wta_po.mid
		/// </summary>
		virtual public System.String Mid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoMetadata.ColumnNames.Mid, value))
				{
					this._UpToUsersBOByMid = null;
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po.status
		/// </summary>
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Status);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Status, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendormid
		/// </summary>
		virtual public System.String Vendormid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendormid);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Vendormid, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendorname
		/// </summary>
		virtual public System.String Vendorname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendorname);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Vendorname, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.vendoraddress
		/// </summary>
		virtual public System.String Vendoraddress
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Vendoraddress);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Vendoraddress, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdby
		/// </summary>
		virtual public System.String Createdby
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Createdby);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Createdby, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdbyname
		/// </summary>
		virtual public System.String Createdbyname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Createdbyname);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Createdbyname, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdateby
		/// </summary>
		virtual public System.String Lastupdateby
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Lastupdateby);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Lastupdateby, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdatebyname
		/// </summary>
		virtual public System.String Lastupdatebyname
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Lastupdatebyname);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Lastupdatebyname, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.createdate
		/// </summary>
		virtual public System.DateTime? Createdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Createdate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Createdate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.lastupdate
		/// </summary>
		virtual public System.DateTime? Lastupdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Lastupdate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Lastupdate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.postdate
		/// </summary>
		virtual public System.DateTime? Postdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Postdate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Postdate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.pocomment
		/// </summary>
		virtual public System.String Pocomment
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Pocomment);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Pocomment, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.shipdate
		/// </summary>
		virtual public System.DateTime? Shipdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Shipdate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Shipdate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRCustid
		/// </summary>
		virtual public System.String FDRCustid
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRCustid);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.FDRCustid, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRInvoice
		/// </summary>
		virtual public System.String FDRInvoice
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRInvoice);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.FDRInvoice, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRSalesMan
		/// </summary>
		virtual public System.String FDRSalesMan
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRSalesMan);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.FDRSalesMan, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRLugger
		/// </summary>
		virtual public System.String FDRLugger
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRLugger);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.FDRLugger, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.MerchTotal
		/// </summary>
		virtual public System.Double? MerchTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.MerchTotal);
			}
			
			set
			{
				base.SetSystemDouble(WtaPoMetadata.ColumnNames.MerchTotal, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.TaxTotal
		/// </summary>
		virtual public System.Double? TaxTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.TaxTotal);
			}
			
			set
			{
				base.SetSystemDouble(WtaPoMetadata.ColumnNames.TaxTotal, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.WeightTotal
		/// </summary>
		virtual public System.Double? WeightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.WeightTotal);
			}
			
			set
			{
				base.SetSystemDouble(WtaPoMetadata.ColumnNames.WeightTotal, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FreightTotal
		/// </summary>
		virtual public System.Double? FreightTotal
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.FreightTotal);
			}
			
			set
			{
				base.SetSystemDouble(WtaPoMetadata.ColumnNames.FreightTotal, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.FDRChecker
		/// </summary>
		virtual public System.String FDRChecker
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.FDRChecker);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.FDRChecker, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.returndate
		/// </summary>
		virtual public System.DateTime? Returndate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Returndate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Returndate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.source
		/// </summary>
		virtual public System.Int32? Source
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Source);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Source, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentstatus
		/// </summary>
		virtual public System.Int32? Sentstatus
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Sentstatus);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Sentstatus, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentdate
		/// </summary>
		virtual public System.DateTime? Sentdate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.Sentdate);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.Sentdate, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentmessage
		/// </summary>
		virtual public System.String Sentmessage
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Sentmessage);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Sentmessage, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.sentmethod
		/// </summary>
		virtual public System.Int32? Sentmethod
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Sentmethod);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Sentmethod, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.routeid
		/// </summary>
		virtual public System.Int32? Routeid
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Routeid);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Routeid, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.routename
		/// </summary>
		virtual public System.String Routename
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Routename);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Routename, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.poid
		/// </summary>
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaPoMetadata.ColumnNames.Poid);
			}
			
			set
			{
				base.SetSystemInt32(WtaPoMetadata.ColumnNames.Poid, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.statusUCode
		/// </summary>
		virtual public System.String StatusUCode
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.StatusUCode);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.StatusUCode, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.requested_delivery_time
		/// </summary>
		virtual public System.DateTime? RequestedDeliveryTime
		{
			get
			{
				return base.GetSystemDateTime(WtaPoMetadata.ColumnNames.RequestedDeliveryTime);
			}
			
			set
			{
				base.SetSystemDateTime(WtaPoMetadata.ColumnNames.RequestedDeliveryTime, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.ponum
		/// </summary>
		virtual public System.String Ponum
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.Ponum);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.Ponum, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.LogisticsModel
		/// </summary>
		virtual public System.String LogisticsModel
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.LogisticsModel);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.LogisticsModel, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.NameComment
		/// </summary>
		virtual public System.String NameComment
		{
			get
			{
				return base.GetSystemString(WtaPoMetadata.ColumnNames.NameComment);
			}
			
			set
			{
				base.SetSystemString(WtaPoMetadata.ColumnNames.NameComment, value);
			}
		}
		
		/// <summary>
		/// Maps to wta_po.TotalRebate
		/// </summary>
		virtual public System.Double? TotalRebate
		{
			get
			{
				return base.GetSystemDouble(WtaPoMetadata.ColumnNames.TotalRebate);
			}
			
			set
			{
				base.SetSystemDouble(WtaPoMetadata.ColumnNames.TotalRebate, value);
			}
		}
		
		[CLSCompliant(false)]
		internal protected UsersBO _UpToUsersBOByMid;
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
		sealed public class esStrings
		{
			public esStrings(esWtaPoBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Mid
			{
				get
				{
					System.String data = entity.Mid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Mid = null;
					else entity.Mid = Convert.ToString(value);
				}
			}
				
			public System.String Status
			{
				get
				{
					System.Int32? data = entity.Status;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Status = null;
					else entity.Status = Convert.ToInt32(value);
				}
			}
				
			public System.String Vendormid
			{
				get
				{
					System.String data = entity.Vendormid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendormid = null;
					else entity.Vendormid = Convert.ToString(value);
				}
			}
				
			public System.String Vendorname
			{
				get
				{
					System.String data = entity.Vendorname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendorname = null;
					else entity.Vendorname = Convert.ToString(value);
				}
			}
				
			public System.String Vendoraddress
			{
				get
				{
					System.String data = entity.Vendoraddress;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendoraddress = null;
					else entity.Vendoraddress = Convert.ToString(value);
				}
			}
				
			public System.String Createdby
			{
				get
				{
					System.String data = entity.Createdby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Createdby = null;
					else entity.Createdby = Convert.ToString(value);
				}
			}
				
			public System.String Createdbyname
			{
				get
				{
					System.String data = entity.Createdbyname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Createdbyname = null;
					else entity.Createdbyname = Convert.ToString(value);
				}
			}
				
			public System.String Lastupdateby
			{
				get
				{
					System.String data = entity.Lastupdateby;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastupdateby = null;
					else entity.Lastupdateby = Convert.ToString(value);
				}
			}
				
			public System.String Lastupdatebyname
			{
				get
				{
					System.String data = entity.Lastupdatebyname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastupdatebyname = null;
					else entity.Lastupdatebyname = Convert.ToString(value);
				}
			}
				
			public System.String Createdate
			{
				get
				{
					System.DateTime? data = entity.Createdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Createdate = null;
					else entity.Createdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Lastupdate
			{
				get
				{
					System.DateTime? data = entity.Lastupdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastupdate = null;
					else entity.Lastupdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Postdate
			{
				get
				{
					System.DateTime? data = entity.Postdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Postdate = null;
					else entity.Postdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Pocomment
			{
				get
				{
					System.String data = entity.Pocomment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pocomment = null;
					else entity.Pocomment = Convert.ToString(value);
				}
			}
				
			public System.String Shipdate
			{
				get
				{
					System.DateTime? data = entity.Shipdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Shipdate = null;
					else entity.Shipdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String FDRCustid
			{
				get
				{
					System.String data = entity.FDRCustid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDRCustid = null;
					else entity.FDRCustid = Convert.ToString(value);
				}
			}
				
			public System.String FDRInvoice
			{
				get
				{
					System.String data = entity.FDRInvoice;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDRInvoice = null;
					else entity.FDRInvoice = Convert.ToString(value);
				}
			}
				
			public System.String FDRSalesMan
			{
				get
				{
					System.String data = entity.FDRSalesMan;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDRSalesMan = null;
					else entity.FDRSalesMan = Convert.ToString(value);
				}
			}
				
			public System.String FDRLugger
			{
				get
				{
					System.String data = entity.FDRLugger;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDRLugger = null;
					else entity.FDRLugger = Convert.ToString(value);
				}
			}
				
			public System.String MerchTotal
			{
				get
				{
					System.Double? data = entity.MerchTotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MerchTotal = null;
					else entity.MerchTotal = Convert.ToDouble(value);
				}
			}
				
			public System.String TaxTotal
			{
				get
				{
					System.Double? data = entity.TaxTotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TaxTotal = null;
					else entity.TaxTotal = Convert.ToDouble(value);
				}
			}
				
			public System.String WeightTotal
			{
				get
				{
					System.Double? data = entity.WeightTotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WeightTotal = null;
					else entity.WeightTotal = Convert.ToDouble(value);
				}
			}
				
			public System.String FreightTotal
			{
				get
				{
					System.Double? data = entity.FreightTotal;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FreightTotal = null;
					else entity.FreightTotal = Convert.ToDouble(value);
				}
			}
				
			public System.String FDRChecker
			{
				get
				{
					System.String data = entity.FDRChecker;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDRChecker = null;
					else entity.FDRChecker = Convert.ToString(value);
				}
			}
				
			public System.String Returndate
			{
				get
				{
					System.DateTime? data = entity.Returndate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Returndate = null;
					else entity.Returndate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Source
			{
				get
				{
					System.Int32? data = entity.Source;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Source = null;
					else entity.Source = Convert.ToInt32(value);
				}
			}
				
			public System.String Sentstatus
			{
				get
				{
					System.Int32? data = entity.Sentstatus;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sentstatus = null;
					else entity.Sentstatus = Convert.ToInt32(value);
				}
			}
				
			public System.String Sentdate
			{
				get
				{
					System.DateTime? data = entity.Sentdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sentdate = null;
					else entity.Sentdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Sentmessage
			{
				get
				{
					System.String data = entity.Sentmessage;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sentmessage = null;
					else entity.Sentmessage = Convert.ToString(value);
				}
			}
				
			public System.String Sentmethod
			{
				get
				{
					System.Int32? data = entity.Sentmethod;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sentmethod = null;
					else entity.Sentmethod = Convert.ToInt32(value);
				}
			}
				
			public System.String Routeid
			{
				get
				{
					System.Int32? data = entity.Routeid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Routeid = null;
					else entity.Routeid = Convert.ToInt32(value);
				}
			}
				
			public System.String Routename
			{
				get
				{
					System.String data = entity.Routename;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Routename = null;
					else entity.Routename = Convert.ToString(value);
				}
			}
				
			public System.String Poid
			{
				get
				{
					System.Int32? data = entity.Poid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Poid = null;
					else entity.Poid = Convert.ToInt32(value);
				}
			}
				
			public System.String StatusUCode
			{
				get
				{
					System.String data = entity.StatusUCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StatusUCode = null;
					else entity.StatusUCode = Convert.ToString(value);
				}
			}
				
			public System.String RequestedDeliveryTime
			{
				get
				{
					System.DateTime? data = entity.RequestedDeliveryTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequestedDeliveryTime = null;
					else entity.RequestedDeliveryTime = Convert.ToDateTime(value);
				}
			}
				
			public System.String Ponum
			{
				get
				{
					System.String data = entity.Ponum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Ponum = null;
					else entity.Ponum = Convert.ToString(value);
				}
			}
				
			public System.String LogisticsModel
			{
				get
				{
					System.String data = entity.LogisticsModel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LogisticsModel = null;
					else entity.LogisticsModel = Convert.ToString(value);
				}
			}
				
			public System.String NameComment
			{
				get
				{
					System.String data = entity.NameComment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NameComment = null;
					else entity.NameComment = Convert.ToString(value);
				}
			}
				
			public System.String TotalRebate
			{
				get
				{
					System.Double? data = entity.TotalRebate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TotalRebate = null;
					else entity.TotalRebate = Convert.ToDouble(value);
				}
			}
			

			private esWtaPoBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esWtaPoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es2.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esWtaPoBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class WtaPoBO : esWtaPoBO
	{

				
		#region WtaPoLineBOCollectionByPoid - Zero To Many
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_wta_po_line_poid
		/// </summary>

		[XmlIgnore]
		public WtaPoLineCollection WtaPoLineBOCollectionByPoid
		{
			get
			{
				if(this._WtaPoLineBOCollectionByPoid == null)
				{
					this._WtaPoLineBOCollectionByPoid = new WtaPoLineCollection();
					this._WtaPoLineBOCollectionByPoid.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("WtaPoLineBOCollectionByPoid", this._WtaPoLineBOCollectionByPoid);
				
					if(this.Poid != null)
					{
						this._WtaPoLineBOCollectionByPoid.Query.Where(this._WtaPoLineBOCollectionByPoid.Query.Poid == this.Poid);
						this._WtaPoLineBOCollectionByPoid.Query.Load();

						// Auto-hookup Foreign Keys
						this._WtaPoLineBOCollectionByPoid.fks.Add(WtaPoLineMetadata.ColumnNames.Poid, this.Poid);
					}
				}

				return this._WtaPoLineBOCollectionByPoid;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._WtaPoLineBOCollectionByPoid != null) 
				{ 
					this.RemovePostSave("WtaPoLineBOCollectionByPoid"); 
					this._WtaPoLineBOCollectionByPoid = null;
					
				} 
			} 			
		}

		private WtaPoLineCollection _WtaPoLineBOCollectionByPoid;
		#endregion

				
		#region UpToUsersBOByMid - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_wta_po_mid
		/// </summary>

		[XmlIgnore]
		public UsersBO UpToUsersBOByMid
		{
			get
			{
				if(this._UpToUsersBOByMid == null
					&& Mid != null					)
				{
					this._UpToUsersBOByMid = new UsersBO();
					this._UpToUsersBOByMid.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToUsersBOByMid", this._UpToUsersBOByMid);
					this._UpToUsersBOByMid.Query.Where(this._UpToUsersBOByMid.Query.Custid == this.Mid);
					this._UpToUsersBOByMid.Query.Load();
				}

				return this._UpToUsersBOByMid;
			}
			
			set
			{
				this.RemovePreSave("UpToUsersBOByMid");
				

				if(value == null)
				{
					this.Mid = null;
					this._UpToUsersBOByMid = null;
				}
				else
				{
					this.Mid = value.Custid;
					this._UpToUsersBOByMid = value;
					this.SetPreSave("UpToUsersBOByMid", this._UpToUsersBOByMid);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "WtaPoLineBOCollectionByPoid", typeof(WtaPoLineCollection), new WtaPoLineBO()));
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
			if(this._WtaPoLineBOCollectionByPoid != null)
			{
				foreach(WtaPoLineBO obj in this._WtaPoLineBOCollectionByPoid)
				{
					if(obj.es.IsAdded)
					{
						obj.Poid = this.Poid;
					}
				}
			}
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esWtaPoQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoMetadata.Meta();
			}
		}	
		

		public esQueryItem Mid
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Mid, esSystemType.String);
			}
		} 
		
		public esQueryItem Status
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Status, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Vendormid
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendormid, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendorname
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendorname, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendoraddress
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Vendoraddress, esSystemType.String);
			}
		} 
		
		public esQueryItem Createdby
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdby, esSystemType.String);
			}
		} 
		
		public esQueryItem Createdbyname
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdbyname, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastupdateby
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdateby, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastupdatebyname
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdatebyname, esSystemType.String);
			}
		} 
		
		public esQueryItem Createdate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Createdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Lastupdate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Lastupdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Postdate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Postdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Pocomment
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Pocomment, esSystemType.String);
			}
		} 
		
		public esQueryItem Shipdate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Shipdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem FDRCustid
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRCustid, esSystemType.String);
			}
		} 
		
		public esQueryItem FDRInvoice
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRInvoice, esSystemType.String);
			}
		} 
		
		public esQueryItem FDRSalesMan
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRSalesMan, esSystemType.String);
			}
		} 
		
		public esQueryItem FDRLugger
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRLugger, esSystemType.String);
			}
		} 
		
		public esQueryItem MerchTotal
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.MerchTotal, esSystemType.Double);
			}
		} 
		
		public esQueryItem TaxTotal
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.TaxTotal, esSystemType.Double);
			}
		} 
		
		public esQueryItem WeightTotal
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.WeightTotal, esSystemType.Double);
			}
		} 
		
		public esQueryItem FreightTotal
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FreightTotal, esSystemType.Double);
			}
		} 
		
		public esQueryItem FDRChecker
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.FDRChecker, esSystemType.String);
			}
		} 
		
		public esQueryItem Returndate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Returndate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Source
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Source, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Sentstatus
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentstatus, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Sentdate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Sentmessage
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentmessage, esSystemType.String);
			}
		} 
		
		public esQueryItem Sentmethod
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Sentmethod, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Routeid
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Routeid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Routename
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Routename, esSystemType.String);
			}
		} 
		
		public esQueryItem Poid
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Poid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem StatusUCode
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.StatusUCode, esSystemType.String);
			}
		} 
		
		public esQueryItem RequestedDeliveryTime
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.RequestedDeliveryTime, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Ponum
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.Ponum, esSystemType.String);
			}
		} 
		
		public esQueryItem LogisticsModel
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.LogisticsModel, esSystemType.String);
			}
		} 
		
		public esQueryItem NameComment
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.NameComment, esSystemType.String);
			}
		} 
		
		public esQueryItem TotalRebate
		{
			get
			{
				return new esQueryItem(this, WtaPoMetadata.ColumnNames.TotalRebate, esSystemType.Double);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("WtaPoCollection")]
	public partial class WtaPoCollection : esWtaPoCollection, IEnumerable<WtaPoBO>
	{
		public WtaPoCollection()
		{

		}
		
		public static implicit operator List<WtaPoBO>(WtaPoCollection coll)
		{
			List<WtaPoBO> list = new List<WtaPoBO>();
			
			foreach (WtaPoBO emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  WtaPoMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new WtaPoBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new WtaPoBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public WtaPoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(WtaPoQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public WtaPoBO AddNew()
		{
			WtaPoBO entity = base.AddNewEntity() as WtaPoBO;
			
			return entity;
		}

		public WtaPoBO FindByPrimaryKey(System.Int32 poid)
		{
			return base.FindByPrimaryKey(poid) as WtaPoBO;
		}


		#region IEnumerable<WtaPoBO> Members

		IEnumerator<WtaPoBO> IEnumerable<WtaPoBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as WtaPoBO;
			}
		}

		#endregion
		
		private WtaPoQuery query;
	}


	/// <summary>
	/// Encapsulates the 'wta_po' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("WtaPoBO ({Poid})")]
	[Serializable]
	public partial class WtaPoBO : esWtaPoBO
	{
		public WtaPoBO()
		{

		}
	
		public WtaPoBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoMetadata.Meta();
			}
		}
		
		
		
		override protected esWtaPoQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public WtaPoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(WtaPoQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private WtaPoQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class WtaPoQuery : esWtaPoQuery
	{
		public WtaPoQuery()
		{

		}		
		
		public WtaPoQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "WtaPoQuery";
        }
		
			
	}


	[Serializable]
	public partial class WtaPoMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaPoMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Mid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Mid;
			c.CharacterMaxLength = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Status, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendormid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendormid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendorname, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendorname;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Vendoraddress, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Vendoraddress;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdby, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdbyname, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdbyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdateby, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdateby;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdatebyname, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdatebyname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Createdate, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Createdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Lastupdate, 10, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Lastupdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Postdate, 11, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Postdate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Pocomment, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Pocomment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Shipdate, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Shipdate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRCustid, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRCustid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRInvoice, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRInvoice;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRSalesMan, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRSalesMan;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRLugger, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRLugger;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.MerchTotal, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.MerchTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.TaxTotal, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.TaxTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.WeightTotal, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.WeightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FreightTotal, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.FreightTotal;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.FDRChecker, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.FDRChecker;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Returndate, 23, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Returndate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Source, 24, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentstatus, 25, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentstatus;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentdate, 26, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentdate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentmessage, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentmessage;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Sentmethod, 28, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Sentmethod;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Routeid, 29, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Routeid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Routename, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Routename;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Poid, 31, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoMetadata.PropertyNames.Poid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.StatusUCode, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.StatusUCode;
			c.CharacterMaxLength = 20;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.RequestedDeliveryTime, 33, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoMetadata.PropertyNames.RequestedDeliveryTime;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.Ponum, 34, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.Ponum;
			c.CharacterMaxLength = 200;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.LogisticsModel, 35, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.LogisticsModel;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('D')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.NameComment, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoMetadata.PropertyNames.NameComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoMetadata.ColumnNames.TotalRebate, 37, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoMetadata.PropertyNames.TotalRebate;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaPoMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Mid = "mid";
			 public const string Status = "status";
			 public const string Vendormid = "vendormid";
			 public const string Vendorname = "vendorname";
			 public const string Vendoraddress = "vendoraddress";
			 public const string Createdby = "createdby";
			 public const string Createdbyname = "createdbyname";
			 public const string Lastupdateby = "lastupdateby";
			 public const string Lastupdatebyname = "lastupdatebyname";
			 public const string Createdate = "createdate";
			 public const string Lastupdate = "lastupdate";
			 public const string Postdate = "postdate";
			 public const string Pocomment = "pocomment";
			 public const string Shipdate = "shipdate";
			 public const string FDRCustid = "FDRCustid";
			 public const string FDRInvoice = "FDRInvoice";
			 public const string FDRSalesMan = "FDRSalesMan";
			 public const string FDRLugger = "FDRLugger";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string FDRChecker = "FDRChecker";
			 public const string Returndate = "returndate";
			 public const string Source = "source";
			 public const string Sentstatus = "sentstatus";
			 public const string Sentdate = "sentdate";
			 public const string Sentmessage = "sentmessage";
			 public const string Sentmethod = "sentmethod";
			 public const string Routeid = "routeid";
			 public const string Routename = "routename";
			 public const string Poid = "poid";
			 public const string StatusUCode = "statusUCode";
			 public const string RequestedDeliveryTime = "requested_delivery_time";
			 public const string Ponum = "ponum";
			 public const string LogisticsModel = "LogisticsModel";
			 public const string NameComment = "NameComment";
			 public const string TotalRebate = "TotalRebate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Status = "Status";
			 public const string Vendormid = "Vendormid";
			 public const string Vendorname = "Vendorname";
			 public const string Vendoraddress = "Vendoraddress";
			 public const string Createdby = "Createdby";
			 public const string Createdbyname = "Createdbyname";
			 public const string Lastupdateby = "Lastupdateby";
			 public const string Lastupdatebyname = "Lastupdatebyname";
			 public const string Createdate = "Createdate";
			 public const string Lastupdate = "Lastupdate";
			 public const string Postdate = "Postdate";
			 public const string Pocomment = "Pocomment";
			 public const string Shipdate = "Shipdate";
			 public const string FDRCustid = "FDRCustid";
			 public const string FDRInvoice = "FDRInvoice";
			 public const string FDRSalesMan = "FDRSalesMan";
			 public const string FDRLugger = "FDRLugger";
			 public const string MerchTotal = "MerchTotal";
			 public const string TaxTotal = "TaxTotal";
			 public const string WeightTotal = "WeightTotal";
			 public const string FreightTotal = "FreightTotal";
			 public const string FDRChecker = "FDRChecker";
			 public const string Returndate = "Returndate";
			 public const string Source = "Source";
			 public const string Sentstatus = "Sentstatus";
			 public const string Sentdate = "Sentdate";
			 public const string Sentmessage = "Sentmessage";
			 public const string Sentmethod = "Sentmethod";
			 public const string Routeid = "Routeid";
			 public const string Routename = "Routename";
			 public const string Poid = "Poid";
			 public const string StatusUCode = "StatusUCode";
			 public const string RequestedDeliveryTime = "RequestedDeliveryTime";
			 public const string Ponum = "Ponum";
			 public const string LogisticsModel = "LogisticsModel";
			 public const string NameComment = "NameComment";
			 public const string TotalRebate = "TotalRebate";
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
			lock (typeof(WtaPoMetadata))
			{
				if(WtaPoMetadata.mapDelegates == null)
				{
					WtaPoMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaPoMetadata.meta == null)
				{
					WtaPoMetadata.meta = new WtaPoMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();
				

				meta.AddTypeMap("Mid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Vendormid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraddress", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdbyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdateby", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastupdatebyname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Createdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastupdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Postdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Pocomment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Shipdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("FDRCustid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRInvoice", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRSalesMan", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FDRLugger", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("MerchTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("TaxTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("WeightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("FreightTotal", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("FDRChecker", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Returndate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Source", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Sentstatus", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Sentdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Sentmessage", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sentmethod", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Routeid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Routename", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("StatusUCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("RequestedDeliveryTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Ponum", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LogisticsModel", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("NameComment", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TotalRebate", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "wta_po";
				meta.Destination = "wta_po";
				
				meta.spInsert = "proc_wta_poInsert";				
				meta.spUpdate = "proc_wta_poUpdate";		
				meta.spDelete = "proc_wta_poDelete";
				meta.spLoadAll = "proc_wta_poLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_poLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaPoMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
