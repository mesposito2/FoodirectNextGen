/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 4/20/2024 4:22:54 PM
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
	abstract public class esFDACTIONHistoryCollection : esEntityCollection
	{
		public esFDACTIONHistoryCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "FDACTIONHistoryCollection";
		}

		#region Query Logic
		protected void InitQuery(esFDACTIONHistoryQuery query)
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
			this.InitQuery(query as esFDACTIONHistoryQuery);
		}
		#endregion
		
		virtual public FDACTIONHistoryBO DetachEntity(FDACTIONHistoryBO entity)
		{
			return base.DetachEntity(entity) as FDACTIONHistoryBO;
		}
		
		virtual public FDACTIONHistoryBO AttachEntity(FDACTIONHistoryBO entity)
		{
			return base.AttachEntity(entity) as FDACTIONHistoryBO;
		}
		
		virtual public void Combine(FDACTIONHistoryCollection collection)
		{
			base.Combine(collection);
		}
		
		new public FDACTIONHistoryBO this[int index]
		{
			get
			{
				return base[index] as FDACTIONHistoryBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(FDACTIONHistoryBO);
		}
	}



	[Serializable]
	abstract public class esFDACTIONHistoryBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esFDACTIONHistoryQuery GetDynamicQuery()
		{
			return null;
		}

		public esFDACTIONHistoryBO()
		{

		}

		public esFDACTIONHistoryBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 fDActionHistoryID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionHistoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionHistoryID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 fDActionHistoryID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionHistoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionHistoryID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 fDActionHistoryID)
		{
			esFDACTIONHistoryQuery query = this.GetDynamicQuery();
			query.Where(query.FDActionHistoryID == fDActionHistoryID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 fDActionHistoryID)
		{
			esParameters parms = new esParameters();
			parms.Add("FDActionHistoryID",fDActionHistoryID);
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
						case "FDActionHistoryID": this.str.FDActionHistoryID = (string)value; break;							
						case "Token": this.str.Token = (string)value; break;							
						case "Description": this.str.Description = (string)value; break;							
						case "Lastlogfile": this.str.Lastlogfile = (string)value; break;							
						case "Lastrun": this.str.Lastrun = (string)value; break;							
						case "Lastresult": this.str.Lastresult = (string)value; break;							
						case "Lastmsg": this.str.Lastmsg = (string)value; break;							
						case "Msgfile": this.str.Msgfile = (string)value; break;							
						case "Active": this.str.Active = (string)value; break;							
						case "LastRunStart": this.str.LastRunStart = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "FDActionHistoryID":
						
							if (value == null || value is System.Int32)
								this.FDActionHistoryID = (System.Int32?)value;
							break;
						
						case "Lastrun":
						
							if (value == null || value is System.DateTime)
								this.Lastrun = (System.DateTime?)value;
							break;
						
						case "Lastresult":
						
							if (value == null || value is System.Decimal)
								this.Lastresult = (System.Decimal?)value;
							break;
						
						case "Active":
						
							if (value == null || value is System.Boolean)
								this.Active = (System.Boolean?)value;
							break;
						
						case "LastRunStart":
						
							if (value == null || value is System.DateTime)
								this.LastRunStart = (System.DateTime?)value;
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
		/// Maps to FDACTIONHistory.FDActionHistoryID
		/// </summary>
		virtual public System.Int32? FDActionHistoryID
		{
			get
			{
				return base.GetSystemInt32(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.FDActionHistoryID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.token
		/// </summary>
		virtual public System.String Token
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Token);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Token, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Token));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastlogfile
		/// </summary>
		virtual public System.String Lastlogfile
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Lastlogfile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastrun
		/// </summary>
		virtual public System.DateTime? Lastrun
		{
			get
			{
				return base.GetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.Lastrun);
			}
			
			set
			{
				if(base.SetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.Lastrun, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Lastrun));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastresult
		/// </summary>
		virtual public System.Decimal? Lastresult
		{
			get
			{
				return base.GetSystemDecimal(FDACTIONHistoryMetadata.ColumnNames.Lastresult);
			}
			
			set
			{
				if(base.SetSystemDecimal(FDACTIONHistoryMetadata.ColumnNames.Lastresult, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Lastresult));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.lastmsg
		/// </summary>
		virtual public System.String Lastmsg
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastmsg);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Lastmsg, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Lastmsg));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.msgfile
		/// </summary>
		virtual public System.String Msgfile
		{
			get
			{
				return base.GetSystemString(FDACTIONHistoryMetadata.ColumnNames.Msgfile);
			}
			
			set
			{
				if(base.SetSystemString(FDACTIONHistoryMetadata.ColumnNames.Msgfile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Msgfile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.active
		/// </summary>
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(FDACTIONHistoryMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(FDACTIONHistoryMetadata.ColumnNames.Active, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.Active));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTIONHistory.LastRunStart
		/// </summary>
		virtual public System.DateTime? LastRunStart
		{
			get
			{
				return base.GetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.LastRunStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(FDACTIONHistoryMetadata.ColumnNames.LastRunStart, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FDACTIONHistoryMetadata.PropertyNames.LastRunStart));
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
			public esStrings(esFDACTIONHistoryBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String FDActionHistoryID
			{
				get
				{
					System.Int32? data = entity.FDActionHistoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDActionHistoryID = null;
					else entity.FDActionHistoryID = Convert.ToInt32(value);
				}
			}
				
			public System.String Token
			{
				get
				{
					System.String data = entity.Token;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Token = null;
					else entity.Token = Convert.ToString(value);
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
				
			public System.String Lastlogfile
			{
				get
				{
					System.String data = entity.Lastlogfile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastlogfile = null;
					else entity.Lastlogfile = Convert.ToString(value);
				}
			}
				
			public System.String Lastrun
			{
				get
				{
					System.DateTime? data = entity.Lastrun;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastrun = null;
					else entity.Lastrun = Convert.ToDateTime(value);
				}
			}
				
			public System.String Lastresult
			{
				get
				{
					System.Decimal? data = entity.Lastresult;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastresult = null;
					else entity.Lastresult = Convert.ToDecimal(value);
				}
			}
				
			public System.String Lastmsg
			{
				get
				{
					System.String data = entity.Lastmsg;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Lastmsg = null;
					else entity.Lastmsg = Convert.ToString(value);
				}
			}
				
			public System.String Msgfile
			{
				get
				{
					System.String data = entity.Msgfile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Msgfile = null;
					else entity.Msgfile = Convert.ToString(value);
				}
			}
				
			public System.String Active
			{
				get
				{
					System.Boolean? data = entity.Active;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Active = null;
					else entity.Active = Convert.ToBoolean(value);
				}
			}
				
			public System.String LastRunStart
			{
				get
				{
					System.DateTime? data = entity.LastRunStart;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastRunStart = null;
					else entity.LastRunStart = Convert.ToDateTime(value);
				}
			}
			

			private esFDACTIONHistoryBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esFDACTIONHistoryQuery query)
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
				throw new Exception("esFDACTIONHistoryBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esFDACTIONHistoryQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FDACTIONHistoryMetadata.Meta();
			}
		}	
		

		public esQueryItem FDActionHistoryID
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Token
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Token, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastlogfile
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastrun
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastrun, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Lastresult
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastresult, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Lastmsg
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Lastmsg, esSystemType.String);
			}
		} 
		
		public esQueryItem Msgfile
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Msgfile, esSystemType.String);
			}
		} 
		
		public esQueryItem Active
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.Active, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem LastRunStart
		{
			get
			{
				return new esQueryItem(this, FDACTIONHistoryMetadata.ColumnNames.LastRunStart, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("FDACTIONHistoryCollection")]
	public partial class FDACTIONHistoryCollection : esFDACTIONHistoryCollection, IEnumerable<FDACTIONHistoryBO>
	{
		public FDACTIONHistoryCollection()
		{

		}
		
		public static implicit operator List<FDACTIONHistoryBO>(FDACTIONHistoryCollection coll)
		{
			List<FDACTIONHistoryBO> list = new List<FDACTIONHistoryBO>();
			
			foreach (FDACTIONHistoryBO emp in coll)
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
				return  FDACTIONHistoryMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FDACTIONHistoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new FDACTIONHistoryBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new FDACTIONHistoryBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public FDACTIONHistoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FDACTIONHistoryQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(FDACTIONHistoryQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public FDACTIONHistoryBO AddNew()
		{
			FDACTIONHistoryBO entity = base.AddNewEntity() as FDACTIONHistoryBO;
			
			return entity;
		}

		public FDACTIONHistoryBO FindByPrimaryKey(System.Int32 fDActionHistoryID)
		{
			return base.FindByPrimaryKey(fDActionHistoryID) as FDACTIONHistoryBO;
		}


		#region IEnumerable<FDACTIONHistoryBO> Members

		IEnumerator<FDACTIONHistoryBO> IEnumerable<FDACTIONHistoryBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as FDACTIONHistoryBO;
			}
		}

		#endregion
		
		private FDACTIONHistoryQuery query;
	}


	/// <summary>
	/// Encapsulates the 'FDACTIONHistory' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("FDACTIONHistoryBO ({FDActionHistoryID})")]
	[Serializable]
	public partial class FDACTIONHistoryBO : esFDACTIONHistoryBO
	{
		public FDACTIONHistoryBO()
		{

		}
	
		public FDACTIONHistoryBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FDACTIONHistoryMetadata.Meta();
			}
		}
		
		
		
		override protected esFDACTIONHistoryQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FDACTIONHistoryQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public FDACTIONHistoryQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FDACTIONHistoryQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(FDACTIONHistoryQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private FDACTIONHistoryQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class FDACTIONHistoryQuery : esFDACTIONHistoryQuery
	{
		public FDACTIONHistoryQuery()
		{

		}		
		
		public FDACTIONHistoryQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "FDACTIONHistoryQuery";
        }
		
			
	}


	[Serializable]
	public partial class FDACTIONHistoryMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FDACTIONHistoryMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.FDActionHistoryID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.FDActionHistoryID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Token, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Token;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastlogfile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastlogfile;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastrun, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastrun;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastresult, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastresult;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Lastmsg, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Lastmsg;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Msgfile, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Msgfile;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FDACTIONHistoryMetadata.ColumnNames.LastRunStart, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FDACTIONHistoryMetadata.PropertyNames.LastRunStart;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public FDACTIONHistoryMetadata Meta()
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
			 public const string FDActionHistoryID = "FDActionHistoryID";
			 public const string Token = "token";
			 public const string Description = "description";
			 public const string Lastlogfile = "lastlogfile";
			 public const string Lastrun = "lastrun";
			 public const string Lastresult = "lastresult";
			 public const string Lastmsg = "lastmsg";
			 public const string Msgfile = "msgfile";
			 public const string Active = "active";
			 public const string LastRunStart = "LastRunStart";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string FDActionHistoryID = "FDActionHistoryID";
			 public const string Token = "Token";
			 public const string Description = "Description";
			 public const string Lastlogfile = "Lastlogfile";
			 public const string Lastrun = "Lastrun";
			 public const string Lastresult = "Lastresult";
			 public const string Lastmsg = "Lastmsg";
			 public const string Msgfile = "Msgfile";
			 public const string Active = "Active";
			 public const string LastRunStart = "LastRunStart";
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
			lock (typeof(FDACTIONHistoryMetadata))
			{
				if(FDACTIONHistoryMetadata.mapDelegates == null)
				{
					FDACTIONHistoryMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (FDACTIONHistoryMetadata.meta == null)
				{
					FDACTIONHistoryMetadata.meta = new FDACTIONHistoryMetadata();
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
				

				meta.AddTypeMap("FDActionHistoryID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Token", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastlogfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastrun", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastresult", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Lastmsg", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Msgfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastRunStart", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "FDACTIONHistory";
				meta.Destination = "FDACTIONHistory";
				
				meta.spInsert = "proc_FDACTIONHistoryInsert";				
				meta.spUpdate = "proc_FDACTIONHistoryUpdate";		
				meta.spDelete = "proc_FDACTIONHistoryDelete";
				meta.spLoadAll = "proc_FDACTIONHistoryLoadAll";
				meta.spLoadByPrimaryKey = "proc_FDACTIONHistoryLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FDACTIONHistoryMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
