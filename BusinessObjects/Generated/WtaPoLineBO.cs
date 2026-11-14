/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 11/23/2021 7:37:39 PM
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
	abstract public class esWtaPoLineCollection : esEntityCollection
	{
		public esWtaPoLineCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "WtaPoLineCollection";
		}

		#region Query Logic
		protected void InitQuery(esWtaPoLineQuery query)
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
			this.InitQuery(query as esWtaPoLineQuery);
		}
		#endregion
		
		virtual public WtaPoLineBO DetachEntity(WtaPoLineBO entity)
		{
			return base.DetachEntity(entity) as WtaPoLineBO;
		}
		
		virtual public WtaPoLineBO AttachEntity(WtaPoLineBO entity)
		{
			return base.AttachEntity(entity) as WtaPoLineBO;
		}
		
		virtual public void Combine(WtaPoLineCollection collection)
		{
			base.Combine(collection);
		}
		
		new public WtaPoLineBO this[int index]
		{
			get
			{
				return base[index] as WtaPoLineBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(WtaPoLineBO);
		}
	}



	[Serializable]
	abstract public class esWtaPoLineBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esWtaPoLineQuery GetDynamicQuery()
		{
			return null;
		}

		public esWtaPoLineBO()
		{

		}

		public esWtaPoLineBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 polid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(polid);
			else
				return LoadByPrimaryKeyStoredProcedure(polid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 polid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(polid);
			else
				return LoadByPrimaryKeyStoredProcedure(polid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 polid)
		{
			esWtaPoLineQuery query = this.GetDynamicQuery();
			query.Where(query.Polid == polid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 polid)
		{
			esParameters parms = new esParameters();
			parms.Add("polid",polid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
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
						case "Poid": this.str.Poid = (string)value; break;							
						case "LineNum": this.str.LineNum = (string)value; break;							
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Productdescription": this.str.Productdescription = (string)value; break;							
						case "Productaltcode": this.str.Productaltcode = (string)value; break;							
						case "Productaltdescription": this.str.Productaltdescription = (string)value; break;							
						case "Vendorcode": this.str.Vendorcode = (string)value; break;							
						case "Vendordescription": this.str.Vendordescription = (string)value; break;							
						case "Vendoraltcode": this.str.Vendoraltcode = (string)value; break;							
						case "Vendoraltdescription": this.str.Vendoraltdescription = (string)value; break;							
						case "Um": this.str.Um = (string)value; break;							
						case "Qty": this.str.Qty = (string)value; break;							
						case "Wprice": this.str.Wprice = (string)value; break;							
						case "Weight": this.str.Weight = (string)value; break;							
						case "Casecount": this.str.Casecount = (string)value; break;							
						case "TruckComment": this.str.TruckComment = (string)value; break;							
						case "VendorComment": this.str.VendorComment = (string)value; break;							
						case "Status": this.str.Status = (string)value; break;							
						case "State": this.str.State = (string)value; break;							
						case "MultipleWeights": this.str.MultipleWeights = (string)value; break;							
						case "Amount": this.str.Amount = (string)value; break;							
						case "Taxamount": this.str.Taxamount = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;							
						case "Jwitem": this.str.Jwitem = (string)value; break;							
						case "Xtype": this.str.Xtype = (string)value; break;							
						case "Taxable": this.str.Taxable = (string)value; break;							
						case "UmStyle": this.str.UmStyle = (string)value; break;							
						case "Productweight": this.str.Productweight = (string)value; break;							
						case "MwBuffer": this.str.MwBuffer = (string)value; break;							
						case "SourceTicketInfo": this.str.SourceTicketInfo = (string)value; break;							
						case "Polid": this.str.Polid = (string)value; break;							
						case "Catid": this.str.Catid = (string)value; break;							
						case "Scatid": this.str.Scatid = (string)value; break;							
						case "LineTypeUCode": this.str.LineTypeUCode = (string)value; break;							
						case "WeightType": this.str.WeightType = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Poid":
						
							if (value == null || value is System.Int32)
								this.Poid = (System.Int32?)value;
							break;
						
						case "LineNum":
						
							if (value == null || value is System.Int32)
								this.LineNum = (System.Int32?)value;
							break;
						
						case "Qty":
						
							if (value == null || value is System.Double)
								this.Qty = (System.Double?)value;
							break;
						
						case "Wprice":
						
							if (value == null || value is System.Double)
								this.Wprice = (System.Double?)value;
							break;
						
						case "Weight":
						
							if (value == null || value is System.Double)
								this.Weight = (System.Double?)value;
							break;
						
						case "Casecount":
						
							if (value == null || value is System.Int32)
								this.Casecount = (System.Int32?)value;
							break;
						
						case "Status":
						
							if (value == null || value is System.Int32)
								this.Status = (System.Int32?)value;
							break;
						
						case "State":
						
							if (value == null || value is System.Int32)
								this.State = (System.Int32?)value;
							break;
						
						case "MultipleWeights":
						
							if (value == null || value is System.Int16)
								this.MultipleWeights = (System.Int16?)value;
							break;
						
						case "Amount":
						
							if (value == null || value is System.Double)
								this.Amount = (System.Double?)value;
							break;
						
						case "Taxamount":
						
							if (value == null || value is System.Double)
								this.Taxamount = (System.Double?)value;
							break;
						
						case "CreateDate":
						
							if (value == null || value is System.DateTime)
								this.CreateDate = (System.DateTime?)value;
							break;
						
						case "Taxable":
						
							if (value == null || value is System.Int32)
								this.Taxable = (System.Int32?)value;
							break;
						
						case "UmStyle":
						
							if (value == null || value is System.Int32)
								this.UmStyle = (System.Int32?)value;
							break;
						
						case "Productweight":
						
							if (value == null || value is System.Double)
								this.Productweight = (System.Double?)value;
							break;
						
						case "Polid":
						
							if (value == null || value is System.Int32)
								this.Polid = (System.Int32?)value;
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
		/// Maps to wta_po_line.poid
		/// </summary>
		virtual public System.Int32? Poid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Poid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Poid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Poid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.line_num
		/// </summary>
		virtual public System.Int32? LineNum
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.LineNum);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.LineNum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.LineNum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productdescription
		/// </summary>
		virtual public System.String Productdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Productdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productaltcode
		/// </summary>
		virtual public System.String Productaltcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productaltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productaltcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Productaltcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productaltdescription
		/// </summary>
		virtual public System.String Productaltdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Productaltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Productaltdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Productaltdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendorcode
		/// </summary>
		virtual public System.String Vendorcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendorcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendorcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Vendorcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendordescription
		/// </summary>
		virtual public System.String Vendordescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendordescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendordescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Vendordescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendoraltcode
		/// </summary>
		virtual public System.String Vendoraltcode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltcode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Vendoraltcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendoraltdescription
		/// </summary>
		virtual public System.String Vendoraltdescription
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltdescription);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Vendoraltdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Vendoraltdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.um
		/// </summary>
		virtual public System.String Um
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Um);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Um, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Um));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.qty
		/// </summary>
		virtual public System.Double? Qty
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Qty);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Qty, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Qty));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.wprice
		/// </summary>
		virtual public System.Double? Wprice
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Wprice);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Wprice, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Wprice));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.weight
		/// </summary>
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Weight, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Weight));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.casecount
		/// </summary>
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Casecount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Casecount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.truck_comment
		/// </summary>
		virtual public System.String TruckComment
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.TruckComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.TruckComment, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.TruckComment));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.vendor_comment
		/// </summary>
		virtual public System.String VendorComment
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.VendorComment);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.VendorComment, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.VendorComment));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.status
		/// </summary>
		virtual public System.Int32? Status
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Status, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Status));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.state
		/// </summary>
		virtual public System.Int32? State
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.State, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.State));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.multiple_weights
		/// </summary>
		virtual public System.Int16? MultipleWeights
		{
			get
			{
				return base.GetSystemInt16(WtaPoLineMetadata.ColumnNames.MultipleWeights);
			}
			
			set
			{
				if(base.SetSystemInt16(WtaPoLineMetadata.ColumnNames.MultipleWeights, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.MultipleWeights));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.amount
		/// </summary>
		virtual public System.Double? Amount
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Amount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Amount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Amount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.taxamount
		/// </summary>
		virtual public System.Double? Taxamount
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Taxamount);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Taxamount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Taxamount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.CreateDate
		/// </summary>
		virtual public System.DateTime? CreateDate
		{
			get
			{
				return base.GetSystemDateTime(WtaPoLineMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(WtaPoLineMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.CreateDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.jwitem
		/// </summary>
		virtual public System.String Jwitem
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Jwitem);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Jwitem, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Jwitem));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.xtype
		/// </summary>
		virtual public System.String Xtype
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Xtype);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Xtype, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Xtype));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.taxable
		/// </summary>
		virtual public System.Int32? Taxable
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Taxable, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Taxable));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.um_style
		/// </summary>
		virtual public System.Int32? UmStyle
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.UmStyle);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.UmStyle, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.UmStyle));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.productweight
		/// </summary>
		virtual public System.Double? Productweight
		{
			get
			{
				return base.GetSystemDouble(WtaPoLineMetadata.ColumnNames.Productweight);
			}
			
			set
			{
				if(base.SetSystemDouble(WtaPoLineMetadata.ColumnNames.Productweight, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Productweight));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.mw_buffer
		/// </summary>
		virtual public System.String MwBuffer
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.MwBuffer);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.MwBuffer, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.MwBuffer));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.SourceTicketInfo
		/// </summary>
		virtual public System.String SourceTicketInfo
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.SourceTicketInfo);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.SourceTicketInfo, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.SourceTicketInfo));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.polid
		/// </summary>
		virtual public System.Int32? Polid
		{
			get
			{
				return base.GetSystemInt32(WtaPoLineMetadata.ColumnNames.Polid);
			}
			
			set
			{
				if(base.SetSystemInt32(WtaPoLineMetadata.ColumnNames.Polid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Polid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.catid
		/// </summary>
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Catid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Catid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.scatid
		/// </summary>
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.Scatid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.LineTypeUCode
		/// </summary>
		virtual public System.String LineTypeUCode
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.LineTypeUCode);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.LineTypeUCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.LineTypeUCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to wta_po_line.weight_type
		/// </summary>
		virtual public System.String WeightType
		{
			get
			{
				return base.GetSystemString(WtaPoLineMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemString(WtaPoLineMetadata.ColumnNames.WeightType, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(WtaPoLineMetadata.PropertyNames.WeightType));
					}
				}
			}
		}
		
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
			public esStrings(esWtaPoLineBO entity)
			{
				this.entity = entity;
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
				
			public System.String LineNum
			{
				get
				{
					System.Int32? data = entity.LineNum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LineNum = null;
					else entity.LineNum = Convert.ToInt32(value);
				}
			}
				
			public System.String Productcode
			{
				get
				{
					System.String data = entity.Productcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productcode = null;
					else entity.Productcode = Convert.ToString(value);
				}
			}
				
			public System.String Productdescription
			{
				get
				{
					System.String data = entity.Productdescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productdescription = null;
					else entity.Productdescription = Convert.ToString(value);
				}
			}
				
			public System.String Productaltcode
			{
				get
				{
					System.String data = entity.Productaltcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productaltcode = null;
					else entity.Productaltcode = Convert.ToString(value);
				}
			}
				
			public System.String Productaltdescription
			{
				get
				{
					System.String data = entity.Productaltdescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productaltdescription = null;
					else entity.Productaltdescription = Convert.ToString(value);
				}
			}
				
			public System.String Vendorcode
			{
				get
				{
					System.String data = entity.Vendorcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendorcode = null;
					else entity.Vendorcode = Convert.ToString(value);
				}
			}
				
			public System.String Vendordescription
			{
				get
				{
					System.String data = entity.Vendordescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendordescription = null;
					else entity.Vendordescription = Convert.ToString(value);
				}
			}
				
			public System.String Vendoraltcode
			{
				get
				{
					System.String data = entity.Vendoraltcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendoraltcode = null;
					else entity.Vendoraltcode = Convert.ToString(value);
				}
			}
				
			public System.String Vendoraltdescription
			{
				get
				{
					System.String data = entity.Vendoraltdescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Vendoraltdescription = null;
					else entity.Vendoraltdescription = Convert.ToString(value);
				}
			}
				
			public System.String Um
			{
				get
				{
					System.String data = entity.Um;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Um = null;
					else entity.Um = Convert.ToString(value);
				}
			}
				
			public System.String Qty
			{
				get
				{
					System.Double? data = entity.Qty;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qty = null;
					else entity.Qty = Convert.ToDouble(value);
				}
			}
				
			public System.String Wprice
			{
				get
				{
					System.Double? data = entity.Wprice;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Wprice = null;
					else entity.Wprice = Convert.ToDouble(value);
				}
			}
				
			public System.String Weight
			{
				get
				{
					System.Double? data = entity.Weight;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Weight = null;
					else entity.Weight = Convert.ToDouble(value);
				}
			}
				
			public System.String Casecount
			{
				get
				{
					System.Int32? data = entity.Casecount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount = null;
					else entity.Casecount = Convert.ToInt32(value);
				}
			}
				
			public System.String TruckComment
			{
				get
				{
					System.String data = entity.TruckComment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TruckComment = null;
					else entity.TruckComment = Convert.ToString(value);
				}
			}
				
			public System.String VendorComment
			{
				get
				{
					System.String data = entity.VendorComment;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VendorComment = null;
					else entity.VendorComment = Convert.ToString(value);
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
				
			public System.String State
			{
				get
				{
					System.Int32? data = entity.State;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.State = null;
					else entity.State = Convert.ToInt32(value);
				}
			}
				
			public System.String MultipleWeights
			{
				get
				{
					System.Int16? data = entity.MultipleWeights;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MultipleWeights = null;
					else entity.MultipleWeights = Convert.ToInt16(value);
				}
			}
				
			public System.String Amount
			{
				get
				{
					System.Double? data = entity.Amount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Amount = null;
					else entity.Amount = Convert.ToDouble(value);
				}
			}
				
			public System.String Taxamount
			{
				get
				{
					System.Double? data = entity.Taxamount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Taxamount = null;
					else entity.Taxamount = Convert.ToDouble(value);
				}
			}
				
			public System.String CreateDate
			{
				get
				{
					System.DateTime? data = entity.CreateDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreateDate = null;
					else entity.CreateDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Jwitem
			{
				get
				{
					System.String data = entity.Jwitem;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jwitem = null;
					else entity.Jwitem = Convert.ToString(value);
				}
			}
				
			public System.String Xtype
			{
				get
				{
					System.String data = entity.Xtype;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Xtype = null;
					else entity.Xtype = Convert.ToString(value);
				}
			}
				
			public System.String Taxable
			{
				get
				{
					System.Int32? data = entity.Taxable;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Taxable = null;
					else entity.Taxable = Convert.ToInt32(value);
				}
			}
				
			public System.String UmStyle
			{
				get
				{
					System.Int32? data = entity.UmStyle;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UmStyle = null;
					else entity.UmStyle = Convert.ToInt32(value);
				}
			}
				
			public System.String Productweight
			{
				get
				{
					System.Double? data = entity.Productweight;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Productweight = null;
					else entity.Productweight = Convert.ToDouble(value);
				}
			}
				
			public System.String MwBuffer
			{
				get
				{
					System.String data = entity.MwBuffer;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MwBuffer = null;
					else entity.MwBuffer = Convert.ToString(value);
				}
			}
				
			public System.String SourceTicketInfo
			{
				get
				{
					System.String data = entity.SourceTicketInfo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SourceTicketInfo = null;
					else entity.SourceTicketInfo = Convert.ToString(value);
				}
			}
				
			public System.String Polid
			{
				get
				{
					System.Int32? data = entity.Polid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Polid = null;
					else entity.Polid = Convert.ToInt32(value);
				}
			}
				
			public System.String Catid
			{
				get
				{
					System.String data = entity.Catid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid = null;
					else entity.Catid = Convert.ToString(value);
				}
			}
				
			public System.String Scatid
			{
				get
				{
					System.String data = entity.Scatid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid = null;
					else entity.Scatid = Convert.ToString(value);
				}
			}
				
			public System.String LineTypeUCode
			{
				get
				{
					System.String data = entity.LineTypeUCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LineTypeUCode = null;
					else entity.LineTypeUCode = Convert.ToString(value);
				}
			}
				
			public System.String WeightType
			{
				get
				{
					System.String data = entity.WeightType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WeightType = null;
					else entity.WeightType = Convert.ToString(value);
				}
			}
			

			private esWtaPoLineBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esWtaPoLineQuery query)
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
				throw new Exception("esWtaPoLineBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esWtaPoLineQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineMetadata.Meta();
			}
		}	
		

		public esQueryItem Poid
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Poid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem LineNum
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.LineNum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Productdescription
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Productaltcode
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productaltcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Productaltdescription
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productaltdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendorcode
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendorcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendordescription
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendordescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendoraltcode
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendoraltcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Vendoraltdescription
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Vendoraltdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Um
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Um, esSystemType.String);
			}
		} 
		
		public esQueryItem Qty
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Qty, esSystemType.Double);
			}
		} 
		
		public esQueryItem Wprice
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Wprice, esSystemType.Double);
			}
		} 
		
		public esQueryItem Weight
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Weight, esSystemType.Double);
			}
		} 
		
		public esQueryItem Casecount
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Casecount, esSystemType.Int32);
			}
		} 
		
		public esQueryItem TruckComment
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.TruckComment, esSystemType.String);
			}
		} 
		
		public esQueryItem VendorComment
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.VendorComment, esSystemType.String);
			}
		} 
		
		public esQueryItem Status
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Status, esSystemType.Int32);
			}
		} 
		
		public esQueryItem State
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.State, esSystemType.Int32);
			}
		} 
		
		public esQueryItem MultipleWeights
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.MultipleWeights, esSystemType.Int16);
			}
		} 
		
		public esQueryItem Amount
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Amount, esSystemType.Double);
			}
		} 
		
		public esQueryItem Taxamount
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Taxamount, esSystemType.Double);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.CreateDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Jwitem
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Jwitem, esSystemType.String);
			}
		} 
		
		public esQueryItem Xtype
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Xtype, esSystemType.String);
			}
		} 
		
		public esQueryItem Taxable
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Taxable, esSystemType.Int32);
			}
		} 
		
		public esQueryItem UmStyle
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.UmStyle, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productweight
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Productweight, esSystemType.Double);
			}
		} 
		
		public esQueryItem MwBuffer
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.MwBuffer, esSystemType.String);
			}
		} 
		
		public esQueryItem SourceTicketInfo
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.SourceTicketInfo, esSystemType.String);
			}
		} 
		
		public esQueryItem Polid
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Polid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Catid
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Catid, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem LineTypeUCode
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.LineTypeUCode, esSystemType.String);
			}
		} 
		
		public esQueryItem WeightType
		{
			get
			{
				return new esQueryItem(this, WtaPoLineMetadata.ColumnNames.WeightType, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("WtaPoLineCollection")]
	public partial class WtaPoLineCollection : esWtaPoLineCollection, IEnumerable<WtaPoLineBO>
	{
		public WtaPoLineCollection()
		{

		}
		
		public static implicit operator List<WtaPoLineBO>(WtaPoLineCollection coll)
		{
			List<WtaPoLineBO> list = new List<WtaPoLineBO>();
			
			foreach (WtaPoLineBO emp in coll)
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
				return  WtaPoLineMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoLineQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new WtaPoLineBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new WtaPoLineBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public WtaPoLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(WtaPoLineQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public WtaPoLineBO AddNew()
		{
			WtaPoLineBO entity = base.AddNewEntity() as WtaPoLineBO;
			
			return entity;
		}

		public WtaPoLineBO FindByPrimaryKey(System.Int32 polid)
		{
			return base.FindByPrimaryKey(polid) as WtaPoLineBO;
		}


		#region IEnumerable<WtaPoLineBO> Members

		IEnumerator<WtaPoLineBO> IEnumerable<WtaPoLineBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as WtaPoLineBO;
			}
		}

		#endregion
		
		private WtaPoLineQuery query;
	}


	/// <summary>
	/// Encapsulates the 'wta_po_line' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("WtaPoLineBO ({Polid})")]
	[Serializable]
	public partial class WtaPoLineBO : esWtaPoLineBO
	{
		public WtaPoLineBO()
		{

		}
	
		public WtaPoLineBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return WtaPoLineMetadata.Meta();
			}
		}
		
		
		
		override protected esWtaPoLineQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new WtaPoLineQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public WtaPoLineQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new WtaPoLineQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(WtaPoLineQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private WtaPoLineQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class WtaPoLineQuery : esWtaPoLineQuery
	{
		public WtaPoLineQuery()
		{

		}		
		
		public WtaPoLineQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "WtaPoLineQuery";
        }
		
			
	}


	[Serializable]
	public partial class WtaPoLineMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected WtaPoLineMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Poid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Poid;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.LineNum, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.LineNum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productdescription, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productaltcode, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productaltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productaltdescription, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productaltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendorcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendorcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendordescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendordescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendoraltcode, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendoraltcode;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Vendoraltdescription, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Vendoraltdescription;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Um, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Um;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Qty, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Qty;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Wprice, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Wprice;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Weight, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Casecount, 14, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.TruckComment, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.TruckComment;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.VendorComment, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.VendorComment;
			c.CharacterMaxLength = 38;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Status, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Status;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.State, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.State;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.MultipleWeights, 19, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.MultipleWeights;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Amount, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Amount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Taxamount, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Taxamount;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.CreateDate, 22, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.CreateDate;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Jwitem, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Jwitem;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Xtype, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Xtype;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Taxable, 25, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Taxable;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.UmStyle, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.UmStyle;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Productweight, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Productweight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.MwBuffer, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.MwBuffer;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.SourceTicketInfo, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.SourceTicketInfo;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Polid, 30, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Polid;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Catid, 31, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.Scatid, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.LineTypeUCode, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.LineTypeUCode;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(WtaPoLineMetadata.ColumnNames.WeightType, 34, typeof(System.String), esSystemType.String);
			c.PropertyName = WtaPoLineMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public WtaPoLineMetadata Meta()
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
			 public const string Poid = "poid";
			 public const string LineNum = "line_num";
			 public const string Productcode = "productcode";
			 public const string Productdescription = "productdescription";
			 public const string Productaltcode = "productaltcode";
			 public const string Productaltdescription = "productaltdescription";
			 public const string Vendorcode = "vendorcode";
			 public const string Vendordescription = "vendordescription";
			 public const string Vendoraltcode = "vendoraltcode";
			 public const string Vendoraltdescription = "vendoraltdescription";
			 public const string Um = "um";
			 public const string Qty = "qty";
			 public const string Wprice = "wprice";
			 public const string Weight = "weight";
			 public const string Casecount = "casecount";
			 public const string TruckComment = "truck_comment";
			 public const string VendorComment = "vendor_comment";
			 public const string Status = "status";
			 public const string State = "state";
			 public const string MultipleWeights = "multiple_weights";
			 public const string Amount = "amount";
			 public const string Taxamount = "taxamount";
			 public const string CreateDate = "CreateDate";
			 public const string Jwitem = "jwitem";
			 public const string Xtype = "xtype";
			 public const string Taxable = "taxable";
			 public const string UmStyle = "um_style";
			 public const string Productweight = "productweight";
			 public const string MwBuffer = "mw_buffer";
			 public const string SourceTicketInfo = "SourceTicketInfo";
			 public const string Polid = "polid";
			 public const string Catid = "catid";
			 public const string Scatid = "scatid";
			 public const string LineTypeUCode = "LineTypeUCode";
			 public const string WeightType = "weight_type";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Poid = "Poid";
			 public const string LineNum = "LineNum";
			 public const string Productcode = "Productcode";
			 public const string Productdescription = "Productdescription";
			 public const string Productaltcode = "Productaltcode";
			 public const string Productaltdescription = "Productaltdescription";
			 public const string Vendorcode = "Vendorcode";
			 public const string Vendordescription = "Vendordescription";
			 public const string Vendoraltcode = "Vendoraltcode";
			 public const string Vendoraltdescription = "Vendoraltdescription";
			 public const string Um = "Um";
			 public const string Qty = "Qty";
			 public const string Wprice = "Wprice";
			 public const string Weight = "Weight";
			 public const string Casecount = "Casecount";
			 public const string TruckComment = "TruckComment";
			 public const string VendorComment = "VendorComment";
			 public const string Status = "Status";
			 public const string State = "State";
			 public const string MultipleWeights = "MultipleWeights";
			 public const string Amount = "Amount";
			 public const string Taxamount = "Taxamount";
			 public const string CreateDate = "CreateDate";
			 public const string Jwitem = "Jwitem";
			 public const string Xtype = "Xtype";
			 public const string Taxable = "Taxable";
			 public const string UmStyle = "UmStyle";
			 public const string Productweight = "Productweight";
			 public const string MwBuffer = "MwBuffer";
			 public const string SourceTicketInfo = "SourceTicketInfo";
			 public const string Polid = "Polid";
			 public const string Catid = "Catid";
			 public const string Scatid = "Scatid";
			 public const string LineTypeUCode = "LineTypeUCode";
			 public const string WeightType = "WeightType";
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
			lock (typeof(WtaPoLineMetadata))
			{
				if(WtaPoLineMetadata.mapDelegates == null)
				{
					WtaPoLineMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (WtaPoLineMetadata.meta == null)
				{
					WtaPoLineMetadata.meta = new WtaPoLineMetadata();
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
				

				meta.AddTypeMap("Poid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LineNum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Productaltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendorcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendordescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Vendoraltdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Um", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Wprice", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TruckComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("VendorComment", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("State", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("MultipleWeights", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Amount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Taxamount", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("CreateDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Jwitem", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Xtype", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Taxable", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("UmStyle", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productweight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("MwBuffer", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SourceTicketInfo", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Polid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LineTypeUCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("WeightType", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "wta_po_line";
				meta.Destination = "wta_po_line";
				
				meta.spInsert = "proc_wta_po_lineInsert";				
				meta.spUpdate = "proc_wta_po_lineUpdate";		
				meta.spDelete = "proc_wta_po_lineDelete";
				meta.spLoadAll = "proc_wta_po_lineLoadAll";
				meta.spLoadByPrimaryKey = "proc_wta_po_lineLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private WtaPoLineMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
