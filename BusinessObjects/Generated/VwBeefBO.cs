/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 1/5/2016 8:59:14 PM
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
	abstract public class esVwBeefCollection : esEntityCollection
	{
		public esVwBeefCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "VwBeefCollection";
		}

		#region Query Logic
		protected void InitQuery(esVwBeefQuery query)
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
			this.InitQuery(query as esVwBeefQuery);
		}
		#endregion
		
		virtual public VwBeefBO DetachEntity(VwBeefBO entity)
		{
			return base.DetachEntity(entity) as VwBeefBO;
		}
		
		virtual public VwBeefBO AttachEntity(VwBeefBO entity)
		{
			return base.AttachEntity(entity) as VwBeefBO;
		}
		
		virtual public void Combine(VwBeefCollection collection)
		{
			base.Combine(collection);
		}
		
		new public VwBeefBO this[int index]
		{
			get
			{
				return base[index] as VwBeefBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(VwBeefBO);
		}
	}



	[Serializable]
	abstract public class esVwBeefBO : esEntity
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esVwBeefQuery GetDynamicQuery()
		{
			return null;
		}

		public esVwBeefBO()
		{

		}

		public esVwBeefBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		
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
						case "OnCurrentOrder1": this.str.OnCurrentOrder1 = (string)value; break;							
						case "OnCurrentOrder2": this.str.OnCurrentOrder2 = (string)value; break;							
						case "OnCurrentOrder3": this.str.OnCurrentOrder3 = (string)value; break;							
						case "OnCurrentOrder4": this.str.OnCurrentOrder4 = (string)value; break;							
						case "OnCurrentOrder5": this.str.OnCurrentOrder5 = (string)value; break;							
						case "OnCurrentOrder6": this.str.OnCurrentOrder6 = (string)value; break;							
						case "OnCurrentOrder7": this.str.OnCurrentOrder7 = (string)value; break;							
						case "OnCurrentOrder8": this.str.OnCurrentOrder8 = (string)value; break;							
						case "OnCurrentOrder9": this.str.OnCurrentOrder9 = (string)value; break;							
						case "OnCurrentOrder10": this.str.OnCurrentOrder10 = (string)value; break;							
						case "OnCurrentOrder11": this.str.OnCurrentOrder11 = (string)value; break;							
						case "Description1": this.str.Description1 = (string)value; break;							
						case "Description2": this.str.Description2 = (string)value; break;							
						case "Description3": this.str.Description3 = (string)value; break;							
						case "Description4": this.str.Description4 = (string)value; break;							
						case "Description5": this.str.Description5 = (string)value; break;							
						case "Description6": this.str.Description6 = (string)value; break;							
						case "Description7": this.str.Description7 = (string)value; break;							
						case "Description8": this.str.Description8 = (string)value; break;							
						case "Description9": this.str.Description9 = (string)value; break;							
						case "Description10": this.str.Description10 = (string)value; break;							
						case "Description11": this.str.Description11 = (string)value; break;							
						case "Catid1": this.str.Catid1 = (string)value; break;							
						case "Catid2": this.str.Catid2 = (string)value; break;							
						case "Catid3": this.str.Catid3 = (string)value; break;							
						case "Catid4": this.str.Catid4 = (string)value; break;							
						case "Catid5": this.str.Catid5 = (string)value; break;							
						case "Catid6": this.str.Catid6 = (string)value; break;							
						case "Catid7": this.str.Catid7 = (string)value; break;							
						case "Catid8": this.str.Catid8 = (string)value; break;							
						case "Catid9": this.str.Catid9 = (string)value; break;							
						case "Catid10": this.str.Catid10 = (string)value; break;							
						case "Catid11": this.str.Catid11 = (string)value; break;							
						case "Scatid1": this.str.Scatid1 = (string)value; break;							
						case "Scatid2": this.str.Scatid2 = (string)value; break;							
						case "Scatid3": this.str.Scatid3 = (string)value; break;							
						case "Scatid4": this.str.Scatid4 = (string)value; break;							
						case "Scatid5": this.str.Scatid5 = (string)value; break;							
						case "Scatid6": this.str.Scatid6 = (string)value; break;							
						case "Scatid7": this.str.Scatid7 = (string)value; break;							
						case "Scatid8": this.str.Scatid8 = (string)value; break;							
						case "Scatid9": this.str.Scatid9 = (string)value; break;							
						case "Scatid10": this.str.Scatid10 = (string)value; break;							
						case "Scatid11": this.str.Scatid11 = (string)value; break;							
						case "IsMaster1": this.str.IsMaster1 = (string)value; break;							
						case "IsMaster2": this.str.IsMaster2 = (string)value; break;							
						case "IsMaster3": this.str.IsMaster3 = (string)value; break;							
						case "IsMaster4": this.str.IsMaster4 = (string)value; break;							
						case "IsMaster5": this.str.IsMaster5 = (string)value; break;							
						case "IsMaster6": this.str.IsMaster6 = (string)value; break;							
						case "IsMaster7": this.str.IsMaster7 = (string)value; break;							
						case "IsMaster8": this.str.IsMaster8 = (string)value; break;							
						case "IsMaster9": this.str.IsMaster9 = (string)value; break;							
						case "IsMaster10": this.str.IsMaster10 = (string)value; break;							
						case "IsMaster11": this.str.IsMaster11 = (string)value; break;							
						case "Casecount1": this.str.Casecount1 = (string)value; break;							
						case "Casecount2": this.str.Casecount2 = (string)value; break;							
						case "Casecount3": this.str.Casecount3 = (string)value; break;							
						case "Casecount4": this.str.Casecount4 = (string)value; break;							
						case "Casecount5": this.str.Casecount5 = (string)value; break;							
						case "Casecount6": this.str.Casecount6 = (string)value; break;							
						case "Casecount7": this.str.Casecount7 = (string)value; break;							
						case "Casecount8": this.str.Casecount8 = (string)value; break;							
						case "Casecount9": this.str.Casecount9 = (string)value; break;							
						case "Casecount10": this.str.Casecount10 = (string)value; break;							
						case "Casecount11": this.str.Casecount11 = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;							
						case "Pcode1": this.str.Pcode1 = (string)value; break;							
						case "Price1": this.str.Price1 = (string)value; break;							
						case "Pcode2": this.str.Pcode2 = (string)value; break;							
						case "Price2": this.str.Price2 = (string)value; break;							
						case "Pcode3": this.str.Pcode3 = (string)value; break;							
						case "Price3": this.str.Price3 = (string)value; break;							
						case "Pcode4": this.str.Pcode4 = (string)value; break;							
						case "Price4": this.str.Price4 = (string)value; break;							
						case "Pcode5": this.str.Pcode5 = (string)value; break;							
						case "Price5": this.str.Price5 = (string)value; break;							
						case "Jprice1": this.str.Jprice1 = (string)value; break;							
						case "Jprice2": this.str.Jprice2 = (string)value; break;							
						case "Jprice3": this.str.Jprice3 = (string)value; break;							
						case "Jprice4": this.str.Jprice4 = (string)value; break;							
						case "Jprice5": this.str.Jprice5 = (string)value; break;							
						case "Pcode6": this.str.Pcode6 = (string)value; break;							
						case "Price6": this.str.Price6 = (string)value; break;							
						case "Jprice6": this.str.Jprice6 = (string)value; break;							
						case "Price7": this.str.Price7 = (string)value; break;							
						case "Price8": this.str.Price8 = (string)value; break;							
						case "Price9": this.str.Price9 = (string)value; break;							
						case "Price10": this.str.Price10 = (string)value; break;							
						case "Jprice7": this.str.Jprice7 = (string)value; break;							
						case "Jprice8": this.str.Jprice8 = (string)value; break;							
						case "Jprice9": this.str.Jprice9 = (string)value; break;							
						case "Jprice10": this.str.Jprice10 = (string)value; break;							
						case "Pcode7": this.str.Pcode7 = (string)value; break;							
						case "Pcode8": this.str.Pcode8 = (string)value; break;							
						case "Pcode9": this.str.Pcode9 = (string)value; break;							
						case "Pcode10": this.str.Pcode10 = (string)value; break;							
						case "Price11": this.str.Price11 = (string)value; break;							
						case "Jprice11": this.str.Jprice11 = (string)value; break;							
						case "Pcode11": this.str.Pcode11 = (string)value; break;							
						case "BeefID": this.str.BeefID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "OnCurrentOrder1":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder1 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder2":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder2 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder3":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder3 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder4":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder4 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder5":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder5 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder6":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder6 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder7":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder7 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder8":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder8 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder9":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder9 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder10":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder10 = (System.Int32?)value;
							break;
						
						case "OnCurrentOrder11":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder11 = (System.Int32?)value;
							break;
						
						case "IsMaster1":
						
							if (value == null || value is System.Boolean)
								this.IsMaster1 = (System.Boolean?)value;
							break;
						
						case "IsMaster2":
						
							if (value == null || value is System.Boolean)
								this.IsMaster2 = (System.Boolean?)value;
							break;
						
						case "IsMaster3":
						
							if (value == null || value is System.Boolean)
								this.IsMaster3 = (System.Boolean?)value;
							break;
						
						case "IsMaster4":
						
							if (value == null || value is System.Boolean)
								this.IsMaster4 = (System.Boolean?)value;
							break;
						
						case "IsMaster5":
						
							if (value == null || value is System.Boolean)
								this.IsMaster5 = (System.Boolean?)value;
							break;
						
						case "IsMaster6":
						
							if (value == null || value is System.Boolean)
								this.IsMaster6 = (System.Boolean?)value;
							break;
						
						case "IsMaster7":
						
							if (value == null || value is System.Boolean)
								this.IsMaster7 = (System.Boolean?)value;
							break;
						
						case "IsMaster8":
						
							if (value == null || value is System.Boolean)
								this.IsMaster8 = (System.Boolean?)value;
							break;
						
						case "IsMaster9":
						
							if (value == null || value is System.Boolean)
								this.IsMaster9 = (System.Boolean?)value;
							break;
						
						case "IsMaster10":
						
							if (value == null || value is System.Boolean)
								this.IsMaster10 = (System.Boolean?)value;
							break;
						
						case "IsMaster11":
						
							if (value == null || value is System.Boolean)
								this.IsMaster11 = (System.Boolean?)value;
							break;
						
						case "Casecount1":
						
							if (value == null || value is System.Int32)
								this.Casecount1 = (System.Int32?)value;
							break;
						
						case "Casecount2":
						
							if (value == null || value is System.Int32)
								this.Casecount2 = (System.Int32?)value;
							break;
						
						case "Casecount3":
						
							if (value == null || value is System.Int32)
								this.Casecount3 = (System.Int32?)value;
							break;
						
						case "Casecount4":
						
							if (value == null || value is System.Int32)
								this.Casecount4 = (System.Int32?)value;
							break;
						
						case "Casecount5":
						
							if (value == null || value is System.Int32)
								this.Casecount5 = (System.Int32?)value;
							break;
						
						case "Casecount6":
						
							if (value == null || value is System.Int32)
								this.Casecount6 = (System.Int32?)value;
							break;
						
						case "Casecount7":
						
							if (value == null || value is System.Int32)
								this.Casecount7 = (System.Int32?)value;
							break;
						
						case "Casecount8":
						
							if (value == null || value is System.Int32)
								this.Casecount8 = (System.Int32?)value;
							break;
						
						case "Casecount9":
						
							if (value == null || value is System.Int32)
								this.Casecount9 = (System.Int32?)value;
							break;
						
						case "Casecount10":
						
							if (value == null || value is System.Int32)
								this.Casecount10 = (System.Int32?)value;
							break;
						
						case "Casecount11":
						
							if (value == null || value is System.Int32)
								this.Casecount11 = (System.Int32?)value;
							break;
						
						case "Price1":
						
							if (value == null || value is System.Double)
								this.Price1 = (System.Double?)value;
							break;
						
						case "Price2":
						
							if (value == null || value is System.Double)
								this.Price2 = (System.Double?)value;
							break;
						
						case "Price3":
						
							if (value == null || value is System.Double)
								this.Price3 = (System.Double?)value;
							break;
						
						case "Price4":
						
							if (value == null || value is System.Double)
								this.Price4 = (System.Double?)value;
							break;
						
						case "Price5":
						
							if (value == null || value is System.Double)
								this.Price5 = (System.Double?)value;
							break;
						
						case "Jprice1":
						
							if (value == null || value is System.Double)
								this.Jprice1 = (System.Double?)value;
							break;
						
						case "Jprice2":
						
							if (value == null || value is System.Double)
								this.Jprice2 = (System.Double?)value;
							break;
						
						case "Jprice3":
						
							if (value == null || value is System.Double)
								this.Jprice3 = (System.Double?)value;
							break;
						
						case "Jprice4":
						
							if (value == null || value is System.Double)
								this.Jprice4 = (System.Double?)value;
							break;
						
						case "Jprice5":
						
							if (value == null || value is System.Double)
								this.Jprice5 = (System.Double?)value;
							break;
						
						case "Price6":
						
							if (value == null || value is System.Double)
								this.Price6 = (System.Double?)value;
							break;
						
						case "Jprice6":
						
							if (value == null || value is System.Double)
								this.Jprice6 = (System.Double?)value;
							break;
						
						case "Price7":
						
							if (value == null || value is System.Double)
								this.Price7 = (System.Double?)value;
							break;
						
						case "Price8":
						
							if (value == null || value is System.Double)
								this.Price8 = (System.Double?)value;
							break;
						
						case "Price9":
						
							if (value == null || value is System.Double)
								this.Price9 = (System.Double?)value;
							break;
						
						case "Price10":
						
							if (value == null || value is System.Double)
								this.Price10 = (System.Double?)value;
							break;
						
						case "Jprice7":
						
							if (value == null || value is System.Double)
								this.Jprice7 = (System.Double?)value;
							break;
						
						case "Jprice8":
						
							if (value == null || value is System.Double)
								this.Jprice8 = (System.Double?)value;
							break;
						
						case "Jprice9":
						
							if (value == null || value is System.Double)
								this.Jprice9 = (System.Double?)value;
							break;
						
						case "Jprice10":
						
							if (value == null || value is System.Double)
								this.Jprice10 = (System.Double?)value;
							break;
						
						case "Price11":
						
							if (value == null || value is System.Double)
								this.Price11 = (System.Double?)value;
							break;
						
						case "Jprice11":
						
							if (value == null || value is System.Double)
								this.Jprice11 = (System.Double?)value;
							break;
						
						case "BeefID":
						
							if (value == null || value is System.Int32)
								this.BeefID = (System.Int32?)value;
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
		/// Maps to vwBeef.onCurrentOrder1
		/// </summary>
		virtual public System.Int32? OnCurrentOrder1
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder1);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder2
		/// </summary>
		virtual public System.Int32? OnCurrentOrder2
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder2);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder3
		/// </summary>
		virtual public System.Int32? OnCurrentOrder3
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder3);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder4
		/// </summary>
		virtual public System.Int32? OnCurrentOrder4
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder4);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder5
		/// </summary>
		virtual public System.Int32? OnCurrentOrder5
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder5);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder6
		/// </summary>
		virtual public System.Int32? OnCurrentOrder6
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder6);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder7
		/// </summary>
		virtual public System.Int32? OnCurrentOrder7
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder7);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder8
		/// </summary>
		virtual public System.Int32? OnCurrentOrder8
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder8);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder9
		/// </summary>
		virtual public System.Int32? OnCurrentOrder9
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder9);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder10
		/// </summary>
		virtual public System.Int32? OnCurrentOrder10
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder10);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.onCurrentOrder11
		/// </summary>
		virtual public System.Int32? OnCurrentOrder11
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder11);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.OnCurrentOrder11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description1
		/// </summary>
		virtual public System.String Description1
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description1);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description2
		/// </summary>
		virtual public System.String Description2
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description2);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description3
		/// </summary>
		virtual public System.String Description3
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description3);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description4
		/// </summary>
		virtual public System.String Description4
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description4);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description5
		/// </summary>
		virtual public System.String Description5
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description5);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description6
		/// </summary>
		virtual public System.String Description6
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description6);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description7
		/// </summary>
		virtual public System.String Description7
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description7);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description8
		/// </summary>
		virtual public System.String Description8
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description8);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description9
		/// </summary>
		virtual public System.String Description9
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description9);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description10
		/// </summary>
		virtual public System.String Description10
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description10);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description11
		/// </summary>
		virtual public System.String Description11
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description11);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid1
		/// </summary>
		virtual public System.String Catid1
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid1);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid2
		/// </summary>
		virtual public System.String Catid2
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid2);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid3
		/// </summary>
		virtual public System.String Catid3
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid3);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid4
		/// </summary>
		virtual public System.String Catid4
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid4);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid5
		/// </summary>
		virtual public System.String Catid5
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid5);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid6
		/// </summary>
		virtual public System.String Catid6
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid6);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid7
		/// </summary>
		virtual public System.String Catid7
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid7);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid8
		/// </summary>
		virtual public System.String Catid8
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid8);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid9
		/// </summary>
		virtual public System.String Catid9
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid9);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid10
		/// </summary>
		virtual public System.String Catid10
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid10);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.catid11
		/// </summary>
		virtual public System.String Catid11
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Catid11);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Catid11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid1
		/// </summary>
		virtual public System.String Scatid1
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid1);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid2
		/// </summary>
		virtual public System.String Scatid2
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid2);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid3
		/// </summary>
		virtual public System.String Scatid3
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid3);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid4
		/// </summary>
		virtual public System.String Scatid4
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid4);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid5
		/// </summary>
		virtual public System.String Scatid5
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid5);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid6
		/// </summary>
		virtual public System.String Scatid6
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid6);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid7
		/// </summary>
		virtual public System.String Scatid7
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid7);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid8
		/// </summary>
		virtual public System.String Scatid8
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid8);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid9
		/// </summary>
		virtual public System.String Scatid9
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid9);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid10
		/// </summary>
		virtual public System.String Scatid10
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid10);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.scatid11
		/// </summary>
		virtual public System.String Scatid11
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Scatid11);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Scatid11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster1
		/// </summary>
		virtual public System.Boolean? IsMaster1
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster1);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster2
		/// </summary>
		virtual public System.Boolean? IsMaster2
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster2);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster3
		/// </summary>
		virtual public System.Boolean? IsMaster3
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster3);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster4
		/// </summary>
		virtual public System.Boolean? IsMaster4
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster4);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster5
		/// </summary>
		virtual public System.Boolean? IsMaster5
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster5);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster6
		/// </summary>
		virtual public System.Boolean? IsMaster6
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster6);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster7
		/// </summary>
		virtual public System.Boolean? IsMaster7
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster7);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster8
		/// </summary>
		virtual public System.Boolean? IsMaster8
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster8);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster9
		/// </summary>
		virtual public System.Boolean? IsMaster9
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster9);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster10
		/// </summary>
		virtual public System.Boolean? IsMaster10
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster10);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.IsMaster11
		/// </summary>
		virtual public System.Boolean? IsMaster11
		{
			get
			{
				return base.GetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster11);
			}
			
			set
			{
				base.SetSystemBoolean(VwBeefMetadata.ColumnNames.IsMaster11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount1
		/// </summary>
		virtual public System.Int32? Casecount1
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount1);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount2
		/// </summary>
		virtual public System.Int32? Casecount2
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount2);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount3
		/// </summary>
		virtual public System.Int32? Casecount3
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount3);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount4
		/// </summary>
		virtual public System.Int32? Casecount4
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount4);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount5
		/// </summary>
		virtual public System.Int32? Casecount5
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount5);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount6
		/// </summary>
		virtual public System.Int32? Casecount6
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount6);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount7
		/// </summary>
		virtual public System.Int32? Casecount7
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount7);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount8
		/// </summary>
		virtual public System.Int32? Casecount8
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount8);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount9
		/// </summary>
		virtual public System.Int32? Casecount9
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount9);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount10
		/// </summary>
		virtual public System.Int32? Casecount10
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount10);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.Casecount11
		/// </summary>
		virtual public System.Int32? Casecount11
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.Casecount11);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.Casecount11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Description);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Description, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode1
		/// </summary>
		virtual public System.String Pcode1
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode1);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price1
		/// </summary>
		virtual public System.Double? Price1
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price1);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode2
		/// </summary>
		virtual public System.String Pcode2
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode2);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price2
		/// </summary>
		virtual public System.Double? Price2
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price2);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode3
		/// </summary>
		virtual public System.String Pcode3
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode3);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price3
		/// </summary>
		virtual public System.Double? Price3
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price3);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode4
		/// </summary>
		virtual public System.String Pcode4
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode4);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price4
		/// </summary>
		virtual public System.Double? Price4
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price4);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode5
		/// </summary>
		virtual public System.String Pcode5
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode5);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price5
		/// </summary>
		virtual public System.Double? Price5
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price5);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice1
		/// </summary>
		virtual public System.Double? Jprice1
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice1);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice1, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice2
		/// </summary>
		virtual public System.Double? Jprice2
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice2);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice2, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice3
		/// </summary>
		virtual public System.Double? Jprice3
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice3);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice3, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice4
		/// </summary>
		virtual public System.Double? Jprice4
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice4);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice4, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice5
		/// </summary>
		virtual public System.Double? Jprice5
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice5);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice5, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode6
		/// </summary>
		virtual public System.String Pcode6
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode6);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price6
		/// </summary>
		virtual public System.Double? Price6
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price6);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice6
		/// </summary>
		virtual public System.Double? Jprice6
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice6);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice6, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price7
		/// </summary>
		virtual public System.Double? Price7
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price7);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price8
		/// </summary>
		virtual public System.Double? Price8
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price8);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price9
		/// </summary>
		virtual public System.Double? Price9
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price9);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price10
		/// </summary>
		virtual public System.Double? Price10
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price10);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice7
		/// </summary>
		virtual public System.Double? Jprice7
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice7);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice8
		/// </summary>
		virtual public System.Double? Jprice8
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice8);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice9
		/// </summary>
		virtual public System.Double? Jprice9
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice9);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice10
		/// </summary>
		virtual public System.Double? Jprice10
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice10);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode7
		/// </summary>
		virtual public System.String Pcode7
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode7);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode7, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode8
		/// </summary>
		virtual public System.String Pcode8
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode8);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode8, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode9
		/// </summary>
		virtual public System.String Pcode9
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode9);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode9, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode10
		/// </summary>
		virtual public System.String Pcode10
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode10);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode10, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.price11
		/// </summary>
		virtual public System.Double? Price11
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Price11);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Price11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.jprice11
		/// </summary>
		virtual public System.Double? Jprice11
		{
			get
			{
				return base.GetSystemDouble(VwBeefMetadata.ColumnNames.Jprice11);
			}
			
			set
			{
				base.SetSystemDouble(VwBeefMetadata.ColumnNames.Jprice11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.pcode11
		/// </summary>
		virtual public System.String Pcode11
		{
			get
			{
				return base.GetSystemString(VwBeefMetadata.ColumnNames.Pcode11);
			}
			
			set
			{
				base.SetSystemString(VwBeefMetadata.ColumnNames.Pcode11, value);
			}
		}
		
		/// <summary>
		/// Maps to vwBeef.beefID
		/// </summary>
		virtual public System.Int32? BeefID
		{
			get
			{
				return base.GetSystemInt32(VwBeefMetadata.ColumnNames.BeefID);
			}
			
			set
			{
				base.SetSystemInt32(VwBeefMetadata.ColumnNames.BeefID, value);
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
			public esStrings(esVwBeefBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String OnCurrentOrder1
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder1 = null;
					else entity.OnCurrentOrder1 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder2
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder2 = null;
					else entity.OnCurrentOrder2 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder3
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder3 = null;
					else entity.OnCurrentOrder3 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder4
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder4 = null;
					else entity.OnCurrentOrder4 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder5
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder5 = null;
					else entity.OnCurrentOrder5 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder6
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder6 = null;
					else entity.OnCurrentOrder6 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder7
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder7 = null;
					else entity.OnCurrentOrder7 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder8
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder8 = null;
					else entity.OnCurrentOrder8 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder9
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder9 = null;
					else entity.OnCurrentOrder9 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder10
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder10 = null;
					else entity.OnCurrentOrder10 = Convert.ToInt32(value);
				}
			}
				
			public System.String OnCurrentOrder11
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder11 = null;
					else entity.OnCurrentOrder11 = Convert.ToInt32(value);
				}
			}
				
			public System.String Description1
			{
				get
				{
					System.String data = entity.Description1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description1 = null;
					else entity.Description1 = Convert.ToString(value);
				}
			}
				
			public System.String Description2
			{
				get
				{
					System.String data = entity.Description2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description2 = null;
					else entity.Description2 = Convert.ToString(value);
				}
			}
				
			public System.String Description3
			{
				get
				{
					System.String data = entity.Description3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description3 = null;
					else entity.Description3 = Convert.ToString(value);
				}
			}
				
			public System.String Description4
			{
				get
				{
					System.String data = entity.Description4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description4 = null;
					else entity.Description4 = Convert.ToString(value);
				}
			}
				
			public System.String Description5
			{
				get
				{
					System.String data = entity.Description5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description5 = null;
					else entity.Description5 = Convert.ToString(value);
				}
			}
				
			public System.String Description6
			{
				get
				{
					System.String data = entity.Description6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description6 = null;
					else entity.Description6 = Convert.ToString(value);
				}
			}
				
			public System.String Description7
			{
				get
				{
					System.String data = entity.Description7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description7 = null;
					else entity.Description7 = Convert.ToString(value);
				}
			}
				
			public System.String Description8
			{
				get
				{
					System.String data = entity.Description8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description8 = null;
					else entity.Description8 = Convert.ToString(value);
				}
			}
				
			public System.String Description9
			{
				get
				{
					System.String data = entity.Description9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description9 = null;
					else entity.Description9 = Convert.ToString(value);
				}
			}
				
			public System.String Description10
			{
				get
				{
					System.String data = entity.Description10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description10 = null;
					else entity.Description10 = Convert.ToString(value);
				}
			}
				
			public System.String Description11
			{
				get
				{
					System.String data = entity.Description11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description11 = null;
					else entity.Description11 = Convert.ToString(value);
				}
			}
				
			public System.String Catid1
			{
				get
				{
					System.String data = entity.Catid1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid1 = null;
					else entity.Catid1 = Convert.ToString(value);
				}
			}
				
			public System.String Catid2
			{
				get
				{
					System.String data = entity.Catid2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid2 = null;
					else entity.Catid2 = Convert.ToString(value);
				}
			}
				
			public System.String Catid3
			{
				get
				{
					System.String data = entity.Catid3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid3 = null;
					else entity.Catid3 = Convert.ToString(value);
				}
			}
				
			public System.String Catid4
			{
				get
				{
					System.String data = entity.Catid4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid4 = null;
					else entity.Catid4 = Convert.ToString(value);
				}
			}
				
			public System.String Catid5
			{
				get
				{
					System.String data = entity.Catid5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid5 = null;
					else entity.Catid5 = Convert.ToString(value);
				}
			}
				
			public System.String Catid6
			{
				get
				{
					System.String data = entity.Catid6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid6 = null;
					else entity.Catid6 = Convert.ToString(value);
				}
			}
				
			public System.String Catid7
			{
				get
				{
					System.String data = entity.Catid7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid7 = null;
					else entity.Catid7 = Convert.ToString(value);
				}
			}
				
			public System.String Catid8
			{
				get
				{
					System.String data = entity.Catid8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid8 = null;
					else entity.Catid8 = Convert.ToString(value);
				}
			}
				
			public System.String Catid9
			{
				get
				{
					System.String data = entity.Catid9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid9 = null;
					else entity.Catid9 = Convert.ToString(value);
				}
			}
				
			public System.String Catid10
			{
				get
				{
					System.String data = entity.Catid10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid10 = null;
					else entity.Catid10 = Convert.ToString(value);
				}
			}
				
			public System.String Catid11
			{
				get
				{
					System.String data = entity.Catid11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Catid11 = null;
					else entity.Catid11 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid1
			{
				get
				{
					System.String data = entity.Scatid1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid1 = null;
					else entity.Scatid1 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid2
			{
				get
				{
					System.String data = entity.Scatid2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid2 = null;
					else entity.Scatid2 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid3
			{
				get
				{
					System.String data = entity.Scatid3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid3 = null;
					else entity.Scatid3 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid4
			{
				get
				{
					System.String data = entity.Scatid4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid4 = null;
					else entity.Scatid4 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid5
			{
				get
				{
					System.String data = entity.Scatid5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid5 = null;
					else entity.Scatid5 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid6
			{
				get
				{
					System.String data = entity.Scatid6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid6 = null;
					else entity.Scatid6 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid7
			{
				get
				{
					System.String data = entity.Scatid7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid7 = null;
					else entity.Scatid7 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid8
			{
				get
				{
					System.String data = entity.Scatid8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid8 = null;
					else entity.Scatid8 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid9
			{
				get
				{
					System.String data = entity.Scatid9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid9 = null;
					else entity.Scatid9 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid10
			{
				get
				{
					System.String data = entity.Scatid10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid10 = null;
					else entity.Scatid10 = Convert.ToString(value);
				}
			}
				
			public System.String Scatid11
			{
				get
				{
					System.String data = entity.Scatid11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Scatid11 = null;
					else entity.Scatid11 = Convert.ToString(value);
				}
			}
				
			public System.String IsMaster1
			{
				get
				{
					System.Boolean? data = entity.IsMaster1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster1 = null;
					else entity.IsMaster1 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster2
			{
				get
				{
					System.Boolean? data = entity.IsMaster2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster2 = null;
					else entity.IsMaster2 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster3
			{
				get
				{
					System.Boolean? data = entity.IsMaster3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster3 = null;
					else entity.IsMaster3 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster4
			{
				get
				{
					System.Boolean? data = entity.IsMaster4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster4 = null;
					else entity.IsMaster4 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster5
			{
				get
				{
					System.Boolean? data = entity.IsMaster5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster5 = null;
					else entity.IsMaster5 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster6
			{
				get
				{
					System.Boolean? data = entity.IsMaster6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster6 = null;
					else entity.IsMaster6 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster7
			{
				get
				{
					System.Boolean? data = entity.IsMaster7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster7 = null;
					else entity.IsMaster7 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster8
			{
				get
				{
					System.Boolean? data = entity.IsMaster8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster8 = null;
					else entity.IsMaster8 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster9
			{
				get
				{
					System.Boolean? data = entity.IsMaster9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster9 = null;
					else entity.IsMaster9 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster10
			{
				get
				{
					System.Boolean? data = entity.IsMaster10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster10 = null;
					else entity.IsMaster10 = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsMaster11
			{
				get
				{
					System.Boolean? data = entity.IsMaster11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster11 = null;
					else entity.IsMaster11 = Convert.ToBoolean(value);
				}
			}
				
			public System.String Casecount1
			{
				get
				{
					System.Int32? data = entity.Casecount1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount1 = null;
					else entity.Casecount1 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount2
			{
				get
				{
					System.Int32? data = entity.Casecount2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount2 = null;
					else entity.Casecount2 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount3
			{
				get
				{
					System.Int32? data = entity.Casecount3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount3 = null;
					else entity.Casecount3 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount4
			{
				get
				{
					System.Int32? data = entity.Casecount4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount4 = null;
					else entity.Casecount4 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount5
			{
				get
				{
					System.Int32? data = entity.Casecount5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount5 = null;
					else entity.Casecount5 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount6
			{
				get
				{
					System.Int32? data = entity.Casecount6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount6 = null;
					else entity.Casecount6 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount7
			{
				get
				{
					System.Int32? data = entity.Casecount7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount7 = null;
					else entity.Casecount7 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount8
			{
				get
				{
					System.Int32? data = entity.Casecount8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount8 = null;
					else entity.Casecount8 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount9
			{
				get
				{
					System.Int32? data = entity.Casecount9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount9 = null;
					else entity.Casecount9 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount10
			{
				get
				{
					System.Int32? data = entity.Casecount10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount10 = null;
					else entity.Casecount10 = Convert.ToInt32(value);
				}
			}
				
			public System.String Casecount11
			{
				get
				{
					System.Int32? data = entity.Casecount11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Casecount11 = null;
					else entity.Casecount11 = Convert.ToInt32(value);
				}
			}
				
			public System.String Description
			{
				get
				{
					System.String data = entity.Description;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description = null;
					else entity.Description = Convert.ToString(value);
				}
			}
				
			public System.String Pcode1
			{
				get
				{
					System.String data = entity.Pcode1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode1 = null;
					else entity.Pcode1 = Convert.ToString(value);
				}
			}
				
			public System.String Price1
			{
				get
				{
					System.Double? data = entity.Price1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price1 = null;
					else entity.Price1 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode2
			{
				get
				{
					System.String data = entity.Pcode2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode2 = null;
					else entity.Pcode2 = Convert.ToString(value);
				}
			}
				
			public System.String Price2
			{
				get
				{
					System.Double? data = entity.Price2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price2 = null;
					else entity.Price2 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode3
			{
				get
				{
					System.String data = entity.Pcode3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode3 = null;
					else entity.Pcode3 = Convert.ToString(value);
				}
			}
				
			public System.String Price3
			{
				get
				{
					System.Double? data = entity.Price3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price3 = null;
					else entity.Price3 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode4
			{
				get
				{
					System.String data = entity.Pcode4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode4 = null;
					else entity.Pcode4 = Convert.ToString(value);
				}
			}
				
			public System.String Price4
			{
				get
				{
					System.Double? data = entity.Price4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price4 = null;
					else entity.Price4 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode5
			{
				get
				{
					System.String data = entity.Pcode5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode5 = null;
					else entity.Pcode5 = Convert.ToString(value);
				}
			}
				
			public System.String Price5
			{
				get
				{
					System.Double? data = entity.Price5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price5 = null;
					else entity.Price5 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice1
			{
				get
				{
					System.Double? data = entity.Jprice1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice1 = null;
					else entity.Jprice1 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice2
			{
				get
				{
					System.Double? data = entity.Jprice2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice2 = null;
					else entity.Jprice2 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice3
			{
				get
				{
					System.Double? data = entity.Jprice3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice3 = null;
					else entity.Jprice3 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice4
			{
				get
				{
					System.Double? data = entity.Jprice4;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice4 = null;
					else entity.Jprice4 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice5
			{
				get
				{
					System.Double? data = entity.Jprice5;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice5 = null;
					else entity.Jprice5 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode6
			{
				get
				{
					System.String data = entity.Pcode6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode6 = null;
					else entity.Pcode6 = Convert.ToString(value);
				}
			}
				
			public System.String Price6
			{
				get
				{
					System.Double? data = entity.Price6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price6 = null;
					else entity.Price6 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice6
			{
				get
				{
					System.Double? data = entity.Jprice6;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice6 = null;
					else entity.Jprice6 = Convert.ToDouble(value);
				}
			}
				
			public System.String Price7
			{
				get
				{
					System.Double? data = entity.Price7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price7 = null;
					else entity.Price7 = Convert.ToDouble(value);
				}
			}
				
			public System.String Price8
			{
				get
				{
					System.Double? data = entity.Price8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price8 = null;
					else entity.Price8 = Convert.ToDouble(value);
				}
			}
				
			public System.String Price9
			{
				get
				{
					System.Double? data = entity.Price9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price9 = null;
					else entity.Price9 = Convert.ToDouble(value);
				}
			}
				
			public System.String Price10
			{
				get
				{
					System.Double? data = entity.Price10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price10 = null;
					else entity.Price10 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice7
			{
				get
				{
					System.Double? data = entity.Jprice7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice7 = null;
					else entity.Jprice7 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice8
			{
				get
				{
					System.Double? data = entity.Jprice8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice8 = null;
					else entity.Jprice8 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice9
			{
				get
				{
					System.Double? data = entity.Jprice9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice9 = null;
					else entity.Jprice9 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice10
			{
				get
				{
					System.Double? data = entity.Jprice10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice10 = null;
					else entity.Jprice10 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode7
			{
				get
				{
					System.String data = entity.Pcode7;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode7 = null;
					else entity.Pcode7 = Convert.ToString(value);
				}
			}
				
			public System.String Pcode8
			{
				get
				{
					System.String data = entity.Pcode8;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode8 = null;
					else entity.Pcode8 = Convert.ToString(value);
				}
			}
				
			public System.String Pcode9
			{
				get
				{
					System.String data = entity.Pcode9;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode9 = null;
					else entity.Pcode9 = Convert.ToString(value);
				}
			}
				
			public System.String Pcode10
			{
				get
				{
					System.String data = entity.Pcode10;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode10 = null;
					else entity.Pcode10 = Convert.ToString(value);
				}
			}
				
			public System.String Price11
			{
				get
				{
					System.Double? data = entity.Price11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price11 = null;
					else entity.Price11 = Convert.ToDouble(value);
				}
			}
				
			public System.String Jprice11
			{
				get
				{
					System.Double? data = entity.Jprice11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jprice11 = null;
					else entity.Jprice11 = Convert.ToDouble(value);
				}
			}
				
			public System.String Pcode11
			{
				get
				{
					System.String data = entity.Pcode11;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Pcode11 = null;
					else entity.Pcode11 = Convert.ToString(value);
				}
			}
				
			public System.String BeefID
			{
				get
				{
					System.Int32? data = entity.BeefID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BeefID = null;
					else entity.BeefID = Convert.ToInt32(value);
				}
			}
			

			private esVwBeefBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esVwBeefQuery query)
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
				throw new Exception("esVwBeefBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esVwBeefQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VwBeefMetadata.Meta();
			}
		}	
		

		public esQueryItem OnCurrentOrder1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder1, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder2, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder3, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder4, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder5, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder6, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder7, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder8, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder9, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder10, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnCurrentOrder11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.OnCurrentOrder11, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Description1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description1, esSystemType.String);
			}
		} 
		
		public esQueryItem Description2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description2, esSystemType.String);
			}
		} 
		
		public esQueryItem Description3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description3, esSystemType.String);
			}
		} 
		
		public esQueryItem Description4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description4, esSystemType.String);
			}
		} 
		
		public esQueryItem Description5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description5, esSystemType.String);
			}
		} 
		
		public esQueryItem Description6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description6, esSystemType.String);
			}
		} 
		
		public esQueryItem Description7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description7, esSystemType.String);
			}
		} 
		
		public esQueryItem Description8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description8, esSystemType.String);
			}
		} 
		
		public esQueryItem Description9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description9, esSystemType.String);
			}
		} 
		
		public esQueryItem Description10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description10, esSystemType.String);
			}
		} 
		
		public esQueryItem Description11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description11, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid1, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid2, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid3, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid4, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid5, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid6, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid7, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid8, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid9, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid10, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Catid11, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid1, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid2, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid3, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid4, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid5, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid6, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid7, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid8, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid9, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid10, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Scatid11, esSystemType.String);
			}
		} 
		
		public esQueryItem IsMaster1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster1, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster2, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster3, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster4, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster5, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster6, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster7, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster8, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster9, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster10, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsMaster11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.IsMaster11, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Casecount1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount1, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount2, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount3, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount4, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount5, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount6, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount7, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount8, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount9, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount10, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Casecount11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Casecount11, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode1, esSystemType.String);
			}
		} 
		
		public esQueryItem Price1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price1, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode2, esSystemType.String);
			}
		} 
		
		public esQueryItem Price2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price2, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode3, esSystemType.String);
			}
		} 
		
		public esQueryItem Price3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price3, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode4, esSystemType.String);
			}
		} 
		
		public esQueryItem Price4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price4, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode5, esSystemType.String);
			}
		} 
		
		public esQueryItem Price5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price5, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice1
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice1, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice2
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice2, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice3
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice3, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice4
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice4, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice5
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice5, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode6, esSystemType.String);
			}
		} 
		
		public esQueryItem Price6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price6, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice6
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice6, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price7, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price8, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price9, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price10, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice7, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice8, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice9, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice10, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode7
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode7, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode8
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode8, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode9
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode9, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode10
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode10, esSystemType.String);
			}
		} 
		
		public esQueryItem Price11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Price11, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Jprice11, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode11
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.Pcode11, esSystemType.String);
			}
		} 
		
		public esQueryItem BeefID
		{
			get
			{
				return new esQueryItem(this, VwBeefMetadata.ColumnNames.BeefID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("VwBeefCollection")]
	public partial class VwBeefCollection : esVwBeefCollection, IEnumerable<VwBeefBO>
	{
		public VwBeefCollection()
		{

		}
		
		public static implicit operator List<VwBeefBO>(VwBeefCollection coll)
		{
			List<VwBeefBO> list = new List<VwBeefBO>();
			
			foreach (VwBeefBO emp in coll)
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
				return  VwBeefMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwBeefQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new VwBeefBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new VwBeefBO();
		}
		
		
		override public bool LoadAll()
		{
			return base.LoadAll(esSqlAccessType.DynamicSQL);
		}	
		
		#endregion


		[BrowsableAttribute( false )]
		public VwBeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwBeefQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(VwBeefQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public VwBeefBO AddNew()
		{
			VwBeefBO entity = base.AddNewEntity() as VwBeefBO;
			
			return entity;
		}


		#region IEnumerable<VwBeefBO> Members

		IEnumerator<VwBeefBO> IEnumerable<VwBeefBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as VwBeefBO;
			}
		}

		#endregion
		
		private VwBeefQuery query;
	}


	/// <summary>
	/// Encapsulates the 'vwBeef' view
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("VwBeefBO ()")]
	[Serializable]
	public partial class VwBeefBO : esVwBeefBO
	{
		public VwBeefBO()
		{

		}
	
		public VwBeefBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VwBeefMetadata.Meta();
			}
		}
		
		
		
		override protected esVwBeefQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwBeefQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public VwBeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwBeefQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(VwBeefQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private VwBeefQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class VwBeefQuery : esVwBeefQuery
	{
		public VwBeefQuery()
		{

		}		
		
		public VwBeefQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "VwBeefQuery";
        }
		
			
	}


	[Serializable]
	public partial class VwBeefMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VwBeefMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder1, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder1;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder2, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder2;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder3, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder3;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder4, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder4;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder5, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder5;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder6, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder6;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder7, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder7;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder8, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder8;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder9, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder9;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder10, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder10;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.OnCurrentOrder11, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.OnCurrentOrder11;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description1, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description1;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description2, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description2;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description3, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description3;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description4, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description4;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description5, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description5;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description6, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description6;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description7, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description7;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description8, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description8;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description9, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description9;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description10, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description10;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description11, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description11;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid1, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid1;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid2, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid2;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid3, 24, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid3;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid4, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid4;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid5, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid5;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid6, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid6;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid7, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid7;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid8, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid8;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid9, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid9;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid10, 31, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid10;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Catid11, 32, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Catid11;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid1, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid1;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid2, 34, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid2;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid3, 35, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid3;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid4, 36, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid4;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid5, 37, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid5;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid6, 38, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid6;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid7, 39, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid7;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid8, 40, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid8;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid9, 41, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid9;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid10, 42, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid10;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Scatid11, 43, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Scatid11;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster1, 44, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster2, 45, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster3, 46, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster4, 47, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster4;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster5, 48, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster5;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster6, 49, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster7, 50, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster7;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster8, 51, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster8;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster9, 52, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster9;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster10, 53, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.IsMaster11, 54, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwBeefMetadata.PropertyNames.IsMaster11;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount1, 55, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount1;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount2, 56, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount2;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount3, 57, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount3;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount4, 58, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount4;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount5, 59, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount5;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount6, 60, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount6;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount7, 61, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount7;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount8, 62, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount8;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount9, 63, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount9;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount10, 64, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount10;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Casecount11, 65, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.Casecount11;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Description, 66, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode1, 67, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode1;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price1, 68, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode2, 69, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode2;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price2, 70, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode3, 71, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode3;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price3, 72, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode4, 73, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode4;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price4, 74, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode5, 75, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode5;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price5, 76, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice1, 77, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice2, 78, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice3, 79, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice4, 80, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice5, 81, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode6, 82, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode6;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price6, 83, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice6, 84, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price7, 85, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price8, 86, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price9, 87, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price10, 88, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice7, 89, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice8, 90, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice9, 91, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice10, 92, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode7, 93, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode7;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode8, 94, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode8;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode9, 95, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode9;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode10, 96, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode10;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Price11, 97, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Price11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Jprice11, 98, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwBeefMetadata.PropertyNames.Jprice11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.Pcode11, 99, typeof(System.String), esSystemType.String);
			c.PropertyName = VwBeefMetadata.PropertyNames.Pcode11;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwBeefMetadata.ColumnNames.BeefID, 100, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwBeefMetadata.PropertyNames.BeefID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public VwBeefMetadata Meta()
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
			 public const string OnCurrentOrder1 = "onCurrentOrder1";
			 public const string OnCurrentOrder2 = "onCurrentOrder2";
			 public const string OnCurrentOrder3 = "onCurrentOrder3";
			 public const string OnCurrentOrder4 = "onCurrentOrder4";
			 public const string OnCurrentOrder5 = "onCurrentOrder5";
			 public const string OnCurrentOrder6 = "onCurrentOrder6";
			 public const string OnCurrentOrder7 = "onCurrentOrder7";
			 public const string OnCurrentOrder8 = "onCurrentOrder8";
			 public const string OnCurrentOrder9 = "onCurrentOrder9";
			 public const string OnCurrentOrder10 = "onCurrentOrder10";
			 public const string OnCurrentOrder11 = "onCurrentOrder11";
			 public const string Description1 = "description1";
			 public const string Description2 = "description2";
			 public const string Description3 = "description3";
			 public const string Description4 = "description4";
			 public const string Description5 = "description5";
			 public const string Description6 = "description6";
			 public const string Description7 = "description7";
			 public const string Description8 = "description8";
			 public const string Description9 = "description9";
			 public const string Description10 = "description10";
			 public const string Description11 = "description11";
			 public const string Catid1 = "catid1";
			 public const string Catid2 = "catid2";
			 public const string Catid3 = "catid3";
			 public const string Catid4 = "catid4";
			 public const string Catid5 = "catid5";
			 public const string Catid6 = "catid6";
			 public const string Catid7 = "catid7";
			 public const string Catid8 = "catid8";
			 public const string Catid9 = "catid9";
			 public const string Catid10 = "catid10";
			 public const string Catid11 = "catid11";
			 public const string Scatid1 = "scatid1";
			 public const string Scatid2 = "scatid2";
			 public const string Scatid3 = "scatid3";
			 public const string Scatid4 = "scatid4";
			 public const string Scatid5 = "scatid5";
			 public const string Scatid6 = "scatid6";
			 public const string Scatid7 = "scatid7";
			 public const string Scatid8 = "scatid8";
			 public const string Scatid9 = "scatid9";
			 public const string Scatid10 = "scatid10";
			 public const string Scatid11 = "scatid11";
			 public const string IsMaster1 = "IsMaster1";
			 public const string IsMaster2 = "IsMaster2";
			 public const string IsMaster3 = "IsMaster3";
			 public const string IsMaster4 = "IsMaster4";
			 public const string IsMaster5 = "IsMaster5";
			 public const string IsMaster6 = "IsMaster6";
			 public const string IsMaster7 = "IsMaster7";
			 public const string IsMaster8 = "IsMaster8";
			 public const string IsMaster9 = "IsMaster9";
			 public const string IsMaster10 = "IsMaster10";
			 public const string IsMaster11 = "IsMaster11";
			 public const string Casecount1 = "Casecount1";
			 public const string Casecount2 = "Casecount2";
			 public const string Casecount3 = "Casecount3";
			 public const string Casecount4 = "Casecount4";
			 public const string Casecount5 = "Casecount5";
			 public const string Casecount6 = "Casecount6";
			 public const string Casecount7 = "Casecount7";
			 public const string Casecount8 = "Casecount8";
			 public const string Casecount9 = "Casecount9";
			 public const string Casecount10 = "Casecount10";
			 public const string Casecount11 = "Casecount11";
			 public const string Description = "description";
			 public const string Pcode1 = "pcode1";
			 public const string Price1 = "price1";
			 public const string Pcode2 = "pcode2";
			 public const string Price2 = "price2";
			 public const string Pcode3 = "pcode3";
			 public const string Price3 = "price3";
			 public const string Pcode4 = "pcode4";
			 public const string Price4 = "price4";
			 public const string Pcode5 = "pcode5";
			 public const string Price5 = "price5";
			 public const string Jprice1 = "jprice1";
			 public const string Jprice2 = "jprice2";
			 public const string Jprice3 = "jprice3";
			 public const string Jprice4 = "jprice4";
			 public const string Jprice5 = "jprice5";
			 public const string Pcode6 = "pcode6";
			 public const string Price6 = "price6";
			 public const string Jprice6 = "jprice6";
			 public const string Price7 = "price7";
			 public const string Price8 = "price8";
			 public const string Price9 = "price9";
			 public const string Price10 = "price10";
			 public const string Jprice7 = "jprice7";
			 public const string Jprice8 = "jprice8";
			 public const string Jprice9 = "jprice9";
			 public const string Jprice10 = "jprice10";
			 public const string Pcode7 = "pcode7";
			 public const string Pcode8 = "pcode8";
			 public const string Pcode9 = "pcode9";
			 public const string Pcode10 = "pcode10";
			 public const string Price11 = "price11";
			 public const string Jprice11 = "jprice11";
			 public const string Pcode11 = "pcode11";
			 public const string BeefID = "beefID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string OnCurrentOrder1 = "OnCurrentOrder1";
			 public const string OnCurrentOrder2 = "OnCurrentOrder2";
			 public const string OnCurrentOrder3 = "OnCurrentOrder3";
			 public const string OnCurrentOrder4 = "OnCurrentOrder4";
			 public const string OnCurrentOrder5 = "OnCurrentOrder5";
			 public const string OnCurrentOrder6 = "OnCurrentOrder6";
			 public const string OnCurrentOrder7 = "OnCurrentOrder7";
			 public const string OnCurrentOrder8 = "OnCurrentOrder8";
			 public const string OnCurrentOrder9 = "OnCurrentOrder9";
			 public const string OnCurrentOrder10 = "OnCurrentOrder10";
			 public const string OnCurrentOrder11 = "OnCurrentOrder11";
			 public const string Description1 = "Description1";
			 public const string Description2 = "Description2";
			 public const string Description3 = "Description3";
			 public const string Description4 = "Description4";
			 public const string Description5 = "Description5";
			 public const string Description6 = "Description6";
			 public const string Description7 = "Description7";
			 public const string Description8 = "Description8";
			 public const string Description9 = "Description9";
			 public const string Description10 = "Description10";
			 public const string Description11 = "Description11";
			 public const string Catid1 = "Catid1";
			 public const string Catid2 = "Catid2";
			 public const string Catid3 = "Catid3";
			 public const string Catid4 = "Catid4";
			 public const string Catid5 = "Catid5";
			 public const string Catid6 = "Catid6";
			 public const string Catid7 = "Catid7";
			 public const string Catid8 = "Catid8";
			 public const string Catid9 = "Catid9";
			 public const string Catid10 = "Catid10";
			 public const string Catid11 = "Catid11";
			 public const string Scatid1 = "Scatid1";
			 public const string Scatid2 = "Scatid2";
			 public const string Scatid3 = "Scatid3";
			 public const string Scatid4 = "Scatid4";
			 public const string Scatid5 = "Scatid5";
			 public const string Scatid6 = "Scatid6";
			 public const string Scatid7 = "Scatid7";
			 public const string Scatid8 = "Scatid8";
			 public const string Scatid9 = "Scatid9";
			 public const string Scatid10 = "Scatid10";
			 public const string Scatid11 = "Scatid11";
			 public const string IsMaster1 = "IsMaster1";
			 public const string IsMaster2 = "IsMaster2";
			 public const string IsMaster3 = "IsMaster3";
			 public const string IsMaster4 = "IsMaster4";
			 public const string IsMaster5 = "IsMaster5";
			 public const string IsMaster6 = "IsMaster6";
			 public const string IsMaster7 = "IsMaster7";
			 public const string IsMaster8 = "IsMaster8";
			 public const string IsMaster9 = "IsMaster9";
			 public const string IsMaster10 = "IsMaster10";
			 public const string IsMaster11 = "IsMaster11";
			 public const string Casecount1 = "Casecount1";
			 public const string Casecount2 = "Casecount2";
			 public const string Casecount3 = "Casecount3";
			 public const string Casecount4 = "Casecount4";
			 public const string Casecount5 = "Casecount5";
			 public const string Casecount6 = "Casecount6";
			 public const string Casecount7 = "Casecount7";
			 public const string Casecount8 = "Casecount8";
			 public const string Casecount9 = "Casecount9";
			 public const string Casecount10 = "Casecount10";
			 public const string Casecount11 = "Casecount11";
			 public const string Description = "Description";
			 public const string Pcode1 = "Pcode1";
			 public const string Price1 = "Price1";
			 public const string Pcode2 = "Pcode2";
			 public const string Price2 = "Price2";
			 public const string Pcode3 = "Pcode3";
			 public const string Price3 = "Price3";
			 public const string Pcode4 = "Pcode4";
			 public const string Price4 = "Price4";
			 public const string Pcode5 = "Pcode5";
			 public const string Price5 = "Price5";
			 public const string Jprice1 = "Jprice1";
			 public const string Jprice2 = "Jprice2";
			 public const string Jprice3 = "Jprice3";
			 public const string Jprice4 = "Jprice4";
			 public const string Jprice5 = "Jprice5";
			 public const string Pcode6 = "Pcode6";
			 public const string Price6 = "Price6";
			 public const string Jprice6 = "Jprice6";
			 public const string Price7 = "Price7";
			 public const string Price8 = "Price8";
			 public const string Price9 = "Price9";
			 public const string Price10 = "Price10";
			 public const string Jprice7 = "Jprice7";
			 public const string Jprice8 = "Jprice8";
			 public const string Jprice9 = "Jprice9";
			 public const string Jprice10 = "Jprice10";
			 public const string Pcode7 = "Pcode7";
			 public const string Pcode8 = "Pcode8";
			 public const string Pcode9 = "Pcode9";
			 public const string Pcode10 = "Pcode10";
			 public const string Price11 = "Price11";
			 public const string Jprice11 = "Jprice11";
			 public const string Pcode11 = "Pcode11";
			 public const string BeefID = "BeefID";
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
			lock (typeof(VwBeefMetadata))
			{
				if(VwBeefMetadata.mapDelegates == null)
				{
					VwBeefMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (VwBeefMetadata.meta == null)
				{
					VwBeefMetadata.meta = new VwBeefMetadata();
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
				

				meta.AddTypeMap("OnCurrentOrder1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder4", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder5", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder6", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder7", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder8", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder9", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder10", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnCurrentOrder11", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Description1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description5", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description6", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description7", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description8", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description9", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description10", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description11", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid5", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid6", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid7", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid8", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid9", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid10", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid11", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid5", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid6", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid7", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid8", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid9", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid10", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid11", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsMaster1", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster2", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster3", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster4", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster5", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster6", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster7", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster8", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster9", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster10", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsMaster11", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Casecount1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount4", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount5", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount6", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount7", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount8", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount9", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount10", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Casecount11", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode5", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode6", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode7", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode8", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode9", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode10", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode11", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("BeefID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "vwBeef";
				meta.Destination = "vwBeef";
				
				meta.spInsert = "proc_vwBeefInsert";				
				meta.spUpdate = "proc_vwBeefUpdate";		
				meta.spDelete = "proc_vwBeefDelete";
				meta.spLoadAll = "proc_vwBeefLoadAll";
				meta.spLoadByPrimaryKey = "proc_vwBeefLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VwBeefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
