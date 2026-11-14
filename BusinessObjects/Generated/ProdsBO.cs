/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 4/17/2024 9:15:15 PM
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
	abstract public class esProdsCollection : esEntityCollection
	{
		public esProdsCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ProdsCollection";
		}

		#region Query Logic
		protected void InitQuery(esProdsQuery query)
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
			this.InitQuery(query as esProdsQuery);
		}
		#endregion
		
		virtual public ProdsBO DetachEntity(ProdsBO entity)
		{
			return base.DetachEntity(entity) as ProdsBO;
		}
		
		virtual public ProdsBO AttachEntity(ProdsBO entity)
		{
			return base.AttachEntity(entity) as ProdsBO;
		}
		
		virtual public void Combine(ProdsCollection collection)
		{
			base.Combine(collection);
		}
		
		new public ProdsBO this[int index]
		{
			get
			{
				return base[index] as ProdsBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(ProdsBO);
		}
	}



	[Serializable]
	abstract public class esProdsBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esProdsQuery GetDynamicQuery()
		{
			return null;
		}

		public esProdsBO()
		{

		}

		public esProdsBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String productcode)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productcode);
			else
				return LoadByPrimaryKeyStoredProcedure(productcode);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String productcode)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productcode);
			else
				return LoadByPrimaryKeyStoredProcedure(productcode);
		}

		private bool LoadByPrimaryKeyDynamic(System.String productcode)
		{
			esProdsQuery query = this.GetDynamicQuery();
			query.Where(query.Productcode == productcode);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String productcode)
		{
			esParameters parms = new esParameters();
			parms.Add("productcode",productcode);
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
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;							
						case "Brandcode": this.str.Brandcode = (string)value; break;							
						case "Catid": this.str.Catid = (string)value; break;							
						case "Scatid": this.str.Scatid = (string)value; break;							
						case "Weight": this.str.Weight = (string)value; break;							
						case "Lbpc": this.str.Lbpc = (string)value; break;							
						case "Lbcs": this.str.Lbcs = (string)value; break;							
						case "Casecount": this.str.Casecount = (string)value; break;							
						case "Jlbpc": this.str.Jlbpc = (string)value; break;							
						case "Jlbcs": this.str.Jlbcs = (string)value; break;							
						case "Onsale": this.str.Onsale = (string)value; break;							
						case "Onsalesheet": this.str.Onsalesheet = (string)value; break;							
						case "OnsaleNw": this.str.OnsaleNw = (string)value; break;							
						case "OnsalesheetNw": this.str.OnsalesheetNw = (string)value; break;							
						case "SaleLbcs": this.str.SaleLbcs = (string)value; break;							
						case "SaleJlbcs": this.str.SaleJlbcs = (string)value; break;							
						case "SalePos": this.str.SalePos = (string)value; break;							
						case "SaleCol": this.str.SaleCol = (string)value; break;							
						case "SaleLbcsNw": this.str.SaleLbcsNw = (string)value; break;							
						case "SaleJlbcsNw": this.str.SaleJlbcsNw = (string)value; break;							
						case "SalePosNw": this.str.SalePosNw = (string)value; break;							
						case "SaleColNw": this.str.SaleColNw = (string)value; break;							
						case "Luc": this.str.Luc = (string)value; break;							
						case "Qtyonhand": this.str.Qtyonhand = (string)value; break;							
						case "Negative": this.str.Negative = (string)value; break;							
						case "WeightType": this.str.WeightType = (string)value; break;							
						case "AvgCost": this.str.AvgCost = (string)value; break;							
						case "AdjCost": this.str.AdjCost = (string)value; break;							
						case "MasterCode": this.str.MasterCode = (string)value; break;							
						case "IsMaster": this.str.IsMaster = (string)value; break;							
						case "JobberOnsale": this.str.JobberOnsale = (string)value; break;							
						case "JobberOnsalesheet": this.str.JobberOnsalesheet = (string)value; break;							
						case "JobberOnsaleNw": this.str.JobberOnsaleNw = (string)value; break;							
						case "JobberOnsalesheetNw": this.str.JobberOnsalesheetNw = (string)value; break;							
						case "JobberSaleLbcs": this.str.JobberSaleLbcs = (string)value; break;							
						case "JobberSaleJlbcs": this.str.JobberSaleJlbcs = (string)value; break;							
						case "JobberSalePos": this.str.JobberSalePos = (string)value; break;							
						case "JobberSaleCol": this.str.JobberSaleCol = (string)value; break;							
						case "JobberSaleLbcsNw": this.str.JobberSaleLbcsNw = (string)value; break;							
						case "JobberSaleJlbcsNw": this.str.JobberSaleJlbcsNw = (string)value; break;							
						case "JobberSalePosNw": this.str.JobberSalePosNw = (string)value; break;							
						case "JobberSaleColNw": this.str.JobberSaleColNw = (string)value; break;							
						case "NextCost": this.str.NextCost = (string)value; break;							
						case "NextPODueDate": this.str.NextPODueDate = (string)value; break;							
						case "NextQtyDue": this.str.NextQtyDue = (string)value; break;							
						case "LastPOCost": this.str.LastPOCost = (string)value; break;							
						case "Keywords": this.str.Keywords = (string)value; break;							
						case "Taxable": this.str.Taxable = (string)value; break;							
						case "OnPriceList": this.str.OnPriceList = (string)value; break;							
						case "PresentInLastImport": this.str.PresentInLastImport = (string)value; break;							
						case "ProductCodeSub": this.str.ProductCodeSub = (string)value; break;							
						case "DoNotSell": this.str.DoNotSell = (string)value; break;							
						case "ArrowProd": this.str.ArrowProd = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Weight":
						
							if (value == null || value is System.Double)
								this.Weight = (System.Double?)value;
							break;
						
						case "Lbpc":
						
							if (value == null || value is System.Double)
								this.Lbpc = (System.Double?)value;
							break;
						
						case "Lbcs":
						
							if (value == null || value is System.Double)
								this.Lbcs = (System.Double?)value;
							break;
						
						case "Casecount":
						
							if (value == null || value is System.Int32)
								this.Casecount = (System.Int32?)value;
							break;
						
						case "Jlbpc":
						
							if (value == null || value is System.Double)
								this.Jlbpc = (System.Double?)value;
							break;
						
						case "Jlbcs":
						
							if (value == null || value is System.Double)
								this.Jlbcs = (System.Double?)value;
							break;
						
						case "Onsale":
						
							if (value == null || value is System.Boolean)
								this.Onsale = (System.Boolean?)value;
							break;
						
						case "Onsalesheet":
						
							if (value == null || value is System.Boolean)
								this.Onsalesheet = (System.Boolean?)value;
							break;
						
						case "OnsaleNw":
						
							if (value == null || value is System.Boolean)
								this.OnsaleNw = (System.Boolean?)value;
							break;
						
						case "OnsalesheetNw":
						
							if (value == null || value is System.Boolean)
								this.OnsalesheetNw = (System.Boolean?)value;
							break;
						
						case "SaleLbcs":
						
							if (value == null || value is System.Double)
								this.SaleLbcs = (System.Double?)value;
							break;
						
						case "SaleJlbcs":
						
							if (value == null || value is System.Double)
								this.SaleJlbcs = (System.Double?)value;
							break;
						
						case "SalePos":
						
							if (value == null || value is System.Int32)
								this.SalePos = (System.Int32?)value;
							break;
						
						case "SaleCol":
						
							if (value == null || value is System.Int32)
								this.SaleCol = (System.Int32?)value;
							break;
						
						case "SaleLbcsNw":
						
							if (value == null || value is System.Double)
								this.SaleLbcsNw = (System.Double?)value;
							break;
						
						case "SaleJlbcsNw":
						
							if (value == null || value is System.Double)
								this.SaleJlbcsNw = (System.Double?)value;
							break;
						
						case "SalePosNw":
						
							if (value == null || value is System.Int32)
								this.SalePosNw = (System.Int32?)value;
							break;
						
						case "SaleColNw":
						
							if (value == null || value is System.Int32)
								this.SaleColNw = (System.Int32?)value;
							break;
						
						case "Luc":
						
							if (value == null || value is System.Double)
								this.Luc = (System.Double?)value;
							break;
						
						case "Qtyonhand":
						
							if (value == null || value is System.Int32)
								this.Qtyonhand = (System.Int32?)value;
							break;
						
						case "AvgCost":
						
							if (value == null || value is System.Double)
								this.AvgCost = (System.Double?)value;
							break;
						
						case "AdjCost":
						
							if (value == null || value is System.Double)
								this.AdjCost = (System.Double?)value;
							break;
						
						case "IsMaster":
						
							if (value == null || value is System.Boolean)
								this.IsMaster = (System.Boolean?)value;
							break;
						
						case "JobberOnsale":
						
							if (value == null || value is System.Boolean)
								this.JobberOnsale = (System.Boolean?)value;
							break;
						
						case "JobberOnsalesheet":
						
							if (value == null || value is System.Boolean)
								this.JobberOnsalesheet = (System.Boolean?)value;
							break;
						
						case "JobberOnsaleNw":
						
							if (value == null || value is System.Boolean)
								this.JobberOnsaleNw = (System.Boolean?)value;
							break;
						
						case "JobberOnsalesheetNw":
						
							if (value == null || value is System.Boolean)
								this.JobberOnsalesheetNw = (System.Boolean?)value;
							break;
						
						case "JobberSaleLbcs":
						
							if (value == null || value is System.Double)
								this.JobberSaleLbcs = (System.Double?)value;
							break;
						
						case "JobberSaleJlbcs":
						
							if (value == null || value is System.Double)
								this.JobberSaleJlbcs = (System.Double?)value;
							break;
						
						case "JobberSalePos":
						
							if (value == null || value is System.Int32)
								this.JobberSalePos = (System.Int32?)value;
							break;
						
						case "JobberSaleCol":
						
							if (value == null || value is System.Int32)
								this.JobberSaleCol = (System.Int32?)value;
							break;
						
						case "JobberSaleLbcsNw":
						
							if (value == null || value is System.Double)
								this.JobberSaleLbcsNw = (System.Double?)value;
							break;
						
						case "JobberSaleJlbcsNw":
						
							if (value == null || value is System.Double)
								this.JobberSaleJlbcsNw = (System.Double?)value;
							break;
						
						case "JobberSalePosNw":
						
							if (value == null || value is System.Int32)
								this.JobberSalePosNw = (System.Int32?)value;
							break;
						
						case "JobberSaleColNw":
						
							if (value == null || value is System.Int32)
								this.JobberSaleColNw = (System.Int32?)value;
							break;
						
						case "NextCost":
						
							if (value == null || value is System.Double)
								this.NextCost = (System.Double?)value;
							break;
						
						case "NextPODueDate":
						
							if (value == null || value is System.DateTime)
								this.NextPODueDate = (System.DateTime?)value;
							break;
						
						case "NextQtyDue":
						
							if (value == null || value is System.Double)
								this.NextQtyDue = (System.Double?)value;
							break;
						
						case "LastPOCost":
						
							if (value == null || value is System.Double)
								this.LastPOCost = (System.Double?)value;
							break;
						
						case "OnPriceList":
						
							if (value == null || value is System.Boolean)
								this.OnPriceList = (System.Boolean?)value;
							break;
						
						case "PresentInLastImport":
						
							if (value == null || value is System.Boolean)
								this.PresentInLastImport = (System.Boolean?)value;
							break;
						
						case "DoNotSell":
						
							if (value == null || value is System.Boolean)
								this.DoNotSell = (System.Boolean?)value;
							break;
						
						case "ArrowProd":
						
							if (value == null || value is System.Boolean)
								this.ArrowProd = (System.Boolean?)value;
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
		/// Maps to prods.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.brandcode
		/// </summary>
		virtual public System.String Brandcode
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Brandcode);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Brandcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Brandcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.catid
		/// </summary>
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Catid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Catid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.scatid
		/// </summary>
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Scatid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.weight
		/// </summary>
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Weight, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Weight));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.lbpc
		/// </summary>
		virtual public System.Double? Lbpc
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Lbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Lbpc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Lbpc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.lbcs
		/// </summary>
		virtual public System.Double? Lbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Lbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Lbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Lbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.casecount
		/// </summary>
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.Casecount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Casecount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jlbpc
		/// </summary>
		virtual public System.Double? Jlbpc
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Jlbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Jlbpc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Jlbpc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jlbcs
		/// </summary>
		virtual public System.Double? Jlbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Jlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Jlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Jlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsale
		/// </summary>
		virtual public System.Boolean? Onsale
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.Onsale);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.Onsale, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Onsale));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsalesheet
		/// </summary>
		virtual public System.Boolean? Onsalesheet
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.Onsalesheet);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.Onsalesheet, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Onsalesheet));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsale_nw
		/// </summary>
		virtual public System.Boolean? OnsaleNw
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.OnsaleNw);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.OnsaleNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.OnsaleNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsalesheet_nw
		/// </summary>
		virtual public System.Boolean? OnsalesheetNw
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.OnsalesheetNw);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.OnsalesheetNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.OnsalesheetNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_lbcs
		/// </summary>
		virtual public System.Double? SaleLbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.SaleLbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.SaleLbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleLbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_jlbcs
		/// </summary>
		virtual public System.Double? SaleJlbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.SaleJlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.SaleJlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleJlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_pos
		/// </summary>
		virtual public System.Int32? SalePos
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.SalePos);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.SalePos, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SalePos));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_col
		/// </summary>
		virtual public System.Int32? SaleCol
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.SaleCol);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.SaleCol, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleCol));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_lbcs_nw
		/// </summary>
		virtual public System.Double? SaleLbcsNw
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.SaleLbcsNw);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.SaleLbcsNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleLbcsNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_jlbcs_nw
		/// </summary>
		virtual public System.Double? SaleJlbcsNw
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.SaleJlbcsNw);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.SaleJlbcsNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleJlbcsNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_pos_nw
		/// </summary>
		virtual public System.Int32? SalePosNw
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.SalePosNw);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.SalePosNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SalePosNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_col_nw
		/// </summary>
		virtual public System.Int32? SaleColNw
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.SaleColNw);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.SaleColNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.SaleColNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.luc
		/// </summary>
		virtual public System.Double? Luc
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.Luc);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.Luc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Luc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.qtyonhand
		/// </summary>
		virtual public System.Int32? Qtyonhand
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.Qtyonhand);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.Qtyonhand, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Qtyonhand));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.negative
		/// </summary>
		virtual public System.String Negative
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Negative);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Negative, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Negative));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.weight_type
		/// </summary>
		virtual public System.String WeightType
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.WeightType, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.WeightType));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.AvgCost
		/// </summary>
		virtual public System.Double? AvgCost
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.AvgCost);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.AvgCost, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.AvgCost));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.AdjCost
		/// </summary>
		virtual public System.Double? AdjCost
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.AdjCost);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.AdjCost, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.AdjCost));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.MasterCode
		/// </summary>
		virtual public System.String MasterCode
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.MasterCode);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.MasterCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.MasterCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.isMaster
		/// </summary>
		virtual public System.Boolean? IsMaster
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.IsMaster);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.IsMaster, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.IsMaster));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsale
		/// </summary>
		virtual public System.Boolean? JobberOnsale
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsale);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsale, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberOnsale));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsalesheet
		/// </summary>
		virtual public System.Boolean? JobberOnsalesheet
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsalesheet);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsalesheet, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberOnsalesheet));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsale_nw
		/// </summary>
		virtual public System.Boolean? JobberOnsaleNw
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsaleNw);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsaleNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberOnsaleNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsalesheet_nw
		/// </summary>
		virtual public System.Boolean? JobberOnsalesheetNw
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsalesheetNw);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.JobberOnsalesheetNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberOnsalesheetNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_lbcs
		/// </summary>
		virtual public System.Double? JobberSaleLbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleLbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleLbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleLbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_jlbcs
		/// </summary>
		virtual public System.Double? JobberSaleJlbcs
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleJlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleJlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleJlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_pos
		/// </summary>
		virtual public System.Int32? JobberSalePos
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.JobberSalePos);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.JobberSalePos, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSalePos));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_col
		/// </summary>
		virtual public System.Int32? JobberSaleCol
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.JobberSaleCol);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.JobberSaleCol, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleCol));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_lbcs_nw
		/// </summary>
		virtual public System.Double? JobberSaleLbcsNw
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleLbcsNw);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleLbcsNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleLbcsNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_jlbcs_nw
		/// </summary>
		virtual public System.Double? JobberSaleJlbcsNw
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleJlbcsNw);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.JobberSaleJlbcsNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleJlbcsNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_pos_nw
		/// </summary>
		virtual public System.Int32? JobberSalePosNw
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.JobberSalePosNw);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.JobberSalePosNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSalePosNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_col_nw
		/// </summary>
		virtual public System.Int32? JobberSaleColNw
		{
			get
			{
				return base.GetSystemInt32(ProdsMetadata.ColumnNames.JobberSaleColNw);
			}
			
			set
			{
				if(base.SetSystemInt32(ProdsMetadata.ColumnNames.JobberSaleColNw, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.JobberSaleColNw));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextCost
		/// </summary>
		virtual public System.Double? NextCost
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.NextCost);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.NextCost, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.NextCost));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextPODueDate
		/// </summary>
		virtual public System.DateTime? NextPODueDate
		{
			get
			{
				return base.GetSystemDateTime(ProdsMetadata.ColumnNames.NextPODueDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ProdsMetadata.ColumnNames.NextPODueDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.NextPODueDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextQtyDue
		/// </summary>
		virtual public System.Double? NextQtyDue
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.NextQtyDue);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.NextQtyDue, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.NextQtyDue));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.LastPOCost
		/// </summary>
		virtual public System.Double? LastPOCost
		{
			get
			{
				return base.GetSystemDouble(ProdsMetadata.ColumnNames.LastPOCost);
			}
			
			set
			{
				if(base.SetSystemDouble(ProdsMetadata.ColumnNames.LastPOCost, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.LastPOCost));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.keywords
		/// </summary>
		virtual public System.String Keywords
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Keywords);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Keywords, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Keywords));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.taxable
		/// </summary>
		virtual public System.String Taxable
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.Taxable, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.Taxable));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.OnPriceList
		/// </summary>
		virtual public System.Boolean? OnPriceList
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.OnPriceList);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.OnPriceList, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.OnPriceList));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.PresentInLastImport
		/// </summary>
		virtual public System.Boolean? PresentInLastImport
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.PresentInLastImport);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.PresentInLastImport, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.PresentInLastImport));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.ProductCodeSub
		/// </summary>
		virtual public System.String ProductCodeSub
		{
			get
			{
				return base.GetSystemString(ProdsMetadata.ColumnNames.ProductCodeSub);
			}
			
			set
			{
				if(base.SetSystemString(ProdsMetadata.ColumnNames.ProductCodeSub, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.ProductCodeSub));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.DoNotSell
		/// </summary>
		virtual public System.Boolean? DoNotSell
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.DoNotSell);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.DoNotSell, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.DoNotSell));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.ArrowProd
		/// </summary>
		virtual public System.Boolean? ArrowProd
		{
			get
			{
				return base.GetSystemBoolean(ProdsMetadata.ColumnNames.ArrowProd);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProdsMetadata.ColumnNames.ArrowProd, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProdsMetadata.PropertyNames.ArrowProd));
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
			public esStrings(esProdsBO entity)
			{
				this.entity = entity;
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
				
			public System.String Brandcode
			{
				get
				{
					System.String data = entity.Brandcode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Brandcode = null;
					else entity.Brandcode = Convert.ToString(value);
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
				
			public System.String Lbpc
			{
				get
				{
					System.Double? data = entity.Lbpc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lbpc = null;
					else entity.Lbpc = Convert.ToDouble(value);
				}
			}
				
			public System.String Lbcs
			{
				get
				{
					System.Double? data = entity.Lbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lbcs = null;
					else entity.Lbcs = Convert.ToDouble(value);
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
				
			public System.String Jlbpc
			{
				get
				{
					System.Double? data = entity.Jlbpc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jlbpc = null;
					else entity.Jlbpc = Convert.ToDouble(value);
				}
			}
				
			public System.String Jlbcs
			{
				get
				{
					System.Double? data = entity.Jlbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Jlbcs = null;
					else entity.Jlbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String Onsale
			{
				get
				{
					System.Boolean? data = entity.Onsale;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Onsale = null;
					else entity.Onsale = Convert.ToBoolean(value);
				}
			}
				
			public System.String Onsalesheet
			{
				get
				{
					System.Boolean? data = entity.Onsalesheet;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Onsalesheet = null;
					else entity.Onsalesheet = Convert.ToBoolean(value);
				}
			}
				
			public System.String OnsaleNw
			{
				get
				{
					System.Boolean? data = entity.OnsaleNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnsaleNw = null;
					else entity.OnsaleNw = Convert.ToBoolean(value);
				}
			}
				
			public System.String OnsalesheetNw
			{
				get
				{
					System.Boolean? data = entity.OnsalesheetNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnsalesheetNw = null;
					else entity.OnsalesheetNw = Convert.ToBoolean(value);
				}
			}
				
			public System.String SaleLbcs
			{
				get
				{
					System.Double? data = entity.SaleLbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleLbcs = null;
					else entity.SaleLbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String SaleJlbcs
			{
				get
				{
					System.Double? data = entity.SaleJlbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleJlbcs = null;
					else entity.SaleJlbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String SalePos
			{
				get
				{
					System.Int32? data = entity.SalePos;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalePos = null;
					else entity.SalePos = Convert.ToInt32(value);
				}
			}
				
			public System.String SaleCol
			{
				get
				{
					System.Int32? data = entity.SaleCol;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleCol = null;
					else entity.SaleCol = Convert.ToInt32(value);
				}
			}
				
			public System.String SaleLbcsNw
			{
				get
				{
					System.Double? data = entity.SaleLbcsNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleLbcsNw = null;
					else entity.SaleLbcsNw = Convert.ToDouble(value);
				}
			}
				
			public System.String SaleJlbcsNw
			{
				get
				{
					System.Double? data = entity.SaleJlbcsNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleJlbcsNw = null;
					else entity.SaleJlbcsNw = Convert.ToDouble(value);
				}
			}
				
			public System.String SalePosNw
			{
				get
				{
					System.Int32? data = entity.SalePosNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalePosNw = null;
					else entity.SalePosNw = Convert.ToInt32(value);
				}
			}
				
			public System.String SaleColNw
			{
				get
				{
					System.Int32? data = entity.SaleColNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SaleColNw = null;
					else entity.SaleColNw = Convert.ToInt32(value);
				}
			}
				
			public System.String Luc
			{
				get
				{
					System.Double? data = entity.Luc;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Luc = null;
					else entity.Luc = Convert.ToDouble(value);
				}
			}
				
			public System.String Qtyonhand
			{
				get
				{
					System.Int32? data = entity.Qtyonhand;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qtyonhand = null;
					else entity.Qtyonhand = Convert.ToInt32(value);
				}
			}
				
			public System.String Negative
			{
				get
				{
					System.String data = entity.Negative;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Negative = null;
					else entity.Negative = Convert.ToString(value);
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
				
			public System.String AvgCost
			{
				get
				{
					System.Double? data = entity.AvgCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AvgCost = null;
					else entity.AvgCost = Convert.ToDouble(value);
				}
			}
				
			public System.String AdjCost
			{
				get
				{
					System.Double? data = entity.AdjCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AdjCost = null;
					else entity.AdjCost = Convert.ToDouble(value);
				}
			}
				
			public System.String MasterCode
			{
				get
				{
					System.String data = entity.MasterCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MasterCode = null;
					else entity.MasterCode = Convert.ToString(value);
				}
			}
				
			public System.String IsMaster
			{
				get
				{
					System.Boolean? data = entity.IsMaster;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsMaster = null;
					else entity.IsMaster = Convert.ToBoolean(value);
				}
			}
				
			public System.String JobberOnsale
			{
				get
				{
					System.Boolean? data = entity.JobberOnsale;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberOnsale = null;
					else entity.JobberOnsale = Convert.ToBoolean(value);
				}
			}
				
			public System.String JobberOnsalesheet
			{
				get
				{
					System.Boolean? data = entity.JobberOnsalesheet;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberOnsalesheet = null;
					else entity.JobberOnsalesheet = Convert.ToBoolean(value);
				}
			}
				
			public System.String JobberOnsaleNw
			{
				get
				{
					System.Boolean? data = entity.JobberOnsaleNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberOnsaleNw = null;
					else entity.JobberOnsaleNw = Convert.ToBoolean(value);
				}
			}
				
			public System.String JobberOnsalesheetNw
			{
				get
				{
					System.Boolean? data = entity.JobberOnsalesheetNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberOnsalesheetNw = null;
					else entity.JobberOnsalesheetNw = Convert.ToBoolean(value);
				}
			}
				
			public System.String JobberSaleLbcs
			{
				get
				{
					System.Double? data = entity.JobberSaleLbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleLbcs = null;
					else entity.JobberSaleLbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String JobberSaleJlbcs
			{
				get
				{
					System.Double? data = entity.JobberSaleJlbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleJlbcs = null;
					else entity.JobberSaleJlbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String JobberSalePos
			{
				get
				{
					System.Int32? data = entity.JobberSalePos;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSalePos = null;
					else entity.JobberSalePos = Convert.ToInt32(value);
				}
			}
				
			public System.String JobberSaleCol
			{
				get
				{
					System.Int32? data = entity.JobberSaleCol;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleCol = null;
					else entity.JobberSaleCol = Convert.ToInt32(value);
				}
			}
				
			public System.String JobberSaleLbcsNw
			{
				get
				{
					System.Double? data = entity.JobberSaleLbcsNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleLbcsNw = null;
					else entity.JobberSaleLbcsNw = Convert.ToDouble(value);
				}
			}
				
			public System.String JobberSaleJlbcsNw
			{
				get
				{
					System.Double? data = entity.JobberSaleJlbcsNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleJlbcsNw = null;
					else entity.JobberSaleJlbcsNw = Convert.ToDouble(value);
				}
			}
				
			public System.String JobberSalePosNw
			{
				get
				{
					System.Int32? data = entity.JobberSalePosNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSalePosNw = null;
					else entity.JobberSalePosNw = Convert.ToInt32(value);
				}
			}
				
			public System.String JobberSaleColNw
			{
				get
				{
					System.Int32? data = entity.JobberSaleColNw;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobberSaleColNw = null;
					else entity.JobberSaleColNw = Convert.ToInt32(value);
				}
			}
				
			public System.String NextCost
			{
				get
				{
					System.Double? data = entity.NextCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NextCost = null;
					else entity.NextCost = Convert.ToDouble(value);
				}
			}
				
			public System.String NextPODueDate
			{
				get
				{
					System.DateTime? data = entity.NextPODueDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NextPODueDate = null;
					else entity.NextPODueDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String NextQtyDue
			{
				get
				{
					System.Double? data = entity.NextQtyDue;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.NextQtyDue = null;
					else entity.NextQtyDue = Convert.ToDouble(value);
				}
			}
				
			public System.String LastPOCost
			{
				get
				{
					System.Double? data = entity.LastPOCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastPOCost = null;
					else entity.LastPOCost = Convert.ToDouble(value);
				}
			}
				
			public System.String Keywords
			{
				get
				{
					System.String data = entity.Keywords;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Keywords = null;
					else entity.Keywords = Convert.ToString(value);
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
				
			public System.String OnPriceList
			{
				get
				{
					System.Boolean? data = entity.OnPriceList;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnPriceList = null;
					else entity.OnPriceList = Convert.ToBoolean(value);
				}
			}
				
			public System.String PresentInLastImport
			{
				get
				{
					System.Boolean? data = entity.PresentInLastImport;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PresentInLastImport = null;
					else entity.PresentInLastImport = Convert.ToBoolean(value);
				}
			}
				
			public System.String ProductCodeSub
			{
				get
				{
					System.String data = entity.ProductCodeSub;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductCodeSub = null;
					else entity.ProductCodeSub = Convert.ToString(value);
				}
			}
				
			public System.String DoNotSell
			{
				get
				{
					System.Boolean? data = entity.DoNotSell;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DoNotSell = null;
					else entity.DoNotSell = Convert.ToBoolean(value);
				}
			}
				
			public System.String ArrowProd
			{
				get
				{
					System.Boolean? data = entity.ArrowProd;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ArrowProd = null;
					else entity.ArrowProd = Convert.ToBoolean(value);
				}
			}
			

			private esProdsBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esProdsQuery query)
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
				throw new Exception("esProdsBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esProdsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdsMetadata.Meta();
			}
		}	
		

		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Brandcode
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Brandcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Catid, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem Weight
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Weight, esSystemType.Double);
			}
		} 
		
		public esQueryItem Lbpc
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Lbpc, esSystemType.Double);
			}
		} 
		
		public esQueryItem Lbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Lbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Casecount
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Casecount, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Jlbpc
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Jlbpc, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jlbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Jlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Onsale
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Onsale, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Onsalesheet
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Onsalesheet, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem OnsaleNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.OnsaleNw, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem OnsalesheetNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.OnsalesheetNw, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem SaleLbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleLbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem SaleJlbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleJlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem SalePos
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SalePos, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SaleCol
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleCol, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SaleLbcsNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleLbcsNw, esSystemType.Double);
			}
		} 
		
		public esQueryItem SaleJlbcsNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleJlbcsNw, esSystemType.Double);
			}
		} 
		
		public esQueryItem SalePosNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SalePosNw, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SaleColNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleColNw, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Luc
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Luc, esSystemType.Double);
			}
		} 
		
		public esQueryItem Qtyonhand
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Qtyonhand, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Negative
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Negative, esSystemType.String);
			}
		} 
		
		public esQueryItem WeightType
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.WeightType, esSystemType.String);
			}
		} 
		
		public esQueryItem AvgCost
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.AvgCost, esSystemType.Double);
			}
		} 
		
		public esQueryItem AdjCost
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.AdjCost, esSystemType.Double);
			}
		} 
		
		public esQueryItem MasterCode
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.MasterCode, esSystemType.String);
			}
		} 
		
		public esQueryItem IsMaster
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.IsMaster, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem JobberOnsale
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsale, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem JobberOnsalesheet
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsalesheet, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem JobberOnsaleNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsaleNw, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem JobberOnsalesheetNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsalesheetNw, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem JobberSaleLbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleLbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem JobberSaleJlbcs
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleJlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem JobberSalePos
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSalePos, esSystemType.Int32);
			}
		} 
		
		public esQueryItem JobberSaleCol
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleCol, esSystemType.Int32);
			}
		} 
		
		public esQueryItem JobberSaleLbcsNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleLbcsNw, esSystemType.Double);
			}
		} 
		
		public esQueryItem JobberSaleJlbcsNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleJlbcsNw, esSystemType.Double);
			}
		} 
		
		public esQueryItem JobberSalePosNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSalePosNw, esSystemType.Int32);
			}
		} 
		
		public esQueryItem JobberSaleColNw
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleColNw, esSystemType.Int32);
			}
		} 
		
		public esQueryItem NextCost
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.NextCost, esSystemType.Double);
			}
		} 
		
		public esQueryItem NextPODueDate
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.NextPODueDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem NextQtyDue
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.NextQtyDue, esSystemType.Double);
			}
		} 
		
		public esQueryItem LastPOCost
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.LastPOCost, esSystemType.Double);
			}
		} 
		
		public esQueryItem Keywords
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Keywords, esSystemType.String);
			}
		} 
		
		public esQueryItem Taxable
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.Taxable, esSystemType.String);
			}
		} 
		
		public esQueryItem OnPriceList
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.OnPriceList, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem PresentInLastImport
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.PresentInLastImport, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem ProductCodeSub
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.ProductCodeSub, esSystemType.String);
			}
		} 
		
		public esQueryItem DoNotSell
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.DoNotSell, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem ArrowProd
		{
			get
			{
				return new esQueryItem(this, ProdsMetadata.ColumnNames.ArrowProd, esSystemType.Boolean);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ProdsCollection")]
	public partial class ProdsCollection : esProdsCollection, IEnumerable<ProdsBO>
	{
		public ProdsCollection()
		{

		}
		
		public static implicit operator List<ProdsBO>(ProdsCollection coll)
		{
			List<ProdsBO> list = new List<ProdsBO>();
			
			foreach (ProdsBO emp in coll)
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
				return  ProdsMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new ProdsBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new ProdsBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ProdsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public ProdsBO AddNew()
		{
			ProdsBO entity = base.AddNewEntity() as ProdsBO;
			
			return entity;
		}

		public ProdsBO FindByPrimaryKey(System.String productcode)
		{
			return base.FindByPrimaryKey(productcode) as ProdsBO;
		}


		#region IEnumerable<ProdsBO> Members

		IEnumerator<ProdsBO> IEnumerable<ProdsBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as ProdsBO;
			}
		}

		#endregion
		
		private ProdsQuery query;
	}


	/// <summary>
	/// Encapsulates the 'prods' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("ProdsBO ({Productcode})")]
	[Serializable]
	public partial class ProdsBO : esProdsBO
	{
		public ProdsBO()
		{

		}
	
		public ProdsBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdsMetadata.Meta();
			}
		}
		
		
		
		override protected esProdsQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProdsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ProdsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ProdsQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class ProdsQuery : esProdsQuery
	{
		public ProdsQuery()
		{

		}		
		
		public ProdsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "ProdsQuery";
        }
		
			
	}


	[Serializable]
	public partial class ProdsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdsMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Productcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Productcode;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 6;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Brandcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Brandcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Catid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Scatid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Weight, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Lbpc, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Lbcs, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Casecount, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Jlbpc, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Jlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Jlbcs, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Jlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Onsale, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.Onsale;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Onsalesheet, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.Onsalesheet;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnsaleNw, 13, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnsaleNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnsalesheetNw, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnsalesheetNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleLbcs, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleLbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleJlbcs, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleJlbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SalePos, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SalePos;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleCol, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleLbcsNw, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleLbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleJlbcsNw, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleJlbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SalePosNw, 21, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SalePosNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleColNw, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleColNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Luc, 23, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Luc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Qtyonhand, 24, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.Qtyonhand;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Negative, 25, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Negative;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.WeightType, 26, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.AvgCost, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.AvgCost;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.AdjCost, 28, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.AdjCost;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.MasterCode, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.MasterCode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.IsMaster, 30, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.IsMaster;
			c.HasDefault = true;
			c.Default = @"(0)";
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsale, 31, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsale;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsalesheet, 32, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsalesheet;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsaleNw, 33, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsaleNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsalesheetNw, 34, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsalesheetNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleLbcs, 35, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleLbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleJlbcs, 36, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleJlbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSalePos, 37, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSalePos;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleCol, 38, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleLbcsNw, 39, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleLbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleJlbcsNw, 40, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleJlbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSalePosNw, 41, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSalePosNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleColNw, 42, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleColNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextCost, 43, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.NextCost;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextPODueDate, 44, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdsMetadata.PropertyNames.NextPODueDate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextQtyDue, 45, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.NextQtyDue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.LastPOCost, 46, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.LastPOCost;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Keywords, 47, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Keywords;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Taxable, 48, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Taxable;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('N')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnPriceList, 49, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnPriceList;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.PresentInLastImport, 50, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.PresentInLastImport;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.ProductCodeSub, 51, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.ProductCodeSub;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.DoNotSell, 52, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.DoNotSell;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.ArrowProd, 53, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.ArrowProd;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdsMetadata Meta()
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
			 public const string Productcode = "productcode";
			 public const string Description = "description";
			 public const string Brandcode = "brandcode";
			 public const string Catid = "catid";
			 public const string Scatid = "scatid";
			 public const string Weight = "weight";
			 public const string Lbpc = "lbpc";
			 public const string Lbcs = "lbcs";
			 public const string Casecount = "casecount";
			 public const string Jlbpc = "jlbpc";
			 public const string Jlbcs = "jlbcs";
			 public const string Onsale = "onsale";
			 public const string Onsalesheet = "onsalesheet";
			 public const string OnsaleNw = "onsale_nw";
			 public const string OnsalesheetNw = "onsalesheet_nw";
			 public const string SaleLbcs = "sale_lbcs";
			 public const string SaleJlbcs = "sale_jlbcs";
			 public const string SalePos = "sale_pos";
			 public const string SaleCol = "sale_col";
			 public const string SaleLbcsNw = "sale_lbcs_nw";
			 public const string SaleJlbcsNw = "sale_jlbcs_nw";
			 public const string SalePosNw = "sale_pos_nw";
			 public const string SaleColNw = "sale_col_nw";
			 public const string Luc = "luc";
			 public const string Qtyonhand = "qtyonhand";
			 public const string Negative = "negative";
			 public const string WeightType = "weight_type";
			 public const string AvgCost = "AvgCost";
			 public const string AdjCost = "AdjCost";
			 public const string MasterCode = "MasterCode";
			 public const string IsMaster = "isMaster";
			 public const string JobberOnsale = "jobber_onsale";
			 public const string JobberOnsalesheet = "jobber_onsalesheet";
			 public const string JobberOnsaleNw = "jobber_onsale_nw";
			 public const string JobberOnsalesheetNw = "jobber_onsalesheet_nw";
			 public const string JobberSaleLbcs = "jobber_sale_lbcs";
			 public const string JobberSaleJlbcs = "jobber_sale_jlbcs";
			 public const string JobberSalePos = "jobber_sale_pos";
			 public const string JobberSaleCol = "jobber_sale_col";
			 public const string JobberSaleLbcsNw = "jobber_sale_lbcs_nw";
			 public const string JobberSaleJlbcsNw = "jobber_sale_jlbcs_nw";
			 public const string JobberSalePosNw = "jobber_sale_pos_nw";
			 public const string JobberSaleColNw = "jobber_sale_col_nw";
			 public const string NextCost = "NextCost";
			 public const string NextPODueDate = "NextPODueDate";
			 public const string NextQtyDue = "NextQtyDue";
			 public const string LastPOCost = "LastPOCost";
			 public const string Keywords = "keywords";
			 public const string Taxable = "taxable";
			 public const string OnPriceList = "OnPriceList";
			 public const string PresentInLastImport = "PresentInLastImport";
			 public const string ProductCodeSub = "ProductCodeSub";
			 public const string DoNotSell = "DoNotSell";
			 public const string ArrowProd = "ArrowProd";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Productcode = "Productcode";
			 public const string Description = "Description";
			 public const string Brandcode = "Brandcode";
			 public const string Catid = "Catid";
			 public const string Scatid = "Scatid";
			 public const string Weight = "Weight";
			 public const string Lbpc = "Lbpc";
			 public const string Lbcs = "Lbcs";
			 public const string Casecount = "Casecount";
			 public const string Jlbpc = "Jlbpc";
			 public const string Jlbcs = "Jlbcs";
			 public const string Onsale = "Onsale";
			 public const string Onsalesheet = "Onsalesheet";
			 public const string OnsaleNw = "OnsaleNw";
			 public const string OnsalesheetNw = "OnsalesheetNw";
			 public const string SaleLbcs = "SaleLbcs";
			 public const string SaleJlbcs = "SaleJlbcs";
			 public const string SalePos = "SalePos";
			 public const string SaleCol = "SaleCol";
			 public const string SaleLbcsNw = "SaleLbcsNw";
			 public const string SaleJlbcsNw = "SaleJlbcsNw";
			 public const string SalePosNw = "SalePosNw";
			 public const string SaleColNw = "SaleColNw";
			 public const string Luc = "Luc";
			 public const string Qtyonhand = "Qtyonhand";
			 public const string Negative = "Negative";
			 public const string WeightType = "WeightType";
			 public const string AvgCost = "AvgCost";
			 public const string AdjCost = "AdjCost";
			 public const string MasterCode = "MasterCode";
			 public const string IsMaster = "IsMaster";
			 public const string JobberOnsale = "JobberOnsale";
			 public const string JobberOnsalesheet = "JobberOnsalesheet";
			 public const string JobberOnsaleNw = "JobberOnsaleNw";
			 public const string JobberOnsalesheetNw = "JobberOnsalesheetNw";
			 public const string JobberSaleLbcs = "JobberSaleLbcs";
			 public const string JobberSaleJlbcs = "JobberSaleJlbcs";
			 public const string JobberSalePos = "JobberSalePos";
			 public const string JobberSaleCol = "JobberSaleCol";
			 public const string JobberSaleLbcsNw = "JobberSaleLbcsNw";
			 public const string JobberSaleJlbcsNw = "JobberSaleJlbcsNw";
			 public const string JobberSalePosNw = "JobberSalePosNw";
			 public const string JobberSaleColNw = "JobberSaleColNw";
			 public const string NextCost = "NextCost";
			 public const string NextPODueDate = "NextPODueDate";
			 public const string NextQtyDue = "NextQtyDue";
			 public const string LastPOCost = "LastPOCost";
			 public const string Keywords = "Keywords";
			 public const string Taxable = "Taxable";
			 public const string OnPriceList = "OnPriceList";
			 public const string PresentInLastImport = "PresentInLastImport";
			 public const string ProductCodeSub = "ProductCodeSub";
			 public const string DoNotSell = "DoNotSell";
			 public const string ArrowProd = "ArrowProd";
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
			lock (typeof(ProdsMetadata))
			{
				if(ProdsMetadata.mapDelegates == null)
				{
					ProdsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProdsMetadata.meta == null)
				{
					ProdsMetadata.meta = new ProdsMetadata();
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
				

				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Brandcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Jlbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Onsale", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Onsalesheet", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("OnsaleNw", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("OnsalesheetNw", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("SaleLbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SaleJlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SalePos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SaleCol", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SaleLbcsNw", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SaleJlbcsNw", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SalePosNw", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SaleColNw", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Luc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Qtyonhand", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Negative", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("WeightType", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("AvgCost", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("AdjCost", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("MasterCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsMaster", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("JobberOnsale", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("JobberOnsalesheet", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("JobberOnsaleNw", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("JobberOnsalesheetNw", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("JobberSaleLbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("JobberSaleJlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("JobberSalePos", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("JobberSaleCol", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("JobberSaleLbcsNw", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("JobberSaleJlbcsNw", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("JobberSalePosNw", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("JobberSaleColNw", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("NextCost", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("NextPODueDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("NextQtyDue", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("LastPOCost", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Keywords", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Taxable", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OnPriceList", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("PresentInLastImport", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ProductCodeSub", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("DoNotSell", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ArrowProd", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "prods";
				meta.Destination = "prods";
				
				meta.spInsert = "proc_prodsInsert";				
				meta.spUpdate = "proc_prodsUpdate";		
				meta.spDelete = "proc_prodsDelete";
				meta.spLoadAll = "proc_prodsLoadAll";
				meta.spLoadByPrimaryKey = "proc_prodsLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
