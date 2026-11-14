/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/27/2015 1:27:45 PM
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
	abstract public class esBeefCollection : esEntityCollection
	{
		public esBeefCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "BeefCollection";
		}

		#region Query Logic
		protected void InitQuery(esBeefQuery query)
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
			this.InitQuery(query as esBeefQuery);
		}
		#endregion
		
		virtual public BeefBO DetachEntity(BeefBO entity)
		{
			return base.DetachEntity(entity) as BeefBO;
		}
		
		virtual public BeefBO AttachEntity(BeefBO entity)
		{
			return base.AttachEntity(entity) as BeefBO;
		}
		
		virtual public void Combine(BeefCollection collection)
		{
			base.Combine(collection);
		}
		
		new public BeefBO this[int index]
		{
			get
			{
				return base[index] as BeefBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(BeefBO);
		}
	}



	[Serializable]
	abstract public class esBeefBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esBeefQuery GetDynamicQuery()
		{
			return null;
		}

		public esBeefBO()
		{

		}

		public esBeefBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 beefID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(beefID);
			else
				return LoadByPrimaryKeyStoredProcedure(beefID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 beefID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(beefID);
			else
				return LoadByPrimaryKeyStoredProcedure(beefID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 beefID)
		{
			esBeefQuery query = this.GetDynamicQuery();
			query.Where(query.BeefID == beefID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 beefID)
		{
			esParameters parms = new esParameters();
			parms.Add("beefID",beefID);
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
		/// Maps to beef.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode1
		/// </summary>
		virtual public System.String Pcode1
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode1);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price1
		/// </summary>
		virtual public System.Double? Price1
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode2
		/// </summary>
		virtual public System.String Pcode2
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode2);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price2
		/// </summary>
		virtual public System.Double? Price2
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode3
		/// </summary>
		virtual public System.String Pcode3
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode3);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price3
		/// </summary>
		virtual public System.Double? Price3
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode4
		/// </summary>
		virtual public System.String Pcode4
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode4);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price4
		/// </summary>
		virtual public System.Double? Price4
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode5
		/// </summary>
		virtual public System.String Pcode5
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode5);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode5, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode5));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price5
		/// </summary>
		virtual public System.Double? Price5
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price5, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price5));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice1
		/// </summary>
		virtual public System.Double? Jprice1
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice2
		/// </summary>
		virtual public System.Double? Jprice2
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice3
		/// </summary>
		virtual public System.Double? Jprice3
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice4
		/// </summary>
		virtual public System.Double? Jprice4
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice4, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice4));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice5
		/// </summary>
		virtual public System.Double? Jprice5
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice5, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice5));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode6
		/// </summary>
		virtual public System.String Pcode6
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode6);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode6, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode6));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price6
		/// </summary>
		virtual public System.Double? Price6
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price6, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price6));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice6
		/// </summary>
		virtual public System.Double? Jprice6
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice6, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice6));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price7
		/// </summary>
		virtual public System.Double? Price7
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price7, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price7));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price8
		/// </summary>
		virtual public System.Double? Price8
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price8, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price8));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price9
		/// </summary>
		virtual public System.Double? Price9
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price9, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price9));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price10
		/// </summary>
		virtual public System.Double? Price10
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price10, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price10));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice7
		/// </summary>
		virtual public System.Double? Jprice7
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice7, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice7));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice8
		/// </summary>
		virtual public System.Double? Jprice8
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice8, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice8));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice9
		/// </summary>
		virtual public System.Double? Jprice9
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice9, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice9));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice10
		/// </summary>
		virtual public System.Double? Jprice10
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice10, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice10));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode7
		/// </summary>
		virtual public System.String Pcode7
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode7);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode7, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode7));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode8
		/// </summary>
		virtual public System.String Pcode8
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode8);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode8, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode8));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode9
		/// </summary>
		virtual public System.String Pcode9
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode9);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode9, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode9));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode10
		/// </summary>
		virtual public System.String Pcode10
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode10);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode10, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode10));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price11
		/// </summary>
		virtual public System.Double? Price11
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price11, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Price11));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice11
		/// </summary>
		virtual public System.Double? Jprice11
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice11, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Jprice11));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode11
		/// </summary>
		virtual public System.String Pcode11
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode11);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode11, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.Pcode11));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.beefID
		/// </summary>
		virtual public System.Int32? BeefID
		{
			get
			{
				return base.GetSystemInt32(BeefMetadata.ColumnNames.BeefID);
			}
			
			set
			{
				if(base.SetSystemInt32(BeefMetadata.ColumnNames.BeefID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(BeefMetadata.PropertyNames.BeefID));
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
			public esStrings(esBeefBO entity)
			{
				this.entity = entity;
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
			

			private esBeefBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esBeefQuery query)
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
				throw new Exception("esBeefBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esBeefQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BeefMetadata.Meta();
			}
		}	
		

		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode1
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode1, esSystemType.String);
			}
		} 
		
		public esQueryItem Price1
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price1, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode2
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode2, esSystemType.String);
			}
		} 
		
		public esQueryItem Price2
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price2, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode3
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode3, esSystemType.String);
			}
		} 
		
		public esQueryItem Price3
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price3, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode4
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode4, esSystemType.String);
			}
		} 
		
		public esQueryItem Price4
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price4, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode5
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode5, esSystemType.String);
			}
		} 
		
		public esQueryItem Price5
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price5, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice1
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice1, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice2
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice2, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice3
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice3, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice4
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice4, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice5
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice5, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode6
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode6, esSystemType.String);
			}
		} 
		
		public esQueryItem Price6
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price6, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice6
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice6, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price7
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price7, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price8
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price8, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price9
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price9, esSystemType.Double);
			}
		} 
		
		public esQueryItem Price10
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price10, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice7
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice7, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice8
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice8, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice9
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice9, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice10
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice10, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode7
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode7, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode8
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode8, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode9
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode9, esSystemType.String);
			}
		} 
		
		public esQueryItem Pcode10
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode10, esSystemType.String);
			}
		} 
		
		public esQueryItem Price11
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Price11, esSystemType.Double);
			}
		} 
		
		public esQueryItem Jprice11
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice11, esSystemType.Double);
			}
		} 
		
		public esQueryItem Pcode11
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode11, esSystemType.String);
			}
		} 
		
		public esQueryItem BeefID
		{
			get
			{
				return new esQueryItem(this, BeefMetadata.ColumnNames.BeefID, esSystemType.Int32);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("BeefCollection")]
	public partial class BeefCollection : esBeefCollection, IEnumerable<BeefBO>
	{
		public BeefCollection()
		{

		}
		
		public static implicit operator List<BeefBO>(BeefCollection coll)
		{
			List<BeefBO> list = new List<BeefBO>();
			
			foreach (BeefBO emp in coll)
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
				return  BeefMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BeefQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new BeefBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new BeefBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public BeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(BeefQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public BeefBO AddNew()
		{
			BeefBO entity = base.AddNewEntity() as BeefBO;
			
			return entity;
		}

		public BeefBO FindByPrimaryKey(System.Int32 beefID)
		{
			return base.FindByPrimaryKey(beefID) as BeefBO;
		}


		#region IEnumerable<BeefBO> Members

		IEnumerator<BeefBO> IEnumerable<BeefBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as BeefBO;
			}
		}

		#endregion
		
		private BeefQuery query;
	}


	/// <summary>
	/// Encapsulates the 'beef' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("BeefBO ({BeefID})")]
	[Serializable]
	public partial class BeefBO : esBeefBO
	{
		public BeefBO()
		{

		}
	
		public BeefBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BeefMetadata.Meta();
			}
		}
		
		
		
		override protected esBeefQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BeefQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public BeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(BeefQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private BeefQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class BeefQuery : esBeefQuery
	{
		public BeefQuery()
		{

		}		
		
		public BeefQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "BeefQuery";
        }
		
			
	}


	[Serializable]
	public partial class BeefMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BeefMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BeefMetadata.ColumnNames.Description, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode1, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode1;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price1, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode2, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode2;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price2, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode3, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode3;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price3, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode4, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode4;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price4, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode5, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode5;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price5, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice1, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice2, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice3, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice4, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice5, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode6, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode6;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price6, 17, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice6, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price7, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price8, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price9, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price10, 22, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice7, 23, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice8, 24, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice9, 25, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice10, 26, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode7, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode7;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode8, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode8;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode9, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode9;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode10, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode10;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price11, 31, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice11, 32, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode11, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode11;
			c.CharacterMaxLength = 6;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.BeefID, 34, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BeefMetadata.PropertyNames.BeefID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public BeefMetadata Meta()
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
			lock (typeof(BeefMetadata))
			{
				if(BeefMetadata.mapDelegates == null)
				{
					BeefMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BeefMetadata.meta == null)
				{
					BeefMetadata.meta = new BeefMetadata();
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
				meta.AddTypeMap("Pcode7", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Pcode8", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Pcode9", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Pcode10", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Price11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode11", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BeefID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "beef";
				meta.Destination = "beef";
				
				meta.spInsert = "proc_beefInsert";				
				meta.spUpdate = "proc_beefUpdate";		
				meta.spDelete = "proc_beefDelete";
				meta.spLoadAll = "proc_beefLoadAll";
				meta.spLoadByPrimaryKey = "proc_beefLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BeefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
