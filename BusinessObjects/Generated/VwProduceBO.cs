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
	abstract public class esVwProduceCollection : esEntityCollection
	{
		public esVwProduceCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "VwProduceCollection";
		}

		#region Query Logic
		protected void InitQuery(esVwProduceQuery query)
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
			this.InitQuery(query as esVwProduceQuery);
		}
		#endregion
		
		virtual public VwProduceBO DetachEntity(VwProduceBO entity)
		{
			return base.DetachEntity(entity) as VwProduceBO;
		}
		
		virtual public VwProduceBO AttachEntity(VwProduceBO entity)
		{
			return base.AttachEntity(entity) as VwProduceBO;
		}
		
		virtual public void Combine(VwProduceCollection collection)
		{
			base.Combine(collection);
		}
		
		new public VwProduceBO this[int index]
		{
			get
			{
				return base[index] as VwProduceBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(VwProduceBO);
		}
	}



	[Serializable]
	abstract public class esVwProduceBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esVwProduceQuery GetDynamicQuery()
		{
			return null;
		}

		public esVwProduceBO()
		{

		}

		public esVwProduceBO(DataRow row)
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
						case "ProduceID": this.str.ProduceID = (string)value; break;
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
						
						case "ProduceID":
						
							if (value == null || value is System.Int32)
								this.ProduceID = (System.Int32?)value;
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
		/// Maps to vwProduce.onCurrentOrder
		/// </summary>
		virtual public System.Int32? OnCurrentOrder
		{
			get
			{
				return base.GetSystemInt32(VwProduceMetadata.ColumnNames.OnCurrentOrder);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProduceMetadata.ColumnNames.OnCurrentOrder, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.OnCurrentOrder));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.IsMaster
		/// </summary>
		virtual public System.Boolean? IsMaster
		{
			get
			{
				return base.GetSystemBoolean(VwProduceMetadata.ColumnNames.IsMaster);
			}
			
			set
			{
				if(base.SetSystemBoolean(VwProduceMetadata.ColumnNames.IsMaster, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.IsMaster));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.Casecount
		/// </summary>
		virtual public System.Int32? Casecount
		{
			get
			{
				return base.GetSystemInt32(VwProduceMetadata.ColumnNames.Casecount);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProduceMetadata.ColumnNames.Casecount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Casecount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.custid
		/// </summary>
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(VwProduceMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(VwProduceMetadata.ColumnNames.Custid, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Custid));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.colnum
		/// </summary>
		virtual public System.Int32? Colnum
		{
			get
			{
				return base.GetSystemInt32(VwProduceMetadata.ColumnNames.Colnum);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProduceMetadata.ColumnNames.Colnum, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Colnum));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.line
		/// </summary>
		virtual public System.Int32? Line
		{
			get
			{
				return base.GetSystemInt32(VwProduceMetadata.ColumnNames.Line);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProduceMetadata.ColumnNames.Line, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Line));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.productcode
		/// </summary>
		virtual public System.String Productcode
		{
			get
			{
				return base.GetSystemString(VwProduceMetadata.ColumnNames.Productcode);
			}
			
			set
			{
				if(base.SetSystemString(VwProduceMetadata.ColumnNames.Productcode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Productcode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.sdescription
		/// </summary>
		virtual public System.String Sdescription
		{
			get
			{
				return base.GetSystemString(VwProduceMetadata.ColumnNames.Sdescription);
			}
			
			set
			{
				if(base.SetSystemString(VwProduceMetadata.ColumnNames.Sdescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Sdescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.slbcs
		/// </summary>
		virtual public System.Double? Slbcs
		{
			get
			{
				return base.GetSystemDouble(VwProduceMetadata.ColumnNames.Slbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(VwProduceMetadata.ColumnNames.Slbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Slbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.sjlbcs
		/// </summary>
		virtual public System.Double? Sjlbcs
		{
			get
			{
				return base.GetSystemDouble(VwProduceMetadata.ColumnNames.Sjlbcs);
			}
			
			set
			{
				if(base.SetSystemDouble(VwProduceMetadata.ColumnNames.Sjlbcs, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.Sjlbcs));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to vwProduce.produceID
		/// </summary>
		virtual public System.Int32? ProduceID
		{
			get
			{
				return base.GetSystemInt32(VwProduceMetadata.ColumnNames.ProduceID);
			}
			
			set
			{
				if(base.SetSystemInt32(VwProduceMetadata.ColumnNames.ProduceID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(VwProduceMetadata.PropertyNames.ProduceID));
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
			public esStrings(esVwProduceBO entity)
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
				
			public System.String ProduceID
			{
				get
				{
					System.Int32? data = entity.ProduceID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProduceID = null;
					else entity.ProduceID = Convert.ToInt32(value);
				}
			}
			

			private esVwProduceBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esVwProduceQuery query)
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
				throw new Exception("esVwProduceBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esVwProduceQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return VwProduceMetadata.Meta();
			}
		}	
		

		public esQueryItem OnCurrentOrder
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.OnCurrentOrder, esSystemType.Int32);
			}
		} 
		
		public esQueryItem IsMaster
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.IsMaster, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Casecount
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Casecount, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Custid
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Custid, esSystemType.String);
			}
		} 
		
		public esQueryItem Colnum
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Colnum, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Line
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Line, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Productcode
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Productcode, esSystemType.String);
			}
		} 
		
		public esQueryItem Sdescription
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Sdescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Slbcs
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Slbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem Sjlbcs
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.Sjlbcs, esSystemType.Double);
			}
		} 
		
		public esQueryItem ProduceID
		{
			get
			{
				return new esQueryItem(this, VwProduceMetadata.ColumnNames.ProduceID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("VwProduceCollection")]
	public partial class VwProduceCollection : esVwProduceCollection, IEnumerable<VwProduceBO>
	{
		public VwProduceCollection()
		{

		}
		
		public static implicit operator List<VwProduceBO>(VwProduceCollection coll)
		{
			List<VwProduceBO> list = new List<VwProduceBO>();
			
			foreach (VwProduceBO emp in coll)
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
				return  VwProduceMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwProduceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new VwProduceBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new VwProduceBO();
		}
		
		
		override public bool LoadAll()
		{
			return base.LoadAll(esSqlAccessType.DynamicSQL);
		}	
		
		#endregion


		[BrowsableAttribute( false )]
		public VwProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwProduceQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(VwProduceQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public VwProduceBO AddNew()
		{
			VwProduceBO entity = base.AddNewEntity() as VwProduceBO;
			
			return entity;
		}


		#region IEnumerable<VwProduceBO> Members

		IEnumerator<VwProduceBO> IEnumerable<VwProduceBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as VwProduceBO;
			}
		}

		#endregion
		
		private VwProduceQuery query;
	}


	/// <summary>
	/// Encapsulates the 'vwProduce' view
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("VwProduceBO ()")]
	[Serializable]
	public partial class VwProduceBO : esVwProduceBO
	{
		public VwProduceBO()
		{

		}
	
		public VwProduceBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return VwProduceMetadata.Meta();
			}
		}
		
		
		
		override protected esVwProduceQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new VwProduceQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public VwProduceQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new VwProduceQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(VwProduceQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private VwProduceQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class VwProduceQuery : esVwProduceQuery
	{
		public VwProduceQuery()
		{

		}		
		
		public VwProduceQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "VwProduceQuery";
        }
		
			
	}


	[Serializable]
	public partial class VwProduceMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected VwProduceMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.OnCurrentOrder, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProduceMetadata.PropertyNames.OnCurrentOrder;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.IsMaster, 1, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = VwProduceMetadata.PropertyNames.IsMaster;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Casecount, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProduceMetadata.PropertyNames.Casecount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Custid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProduceMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Colnum, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProduceMetadata.PropertyNames.Colnum;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Line, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProduceMetadata.PropertyNames.Line;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Productcode, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProduceMetadata.PropertyNames.Productcode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Sdescription, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = VwProduceMetadata.PropertyNames.Sdescription;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Slbcs, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwProduceMetadata.PropertyNames.Slbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.Sjlbcs, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = VwProduceMetadata.PropertyNames.Sjlbcs;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(VwProduceMetadata.ColumnNames.ProduceID, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = VwProduceMetadata.PropertyNames.ProduceID;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public VwProduceMetadata Meta()
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
			 public const string Casecount = "Casecount";
			 public const string Custid = "custid";
			 public const string Colnum = "colnum";
			 public const string Line = "line";
			 public const string Productcode = "productcode";
			 public const string Sdescription = "sdescription";
			 public const string Slbcs = "slbcs";
			 public const string Sjlbcs = "sjlbcs";
			 public const string ProduceID = "produceID";
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
			 public const string ProduceID = "ProduceID";
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
			lock (typeof(VwProduceMetadata))
			{
				if(VwProduceMetadata.mapDelegates == null)
				{
					VwProduceMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (VwProduceMetadata.meta == null)
				{
					VwProduceMetadata.meta = new VwProduceMetadata();
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
				meta.AddTypeMap("ProduceID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "vwProduce";
				meta.Destination = "vwProduce";
				
				meta.spInsert = "proc_vwProduceInsert";				
				meta.spUpdate = "proc_vwProduceUpdate";		
				meta.spDelete = "proc_vwProduceDelete";
				meta.spLoadAll = "proc_vwProduceLoadAll";
				meta.spLoadByPrimaryKey = "proc_vwProduceLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private VwProduceMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
