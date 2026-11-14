
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:15 PM
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
	/// Encapsulates the 'prods' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(ProdsBO))]	
	[XmlType("ProdsBO")]
	public partial class ProdsBO : esProdsBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ProdsBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String productcode)
		{
			var obj = new ProdsBO();
			obj.Productcode = productcode;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String productcode, esSqlAccessType sqlAccessType)
		{
			var obj = new ProdsBO();
			obj.Productcode = productcode;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProdsCollection")]
	public partial class ProdsCollection : esProdsCollection, IEnumerable<ProdsBO>
	{
		public ProdsBO FindByPrimaryKey(System.String productcode)
		{
			return this.SingleOrDefault(e => e.Productcode == productcode);
		}

		
				
	}



	[Serializable]	
	public partial class ProdsQuery : esProdsQuery
	{
		public ProdsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProdsQuery(string joinAlias, out ProdsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProdsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProdsQuery query)
		{
			return ProdsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProdsQuery(string query)
		{
			return (ProdsQuery)ProdsQuery.SerializeHelper.FromXml(query, typeof(ProdsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProdsBO : esEntity
	{
		public esProdsBO()
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
			ProdsQuery query = new ProdsQuery();
			query.Where(query.Productcode == productcode);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String productcode)
		{
			esParameters parms = new esParameters();
			parms.Add("Productcode", productcode);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to prods.productcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Productcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.brandcode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Brandcode);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.catid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._CatBO = null;
					this.OnPropertyChanged("CatBO");
					OnPropertyChanged(ProdsMetadata.PropertyNames.Catid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.scatid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					this._CatsubBO = null;
					this.OnPropertyChanged("CatsubBO");
					OnPropertyChanged(ProdsMetadata.PropertyNames.Scatid);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.weight
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Weight);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.lbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Lbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.lbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Lbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.casecount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Casecount);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jlbpc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Jlbpc);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Jlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsale
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Onsale);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsalesheet
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Onsalesheet);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsale_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.OnsaleNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.onsalesheet_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.OnsalesheetNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_lbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleLbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_jlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleJlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_pos
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SalePos);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_col
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleCol);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_lbcs_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleLbcsNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_jlbcs_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleJlbcsNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_pos_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SalePosNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.sale_col_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.SaleColNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.luc
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Luc);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.qtyonhand
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Qtyonhand);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.negative
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Negative
		{
			get
			{
				return base.GetSystemChar(ProdsMetadata.ColumnNames.Negative);
			}
			
			set
			{
				if(base.SetSystemChar(ProdsMetadata.ColumnNames.Negative, value))
				{
					OnPropertyChanged(ProdsMetadata.PropertyNames.Negative);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.weight_type
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? WeightType
		{
			get
			{
				return base.GetSystemChar(ProdsMetadata.ColumnNames.WeightType);
			}
			
			set
			{
				if(base.SetSystemChar(ProdsMetadata.ColumnNames.WeightType, value))
				{
					OnPropertyChanged(ProdsMetadata.PropertyNames.WeightType);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.AvgCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.AvgCost);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.AdjCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.AdjCost);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.MasterCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.MasterCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.isMaster
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.IsMaster);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsale
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberOnsale);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsalesheet
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberOnsalesheet);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsale_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberOnsaleNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_onsalesheet_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberOnsalesheetNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_lbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleLbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_jlbcs
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleJlbcs);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_pos
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSalePos);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_col
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleCol);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_lbcs_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleLbcsNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_jlbcs_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleJlbcsNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_pos_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSalePosNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.jobber_sale_col_nw
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.JobberSaleColNw);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.NextCost);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextPODueDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.NextPODueDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.NextQtyDue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.NextQtyDue);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.LastPOCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.LastPOCost);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.keywords
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.Keywords);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.taxable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Char? Taxable
		{
			get
			{
				return base.GetSystemChar(ProdsMetadata.ColumnNames.Taxable);
			}
			
			set
			{
				if(base.SetSystemChar(ProdsMetadata.ColumnNames.Taxable, value))
				{
					OnPropertyChanged(ProdsMetadata.PropertyNames.Taxable);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.OnPriceList
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.OnPriceList);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.PresentInLastImport
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.PresentInLastImport);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.ProductCodeSub
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.ProductCodeSub);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.DoNotSell
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.DoNotSell);
				}
			}
		}
		
		/// <summary>
		/// Maps to prods.ArrowProd
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
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
					OnPropertyChanged(ProdsMetadata.PropertyNames.ArrowProd);
				}
			}
		}
		
		internal protected CatBO _CatBO;
		internal protected CatsubBO _CatsubBO;
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProdsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(ProdsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdsQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private ProdsQuery query;		
	}



	[Serializable]
	abstract public partial class esProdsCollection : esEntityCollection<ProdsBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProdsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProdsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProdsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProdsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
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

		protected void InitQuery(ProdsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProdsQuery)query);
		}

		#endregion
		
		private ProdsQuery query;
	}



	[Serializable]
	abstract public partial class esProdsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProdsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Productcode": return this.Productcode;
				case "Description": return this.Description;
				case "Brandcode": return this.Brandcode;
				case "Catid": return this.Catid;
				case "Scatid": return this.Scatid;
				case "Weight": return this.Weight;
				case "Lbpc": return this.Lbpc;
				case "Lbcs": return this.Lbcs;
				case "Casecount": return this.Casecount;
				case "Jlbpc": return this.Jlbpc;
				case "Jlbcs": return this.Jlbcs;
				case "Onsale": return this.Onsale;
				case "Onsalesheet": return this.Onsalesheet;
				case "OnsaleNw": return this.OnsaleNw;
				case "OnsalesheetNw": return this.OnsalesheetNw;
				case "SaleLbcs": return this.SaleLbcs;
				case "SaleJlbcs": return this.SaleJlbcs;
				case "SalePos": return this.SalePos;
				case "SaleCol": return this.SaleCol;
				case "SaleLbcsNw": return this.SaleLbcsNw;
				case "SaleJlbcsNw": return this.SaleJlbcsNw;
				case "SalePosNw": return this.SalePosNw;
				case "SaleColNw": return this.SaleColNw;
				case "Luc": return this.Luc;
				case "Qtyonhand": return this.Qtyonhand;
				case "Negative": return this.Negative;
				case "WeightType": return this.WeightType;
				case "AvgCost": return this.AvgCost;
				case "AdjCost": return this.AdjCost;
				case "MasterCode": return this.MasterCode;
				case "IsMaster": return this.IsMaster;
				case "JobberOnsale": return this.JobberOnsale;
				case "JobberOnsalesheet": return this.JobberOnsalesheet;
				case "JobberOnsaleNw": return this.JobberOnsaleNw;
				case "JobberOnsalesheetNw": return this.JobberOnsalesheetNw;
				case "JobberSaleLbcs": return this.JobberSaleLbcs;
				case "JobberSaleJlbcs": return this.JobberSaleJlbcs;
				case "JobberSalePos": return this.JobberSalePos;
				case "JobberSaleCol": return this.JobberSaleCol;
				case "JobberSaleLbcsNw": return this.JobberSaleLbcsNw;
				case "JobberSaleJlbcsNw": return this.JobberSaleJlbcsNw;
				case "JobberSalePosNw": return this.JobberSalePosNw;
				case "JobberSaleColNw": return this.JobberSaleColNw;
				case "NextCost": return this.NextCost;
				case "NextPODueDate": return this.NextPODueDate;
				case "NextQtyDue": return this.NextQtyDue;
				case "LastPOCost": return this.LastPOCost;
				case "Keywords": return this.Keywords;
				case "Taxable": return this.Taxable;
				case "OnPriceList": return this.OnPriceList;
				case "PresentInLastImport": return this.PresentInLastImport;
				case "ProductCodeSub": return this.ProductCodeSub;
				case "DoNotSell": return this.DoNotSell;
				case "ArrowProd": return this.ArrowProd;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Productcode
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Productcode, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Brandcode
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Brandcode, esSystemType.String); }
		} 
		
		public esQueryItem Catid
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Catid, esSystemType.String); }
		} 
		
		public esQueryItem Scatid
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Scatid, esSystemType.String); }
		} 
		
		public esQueryItem Weight
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Weight, esSystemType.Double); }
		} 
		
		public esQueryItem Lbpc
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Lbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Lbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Lbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Casecount
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Casecount, esSystemType.Int32); }
		} 
		
		public esQueryItem Jlbpc
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Jlbpc, esSystemType.Double); }
		} 
		
		public esQueryItem Jlbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Jlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem Onsale
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Onsale, esSystemType.Boolean); }
		} 
		
		public esQueryItem Onsalesheet
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Onsalesheet, esSystemType.Boolean); }
		} 
		
		public esQueryItem OnsaleNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.OnsaleNw, esSystemType.Boolean); }
		} 
		
		public esQueryItem OnsalesheetNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.OnsalesheetNw, esSystemType.Boolean); }
		} 
		
		public esQueryItem SaleLbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleLbcs, esSystemType.Double); }
		} 
		
		public esQueryItem SaleJlbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleJlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem SalePos
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SalePos, esSystemType.Int32); }
		} 
		
		public esQueryItem SaleCol
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleCol, esSystemType.Int32); }
		} 
		
		public esQueryItem SaleLbcsNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleLbcsNw, esSystemType.Double); }
		} 
		
		public esQueryItem SaleJlbcsNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleJlbcsNw, esSystemType.Double); }
		} 
		
		public esQueryItem SalePosNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SalePosNw, esSystemType.Int32); }
		} 
		
		public esQueryItem SaleColNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.SaleColNw, esSystemType.Int32); }
		} 
		
		public esQueryItem Luc
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Luc, esSystemType.Double); }
		} 
		
		public esQueryItem Qtyonhand
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Qtyonhand, esSystemType.Int32); }
		} 
		
		public esQueryItem Negative
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Negative, esSystemType.Char); }
		} 
		
		public esQueryItem WeightType
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.WeightType, esSystemType.Char); }
		} 
		
		public esQueryItem AvgCost
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.AvgCost, esSystemType.Double); }
		} 
		
		public esQueryItem AdjCost
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.AdjCost, esSystemType.Double); }
		} 
		
		public esQueryItem MasterCode
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.MasterCode, esSystemType.String); }
		} 
		
		public esQueryItem IsMaster
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.IsMaster, esSystemType.Boolean); }
		} 
		
		public esQueryItem JobberOnsale
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsale, esSystemType.Boolean); }
		} 
		
		public esQueryItem JobberOnsalesheet
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsalesheet, esSystemType.Boolean); }
		} 
		
		public esQueryItem JobberOnsaleNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsaleNw, esSystemType.Boolean); }
		} 
		
		public esQueryItem JobberOnsalesheetNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberOnsalesheetNw, esSystemType.Boolean); }
		} 
		
		public esQueryItem JobberSaleLbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleLbcs, esSystemType.Double); }
		} 
		
		public esQueryItem JobberSaleJlbcs
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleJlbcs, esSystemType.Double); }
		} 
		
		public esQueryItem JobberSalePos
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSalePos, esSystemType.Int32); }
		} 
		
		public esQueryItem JobberSaleCol
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleCol, esSystemType.Int32); }
		} 
		
		public esQueryItem JobberSaleLbcsNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleLbcsNw, esSystemType.Double); }
		} 
		
		public esQueryItem JobberSaleJlbcsNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleJlbcsNw, esSystemType.Double); }
		} 
		
		public esQueryItem JobberSalePosNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSalePosNw, esSystemType.Int32); }
		} 
		
		public esQueryItem JobberSaleColNw
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.JobberSaleColNw, esSystemType.Int32); }
		} 
		
		public esQueryItem NextCost
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.NextCost, esSystemType.Double); }
		} 
		
		public esQueryItem NextPODueDate
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.NextPODueDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem NextQtyDue
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.NextQtyDue, esSystemType.Double); }
		} 
		
		public esQueryItem LastPOCost
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.LastPOCost, esSystemType.Double); }
		} 
		
		public esQueryItem Keywords
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Keywords, esSystemType.String); }
		} 
		
		public esQueryItem Taxable
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.Taxable, esSystemType.Char); }
		} 
		
		public esQueryItem OnPriceList
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.OnPriceList, esSystemType.Boolean); }
		} 
		
		public esQueryItem PresentInLastImport
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.PresentInLastImport, esSystemType.Boolean); }
		} 
		
		public esQueryItem ProductCodeSub
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.ProductCodeSub, esSystemType.String); }
		} 
		
		public esQueryItem DoNotSell
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.DoNotSell, esSystemType.Boolean); }
		} 
		
		public esQueryItem ArrowProd
		{
			get { return new esQueryItem(this, ProdsMetadata.ColumnNames.ArrowProd, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class ProdsBO : esProdsBO
	{

		#region GroupaBOCollection - Zero To Many (FK_groupa_productcode)
		
		static public esPrefetchMap Prefetch_GroupaBOCollection
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap
				{
					PrefetchDelegate = BusinessObjects.ProdsBO.GroupaBOCollection_Delegate,
					PropertyName = "GroupaBOCollection",
					MyColumnName = "productcode",
					ParentColumnName = "productcode",
					IsMultiPartKey = false
				};
				return map;
			}
		}		
		
		static private void GroupaBOCollection_Delegate(esPrefetchParameters data)
		{
			ProdsQuery parent = new ProdsQuery(data.NextAlias());

			GroupaQuery me = data.You != null ? data.You as GroupaQuery : new GroupaQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Productcode == me.Productcode);

			data.You = parent;
		}	
	
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_groupa_productcode
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeGroupaBOCollection()
		{
		    if(this._GroupaBOCollection != null && this._GroupaBOCollection.Count > 0)
				return true;
            else
				return false;
		}	
		

		[DataMember(Name="GroupaBOCollection", EmitDefaultValue = false)]
		public GroupaCollection GroupaBOCollection
		{
			get
			{
				if(this._GroupaBOCollection == null)
				{
					this._GroupaBOCollection = new GroupaCollection();
					this._GroupaBOCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("GroupaBOCollection", this._GroupaBOCollection);
				
					if (this.Productcode != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._GroupaBOCollection.Query.Where(this._GroupaBOCollection.Query.Productcode == this.Productcode);
							this._GroupaBOCollection.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._GroupaBOCollection.fks.Add(GroupaMetadata.ColumnNames.Productcode, this.Productcode);
					}
				}

				return this._GroupaBOCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._GroupaBOCollection != null) 
				{ 
					this.RemovePostSave("GroupaBOCollection"); 
					this._GroupaBOCollection = null;
					
				} 
			} 			
		}
		

		
			
		
		private GroupaCollection _GroupaBOCollection;
		#endregion

		
		#region CatBO - Many To One (FK_prods_catid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeCatBO()
		{
		    return this._CatBO != null ? true : false;
		}
		

		[DataMember(Name="CatBO", EmitDefaultValue = false)]
					
		public CatBO CatBO
		{
			get
			{
                if (this._CatBO == null)
                {
                    this._CatBO = new CatBO();
                    this._CatBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("CatBO", this._CatBO);

					if(this._CatBO == null && Catid != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._CatBO.Query.Where(this._CatBO.Query.Catid == this.Catid);
							this._CatBO.Query.Load();
                        }
                    }
                }

				return this._CatBO;
			}
			
			set
			{
				this.RemovePreSave("CatBO");
				

				if(value == null)
				{
					this.Catid = null;
					this._CatBO = null;
				}
				else
				{
					this.Catid = value.Catid;
					this._CatBO = value;
					this.SetPreSave("CatBO", this._CatBO);
				}
				
			}
		}
		#endregion
		

		
		#region CatsubBO - Many To One (FK_prods_scatid)
		
	    [EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeCatsubBO()
		{
		    return this._CatsubBO != null ? true : false;
		}
		

		[DataMember(Name="CatsubBO", EmitDefaultValue = false)]
					
		public CatsubBO CatsubBO
		{
			get
			{
                if (this._CatsubBO == null)
                {
                    this._CatsubBO = new CatsubBO();
                    this._CatsubBO.es.Connection.Name = this.es.Connection.Name;
                    this.SetPreSave("CatsubBO", this._CatsubBO);

					if(this._CatsubBO == null && Scatid != null)
                    {
                        if (!this.es.IsLazyLoadDisabled)
                        {
							this._CatsubBO.Query.Where(this._CatsubBO.Query.Scatid == this.Scatid);
							this._CatsubBO.Query.Load();
                        }
                    }
                }

				return this._CatsubBO;
			}
			
			set
			{
				this.RemovePreSave("CatsubBO");
				

				if(value == null)
				{
					this.Scatid = null;
					this._CatsubBO = null;
				}
				else
				{
					this.Scatid = value.Scatid;
					this._CatsubBO = value;
					this.SetPreSave("CatsubBO", this._CatsubBO);
				}
				
			}
		}
		#endregion
		

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "GroupaBOCollection":
					coll = this.GroupaBOCollection;
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
			
			props.Add(new esPropertyDescriptor(this, "GroupaBOCollection", typeof(GroupaCollection), new GroupaBO()));
		
			return props;
		}
		
	}
	



	[Serializable]
	public partial class ProdsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProdsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Productcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Productcode;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 6;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Brandcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Brandcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Catid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Scatid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Weight, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Lbpc, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Lbcs, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Casecount, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Jlbpc, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Jlbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Jlbcs, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Jlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Onsale, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.Onsale;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Onsalesheet, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.Onsalesheet;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnsaleNw, 13, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnsaleNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnsalesheetNw, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnsalesheetNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleLbcs, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleLbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleJlbcs, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleJlbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SalePos, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SalePos;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleCol, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleLbcsNw, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleLbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleJlbcsNw, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleJlbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SalePosNw, 21, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SalePosNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.SaleColNw, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.SaleColNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Luc, 23, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.Luc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Qtyonhand, 24, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.Qtyonhand;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Negative, 25, typeof(System.Char), esSystemType.Char);
			c.PropertyName = ProdsMetadata.PropertyNames.Negative;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.WeightType, 26, typeof(System.Char), esSystemType.Char);
			c.PropertyName = ProdsMetadata.PropertyNames.WeightType;
			c.CharacterMaxLength = 1;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.AvgCost, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.AvgCost;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.AdjCost, 28, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.AdjCost;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.MasterCode, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.MasterCode;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.IsMaster, 30, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.IsMaster;
			c.HasDefault = true;
			c.Default = @"(0)";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsale, 31, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsale;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsalesheet, 32, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsalesheet;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsaleNw, 33, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsaleNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberOnsalesheetNw, 34, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberOnsalesheetNw;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleLbcs, 35, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleLbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleJlbcs, 36, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleJlbcs;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSalePos, 37, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSalePos;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleCol, 38, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleCol;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleLbcsNw, 39, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleLbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleJlbcsNw, 40, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleJlbcsNw;
			c.NumericPrecision = 15;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSalePosNw, 41, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSalePosNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.JobberSaleColNw, 42, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProdsMetadata.PropertyNames.JobberSaleColNw;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextCost, 43, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.NextCost;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextPODueDate, 44, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ProdsMetadata.PropertyNames.NextPODueDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.NextQtyDue, 45, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.NextQtyDue;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.LastPOCost, 46, typeof(System.Double), esSystemType.Double);
			c.PropertyName = ProdsMetadata.PropertyNames.LastPOCost;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Keywords, 47, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.Keywords;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.Taxable, 48, typeof(System.Char), esSystemType.Char);
			c.PropertyName = ProdsMetadata.PropertyNames.Taxable;
			c.CharacterMaxLength = 1;
			c.HasDefault = true;
			c.Default = @"('N')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.OnPriceList, 49, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.OnPriceList;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.PresentInLastImport, 50, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.PresentInLastImport;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.ProductCodeSub, 51, typeof(System.String), esSystemType.String);
			c.PropertyName = ProdsMetadata.PropertyNames.ProductCodeSub;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.DoNotSell, 52, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.DoNotSell;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProdsMetadata.ColumnNames.ArrowProd, 53, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProdsMetadata.PropertyNames.ArrowProd;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProdsMetadata Meta()
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
			if(!m_providerMetadataMaps.ContainsKey(mapName))
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
				meta.AddTypeMap("Negative", new esTypeMap("nvarchar", "System.Char"));
				meta.AddTypeMap("WeightType", new esTypeMap("nvarchar", "System.Char"));
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
				meta.AddTypeMap("Taxable", new esTypeMap("varchar", "System.Char"));
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
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProdsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
