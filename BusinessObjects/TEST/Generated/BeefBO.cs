
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
	/// Encapsulates the 'beef' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(BeefBO))]	
	[XmlType("BeefBO")]
	public partial class BeefBO : esBeefBO
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new BeefBO();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 beefID)
		{
			var obj = new BeefBO();
			obj.BeefID = beefID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 beefID, esSqlAccessType sqlAccessType)
		{
			var obj = new BeefBO();
			obj.BeefID = beefID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("BeefCollection")]
	public partial class BeefCollection : esBeefCollection, IEnumerable<BeefBO>
	{
		public BeefBO FindByPrimaryKey(System.Int32 beefID)
		{
			return this.SingleOrDefault(e => e.BeefID == beefID);
		}

		
				
	}



	[Serializable]	
	public partial class BeefQuery : esBeefQuery
	{
		public BeefQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public BeefQuery(string joinAlias, out BeefQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "BeefQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(BeefQuery query)
		{
			return BeefQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator BeefQuery(string query)
		{
			return (BeefQuery)BeefQuery.SerializeHelper.FromXml(query, typeof(BeefQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esBeefBO : esEntity
	{
		public esBeefBO()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 beefID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(beefID);
			else
				return LoadByPrimaryKeyStoredProcedure(beefID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 beefID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(beefID);
			else
				return LoadByPrimaryKeyStoredProcedure(beefID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 beefID)
		{
			BeefQuery query = new BeefQuery();
			query.Where(query.BeefID == beefID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 beefID)
		{
			esParameters parms = new esParameters();
			parms.Add("BeefID", beefID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to beef.description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Description);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode1
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode1);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode1, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price1
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price1, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode2
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode2);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode2, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price2
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price2, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode3
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode3);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode3, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price3
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price3, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode4
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode4);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode4, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price4
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price4, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode5
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode5);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode5, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price5
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price5, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice1
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice1);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice1, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice1);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice2
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice2);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice2, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice2);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice3
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice3);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice3, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice3);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice4
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice4
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice4);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice4, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice4);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice5
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice5
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice5);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice5, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice5);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode6
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode6);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode6, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price6
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price6, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice6
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice6
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice6);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice6, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice6);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price7
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price7, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price8
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price8, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price9
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price9, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price10
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price10, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice7
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice7);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice7, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice8
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice8);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice8, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice9
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice9);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice9, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice10
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice10);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice10, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode7
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode7
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode7);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode7, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode7);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode8
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode8
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode8);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode8, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode8);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode9
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode9
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode9);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode9, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode9);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode10
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode10
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode10);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode10, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode10);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.price11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Price11
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Price11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Price11, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Price11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.jprice11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Double? Jprice11
		{
			get
			{
				return base.GetSystemDouble(BeefMetadata.ColumnNames.Jprice11);
			}
			
			set
			{
				if(base.SetSystemDouble(BeefMetadata.ColumnNames.Jprice11, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Jprice11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.pcode11
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Pcode11
		{
			get
			{
				return base.GetSystemString(BeefMetadata.ColumnNames.Pcode11);
			}
			
			set
			{
				if(base.SetSystemString(BeefMetadata.ColumnNames.Pcode11, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.Pcode11);
				}
			}
		}
		
		/// <summary>
		/// Maps to beef.beefID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? BeefID
		{
			get
			{
				return base.GetSystemInt32(BeefMetadata.ColumnNames.BeefID);
			}
			
			set
			{
				if(base.SetSystemInt32(BeefMetadata.ColumnNames.BeefID, value))
				{
					OnPropertyChanged(BeefMetadata.PropertyNames.BeefID);
				}
			}
		}
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return BeefMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public BeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(BeefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefQuery)query);
		}

		#endregion
		
        [IgnoreDataMember]
		private BeefQuery query;		
	}



	[Serializable]
	abstract public partial class esBeefCollection : esEntityCollection<BeefBO>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return BeefMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "BeefCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public BeefQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new BeefQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(BeefQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new BeefQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(BeefQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((BeefQuery)query);
		}

		#endregion
		
		private BeefQuery query;
	}



	[Serializable]
	abstract public partial class esBeefQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return BeefMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Description": return this.Description;
				case "Pcode1": return this.Pcode1;
				case "Price1": return this.Price1;
				case "Pcode2": return this.Pcode2;
				case "Price2": return this.Price2;
				case "Pcode3": return this.Pcode3;
				case "Price3": return this.Price3;
				case "Pcode4": return this.Pcode4;
				case "Price4": return this.Price4;
				case "Pcode5": return this.Pcode5;
				case "Price5": return this.Price5;
				case "Jprice1": return this.Jprice1;
				case "Jprice2": return this.Jprice2;
				case "Jprice3": return this.Jprice3;
				case "Jprice4": return this.Jprice4;
				case "Jprice5": return this.Jprice5;
				case "Pcode6": return this.Pcode6;
				case "Price6": return this.Price6;
				case "Jprice6": return this.Jprice6;
				case "Price7": return this.Price7;
				case "Price8": return this.Price8;
				case "Price9": return this.Price9;
				case "Price10": return this.Price10;
				case "Jprice7": return this.Jprice7;
				case "Jprice8": return this.Jprice8;
				case "Jprice9": return this.Jprice9;
				case "Jprice10": return this.Jprice10;
				case "Pcode7": return this.Pcode7;
				case "Pcode8": return this.Pcode8;
				case "Pcode9": return this.Pcode9;
				case "Pcode10": return this.Pcode10;
				case "Price11": return this.Price11;
				case "Jprice11": return this.Jprice11;
				case "Pcode11": return this.Pcode11;
				case "BeefID": return this.BeefID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Description
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Pcode1
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode1, esSystemType.String); }
		} 
		
		public esQueryItem Price1
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price1, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode2
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode2, esSystemType.String); }
		} 
		
		public esQueryItem Price2
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price2, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode3
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode3, esSystemType.String); }
		} 
		
		public esQueryItem Price3
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price3, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode4
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode4, esSystemType.String); }
		} 
		
		public esQueryItem Price4
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price4, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode5
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode5, esSystemType.String); }
		} 
		
		public esQueryItem Price5
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price5, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice1
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice1, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice2
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice2, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice3
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice3, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice4
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice4, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice5
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice5, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode6
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode6, esSystemType.String); }
		} 
		
		public esQueryItem Price6
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price6, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice6
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice6, esSystemType.Double); }
		} 
		
		public esQueryItem Price7
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price7, esSystemType.Double); }
		} 
		
		public esQueryItem Price8
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price8, esSystemType.Double); }
		} 
		
		public esQueryItem Price9
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price9, esSystemType.Double); }
		} 
		
		public esQueryItem Price10
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price10, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice7
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice7, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice8
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice8, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice9
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice9, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice10
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice10, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode7
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode7, esSystemType.String); }
		} 
		
		public esQueryItem Pcode8
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode8, esSystemType.String); }
		} 
		
		public esQueryItem Pcode9
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode9, esSystemType.String); }
		} 
		
		public esQueryItem Pcode10
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode10, esSystemType.String); }
		} 
		
		public esQueryItem Price11
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Price11, esSystemType.Double); }
		} 
		
		public esQueryItem Jprice11
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Jprice11, esSystemType.Double); }
		} 
		
		public esQueryItem Pcode11
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.Pcode11, esSystemType.String); }
		} 
		
		public esQueryItem BeefID
		{
			get { return new esQueryItem(this, BeefMetadata.ColumnNames.BeefID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class BeefBO : esBeefBO
	{

		
		
	}
	



	[Serializable]
	public partial class BeefMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected BeefMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(BeefMetadata.ColumnNames.Description, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode1, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode1;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price1, 2, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode2, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode2;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price2, 4, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode3, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode3;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price3, 6, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode4, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode4;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price4, 8, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode5, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode5;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price5, 10, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice1, 11, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice1;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice2, 12, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice2;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice3, 13, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice3;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice4, 14, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice4;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice5, 15, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice5;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode6, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode6;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price6, 17, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice6, 18, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice6;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price7, 19, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price8, 20, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price9, 21, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price10, 22, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice7, 23, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice7;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice8, 24, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice8;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice9, 25, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice9;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice10, 26, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice10;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode7, 27, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode7;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode8, 28, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode8;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode9, 29, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode9;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode10, 30, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode10;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Price11, 31, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Price11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Jprice11, 32, typeof(System.Double), esSystemType.Double);
			c.PropertyName = BeefMetadata.PropertyNames.Jprice11;
			c.NumericPrecision = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.Pcode11, 33, typeof(System.String), esSystemType.String);
			c.PropertyName = BeefMetadata.PropertyNames.Pcode11;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(BeefMetadata.ColumnNames.BeefID, 34, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = BeefMetadata.PropertyNames.BeefID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public BeefMetadata Meta()
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
			 public const string Description = "description";
			 public const string Pcode1 = "pcode1";
			 public const string Price1 = "price1";
			 public const string Pcode2 = "pcode2";
			 public const string Price2 = "price2";
			 public const string Pcode3 = "pcode3";
			 public const string Price3 = "price3";
			 public const string Pcode4 = "pcode4";
			 public const string Price4 = "price4";
			 public const string Pcode5 = "pcode5";
			 public const string Price5 = "price5";
			 public const string Jprice1 = "jprice1";
			 public const string Jprice2 = "jprice2";
			 public const string Jprice3 = "jprice3";
			 public const string Jprice4 = "jprice4";
			 public const string Jprice5 = "jprice5";
			 public const string Pcode6 = "pcode6";
			 public const string Price6 = "price6";
			 public const string Jprice6 = "jprice6";
			 public const string Price7 = "price7";
			 public const string Price8 = "price8";
			 public const string Price9 = "price9";
			 public const string Price10 = "price10";
			 public const string Jprice7 = "jprice7";
			 public const string Jprice8 = "jprice8";
			 public const string Jprice9 = "jprice9";
			 public const string Jprice10 = "jprice10";
			 public const string Pcode7 = "pcode7";
			 public const string Pcode8 = "pcode8";
			 public const string Pcode9 = "pcode9";
			 public const string Pcode10 = "pcode10";
			 public const string Price11 = "price11";
			 public const string Jprice11 = "jprice11";
			 public const string Pcode11 = "pcode11";
			 public const string BeefID = "beefID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Description = "Description";
			 public const string Pcode1 = "Pcode1";
			 public const string Price1 = "Price1";
			 public const string Pcode2 = "Pcode2";
			 public const string Price2 = "Price2";
			 public const string Pcode3 = "Pcode3";
			 public const string Price3 = "Price3";
			 public const string Pcode4 = "Pcode4";
			 public const string Price4 = "Price4";
			 public const string Pcode5 = "Pcode5";
			 public const string Price5 = "Price5";
			 public const string Jprice1 = "Jprice1";
			 public const string Jprice2 = "Jprice2";
			 public const string Jprice3 = "Jprice3";
			 public const string Jprice4 = "Jprice4";
			 public const string Jprice5 = "Jprice5";
			 public const string Pcode6 = "Pcode6";
			 public const string Price6 = "Price6";
			 public const string Jprice6 = "Jprice6";
			 public const string Price7 = "Price7";
			 public const string Price8 = "Price8";
			 public const string Price9 = "Price9";
			 public const string Price10 = "Price10";
			 public const string Jprice7 = "Jprice7";
			 public const string Jprice8 = "Jprice8";
			 public const string Jprice9 = "Jprice9";
			 public const string Jprice10 = "Jprice10";
			 public const string Pcode7 = "Pcode7";
			 public const string Pcode8 = "Pcode8";
			 public const string Pcode9 = "Pcode9";
			 public const string Pcode10 = "Pcode10";
			 public const string Price11 = "Price11";
			 public const string Jprice11 = "Jprice11";
			 public const string Pcode11 = "Pcode11";
			 public const string BeefID = "BeefID";
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
			lock (typeof(BeefMetadata))
			{
				if(BeefMetadata.mapDelegates == null)
				{
					BeefMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (BeefMetadata.meta == null)
				{
					BeefMetadata.meta = new BeefMetadata();
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


				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode4", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode5", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice1", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice2", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice3", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice4", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice5", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode6", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice6", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Price10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice7", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice8", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice9", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice10", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode7", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode8", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode9", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Pcode10", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Price11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Jprice11", new esTypeMap("float", "System.Double"));
				meta.AddTypeMap("Pcode11", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("BeefID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "beef";
				meta.Destination = "beef";
				
				meta.spInsert = "proc_beefInsert";				
				meta.spUpdate = "proc_beefUpdate";		
				meta.spDelete = "proc_beefDelete";
				meta.spLoadAll = "proc_beefLoadAll";
				meta.spLoadByPrimaryKey = "proc_beefLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private BeefMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
