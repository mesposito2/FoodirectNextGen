/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 10/29/2015 11:45:01 AM
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
	abstract public class esVwProdsCollection : esEntityCollection
	{
		public esVwProdsCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "VwProdsCollection";
		}

		#region Query Logic
		protected void InitQuery(esVwProdsQuery query)
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
			this.InitQuery(query as esVwProdsQuery);
		}
		#endregion
		
		virtual public VwProdsBO DetachEntity(VwProdsBO entity)
		{
			return base.DetachEntity(entity) as VwProdsBO;
		}
		
		virtual public VwProdsBO AttachEntity(VwProdsBO entity)
		{
			return base.AttachEntity(entity) as VwProdsBO;
		}
		
		virtual public void Combine(VwProdsCollection collection)
		{
			base.Combine(collection);
		}
		
		new public VwProdsBO this[int index]
		{
			get
			{
				return base[index] as VwProdsBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(VwProdsBO);
		}
	}



	[Serializable]
	abstract public class esVwProdsBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esVwProdsQuery GetDynamicQuery()
		{
			return null;
		}

		public esVwProdsBO()
		{

		}

		public esVwProdsBO(DataRow row)
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
						case "Productcode": this.str.Productcode = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;							
						case "Brandcode": this.str.Brandcode = (string)value; break;							
						case "CategoryName": this.str.CategoryName = (string)value; break;							
						case "Catid": this.str.Catid = (string)value; break;							
						case "Scatid": this.str.Scatid = (string)value; break;							
						case "Keywords": this.str.Keywords = (string)value; break;							
						case "Weight": this.str.Weight = (string)value; break;							
						case "Lbpc": this.str.Lbpc = (string)value; break;							
						case "Lbcs": this.str.Lbcs = (string)value; break;							
						case "Casecount": this.str.Casecount = (string)value; break;							
						case "OnPriceList": this.str.OnPriceList = (string)value; break;							
						case "PresentInLastImport": this.str.PresentInLastImport = (string)value; break;							
						case "Qtyonhand": this.str.Qtyonhand = (string)value; break;							
						case "GroupCode": this.str.GroupCode = (string)value; break;
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
						
						case "OnPriceList":
						
							if (value == null || value is System.Boolean)
								this.OnPriceList = (System.Boolean?)value;
							break;
						
						case "PresentInLastImport":
						
							if (value == null || value is System.Boolean)
								this.PresentInLastImport = (System.Boolean?)value;
							break;
						
						case "Qtyonhand":
						
							if (value == null || value is System.Int32)
								this.Qtyonhand = (System.Int32?)value;
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
		/// Maps to vwProds.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.brandcode
		/// </summary>
		virtual public System.String Brandcode
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Brandcode);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Brandcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Brandcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.CategoryName
		/// </summary>
		virtual public System.String CategoryName
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.CategoryName);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.CategoryName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.CategoryName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.catid
		/// </summary>
		virtual public System.String Catid
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Catid);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Catid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Catid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.scatid
		/// </summary>
		virtual public System.String Scatid
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Scatid);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Scatid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Scatid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.keywords
		/// </summary>
		virtual public System.String Keywords
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.Keywords);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.Keywords, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Keywords));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.weight
		/// </summary>
		virtual public System.Double? Weight
		{
			get
			{
				return base.GetSystemDouble(VwProdsMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDouble(VwProdsMetadata.ColumnNames.Weight, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Weight));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.lbpc
		/// </summary>
		virtual public System.Double? Lbpc
		{
			get
			{
				return base.GetSystemDouble(VwProdsMetadata.ColumnNames.Lbpc);
			}
			
			set
			{
				if(base.SetSystemDouble(VwProdsMetadata.ColumnNames.Lbpc, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Lbpc));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.lbcs
		/// </summary>
		virtual public System.Double? Lbcs
		{
			get
			{
				return base.GetSystemDouble(VwProdsMetadata.ColumnNames.Lbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(VwProdsMetadata.ColumnNames.Lbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Lbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.casecount
		/// </summary>
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(VwProdsMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProdsMetadata.ColumnNames.Casecount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Casecount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.OnPriceList
		/// </summary>
		virtual public System.Boolean? OnPriceList
		{
			get
			{
				return base.GetSystemBoolean(VwProdsMetadata.ColumnNames.OnPriceList);
			}
			
			set
			{
				if(base.SetSystemBoolean(VwProdsMetadata.ColumnNames.OnPriceList, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.OnPriceList));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.PresentInLastImport
		/// </summary>
		virtual public System.Boolean? PresentInLastImport
		{
			get
			{
				return base.GetSystemBoolean(VwProdsMetadata.ColumnNames.PresentInLastImport);
			}
			
			set
			{
				if(base.SetSystemBoolean(VwProdsMetadata.ColumnNames.PresentInLastImport, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.PresentInLastImport));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.qtyonhand
		/// </summary>
		virtual public System.Int32? Qtyonhand
		{
			get
			{
				return base.GetSystemInt32(VwProdsMetadata.ColumnNames.Qtyonhand);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProdsMetadata.ColumnNames.Qtyonhand, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.Qtyonhand));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProds.GroupCode
		/// </summary>
		virtual public System.String GroupCode
		{
			get
			{
				return base.GetSystemString(VwProdsMetadata.ColumnNames.GroupCode);
			}
			
			set
			{
				if(base.SetSystemString(VwProdsMetadata.ColumnNames.GroupCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProdsMetadata.PropertyNames.GroupCode));
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
			public esStrings(esVwProdsBO entity)
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
				
			public System.String CategoryName
			{
				get
				{
					System.String data = entity.CategoryName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CategoryName = null;
					else entity.CategoryName = Convert.ToString(value);
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
			

			private esVwProdsBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esVwProdsQuery query)
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
				throw new Exception("esVwProdsBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esVwProdsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VwProdsMetadata.Meta();
			}
		}	
		

		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Brandcode
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Brandcode, esSystemType.String);
			}
		} 
		
		public esQueryItem CategoryName
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.CategoryName, esSystemType.String);
			}
		} 
		
		public esQueryItem Catid
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Catid, esSystemType.String);
			}
		} 
		
		public esQueryItem Scatid
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Scatid, esSystemType.String);
			}
		} 
		
		public esQueryItem Keywords
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Keywords, esSystemType.String);
			}
		} 
		
		public esQueryItem Weight
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Weight, esSystemType.Double);
			}
		} 
		
		public esQueryItem Lbpc
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Lbpc, esSystemType.Double);
			}
		} 
		
		public esQueryItem Lbcs
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Lbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Casecount
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Casecount, esSystemType.Int32);
			}
		} 
		
		public esQueryItem OnPriceList
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.OnPriceList, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem PresentInLastImport
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.PresentInLastImport, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Qtyonhand
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.Qtyonhand, esSystemType.Int32);
			}
		} 
		
		public esQueryItem GroupCode
		{
			get
			{
				return new esQueryItem(this, VwProdsMetadata.ColumnNames.GroupCode, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("VwProdsCollection")]
	public partial class VwProdsCollection : esVwProdsCollection, IEnumerable<VwProdsBO>
	{
		public VwProdsCollection()
		{

		}
		
		public static implicit operator List<VwProdsBO>(VwProdsCollection coll)
		{
			List<VwProdsBO> list = new List<VwProdsBO>();
			
			foreach (VwProdsBO emp in coll)
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
				return  VwProdsMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwProdsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new VwProdsBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new VwProdsBO();
		}
		
		
		override public bool LoadAll()
		{
			return base.LoadAll(esSqlAccessType.DynamicSQL);
		}	
		
		#endregion


		[BrowsableAttribute( false )]
		public VwProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwProdsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(VwProdsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public VwProdsBO AddNew()
		{
			VwProdsBO entity = base.AddNewEntity() as VwProdsBO;
			
			return entity;
		}


		#region IEnumerable<VwProdsBO> Members

		IEnumerator<VwProdsBO> IEnumerable<VwProdsBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as VwProdsBO;
			}
		}

		#endregion
		
		private VwProdsQuery query;
	}


	/// <summary>
	/// Encapsulates the 'vwProds' view
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("VwProdsBO ()")]
	[Serializable]
	public partial class VwProdsBO : esVwProdsBO
	{
		public VwProdsBO()
		{

		}
	
		public VwProdsBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VwProdsMetadata.Meta();
			}
		}
		
		
		
		override protected esVwProdsQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwProdsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public VwProdsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwProdsQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(VwProdsQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private VwProdsQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class VwProdsQuery : esVwProdsQuery
	{
		public VwProdsQuery()
		{

		}		
		
		public VwProdsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "VwProdsQuery";
        }
		
			
	}


	[Serializable]
	public partial class VwProdsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VwProdsMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Productcode, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 6;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Description, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Brandcode, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Brandcode;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.CategoryName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.CategoryName;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Catid, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Catid;
			c.CharacterMaxLength = 3;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Scatid, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Scatid;
			c.CharacterMaxLength = 3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Keywords, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.Keywords;
			c.CharacterMaxLength = 1000;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Weight, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwProdsMetadata.PropertyNames.Weight;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Lbpc, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwProdsMetadata.PropertyNames.Lbpc;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Lbcs, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwProdsMetadata.PropertyNames.Lbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Casecount, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProdsMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.OnPriceList, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwProdsMetadata.PropertyNames.OnPriceList;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.PresentInLastImport, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwProdsMetadata.PropertyNames.PresentInLastImport;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.Qtyonhand, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProdsMetadata.PropertyNames.Qtyonhand;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProdsMetadata.ColumnNames.GroupCode, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProdsMetadata.PropertyNames.GroupCode;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public VwProdsMetadata Meta()
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
			 public const string CategoryName = "CategoryName";
			 public const string Catid = "catid";
			 public const string Scatid = "scatid";
			 public const string Keywords = "keywords";
			 public const string Weight = "weight";
			 public const string Lbpc = "lbpc";
			 public const string Lbcs = "lbcs";
			 public const string Casecount = "casecount";
			 public const string OnPriceList = "OnPriceList";
			 public const string PresentInLastImport = "PresentInLastImport";
			 public const string Qtyonhand = "qtyonhand";
			 public const string GroupCode = "GroupCode";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Productcode = "Productcode";
			 public const string Description = "Description";
			 public const string Brandcode = "Brandcode";
			 public const string CategoryName = "CategoryName";
			 public const string Catid = "Catid";
			 public const string Scatid = "Scatid";
			 public const string Keywords = "Keywords";
			 public const string Weight = "Weight";
			 public const string Lbpc = "Lbpc";
			 public const string Lbcs = "Lbcs";
			 public const string Casecount = "Casecount";
			 public const string OnPriceList = "OnPriceList";
			 public const string PresentInLastImport = "PresentInLastImport";
			 public const string Qtyonhand = "Qtyonhand";
			 public const string GroupCode = "GroupCode";
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
			lock (typeof(VwProdsMetadata))
			{
				if(VwProdsMetadata.mapDelegates == null)
				{
					VwProdsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (VwProdsMetadata.meta == null)
				{
					VwProdsMetadata.meta = new VwProdsMetadata();
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
				meta.AddTypeMap("CategoryName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Catid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Scatid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Keywords", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Weight", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbpc", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Lbcs", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Casecount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("OnPriceList", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("PresentInLastImport", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Qtyonhand", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("GroupCode", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "vwProds";
				meta.Destination = "vwProds";
				
				meta.spInsert = "proc_vwProdsInsert";				
				meta.spUpdate = "proc_vwProdsUpdate";		
				meta.spDelete = "proc_vwProdsDelete";
				meta.spLoadAll = "proc_vwProdsLoadAll";
				meta.spLoadByPrimaryKey = "proc_vwProdsLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VwProdsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
