/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 6/1/2018 6:15:39 PM
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
	abstract public class esSystemCollection : esEntityCollection
	{
		public esSystemCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "SystemCollection";
		}

		#region Query Logic
		protected void InitQuery(esSystemQuery query)
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
			this.InitQuery(query as esSystemQuery);
		}
		#endregion
		
		virtual public SystemBO DetachEntity(SystemBO entity)
		{
			return base.DetachEntity(entity) as SystemBO;
		}
		
		virtual public SystemBO AttachEntity(SystemBO entity)
		{
			return base.AttachEntity(entity) as SystemBO;
		}
		
		virtual public void Combine(SystemCollection collection)
		{
			base.Combine(collection);
		}
		
		new public SystemBO this[int index]
		{
			get
			{
				return base[index] as SystemBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(SystemBO);
		}
	}



	[Serializable]
	abstract public class esSystemBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esSystemQuery GetDynamicQuery()
		{
			return null;
		}

		public esSystemBO()
		{

		}

		public esSystemBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Guid systemID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(systemID);
			else
				return LoadByPrimaryKeyStoredProcedure(systemID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Guid systemID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(systemID);
			else
				return LoadByPrimaryKeyStoredProcedure(systemID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Guid systemID)
		{
			esSystemQuery query = this.GetDynamicQuery();
			query.Where(query.SystemID == systemID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Guid systemID)
		{
			esParameters parms = new esParameters();
			parms.Add("systemID",systemID);
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
						case "Str1": this.str.Str1 = (string)value; break;							
						case "Str2": this.str.Str2 = (string)value; break;							
						case "Str3": this.str.Str3 = (string)value; break;							
						case "Bool1": this.str.Bool1 = (string)value; break;							
						case "Bool2": this.str.Bool2 = (string)value; break;							
						case "Bool3": this.str.Bool3 = (string)value; break;							
						case "Int1": this.str.Int1 = (string)value; break;							
						case "Int2": this.str.Int2 = (string)value; break;							
						case "Int3": this.str.Int3 = (string)value; break;							
						case "Dbl1": this.str.Dbl1 = (string)value; break;							
						case "Dbl2": this.str.Dbl2 = (string)value; break;							
						case "Dbl3": this.str.Dbl3 = (string)value; break;							
						case "Displaypriceexpire": this.str.Displaypriceexpire = (string)value; break;							
						case "Lastfposcdate": this.str.Lastfposcdate = (string)value; break;							
						case "Lastfposversion": this.str.Lastfposversion = (string)value; break;							
						case "Lastfdpfile": this.str.Lastfdpfile = (string)value; break;							
						case "SystemID": this.str.SystemID = (string)value; break;							
						case "SystemUCODE": this.str.SystemUCODE = (string)value; break;							
						case "LastUpdate": this.str.LastUpdate = (string)value; break;							
						case "LastUpdatedBy": this.str.LastUpdatedBy = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Bool1":
						
							if (value == null || value is System.Boolean)
								this.Bool1 = (System.Boolean?)value;
							break;
						
						case "Bool2":
						
							if (value == null || value is System.Boolean)
								this.Bool2 = (System.Boolean?)value;
							break;
						
						case "Bool3":
						
							if (value == null || value is System.Boolean)
								this.Bool3 = (System.Boolean?)value;
							break;
						
						case "Int1":
						
							if (value == null || value is System.Int32)
								this.Int1 = (System.Int32?)value;
							break;
						
						case "Int2":
						
							if (value == null || value is System.Int32)
								this.Int2 = (System.Int32?)value;
							break;
						
						case "Int3":
						
							if (value == null || value is System.Int32)
								this.Int3 = (System.Int32?)value;
							break;
						
						case "Dbl1":
						
							if (value == null || value is System.Int32)
								this.Dbl1 = (System.Int32?)value;
							break;
						
						case "Dbl2":
						
							if (value == null || value is System.Int32)
								this.Dbl2 = (System.Int32?)value;
							break;
						
						case "Dbl3":
						
							if (value == null || value is System.Int32)
								this.Dbl3 = (System.Int32?)value;
							break;
						
						case "Displaypriceexpire":
						
							if (value == null || value is System.DateTime)
								this.Displaypriceexpire = (System.DateTime?)value;
							break;
						
						case "Lastfposcdate":
						
							if (value == null || value is System.DateTime)
								this.Lastfposcdate = (System.DateTime?)value;
							break;
						
						case "Lastfposversion":
						
							if (value == null || value is System.Int32)
								this.Lastfposversion = (System.Int32?)value;
							break;
						
						case "Lastfdpfile":
						
							if (value == null || value is System.Int32)
								this.Lastfdpfile = (System.Int32?)value;
							break;
						
						case "SystemID":
						
							if (value == null || value is System.Guid)
								this.SystemID = (System.Guid?)value;
							break;
						
						case "LastUpdate":
						
							if (value == null || value is System.DateTime)
								this.LastUpdate = (System.DateTime?)value;
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
		/// Maps to system.str1
		/// </summary>
		virtual public System.String Str1
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str1);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Str1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.str2
		/// </summary>
		virtual public System.String Str2
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str2);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Str2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.str3
		/// </summary>
		virtual public System.String Str3
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.Str3);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.Str3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Str3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool1
		/// </summary>
		virtual public System.Boolean? Bool1
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool1);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Bool1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool2
		/// </summary>
		virtual public System.Boolean? Bool2
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool2);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Bool2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.bool3
		/// </summary>
		virtual public System.Boolean? Bool3
		{
			get
			{
				return base.GetSystemBoolean(SystemMetadata.ColumnNames.Bool3);
			}
			
			set
			{
				if(base.SetSystemBoolean(SystemMetadata.ColumnNames.Bool3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Bool3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int1
		/// </summary>
		virtual public System.Int32? Int1
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int1);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Int1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int2
		/// </summary>
		virtual public System.Int32? Int2
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int2);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Int2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.int3
		/// </summary>
		virtual public System.Int32? Int3
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Int3);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Int3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Int3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl1
		/// </summary>
		virtual public System.Int32? Dbl1
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl1);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl1, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Dbl1));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl2
		/// </summary>
		virtual public System.Int32? Dbl2
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl2);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl2, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Dbl2));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.dbl3
		/// </summary>
		virtual public System.Int32? Dbl3
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Dbl3);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Dbl3, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Dbl3));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.displaypriceexpire
		/// </summary>
		virtual public System.DateTime? Displaypriceexpire
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.Displaypriceexpire);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.Displaypriceexpire, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Displaypriceexpire));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfposcdate
		/// </summary>
		virtual public System.DateTime? Lastfposcdate
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.Lastfposcdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.Lastfposcdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Lastfposcdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfposversion
		/// </summary>
		virtual public System.Int32? Lastfposversion
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Lastfposversion);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Lastfposversion, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Lastfposversion));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastfdpfile
		/// </summary>
		virtual public System.Int32? Lastfdpfile
		{
			get
			{
				return base.GetSystemInt32(SystemMetadata.ColumnNames.Lastfdpfile);
			}
			
			set
			{
				if(base.SetSystemInt32(SystemMetadata.ColumnNames.Lastfdpfile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.Lastfdpfile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.systemID
		/// </summary>
		virtual public System.Guid? SystemID
		{
			get
			{
				return base.GetSystemGuid(SystemMetadata.ColumnNames.SystemID);
			}
			
			set
			{
				if(base.SetSystemGuid(SystemMetadata.ColumnNames.SystemID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.SystemID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.systemUCODE
		/// </summary>
		virtual public System.String SystemUCODE
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.SystemUCODE);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.SystemUCODE, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.SystemUCODE));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastUpdate
		/// </summary>
		virtual public System.DateTime? LastUpdate
		{
			get
			{
				return base.GetSystemDateTime(SystemMetadata.ColumnNames.LastUpdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(SystemMetadata.ColumnNames.LastUpdate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.LastUpdate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to system.lastUpdatedBy
		/// </summary>
		virtual public System.String LastUpdatedBy
		{
			get
			{
				return base.GetSystemString(SystemMetadata.ColumnNames.LastUpdatedBy);
			}
			
			set
			{
				if(base.SetSystemString(SystemMetadata.ColumnNames.LastUpdatedBy, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(SystemMetadata.PropertyNames.LastUpdatedBy));
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
			public esStrings(esSystemBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Str1
			{
				get
				{
					System.String data = entity.Str1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Str1 = null;
					else entity.Str1 = Convert.ToString(value);
				}
			}
				
			public System.String Str2
			{
				get
				{
					System.String data = entity.Str2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Str2 = null;
					else entity.Str2 = Convert.ToString(value);
				}
			}
				
			public System.String Str3
			{
				get
				{
					System.String data = entity.Str3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Str3 = null;
					else entity.Str3 = Convert.ToString(value);
				}
			}
				
			public System.String Bool1
			{
				get
				{
					System.Boolean? data = entity.Bool1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Bool1 = null;
					else entity.Bool1 = Convert.ToBoolean(value);
				}
			}
				
			public System.String Bool2
			{
				get
				{
					System.Boolean? data = entity.Bool2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Bool2 = null;
					else entity.Bool2 = Convert.ToBoolean(value);
				}
			}
				
			public System.String Bool3
			{
				get
				{
					System.Boolean? data = entity.Bool3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Bool3 = null;
					else entity.Bool3 = Convert.ToBoolean(value);
				}
			}
				
			public System.String Int1
			{
				get
				{
					System.Int32? data = entity.Int1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Int1 = null;
					else entity.Int1 = Convert.ToInt32(value);
				}
			}
				
			public System.String Int2
			{
				get
				{
					System.Int32? data = entity.Int2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Int2 = null;
					else entity.Int2 = Convert.ToInt32(value);
				}
			}
				
			public System.String Int3
			{
				get
				{
					System.Int32? data = entity.Int3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Int3 = null;
					else entity.Int3 = Convert.ToInt32(value);
				}
			}
				
			public System.String Dbl1
			{
				get
				{
					System.Int32? data = entity.Dbl1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Dbl1 = null;
					else entity.Dbl1 = Convert.ToInt32(value);
				}
			}
				
			public System.String Dbl2
			{
				get
				{
					System.Int32? data = entity.Dbl2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Dbl2 = null;
					else entity.Dbl2 = Convert.ToInt32(value);
				}
			}
				
			public System.String Dbl3
			{
				get
				{
					System.Int32? data = entity.Dbl3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Dbl3 = null;
					else entity.Dbl3 = Convert.ToInt32(value);
				}
			}
				
			public System.String Displaypriceexpire
			{
				get
				{
					System.DateTime? data = entity.Displaypriceexpire;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Displaypriceexpire = null;
					else entity.Displaypriceexpire = Convert.ToDateTime(value);
				}
			}
				
			public System.String Lastfposcdate
			{
				get
				{
					System.DateTime? data = entity.Lastfposcdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastfposcdate = null;
					else entity.Lastfposcdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Lastfposversion
			{
				get
				{
					System.Int32? data = entity.Lastfposversion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastfposversion = null;
					else entity.Lastfposversion = Convert.ToInt32(value);
				}
			}
				
			public System.String Lastfdpfile
			{
				get
				{
					System.Int32? data = entity.Lastfdpfile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastfdpfile = null;
					else entity.Lastfdpfile = Convert.ToInt32(value);
				}
			}
				
			public System.String SystemID
			{
				get
				{
					System.Guid? data = entity.SystemID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SystemID = null;
					else entity.SystemID = new Guid(value);
				}
			}
				
			public System.String SystemUCODE
			{
				get
				{
					System.String data = entity.SystemUCODE;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SystemUCODE = null;
					else entity.SystemUCODE = Convert.ToString(value);
				}
			}
				
			public System.String LastUpdate
			{
				get
				{
					System.DateTime? data = entity.LastUpdate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdate = null;
					else entity.LastUpdate = Convert.ToDateTime(value);
				}
			}
				
			public System.String LastUpdatedBy
			{
				get
				{
					System.String data = entity.LastUpdatedBy;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdatedBy = null;
					else entity.LastUpdatedBy = Convert.ToString(value);
				}
			}
			

			private esSystemBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esSystemQuery query)
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
				throw new Exception("esSystemBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esSystemQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SystemMetadata.Meta();
			}
		}	
		

		public esQueryItem Str1
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Str1, esSystemType.String);
			}
		} 
		
		public esQueryItem Str2
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Str2, esSystemType.String);
			}
		} 
		
		public esQueryItem Str3
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Str3, esSystemType.String);
			}
		} 
		
		public esQueryItem Bool1
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Bool1, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Bool2
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Bool2, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Bool3
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Bool3, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Int1
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Int1, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Int2
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Int2, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Int3
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Int3, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Dbl1
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl1, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Dbl2
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl2, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Dbl3
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Dbl3, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Displaypriceexpire
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Displaypriceexpire, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Lastfposcdate
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfposcdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Lastfposversion
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfposversion, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Lastfdpfile
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.Lastfdpfile, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SystemID
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.SystemID, esSystemType.Guid);
			}
		} 
		
		public esQueryItem SystemUCODE
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.SystemUCODE, esSystemType.String);
			}
		} 
		
		public esQueryItem LastUpdate
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.LastUpdate, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem LastUpdatedBy
		{
			get
			{
				return new esQueryItem(this, SystemMetadata.ColumnNames.LastUpdatedBy, esSystemType.String);
			}
		} 
		
	}



	[Serializable]
	[XmlType("SystemCollection")]
	public partial class SystemCollection : esSystemCollection, IEnumerable<SystemBO>
	{
		public SystemCollection()
		{

		}
		
		public static implicit operator List<SystemBO>(SystemCollection coll)
		{
			List<SystemBO> list = new List<SystemBO>();
			
			foreach (SystemBO emp in coll)
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
				return  SystemMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SystemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new SystemBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new SystemBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public SystemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SystemQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(SystemQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public SystemBO AddNew()
		{
			SystemBO entity = base.AddNewEntity() as SystemBO;
			
			return entity;
		}

		public SystemBO FindByPrimaryKey(System.Guid systemID)
		{
			return base.FindByPrimaryKey(systemID) as SystemBO;
		}


		#region IEnumerable<SystemBO> Members

		IEnumerator<SystemBO> IEnumerable<SystemBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as SystemBO;
			}
		}

		#endregion
		
		private SystemQuery query;
	}


	/// <summary>
	/// Encapsulates the 'system' table
	/// </summary>

	[Serializable]
	public partial class SystemBO : esSystemBO
	{
		public SystemBO()
		{

		}
	
		public SystemBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SystemMetadata.Meta();
			}
		}
		
		
		
		override protected esSystemQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SystemQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public SystemQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SystemQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(SystemQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private SystemQuery query;
	}



	[Serializable]
		
	public partial class SystemQuery : esSystemQuery
	{
		public SystemQuery()
		{

		}		
		
		public SystemQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "SystemQuery";
        }
		
			
	}


	[Serializable]
	public partial class SystemMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SystemMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str1, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str1;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str2, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str2;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Str3, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.Str3;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool1, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool1;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool2, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool2;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Bool3, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = SystemMetadata.PropertyNames.Bool3;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int1, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int1;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int2, 7, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int2;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Int3, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Int3;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl1, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl1;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl2, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl2;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Dbl3, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Dbl3;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Displaypriceexpire, 12, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.Displaypriceexpire;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfposcdate, 13, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfposcdate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfposversion, 14, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfposversion;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.Lastfdpfile, 15, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = SystemMetadata.PropertyNames.Lastfdpfile;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.SystemID, 16, typeof(System.Guid), esSystemType.Guid);
			c.PropertyName = SystemMetadata.PropertyNames.SystemID;
			c.IsInPrimaryKey = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.SystemUCODE, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.SystemUCODE;
			c.CharacterMaxLength = 50;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.LastUpdate, 18, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = SystemMetadata.PropertyNames.LastUpdate;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(SystemMetadata.ColumnNames.LastUpdatedBy, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = SystemMetadata.PropertyNames.LastUpdatedBy;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public SystemMetadata Meta()
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
			 public const string Str1 = "str1";
			 public const string Str2 = "str2";
			 public const string Str3 = "str3";
			 public const string Bool1 = "bool1";
			 public const string Bool2 = "bool2";
			 public const string Bool3 = "bool3";
			 public const string Int1 = "int1";
			 public const string Int2 = "int2";
			 public const string Int3 = "int3";
			 public const string Dbl1 = "dbl1";
			 public const string Dbl2 = "dbl2";
			 public const string Dbl3 = "dbl3";
			 public const string Displaypriceexpire = "displaypriceexpire";
			 public const string Lastfposcdate = "lastfposcdate";
			 public const string Lastfposversion = "lastfposversion";
			 public const string Lastfdpfile = "lastfdpfile";
			 public const string SystemID = "systemID";
			 public const string SystemUCODE = "systemUCODE";
			 public const string LastUpdate = "lastUpdate";
			 public const string LastUpdatedBy = "lastUpdatedBy";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Str1 = "Str1";
			 public const string Str2 = "Str2";
			 public const string Str3 = "Str3";
			 public const string Bool1 = "Bool1";
			 public const string Bool2 = "Bool2";
			 public const string Bool3 = "Bool3";
			 public const string Int1 = "Int1";
			 public const string Int2 = "Int2";
			 public const string Int3 = "Int3";
			 public const string Dbl1 = "Dbl1";
			 public const string Dbl2 = "Dbl2";
			 public const string Dbl3 = "Dbl3";
			 public const string Displaypriceexpire = "Displaypriceexpire";
			 public const string Lastfposcdate = "Lastfposcdate";
			 public const string Lastfposversion = "Lastfposversion";
			 public const string Lastfdpfile = "Lastfdpfile";
			 public const string SystemID = "SystemID";
			 public const string SystemUCODE = "SystemUCODE";
			 public const string LastUpdate = "LastUpdate";
			 public const string LastUpdatedBy = "LastUpdatedBy";
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
			lock (typeof(SystemMetadata))
			{
				if(SystemMetadata.mapDelegates == null)
				{
					SystemMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SystemMetadata.meta == null)
				{
					SystemMetadata.meta = new SystemMetadata();
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
				

				meta.AddTypeMap("Str1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Str2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Str3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Bool1", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Bool2", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Bool3", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Int1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Int2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Int3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl1", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl2", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Dbl3", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Displaypriceexpire", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastfposcdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastfposversion", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Lastfdpfile", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SystemID", new esTypeMap("uniqueidentifier", "System.Guid"));
				meta.AddTypeMap("SystemUCODE", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LastUpdate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdatedBy", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "system";
				meta.Destination = "system";
				
				meta.spInsert = "proc_systemInsert";				
				meta.spUpdate = "proc_systemUpdate";		
				meta.spDelete = "proc_systemDelete";
				meta.spLoadAll = "proc_systemLoadAll";
				meta.spLoadByPrimaryKey = "proc_systemLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SystemMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
