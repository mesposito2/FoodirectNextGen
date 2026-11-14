/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 5/14/2023 5:34:19 PM
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
	abstract public class esUsersCollection : esEntityCollection
	{
		public esUsersCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "UsersCollection";
		}

		#region Query Logic
		protected void InitQuery(esUsersQuery query)
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
			this.InitQuery(query as esUsersQuery);
		}
		#endregion
		
		virtual public UsersBO DetachEntity(UsersBO entity)
		{
			return base.DetachEntity(entity) as UsersBO;
		}
		
		virtual public UsersBO AttachEntity(UsersBO entity)
		{
			return base.AttachEntity(entity) as UsersBO;
		}
		
		virtual public void Combine(UsersCollection collection)
		{
			base.Combine(collection);
		}
		
		new public UsersBO this[int index]
		{
			get
			{
				return base[index] as UsersBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(UsersBO);
		}
	}



	[Serializable]
	abstract public class esUsersBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esUsersQuery GetDynamicQuery()
		{
			return null;
		}

		public esUsersBO()
		{

		}

		public esUsersBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String custid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(custid);
			else
				return LoadByPrimaryKeyStoredProcedure(custid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String custid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(custid);
			else
				return LoadByPrimaryKeyStoredProcedure(custid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String custid)
		{
			esUsersQuery query = this.GetDynamicQuery();
			query.Where(query.Custid == custid);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String custid)
		{
			esParameters parms = new esParameters();
			parms.Add("custid",custid);
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
						case "Custid": this.str.Custid = (string)value; break;							
						case "Type": this.str.Type = (string)value; break;							
						case "Internetid": this.str.Internetid = (string)value; break;							
						case "Access": this.str.Access = (string)value; break;							
						case "Notes": this.str.Notes = (string)value; break;							
						case "Altcode": this.str.Altcode = (string)value; break;							
						case "Jobberid": this.str.Jobberid = (string)value; break;							
						case "Bizname": this.str.Bizname = (string)value; break;							
						case "Contactname": this.str.Contactname = (string)value; break;							
						case "Address1": this.str.Address1 = (string)value; break;							
						case "Address2": this.str.Address2 = (string)value; break;							
						case "City": this.str.City = (string)value; break;							
						case "State": this.str.State = (string)value; break;							
						case "Zip": this.str.Zip = (string)value; break;							
						case "Zip4": this.str.Zip4 = (string)value; break;							
						case "Telephone": this.str.Telephone = (string)value; break;							
						case "Fax": this.str.Fax = (string)value; break;							
						case "Cell": this.str.Cell = (string)value; break;							
						case "Faxmachine": this.str.Faxmachine = (string)value; break;							
						case "Email": this.str.Email = (string)value; break;							
						case "Sendfax": this.str.Sendfax = (string)value; break;							
						case "Sendemail": this.str.Sendemail = (string)value; break;							
						case "Sendmail": this.str.Sendmail = (string)value; break;							
						case "Flags": this.str.Flags = (string)value; break;							
						case "Custcatb": this.str.Custcatb = (string)value; break;							
						case "CustcatbRoll": this.str.CustcatbRoll = (string)value; break;							
						case "Source": this.str.Source = (string)value; break;							
						case "PMargin": this.str.PMargin = (string)value; break;							
						case "PPageCol": this.str.PPageCol = (string)value; break;							
						case "PFontSize": this.str.PFontSize = (string)value; break;							
						case "PFont": this.str.PFont = (string)value; break;							
						case "Accpay": this.str.Accpay = (string)value; break;							
						case "Salesheetlabel": this.str.Salesheetlabel = (string)value; break;							
						case "Password": this.str.Password = (string)value; break;							
						case "WtaRouteRid": this.str.WtaRouteRid = (string)value; break;							
						case "SalesTaxType": this.str.SalesTaxType = (string)value; break;							
						case "Qbid": this.str.Qbid = (string)value; break;							
						case "FoodirectQbid": this.str.FoodirectQbid = (string)value; break;							
						case "SalesTaxRegion": this.str.SalesTaxRegion = (string)value; break;							
						case "InvoiceAger": this.str.InvoiceAger = (string)value; break;							
						case "WtaAccess": this.str.WtaAccess = (string)value; break;							
						case "WtaLock": this.str.WtaLock = (string)value; break;							
						case "BeefMarkup": this.str.BeefMarkup = (string)value; break;							
						case "GroupCode": this.str.GroupCode = (string)value; break;							
						case "Taxable": this.str.Taxable = (string)value; break;							
						case "SlmInit": this.str.SlmInit = (string)value; break;							
						case "SlmName": this.str.SlmName = (string)value; break;							
						case "CanOrder": this.str.CanOrder = (string)value; break;							
						case "TierCode": this.str.TierCode = (string)value; break;							
						case "TierPCT": this.str.TierPCT = (string)value; break;							
						case "XEmail1": this.str.XEmail1 = (string)value; break;							
						case "XEmail2": this.str.XEmail2 = (string)value; break;							
						case "XEmail3": this.str.XEmail3 = (string)value; break;							
						case "XEmail4": this.str.XEmail4 = (string)value; break;							
						case "AgerCurrent": this.str.AgerCurrent = (string)value; break;							
						case "AgerWeek1": this.str.AgerWeek1 = (string)value; break;							
						case "AgerWeek2": this.str.AgerWeek2 = (string)value; break;							
						case "AgerWeek3": this.str.AgerWeek3 = (string)value; break;							
						case "AgerWeek4": this.str.AgerWeek4 = (string)value; break;							
						case "AgerWeek5": this.str.AgerWeek5 = (string)value; break;							
						case "AgerWeek6": this.str.AgerWeek6 = (string)value; break;							
						case "LastBookFile": this.str.LastBookFile = (string)value; break;							
						case "CanViewInventoryDetails": this.str.CanViewInventoryDetails = (string)value; break;							
						case "ChainCode": this.str.ChainCode = (string)value; break;							
						case "UseProdCustGuide": this.str.UseProdCustGuide = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Type":
						
							if (value == null || value is System.Int16)
								this.Type = (System.Int16?)value;
							break;
						
						case "Access":
						
							if (value == null || value is System.Int32)
								this.Access = (System.Int32?)value;
							break;
						
						case "Faxmachine":
						
							if (value == null || value is System.Int16)
								this.Faxmachine = (System.Int16?)value;
							break;
						
						case "Sendfax":
						
							if (value == null || value is System.Boolean)
								this.Sendfax = (System.Boolean?)value;
							break;
						
						case "Sendemail":
						
							if (value == null || value is System.Boolean)
								this.Sendemail = (System.Boolean?)value;
							break;
						
						case "Sendmail":
						
							if (value == null || value is System.Boolean)
								this.Sendmail = (System.Boolean?)value;
							break;
						
						case "Flags":
						
							if (value == null || value is System.Int32)
								this.Flags = (System.Int32?)value;
							break;
						
						case "Source":
						
							if (value == null || value is System.Int32)
								this.Source = (System.Int32?)value;
							break;
						
						case "PMargin":
						
							if (value == null || value is System.Int32)
								this.PMargin = (System.Int32?)value;
							break;
						
						case "PPageCol":
						
							if (value == null || value is System.Int32)
								this.PPageCol = (System.Int32?)value;
							break;
						
						case "PFontSize":
						
							if (value == null || value is System.Int32)
								this.PFontSize = (System.Int32?)value;
							break;
						
						case "Accpay":
						
							if (value == null || value is System.Int32)
								this.Accpay = (System.Int32?)value;
							break;
						
						case "WtaRouteRid":
						
							if (value == null || value is System.Int32)
								this.WtaRouteRid = (System.Int32?)value;
							break;
						
						case "SalesTaxType":
						
							if (value == null || value is System.Int32)
								this.SalesTaxType = (System.Int32?)value;
							break;
						
						case "InvoiceAger":
						
							if (value == null || value is System.Boolean)
								this.InvoiceAger = (System.Boolean?)value;
							break;
						
						case "WtaAccess":
						
							if (value == null || value is System.Int32)
								this.WtaAccess = (System.Int32?)value;
							break;
						
						case "WtaLock":
						
							if (value == null || value is System.Int32)
								this.WtaLock = (System.Int32?)value;
							break;
						
						case "BeefMarkup":
						
							if (value == null || value is System.Double)
								this.BeefMarkup = (System.Double?)value;
							break;
						
						case "CanOrder":
						
							if (value == null || value is System.Boolean)
								this.CanOrder = (System.Boolean?)value;
							break;
						
						case "TierPCT":
						
							if (value == null || value is System.Int32)
								this.TierPCT = (System.Int32?)value;
							break;
						
						case "AgerCurrent":
						
							if (value == null || value is System.Double)
								this.AgerCurrent = (System.Double?)value;
							break;
						
						case "AgerWeek1":
						
							if (value == null || value is System.Double)
								this.AgerWeek1 = (System.Double?)value;
							break;
						
						case "AgerWeek2":
						
							if (value == null || value is System.Double)
								this.AgerWeek2 = (System.Double?)value;
							break;
						
						case "AgerWeek3":
						
							if (value == null || value is System.Double)
								this.AgerWeek3 = (System.Double?)value;
							break;
						
						case "AgerWeek4":
						
							if (value == null || value is System.Double)
								this.AgerWeek4 = (System.Double?)value;
							break;
						
						case "AgerWeek5":
						
							if (value == null || value is System.Double)
								this.AgerWeek5 = (System.Double?)value;
							break;
						
						case "AgerWeek6":
						
							if (value == null || value is System.Double)
								this.AgerWeek6 = (System.Double?)value;
							break;
						
						case "CanViewInventoryDetails":
						
							if (value == null || value is System.Boolean)
								this.CanViewInventoryDetails = (System.Boolean?)value;
							break;
						
						case "UseProdCustGuide":
						
							if (value == null || value is System.Boolean)
								this.UseProdCustGuide = (System.Boolean?)value;
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
		/// Maps to users.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.type
		/// </summary>
		virtual public System.Int16? Type
		{
			get
			{
				return base.GetSystemInt16(UsersMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemInt16(UsersMetadata.ColumnNames.Type, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Type));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.internetid
		/// </summary>
		virtual public System.String Internetid
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Internetid);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Internetid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Internetid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.access
		/// </summary>
		virtual public System.Int32? Access
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.Access);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.Access, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Access));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.notes
		/// </summary>
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Notes, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Notes));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.altcode
		/// </summary>
		virtual public System.String Altcode
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Altcode);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Altcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Altcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.jobberid
		/// </summary>
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Jobberid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Jobberid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.bizname
		/// </summary>
		virtual public System.String Bizname
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Bizname);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Bizname, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Bizname));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.contactname
		/// </summary>
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Contactname, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Contactname));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.address1
		/// </summary>
		virtual public System.String Address1
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Address1);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Address1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Address1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.address2
		/// </summary>
		virtual public System.String Address2
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Address2);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Address2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Address2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.city
		/// </summary>
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.City, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.City));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.state
		/// </summary>
		virtual public System.String State
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.State, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.State));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.zip
		/// </summary>
		virtual public System.String Zip
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Zip);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Zip, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Zip));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.zip4
		/// </summary>
		virtual public System.String Zip4
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Zip4);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Zip4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Zip4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.telephone
		/// </summary>
		virtual public System.String Telephone
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Telephone);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Telephone, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Telephone));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.fax
		/// </summary>
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Fax, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Fax));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.cell
		/// </summary>
		virtual public System.String Cell
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Cell);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Cell, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Cell));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.faxmachine
		/// </summary>
		virtual public System.Int16? Faxmachine
		{
			get
			{
				return base.GetSystemInt16(UsersMetadata.ColumnNames.Faxmachine);
			}
			
			set
			{
				if(base.SetSystemInt16(UsersMetadata.ColumnNames.Faxmachine, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Faxmachine));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.email
		/// </summary>
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Email, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Email));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendfax
		/// </summary>
		virtual public System.Boolean? Sendfax
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.Sendfax);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.Sendfax, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Sendfax));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendemail
		/// </summary>
		virtual public System.Boolean? Sendemail
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.Sendemail);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.Sendemail, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Sendemail));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendmail
		/// </summary>
		virtual public System.Boolean? Sendmail
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.Sendmail);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.Sendmail, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Sendmail));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.flags
		/// </summary>
		virtual public System.Int32? Flags
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.Flags);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.Flags, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Flags));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.custcatb
		/// </summary>
		virtual public System.String Custcatb
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Custcatb);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Custcatb, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Custcatb));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.custcatb_roll
		/// </summary>
		virtual public System.String CustcatbRoll
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.CustcatbRoll);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.CustcatbRoll, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.CustcatbRoll));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.source
		/// </summary>
		virtual public System.Int32? Source
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.Source);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.Source, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Source));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pMargin
		/// </summary>
		virtual public System.Int32? PMargin
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.PMargin);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.PMargin, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.PMargin));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pPageCol
		/// </summary>
		virtual public System.Int32? PPageCol
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.PPageCol);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.PPageCol, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.PPageCol));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pFontSize
		/// </summary>
		virtual public System.Int32? PFontSize
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.PFontSize);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.PFontSize, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.PFontSize));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pFont
		/// </summary>
		virtual public System.String PFont
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.PFont);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.PFont, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.PFont));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.accpay
		/// </summary>
		virtual public System.Int32? Accpay
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.Accpay);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.Accpay, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Accpay));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.salesheetlabel
		/// </summary>
		virtual public System.String Salesheetlabel
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Salesheetlabel);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Salesheetlabel, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Salesheetlabel));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.password
		/// </summary>
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Password, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Password));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_route_rid
		/// </summary>
		virtual public System.Int32? WtaRouteRid
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.WtaRouteRid);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.WtaRouteRid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.WtaRouteRid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sales_tax_type
		/// </summary>
		virtual public System.Int32? SalesTaxType
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.SalesTaxType);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.SalesTaxType, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.SalesTaxType));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.qbid
		/// </summary>
		virtual public System.String Qbid
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Qbid);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Qbid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Qbid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.foodirect_qbid
		/// </summary>
		virtual public System.String FoodirectQbid
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.FoodirectQbid);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.FoodirectQbid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.FoodirectQbid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sales_tax_region
		/// </summary>
		virtual public System.String SalesTaxRegion
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.SalesTaxRegion);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.SalesTaxRegion, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.SalesTaxRegion));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.invoice_ager
		/// </summary>
		virtual public System.Boolean? InvoiceAger
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.InvoiceAger);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.InvoiceAger, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.InvoiceAger));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_access
		/// </summary>
		virtual public System.Int32? WtaAccess
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.WtaAccess);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.WtaAccess, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.WtaAccess));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_lock
		/// </summary>
		virtual public System.Int32? WtaLock
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.WtaLock);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.WtaLock, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.WtaLock));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.BeefMarkup
		/// </summary>
		virtual public System.Double? BeefMarkup
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.BeefMarkup);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.BeefMarkup, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.BeefMarkup));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.GroupCode
		/// </summary>
		virtual public System.String GroupCode
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.GroupCode);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.GroupCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.GroupCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.taxable
		/// </summary>
		virtual public System.String Taxable
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.Taxable, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.Taxable));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.SlmInit
		/// </summary>
		virtual public System.String SlmInit
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.SlmInit);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.SlmInit, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.SlmInit));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.SlmName
		/// </summary>
		virtual public System.String SlmName
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.SlmName);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.SlmName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.SlmName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.CanOrder
		/// </summary>
		virtual public System.Boolean? CanOrder
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.CanOrder);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.CanOrder, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.CanOrder));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.TierCode
		/// </summary>
		virtual public System.String TierCode
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.TierCode);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.TierCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.TierCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.TierPCT
		/// </summary>
		virtual public System.Int32? TierPCT
		{
			get
			{
				return base.GetSystemInt32(UsersMetadata.ColumnNames.TierPCT);
			}
			
			set
			{
				if(base.SetSystemInt32(UsersMetadata.ColumnNames.TierPCT, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.TierPCT));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail1
		/// </summary>
		virtual public System.String XEmail1
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.XEmail1);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.XEmail1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.XEmail1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail2
		/// </summary>
		virtual public System.String XEmail2
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.XEmail2);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.XEmail2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.XEmail2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail3
		/// </summary>
		virtual public System.String XEmail3
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.XEmail3);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.XEmail3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.XEmail3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail4
		/// </summary>
		virtual public System.String XEmail4
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.XEmail4);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.XEmail4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.XEmail4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_current
		/// </summary>
		virtual public System.Double? AgerCurrent
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerCurrent);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerCurrent, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerCurrent));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week1
		/// </summary>
		virtual public System.Double? AgerWeek1
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek1);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week2
		/// </summary>
		virtual public System.Double? AgerWeek2
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek2);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week3
		/// </summary>
		virtual public System.Double? AgerWeek3
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek3);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week4
		/// </summary>
		virtual public System.Double? AgerWeek4
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek4);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week5
		/// </summary>
		virtual public System.Double? AgerWeek5
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek5);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek5, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek5));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week6
		/// </summary>
		virtual public System.Double? AgerWeek6
		{
			get
			{
				return base.GetSystemDouble(UsersMetadata.ColumnNames.AgerWeek6);
			}
			
			set
			{
				if(base.SetSystemDouble(UsersMetadata.ColumnNames.AgerWeek6, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.AgerWeek6));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.lastBookFile
		/// </summary>
		virtual public System.String LastBookFile
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.LastBookFile);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.LastBookFile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.LastBookFile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.CanViewInventoryDetails
		/// </summary>
		virtual public System.Boolean? CanViewInventoryDetails
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.CanViewInventoryDetails);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.CanViewInventoryDetails, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.CanViewInventoryDetails));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ChainCode
		/// </summary>
		virtual public System.String ChainCode
		{
			get
			{
				return base.GetSystemString(UsersMetadata.ColumnNames.ChainCode);
			}
			
			set
			{
				if(base.SetSystemString(UsersMetadata.ColumnNames.ChainCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.ChainCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to users.UseProdCustGuide
		/// </summary>
		virtual public System.Boolean? UseProdCustGuide
		{
			get
			{
				return base.GetSystemBoolean(UsersMetadata.ColumnNames.UseProdCustGuide);
			}
			
			set
			{
				if(base.SetSystemBoolean(UsersMetadata.ColumnNames.UseProdCustGuide, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UsersMetadata.PropertyNames.UseProdCustGuide));
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
			public esStrings(esUsersBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Custid
			{
				get
				{
					System.String data = entity.Custid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Custid = null;
					else entity.Custid = Convert.ToString(value);
				}
			}
				
			public System.String Type
			{
				get
				{
					System.Int16? data = entity.Type;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Type = null;
					else entity.Type = Convert.ToInt16(value);
				}
			}
				
			public System.String Internetid
			{
				get
				{
					System.String data = entity.Internetid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Internetid = null;
					else entity.Internetid = Convert.ToString(value);
				}
			}
				
			public System.String Access
			{
				get
				{
					System.Int32? data = entity.Access;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Access = null;
					else entity.Access = Convert.ToInt32(value);
				}
			}
				
			public System.String Notes
			{
				get
				{
					System.String data = entity.Notes;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Notes = null;
					else entity.Notes = Convert.ToString(value);
				}
			}
				
			public System.String Altcode
			{
				get
				{
					System.String data = entity.Altcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Altcode = null;
					else entity.Altcode = Convert.ToString(value);
				}
			}
				
			public System.String Jobberid
			{
				get
				{
					System.String data = entity.Jobberid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jobberid = null;
					else entity.Jobberid = Convert.ToString(value);
				}
			}
				
			public System.String Bizname
			{
				get
				{
					System.String data = entity.Bizname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Bizname = null;
					else entity.Bizname = Convert.ToString(value);
				}
			}
				
			public System.String Contactname
			{
				get
				{
					System.String data = entity.Contactname;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Contactname = null;
					else entity.Contactname = Convert.ToString(value);
				}
			}
				
			public System.String Address1
			{
				get
				{
					System.String data = entity.Address1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Address1 = null;
					else entity.Address1 = Convert.ToString(value);
				}
			}
				
			public System.String Address2
			{
				get
				{
					System.String data = entity.Address2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Address2 = null;
					else entity.Address2 = Convert.ToString(value);
				}
			}
				
			public System.String City
			{
				get
				{
					System.String data = entity.City;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.City = null;
					else entity.City = Convert.ToString(value);
				}
			}
				
			public System.String State
			{
				get
				{
					System.String data = entity.State;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.State = null;
					else entity.State = Convert.ToString(value);
				}
			}
				
			public System.String Zip
			{
				get
				{
					System.String data = entity.Zip;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Zip = null;
					else entity.Zip = Convert.ToString(value);
				}
			}
				
			public System.String Zip4
			{
				get
				{
					System.String data = entity.Zip4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Zip4 = null;
					else entity.Zip4 = Convert.ToString(value);
				}
			}
				
			public System.String Telephone
			{
				get
				{
					System.String data = entity.Telephone;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Telephone = null;
					else entity.Telephone = Convert.ToString(value);
				}
			}
				
			public System.String Fax
			{
				get
				{
					System.String data = entity.Fax;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fax = null;
					else entity.Fax = Convert.ToString(value);
				}
			}
				
			public System.String Cell
			{
				get
				{
					System.String data = entity.Cell;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Cell = null;
					else entity.Cell = Convert.ToString(value);
				}
			}
				
			public System.String Faxmachine
			{
				get
				{
					System.Int16? data = entity.Faxmachine;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Faxmachine = null;
					else entity.Faxmachine = Convert.ToInt16(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String Sendfax
			{
				get
				{
					System.Boolean? data = entity.Sendfax;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sendfax = null;
					else entity.Sendfax = Convert.ToBoolean(value);
				}
			}
				
			public System.String Sendemail
			{
				get
				{
					System.Boolean? data = entity.Sendemail;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sendemail = null;
					else entity.Sendemail = Convert.ToBoolean(value);
				}
			}
				
			public System.String Sendmail
			{
				get
				{
					System.Boolean? data = entity.Sendmail;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sendmail = null;
					else entity.Sendmail = Convert.ToBoolean(value);
				}
			}
				
			public System.String Flags
			{
				get
				{
					System.Int32? data = entity.Flags;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Flags = null;
					else entity.Flags = Convert.ToInt32(value);
				}
			}
				
			public System.String Custcatb
			{
				get
				{
					System.String data = entity.Custcatb;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Custcatb = null;
					else entity.Custcatb = Convert.ToString(value);
				}
			}
				
			public System.String CustcatbRoll
			{
				get
				{
					System.String data = entity.CustcatbRoll;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CustcatbRoll = null;
					else entity.CustcatbRoll = Convert.ToString(value);
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
				
			public System.String PMargin
			{
				get
				{
					System.Int32? data = entity.PMargin;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PMargin = null;
					else entity.PMargin = Convert.ToInt32(value);
				}
			}
				
			public System.String PPageCol
			{
				get
				{
					System.Int32? data = entity.PPageCol;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PPageCol = null;
					else entity.PPageCol = Convert.ToInt32(value);
				}
			}
				
			public System.String PFontSize
			{
				get
				{
					System.Int32? data = entity.PFontSize;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PFontSize = null;
					else entity.PFontSize = Convert.ToInt32(value);
				}
			}
				
			public System.String PFont
			{
				get
				{
					System.String data = entity.PFont;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PFont = null;
					else entity.PFont = Convert.ToString(value);
				}
			}
				
			public System.String Accpay
			{
				get
				{
					System.Int32? data = entity.Accpay;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Accpay = null;
					else entity.Accpay = Convert.ToInt32(value);
				}
			}
				
			public System.String Salesheetlabel
			{
				get
				{
					System.String data = entity.Salesheetlabel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Salesheetlabel = null;
					else entity.Salesheetlabel = Convert.ToString(value);
				}
			}
				
			public System.String Password
			{
				get
				{
					System.String data = entity.Password;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Password = null;
					else entity.Password = Convert.ToString(value);
				}
			}
				
			public System.String WtaRouteRid
			{
				get
				{
					System.Int32? data = entity.WtaRouteRid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WtaRouteRid = null;
					else entity.WtaRouteRid = Convert.ToInt32(value);
				}
			}
				
			public System.String SalesTaxType
			{
				get
				{
					System.Int32? data = entity.SalesTaxType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalesTaxType = null;
					else entity.SalesTaxType = Convert.ToInt32(value);
				}
			}
				
			public System.String Qbid
			{
				get
				{
					System.String data = entity.Qbid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qbid = null;
					else entity.Qbid = Convert.ToString(value);
				}
			}
				
			public System.String FoodirectQbid
			{
				get
				{
					System.String data = entity.FoodirectQbid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FoodirectQbid = null;
					else entity.FoodirectQbid = Convert.ToString(value);
				}
			}
				
			public System.String SalesTaxRegion
			{
				get
				{
					System.String data = entity.SalesTaxRegion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalesTaxRegion = null;
					else entity.SalesTaxRegion = Convert.ToString(value);
				}
			}
				
			public System.String InvoiceAger
			{
				get
				{
					System.Boolean? data = entity.InvoiceAger;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InvoiceAger = null;
					else entity.InvoiceAger = Convert.ToBoolean(value);
				}
			}
				
			public System.String WtaAccess
			{
				get
				{
					System.Int32? data = entity.WtaAccess;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WtaAccess = null;
					else entity.WtaAccess = Convert.ToInt32(value);
				}
			}
				
			public System.String WtaLock
			{
				get
				{
					System.Int32? data = entity.WtaLock;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WtaLock = null;
					else entity.WtaLock = Convert.ToInt32(value);
				}
			}
				
			public System.String BeefMarkup
			{
				get
				{
					System.Double? data = entity.BeefMarkup;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BeefMarkup = null;
					else entity.BeefMarkup = Convert.ToDouble(value);
				}
			}
				
			public System.String GroupCode
			{
				get
				{
					System.String data = entity.GroupCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.GroupCode = null;
					else entity.GroupCode = Convert.ToString(value);
				}
			}
				
			public System.String Taxable
			{
				get
				{
					System.String data = entity.Taxable;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Taxable = null;
					else entity.Taxable = Convert.ToString(value);
				}
			}
				
			public System.String SlmInit
			{
				get
				{
					System.String data = entity.SlmInit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SlmInit = null;
					else entity.SlmInit = Convert.ToString(value);
				}
			}
				
			public System.String SlmName
			{
				get
				{
					System.String data = entity.SlmName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SlmName = null;
					else entity.SlmName = Convert.ToString(value);
				}
			}
				
			public System.String CanOrder
			{
				get
				{
					System.Boolean? data = entity.CanOrder;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CanOrder = null;
					else entity.CanOrder = Convert.ToBoolean(value);
				}
			}
				
			public System.String TierCode
			{
				get
				{
					System.String data = entity.TierCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TierCode = null;
					else entity.TierCode = Convert.ToString(value);
				}
			}
				
			public System.String TierPCT
			{
				get
				{
					System.Int32? data = entity.TierPCT;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TierPCT = null;
					else entity.TierPCT = Convert.ToInt32(value);
				}
			}
				
			public System.String XEmail1
			{
				get
				{
					System.String data = entity.XEmail1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.XEmail1 = null;
					else entity.XEmail1 = Convert.ToString(value);
				}
			}
				
			public System.String XEmail2
			{
				get
				{
					System.String data = entity.XEmail2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.XEmail2 = null;
					else entity.XEmail2 = Convert.ToString(value);
				}
			}
				
			public System.String XEmail3
			{
				get
				{
					System.String data = entity.XEmail3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.XEmail3 = null;
					else entity.XEmail3 = Convert.ToString(value);
				}
			}
				
			public System.String XEmail4
			{
				get
				{
					System.String data = entity.XEmail4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.XEmail4 = null;
					else entity.XEmail4 = Convert.ToString(value);
				}
			}
				
			public System.String AgerCurrent
			{
				get
				{
					System.Double? data = entity.AgerCurrent;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerCurrent = null;
					else entity.AgerCurrent = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek1
			{
				get
				{
					System.Double? data = entity.AgerWeek1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek1 = null;
					else entity.AgerWeek1 = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek2
			{
				get
				{
					System.Double? data = entity.AgerWeek2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek2 = null;
					else entity.AgerWeek2 = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek3
			{
				get
				{
					System.Double? data = entity.AgerWeek3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek3 = null;
					else entity.AgerWeek3 = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek4
			{
				get
				{
					System.Double? data = entity.AgerWeek4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek4 = null;
					else entity.AgerWeek4 = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek5
			{
				get
				{
					System.Double? data = entity.AgerWeek5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek5 = null;
					else entity.AgerWeek5 = Convert.ToDouble(value);
				}
			}
				
			public System.String AgerWeek6
			{
				get
				{
					System.Double? data = entity.AgerWeek6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AgerWeek6 = null;
					else entity.AgerWeek6 = Convert.ToDouble(value);
				}
			}
				
			public System.String LastBookFile
			{
				get
				{
					System.String data = entity.LastBookFile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastBookFile = null;
					else entity.LastBookFile = Convert.ToString(value);
				}
			}
				
			public System.String CanViewInventoryDetails
			{
				get
				{
					System.Boolean? data = entity.CanViewInventoryDetails;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CanViewInventoryDetails = null;
					else entity.CanViewInventoryDetails = Convert.ToBoolean(value);
				}
			}
				
			public System.String ChainCode
			{
				get
				{
					System.String data = entity.ChainCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChainCode = null;
					else entity.ChainCode = Convert.ToString(value);
				}
			}
				
			public System.String UseProdCustGuide
			{
				get
				{
					System.Boolean? data = entity.UseProdCustGuide;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UseProdCustGuide = null;
					else entity.UseProdCustGuide = Convert.ToBoolean(value);
				}
			}
			

			private esUsersBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esUsersQuery query)
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
				throw new Exception("esUsersBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esUsersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UsersMetadata.Meta();
			}
		}	
		

		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Type
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Type, esSystemType.Int16);
			}
		} 
		
		public esQueryItem Internetid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Internetid, esSystemType.String);
			}
		} 
		
		public esQueryItem Access
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Access, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Notes
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Notes, esSystemType.String);
			}
		} 
		
		public esQueryItem Altcode
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Altcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Jobberid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Jobberid, esSystemType.String);
			}
		} 
		
		public esQueryItem Bizname
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Bizname, esSystemType.String);
			}
		} 
		
		public esQueryItem Contactname
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Contactname, esSystemType.String);
			}
		} 
		
		public esQueryItem Address1
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Address1, esSystemType.String);
			}
		} 
		
		public esQueryItem Address2
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Address2, esSystemType.String);
			}
		} 
		
		public esQueryItem City
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.City, esSystemType.String);
			}
		} 
		
		public esQueryItem State
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.State, esSystemType.String);
			}
		} 
		
		public esQueryItem Zip
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Zip, esSystemType.String);
			}
		} 
		
		public esQueryItem Zip4
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Zip4, esSystemType.String);
			}
		} 
		
		public esQueryItem Telephone
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Telephone, esSystemType.String);
			}
		} 
		
		public esQueryItem Fax
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Fax, esSystemType.String);
			}
		} 
		
		public esQueryItem Cell
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Cell, esSystemType.String);
			}
		} 
		
		public esQueryItem Faxmachine
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Faxmachine, esSystemType.Int16);
			}
		} 
		
		public esQueryItem Email
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Email, esSystemType.String);
			}
		} 
		
		public esQueryItem Sendfax
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Sendfax, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Sendemail
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Sendemail, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Sendmail
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Sendmail, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Flags
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Flags, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Custcatb
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Custcatb, esSystemType.String);
			}
		} 
		
		public esQueryItem CustcatbRoll
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.CustcatbRoll, esSystemType.String);
			}
		} 
		
		public esQueryItem Source
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Source, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PMargin
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.PMargin, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PPageCol
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.PPageCol, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PFontSize
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.PFontSize, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PFont
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.PFont, esSystemType.String);
			}
		} 
		
		public esQueryItem Accpay
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Accpay, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Salesheetlabel
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Salesheetlabel, esSystemType.String);
			}
		} 
		
		public esQueryItem Password
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Password, esSystemType.String);
			}
		} 
		
		public esQueryItem WtaRouteRid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.WtaRouteRid, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SalesTaxType
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.SalesTaxType, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Qbid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Qbid, esSystemType.String);
			}
		} 
		
		public esQueryItem FoodirectQbid
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.FoodirectQbid, esSystemType.String);
			}
		} 
		
		public esQueryItem SalesTaxRegion
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.SalesTaxRegion, esSystemType.String);
			}
		} 
		
		public esQueryItem InvoiceAger
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.InvoiceAger, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem WtaAccess
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.WtaAccess, esSystemType.Int32);
			}
		} 
		
		public esQueryItem WtaLock
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.WtaLock, esSystemType.Int32);
			}
		} 
		
		public esQueryItem BeefMarkup
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.BeefMarkup, esSystemType.Double);
			}
		} 
		
		public esQueryItem GroupCode
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.GroupCode, esSystemType.String);
			}
		} 
		
		public esQueryItem Taxable
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.Taxable, esSystemType.String);
			}
		} 
		
		public esQueryItem SlmInit
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.SlmInit, esSystemType.String);
			}
		} 
		
		public esQueryItem SlmName
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.SlmName, esSystemType.String);
			}
		} 
		
		public esQueryItem CanOrder
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.CanOrder, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem TierCode
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.TierCode, esSystemType.String);
			}
		} 
		
		public esQueryItem TierPCT
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.TierPCT, esSystemType.Int32);
			}
		} 
		
		public esQueryItem XEmail1
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail1, esSystemType.String);
			}
		} 
		
		public esQueryItem XEmail2
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail2, esSystemType.String);
			}
		} 
		
		public esQueryItem XEmail3
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail3, esSystemType.String);
			}
		} 
		
		public esQueryItem XEmail4
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail4, esSystemType.String);
			}
		} 
		
		public esQueryItem AgerCurrent
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerCurrent, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek1
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek1, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek2
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek2, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek3
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek3, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek4
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek4, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek5
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek5, esSystemType.Double);
			}
		} 
		
		public esQueryItem AgerWeek6
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek6, esSystemType.Double);
			}
		} 
		
		public esQueryItem LastBookFile
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.LastBookFile, esSystemType.String);
			}
		} 
		
		public esQueryItem CanViewInventoryDetails
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.CanViewInventoryDetails, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem ChainCode
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.ChainCode, esSystemType.String);
			}
		} 
		
		public esQueryItem UseProdCustGuide
		{
			get
			{
				return new esQueryItem(this, UsersMetadata.ColumnNames.UseProdCustGuide, esSystemType.Boolean);
			}
		} 
		
	}



	[Serializable]
	[XmlType("UsersCollection")]
	public partial class UsersCollection : esUsersCollection, IEnumerable<UsersBO>
	{
		public UsersCollection()
		{

		}
		
		public static implicit operator List<UsersBO>(UsersCollection coll)
		{
			List<UsersBO> list = new List<UsersBO>();
			
			foreach (UsersBO emp in coll)
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
				return  UsersMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UsersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new UsersBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new UsersBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public UsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(UsersQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public UsersBO AddNew()
		{
			UsersBO entity = base.AddNewEntity() as UsersBO;
			
			return entity;
		}

		public UsersBO FindByPrimaryKey(System.String custid)
		{
			return base.FindByPrimaryKey(custid) as UsersBO;
		}


		#region IEnumerable<UsersBO> Members

		IEnumerator<UsersBO> IEnumerable<UsersBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as UsersBO;
			}
		}

		#endregion
		
		private UsersQuery query;
	}


	/// <summary>
	/// Encapsulates the 'users' table
	/// </summary>

	[Serializable]
	public partial class UsersBO : esUsersBO
	{
		public UsersBO()
		{

		}
	
		public UsersBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UsersMetadata.Meta();
			}
		}
		
		
		
		override protected esUsersQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UsersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public UsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(UsersQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private UsersQuery query;
	}



	[Serializable]
		
	public partial class UsersQuery : esUsersQuery
	{
		public UsersQuery()
		{

		}		
		
		public UsersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "UsersQuery";
        }
		
			
	}


	[Serializable]
	public partial class UsersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UsersMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UsersMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Custid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Type, 1, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = UsersMetadata.PropertyNames.Type;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Internetid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Internetid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Access, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Access;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Notes, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Altcode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Altcode;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Jobberid, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Bizname, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Bizname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Contactname, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Contactname;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Address1, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Address1;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Address2, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Address2;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.City, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.State, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.State;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Zip, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Zip;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Zip4, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Zip4;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Telephone, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Telephone;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Fax, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Cell, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Cell;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Faxmachine, 18, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = UsersMetadata.PropertyNames.Faxmachine;
			c.NumericPrecision = 5;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Email, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendfax, 20, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendfax;
			c.HasDefault = true;
			c.Default = @"(0)";
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendemail, 21, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendemail;
			c.HasDefault = true;
			c.Default = @"(0)";
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendmail, 22, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendmail;
			c.HasDefault = true;
			c.Default = @"(0)";
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Flags, 23, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Flags;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Custcatb, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Custcatb;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CustcatbRoll, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.CustcatbRoll;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Source, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PMargin, 27, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PMargin;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(2)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PPageCol, 28, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PPageCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(110)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PFontSize, 29, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PFontSize;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(9)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PFont, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.PFont;
			c.CharacterMaxLength = 40;
			c.HasDefault = true;
			c.Default = @"('Courier New')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Accpay, 31, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Accpay;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Salesheetlabel, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Salesheetlabel;
			c.CharacterMaxLength = 250;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Password, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 30;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaRouteRid, 34, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaRouteRid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SalesTaxType, 35, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.SalesTaxType;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Qbid, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Qbid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.FoodirectQbid, 37, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.FoodirectQbid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SalesTaxRegion, 38, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SalesTaxRegion;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.InvoiceAger, 39, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.InvoiceAger;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaAccess, 40, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaAccess;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaLock, 41, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaLock;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.BeefMarkup, 42, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.BeefMarkup;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.GroupCode, 43, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.GroupCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Taxable, 44, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Taxable;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('N')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SlmInit, 45, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SlmInit;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SlmName, 46, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SlmName;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CanOrder, 47, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.CanOrder;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.TierCode, 48, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.TierCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.TierPCT, 49, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.TierPCT;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail1, 50, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail1;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail2, 51, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail3, 52, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail3;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail4, 53, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail4;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerCurrent, 54, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerCurrent;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek1, 55, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek1;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek2, 56, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek2;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek3, 57, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek3;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek4, 58, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek4;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek5, 59, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek5;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek6, 60, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek6;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.LastBookFile, 61, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.LastBookFile;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CanViewInventoryDetails, 62, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.CanViewInventoryDetails;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.ChainCode, 63, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.ChainCode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.UseProdCustGuide, 64, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.UseProdCustGuide;
			c.HasDefault = true;
			c.Default = @"((0))";
			_columns.Add(c);
				
		}
		#endregion	
	
		static public UsersMetadata Meta()
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
			 public const string Custid = "custid";
			 public const string Type = "type";
			 public const string Internetid = "internetid";
			 public const string Access = "access";
			 public const string Notes = "notes";
			 public const string Altcode = "altcode";
			 public const string Jobberid = "jobberid";
			 public const string Bizname = "bizname";
			 public const string Contactname = "contactname";
			 public const string Address1 = "address1";
			 public const string Address2 = "address2";
			 public const string City = "city";
			 public const string State = "state";
			 public const string Zip = "zip";
			 public const string Zip4 = "zip4";
			 public const string Telephone = "telephone";
			 public const string Fax = "fax";
			 public const string Cell = "cell";
			 public const string Faxmachine = "faxmachine";
			 public const string Email = "email";
			 public const string Sendfax = "sendfax";
			 public const string Sendemail = "sendemail";
			 public const string Sendmail = "sendmail";
			 public const string Flags = "flags";
			 public const string Custcatb = "custcatb";
			 public const string CustcatbRoll = "custcatb_roll";
			 public const string Source = "source";
			 public const string PMargin = "pMargin";
			 public const string PPageCol = "pPageCol";
			 public const string PFontSize = "pFontSize";
			 public const string PFont = "pFont";
			 public const string Accpay = "accpay";
			 public const string Salesheetlabel = "salesheetlabel";
			 public const string Password = "password";
			 public const string WtaRouteRid = "wta_route_rid";
			 public const string SalesTaxType = "sales_tax_type";
			 public const string Qbid = "qbid";
			 public const string FoodirectQbid = "foodirect_qbid";
			 public const string SalesTaxRegion = "sales_tax_region";
			 public const string InvoiceAger = "invoice_ager";
			 public const string WtaAccess = "wta_access";
			 public const string WtaLock = "wta_lock";
			 public const string BeefMarkup = "BeefMarkup";
			 public const string GroupCode = "GroupCode";
			 public const string Taxable = "taxable";
			 public const string SlmInit = "SlmInit";
			 public const string SlmName = "SlmName";
			 public const string CanOrder = "CanOrder";
			 public const string TierCode = "TierCode";
			 public const string TierPCT = "TierPCT";
			 public const string XEmail1 = "XEmail1";
			 public const string XEmail2 = "XEmail2";
			 public const string XEmail3 = "XEmail3";
			 public const string XEmail4 = "XEmail4";
			 public const string AgerCurrent = "ager_current";
			 public const string AgerWeek1 = "ager_week1";
			 public const string AgerWeek2 = "ager_week2";
			 public const string AgerWeek3 = "ager_week3";
			 public const string AgerWeek4 = "ager_week4";
			 public const string AgerWeek5 = "ager_week5";
			 public const string AgerWeek6 = "ager_week6";
			 public const string LastBookFile = "lastBookFile";
			 public const string CanViewInventoryDetails = "CanViewInventoryDetails";
			 public const string ChainCode = "ChainCode";
			 public const string UseProdCustGuide = "UseProdCustGuide";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Custid = "Custid";
			 public const string Type = "Type";
			 public const string Internetid = "Internetid";
			 public const string Access = "Access";
			 public const string Notes = "Notes";
			 public const string Altcode = "Altcode";
			 public const string Jobberid = "Jobberid";
			 public const string Bizname = "Bizname";
			 public const string Contactname = "Contactname";
			 public const string Address1 = "Address1";
			 public const string Address2 = "Address2";
			 public const string City = "City";
			 public const string State = "State";
			 public const string Zip = "Zip";
			 public const string Zip4 = "Zip4";
			 public const string Telephone = "Telephone";
			 public const string Fax = "Fax";
			 public const string Cell = "Cell";
			 public const string Faxmachine = "Faxmachine";
			 public const string Email = "Email";
			 public const string Sendfax = "Sendfax";
			 public const string Sendemail = "Sendemail";
			 public const string Sendmail = "Sendmail";
			 public const string Flags = "Flags";
			 public const string Custcatb = "Custcatb";
			 public const string CustcatbRoll = "CustcatbRoll";
			 public const string Source = "Source";
			 public const string PMargin = "PMargin";
			 public const string PPageCol = "PPageCol";
			 public const string PFontSize = "PFontSize";
			 public const string PFont = "PFont";
			 public const string Accpay = "Accpay";
			 public const string Salesheetlabel = "Salesheetlabel";
			 public const string Password = "Password";
			 public const string WtaRouteRid = "WtaRouteRid";
			 public const string SalesTaxType = "SalesTaxType";
			 public const string Qbid = "Qbid";
			 public const string FoodirectQbid = "FoodirectQbid";
			 public const string SalesTaxRegion = "SalesTaxRegion";
			 public const string InvoiceAger = "InvoiceAger";
			 public const string WtaAccess = "WtaAccess";
			 public const string WtaLock = "WtaLock";
			 public const string BeefMarkup = "BeefMarkup";
			 public const string GroupCode = "GroupCode";
			 public const string Taxable = "Taxable";
			 public const string SlmInit = "SlmInit";
			 public const string SlmName = "SlmName";
			 public const string CanOrder = "CanOrder";
			 public const string TierCode = "TierCode";
			 public const string TierPCT = "TierPCT";
			 public const string XEmail1 = "XEmail1";
			 public const string XEmail2 = "XEmail2";
			 public const string XEmail3 = "XEmail3";
			 public const string XEmail4 = "XEmail4";
			 public const string AgerCurrent = "AgerCurrent";
			 public const string AgerWeek1 = "AgerWeek1";
			 public const string AgerWeek2 = "AgerWeek2";
			 public const string AgerWeek3 = "AgerWeek3";
			 public const string AgerWeek4 = "AgerWeek4";
			 public const string AgerWeek5 = "AgerWeek5";
			 public const string AgerWeek6 = "AgerWeek6";
			 public const string LastBookFile = "LastBookFile";
			 public const string CanViewInventoryDetails = "CanViewInventoryDetails";
			 public const string ChainCode = "ChainCode";
			 public const string UseProdCustGuide = "UseProdCustGuide";
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
			lock (typeof(UsersMetadata))
			{
				if(UsersMetadata.mapDelegates == null)
				{
					UsersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (UsersMetadata.meta == null)
				{
					UsersMetadata.meta = new UsersMetadata();
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
				

				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Internetid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Access", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Notes", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Altcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Jobberid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Bizname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Contactname", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Address1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Address2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("State", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Zip", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Zip4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Telephone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Cell", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Faxmachine", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sendfax", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Sendemail", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Sendmail", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Flags", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Custcatb", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CustcatbRoll", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Source", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PMargin", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PPageCol", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PFontSize", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PFont", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Accpay", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Salesheetlabel", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Password", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("WtaRouteRid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SalesTaxType", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Qbid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FoodirectQbid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SalesTaxRegion", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("InvoiceAger", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("WtaAccess", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("WtaLock", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("BeefMarkup", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("GroupCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Taxable", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SlmInit", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SlmName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CanOrder", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("TierCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TierPCT", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("XEmail1", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("XEmail2", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("XEmail3", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("XEmail4", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("AgerCurrent", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AgerWeek6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("LastBookFile", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CanViewInventoryDetails", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ChainCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UseProdCustGuide", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "users";
				meta.Destination = "users";
				
				meta.spInsert = "proc_usersInsert";				
				meta.spUpdate = "proc_usersUpdate";		
				meta.spDelete = "proc_usersDelete";
				meta.spLoadAll = "proc_usersLoadAll";
				meta.spLoadByPrimaryKey = "proc_usersLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UsersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
