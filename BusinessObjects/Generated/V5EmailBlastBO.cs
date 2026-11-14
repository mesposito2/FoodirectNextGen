/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/11/2023 2:44:55 PM
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
	abstract public class esV5EmailBlastCollection : esEntityCollection
	{
		public esV5EmailBlastCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "V5EmailBlastCollection";
		}

		#region Query Logic
		protected void InitQuery(esV5EmailBlastQuery query)
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
			this.InitQuery(query as esV5EmailBlastQuery);
		}
		#endregion
		
		virtual public V5EmailBlastBO DetachEntity(V5EmailBlastBO entity)
		{
			return base.DetachEntity(entity) as V5EmailBlastBO;
		}
		
		virtual public V5EmailBlastBO AttachEntity(V5EmailBlastBO entity)
		{
			return base.AttachEntity(entity) as V5EmailBlastBO;
		}
		
		virtual public void Combine(V5EmailBlastCollection collection)
		{
			base.Combine(collection);
		}
		
		new public V5EmailBlastBO this[int index]
		{
			get
			{
				return base[index] as V5EmailBlastBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(V5EmailBlastBO);
		}
	}



	[Serializable]
	abstract public class esV5EmailBlastBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esV5EmailBlastQuery GetDynamicQuery()
		{
			return null;
		}

		public esV5EmailBlastBO()
		{

		}

		public esV5EmailBlastBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 emailBlastID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 emailBlastID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(emailBlastID);
			else
				return LoadByPrimaryKeyStoredProcedure(emailBlastID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 emailBlastID)
		{
			esV5EmailBlastQuery query = this.GetDynamicQuery();
			query.Where(query.EmailBlastID == emailBlastID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 emailBlastID)
		{
			esParameters parms = new esParameters();
			parms.Add("EmailBlastID",emailBlastID);
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
						case "EmailBlastID": this.str.EmailBlastID = (string)value; break;							
						case "CreatedByDate": this.str.CreatedByDate = (string)value; break;							
						case "CreatedBy": this.str.CreatedBy = (string)value; break;							
						case "SendDate": this.str.SendDate = (string)value; break;							
						case "StatusUCODE": this.str.StatusUCODE = (string)value; break;							
						case "Subject": this.str.Subject = (string)value; break;							
						case "EmailFrom": this.str.EmailFrom = (string)value; break;							
						case "ToUCODE": this.str.ToUCODE = (string)value; break;							
						case "ToOther": this.str.ToOther = (string)value; break;							
						case "ToSent": this.str.ToSent = (string)value; break;							
						case "Body": this.str.Body = (string)value; break;							
						case "OrginalEmailBlastID": this.str.OrginalEmailBlastID = (string)value; break;							
						case "LogFile": this.str.LogFile = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "EmailBlastID":
						
							if (value == null || value is System.Int32)
								this.EmailBlastID = (System.Int32?)value;
							break;
						
						case "CreatedByDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedByDate = (System.DateTime?)value;
							break;
						
						case "SendDate":
						
							if (value == null || value is System.DateTime)
								this.SendDate = (System.DateTime?)value;
							break;
						
						case "OrginalEmailBlastID":
						
							if (value == null || value is System.Int32)
								this.OrginalEmailBlastID = (System.Int32?)value;
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
		/// Maps to V5EmailBlast.EmailBlastID
		/// </summary>
		virtual public System.Int32? EmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastMetadata.ColumnNames.EmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastMetadata.ColumnNames.EmailBlastID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.EmailBlastID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.CreatedByDate
		/// </summary>
		virtual public System.DateTime? CreatedByDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastMetadata.ColumnNames.CreatedByDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastMetadata.ColumnNames.CreatedByDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.CreatedByDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.CreatedBy
		/// </summary>
		virtual public System.String CreatedBy
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.CreatedBy);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.CreatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.CreatedBy));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.SendDate
		/// </summary>
		virtual public System.DateTime? SendDate
		{
			get
			{
				return base.GetSystemDateTime(V5EmailBlastMetadata.ColumnNames.SendDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(V5EmailBlastMetadata.ColumnNames.SendDate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.SendDate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.StatusUCODE
		/// </summary>
		virtual public System.String StatusUCODE
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.StatusUCODE);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.StatusUCODE, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.StatusUCODE));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.Subject
		/// </summary>
		virtual public System.String Subject
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.Subject);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.Subject, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.Subject));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.EmailFrom
		/// </summary>
		virtual public System.String EmailFrom
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.EmailFrom);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.EmailFrom, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.EmailFrom));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToUCODE
		/// </summary>
		virtual public System.String ToUCODE
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToUCODE);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToUCODE, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.ToUCODE));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToOther
		/// </summary>
		virtual public System.String ToOther
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToOther);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToOther, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.ToOther));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.ToSent
		/// </summary>
		virtual public System.String ToSent
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.ToSent);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.ToSent, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.ToSent));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.Body
		/// </summary>
		virtual public System.String Body
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.Body);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.Body, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.Body));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.OrginalEmailBlastID
		/// </summary>
		virtual public System.Int32? OrginalEmailBlastID
		{
			get
			{
				return base.GetSystemInt32(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID);
			}
			
			set
			{
				if(base.SetSystemInt32(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.OrginalEmailBlastID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to V5EmailBlast.LogFile
		/// </summary>
		virtual public System.String LogFile
		{
			get
			{
				return base.GetSystemString(V5EmailBlastMetadata.ColumnNames.LogFile);
			}
			
			set
			{
				if(base.SetSystemString(V5EmailBlastMetadata.ColumnNames.LogFile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(V5EmailBlastMetadata.PropertyNames.LogFile));
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
			public esStrings(esV5EmailBlastBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String EmailBlastID
			{
				get
				{
					System.Int32? data = entity.EmailBlastID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EmailBlastID = null;
					else entity.EmailBlastID = Convert.ToInt32(value);
				}
			}
				
			public System.String CreatedByDate
			{
				get
				{
					System.DateTime? data = entity.CreatedByDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedByDate = null;
					else entity.CreatedByDate = Convert.ToDateTime(value);
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
				
			public System.String SendDate
			{
				get
				{
					System.DateTime? data = entity.SendDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SendDate = null;
					else entity.SendDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String StatusUCODE
			{
				get
				{
					System.String data = entity.StatusUCODE;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StatusUCODE = null;
					else entity.StatusUCODE = Convert.ToString(value);
				}
			}
				
			public System.String Subject
			{
				get
				{
					System.String data = entity.Subject;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Subject = null;
					else entity.Subject = Convert.ToString(value);
				}
			}
				
			public System.String EmailFrom
			{
				get
				{
					System.String data = entity.EmailFrom;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EmailFrom = null;
					else entity.EmailFrom = Convert.ToString(value);
				}
			}
				
			public System.String ToUCODE
			{
				get
				{
					System.String data = entity.ToUCODE;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ToUCODE = null;
					else entity.ToUCODE = Convert.ToString(value);
				}
			}
				
			public System.String ToOther
			{
				get
				{
					System.String data = entity.ToOther;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ToOther = null;
					else entity.ToOther = Convert.ToString(value);
				}
			}
				
			public System.String ToSent
			{
				get
				{
					System.String data = entity.ToSent;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ToSent = null;
					else entity.ToSent = Convert.ToString(value);
				}
			}
				
			public System.String Body
			{
				get
				{
					System.String data = entity.Body;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Body = null;
					else entity.Body = Convert.ToString(value);
				}
			}
				
			public System.String OrginalEmailBlastID
			{
				get
				{
					System.Int32? data = entity.OrginalEmailBlastID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OrginalEmailBlastID = null;
					else entity.OrginalEmailBlastID = Convert.ToInt32(value);
				}
			}
				
			public System.String LogFile
			{
				get
				{
					System.String data = entity.LogFile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LogFile = null;
					else entity.LogFile = Convert.ToString(value);
				}
			}
			

			private esV5EmailBlastBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esV5EmailBlastQuery query)
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
				throw new Exception("esV5EmailBlastBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esV5EmailBlastQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastMetadata.Meta();
			}
		}	
		

		public esQueryItem EmailBlastID
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.EmailBlastID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem CreatedByDate
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.CreatedByDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem CreatedBy
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.CreatedBy, esSystemType.String);
			}
		} 
		
		public esQueryItem SendDate
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.SendDate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem StatusUCODE
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.StatusUCODE, esSystemType.String);
			}
		} 
		
		public esQueryItem Subject
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.Subject, esSystemType.String);
			}
		} 
		
		public esQueryItem EmailFrom
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.EmailFrom, esSystemType.String);
			}
		} 
		
		public esQueryItem ToUCODE
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToUCODE, esSystemType.String);
			}
		} 
		
		public esQueryItem ToOther
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToOther, esSystemType.String);
			}
		} 
		
		public esQueryItem ToSent
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.ToSent, esSystemType.String);
			}
		} 
		
		public esQueryItem Body
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.Body, esSystemType.String);
			}
		} 
		
		public esQueryItem OrginalEmailBlastID
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem LogFile
		{
			get
			{
				return new esQueryItem(this, V5EmailBlastMetadata.ColumnNames.LogFile, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("V5EmailBlastCollection")]
	public partial class V5EmailBlastCollection : esV5EmailBlastCollection, IEnumerable<V5EmailBlastBO>
	{
		public V5EmailBlastCollection()
		{

		}
		
		public static implicit operator List<V5EmailBlastBO>(V5EmailBlastCollection coll)
		{
			List<V5EmailBlastBO> list = new List<V5EmailBlastBO>();
			
			foreach (V5EmailBlastBO emp in coll)
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
				return  V5EmailBlastMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new V5EmailBlastBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new V5EmailBlastBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public V5EmailBlastQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(V5EmailBlastQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public V5EmailBlastBO AddNew()
		{
			V5EmailBlastBO entity = base.AddNewEntity() as V5EmailBlastBO;
			
			return entity;
		}

		public V5EmailBlastBO FindByPrimaryKey(System.Int32 emailBlastID)
		{
			return base.FindByPrimaryKey(emailBlastID) as V5EmailBlastBO;
		}


		#region IEnumerable<V5EmailBlastBO> Members

		IEnumerator<V5EmailBlastBO> IEnumerable<V5EmailBlastBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as V5EmailBlastBO;
			}
		}

		#endregion
		
		private V5EmailBlastQuery query;
	}


	/// <summary>
	/// Encapsulates the 'V5EmailBlast' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("V5EmailBlastBO ({EmailBlastID})")]
	[Serializable]
	public partial class V5EmailBlastBO : esV5EmailBlastBO
	{
		public V5EmailBlastBO()
		{

		}
	
		public V5EmailBlastBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return V5EmailBlastMetadata.Meta();
			}
		}
		
		
		
		override protected esV5EmailBlastQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new V5EmailBlastQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public V5EmailBlastQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new V5EmailBlastQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(V5EmailBlastQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private V5EmailBlastQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class V5EmailBlastQuery : esV5EmailBlastQuery
	{
		public V5EmailBlastQuery()
		{

		}		
		
		public V5EmailBlastQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "V5EmailBlastQuery";
        }
		
			
	}


	[Serializable]
	public partial class V5EmailBlastMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected V5EmailBlastMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.EmailBlastID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.EmailBlastID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.CreatedByDate, 1, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.CreatedByDate;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.CreatedBy, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.CreatedBy;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.SendDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.SendDate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.StatusUCODE, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.StatusUCODE;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.Subject, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.Subject;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.EmailFrom, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.EmailFrom;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToUCODE, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToUCODE;
			c.CharacterMaxLength = 100;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToOther, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToOther;
			c.CharacterMaxLength = 500;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.ToSent, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.ToSent;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.Body, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.Body;
			c.CharacterMaxLength = 2147483647;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.OrginalEmailBlastID, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.OrginalEmailBlastID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(V5EmailBlastMetadata.ColumnNames.LogFile, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = V5EmailBlastMetadata.PropertyNames.LogFile;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public V5EmailBlastMetadata Meta()
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
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string SendDate = "SendDate";
			 public const string StatusUCODE = "StatusUCODE";
			 public const string Subject = "Subject";
			 public const string EmailFrom = "EmailFrom";
			 public const string ToUCODE = "ToUCODE";
			 public const string ToOther = "ToOther";
			 public const string ToSent = "ToSent";
			 public const string Body = "Body";
			 public const string OrginalEmailBlastID = "OrginalEmailBlastID";
			 public const string LogFile = "LogFile";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string EmailBlastID = "EmailBlastID";
			 public const string CreatedByDate = "CreatedByDate";
			 public const string CreatedBy = "CreatedBy";
			 public const string SendDate = "SendDate";
			 public const string StatusUCODE = "StatusUCODE";
			 public const string Subject = "Subject";
			 public const string EmailFrom = "EmailFrom";
			 public const string ToUCODE = "ToUCODE";
			 public const string ToOther = "ToOther";
			 public const string ToSent = "ToSent";
			 public const string Body = "Body";
			 public const string OrginalEmailBlastID = "OrginalEmailBlastID";
			 public const string LogFile = "LogFile";
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
			lock (typeof(V5EmailBlastMetadata))
			{
				if(V5EmailBlastMetadata.mapDelegates == null)
				{
					V5EmailBlastMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (V5EmailBlastMetadata.meta == null)
				{
					V5EmailBlastMetadata.meta = new V5EmailBlastMetadata();
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
				

				meta.AddTypeMap("EmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CreatedByDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SendDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("StatusUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Subject", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("EmailFrom", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToOther", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ToSent", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("Body", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OrginalEmailBlastID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LogFile", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "V5EmailBlast";
				meta.Destination = "V5EmailBlast";
				
				meta.spInsert = "proc_V5EmailBlastInsert";				
				meta.spUpdate = "proc_V5EmailBlastUpdate";		
				meta.spDelete = "proc_V5EmailBlastDelete";
				meta.spLoadAll = "proc_V5EmailBlastLoadAll";
				meta.spLoadByPrimaryKey = "proc_V5EmailBlastLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private V5EmailBlastMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
