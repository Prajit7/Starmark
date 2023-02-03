﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApp.DataComponent
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="3328")]
	public partial class TicketDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertticketsystem(ticketsystem instance);
    partial void Updateticketsystem(ticketsystem instance);
    partial void Deleteticketsystem(ticketsystem instance);
    #endregion
		
		public TicketDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["_3328ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TicketDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ticketsystem> ticketsystems
		{
			get
			{
				return this.GetTable<ticketsystem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ticketsystem")]
	public partial class ticketsystem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketNo;
		
		private int _EmpId;
		
		private string _EmpName;
		
		private string _Title;
		
		private string _TicketDescription;
		
		private string _TicketTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketNoChanging(int value);
    partial void OnTicketNoChanged();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTicketDescriptionChanging(string value);
    partial void OnTicketDescriptionChanged();
    partial void OnTicketTimeChanging(string value);
    partial void OnTicketTimeChanged();
    #endregion
		
		public ticketsystem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketNo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TicketNo
		{
			get
			{
				return this._TicketNo;
			}
			set
			{
				if ((this._TicketNo != value))
				{
					this.OnTicketNoChanging(value);
					this.SendPropertyChanging();
					this._TicketNo = value;
					this.SendPropertyChanged("TicketNo");
					this.OnTicketNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketDescription", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TicketDescription
		{
			get
			{
				return this._TicketDescription;
			}
			set
			{
				if ((this._TicketDescription != value))
				{
					this.OnTicketDescriptionChanging(value);
					this.SendPropertyChanging();
					this._TicketDescription = value;
					this.SendPropertyChanged("TicketDescription");
					this.OnTicketDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketTime", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TicketTime
		{
			get
			{
				return this._TicketTime;
			}
			set
			{
				if ((this._TicketTime != value))
				{
					this.OnTicketTimeChanging(value);
					this.SendPropertyChanging();
					this._TicketTime = value;
					this.SendPropertyChanged("TicketTime");
					this.OnTicketTimeChanged();
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
}
#pragma warning restore 1591
