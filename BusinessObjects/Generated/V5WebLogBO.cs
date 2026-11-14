/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 10/29/2023 2:48:03 PM
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
	abstract public class esV5WebLogCollection : esEntityCollection
	{
		public esV5WebLogCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5WebLogCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5WebLogQuery query)
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
			this.InitQuery(query as esV5WebLogQuery);
		}
		#endregion
		
		virtual public V5WebLogBO DetachEntity(V5WebLogBO entity)
		{
			return base.DetachEntity(entity) as V5WebLogBO;
		}
		
		virtual public V5WebLogBO AttachEntity(V5WebLogBO entity)
		{
			return base.AttachEntity(entity) as V5WebLogBO;
		}
		
		virtual public void Combine(V5WebLogCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5WebLogBO this[int index]
		{
			get
			{
				return base[index] as V5WebLogBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5WebLogBO);
		}
	}



	[Serializable]
	abstract public class esV5WebLogBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5WebLogQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5WebLogBO()
		{

		}

		public esV5WebLogBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 weblogID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(weblogID);
			else
				return LoadByPrimaryKeyStoredProcedure(weblogID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 weblogID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(weblogID);
			else
				return LoadByPrimaryKeyStoredProcedure(weblogID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 weblogID)
		{
			esV5WebLogQuery query = this.GetDynamicQuery();
			query.Where(query.WeblogID == weblogID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 weblogID)
		{
			esParameters parms = new esParameters();
			parms.Add("WeblogID",weblogID);
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
						case "WeblogID": this.str.WeblogID = (string)value; break;							
						case "Ip": this.str.Ip = (string)value; break;							
						case "CreateDateTime": this.str.CreateDateTime = (string)value; break;							
						case "Message": this.str.Message = (string)value; break;							
						case "Type": this.str.Type = (string)value; break;							
						case "Action": this.str.Action = (string)value; break;							
						case "User": this.str.User = (string)value; break;							
						case "Page": this.str.Page = (string)value; break;							
						case "Reported": this.str.Reported = (string)value; break;							
						case "IsAjax": this.str.IsAjax = (string)value; break;							
						case "HttpReferer": this.str.HttpReferer = (string)value; break;							
						case "HttpUserAgent": this.str.HttpUserAgent = (string)value; break;							
						case "Https": this.str.Https = (string)value; break;							
						case "ResponseCode": this.str.ResponseCode = (string)value; break;							
						case "IsNotFound": this.str.IsNotFound = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "WeblogID":
						
							if (value == null || value is System.Int32)
								this.WeblogID = (System.Int32?)value;
							break;
						
						case "CreateDateTime":
						
							if (value == null || value is System.DateTime)
								this.CreateDateTime = (System.DateTime?)value;
							break;
						
						case "Reported":
						
							if (value == null || value is System.Boolean)
								this.Reported = (System.Boolean?)value;
							break;
						
						case "IsAjax":
						
							if (value == null || value is System.Boolean)
								this.IsAjax = (System.Boolean?)value;
							break;
						
						case "ResponseCode":
						
							if (value == null || value is System.Int32)
								this.ResponseCode = (System.Int32?)value;
							break;
						
						case "IsNotFound":
						
							if (value == null || value is System.Boolean)
								this.IsNotFound = (System.Boolean?)value;
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
		/// Maps to v5WebLog.WeblogID
		/// </summary>
		virtual public System.Int32? WeblogID
		{
			get
			{
				return base.GetSystemInt32(V5WebLogMetadata.ColumnNames.WeblogID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5WebLogMetadata.ColumnNames.WeblogID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.WeblogID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.ip
		/// </summary>
		virtual public System.String Ip
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Ip);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Ip, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Ip));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.createDateTime
		/// </summary>
		virtual public System.DateTime? CreateDateTime
		{
			get
			{
				return base.GetSystemDateTime(V5WebLogMetadata.ColumnNames.CreateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5WebLogMetadata.ColumnNames.CreateDateTime, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.CreateDateTime));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.message
		/// </summary>
		virtual public System.String Message
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Message);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Message, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Message));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.type
		/// </summary>
		virtual public System.String Type
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Type);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Type, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Type));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.action
		/// </summary>
		virtual public System.String Action
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Action);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Action, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Action));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.User
		/// </summary>
		virtual public System.String User
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.User);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.User, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.User));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Page
		/// </summary>
		virtual public System.String Page
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Page);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Page, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Page));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Reported
		/// </summary>
		virtual public System.Boolean? Reported
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.Reported);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.Reported, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Reported));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.IsAjax
		/// </summary>
		virtual public System.Boolean? IsAjax
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.IsAjax);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.IsAjax, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.IsAjax));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.HttpReferer
		/// </summary>
		virtual public System.String HttpReferer
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.HttpReferer);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.HttpReferer, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.HttpReferer));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.HttpUserAgent
		/// </summary>
		virtual public System.String HttpUserAgent
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.HttpUserAgent);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.HttpUserAgent, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.HttpUserAgent));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.Https
		/// </summary>
		virtual public System.String Https
		{
			get
			{
				return base.GetSystemString(V5WebLogMetadata.ColumnNames.Https);
			}
			
			set
			{
				if(base.SetSystemString(V5WebLogMetadata.ColumnNames.Https, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.Https));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.ResponseCode
		/// </summary>
		virtual public System.Int32? ResponseCode
		{
			get
			{
				return base.GetSystemInt32(V5WebLogMetadata.ColumnNames.ResponseCode);
			}
			
			set
			{
				if(base.SetSystemInt32(V5WebLogMetadata.ColumnNames.ResponseCode, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.ResponseCode));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to v5WebLog.IsNotFound
		/// </summary>
		virtual public System.Boolean? IsNotFound
		{
			get
			{
				return base.GetSystemBoolean(V5WebLogMetadata.ColumnNames.IsNotFound);
			}
			
			set
			{
				if(base.SetSystemBoolean(V5WebLogMetadata.ColumnNames.IsNotFound, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5WebLogMetadata.PropertyNames.IsNotFound));
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
			public esStrings(esV5WebLogBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String WeblogID
			{
				get
				{
					System.Int32? data = entity.WeblogID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.WeblogID = null;
					else entity.WeblogID = Convert.ToInt32(value);
				}
			}
				
			public System.String Ip
			{
				get
				{
					System.String data = entity.Ip;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Ip = null;
					else entity.Ip = Convert.ToString(value);
				}
			}
				
			public System.String CreateDateTime
			{
				get
				{
					System.DateTime? data = entity.CreateDateTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreateDateTime = null;
					else entity.CreateDateTime = Convert.ToDateTime(value);
				}
			}
				
			public System.String Message
			{
				get
				{
					System.String data = entity.Message;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Message = null;
					else entity.Message = Convert.ToString(value);
				}
			}
				
			public System.String Type
			{
				get
				{
					System.String data = entity.Type;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Type = null;
					else entity.Type = Convert.ToString(value);
				}
			}
				
			public System.String Action
			{
				get
				{
					System.String data = entity.Action;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Action = null;
					else entity.Action = Convert.ToString(value);
				}
			}
				
			public System.String User
			{
				get
				{
					System.String data = entity.User;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.User = null;
					else entity.User = Convert.ToString(value);
				}
			}
				
			public System.String Page
			{
				get
				{
					System.String data = entity.Page;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Page = null;
					else entity.Page = Convert.ToString(value);
				}
			}
				
			public System.String Reported
			{
				get
				{
					System.Boolean? data = entity.Reported;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Reported = null;
					else entity.Reported = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsAjax
			{
				get
				{
					System.Boolean? data = entity.IsAjax;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsAjax = null;
					else entity.IsAjax = Convert.ToBoolean(value);
				}
			}
				
			public System.String HttpReferer
			{
				get
				{
					System.String data = entity.HttpReferer;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HttpReferer = null;
					else entity.HttpReferer = Convert.ToString(value);
				}
			}
				
			public System.String HttpUserAgent
			{
				get
				{
					System.String data = entity.HttpUserAgent;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.HttpUserAgent = null;
					else entity.HttpUserAgent = Convert.ToString(value);
				}
			}
				
			public System.String Https
			{
				get
				{
					System.String data = entity.Https;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Https = null;
					else entity.Https = Convert.ToString(value);
				}
			}
				
			public System.String ResponseCode
			{
				get
				{
					System.Int32? data = entity.ResponseCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ResponseCode = null;
					else entity.ResponseCode = Convert.ToInt32(value);
				}
			}
				
			public System.String IsNotFound
			{
				get
				{
					System.Boolean? data = entity.IsNotFound;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsNotFound = null;
					else entity.IsNotFound = Convert.ToBoolean(value);
				}
			}
			

			private esV5WebLogBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5WebLogQuery query)
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
				throw new Exception("esV5WebLogBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esV5WebLogQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5WebLogMetadata.Meta();
			}
		}	
		

		public esQueryItem WeblogID
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.WeblogID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Ip
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Ip, esSystemType.String);
			}
		} 
		
		public esQueryItem CreateDateTime
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.CreateDateTime, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Message
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Message, esSystemType.String);
			}
		} 
		
		public esQueryItem Type
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Type, esSystemType.String);
			}
		} 
		
		public esQueryItem Action
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Action, esSystemType.String);
			}
		} 
		
		public esQueryItem User
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.User, esSystemType.String);
			}
		} 
		
		public esQueryItem Page
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Page, esSystemType.String);
			}
		} 
		
		public esQueryItem Reported
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Reported, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem IsAjax
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.IsAjax, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem HttpReferer
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.HttpReferer, esSystemType.String);
			}
		} 
		
		public esQueryItem HttpUserAgent
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.HttpUserAgent, esSystemType.String);
			}
		} 
		
		public esQueryItem Https
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.Https, esSystemType.String);
			}
		} 
		
		public esQueryItem ResponseCode
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.ResponseCode, esSystemType.Int32);
			}
		} 
		
		public esQueryItem IsNotFound
		{
			get
			{
				return new esQueryItem(this, V5WebLogMetadata.ColumnNames.IsNotFound, esSystemType.Boolean);
			}
		} 
		
	}



	[Serializable]
	[XmlType("V5WebLogCollection")]
	public partial class V5WebLogCollection : esV5WebLogCollection, IEnumerable<V5WebLogBO>
	{
		public V5WebLogCollection()
		{

		}
		
		public static implicit operator List<V5WebLogBO>(V5WebLogCollection coll)
		{
			List<V5WebLogBO> list = new List<V5WebLogBO>();
			
			foreach (V5WebLogBO emp in coll)
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
				return  V5WebLogMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5WebLogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5WebLogBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5WebLogBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5WebLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5WebLogQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5WebLogQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5WebLogBO AddNew()
		{
			V5WebLogBO entity = base.AddNewEntity() as V5WebLogBO;
			
			return entity;
		}

		public V5WebLogBO FindByPrimaryKey(System.Int32 weblogID)
		{
			return base.FindByPrimaryKey(weblogID) as V5WebLogBO;
		}


		#region IEnumerable<V5WebLogBO> Members

		IEnumerator<V5WebLogBO> IEnumerable<V5WebLogBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5WebLogBO;
			}
		}

		#endregion
		
		private V5WebLogQuery query;
	}


	/// <summary>
	/// Encapsulates the 'v5WebLog' table
	/// </summary>

	[Serializable]
	public partial class V5WebLogBO : esV5WebLogBO
	{
		public V5WebLogBO()
		{

		}
	
		public V5WebLogBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5WebLogMetadata.Meta();
			}
		}
		
		
		
		override protected esV5WebLogQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5WebLogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5WebLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5WebLogQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5WebLogQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5WebLogQuery query;
	}



	[Serializable]
		
	public partial class V5WebLogQuery : esV5WebLogQuery
	{
		public V5WebLogQuery()
		{

		}		
		
		public V5WebLogQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5WebLogQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5WebLogMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5WebLogMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.WeblogID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5WebLogMetadata.PropertyNames.WeblogID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Ip, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Ip;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.CreateDateTime, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5WebLogMetadata.PropertyNames.CreateDateTime;
			c.HasDefault = true;
			c.Default = @"(getdate())";
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Message, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Message;
			c.CharacterMaxLength = 1073741823;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Type, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Type;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Action, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Action;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.User, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.User;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Page, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Page;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Reported, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Reported;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.IsAjax, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.IsAjax;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.HttpReferer, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.HttpReferer;
			c.CharacterMaxLength = 300;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.HttpUserAgent, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.HttpUserAgent;
			c.CharacterMaxLength = 300;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.Https, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = V5WebLogMetadata.PropertyNames.Https;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('')";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.ResponseCode, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5WebLogMetadata.PropertyNames.ResponseCode;
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5WebLogMetadata.ColumnNames.IsNotFound, 14, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = V5WebLogMetadata.PropertyNames.IsNotFound;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5WebLogMetadata Meta()
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
			 public const string WeblogID = "WeblogID";
			 public const string Ip = "ip";
			 public const string CreateDateTime = "createDateTime";
			 public const string Message = "message";
			 public const string Type = "type";
			 public const string Action = "action";
			 public const string User = "User";
			 public const string Page = "Page";
			 public const string Reported = "Reported";
			 public const string IsAjax = "IsAjax";
			 public const string HttpReferer = "HttpReferer";
			 public const string HttpUserAgent = "HttpUserAgent";
			 public const string Https = "Https";
			 public const string ResponseCode = "ResponseCode";
			 public const string IsNotFound = "IsNotFound";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string WeblogID = "WeblogID";
			 public const string Ip = "Ip";
			 public const string CreateDateTime = "CreateDateTime";
			 public const string Message = "Message";
			 public const string Type = "Type";
			 public const string Action = "Action";
			 public const string User = "User";
			 public const string Page = "Page";
			 public const string Reported = "Reported";
			 public const string IsAjax = "IsAjax";
			 public const string HttpReferer = "HttpReferer";
			 public const string HttpUserAgent = "HttpUserAgent";
			 public const string Https = "Https";
			 public const string ResponseCode = "ResponseCode";
			 public const string IsNotFound = "IsNotFound";
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
			lock (typeof(V5WebLogMetadata))
			{
				if(V5WebLogMetadata.mapDelegates == null)
				{
					V5WebLogMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5WebLogMetadata.meta == null)
				{
					V5WebLogMetadata.meta = new V5WebLogMetadata();
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
				

				meta.AddTypeMap("WeblogID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Ip", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("CreateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Message", new esTypeMap("ntext", "System.String"));
				meta.AddTypeMap("Type", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Action", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("User", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Page", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Reported", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsAjax", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("HttpReferer", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("HttpUserAgent", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Https", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ResponseCode", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("IsNotFound", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "v5WebLog";
				meta.Destination = "v5WebLog";
				
				meta.spInsert = "proc_v5WebLogInsert";				
				meta.spUpdate = "proc_v5WebLogUpdate";		
				meta.spDelete = "proc_v5WebLogDelete";
				meta.spLoadAll = "proc_v5WebLogLoadAll";
				meta.spLoadByPrimaryKey = "proc_v5WebLogLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5WebLogMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
