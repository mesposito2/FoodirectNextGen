
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2019.1.1218.0
EntitySpaces Driver  : SQL
Date Generated       : 11/27/2024 3:31:12 PM
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
	/// Encapsulates the 'beefadj' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(BeefadjBO))]	
	[XmlType("BeefadjBO")]
	public partial class BeefadjBO : esBeefadjBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new BeefadjBO();
		}
		
		#region Static Quick Access Methods
		
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("BeefadjCollection")]
	public partial class BeefadjCollection : esBeefadjCollection, IEnumerable<BeefadjBO>
	{

		
				
	}



	[Serializable]	
	public partial class BeefadjQuery : esBeefadjQuery
	{
		public BeefadjQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public BeefadjQuery(string joinAlias, out BeefadjQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "BeefadjQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(BeefadjQuery query)
		{
			return BeefadjQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator BeefadjQuery(string query)
		{
			return (BeefadjQuery)BeefadjQuery.SerializeHelper.FromXml(query, typeof(BeefadjQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esBeefadjBO : esEntity
	{
		public esBeefadjBO()
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
			BeefadjQuery query = new BeefadjQuery();
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
		/// Maps to beefadj.jobberid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Jobberid
		{
			get
			{
				return base.GetSystemString(BeefadjMetadata.ColumnNames.Jobberid);
			}
			
			set
			{
				if(base.SetSystemString(BeefadjMetadata.ColumnNames.Jobberid, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.Jobberid);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A1
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A1, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A2
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A2, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A3
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A3, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A4
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A4, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A5
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A5, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A6
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A6, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A7
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A7, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A8
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A8, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A9
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A9, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A10
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A10, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A11
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A11, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A12
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A12
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A12);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A12, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A12);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A13
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A13
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A13);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A13, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A13);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A14
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A14
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A14);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A14, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A14);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A15
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A15
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A15);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A15, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A15);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A16
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A16
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A16);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A16, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A16);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A17
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A17
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A17);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A17, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A17);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A18
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A18
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A18);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A18, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A18);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A19
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A19
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A19);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A19, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A19);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.A20
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? A20
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.A20);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.A20, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.A20);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B1
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B1, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B2
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B2, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B3
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B3, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B4
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B4, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B5
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B5, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B6
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B6, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B7
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B7, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B8
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B8, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B9
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B9, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B10
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B10, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B11
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B11, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B12
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B12
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B12);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B12, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B12);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B13
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B13
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B13);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B13, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B13);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B14
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B14
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B14);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B14, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B14);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B15
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B15
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B15);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B15, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B15);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B16
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B16
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B16);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B16, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B16);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B17
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B17
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B17);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B17, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B17);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B18
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B18
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B18);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B18, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B18);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B19
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B19
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B19);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B19, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B19);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.B20
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? B20
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.B20);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.B20, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.B20);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C1
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C1, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C2
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C2, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C3
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C3, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C4
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C4, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C5
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C5, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C6
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C6, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C7
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C7, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C8
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C8, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C9
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C9, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C10
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C10, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C11
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C11, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C12
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C12
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C12);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C12, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C12);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C13
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C13
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C13);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C13, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C13);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C14
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C14
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C14);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C14, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C14);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C15
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C15
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C15);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C15, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C15);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C16
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C16
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C16);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C16, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C16);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C17
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C17
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C17);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C17, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C17);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C18
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C18
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C18);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C18, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C18);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C19
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C19
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C19);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C19, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C19);
				}
			}
		}
		
		/// <summary>
		/// Maps to beefadj.C20
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? C20
		{
			get
			{
				return base.GetSystemDouble(BeefadjMetadata.ColumnNames.C20);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefadjMetadata.ColumnNames.C20, value))
				{
					OnPropertyChanged(BeefadjMetadata.PropertyNames.C20);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return BeefadjMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public BeefadjQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefadjQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefadjQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(BeefadjQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefadjQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private BeefadjQuery query;		
	}



	[Serializable]
	abstract public partial class esBeefadjCollection : esEntityCollection<BeefadjBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BeefadjMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "BeefadjCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public BeefadjQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefadjQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefadjQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BeefadjQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(BeefadjQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefadjQuery)query);
		}

		#endregion
		
		private BeefadjQuery query;
	}



	[Serializable]
	abstract public partial class esBeefadjQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BeefadjMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Jobberid": return this.Jobberid;
				case "A1": return this.A1;
				case "A2": return this.A2;
				case "A3": return this.A3;
				case "A4": return this.A4;
				case "A5": return this.A5;
				case "A6": return this.A6;
				case "A7": return this.A7;
				case "A8": return this.A8;
				case "A9": return this.A9;
				case "A10": return this.A10;
				case "A11": return this.A11;
				case "A12": return this.A12;
				case "A13": return this.A13;
				case "A14": return this.A14;
				case "A15": return this.A15;
				case "A16": return this.A16;
				case "A17": return this.A17;
				case "A18": return this.A18;
				case "A19": return this.A19;
				case "A20": return this.A20;
				case "B1": return this.B1;
				case "B2": return this.B2;
				case "B3": return this.B3;
				case "B4": return this.B4;
				case "B5": return this.B5;
				case "B6": return this.B6;
				case "B7": return this.B7;
				case "B8": return this.B8;
				case "B9": return this.B9;
				case "B10": return this.B10;
				case "B11": return this.B11;
				case "B12": return this.B12;
				case "B13": return this.B13;
				case "B14": return this.B14;
				case "B15": return this.B15;
				case "B16": return this.B16;
				case "B17": return this.B17;
				case "B18": return this.B18;
				case "B19": return this.B19;
				case "B20": return this.B20;
				case "C1": return this.C1;
				case "C2": return this.C2;
				case "C3": return this.C3;
				case "C4": return this.C4;
				case "C5": return this.C5;
				case "C6": return this.C6;
				case "C7": return this.C7;
				case "C8": return this.C8;
				case "C9": return this.C9;
				case "C10": return this.C10;
				case "C11": return this.C11;
				case "C12": return this.C12;
				case "C13": return this.C13;
				case "C14": return this.C14;
				case "C15": return this.C15;
				case "C16": return this.C16;
				case "C17": return this.C17;
				case "C18": return this.C18;
				case "C19": return this.C19;
				case "C20": return this.C20;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Jobberid
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.Jobberid, esSystemType.String); }
		} 
		
		public esQueryItem A1
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A1, esSystemType.Double); }
		} 
		
		public esQueryItem A2
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A2, esSystemType.Double); }
		} 
		
		public esQueryItem A3
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A3, esSystemType.Double); }
		} 
		
		public esQueryItem A4
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A4, esSystemType.Double); }
		} 
		
		public esQueryItem A5
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A5, esSystemType.Double); }
		} 
		
		public esQueryItem A6
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A6, esSystemType.Double); }
		} 
		
		public esQueryItem A7
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A7, esSystemType.Double); }
		} 
		
		public esQueryItem A8
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A8, esSystemType.Double); }
		} 
		
		public esQueryItem A9
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A9, esSystemType.Double); }
		} 
		
		public esQueryItem A10
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A10, esSystemType.Double); }
		} 
		
		public esQueryItem A11
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A11, esSystemType.Double); }
		} 
		
		public esQueryItem A12
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A12, esSystemType.Double); }
		} 
		
		public esQueryItem A13
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A13, esSystemType.Double); }
		} 
		
		public esQueryItem A14
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A14, esSystemType.Double); }
		} 
		
		public esQueryItem A15
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A15, esSystemType.Double); }
		} 
		
		public esQueryItem A16
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A16, esSystemType.Double); }
		} 
		
		public esQueryItem A17
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A17, esSystemType.Double); }
		} 
		
		public esQueryItem A18
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A18, esSystemType.Double); }
		} 
		
		public esQueryItem A19
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A19, esSystemType.Double); }
		} 
		
		public esQueryItem A20
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.A20, esSystemType.Double); }
		} 
		
		public esQueryItem B1
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B1, esSystemType.Double); }
		} 
		
		public esQueryItem B2
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B2, esSystemType.Double); }
		} 
		
		public esQueryItem B3
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B3, esSystemType.Double); }
		} 
		
		public esQueryItem B4
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B4, esSystemType.Double); }
		} 
		
		public esQueryItem B5
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B5, esSystemType.Double); }
		} 
		
		public esQueryItem B6
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B6, esSystemType.Double); }
		} 
		
		public esQueryItem B7
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B7, esSystemType.Double); }
		} 
		
		public esQueryItem B8
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B8, esSystemType.Double); }
		} 
		
		public esQueryItem B9
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B9, esSystemType.Double); }
		} 
		
		public esQueryItem B10
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B10, esSystemType.Double); }
		} 
		
		public esQueryItem B11
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B11, esSystemType.Double); }
		} 
		
		public esQueryItem B12
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B12, esSystemType.Double); }
		} 
		
		public esQueryItem B13
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B13, esSystemType.Double); }
		} 
		
		public esQueryItem B14
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B14, esSystemType.Double); }
		} 
		
		public esQueryItem B15
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B15, esSystemType.Double); }
		} 
		
		public esQueryItem B16
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B16, esSystemType.Double); }
		} 
		
		public esQueryItem B17
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B17, esSystemType.Double); }
		} 
		
		public esQueryItem B18
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B18, esSystemType.Double); }
		} 
		
		public esQueryItem B19
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B19, esSystemType.Double); }
		} 
		
		public esQueryItem B20
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.B20, esSystemType.Double); }
		} 
		
		public esQueryItem C1
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C1, esSystemType.Double); }
		} 
		
		public esQueryItem C2
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C2, esSystemType.Double); }
		} 
		
		public esQueryItem C3
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C3, esSystemType.Double); }
		} 
		
		public esQueryItem C4
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C4, esSystemType.Double); }
		} 
		
		public esQueryItem C5
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C5, esSystemType.Double); }
		} 
		
		public esQueryItem C6
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C6, esSystemType.Double); }
		} 
		
		public esQueryItem C7
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C7, esSystemType.Double); }
		} 
		
		public esQueryItem C8
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C8, esSystemType.Double); }
		} 
		
		public esQueryItem C9
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C9, esSystemType.Double); }
		} 
		
		public esQueryItem C10
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C10, esSystemType.Double); }
		} 
		
		public esQueryItem C11
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C11, esSystemType.Double); }
		} 
		
		public esQueryItem C12
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C12, esSystemType.Double); }
		} 
		
		public esQueryItem C13
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C13, esSystemType.Double); }
		} 
		
		public esQueryItem C14
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C14, esSystemType.Double); }
		} 
		
		public esQueryItem C15
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C15, esSystemType.Double); }
		} 
		
		public esQueryItem C16
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C16, esSystemType.Double); }
		} 
		
		public esQueryItem C17
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C17, esSystemType.Double); }
		} 
		
		public esQueryItem C18
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C18, esSystemType.Double); }
		} 
		
		public esQueryItem C19
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C19, esSystemType.Double); }
		} 
		
		public esQueryItem C20
		{
			get { return new esQueryItem(this, BeefadjMetadata.ColumnNames.C20, esSystemType.Double); }
		} 
		
		#endregion
		
	}


	
	public partial class BeefadjBO : esBeefadjBO
	{

		
		
	}
	



	[Serializable]
	public partial class BeefadjMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BeefadjMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.Jobberid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefadjMetadata.PropertyNames.Jobberid;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A1, 1, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A2, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A3, 3, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A4, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A5, 5, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A6, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A7, 7, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A8, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A9, 9, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A10, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A11, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A12, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A12;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A13, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A13;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A14, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A14;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A15, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A15;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A16, 16, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A16;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A17, 17, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A17;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A18, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A18;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A19, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A19;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.A20, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.A20;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B1, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B2, 22, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B3, 23, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B4, 24, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B5, 25, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B6, 26, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B7, 27, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B8, 28, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B9, 29, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B10, 30, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B11, 31, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B12, 32, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B12;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B13, 33, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B13;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B14, 34, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B14;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B15, 35, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B15;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B16, 36, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B16;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B17, 37, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B17;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B18, 38, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B18;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B19, 39, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B19;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.B20, 40, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.B20;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C1, 41, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C2, 42, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C3, 43, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C4, 44, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C5, 45, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C6, 46, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C7, 47, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C8, 48, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C9, 49, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C10, 50, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C11, 51, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C12, 52, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C12;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C13, 53, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C13;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C14, 54, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C14;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C15, 55, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C15;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C16, 56, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C16;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C17, 57, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C17;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C18, 58, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C18;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C19, 59, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C19;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefadjMetadata.ColumnNames.C20, 60, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefadjMetadata.PropertyNames.C20;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public BeefadjMetadata Meta()
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
			 public const string A1 = "A1";
			 public const string A2 = "A2";
			 public const string A3 = "A3";
			 public const string A4 = "A4";
			 public const string A5 = "A5";
			 public const string A6 = "A6";
			 public const string A7 = "A7";
			 public const string A8 = "A8";
			 public const string A9 = "A9";
			 public const string A10 = "A10";
			 public const string A11 = "A11";
			 public const string A12 = "A12";
			 public const string A13 = "A13";
			 public const string A14 = "A14";
			 public const string A15 = "A15";
			 public const string A16 = "A16";
			 public const string A17 = "A17";
			 public const string A18 = "A18";
			 public const string A19 = "A19";
			 public const string A20 = "A20";
			 public const string B1 = "B1";
			 public const string B2 = "B2";
			 public const string B3 = "B3";
			 public const string B4 = "B4";
			 public const string B5 = "B5";
			 public const string B6 = "B6";
			 public const string B7 = "B7";
			 public const string B8 = "B8";
			 public const string B9 = "B9";
			 public const string B10 = "B10";
			 public const string B11 = "B11";
			 public const string B12 = "B12";
			 public const string B13 = "B13";
			 public const string B14 = "B14";
			 public const string B15 = "B15";
			 public const string B16 = "B16";
			 public const string B17 = "B17";
			 public const string B18 = "B18";
			 public const string B19 = "B19";
			 public const string B20 = "B20";
			 public const string C1 = "C1";
			 public const string C2 = "C2";
			 public const string C3 = "C3";
			 public const string C4 = "C4";
			 public const string C5 = "C5";
			 public const string C6 = "C6";
			 public const string C7 = "C7";
			 public const string C8 = "C8";
			 public const string C9 = "C9";
			 public const string C10 = "C10";
			 public const string C11 = "C11";
			 public const string C12 = "C12";
			 public const string C13 = "C13";
			 public const string C14 = "C14";
			 public const string C15 = "C15";
			 public const string C16 = "C16";
			 public const string C17 = "C17";
			 public const string C18 = "C18";
			 public const string C19 = "C19";
			 public const string C20 = "C20";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Jobberid = "Jobberid";
			 public const string A1 = "A1";
			 public const string A2 = "A2";
			 public const string A3 = "A3";
			 public const string A4 = "A4";
			 public const string A5 = "A5";
			 public const string A6 = "A6";
			 public const string A7 = "A7";
			 public const string A8 = "A8";
			 public const string A9 = "A9";
			 public const string A10 = "A10";
			 public const string A11 = "A11";
			 public const string A12 = "A12";
			 public const string A13 = "A13";
			 public const string A14 = "A14";
			 public const string A15 = "A15";
			 public const string A16 = "A16";
			 public const string A17 = "A17";
			 public const string A18 = "A18";
			 public const string A19 = "A19";
			 public const string A20 = "A20";
			 public const string B1 = "B1";
			 public const string B2 = "B2";
			 public const string B3 = "B3";
			 public const string B4 = "B4";
			 public const string B5 = "B5";
			 public const string B6 = "B6";
			 public const string B7 = "B7";
			 public const string B8 = "B8";
			 public const string B9 = "B9";
			 public const string B10 = "B10";
			 public const string B11 = "B11";
			 public const string B12 = "B12";
			 public const string B13 = "B13";
			 public const string B14 = "B14";
			 public const string B15 = "B15";
			 public const string B16 = "B16";
			 public const string B17 = "B17";
			 public const string B18 = "B18";
			 public const string B19 = "B19";
			 public const string B20 = "B20";
			 public const string C1 = "C1";
			 public const string C2 = "C2";
			 public const string C3 = "C3";
			 public const string C4 = "C4";
			 public const string C5 = "C5";
			 public const string C6 = "C6";
			 public const string C7 = "C7";
			 public const string C8 = "C8";
			 public const string C9 = "C9";
			 public const string C10 = "C10";
			 public const string C11 = "C11";
			 public const string C12 = "C12";
			 public const string C13 = "C13";
			 public const string C14 = "C14";
			 public const string C15 = "C15";
			 public const string C16 = "C16";
			 public const string C17 = "C17";
			 public const string C18 = "C18";
			 public const string C19 = "C19";
			 public const string C20 = "C20";
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
			lock (typeof(BeefadjMetadata))
			{
				if(BeefadjMetadata.mapDelegates == null)
				{
					BeefadjMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BeefadjMetadata.meta == null)
				{
					BeefadjMetadata.meta = new BeefadjMetadata();
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
				meta.AddTypeMap("A1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A12", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A13", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A14", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A15", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A16", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A17", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A18", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A19", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("A20", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B12", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B13", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B14", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B15", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B16", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B17", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B18", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B19", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("B20", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C12", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C13", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C14", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C15", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C16", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C17", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C18", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C19", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("C20", new esTypeMap("float", "System.Double"));			
				
				
				
				meta.Source = "beefadj";
				meta.Destination = "beefadj";
				
				meta.spInsert = "proc_beefadjInsert";				
				meta.spUpdate = "proc_beefadjUpdate";		
				meta.spDelete = "proc_beefadjDelete";
				meta.spLoadAll = "proc_beefadjLoadAll";
				meta.spLoadByPrimaryKey = "proc_beefadjLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BeefadjMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
