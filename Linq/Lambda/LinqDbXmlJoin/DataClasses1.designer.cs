﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36415
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqDbXmlJoin
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sqlpractice")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LinqDbXmlJoin.Properties.Settings.Default.sqlpracticeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AgentPDup> AgentPDups
		{
			get
			{
				return this.GetTable<AgentPDup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AgentPDup")]
	public partial class AgentPDup
	{
		
		private int _AgentID;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _SSN;
		
		private string _Gender;
		
		public AgentPDup()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int AgentID
		{
			get
			{
				return this._AgentID;
			}
			set
			{
				if ((this._AgentID != value))
				{
					this._AgentID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address1", DbType="VarChar(30)")]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this._Address1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address2", DbType="VarChar(30)")]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this._Address2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSN", DbType="VarChar(30)")]
		public string SSN
		{
			get
			{
				return this._SSN;
			}
			set
			{
				if ((this._SSN != value))
				{
					this._SSN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
