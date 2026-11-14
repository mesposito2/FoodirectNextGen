
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:14 PM
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
	/// Encapsulates the 'midi' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(MidiBO))]	
	[XmlType("MidiBO")]
	public partial class MidiBO : esMidiBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new MidiBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("MidiCollection")]
	public partial class MidiCollection : esMidiCollection, IEnumerable<MidiBO>
	{

		
				
	}



	[Serializable]	
	public partial class MidiQuery : esMidiQuery
	{
		public MidiQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public MidiQuery(string joinAlias, out MidiQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "MidiQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(MidiQuery query)
		{
			return MidiQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator MidiQuery(string query)
		{
			return (MidiQuery)MidiQuery.SerializeHelper.FromXml(query, typeof(MidiQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esMidiBO : esEntity
	{
		public esMidiBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey()
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, )
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic();
			else
				return LoadByPrimaryKeyStoredProcedure();
		}

		private bool LoadByPrimaryKeyDynamic()
		{
			MidiQuery query = new MidiQuery();
			query.Where();
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure()
		{
			esParameters parms = new esParameters();

			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to midi.mid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Mid
		{
			get
			{
				return base.GetSystemInt32(MidiMetadata.ColumnNames.Mid);
			}
			
			set
			{
				if(base.SetSystemInt32(MidiMetadata.ColumnNames.Mid, value))
				{
					OnPropertyChanged(MidiMetadata.PropertyNames.Mid);
				}
			}
		}
		
		/// <summary>
		/// Maps to midi.midifile
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Midifile
		{
			get
			{
				return base.GetSystemString(MidiMetadata.ColumnNames.Midifile);
			}
			
			set
			{
				if(base.SetSystemString(MidiMetadata.ColumnNames.Midifile, value))
				{
					OnPropertyChanged(MidiMetadata.PropertyNames.Midifile);
				}
			}
		}
		
		/// <summary>
		/// Maps to midi.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(MidiMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(MidiMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(MidiMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to midi.flags
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Flags
		{
			get
			{
				return base.GetSystemInt32(MidiMetadata.ColumnNames.Flags);
			}
			
			set
			{
				if(base.SetSystemInt32(MidiMetadata.ColumnNames.Flags, value))
				{
					OnPropertyChanged(MidiMetadata.PropertyNames.Flags);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return MidiMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public MidiQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MidiQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MidiQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(MidiQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MidiQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private MidiQuery query;		
	}



	[Serializable]
	abstract public partial class esMidiCollection : esEntityCollection<MidiBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return MidiMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "MidiCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public MidiQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new MidiQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(MidiQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new MidiQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(MidiQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((MidiQuery)query);
		}

		#endregion
		
		private MidiQuery query;
	}



	[Serializable]
	abstract public partial class esMidiQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return MidiMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Mid": return this.Mid;
				case "Midifile": return this.Midifile;
				case "Description": return this.Description;
				case "Flags": return this.Flags;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Mid
		{
			get { return new esQueryItem(this, MidiMetadata.ColumnNames.Mid, esSystemType.Int32); }
		} 
		
		public esQueryItem Midifile
		{
			get { return new esQueryItem(this, MidiMetadata.ColumnNames.Midifile, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, MidiMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Flags
		{
			get { return new esQueryItem(this, MidiMetadata.ColumnNames.Flags, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class MidiBO : esMidiBO
	{

		
		
	}
	



	[Serializable]
	public partial class MidiMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected MidiMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(MidiMetadata.ColumnNames.Mid, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MidiMetadata.PropertyNames.Mid;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MidiMetadata.ColumnNames.Midifile, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = MidiMetadata.PropertyNames.Midifile;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MidiMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = MidiMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(MidiMetadata.ColumnNames.Flags, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = MidiMetadata.PropertyNames.Flags;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public MidiMetadata Meta()
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
			 public const string Mid = "mid";
			 public const string Midifile = "midifile";
			 public const string Description = "description";
			 public const string Flags = "flags";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Mid = "Mid";
			 public const string Midifile = "Midifile";
			 public const string Description = "Description";
			 public const string Flags = "Flags";
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
			lock (typeof(MidiMetadata))
			{
				if(MidiMetadata.mapDelegates == null)
				{
					MidiMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (MidiMetadata.meta == null)
				{
					MidiMetadata.meta = new MidiMetadata();
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


				meta.AddTypeMap("Mid", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Midifile", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Flags", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "midi";
				meta.Destination = "midi";
				
				meta.spInsert = "proc_midiInsert";				
				meta.spUpdate = "proc_midiUpdate";		
				meta.spDelete = "proc_midiDelete";
				meta.spLoadAll = "proc_midiLoadAll";
				meta.spLoadByPrimaryKey = "proc_midiLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private MidiMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
