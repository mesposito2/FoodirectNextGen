
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
	/// Encapsulates the 'users' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(UsersBO))]	
	[XmlType("UsersBO")]
	public partial class UsersBO : esUsersBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new UsersBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String custid)
		{
			var obj = new UsersBO();
			obj.Custid = custid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String custid, esSqlAccessType sqlAccessType)
		{
			var obj = new UsersBO();
			obj.Custid = custid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("UsersCollection")]
	public partial class UsersCollection : esUsersCollection, IEnumerable<UsersBO>
	{
		public UsersBO FindByPrimaryKey(System.String custid)
		{
			return this.SingleOrDefault(e => e.Custid == custid);
		}

		
				
	}



	[Serializable]	
	public partial class UsersQuery : esUsersQuery
	{
		public UsersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public UsersQuery(string joinAlias, out UsersQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "UsersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(UsersQuery query)
		{
			return UsersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator UsersQuery(string query)
		{
			return (UsersQuery)UsersQuery.SerializeHelper.FromXml(query, typeof(UsersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esUsersBO : esEntity
	{
		public esUsersBO()
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
			UsersQuery query = new UsersQuery();
			query.Where(query.Custid == custid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String custid)
		{
			esParameters parms = new esParameters();
			parms.Add("Custid", custid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to users.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._UserTypeBO = null;
					this.OnPropertyChanged("UserTypeBO");
					OnPropertyChanged(UsersMetadata.PropertyNames.Type);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.internetid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Internetid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.access
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Access);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.notes
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Notes);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.altcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Altcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.bizname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Bizname);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.contactname
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Contactname);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.address1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Address1);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.address2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Address2);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.city
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.City);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.state
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.State);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.zip
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Zip);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.zip4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Zip4);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.telephone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Telephone);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Fax);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.cell
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Cell);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.faxmachine
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Faxmachine);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Email);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendfax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Sendfax);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendemail
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Sendemail);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sendmail
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Sendmail);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.flags
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Flags);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.custcatb
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Custcatb);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.custcatb_roll
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.CustcatbRoll);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.source
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Source);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pMargin
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.PMargin);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pPageCol
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.PPageCol);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pFontSize
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.PFontSize);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.pFont
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.PFont);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.accpay
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Accpay);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.salesheetlabel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Salesheetlabel);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Password);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_route_rid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.WtaRouteRid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sales_tax_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.SalesTaxType);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.qbid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.Qbid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.foodirect_qbid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.FoodirectQbid);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.sales_tax_region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._WtaSalesTaxBO = null;
					this.OnPropertyChanged("WtaSalesTaxBO");
					OnPropertyChanged(UsersMetadata.PropertyNames.SalesTaxRegion);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.invoice_ager
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.InvoiceAger);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_access
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.WtaAccess);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.wta_lock
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.WtaLock);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.BeefMarkup
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.BeefMarkup);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.GroupCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? GroupCode
		{
			get
			{
				return base.GetSystemChar(UsersMetadata.ColumnNames.GroupCode);
			}
			
			set
			{
				if(base.SetSystemChar(UsersMetadata.ColumnNames.GroupCode, value))
				{
					OnPropertyChanged(UsersMetadata.PropertyNames.GroupCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Taxable
		{
			get
			{
				return base.GetSystemChar(UsersMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemChar(UsersMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(UsersMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.SlmInit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.SlmInit);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.SlmName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.SlmName);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.CanOrder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.CanOrder);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.TierCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? TierCode
		{
			get
			{
				return base.GetSystemChar(UsersMetadata.ColumnNames.TierCode);
			}
			
			set
			{
				if(base.SetSystemChar(UsersMetadata.ColumnNames.TierCode, value))
				{
					OnPropertyChanged(UsersMetadata.PropertyNames.TierCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.TierPCT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.TierPCT);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.XEmail1);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.XEmail2);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.XEmail3);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.XEmail4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.XEmail4);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_current
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerCurrent);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek1);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek2);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek3);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek4);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek5);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ager_week6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.AgerWeek6);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.lastBookFile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.LastBookFile);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.CanViewInventoryDetails
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.CanViewInventoryDetails);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.ChainCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._ChainBO = null;
					this.OnPropertyChanged("ChainBO");
					OnPropertyChanged(UsersMetadata.PropertyNames.ChainCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to users.UseProdCustGuide
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(UsersMetadata.PropertyNames.UseProdCustGuide);
				}
			}
		}
		
		internal protected ChainBO _ChainBO;
		internal protected UserTypeBO _UserTypeBO;
		internal protected WtaSalesTaxBO _WtaSalesTaxBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return UsersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public UsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(UsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UsersQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private UsersQuery query;		
	}



	[Serializable]
	abstract public partial class esUsersCollection : esEntityCollection<UsersBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UsersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "UsersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public UsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(UsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(UsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((UsersQuery)query);
		}

		#endregion
		
		private UsersQuery query;
	}



	[Serializable]
	abstract public partial class esUsersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UsersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Custid": return this.Custid;
				case "Type": return this.Type;
				case "Internetid": return this.Internetid;
				case "Access": return this.Access;
				case "Notes": return this.Notes;
				case "Altcode": return this.Altcode;
				case "Jobberid": return this.Jobberid;
				case "Bizname": return this.Bizname;
				case "Contactname": return this.Contactname;
				case "Address1": return this.Address1;
				case "Address2": return this.Address2;
				case "City": return this.City;
				case "State": return this.State;
				case "Zip": return this.Zip;
				case "Zip4": return this.Zip4;
				case "Telephone": return this.Telephone;
				case "Fax": return this.Fax;
				case "Cell": return this.Cell;
				case "Faxmachine": return this.Faxmachine;
				case "Email": return this.Email;
				case "Sendfax": return this.Sendfax;
				case "Sendemail": return this.Sendemail;
				case "Sendmail": return this.Sendmail;
				case "Flags": return this.Flags;
				case "Custcatb": return this.Custcatb;
				case "CustcatbRoll": return this.CustcatbRoll;
				case "Source": return this.Source;
				case "PMargin": return this.PMargin;
				case "PPageCol": return this.PPageCol;
				case "PFontSize": return this.PFontSize;
				case "PFont": return this.PFont;
				case "Accpay": return this.Accpay;
				case "Salesheetlabel": return this.Salesheetlabel;
				case "Password": return this.Password;
				case "WtaRouteRid": return this.WtaRouteRid;
				case "SalesTaxType": return this.SalesTaxType;
				case "Qbid": return this.Qbid;
				case "FoodirectQbid": return this.FoodirectQbid;
				case "SalesTaxRegion": return this.SalesTaxRegion;
				case "InvoiceAger": return this.InvoiceAger;
				case "WtaAccess": return this.WtaAccess;
				case "WtaLock": return this.WtaLock;
				case "BeefMarkup": return this.BeefMarkup;
				case "GroupCode": return this.GroupCode;
				case "Taxable": return this.Taxable;
				case "SlmInit": return this.SlmInit;
				case "SlmName": return this.SlmName;
				case "CanOrder": return this.CanOrder;
				case "TierCode": return this.TierCode;
				case "TierPCT": return this.TierPCT;
				case "XEmail1": return this.XEmail1;
				case "XEmail2": return this.XEmail2;
				case "XEmail3": return this.XEmail3;
				case "XEmail4": return this.XEmail4;
				case "AgerCurrent": return this.AgerCurrent;
				case "AgerWeek1": return this.AgerWeek1;
				case "AgerWeek2": return this.AgerWeek2;
				case "AgerWeek3": return this.AgerWeek3;
				case "AgerWeek4": return this.AgerWeek4;
				case "AgerWeek5": return this.AgerWeek5;
				case "AgerWeek6": return this.AgerWeek6;
				case "LastBookFile": return this.LastBookFile;
				case "CanViewInventoryDetails": return this.CanViewInventoryDetails;
				case "ChainCode": return this.ChainCode;
				case "UseProdCustGuide": return this.UseProdCustGuide;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Custid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem Type
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Type, esSystemType.Int16); }
		} 
		
		public esQueryItem Internetid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Internetid, esSystemType.String); }
		} 
		
		public esQueryItem Access
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Access, esSystemType.Int32); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem Altcode
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Altcode, esSystemType.String); }
		} 
		
		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Bizname
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Bizname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Address1
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Address1, esSystemType.String); }
		} 
		
		public esQueryItem Address2
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Address2, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem State
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.State, esSystemType.String); }
		} 
		
		public esQueryItem Zip
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Zip, esSystemType.String); }
		} 
		
		public esQueryItem Zip4
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Zip4, esSystemType.String); }
		} 
		
		public esQueryItem Telephone
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Telephone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		public esQueryItem Cell
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Cell, esSystemType.String); }
		} 
		
		public esQueryItem Faxmachine
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Faxmachine, esSystemType.Int16); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Sendfax
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Sendfax, esSystemType.Boolean); }
		} 
		
		public esQueryItem Sendemail
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Sendemail, esSystemType.Boolean); }
		} 
		
		public esQueryItem Sendmail
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Sendmail, esSystemType.Boolean); }
		} 
		
		public esQueryItem Flags
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Flags, esSystemType.Int32); }
		} 
		
		public esQueryItem Custcatb
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Custcatb, esSystemType.String); }
		} 
		
		public esQueryItem CustcatbRoll
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.CustcatbRoll, esSystemType.String); }
		} 
		
		public esQueryItem Source
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Source, esSystemType.Int32); }
		} 
		
		public esQueryItem PMargin
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.PMargin, esSystemType.Int32); }
		} 
		
		public esQueryItem PPageCol
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.PPageCol, esSystemType.Int32); }
		} 
		
		public esQueryItem PFontSize
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.PFontSize, esSystemType.Int32); }
		} 
		
		public esQueryItem PFont
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.PFont, esSystemType.String); }
		} 
		
		public esQueryItem Accpay
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Accpay, esSystemType.Int32); }
		} 
		
		public esQueryItem Salesheetlabel
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Salesheetlabel, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem WtaRouteRid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.WtaRouteRid, esSystemType.Int32); }
		} 
		
		public esQueryItem SalesTaxType
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.SalesTaxType, esSystemType.Int32); }
		} 
		
		public esQueryItem Qbid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Qbid, esSystemType.String); }
		} 
		
		public esQueryItem FoodirectQbid
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.FoodirectQbid, esSystemType.String); }
		} 
		
		public esQueryItem SalesTaxRegion
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.SalesTaxRegion, esSystemType.String); }
		} 
		
		public esQueryItem InvoiceAger
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.InvoiceAger, esSystemType.Boolean); }
		} 
		
		public esQueryItem WtaAccess
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.WtaAccess, esSystemType.Int32); }
		} 
		
		public esQueryItem WtaLock
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.WtaLock, esSystemType.Int32); }
		} 
		
		public esQueryItem BeefMarkup
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.BeefMarkup, esSystemType.Double); }
		} 
		
		public esQueryItem GroupCode
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.GroupCode, esSystemType.Char); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.Taxable, esSystemType.Char); }
		} 
		
		public esQueryItem SlmInit
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.SlmInit, esSystemType.String); }
		} 
		
		public esQueryItem SlmName
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.SlmName, esSystemType.String); }
		} 
		
		public esQueryItem CanOrder
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.CanOrder, esSystemType.Boolean); }
		} 
		
		public esQueryItem TierCode
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.TierCode, esSystemType.Char); }
		} 
		
		public esQueryItem TierPCT
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.TierPCT, esSystemType.Int32); }
		} 
		
		public esQueryItem XEmail1
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail1, esSystemType.String); }
		} 
		
		public esQueryItem XEmail2
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail2, esSystemType.String); }
		} 
		
		public esQueryItem XEmail3
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail3, esSystemType.String); }
		} 
		
		public esQueryItem XEmail4
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.XEmail4, esSystemType.String); }
		} 
		
		public esQueryItem AgerCurrent
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerCurrent, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek1
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek1, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek2
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek2, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek3
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek3, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek4
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek4, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek5
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek5, esSystemType.Double); }
		} 
		
		public esQueryItem AgerWeek6
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.AgerWeek6, esSystemType.Double); }
		} 
		
		public esQueryItem LastBookFile
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.LastBookFile, esSystemType.String); }
		} 
		
		public esQueryItem CanViewInventoryDetails
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.CanViewInventoryDetails, esSystemType.Boolean); }
		} 
		
		public esQueryItem ChainCode
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.ChainCode, esSystemType.String); }
		} 
		
		public esQueryItem UseProdCustGuide
		{
			get { return new esQueryItem(this, UsersMetadata.ColumnNames.UseProdCustGuide, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class UsersBO : esUsersBO
	{

		#region FavoriteBOCollection - Zero To Many (FK_favorite_custid)
		
		static public esPrefetchMap Prefetch_FavoriteBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.UsersBO.FavoriteBOCollection_Delegate,
					PropertyName = "FavoriteBOCollection",
					MyColumnName = "custID",
					ParentColumnName = "custid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void FavoriteBOCollection_Delegate(esPrefetchParameters data)
		{
			UsersQuery parent = new UsersQuery(data.NextAlias());

			FavoriteQuery me = data.You != null ? data.You as FavoriteQuery : new FavoriteQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Custid == me.CustID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_favorite_custid
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeFavoriteBOCollection()
		{
		    if(this._FavoriteBOCollection != null && this._FavoriteBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="FavoriteBOCollection", EmitDefaultValue = false)]
		public FavoriteCollection FavoriteBOCollection
		{
			get
			{
				if(this._FavoriteBOCollection == null)
				{
					this._FavoriteBOCollection = new FavoriteCollection();
					this._FavoriteBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("FavoriteBOCollection", this._FavoriteBOCollection);
				
					if (this.Custid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._FavoriteBOCollection.Query.Where(this._FavoriteBOCollection.Query.CustID == this.Custid);
							this._FavoriteBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._FavoriteBOCollection.fks.Add(FavoriteMetadata.ColumnNames.CustID, this.Custid);
					}
				}

				return this._FavoriteBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._FavoriteBOCollection != null) 
				{ 
					this.RemovePostSave("FavoriteBOCollection"); 
					this._FavoriteBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private FavoriteCollection _FavoriteBOCollection;
		#endregion

		#region SpeedBOCollection - Zero To Many (FK_speed_custid)
		
		static public esPrefetchMap Prefetch_SpeedBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.UsersBO.SpeedBOCollection_Delegate,
					PropertyName = "SpeedBOCollection",
					MyColumnName = "custid",
					ParentColumnName = "custid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void SpeedBOCollection_Delegate(esPrefetchParameters data)
		{
			UsersQuery parent = new UsersQuery(data.NextAlias());

			SpeedQuery me = data.You != null ? data.You as SpeedQuery : new SpeedQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Custid == me.Custid);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_speed_custid
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeSpeedBOCollection()
		{
		    if(this._SpeedBOCollection != null && this._SpeedBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="SpeedBOCollection", EmitDefaultValue = false)]
		public SpeedCollection SpeedBOCollection
		{
			get
			{
				if(this._SpeedBOCollection == null)
				{
					this._SpeedBOCollection = new SpeedCollection();
					this._SpeedBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("SpeedBOCollection", this._SpeedBOCollection);
				
					if (this.Custid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._SpeedBOCollection.Query.Where(this._SpeedBOCollection.Query.Custid == this.Custid);
							this._SpeedBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._SpeedBOCollection.fks.Add(SpeedMetadata.ColumnNames.Custid, this.Custid);
					}
				}

				return this._SpeedBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._SpeedBOCollection != null) 
				{ 
					this.RemovePostSave("SpeedBOCollection"); 
					this._SpeedBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private SpeedCollection _SpeedBOCollection;
		#endregion

		#region UsersBookBOCollection - Zero To Many (FK_UsersBook_CustID)
		
		static public esPrefetchMap Prefetch_UsersBookBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.UsersBO.UsersBookBOCollection_Delegate,
					PropertyName = "UsersBookBOCollection",
					MyColumnName = "custID",
					ParentColumnName = "custid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void UsersBookBOCollection_Delegate(esPrefetchParameters data)
		{
			UsersQuery parent = new UsersQuery(data.NextAlias());

			UsersBookQuery me = data.You != null ? data.You as UsersBookQuery : new UsersBookQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Custid == me.CustID);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_UsersBook_CustID
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUsersBookBOCollection()
		{
		    if(this._UsersBookBOCollection != null && this._UsersBookBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="UsersBookBOCollection", EmitDefaultValue = false)]
		public UsersBookCollection UsersBookBOCollection
		{
			get
			{
				if(this._UsersBookBOCollection == null)
				{
					this._UsersBookBOCollection = new UsersBookCollection();
					this._UsersBookBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("UsersBookBOCollection", this._UsersBookBOCollection);
				
					if (this.Custid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._UsersBookBOCollection.Query.Where(this._UsersBookBOCollection.Query.CustID == this.Custid);
							this._UsersBookBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._UsersBookBOCollection.fks.Add(UsersBookMetadata.ColumnNames.CustID, this.Custid);
					}
				}

				return this._UsersBookBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._UsersBookBOCollection != null) 
				{ 
					this.RemovePostSave("UsersBookBOCollection"); 
					this._UsersBookBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private UsersBookCollection _UsersBookBOCollection;
		#endregion

		#region WtaPoBOCollection - Zero To Many (FK_wta_po_mid)
		
		static public esPrefetchMap Prefetch_WtaPoBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.UsersBO.WtaPoBOCollection_Delegate,
					PropertyName = "WtaPoBOCollection",
					MyColumnName = "mid",
					ParentColumnName = "custid",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void WtaPoBOCollection_Delegate(esPrefetchParameters data)
		{
			UsersQuery parent = new UsersQuery(data.NextAlias());

			WtaPoQuery me = data.You != null ? data.You as WtaPoQuery : new WtaPoQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Custid == me.Mid);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_wta_po_mid
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeWtaPoBOCollection()
		{
		    if(this._WtaPoBOCollection != null && this._WtaPoBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="WtaPoBOCollection", EmitDefaultValue = false)]
		public WtaPoCollection WtaPoBOCollection
		{
			get
			{
				if(this._WtaPoBOCollection == null)
				{
					this._WtaPoBOCollection = new WtaPoCollection();
					this._WtaPoBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("WtaPoBOCollection", this._WtaPoBOCollection);
				
					if (this.Custid != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._WtaPoBOCollection.Query.Where(this._WtaPoBOCollection.Query.Mid == this.Custid);
							this._WtaPoBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._WtaPoBOCollection.fks.Add(WtaPoMetadata.ColumnNames.Mid, this.Custid);
					}
				}

				return this._WtaPoBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._WtaPoBOCollection != null) 
				{ 
					this.RemovePostSave("WtaPoBOCollection"); 
					this._WtaPoBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private WtaPoCollection _WtaPoBOCollection;
		#endregion

		
		#region ChainBO - Many To One (UN_Users_ChainCode)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeChainBO()
		{
		    return this._ChainBO != null ? true : false;
		}
		

		[DataMember(Name="ChainBO", EmitDefaultValue = false)]
					
		public ChainBO ChainBO
		{
			get
			{
                if (this._ChainBO == null)
                {
                    this._ChainBO = new ChainBO();
                    this._ChainBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("ChainBO", this._ChainBO);

					if(this._ChainBO == null && ChainCode != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._ChainBO.Query.Where(this._ChainBO.Query.ChainCode == this.ChainCode);
							this._ChainBO.Query.Load();
                        }
                    }
                }

				return this._ChainBO;
			}
			
			set
			{
				this.RemovePreSave("ChainBO");
				

				if(value == null)
				{
					this.ChainCode = null;
					this._ChainBO = null;
				}
				else
				{
					this.ChainCode = value.ChainCode;
					this._ChainBO = value;
					this.SetPreSave("ChainBO", this._ChainBO);
				}
				
			}
		}
		#endregion
		

		
		#region UserTypeBO - Many To One (FK_users_UserType)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeUserTypeBO()
		{
		    return this._UserTypeBO != null ? true : false;
		}
		

		[DataMember(Name="UserTypeBO", EmitDefaultValue = false)]
					
		public UserTypeBO UserTypeBO
		{
			get
			{
                if (this._UserTypeBO == null)
                {
                    this._UserTypeBO = new UserTypeBO();
                    this._UserTypeBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("UserTypeBO", this._UserTypeBO);

					if(this._UserTypeBO == null && Type != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._UserTypeBO.Query.Where(this._UserTypeBO.Query.UserTypeID == this.Type);
							this._UserTypeBO.Query.Load();
                        }
                    }
                }

				return this._UserTypeBO;
			}
			
			set
			{
				this.RemovePreSave("UserTypeBO");
				

				if(value == null)
				{
					this.Type = null;
					this._UserTypeBO = null;
				}
				else
				{
					this.Type = value.UserTypeID;
					this._UserTypeBO = value;
					this.SetPreSave("UserTypeBO", this._UserTypeBO);
				}
				
			}
		}
		#endregion
		

		
		#region WtaSalesTaxBO - Many To One (FK_users_sales_tax_region)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeWtaSalesTaxBO()
		{
		    return this._WtaSalesTaxBO != null ? true : false;
		}
		

		[DataMember(Name="WtaSalesTaxBO", EmitDefaultValue = false)]
					
		public WtaSalesTaxBO WtaSalesTaxBO
		{
			get
			{
                if (this._WtaSalesTaxBO == null)
                {
                    this._WtaSalesTaxBO = new WtaSalesTaxBO();
                    this._WtaSalesTaxBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("WtaSalesTaxBO", this._WtaSalesTaxBO);

					if(this._WtaSalesTaxBO == null && SalesTaxRegion != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._WtaSalesTaxBO.Query.Where(this._WtaSalesTaxBO.Query.Code == this.SalesTaxRegion);
							this._WtaSalesTaxBO.Query.Load();
                        }
                    }
                }

				return this._WtaSalesTaxBO;
			}
			
			set
			{
				this.RemovePreSave("WtaSalesTaxBO");
				

				if(value == null)
				{
					this.SalesTaxRegion = null;
					this._WtaSalesTaxBO = null;
				}
				else
				{
					this.SalesTaxRegion = value.Code;
					this._WtaSalesTaxBO = value;
					this.SetPreSave("WtaSalesTaxBO", this._WtaSalesTaxBO);
				}
				
			}
		}
		#endregion
		

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "FavoriteBOCollection":
					coll = this.FavoriteBOCollection;
					break;
				case "SpeedBOCollection":
					coll = this.SpeedBOCollection;
					break;
				case "UsersBookBOCollection":
					coll = this.UsersBookBOCollection;
					break;
				case "WtaPoBOCollection":
					coll = this.WtaPoBOCollection;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "FavoriteBOCollection", typeof(FavoriteCollection), new FavoriteBO()));
			props.Add(new esPropertyDescriptor(this, "SpeedBOCollection", typeof(SpeedCollection), new SpeedBO()));
			props.Add(new esPropertyDescriptor(this, "UsersBookBOCollection", typeof(UsersBookCollection), new UsersBookBO()));
			props.Add(new esPropertyDescriptor(this, "WtaPoBOCollection", typeof(WtaPoCollection), new WtaPoBO()));
		
			return props;
		}
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._ChainBO != null)
			{
				this.ChainCode = this._ChainBO.ChainCode;
			}
			if(!this.es.IsDeleted && this._WtaSalesTaxBO != null)
			{
				this.SalesTaxRegion = this._WtaSalesTaxBO.Code;
			}
		}
		
	}
	



	[Serializable]
	public partial class UsersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UsersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UsersMetadata.ColumnNames.Custid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Custid;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Type, 1, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = UsersMetadata.PropertyNames.Type;
			c.NumericPrecision = 5;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Internetid, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Internetid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Access, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Access;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Notes, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Notes;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Altcode, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Altcode;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Jobberid, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Bizname, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Bizname;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Contactname, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Contactname;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Address1, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Address1;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Address2, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Address2;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.City, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.State, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.State;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Zip, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Zip;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Zip4, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Zip4;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Telephone, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Telephone;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Fax, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Cell, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Cell;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Faxmachine, 18, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = UsersMetadata.PropertyNames.Faxmachine;
			c.NumericPrecision = 5;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Email, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendfax, 20, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendfax;
			c.HasDefault = true;
			c.Default = @"(0)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendemail, 21, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendemail;
			c.HasDefault = true;
			c.Default = @"(0)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Sendmail, 22, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.Sendmail;
			c.HasDefault = true;
			c.Default = @"(0)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Flags, 23, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Flags;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Custcatb, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Custcatb;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CustcatbRoll, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.CustcatbRoll;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Source, 26, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Source;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PMargin, 27, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PMargin;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(2)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PPageCol, 28, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PPageCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(110)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PFontSize, 29, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.PFontSize;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(9)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.PFont, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.PFont;
			c.CharacterMaxLength = 40;
			c.HasDefault = true;
			c.Default = @"('Courier New')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Accpay, 31, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.Accpay;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Salesheetlabel, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Salesheetlabel;
			c.CharacterMaxLength = 250;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Password, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 30;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaRouteRid, 34, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaRouteRid;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SalesTaxType, 35, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.SalesTaxType;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Qbid, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.Qbid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.FoodirectQbid, 37, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.FoodirectQbid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SalesTaxRegion, 38, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SalesTaxRegion;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.InvoiceAger, 39, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.InvoiceAger;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaAccess, 40, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaAccess;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.WtaLock, 41, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.WtaLock;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.BeefMarkup, 42, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.BeefMarkup;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.GroupCode, 43, typeof(System.Char), esSystemType.Char);
			c.PropertyName = UsersMetadata.PropertyNames.GroupCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.Taxable, 44, typeof(System.Char), esSystemType.Char);
			c.PropertyName = UsersMetadata.PropertyNames.Taxable;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('N')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SlmInit, 45, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SlmInit;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.SlmName, 46, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.SlmName;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CanOrder, 47, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.CanOrder;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.TierCode, 48, typeof(System.Char), esSystemType.Char);
			c.PropertyName = UsersMetadata.PropertyNames.TierCode;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.TierPCT, 49, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UsersMetadata.PropertyNames.TierPCT;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail1, 50, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail1;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail2, 51, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail3, 52, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail3;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.XEmail4, 53, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.XEmail4;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerCurrent, 54, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerCurrent;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek1, 55, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek1;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek2, 56, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek2;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek3, 57, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek3;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek4, 58, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek4;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek5, 59, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek5;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.AgerWeek6, 60, typeof(System.Double), esSystemType.Double);
			c.PropertyName = UsersMetadata.PropertyNames.AgerWeek6;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.LastBookFile, 61, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.LastBookFile;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.CanViewInventoryDetails, 62, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.CanViewInventoryDetails;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.ChainCode, 63, typeof(System.String), esSystemType.String);
			c.PropertyName = UsersMetadata.PropertyNames.ChainCode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(UsersMetadata.ColumnNames.UseProdCustGuide, 64, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UsersMetadata.PropertyNames.UseProdCustGuide;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public UsersMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				meta.AddTypeMap("GroupCode", new esTypeMap("varchar", "System.Char"));
				meta.AddTypeMap("Taxable", new esTypeMap("varchar", "System.Char"));
				meta.AddTypeMap("SlmInit", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SlmName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CanOrder", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("TierCode", new esTypeMap("varchar", "System.Char"));
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UsersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
