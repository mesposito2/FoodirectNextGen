/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 11/6/2015 4:27:12 PM
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
	abstract public class esVwSalePCollection : esEntityCollection
	{
		public esVwSalePCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "VwSalePCollection";
		}

		#region Query Logic
		protected void InitQuery(esVwSalePQuery query)
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
			this.InitQuery(query as esVwSalePQuery);
		}
		#endregion
		
		virtual public VwSalePBO DetachEntity(VwSalePBO entity)
		{
			return base.DetachEntity(entity) as VwSalePBO;
		}
		
		virtual public VwSalePBO AttachEntity(VwSalePBO entity)
		{
			return base.AttachEntity(entity) as VwSalePBO;
		}
		
		virtual public void Combine(VwSalePCollection collection)
		{
			base.Combine(collection);
		}
		
		new public VwSalePBO this[int index]
		{
			get
			{
				return base[index] as VwSalePBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(VwSalePBO);
		}
	}



	[Serializable]
	abstract public class esVwSalePBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esVwSalePQuery GetDynamicQuery()
		{
			return null;
		}

		public esVwSalePBO()
		{

		}

		public esVwSalePBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		
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
						case "OnCurrentOrder": this.str.OnCurrentOrder = (string)value; break;							
						case "IsMaster": this.str.IsMaster = (string)value; break;							
						case "Casecount": this.str.Casecount = (string)value; break;							
						case "Custid": this.str.Custid = (string)value; break;							
						case "Colnum": this.str.Colnum = (string)value; break;							
						case "Line": this.str.Line = (string)value; break;							
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Sdescription": this.str.Sdescription = (string)value; break;							
						case "Slbcs": this.str.Slbcs = (string)value; break;							
						case "Sjlbcs": this.str.Sjlbcs = (string)value; break;							
						case "SalepID": this.str.SalepID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "OnCurrentOrder":
						
							if (value == null || value is System.Int32)
								this.OnCurrentOrder = (System.Int32?)value;
							break;
						
						case "IsMaster":
						
							if (value == null || value is System.Boolean)
								this.IsMaster = (System.Boolean?)value;
							break;
						
						case "Casecount":
						
							if (value == null || value is System.Int32)
								this.Casecount = (System.Int32?)value;
							break;
						
						case "Colnum":
						
							if (value == null || value is System.Int32)
								this.Colnum = (System.Int32?)value;
							break;
						
						case "Line":
						
							if (value == null || value is System.Int32)
								this.Line = (System.Int32?)value;
							break;
						
						case "Slbcs":
						
							if (value == null || value is System.Double)
								this.Slbcs = (System.Double?)value;
							break;
						
						case "Sjlbcs":
						
							if (value == null || value is System.Double)
								this.Sjlbcs = (System.Double?)value;
							break;
						
						case "SalepID":
						
							if (value == null || value is System.Int32)
								this.SalepID = (System.Int32?)value;
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
		/// Maps to vwSaleP.onCurrentOrder
		/// </summary>
		virtual public System.Int32? OnCurrentOrder
		{
			get
			{
				return base.GetSystemInt32(VwSalePMetadata.ColumnNames.OnCurrentOrder);
			}
			
			set
			{
				if(base.SetSystemInt32(VwSalePMetadata.ColumnNames.OnCurrentOrder, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.OnCurrentOrder));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.IsMaster
		/// </summary>
		virtual public System.Boolean? IsMaster
		{
			get
			{
				return base.GetSystemBoolean(VwSalePMetadata.ColumnNames.IsMaster);
			}
			
			set
			{
				if(base.SetSystemBoolean(VwSalePMetadata.ColumnNames.IsMaster, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.IsMaster));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.casecount
		/// </summary>
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(VwSalePMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(VwSalePMetadata.ColumnNames.Casecount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Casecount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(VwSalePMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(VwSalePMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.colnum
		/// </summary>
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(VwSalePMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(VwSalePMetadata.ColumnNames.Colnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.line
		/// </summary>
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(VwSalePMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(VwSalePMetadata.ColumnNames.Line, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(VwSalePMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(VwSalePMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.sdescription
		/// </summary>
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(VwSalePMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(VwSalePMetadata.ColumnNames.Sdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.slbcs
		/// </summary>
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(VwSalePMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(VwSalePMetadata.ColumnNames.Slbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.sjlbcs
		/// </summary>
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(VwSalePMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(VwSalePMetadata.ColumnNames.Sjlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwSaleP.salepID
		/// </summary>
		virtual public System.Int32? SalepID
		{
			get
			{
				return base.GetSystemInt32(VwSalePMetadata.ColumnNames.SalepID);
			}
			
			set
			{
				if(base.SetSystemInt32(VwSalePMetadata.ColumnNames.SalepID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwSalePMetadata.PropertyNames.SalepID));
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
			public esStrings(esVwSalePBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String OnCurrentOrder
			{
				get
				{
					System.Int32? data = entity.OnCurrentOrder;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OnCurrentOrder = null;
					else entity.OnCurrentOrder = Convert.ToInt32(value);
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
				
			public System.String Colnum
			{
				get
				{
					System.Int32? data = entity.Colnum;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Colnum = null;
					else entity.Colnum = Convert.ToInt32(value);
				}
			}
				
			public System.String Line
			{
				get
				{
					System.Int32? data = entity.Line;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Line = null;
					else entity.Line = Convert.ToInt32(value);
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
				
			public System.String Sdescription
			{
				get
				{
					System.String data = entity.Sdescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sdescription = null;
					else entity.Sdescription = Convert.ToString(value);
				}
			}
				
			public System.String Slbcs
			{
				get
				{
					System.Double? data = entity.Slbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Slbcs = null;
					else entity.Slbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String Sjlbcs
			{
				get
				{
					System.Double? data = entity.Sjlbcs;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Sjlbcs = null;
					else entity.Sjlbcs = Convert.ToDouble(value);
				}
			}
				
			public System.String SalepID
			{
				get
				{
					System.Int32? data = entity.SalepID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SalepID = null;
					else entity.SalepID = Convert.ToInt32(value);
				}
			}
			

			private esVwSalePBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esVwSalePQuery query)
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
				throw new Exception("esVwSalePBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esVwSalePQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VwSalePMetadata.Meta();
			}
		}	
		

		public esQueryItem OnCurrentOrder
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.OnCurrentOrder, esSystemType.Int32);
			}
		} 
		
		public esQueryItem IsMaster
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.IsMaster, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Casecount
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Casecount, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem SalepID
		{
			get
			{
				return new esQueryItem(this, VwSalePMetadata.ColumnNames.SalepID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("VwSalePCollection")]
	public partial class VwSalePCollection : esVwSalePCollection, IEnumerable<VwSalePBO>
	{
		public VwSalePCollection()
		{

		}
		
		public static implicit operator List<VwSalePBO>(VwSalePCollection coll)
		{
			List<VwSalePBO> list = new List<VwSalePBO>();
			
			foreach (VwSalePBO emp in coll)
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
				return  VwSalePMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwSalePQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new VwSalePBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new VwSalePBO();
		}
		
		
		override public bool LoadAll()
		{
			return base.LoadAll(esSqlAccessType.DynamicSQL);
		}	
		
		#endregion


		[BrowsableAttribute( false )]
		public VwSalePQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwSalePQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(VwSalePQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public VwSalePBO AddNew()
		{
			VwSalePBO entity = base.AddNewEntity() as VwSalePBO;
			
			return entity;
		}


		#region IEnumerable<VwSalePBO> Members

		IEnumerator<VwSalePBO> IEnumerable<VwSalePBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as VwSalePBO;
			}
		}

		#endregion
		
		private VwSalePQuery query;
	}


	/// <summary>
	/// Encapsulates the 'vwSaleP' view
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("VwSalePBO ()")]
	[Serializable]
	public partial class VwSalePBO : esVwSalePBO
	{
		public VwSalePBO()
		{

		}
	
		public VwSalePBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VwSalePMetadata.Meta();
			}
		}
		
		
		
		override protected esVwSalePQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwSalePQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public VwSalePQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwSalePQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(VwSalePQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private VwSalePQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class VwSalePQuery : esVwSalePQuery
	{
		public VwSalePQuery()
		{

		}		
		
		public VwSalePQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "VwSalePQuery";
        }
		
			
	}


	[Serializable]
	public partial class VwSalePMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VwSalePMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.OnCurrentOrder, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwSalePMetadata.PropertyNames.OnCurrentOrder;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.IsMaster, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwSalePMetadata.PropertyNames.IsMaster;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Casecount, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwSalePMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Custid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = VwSalePMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Colnum, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwSalePMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Line, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwSalePMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Productcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = VwSalePMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Sdescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = VwSalePMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Slbcs, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwSalePMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.Sjlbcs, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwSalePMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwSalePMetadata.ColumnNames.SalepID, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwSalePMetadata.PropertyNames.SalepID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public VwSalePMetadata Meta()
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
			 public const string OnCurrentOrder = "onCurrentOrder";
			 public const string IsMaster = "IsMaster";
			 public const string Casecount = "casecount";
			 public const string Custid = "custid";
			 public const string Colnum = "colnum";
			 public const string Line = "line";
			 public const string Productcode = "productcode";
			 public const string Sdescription = "sdescription";
			 public const string Slbcs = "slbcs";
			 public const string Sjlbcs = "sjlbcs";
			 public const string SalepID = "salepID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string OnCurrentOrder = "OnCurrentOrder";
			 public const string IsMaster = "IsMaster";
			 public const string Casecount = "Casecount";
			 public const string Custid = "Custid";
			 public const string Colnum = "Colnum";
			 public const string Line = "Line";
			 public const string Productcode = "Productcode";
			 public const string Sdescription = "Sdescription";
			 public const string Slbcs = "Slbcs";
			 public const string Sjlbcs = "Sjlbcs";
			 public const string SalepID = "SalepID";
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
			lock (typeof(VwSalePMetadata))
			{
				if(VwSalePMetadata.mapDelegates == null)
				{
					VwSalePMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (VwSalePMetadata.meta == null)
				{
					VwSalePMetadata.meta = new VwSalePMetadata();
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
				

				meta.AddTypeMap("OnCurrentOrder", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsMaster", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Colnum", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Line", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Productcode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Sdescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Slbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Sjlbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("SalepID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "vwSaleP";
				meta.Destination = "vwSaleP";
				
				meta.spInsert = "proc_vwSalePInsert";				
				meta.spUpdate = "proc_vwSalePUpdate";		
				meta.spDelete = "proc_vwSalePDelete";
				meta.spLoadAll = "proc_vwSalePLoadAll";
				meta.spLoadByPrimaryKey = "proc_vwSalePLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VwSalePMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
