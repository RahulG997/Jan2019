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

namespace LambdaJoinDbExample
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
    partial void InsertAgent(Agent instance);
    partial void UpdateAgent(Agent instance);
    partial void DeleteAgent(Agent instance);
    partial void InsertAgentPolicy(AgentPolicy instance);
    partial void UpdateAgentPolicy(AgentPolicy instance);
    partial void DeleteAgentPolicy(AgentPolicy instance);
    partial void InsertPolicy(Policy instance);
    partial void UpdatePolicy(Policy instance);
    partial void DeletePolicy(Policy instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LambdaJoinDbExample.Properties.Settings.Default.sqlpracticeConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Agent> Agents
		{
			get
			{
				return this.GetTable<Agent>();
			}
		}
		
		public System.Data.Linq.Table<AgentPolicy> AgentPolicies
		{
			get
			{
				return this.GetTable<AgentPolicy>();
			}
		}
		
		public System.Data.Linq.Table<Policy> Policies
		{
			get
			{
				return this.GetTable<Policy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Agent")]
	public partial class Agent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AgentID;
		
		private string _FirstName;
		
		private string _MI;
		
		private string _LastName;
		
		private string _FullName;
		
		private string _Gender;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private string _SSN;
		
		private System.Nullable<int> _MaritalStatus;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _City;
		
		private string _STATE;
		
		private string _ZipCode;
		
		private string _Country;
		
		private System.Nullable<System.DateTime> _InsertedOn;
		
		private string _InsertedBy;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		private string _UpdatedBy;
		
		private System.Nullable<System.DateTime> _DeletedOn;
		
		private string _DeletedBy;
		
		private EntitySet<AgentPolicy> _AgentPolicies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgentIDChanging(int value);
    partial void OnAgentIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMIChanging(string value);
    partial void OnMIChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnSSNChanging(string value);
    partial void OnSSNChanged();
    partial void OnMaritalStatusChanging(System.Nullable<int> value);
    partial void OnMaritalStatusChanged();
    partial void OnAddress1Changing(string value);
    partial void OnAddress1Changed();
    partial void OnAddress2Changing(string value);
    partial void OnAddress2Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnSTATEChanging(string value);
    partial void OnSTATEChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnInsertedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertedOnChanged();
    partial void OnInsertedByChanging(string value);
    partial void OnInsertedByChanged();
    partial void OnUpdatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedOnChanged();
    partial void OnUpdatedByChanging(string value);
    partial void OnUpdatedByChanged();
    partial void OnDeletedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnDeletedOnChanged();
    partial void OnDeletedByChanging(string value);
    partial void OnDeletedByChanged();
    #endregion
		
		public Agent()
		{
			this._AgentPolicies = new EntitySet<AgentPolicy>(new Action<AgentPolicy>(this.attach_AgentPolicies), new Action<AgentPolicy>(this.detach_AgentPolicies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnAgentIDChanging(value);
					this.SendPropertyChanging();
					this._AgentID = value;
					this.SendPropertyChanged("AgentID");
					this.OnAgentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(30)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI", DbType="VarChar(1)")]
		public string MI
		{
			get
			{
				return this._MI;
			}
			set
			{
				if ((this._MI != value))
				{
					this.OnMIChanging(value);
					this.SendPropertyChanging();
					this._MI = value;
					this.SendPropertyChanged("MI");
					this.OnMIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(30)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(80)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
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
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="DateTime")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
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
					this.OnSSNChanging(value);
					this.SendPropertyChanging();
					this._SSN = value;
					this.SendPropertyChanged("SSN");
					this.OnSSNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaritalStatus", DbType="Int")]
		public System.Nullable<int> MaritalStatus
		{
			get
			{
				return this._MaritalStatus;
			}
			set
			{
				if ((this._MaritalStatus != value))
				{
					this.OnMaritalStatusChanging(value);
					this.SendPropertyChanging();
					this._MaritalStatus = value;
					this.SendPropertyChanged("MaritalStatus");
					this.OnMaritalStatusChanged();
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
					this.OnAddress1Changing(value);
					this.SendPropertyChanging();
					this._Address1 = value;
					this.SendPropertyChanged("Address1");
					this.OnAddress1Changed();
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
					this.OnAddress2Changing(value);
					this.SendPropertyChanging();
					this._Address2 = value;
					this.SendPropertyChanged("Address2");
					this.OnAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(30)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATE", DbType="VarChar(30)")]
		public string STATE
		{
			get
			{
				return this._STATE;
			}
			set
			{
				if ((this._STATE != value))
				{
					this.OnSTATEChanging(value);
					this.SendPropertyChanging();
					this._STATE = value;
					this.SendPropertyChanged("STATE");
					this.OnSTATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(30)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(30)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertedOn
		{
			get
			{
				return this._InsertedOn;
			}
			set
			{
				if ((this._InsertedOn != value))
				{
					this.OnInsertedOnChanging(value);
					this.SendPropertyChanging();
					this._InsertedOn = value;
					this.SendPropertyChanged("InsertedOn");
					this.OnInsertedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedBy", DbType="VarChar(30)")]
		public string InsertedBy
		{
			get
			{
				return this._InsertedBy;
			}
			set
			{
				if ((this._InsertedBy != value))
				{
					this.OnInsertedByChanging(value);
					this.SendPropertyChanging();
					this._InsertedBy = value;
					this.SendPropertyChanged("InsertedBy");
					this.OnInsertedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this.OnUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._UpdatedOn = value;
					this.SendPropertyChanged("UpdatedOn");
					this.OnUpdatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedBy", DbType="VarChar(30)")]
		public string UpdatedBy
		{
			get
			{
				return this._UpdatedBy;
			}
			set
			{
				if ((this._UpdatedBy != value))
				{
					this.OnUpdatedByChanging(value);
					this.SendPropertyChanging();
					this._UpdatedBy = value;
					this.SendPropertyChanged("UpdatedBy");
					this.OnUpdatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeletedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeletedOn
		{
			get
			{
				return this._DeletedOn;
			}
			set
			{
				if ((this._DeletedOn != value))
				{
					this.OnDeletedOnChanging(value);
					this.SendPropertyChanging();
					this._DeletedOn = value;
					this.SendPropertyChanged("DeletedOn");
					this.OnDeletedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeletedBy", DbType="VarChar(30)")]
		public string DeletedBy
		{
			get
			{
				return this._DeletedBy;
			}
			set
			{
				if ((this._DeletedBy != value))
				{
					this.OnDeletedByChanging(value);
					this.SendPropertyChanging();
					this._DeletedBy = value;
					this.SendPropertyChanged("DeletedBy");
					this.OnDeletedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agent_AgentPolicy", Storage="_AgentPolicies", ThisKey="AgentID", OtherKey="AgentID")]
		public EntitySet<AgentPolicy> AgentPolicies
		{
			get
			{
				return this._AgentPolicies;
			}
			set
			{
				this._AgentPolicies.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AgentPolicies(AgentPolicy entity)
		{
			this.SendPropertyChanging();
			entity.Agent = this;
		}
		
		private void detach_AgentPolicies(AgentPolicy entity)
		{
			this.SendPropertyChanging();
			entity.Agent = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AgentPolicy")]
	public partial class AgentPolicy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AgentID;
		
		private int _PolicyID;
		
		private System.Nullable<int> _IsSplitAgent;
		
		private System.Nullable<System.DateTime> _InsertedOn;
		
		private string _InsertedBy;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		private string _UpdatedBy;
		
		private System.Nullable<System.DateTime> _DeletedOn;
		
		private string _DeletedBy;
		
		private EntityRef<Agent> _Agent;
		
		private EntityRef<Policy> _Policy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgentIDChanging(int value);
    partial void OnAgentIDChanged();
    partial void OnPolicyIDChanging(int value);
    partial void OnPolicyIDChanged();
    partial void OnIsSplitAgentChanging(System.Nullable<int> value);
    partial void OnIsSplitAgentChanged();
    partial void OnInsertedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertedOnChanged();
    partial void OnInsertedByChanging(string value);
    partial void OnInsertedByChanged();
    partial void OnUpdatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedOnChanged();
    partial void OnUpdatedByChanging(string value);
    partial void OnUpdatedByChanged();
    partial void OnDeletedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnDeletedOnChanged();
    partial void OnDeletedByChanging(string value);
    partial void OnDeletedByChanged();
    #endregion
		
		public AgentPolicy()
		{
			this._Agent = default(EntityRef<Agent>);
			this._Policy = default(EntityRef<Policy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
					if (this._Agent.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAgentIDChanging(value);
					this.SendPropertyChanging();
					this._AgentID = value;
					this.SendPropertyChanged("AgentID");
					this.OnAgentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PolicyID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PolicyID
		{
			get
			{
				return this._PolicyID;
			}
			set
			{
				if ((this._PolicyID != value))
				{
					if (this._Policy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPolicyIDChanging(value);
					this.SendPropertyChanging();
					this._PolicyID = value;
					this.SendPropertyChanged("PolicyID");
					this.OnPolicyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSplitAgent", DbType="Int")]
		public System.Nullable<int> IsSplitAgent
		{
			get
			{
				return this._IsSplitAgent;
			}
			set
			{
				if ((this._IsSplitAgent != value))
				{
					this.OnIsSplitAgentChanging(value);
					this.SendPropertyChanging();
					this._IsSplitAgent = value;
					this.SendPropertyChanged("IsSplitAgent");
					this.OnIsSplitAgentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertedOn
		{
			get
			{
				return this._InsertedOn;
			}
			set
			{
				if ((this._InsertedOn != value))
				{
					this.OnInsertedOnChanging(value);
					this.SendPropertyChanging();
					this._InsertedOn = value;
					this.SendPropertyChanged("InsertedOn");
					this.OnInsertedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedBy", DbType="VarChar(30)")]
		public string InsertedBy
		{
			get
			{
				return this._InsertedBy;
			}
			set
			{
				if ((this._InsertedBy != value))
				{
					this.OnInsertedByChanging(value);
					this.SendPropertyChanging();
					this._InsertedBy = value;
					this.SendPropertyChanged("InsertedBy");
					this.OnInsertedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this.OnUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._UpdatedOn = value;
					this.SendPropertyChanged("UpdatedOn");
					this.OnUpdatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedBy", DbType="VarChar(30)")]
		public string UpdatedBy
		{
			get
			{
				return this._UpdatedBy;
			}
			set
			{
				if ((this._UpdatedBy != value))
				{
					this.OnUpdatedByChanging(value);
					this.SendPropertyChanging();
					this._UpdatedBy = value;
					this.SendPropertyChanged("UpdatedBy");
					this.OnUpdatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeletedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeletedOn
		{
			get
			{
				return this._DeletedOn;
			}
			set
			{
				if ((this._DeletedOn != value))
				{
					this.OnDeletedOnChanging(value);
					this.SendPropertyChanging();
					this._DeletedOn = value;
					this.SendPropertyChanged("DeletedOn");
					this.OnDeletedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeletedBy", DbType="VarChar(30)")]
		public string DeletedBy
		{
			get
			{
				return this._DeletedBy;
			}
			set
			{
				if ((this._DeletedBy != value))
				{
					this.OnDeletedByChanging(value);
					this.SendPropertyChanging();
					this._DeletedBy = value;
					this.SendPropertyChanged("DeletedBy");
					this.OnDeletedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agent_AgentPolicy", Storage="_Agent", ThisKey="AgentID", OtherKey="AgentID", IsForeignKey=true)]
		public Agent Agent
		{
			get
			{
				return this._Agent.Entity;
			}
			set
			{
				Agent previousValue = this._Agent.Entity;
				if (((previousValue != value) 
							|| (this._Agent.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Agent.Entity = null;
						previousValue.AgentPolicies.Remove(this);
					}
					this._Agent.Entity = value;
					if ((value != null))
					{
						value.AgentPolicies.Add(this);
						this._AgentID = value.AgentID;
					}
					else
					{
						this._AgentID = default(int);
					}
					this.SendPropertyChanged("Agent");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Policy_AgentPolicy", Storage="_Policy", ThisKey="PolicyID", OtherKey="PolicyID", IsForeignKey=true)]
		public Policy Policy
		{
			get
			{
				return this._Policy.Entity;
			}
			set
			{
				Policy previousValue = this._Policy.Entity;
				if (((previousValue != value) 
							|| (this._Policy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Policy.Entity = null;
						previousValue.AgentPolicies.Remove(this);
					}
					this._Policy.Entity = value;
					if ((value != null))
					{
						value.AgentPolicies.Add(this);
						this._PolicyID = value.PolicyID;
					}
					else
					{
						this._PolicyID = default(int);
					}
					this.SendPropertyChanged("Policy");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Policy")]
	public partial class Policy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PolicyID;
		
		private string _AppNumber;
		
		private System.Nullable<System.DateTime> _AppDate;
		
		private string _PolicyNumber;
		
		private System.Nullable<decimal> _AnnualPremium;
		
		private System.Nullable<int> _PaymentModeID;
		
		private System.Nullable<decimal> _ModalPremium;
		
		private System.Nullable<System.DateTime> _InsertedOn;
		
		private string _InsertedBy;
		
		private System.Nullable<System.DateTime> _UpdatedOn;
		
		private string _UpdatedBy;
		
		private System.Nullable<System.DateTime> _Deletedon;
		
		private string _DeletedBy;
		
		private EntitySet<AgentPolicy> _AgentPolicies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPolicyIDChanging(int value);
    partial void OnPolicyIDChanged();
    partial void OnAppNumberChanging(string value);
    partial void OnAppNumberChanged();
    partial void OnAppDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAppDateChanged();
    partial void OnPolicyNumberChanging(string value);
    partial void OnPolicyNumberChanged();
    partial void OnAnnualPremiumChanging(System.Nullable<decimal> value);
    partial void OnAnnualPremiumChanged();
    partial void OnPaymentModeIDChanging(System.Nullable<int> value);
    partial void OnPaymentModeIDChanged();
    partial void OnModalPremiumChanging(System.Nullable<decimal> value);
    partial void OnModalPremiumChanged();
    partial void OnInsertedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertedOnChanged();
    partial void OnInsertedByChanging(string value);
    partial void OnInsertedByChanged();
    partial void OnUpdatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedOnChanged();
    partial void OnUpdatedByChanging(string value);
    partial void OnUpdatedByChanged();
    partial void OnDeletedonChanging(System.Nullable<System.DateTime> value);
    partial void OnDeletedonChanged();
    partial void OnDeletedByChanging(string value);
    partial void OnDeletedByChanged();
    #endregion
		
		public Policy()
		{
			this._AgentPolicies = new EntitySet<AgentPolicy>(new Action<AgentPolicy>(this.attach_AgentPolicies), new Action<AgentPolicy>(this.detach_AgentPolicies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PolicyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PolicyID
		{
			get
			{
				return this._PolicyID;
			}
			set
			{
				if ((this._PolicyID != value))
				{
					this.OnPolicyIDChanging(value);
					this.SendPropertyChanging();
					this._PolicyID = value;
					this.SendPropertyChanged("PolicyID");
					this.OnPolicyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppNumber", DbType="VarChar(30)")]
		public string AppNumber
		{
			get
			{
				return this._AppNumber;
			}
			set
			{
				if ((this._AppNumber != value))
				{
					this.OnAppNumberChanging(value);
					this.SendPropertyChanging();
					this._AppNumber = value;
					this.SendPropertyChanged("AppNumber");
					this.OnAppNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AppDate
		{
			get
			{
				return this._AppDate;
			}
			set
			{
				if ((this._AppDate != value))
				{
					this.OnAppDateChanging(value);
					this.SendPropertyChanging();
					this._AppDate = value;
					this.SendPropertyChanged("AppDate");
					this.OnAppDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PolicyNumber", DbType="VarChar(30)")]
		public string PolicyNumber
		{
			get
			{
				return this._PolicyNumber;
			}
			set
			{
				if ((this._PolicyNumber != value))
				{
					this.OnPolicyNumberChanging(value);
					this.SendPropertyChanging();
					this._PolicyNumber = value;
					this.SendPropertyChanged("PolicyNumber");
					this.OnPolicyNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnnualPremium", DbType="Decimal(9,2)")]
		public System.Nullable<decimal> AnnualPremium
		{
			get
			{
				return this._AnnualPremium;
			}
			set
			{
				if ((this._AnnualPremium != value))
				{
					this.OnAnnualPremiumChanging(value);
					this.SendPropertyChanging();
					this._AnnualPremium = value;
					this.SendPropertyChanged("AnnualPremium");
					this.OnAnnualPremiumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentModeID", DbType="Int")]
		public System.Nullable<int> PaymentModeID
		{
			get
			{
				return this._PaymentModeID;
			}
			set
			{
				if ((this._PaymentModeID != value))
				{
					this.OnPaymentModeIDChanging(value);
					this.SendPropertyChanging();
					this._PaymentModeID = value;
					this.SendPropertyChanged("PaymentModeID");
					this.OnPaymentModeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModalPremium", DbType="Decimal(9,2)")]
		public System.Nullable<decimal> ModalPremium
		{
			get
			{
				return this._ModalPremium;
			}
			set
			{
				if ((this._ModalPremium != value))
				{
					this.OnModalPremiumChanging(value);
					this.SendPropertyChanging();
					this._ModalPremium = value;
					this.SendPropertyChanged("ModalPremium");
					this.OnModalPremiumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertedOn
		{
			get
			{
				return this._InsertedOn;
			}
			set
			{
				if ((this._InsertedOn != value))
				{
					this.OnInsertedOnChanging(value);
					this.SendPropertyChanging();
					this._InsertedOn = value;
					this.SendPropertyChanged("InsertedOn");
					this.OnInsertedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertedBy", DbType="VarChar(30)")]
		public string InsertedBy
		{
			get
			{
				return this._InsertedBy;
			}
			set
			{
				if ((this._InsertedBy != value))
				{
					this.OnInsertedByChanging(value);
					this.SendPropertyChanging();
					this._InsertedBy = value;
					this.SendPropertyChanged("InsertedBy");
					this.OnInsertedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedOn
		{
			get
			{
				return this._UpdatedOn;
			}
			set
			{
				if ((this._UpdatedOn != value))
				{
					this.OnUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._UpdatedOn = value;
					this.SendPropertyChanged("UpdatedOn");
					this.OnUpdatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedBy", DbType="VarChar(30)")]
		public string UpdatedBy
		{
			get
			{
				return this._UpdatedBy;
			}
			set
			{
				if ((this._UpdatedBy != value))
				{
					this.OnUpdatedByChanging(value);
					this.SendPropertyChanging();
					this._UpdatedBy = value;
					this.SendPropertyChanged("UpdatedBy");
					this.OnUpdatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deletedon", DbType="DateTime")]
		public System.Nullable<System.DateTime> Deletedon
		{
			get
			{
				return this._Deletedon;
			}
			set
			{
				if ((this._Deletedon != value))
				{
					this.OnDeletedonChanging(value);
					this.SendPropertyChanging();
					this._Deletedon = value;
					this.SendPropertyChanged("Deletedon");
					this.OnDeletedonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeletedBy", DbType="VarChar(30)")]
		public string DeletedBy
		{
			get
			{
				return this._DeletedBy;
			}
			set
			{
				if ((this._DeletedBy != value))
				{
					this.OnDeletedByChanging(value);
					this.SendPropertyChanging();
					this._DeletedBy = value;
					this.SendPropertyChanged("DeletedBy");
					this.OnDeletedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Policy_AgentPolicy", Storage="_AgentPolicies", ThisKey="PolicyID", OtherKey="PolicyID")]
		public EntitySet<AgentPolicy> AgentPolicies
		{
			get
			{
				return this._AgentPolicies;
			}
			set
			{
				this._AgentPolicies.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AgentPolicies(AgentPolicy entity)
		{
			this.SendPropertyChanging();
			entity.Policy = this;
		}
		
		private void detach_AgentPolicies(AgentPolicy entity)
		{
			this.SendPropertyChanging();
			entity.Policy = null;
		}
	}
}
#pragma warning restore 1591
