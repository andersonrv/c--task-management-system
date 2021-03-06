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

namespace Task_Management_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aresendeviana683")]
	public partial class LinqToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBoardAccess(TBoardAccess instance);
    partial void UpdateTBoardAccess(TBoardAccess instance);
    partial void DeleteTBoardAccess(TBoardAccess instance);
    partial void InsertTBoard(TBoard instance);
    partial void UpdateTBoard(TBoard instance);
    partial void DeleteTBoard(TBoard instance);
    partial void InsertTStatus(TStatus instance);
    partial void UpdateTStatus(TStatus instance);
    partial void DeleteTStatus(TStatus instance);
    partial void InsertTTask(TTask instance);
    partial void UpdateTTask(TTask instance);
    partial void DeleteTTask(TTask instance);
    partial void InsertTUser(TUser instance);
    partial void UpdateTUser(TUser instance);
    partial void DeleteTUser(TUser instance);
    partial void InsertTList(TList instance);
    partial void UpdateTList(TList instance);
    partial void DeleteTList(TList instance);
    #endregion
		
		public LinqToSQLDataContext() : 
				base(global::Task_Management_System.Properties.Settings.Default.TMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBoardAccess> TBoardAccesses
		{
			get
			{
				return this.GetTable<TBoardAccess>();
			}
		}
		
		public System.Data.Linq.Table<TBoard> TBoards
		{
			get
			{
				return this.GetTable<TBoard>();
			}
		}
		
		public System.Data.Linq.Table<TStatus> TStatus
		{
			get
			{
				return this.GetTable<TStatus>();
			}
		}
		
		public System.Data.Linq.Table<TTask> TTasks
		{
			get
			{
				return this.GetTable<TTask>();
			}
		}
		
		public System.Data.Linq.Table<TUser> TUsers
		{
			get
			{
				return this.GetTable<TUser>();
			}
		}
		
		public System.Data.Linq.Table<TList> TLists
		{
			get
			{
				return this.GetTable<TList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBoardAccess")]
	public partial class TBoardAccess : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccessId;
		
		private System.Nullable<int> _BoardId;
		
		private System.Nullable<int> _UserId;
		
		private System.Nullable<bool> _IsUserAdm;
		
		private EntityRef<TBoard> _TBoard;
		
		private EntityRef<TUser> _TUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccessIdChanging(int value);
    partial void OnAccessIdChanged();
    partial void OnBoardIdChanging(System.Nullable<int> value);
    partial void OnBoardIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnIsUserAdmChanging(System.Nullable<bool> value);
    partial void OnIsUserAdmChanged();
    #endregion
		
		public TBoardAccess()
		{
			this._TBoard = default(EntityRef<TBoard>);
			this._TUser = default(EntityRef<TUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AccessId
		{
			get
			{
				return this._AccessId;
			}
			set
			{
				if ((this._AccessId != value))
				{
					this.OnAccessIdChanging(value);
					this.SendPropertyChanging();
					this._AccessId = value;
					this.SendPropertyChanged("AccessId");
					this.OnAccessIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardId", DbType="Int")]
		public System.Nullable<int> BoardId
		{
			get
			{
				return this._BoardId;
			}
			set
			{
				if ((this._BoardId != value))
				{
					if (this._TBoard.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBoardIdChanging(value);
					this.SendPropertyChanging();
					this._BoardId = value;
					this.SendPropertyChanged("BoardId");
					this.OnBoardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._TUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsUserAdm", DbType="Bit")]
		public System.Nullable<bool> IsUserAdm
		{
			get
			{
				return this._IsUserAdm;
			}
			set
			{
				if ((this._IsUserAdm != value))
				{
					this.OnIsUserAdmChanging(value);
					this.SendPropertyChanging();
					this._IsUserAdm = value;
					this.SendPropertyChanged("IsUserAdm");
					this.OnIsUserAdmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TBoardAccess", Storage="_TBoard", ThisKey="BoardId", OtherKey="BoardId", IsForeignKey=true)]
		public TBoard TBoard
		{
			get
			{
				return this._TBoard.Entity;
			}
			set
			{
				TBoard previousValue = this._TBoard.Entity;
				if (((previousValue != value) 
							|| (this._TBoard.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBoard.Entity = null;
						previousValue.TBoardAccesses.Remove(this);
					}
					this._TBoard.Entity = value;
					if ((value != null))
					{
						value.TBoardAccesses.Add(this);
						this._BoardId = value.BoardId;
					}
					else
					{
						this._BoardId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TBoard");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUser_TBoardAccess", Storage="_TUser", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public TUser TUser
		{
			get
			{
				return this._TUser.Entity;
			}
			set
			{
				TUser previousValue = this._TUser.Entity;
				if (((previousValue != value) 
							|| (this._TUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TUser.Entity = null;
						previousValue.TBoardAccesses.Remove(this);
					}
					this._TUser.Entity = value;
					if ((value != null))
					{
						value.TBoardAccesses.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBoards")]
	public partial class TBoard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BoardId;
		
		private string _BoardName;
		
		private System.Nullable<int> _UserId;
		
		private EntitySet<TBoardAccess> _TBoardAccesses;
		
		private EntitySet<TTask> _TTasks;
		
		private EntitySet<TList> _TLists;
		
		private EntityRef<TUser> _TUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBoardIdChanging(int value);
    partial void OnBoardIdChanged();
    partial void OnBoardNameChanging(string value);
    partial void OnBoardNameChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    #endregion
		
		public TBoard()
		{
			this._TBoardAccesses = new EntitySet<TBoardAccess>(new Action<TBoardAccess>(this.attach_TBoardAccesses), new Action<TBoardAccess>(this.detach_TBoardAccesses));
			this._TTasks = new EntitySet<TTask>(new Action<TTask>(this.attach_TTasks), new Action<TTask>(this.detach_TTasks));
			this._TLists = new EntitySet<TList>(new Action<TList>(this.attach_TLists), new Action<TList>(this.detach_TLists));
			this._TUser = default(EntityRef<TUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BoardId
		{
			get
			{
				return this._BoardId;
			}
			set
			{
				if ((this._BoardId != value))
				{
					this.OnBoardIdChanging(value);
					this.SendPropertyChanging();
					this._BoardId = value;
					this.SendPropertyChanged("BoardId");
					this.OnBoardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardName", DbType="NVarChar(80)")]
		public string BoardName
		{
			get
			{
				return this._BoardName;
			}
			set
			{
				if ((this._BoardName != value))
				{
					this.OnBoardNameChanging(value);
					this.SendPropertyChanging();
					this._BoardName = value;
					this.SendPropertyChanged("BoardName");
					this.OnBoardNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._TUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TBoardAccess", Storage="_TBoardAccesses", ThisKey="BoardId", OtherKey="BoardId")]
		public EntitySet<TBoardAccess> TBoardAccesses
		{
			get
			{
				return this._TBoardAccesses;
			}
			set
			{
				this._TBoardAccesses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TTask", Storage="_TTasks", ThisKey="BoardId", OtherKey="TaskWho")]
		public EntitySet<TTask> TTasks
		{
			get
			{
				return this._TTasks;
			}
			set
			{
				this._TTasks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TList", Storage="_TLists", ThisKey="BoardId", OtherKey="BoardId")]
		public EntitySet<TList> TLists
		{
			get
			{
				return this._TLists;
			}
			set
			{
				this._TLists.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUser_TBoard", Storage="_TUser", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true)]
		public TUser TUser
		{
			get
			{
				return this._TUser.Entity;
			}
			set
			{
				TUser previousValue = this._TUser.Entity;
				if (((previousValue != value) 
							|| (this._TUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TUser.Entity = null;
						previousValue.TBoards.Remove(this);
					}
					this._TUser.Entity = value;
					if ((value != null))
					{
						value.TBoards.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TUser");
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
		
		private void attach_TBoardAccesses(TBoardAccess entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = this;
		}
		
		private void detach_TBoardAccesses(TBoardAccess entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = null;
		}
		
		private void attach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = this;
		}
		
		private void detach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = null;
		}
		
		private void attach_TLists(TList entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = this;
		}
		
		private void detach_TLists(TList entity)
		{
			this.SendPropertyChanging();
			entity.TBoard = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TStatus")]
	public partial class TStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StatusId;
		
		private string _StatusName;
		
		private EntitySet<TTask> _TTasks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStatusIdChanging(int value);
    partial void OnStatusIdChanged();
    partial void OnStatusNameChanging(string value);
    partial void OnStatusNameChanged();
    #endregion
		
		public TStatus()
		{
			this._TTasks = new EntitySet<TTask>(new Action<TTask>(this.attach_TTasks), new Action<TTask>(this.detach_TTasks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StatusId
		{
			get
			{
				return this._StatusId;
			}
			set
			{
				if ((this._StatusId != value))
				{
					this.OnStatusIdChanging(value);
					this.SendPropertyChanging();
					this._StatusId = value;
					this.SendPropertyChanged("StatusId");
					this.OnStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusName", DbType="NVarChar(30)")]
		public string StatusName
		{
			get
			{
				return this._StatusName;
			}
			set
			{
				if ((this._StatusName != value))
				{
					this.OnStatusNameChanging(value);
					this.SendPropertyChanging();
					this._StatusName = value;
					this.SendPropertyChanged("StatusName");
					this.OnStatusNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TStatus_TTask", Storage="_TTasks", ThisKey="StatusId", OtherKey="TaskStatus")]
		public EntitySet<TTask> TTasks
		{
			get
			{
				return this._TTasks;
			}
			set
			{
				this._TTasks.Assign(value);
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
		
		private void attach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TStatus = this;
		}
		
		private void detach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TStatus = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TTasks")]
	public partial class TTask : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TasktId;
		
		private string _TaskName;
		
		private string _TaskDescription;
		
		private System.Nullable<System.DateTime> _TaskDue;
		
		private System.Nullable<int> _TaskWho;
		
		private System.Nullable<int> _TaskStatus;
		
		private System.Nullable<int> _TaskList;
		
		private EntityRef<TStatus> _TStatus;
		
		private EntityRef<TBoard> _TBoard;
		
		private EntityRef<TList> _TList;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTasktIdChanging(int value);
    partial void OnTasktIdChanged();
    partial void OnTaskNameChanging(string value);
    partial void OnTaskNameChanged();
    partial void OnTaskDescriptionChanging(string value);
    partial void OnTaskDescriptionChanged();
    partial void OnTaskDueChanging(System.Nullable<System.DateTime> value);
    partial void OnTaskDueChanged();
    partial void OnTaskWhoChanging(System.Nullable<int> value);
    partial void OnTaskWhoChanged();
    partial void OnTaskStatusChanging(System.Nullable<int> value);
    partial void OnTaskStatusChanged();
    partial void OnTaskListChanging(System.Nullable<int> value);
    partial void OnTaskListChanged();
    #endregion
		
		public TTask()
		{
			this._TStatus = default(EntityRef<TStatus>);
			this._TBoard = default(EntityRef<TBoard>);
			this._TList = default(EntityRef<TList>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TasktId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TasktId
		{
			get
			{
				return this._TasktId;
			}
			set
			{
				if ((this._TasktId != value))
				{
					this.OnTasktIdChanging(value);
					this.SendPropertyChanging();
					this._TasktId = value;
					this.SendPropertyChanged("TasktId");
					this.OnTasktIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskName", DbType="NVarChar(80)")]
		public string TaskName
		{
			get
			{
				return this._TaskName;
			}
			set
			{
				if ((this._TaskName != value))
				{
					this.OnTaskNameChanging(value);
					this.SendPropertyChanging();
					this._TaskName = value;
					this.SendPropertyChanged("TaskName");
					this.OnTaskNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskDescription", DbType="NVarChar(1000)")]
		public string TaskDescription
		{
			get
			{
				return this._TaskDescription;
			}
			set
			{
				if ((this._TaskDescription != value))
				{
					this.OnTaskDescriptionChanging(value);
					this.SendPropertyChanging();
					this._TaskDescription = value;
					this.SendPropertyChanged("TaskDescription");
					this.OnTaskDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskDue", DbType="DateTime2")]
		public System.Nullable<System.DateTime> TaskDue
		{
			get
			{
				return this._TaskDue;
			}
			set
			{
				if ((this._TaskDue != value))
				{
					this.OnTaskDueChanging(value);
					this.SendPropertyChanging();
					this._TaskDue = value;
					this.SendPropertyChanged("TaskDue");
					this.OnTaskDueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskWho", DbType="Int")]
		public System.Nullable<int> TaskWho
		{
			get
			{
				return this._TaskWho;
			}
			set
			{
				if ((this._TaskWho != value))
				{
					if (this._TBoard.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTaskWhoChanging(value);
					this.SendPropertyChanging();
					this._TaskWho = value;
					this.SendPropertyChanged("TaskWho");
					this.OnTaskWhoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskStatus", DbType="Int")]
		public System.Nullable<int> TaskStatus
		{
			get
			{
				return this._TaskStatus;
			}
			set
			{
				if ((this._TaskStatus != value))
				{
					if (this._TStatus.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTaskStatusChanging(value);
					this.SendPropertyChanging();
					this._TaskStatus = value;
					this.SendPropertyChanged("TaskStatus");
					this.OnTaskStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskList", DbType="Int")]
		public System.Nullable<int> TaskList
		{
			get
			{
				return this._TaskList;
			}
			set
			{
				if ((this._TaskList != value))
				{
					if (this._TList.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTaskListChanging(value);
					this.SendPropertyChanging();
					this._TaskList = value;
					this.SendPropertyChanged("TaskList");
					this.OnTaskListChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TStatus_TTask", Storage="_TStatus", ThisKey="TaskStatus", OtherKey="StatusId", IsForeignKey=true)]
		public TStatus TStatus
		{
			get
			{
				return this._TStatus.Entity;
			}
			set
			{
				TStatus previousValue = this._TStatus.Entity;
				if (((previousValue != value) 
							|| (this._TStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TStatus.Entity = null;
						previousValue.TTasks.Remove(this);
					}
					this._TStatus.Entity = value;
					if ((value != null))
					{
						value.TTasks.Add(this);
						this._TaskStatus = value.StatusId;
					}
					else
					{
						this._TaskStatus = default(Nullable<int>);
					}
					this.SendPropertyChanged("TStatus");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TTask", Storage="_TBoard", ThisKey="TaskWho", OtherKey="BoardId", IsForeignKey=true)]
		public TBoard TBoard
		{
			get
			{
				return this._TBoard.Entity;
			}
			set
			{
				TBoard previousValue = this._TBoard.Entity;
				if (((previousValue != value) 
							|| (this._TBoard.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBoard.Entity = null;
						previousValue.TTasks.Remove(this);
					}
					this._TBoard.Entity = value;
					if ((value != null))
					{
						value.TTasks.Add(this);
						this._TaskWho = value.BoardId;
					}
					else
					{
						this._TaskWho = default(Nullable<int>);
					}
					this.SendPropertyChanged("TBoard");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TList_TTask", Storage="_TList", ThisKey="TaskList", OtherKey="ListId", IsForeignKey=true)]
		public TList TList
		{
			get
			{
				return this._TList.Entity;
			}
			set
			{
				TList previousValue = this._TList.Entity;
				if (((previousValue != value) 
							|| (this._TList.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TList.Entity = null;
						previousValue.TTasks.Remove(this);
					}
					this._TList.Entity = value;
					if ((value != null))
					{
						value.TTasks.Add(this);
						this._TaskList = value.ListId;
					}
					else
					{
						this._TaskList = default(Nullable<int>);
					}
					this.SendPropertyChanged("TList");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TUsers")]
	public partial class TUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private string _Pass;
		
		private EntitySet<TBoardAccess> _TBoardAccesses;
		
		private EntitySet<TBoard> _TBoards;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    #endregion
		
		public TUser()
		{
			this._TBoardAccesses = new EntitySet<TBoardAccess>(new Action<TBoardAccess>(this.attach_TBoardAccesses), new Action<TBoardAccess>(this.detach_TBoardAccesses));
			this._TBoards = new EntitySet<TBoard>(new Action<TBoard>(this.attach_TBoards), new Action<TBoard>(this.detach_TBoards));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(80)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(12)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUser_TBoardAccess", Storage="_TBoardAccesses", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<TBoardAccess> TBoardAccesses
		{
			get
			{
				return this._TBoardAccesses;
			}
			set
			{
				this._TBoardAccesses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUser_TBoard", Storage="_TBoards", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<TBoard> TBoards
		{
			get
			{
				return this._TBoards;
			}
			set
			{
				this._TBoards.Assign(value);
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
		
		private void attach_TBoardAccesses(TBoardAccess entity)
		{
			this.SendPropertyChanging();
			entity.TUser = this;
		}
		
		private void detach_TBoardAccesses(TBoardAccess entity)
		{
			this.SendPropertyChanging();
			entity.TUser = null;
		}
		
		private void attach_TBoards(TBoard entity)
		{
			this.SendPropertyChanging();
			entity.TUser = this;
		}
		
		private void detach_TBoards(TBoard entity)
		{
			this.SendPropertyChanging();
			entity.TUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLists")]
	public partial class TList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ListId;
		
		private string _ListName;
		
		private System.Nullable<int> _BoardId;
		
		private EntitySet<TTask> _TTasks;
		
		private EntityRef<TBoard> _TBoard;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnListIdChanging(int value);
    partial void OnListIdChanged();
    partial void OnListNameChanging(string value);
    partial void OnListNameChanged();
    partial void OnBoardIdChanging(System.Nullable<int> value);
    partial void OnBoardIdChanged();
    #endregion
		
		public TList()
		{
			this._TTasks = new EntitySet<TTask>(new Action<TTask>(this.attach_TTasks), new Action<TTask>(this.detach_TTasks));
			this._TBoard = default(EntityRef<TBoard>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ListId
		{
			get
			{
				return this._ListId;
			}
			set
			{
				if ((this._ListId != value))
				{
					this.OnListIdChanging(value);
					this.SendPropertyChanging();
					this._ListId = value;
					this.SendPropertyChanged("ListId");
					this.OnListIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListName", DbType="NVarChar(80)")]
		public string ListName
		{
			get
			{
				return this._ListName;
			}
			set
			{
				if ((this._ListName != value))
				{
					this.OnListNameChanging(value);
					this.SendPropertyChanging();
					this._ListName = value;
					this.SendPropertyChanged("ListName");
					this.OnListNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardId", DbType="Int")]
		public System.Nullable<int> BoardId
		{
			get
			{
				return this._BoardId;
			}
			set
			{
				if ((this._BoardId != value))
				{
					if (this._TBoard.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBoardIdChanging(value);
					this.SendPropertyChanging();
					this._BoardId = value;
					this.SendPropertyChanged("BoardId");
					this.OnBoardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TList_TTask", Storage="_TTasks", ThisKey="ListId", OtherKey="TaskList")]
		public EntitySet<TTask> TTasks
		{
			get
			{
				return this._TTasks;
			}
			set
			{
				this._TTasks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBoard_TList", Storage="_TBoard", ThisKey="BoardId", OtherKey="BoardId", IsForeignKey=true)]
		public TBoard TBoard
		{
			get
			{
				return this._TBoard.Entity;
			}
			set
			{
				TBoard previousValue = this._TBoard.Entity;
				if (((previousValue != value) 
							|| (this._TBoard.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBoard.Entity = null;
						previousValue.TLists.Remove(this);
					}
					this._TBoard.Entity = value;
					if ((value != null))
					{
						value.TLists.Add(this);
						this._BoardId = value.BoardId;
					}
					else
					{
						this._BoardId = default(Nullable<int>);
					}
					this.SendPropertyChanged("TBoard");
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
		
		private void attach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TList = this;
		}
		
		private void detach_TTasks(TTask entity)
		{
			this.SendPropertyChanging();
			entity.TList = null;
		}
	}
}
#pragma warning restore 1591
