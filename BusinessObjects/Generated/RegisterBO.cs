/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 12/21/2013 8:34:43 AM
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
	abstract public class esRegisterCollection : esEntityCollection
	{
		public esRegisterCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "RegisterCollection";
		}

		#region Query Logic
		protected void InitQuery(esRegisterQuery query)
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
			this.InitQuery(query as esRegisterQuery);
		}
		#endregion
		
		virtual public RegisterBO DetachEntity(RegisterBO entity)
		{
			return base.DetachEntity(entity) as RegisterBO;
		}
		
		virtual public RegisterBO AttachEntity(RegisterBO entity)
		{
			return base.AttachEntity(entity) as RegisterBO;
		}
		
		virtual public void Combine(RegisterCollection collection)
		{
			base.Combine(collection);
		}
		
		new public RegisterBO this[int index]
		{
			get
			{
				return base[index] as RegisterBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(RegisterBO);
		}
	}



	[Serializable]
	abstract public class esRegisterBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esRegisterQuery GetDynamicQuery()
		{
			return null;
		}

		public esRegisterBO()
		{

		}

		public esRegisterBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 registerID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(registerID);
			else
				return LoadByPrimaryKeyStoredProcedure(registerID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 registerID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(registerID);
			else
				return LoadByPrimaryKeyStoredProcedure(registerID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 registerID)
		{
			esRegisterQuery query = this.GetDynamicQuery();
			query.Where(query.RegisterID == registerID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 registerID)
		{
			esParameters parms = new esParameters();
			parms.Add("RegisterID",registerID);
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
						case "RegisterID": this.str.RegisterID = (string)value; break;							
						case "FName": this.str.FName = (string)value; break;							
						case "LName": this.str.LName = (string)value; break;							
						case "Address": this.str.Address = (string)value; break;							
						case "City": this.str.City = (string)value; break;							
						case "State": this.str.State = (string)value; break;							
						case "Zip": this.str.Zip = (string)value; break;							
						case "BusinessName": this.str.BusinessName = (string)value; break;							
						case "BusinessType": this.str.BusinessType = (string)value; break;							
						case "BusinessSize": this.str.BusinessSize = (string)value; break;							
						case "BestTimeToContact": this.str.BestTimeToContact = (string)value; break;							
						case "Email": this.str.Email = (string)value; break;							
						case "Phone": this.str.Phone = (string)value; break;							
						case "Country": this.str.Country = (string)value; break;							
						case "IdData": this.str.IdData = (string)value; break;							
						case "UserName": this.str.UserName = (string)value; break;							
						case "Password": this.str.Password = (string)value; break;							
						case "StatusUCode": this.str.StatusUCode = (string)value; break;							
						case "LastUpdateBy": this.str.LastUpdateBy = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "CreateDate": this.str.CreateDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "RegisterID":
						
							if (value == null || value is System.Int32)
								this.RegisterID = (System.Int32?)value;
							break;
						
						case "BusinessSize":
						
							if (value == null || value is System.Int32)
								this.BusinessSize = (System.Int32?)value;
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
		/// Maps to Register.RegisterID
		/// </summary>
		virtual public System.Int32? RegisterID
		{
			get
			{
				return base.GetSystemInt32(RegisterMetadata.ColumnNames.RegisterID);
			}
			
			set
			{
				if(base.SetSystemInt32(RegisterMetadata.ColumnNames.RegisterID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.RegisterID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.FName
		/// </summary>
		virtual public System.String FName
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.FName);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.FName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.FName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.LName
		/// </summary>
		virtual public System.String LName
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.LName);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.LName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.LName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Address
		/// </summary>
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Address, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Address));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.City
		/// </summary>
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.City, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.City));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.State
		/// </summary>
		virtual public System.String State
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.State, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.State));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Zip
		/// </summary>
		virtual public System.String Zip
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Zip);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Zip, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Zip));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.BusinessName
		/// </summary>
		virtual public System.String BusinessName
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.BusinessName);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.BusinessName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.BusinessName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.BusinessType
		/// </summary>
		virtual public System.String BusinessType
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.BusinessType);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.BusinessType, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.BusinessType));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.BusinessSize
		/// </summary>
		virtual public System.Int32? BusinessSize
		{
			get
			{
				return base.GetSystemInt32(RegisterMetadata.ColumnNames.BusinessSize);
			}
			
			set
			{
				if(base.SetSystemInt32(RegisterMetadata.ColumnNames.BusinessSize, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.BusinessSize));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.BestTimeToContact
		/// </summary>
		virtual public System.String BestTimeToContact
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.BestTimeToContact);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.BestTimeToContact, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.BestTimeToContact));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Email
		/// </summary>
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Email, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Email));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Phone
		/// </summary>
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Phone, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Phone));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Country
		/// </summary>
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Country, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Country));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.ID_DATA
		/// </summary>
		virtual public System.String IdData
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.IdData);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.IdData, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.IdData));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.UserName
		/// </summary>
		virtual public System.String UserName
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.UserName);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.UserName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.UserName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.Password
		/// </summary>
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.Password, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.Password));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.StatusUCode
		/// </summary>
		virtual public System.String StatusUCode
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.StatusUCode);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.StatusUCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.StatusUCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.LastUpdateBy
		/// </summary>
		virtual public System.String LastUpdateBy
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.LastUpdateBy);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.LastUpdateBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.LastUpdateBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.LastUpdate
		/// </summary>
		virtual public System.String LastUpdate
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Register.CreateDate
		/// </summary>
		virtual public System.String CreateDate
		{
			get
			{
				return base.GetSystemString(RegisterMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemString(RegisterMetadata.ColumnNames.CreateDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(RegisterMetadata.PropertyNames.CreateDate));
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
			public esStrings(esRegisterBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String RegisterID
			{
				get
				{
					System.Int32? data = entity.RegisterID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RegisterID = null;
					else entity.RegisterID = Convert.ToInt32(value);
				}
			}
				
			public System.String FName
			{
				get
				{
					System.String data = entity.FName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FName = null;
					else entity.FName = Convert.ToString(value);
				}
			}
				
			public System.String LName
			{
				get
				{
					System.String data = entity.LName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LName = null;
					else entity.LName = Convert.ToString(value);
				}
			}
				
			public System.String Address
			{
				get
				{
					System.String data = entity.Address;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Address = null;
					else entity.Address = Convert.ToString(value);
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
				
			public System.String BusinessName
			{
				get
				{
					System.String data = entity.BusinessName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BusinessName = null;
					else entity.BusinessName = Convert.ToString(value);
				}
			}
				
			public System.String BusinessType
			{
				get
				{
					System.String data = entity.BusinessType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BusinessType = null;
					else entity.BusinessType = Convert.ToString(value);
				}
			}
				
			public System.String BusinessSize
			{
				get
				{
					System.Int32? data = entity.BusinessSize;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BusinessSize = null;
					else entity.BusinessSize = Convert.ToInt32(value);
				}
			}
				
			public System.String BestTimeToContact
			{
				get
				{
					System.String data = entity.BestTimeToContact;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.BestTimeToContact = null;
					else entity.BestTimeToContact = Convert.ToString(value);
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
				
			public System.String Phone
			{
				get
				{
					System.String data = entity.Phone;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Phone = null;
					else entity.Phone = Convert.ToString(value);
				}
			}
				
			public System.String Country
			{
				get
				{
					System.String data = entity.Country;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Country = null;
					else entity.Country = Convert.ToString(value);
				}
			}
				
			public System.String IdData
			{
				get
				{
					System.String data = entity.IdData;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IdData = null;
					else entity.IdData = Convert.ToString(value);
				}
			}
				
			public System.String UserName
			{
				get
				{
					System.String data = entity.UserName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserName = null;
					else entity.UserName = Convert.ToString(value);
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
				
			public System.String StatusUCode
			{
				get
				{
					System.String data = entity.StatusUCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StatusUCode = null;
					else entity.StatusUCode = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdateBy
			{
				get
				{
					System.String data = entity.LastUpdateBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateBy = null;
					else entity.LastUpdateBy = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdate
			{
				get
				{
					System.String data = entity.LastUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdate = null;
					else entity.LastUpdate = Convert.ToString(value);
				}
			}
				
			public System.String CreatedBy
			{
				get
				{
					System.String data = entity.CreatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedBy = null;
					else entity.CreatedBy = Convert.ToString(value);
				}
			}
				
			public System.String CreateDate
			{
				get
				{
					System.String data = entity.CreateDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreateDate = null;
					else entity.CreateDate = Convert.ToString(value);
				}
			}
			

			private esRegisterBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esRegisterQuery query)
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
				throw new Exception("esRegisterBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esRegisterQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return RegisterMetadata.Meta();
			}
		}	
		

		public esQueryItem RegisterID
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.RegisterID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem FName
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.FName, esSystemType.String);
			}
		} 
		
		public esQueryItem LName
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.LName, esSystemType.String);
			}
		} 
		
		public esQueryItem Address
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Address, esSystemType.String);
			}
		} 
		
		public esQueryItem City
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.City, esSystemType.String);
			}
		} 
		
		public esQueryItem State
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.State, esSystemType.String);
			}
		} 
		
		public esQueryItem Zip
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Zip, esSystemType.String);
			}
		} 
		
		public esQueryItem BusinessName
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.BusinessName, esSystemType.String);
			}
		} 
		
		public esQueryItem BusinessType
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.BusinessType, esSystemType.String);
			}
		} 
		
		public esQueryItem BusinessSize
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.BusinessSize, esSystemType.Int32);
			}
		} 
		
		public esQueryItem BestTimeToContact
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.BestTimeToContact, esSystemType.String);
			}
		} 
		
		public esQueryItem Email
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Email, esSystemType.String);
			}
		} 
		
		public esQueryItem Phone
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Phone, esSystemType.String);
			}
		} 
		
		public esQueryItem Country
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Country, esSystemType.String);
			}
		} 
		
		public esQueryItem IdData
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.IdData, esSystemType.String);
			}
		} 
		
		public esQueryItem UserName
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.UserName, esSystemType.String);
			}
		} 
		
		public esQueryItem Password
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.Password, esSystemType.String);
			}
		} 
		
		public esQueryItem StatusUCode
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.StatusUCode, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdateBy
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.LastUpdateBy, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.LastUpdate, esSystemType.String);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDate
		{
			get
			{
				return new esQueryItem(this, RegisterMetadata.ColumnNames.CreateDate, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("RegisterCollection")]
	public partial class RegisterCollection : esRegisterCollection, IEnumerable<RegisterBO>
	{
		public RegisterCollection()
		{

		}
		
		public static implicit operator List<RegisterBO>(RegisterCollection coll)
		{
			List<RegisterBO> list = new List<RegisterBO>();
			
			foreach (RegisterBO emp in coll)
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
				return  RegisterMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RegisterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new RegisterBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new RegisterBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public RegisterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegisterQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(RegisterQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public RegisterBO AddNew()
		{
			RegisterBO entity = base.AddNewEntity() as RegisterBO;
			
			return entity;
		}

		public RegisterBO FindByPrimaryKey(System.Int32 registerID)
		{
			return base.FindByPrimaryKey(registerID) as RegisterBO;
		}


		#region IEnumerable<RegisterBO> Members

		IEnumerator<RegisterBO> IEnumerable<RegisterBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as RegisterBO;
			}
		}

		#endregion
		
		private RegisterQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Register' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("RegisterBO ({RegisterID})")]
	[Serializable]
	public partial class RegisterBO : esRegisterBO
	{
		public RegisterBO()
		{

		}
	
		public RegisterBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return RegisterMetadata.Meta();
			}
		}
		
		
		
		override protected esRegisterQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new RegisterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public RegisterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new RegisterQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(RegisterQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private RegisterQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class RegisterQuery : esRegisterQuery
	{
		public RegisterQuery()
		{

		}		
		
		public RegisterQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "RegisterQuery";
        }
		
			
	}


	[Serializable]
	public partial class RegisterMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected RegisterMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(RegisterMetadata.ColumnNames.RegisterID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = RegisterMetadata.PropertyNames.RegisterID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.FName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.FName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.LName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.LName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Address, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.City, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.State, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.State;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Zip, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Zip;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.BusinessName, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.BusinessName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.BusinessType, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.BusinessType;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.BusinessSize, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = RegisterMetadata.PropertyNames.BusinessSize;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.BestTimeToContact, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.BestTimeToContact;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Email, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Phone, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Country, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.IdData, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.IdData;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.UserName, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.UserName;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.Password, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.StatusUCode, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.StatusUCode;
			c.CharacterMaxLength = 25;
			c.HasDefault = true;
			c.Default = @"('PENDING')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.LastUpdateBy, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.LastUpdateBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.LastUpdate, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.LastUpdate;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.CreatedBy, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			_columns.Add(c);
				
			c = new esColumnMetadata(RegisterMetadata.ColumnNames.CreateDate, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = RegisterMetadata.PropertyNames.CreateDate;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
		}
		#endregion	
	
		static public RegisterMetadata Meta()
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
			 public const string RegisterID = "RegisterID";
			 public const string FName = "FName";
			 public const string LName = "LName";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string State = "State";
			 public const string Zip = "Zip";
			 public const string BusinessName = "BusinessName";
			 public const string BusinessType = "BusinessType";
			 public const string BusinessSize = "BusinessSize";
			 public const string BestTimeToContact = "BestTimeToContact";
			 public const string Email = "Email";
			 public const string Phone = "Phone";
			 public const string Country = "Country";
			 public const string IdData = "ID_DATA";
			 public const string UserName = "UserName";
			 public const string Password = "Password";
			 public const string StatusUCode = "StatusUCode";
			 public const string LastUpdateBy = "LastUpdateBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreateDate = "CreateDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string RegisterID = "RegisterID";
			 public const string FName = "FName";
			 public const string LName = "LName";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string State = "State";
			 public const string Zip = "Zip";
			 public const string BusinessName = "BusinessName";
			 public const string BusinessType = "BusinessType";
			 public const string BusinessSize = "BusinessSize";
			 public const string BestTimeToContact = "BestTimeToContact";
			 public const string Email = "Email";
			 public const string Phone = "Phone";
			 public const string Country = "Country";
			 public const string IdData = "IdData";
			 public const string UserName = "UserName";
			 public const string Password = "Password";
			 public const string StatusUCode = "StatusUCode";
			 public const string LastUpdateBy = "LastUpdateBy";
			 public const string LastUpdate = "LastUpdate";
			 public const string CreatedBy = "CreatedBy";
			 public const string CreateDate = "CreateDate";
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
			lock (typeof(RegisterMetadata))
			{
				if(RegisterMetadata.mapDelegates == null)
				{
					RegisterMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (RegisterMetadata.meta == null)
				{
					RegisterMetadata.meta = new RegisterMetadata();
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
				

				meta.AddTypeMap("RegisterID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("FName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("State", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("Zip", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessSize", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("BestTimeToContact", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Email", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IdData", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("UserName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Password", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("StatusUCode", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdateBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDate", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "Register";
				meta.Destination = "Register";
				
				meta.spInsert = "proc_RegisterInsert";				
				meta.spUpdate = "proc_RegisterUpdate";		
				meta.spDelete = "proc_RegisterDelete";
				meta.spLoadAll = "proc_RegisterLoadAll";
				meta.spLoadByPrimaryKey = "proc_RegisterLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private RegisterMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
