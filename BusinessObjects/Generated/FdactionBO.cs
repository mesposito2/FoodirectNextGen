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
	abstract public class esFdactionCollection : esEntityCollection
	{
		public esFdactionCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "FdactionCollection";
		}

		#region Query Logic
		protected void InitQuery(esFdactionQuery query)
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
			this.InitQuery(query as esFdactionQuery);
		}
		#endregion
		
		virtual public FdactionBO DetachEntity(FdactionBO entity)
		{
			return base.DetachEntity(entity) as FdactionBO;
		}
		
		virtual public FdactionBO AttachEntity(FdactionBO entity)
		{
			return base.AttachEntity(entity) as FdactionBO;
		}
		
		virtual public void Combine(FdactionCollection collection)
		{
			base.Combine(collection);
		}
		
		new public FdactionBO this[int index]
		{
			get
			{
				return base[index] as FdactionBO;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(FdactionBO);
		}
	}



	[Serializable]
	abstract public class esFdactionBO : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esFdactionQuery GetDynamicQuery()
		{
			return null;
		}

		public esFdactionBO()
		{

		}

		public esFdactionBO(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 fDActionID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 fDActionID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(fDActionID);
			else
				return LoadByPrimaryKeyStoredProcedure(fDActionID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 fDActionID)
		{
			esFdactionQuery query = this.GetDynamicQuery();
			query.Where(query.FDActionID == fDActionID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 fDActionID)
		{
			esParameters parms = new esParameters();
			parms.Add("FDActionID",fDActionID);
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
						case "FDActionID": this.str.FDActionID = (string)value; break;							
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
						case "FDActionID":
						
							if (value == null || value is System.Int32)
								this.FDActionID = (System.Int32?)value;
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
		/// Maps to FDACTION.FDActionID
		/// </summary>
		virtual public System.Int32? FDActionID
		{
			get
			{
				return base.GetSystemInt32(FdactionMetadata.ColumnNames.FDActionID);
			}
			
			set
			{
				if(base.SetSystemInt32(FdactionMetadata.ColumnNames.FDActionID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.FDActionID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.token
		/// </summary>
		virtual public System.String Token
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Token);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Token, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Token));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.description
		/// </summary>
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Description, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Description));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastlogfile
		/// </summary>
		virtual public System.String Lastlogfile
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Lastlogfile);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Lastlogfile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Lastlogfile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastrun
		/// </summary>
		virtual public System.DateTime? Lastrun
		{
			get
			{
				return base.GetSystemDateTime(FdactionMetadata.ColumnNames.Lastrun);
			}
			
			set
			{
				if(base.SetSystemDateTime(FdactionMetadata.ColumnNames.Lastrun, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Lastrun));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastresult
		/// </summary>
		virtual public System.Decimal? Lastresult
		{
			get
			{
				return base.GetSystemDecimal(FdactionMetadata.ColumnNames.Lastresult);
			}
			
			set
			{
				if(base.SetSystemDecimal(FdactionMetadata.ColumnNames.Lastresult, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Lastresult));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.lastmsg
		/// </summary>
		virtual public System.String Lastmsg
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Lastmsg);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Lastmsg, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Lastmsg));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.msgfile
		/// </summary>
		virtual public System.String Msgfile
		{
			get
			{
				return base.GetSystemString(FdactionMetadata.ColumnNames.Msgfile);
			}
			
			set
			{
				if(base.SetSystemString(FdactionMetadata.ColumnNames.Msgfile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Msgfile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.active
		/// </summary>
		virtual public System.Boolean? Active
		{
			get
			{
				return base.GetSystemBoolean(FdactionMetadata.ColumnNames.Active);
			}
			
			set
			{
				if(base.SetSystemBoolean(FdactionMetadata.ColumnNames.Active, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.Active));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to FDACTION.LastRunStart
		/// </summary>
		virtual public System.DateTime? LastRunStart
		{
			get
			{
				return base.GetSystemDateTime(FdactionMetadata.ColumnNames.LastRunStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(FdactionMetadata.ColumnNames.LastRunStart, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(FdactionMetadata.PropertyNames.LastRunStart));
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
			public esStrings(esFdactionBO entity)
			{
				this.entity = entity;
			}
			
	
			public System.String FDActionID
			{
				get
				{
					System.Int32? data = entity.FDActionID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FDActionID = null;
					else entity.FDActionID = Convert.ToInt32(value);
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
			

			private esFdactionBO entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esFdactionQuery query)
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
				throw new Exception("esFdactionBO can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}



	[Serializable]
	abstract public class esFdactionQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return FdactionMetadata.Meta();
			}
		}	
		

		public esQueryItem FDActionID
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.FDActionID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Token
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Token, esSystemType.String);
			}
		} 
		
		public esQueryItem Description
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Description, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastlogfile
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastlogfile, esSystemType.String);
			}
		} 
		
		public esQueryItem Lastrun
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastrun, esSystemType.DateTime);
			}
		} 
		
		public esQueryItem Lastresult
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastresult, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Lastmsg
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Lastmsg, esSystemType.String);
			}
		} 
		
		public esQueryItem Msgfile
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Msgfile, esSystemType.String);
			}
		} 
		
		public esQueryItem Active
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.Active, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem LastRunStart
		{
			get
			{
				return new esQueryItem(this, FdactionMetadata.ColumnNames.LastRunStart, esSystemType.DateTime);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("FdactionCollection")]
	public partial class FdactionCollection : esFdactionCollection, IEnumerable<FdactionBO>
	{
		public FdactionCollection()
		{

		}
		
		public static implicit operator List<FdactionBO>(FdactionCollection coll)
		{
			List<FdactionBO> list = new List<FdactionBO>();
			
			foreach (FdactionBO emp in coll)
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
				return  FdactionMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FdactionQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new FdactionBO(row);
		}

		override protected esEntity CreateEntity()
		{
			return new FdactionBO();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public FdactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FdactionQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(FdactionQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public FdactionBO AddNew()
		{
			FdactionBO entity = base.AddNewEntity() as FdactionBO;
			
			return entity;
		}

		public FdactionBO FindByPrimaryKey(System.Int32 fDActionID)
		{
			return base.FindByPrimaryKey(fDActionID) as FdactionBO;
		}


		#region IEnumerable<FdactionBO> Members

		IEnumerator<FdactionBO> IEnumerable<FdactionBO>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as FdactionBO;
			}
		}

		#endregion
		
		private FdactionQuery query;
	}


	/// <summary>
	/// Encapsulates the 'FDACTION' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("FdactionBO ({FDActionID})")]
	[Serializable]
	public partial class FdactionBO : esFdactionBO
	{
		public FdactionBO()
		{

		}
	
		public FdactionBO(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return FdactionMetadata.Meta();
			}
		}
		
		
		
		override protected esFdactionQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new FdactionQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public FdactionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new FdactionQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(FdactionQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private FdactionQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
		
	public partial class FdactionQuery : esFdactionQuery
	{
		public FdactionQuery()
		{

		}		
		
		public FdactionQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

        override protected string GetQueryName()
        {
            return "FdactionQuery";
        }
		
			
	}


	[Serializable]
	public partial class FdactionMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected FdactionMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(FdactionMetadata.ColumnNames.FDActionID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = FdactionMetadata.PropertyNames.FDActionID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Token, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Token;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastlogfile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastlogfile;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastrun, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastrun;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastresult, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastresult;
			c.NumericPrecision = 18;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Lastmsg, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Lastmsg;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Msgfile, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = FdactionMetadata.PropertyNames.Msgfile;
			c.CharacterMaxLength = 255;
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.Active, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = FdactionMetadata.PropertyNames.Active;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			_columns.Add(c);
				
			c = new esColumnMetadata(FdactionMetadata.ColumnNames.LastRunStart, 9, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = FdactionMetadata.PropertyNames.LastRunStart;
			c.IsNullable = true;
			_columns.Add(c);
				
		}
		#endregion	
	
		static public FdactionMetadata Meta()
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
			 public const string FDActionID = "FDActionID";
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
			 public const string FDActionID = "FDActionID";
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
			lock (typeof(FdactionMetadata))
			{
				if(FdactionMetadata.mapDelegates == null)
				{
					FdactionMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (FdactionMetadata.meta == null)
				{
					FdactionMetadata.meta = new FdactionMetadata();
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
				

				meta.AddTypeMap("FDActionID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Token", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastlogfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Lastrun", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Lastresult", new esTypeMap("decimal", "System.Decimal"));
				meta.AddTypeMap("Lastmsg", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Msgfile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Active", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("LastRunStart", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "FDACTION";
				meta.Destination = "FDACTION";
				
				meta.spInsert = "proc_FDACTIONInsert";				
				meta.spUpdate = "proc_FDACTIONUpdate";		
				meta.spDelete = "proc_FDACTIONDelete";
				meta.spLoadAll = "proc_FDACTIONLoadAll";
				meta.spLoadByPrimaryKey = "proc_FDACTIONLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private FdactionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
