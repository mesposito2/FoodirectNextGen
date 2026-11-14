
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
	/// Encapsulates the 'V5Register' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(V5RegisterBO))]	
	[XmlType("V5RegisterBO")]
	public partial class V5RegisterBO : esV5RegisterBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new V5RegisterBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 registerID)
		{
			var obj = new V5RegisterBO();
			obj.RegisterID = registerID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 registerID, esSqlAccessType sqlAccessType)
		{
			var obj = new V5RegisterBO();
			obj.RegisterID = registerID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("V5RegisterCollection")]
	public partial class V5RegisterCollection : esV5RegisterCollection, IEnumerable<V5RegisterBO>
	{
		public V5RegisterBO FindByPrimaryKey(System.Int32 registerID)
		{
			return this.SingleOrDefault(e => e.RegisterID == registerID);
		}

		
				
	}



	[Serializable]	
	public partial class V5RegisterQuery : esV5RegisterQuery
	{
		public V5RegisterQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public V5RegisterQuery(string joinAlias, out V5RegisterQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "V5RegisterQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(V5RegisterQuery query)
		{
			return V5RegisterQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator V5RegisterQuery(string query)
		{
			return (V5RegisterQuery)V5RegisterQuery.SerializeHelper.FromXml(query, typeof(V5RegisterQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esV5RegisterBO : esEntity
	{
		public esV5RegisterBO()
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
			V5RegisterQuery query = new V5RegisterQuery();
			query.Where(query.RegisterID == registerID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 registerID)
		{
			esParameters parms = new esParameters();
			parms.Add("RegisterID", registerID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to V5Register.RegisterID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? RegisterID
		{
			get
			{
				return base.GetSystemInt32(V5RegisterMetadata.ColumnNames.RegisterID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5RegisterMetadata.ColumnNames.RegisterID, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.RegisterID);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.FName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FName
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.FName);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.FName, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.FName);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.LName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LName
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.LName);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.LName, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.LName);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Address);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.City);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.State
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String State
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.State);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.State, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.State);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Zip
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Zip
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Zip);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Zip, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Zip);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.BusinessName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BusinessName
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.BusinessName);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.BusinessName, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.BusinessName);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.BusinessType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BusinessType
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.BusinessType);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.BusinessType, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.BusinessType);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.BusinessSize
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BusinessSize
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.BusinessSize);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.BusinessSize, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.BusinessSize);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.BestTimeToContact
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String BestTimeToContact
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.BestTimeToContact);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.BestTimeToContact, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.BestTimeToContact);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Email);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Phone);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Country);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.ID_DATA
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String IdData
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.IdData);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.IdData, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.IdData);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.UserName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserName
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.UserName);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.UserName, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.UserName);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Password, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Password);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.StatusUCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String StatusUCode
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.StatusUCode);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.StatusUCode, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.StatusUCode);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.LastUpdateBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateBy
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.LastUpdateBy);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.LastUpdateBy, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.LastUpdateBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.LastUpdate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdate
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.LastUpdate, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.LastUpdate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.CreatedBy
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.CreatedBy, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.CreatedBy);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.CreateDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CreateDate
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.CreateDate);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.CreateDate, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.CreateDate);
				}
			}
		}
		
		/// <summary>
		/// Maps to V5Register.Address2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address2
		{
			get
			{
				return base.GetSystemString(V5RegisterMetadata.ColumnNames.Address2);
			}
			
			set
			{
				if(base.SetSystemString(V5RegisterMetadata.ColumnNames.Address2, value))
				{
					OnPropertyChanged(V5RegisterMetadata.PropertyNames.Address2);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return V5RegisterMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public V5RegisterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5RegisterQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5RegisterQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(V5RegisterQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5RegisterQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private V5RegisterQuery query;		
	}



	[Serializable]
	abstract public partial class esV5RegisterCollection : esEntityCollection<V5RegisterBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5RegisterMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "V5RegisterCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public V5RegisterQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5RegisterQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(V5RegisterQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5RegisterQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(V5RegisterQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((V5RegisterQuery)query);
		}

		#endregion
		
		private V5RegisterQuery query;
	}



	[Serializable]
	abstract public partial class esV5RegisterQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5RegisterMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "RegisterID": return this.RegisterID;
				case "FName": return this.FName;
				case "LName": return this.LName;
				case "Address": return this.Address;
				case "City": return this.City;
				case "State": return this.State;
				case "Zip": return this.Zip;
				case "BusinessName": return this.BusinessName;
				case "BusinessType": return this.BusinessType;
				case "BusinessSize": return this.BusinessSize;
				case "BestTimeToContact": return this.BestTimeToContact;
				case "Email": return this.Email;
				case "Phone": return this.Phone;
				case "Country": return this.Country;
				case "IdData": return this.IdData;
				case "UserName": return this.UserName;
				case "Password": return this.Password;
				case "StatusUCode": return this.StatusUCode;
				case "LastUpdateBy": return this.LastUpdateBy;
				case "LastUpdate": return this.LastUpdate;
				case "CreatedBy": return this.CreatedBy;
				case "CreateDate": return this.CreateDate;
				case "Address2": return this.Address2;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem RegisterID
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.RegisterID, esSystemType.Int32); }
		} 
		
		public esQueryItem FName
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.FName, esSystemType.String); }
		} 
		
		public esQueryItem LName
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.LName, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem State
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.State, esSystemType.String); }
		} 
		
		public esQueryItem Zip
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Zip, esSystemType.String); }
		} 
		
		public esQueryItem BusinessName
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.BusinessName, esSystemType.String); }
		} 
		
		public esQueryItem BusinessType
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.BusinessType, esSystemType.String); }
		} 
		
		public esQueryItem BusinessSize
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.BusinessSize, esSystemType.String); }
		} 
		
		public esQueryItem BestTimeToContact
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.BestTimeToContact, esSystemType.String); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem IdData
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.IdData, esSystemType.String); }
		} 
		
		public esQueryItem UserName
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.UserName, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem StatusUCode
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.StatusUCode, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdateBy
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.LastUpdateBy, esSystemType.String); }
		} 
		
		public esQueryItem LastUpdate
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.LastUpdate, esSystemType.String); }
		} 
		
		public esQueryItem CreatedBy
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.CreatedBy, esSystemType.String); }
		} 
		
		public esQueryItem CreateDate
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.CreateDate, esSystemType.String); }
		} 
		
		public esQueryItem Address2
		{
			get { return new esQueryItem(this, V5RegisterMetadata.ColumnNames.Address2, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class V5RegisterBO : esV5RegisterBO
	{

		
		
	}
	



	[Serializable]
	public partial class V5RegisterMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5RegisterMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.RegisterID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5RegisterMetadata.PropertyNames.RegisterID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.FName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.FName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.LName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.LName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Address, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.City, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.City;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.State, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.State;
			c.CharacterMaxLength = 2;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Zip, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Zip;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.BusinessName, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.BusinessName;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.BusinessType, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.BusinessType;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.BusinessSize, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.BusinessSize;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.BestTimeToContact, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.BestTimeToContact;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Email, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Phone, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Country, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.IdData, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.IdData;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.UserName, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.UserName;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Password, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 25;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.StatusUCode, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.StatusUCode;
			c.CharacterMaxLength = 25;
			c.HasDefault = true;
			c.Default = @"('PENDING')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.LastUpdateBy, 18, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.LastUpdateBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.LastUpdate, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.LastUpdate;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.CreatedBy, 20, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('SYS')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.CreateDate, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.CreateDate;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			m_columns.Add(c);
				
			c = new esColumnMetadata(V5RegisterMetadata.ColumnNames.Address2, 22, typeof(System.String), esSystemType.String);
			c.PropertyName = V5RegisterMetadata.PropertyNames.Address2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public V5RegisterMetadata Meta()
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
			 public const string Address2 = "Address2";
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
			 public const string Address2 = "Address2";
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
			lock (typeof(V5RegisterMetadata))
			{
				if(V5RegisterMetadata.mapDelegates == null)
				{
					V5RegisterMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5RegisterMetadata.meta == null)
				{
					V5RegisterMetadata.meta = new V5RegisterMetadata();
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


				meta.AddTypeMap("RegisterID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("FName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("State", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("Zip", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("BusinessSize", new esTypeMap("varchar", "System.String"));
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
				meta.AddTypeMap("Address2", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "V5Register";
				meta.Destination = "V5Register";
				
				meta.spInsert = "proc_V5RegisterInsert";				
				meta.spUpdate = "proc_V5RegisterUpdate";		
				meta.spDelete = "proc_V5RegisterDelete";
				meta.spLoadAll = "proc_V5RegisterLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5RegisterLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5RegisterMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
