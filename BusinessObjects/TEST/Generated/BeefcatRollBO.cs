
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:13 PM
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
	/// Encapsulates the 'beefcat_roll' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(BeefcatRollBO))]	
	[XmlType("BeefcatRollBO")]
	public partial class BeefcatRollBO : esBeefcatRollBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new BeefcatRollBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("BeefcatRollCollection")]
	public partial class BeefcatRollCollection : esBeefcatRollCollection, IEnumerable<BeefcatRollBO>
	{

		
				
	}



	[Serializable]	
	public partial class BeefcatRollQuery : esBeefcatRollQuery
	{
		public BeefcatRollQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public BeefcatRollQuery(string joinAlias, out BeefcatRollQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "BeefcatRollQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(BeefcatRollQuery query)
		{
			return BeefcatRollQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator BeefcatRollQuery(string query)
		{
			return (BeefcatRollQuery)BeefcatRollQuery.SerializeHelper.FromXml(query, typeof(BeefcatRollQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esBeefcatRollBO : esEntity
	{
		public esBeefcatRollBO()
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
			BeefcatRollQuery query = new BeefcatRollQuery();
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
		/// Maps to beefcat_roll.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(BeefcatRollMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(BeefcatRollMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.custid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Custid
		{
			get
			{
				return base.GetSystemString(BeefcatRollMetadata.ColumnNames.Custid);
			}
			
			set
			{
				if(base.SetSystemString(BeefcatRollMetadata.ColumnNames.Custid, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.Custid);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P1
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P1, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P2
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P2, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P3
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P3, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P4
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P4, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P5
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P5, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P6
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P6, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P7
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P7, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P8
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P8, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P9
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P9, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P10
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P10, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P11
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P11, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P12
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P12
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P12);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P12, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P12);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P13
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P13
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P13);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P13, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P13);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P14
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P14
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P14);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P14, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P14);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P15
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P15
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P15);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P15, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P15);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P16
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P16
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P16);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P16, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P16);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P17
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P17
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P17);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P17, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P17);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P18
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P18
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P18);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P18, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P18);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P19
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P19
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P19);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P19, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P19);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefcat_roll.P20
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? P20
		{
			get
			{
				return base.GetSystemDouble(BeefcatRollMetadata.ColumnNames.P20);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefcatRollMetadata.ColumnNames.P20, value))
				{
					OnPropertyChanged(BeefcatRollMetadata.PropertyNames.P20);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return BeefcatRollMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public BeefcatRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefcatRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefcatRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(BeefcatRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefcatRollQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private BeefcatRollQuery query;		
	}



	[Serializable]
	abstract public partial class esBeefcatRollCollection : esEntityCollection<BeefcatRollBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BeefcatRollMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "BeefcatRollCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public BeefcatRollQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefcatRollQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefcatRollQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BeefcatRollQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(BeefcatRollQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefcatRollQuery)query);
		}

		#endregion
		
		private BeefcatRollQuery query;
	}



	[Serializable]
	abstract public partial class esBeefcatRollQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BeefcatRollMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Jobberid": return this.Jobberid;
				case "Custid": return this.Custid;
				case "P1": return this.P1;
				case "P2": return this.P2;
				case "P3": return this.P3;
				case "P4": return this.P4;
				case "P5": return this.P5;
				case "P6": return this.P6;
				case "P7": return this.P7;
				case "P8": return this.P8;
				case "P9": return this.P9;
				case "P10": return this.P10;
				case "P11": return this.P11;
				case "P12": return this.P12;
				case "P13": return this.P13;
				case "P14": return this.P14;
				case "P15": return this.P15;
				case "P16": return this.P16;
				case "P17": return this.P17;
				case "P18": return this.P18;
				case "P19": return this.P19;
				case "P20": return this.P20;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem Custid
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.Custid, esSystemType.String); }
		} 
		
		public esQueryItem P1
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P1, esSystemType.Double); }
		} 
		
		public esQueryItem P2
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P2, esSystemType.Double); }
		} 
		
		public esQueryItem P3
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P3, esSystemType.Double); }
		} 
		
		public esQueryItem P4
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P4, esSystemType.Double); }
		} 
		
		public esQueryItem P5
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P5, esSystemType.Double); }
		} 
		
		public esQueryItem P6
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P6, esSystemType.Double); }
		} 
		
		public esQueryItem P7
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P7, esSystemType.Double); }
		} 
		
		public esQueryItem P8
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P8, esSystemType.Double); }
		} 
		
		public esQueryItem P9
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P9, esSystemType.Double); }
		} 
		
		public esQueryItem P10
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P10, esSystemType.Double); }
		} 
		
		public esQueryItem P11
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P11, esSystemType.Double); }
		} 
		
		public esQueryItem P12
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P12, esSystemType.Double); }
		} 
		
		public esQueryItem P13
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P13, esSystemType.Double); }
		} 
		
		public esQueryItem P14
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P14, esSystemType.Double); }
		} 
		
		public esQueryItem P15
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P15, esSystemType.Double); }
		} 
		
		public esQueryItem P16
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P16, esSystemType.Double); }
		} 
		
		public esQueryItem P17
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P17, esSystemType.Double); }
		} 
		
		public esQueryItem P18
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P18, esSystemType.Double); }
		} 
		
		public esQueryItem P19
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P19, esSystemType.Double); }
		} 
		
		public esQueryItem P20
		{
			get { return new esQueryItem(this, BeefcatRollMetadata.ColumnNames.P20, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class BeefcatRollBO : esBeefcatRollBO
	{

		
		
	}
	



	[Serializable]
	public partial class BeefcatRollMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BeefcatRollMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.Jobberid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.Custid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.Custid;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P1, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P2, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P3, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P4, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P5, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P6, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P7, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P8, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P9, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P10, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P11, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P12, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P12;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P13, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P13;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P14, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P14;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P15, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P15;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P16, 17, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P16;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P17, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P17;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P18, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P18;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P19, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P19;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefcatRollMetadata.ColumnNames.P20, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefcatRollMetadata.PropertyNames.P20;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public BeefcatRollMetadata Meta()
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
			 public const string Jobberid = "jobberid";
			 public const string Custid = "custid";
			 public const string P1 = "P1";
			 public const string P2 = "P2";
			 public const string P3 = "P3";
			 public const string P4 = "P4";
			 public const string P5 = "P5";
			 public const string P6 = "P6";
			 public const string P7 = "P7";
			 public const string P8 = "P8";
			 public const string P9 = "P9";
			 public const string P10 = "P10";
			 public const string P11 = "P11";
			 public const string P12 = "P12";
			 public const string P13 = "P13";
			 public const string P14 = "P14";
			 public const string P15 = "P15";
			 public const string P16 = "P16";
			 public const string P17 = "P17";
			 public const string P18 = "P18";
			 public const string P19 = "P19";
			 public const string P20 = "P20";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Jobberid = "Jobberid";
			 public const string Custid = "Custid";
			 public const string P1 = "P1";
			 public const string P2 = "P2";
			 public const string P3 = "P3";
			 public const string P4 = "P4";
			 public const string P5 = "P5";
			 public const string P6 = "P6";
			 public const string P7 = "P7";
			 public const string P8 = "P8";
			 public const string P9 = "P9";
			 public const string P10 = "P10";
			 public const string P11 = "P11";
			 public const string P12 = "P12";
			 public const string P13 = "P13";
			 public const string P14 = "P14";
			 public const string P15 = "P15";
			 public const string P16 = "P16";
			 public const string P17 = "P17";
			 public const string P18 = "P18";
			 public const string P19 = "P19";
			 public const string P20 = "P20";
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
			lock (typeof(BeefcatRollMetadata))
			{
				if(BeefcatRollMetadata.mapDelegates == null)
				{
					BeefcatRollMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BeefcatRollMetadata.meta == null)
				{
					BeefcatRollMetadata.meta = new BeefcatRollMetadata();
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


				meta.AddTypeMap("Jobberid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Custid", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("P1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P12", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P13", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P14", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P15", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P16", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P17", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P18", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P19", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("P20", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "beefcat_roll";
				meta.Destination = "beefcat_roll";
				
				meta.spInsert = "proc_beefcat_rollInsert";				
				meta.spUpdate = "proc_beefcat_rollUpdate";		
				meta.spDelete = "proc_beefcat_rollDelete";
				meta.spLoadAll = "proc_beefcat_rollLoadAll";
				meta.spLoadByPrimaryKey = "proc_beefcat_rollLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BeefcatRollMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
