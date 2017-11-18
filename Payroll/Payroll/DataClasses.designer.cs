﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakePayroll {
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Payroll")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertPayroll(Payroll instance);
    partial void UpdatePayroll(Payroll instance);
    partial void DeletePayroll(Payroll instance);
    partial void InsertPosition(Position instance);
    partial void UpdatePosition(Position instance);
    partial void DeletePosition(Position instance);
    partial void InsertSalary(Salary instance);
    partial void UpdateSalary(Salary instance);
    partial void DeleteSalary(Salary instance);
    partial void InsertTablePayroll(TablePayroll instance);
    partial void UpdateTablePayroll(TablePayroll instance);
    partial void DeleteTablePayroll(TablePayroll instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Payroll.Properties.Settings.Default.PayrollConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employee
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Payroll> Payroll
		{
			get
			{
				return this.GetTable<Payroll>();
			}
		}
		
		public System.Data.Linq.Table<Position> Position
		{
			get
			{
				return this.GetTable<Position>();
			}
		}
		
		public System.Data.Linq.Table<Salary> Salary
		{
			get
			{
				return this.GetTable<Salary>();
			}
		}
		
		public System.Data.Linq.Table<TablePayroll> TablePayroll
		{
			get
			{
				return this.GetTable<TablePayroll>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _tabelNumber;
		
		private string _fio;
		
		private System.Nullable<System.DateTime> _birthdate;
		
		private string _passportData;
		
		private string _address;
		
		private System.Nullable<int> _salary;
		
		private EntitySet<TablePayroll> _TablePayroll;
		
		private EntityRef<Salary> _Salary1;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntabelNumberChanging(string value);
    partial void OntabelNumberChanged();
    partial void OnfioChanging(string value);
    partial void OnfioChanged();
    partial void OnbirthdateChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthdateChanged();
    partial void OnpassportDataChanging(string value);
    partial void OnpassportDataChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnsalaryChanging(System.Nullable<int> value);
    partial void OnsalaryChanged();
    #endregion
		
		public Employee()
		{
			this._TablePayroll = new EntitySet<TablePayroll>(new Action<TablePayroll>(this.attach_TablePayroll), new Action<TablePayroll>(this.detach_TablePayroll));
			this._Salary1 = default(EntityRef<Salary>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tabelNumber", DbType="VarChar(8)")]
		public string tabelNumber
		{
			get
			{
				return this._tabelNumber;
			}
			set
			{
				if ((this._tabelNumber != value))
				{
					this.OntabelNumberChanging(value);
					this.SendPropertyChanging();
					this._tabelNumber = value;
					this.SendPropertyChanged("tabelNumber");
					this.OntabelNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fio", DbType="VarChar(250)")]
		public string fio
		{
			get
			{
				return this._fio;
			}
			set
			{
				if ((this._fio != value))
				{
					this.OnfioChanging(value);
					this.SendPropertyChanging();
					this._fio = value;
					this.SendPropertyChanged("fio");
					this.OnfioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthdate", DbType="Date")]
		public System.Nullable<System.DateTime> birthdate
		{
			get
			{
				return this._birthdate;
			}
			set
			{
				if ((this._birthdate != value))
				{
					this.OnbirthdateChanging(value);
					this.SendPropertyChanging();
					this._birthdate = value;
					this.SendPropertyChanged("birthdate");
					this.OnbirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passportData", DbType="VarChar(MAX)")]
		public string passportData
		{
			get
			{
				return this._passportData;
			}
			set
			{
				if ((this._passportData != value))
				{
					this.OnpassportDataChanging(value);
					this.SendPropertyChanging();
					this._passportData = value;
					this.SendPropertyChanged("passportData");
					this.OnpassportDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(MAX)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int")]
		public System.Nullable<int> salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					if (this._Salary1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_TablePayroll", Storage="_TablePayroll", ThisKey="id", OtherKey="employee")]
		public EntitySet<TablePayroll> TablePayroll
		{
			get
			{
				return this._TablePayroll;
			}
			set
			{
				this._TablePayroll.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salary_Employee", Storage="_Salary1", ThisKey="salary", OtherKey="id", IsForeignKey=true)]
		public Salary Salary1
		{
			get
			{
				return this._Salary1.Entity;
			}
			set
			{
				Salary previousValue = this._Salary1.Entity;
				if (((previousValue != value) 
							|| (this._Salary1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Salary1.Entity = null;
						previousValue.Employee.Remove(this);
					}
					this._Salary1.Entity = value;
					if ((value != null))
					{
						value.Employee.Add(this);
						this._salary = value.id;
					}
					else
					{
						this._salary = default(Nullable<int>);
					}
					this.SendPropertyChanged("Salary1");
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
		
		private void attach_TablePayroll(TablePayroll entity)
		{
			this.SendPropertyChanging();
			entity.Employee1 = this;
		}
		
		private void detach_TablePayroll(TablePayroll entity)
		{
			this.SendPropertyChanging();
			entity.Employee1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payroll")]
	public partial class Payroll : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _number;
		
		private System.Nullable<System.DateTime> _date;
		
		private EntitySet<TablePayroll> _TablePayroll;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    #endregion
		
		public Payroll()
		{
			this._TablePayroll = new EntitySet<TablePayroll>(new Action<TablePayroll>(this.attach_TablePayroll), new Action<TablePayroll>(this.detach_TablePayroll));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="VarChar(8)")]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Payroll_TablePayroll", Storage="_TablePayroll", ThisKey="id", OtherKey="payroll")]
		public EntitySet<TablePayroll> TablePayroll
		{
			get
			{
				return this._TablePayroll;
			}
			set
			{
				this._TablePayroll.Assign(value);
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
		
		private void attach_TablePayroll(TablePayroll entity)
		{
			this.SendPropertyChanging();
			entity.Payroll1 = this;
		}
		
		private void detach_TablePayroll(TablePayroll entity)
		{
			this.SendPropertyChanging();
			entity.Payroll1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Position")]
	public partial class Position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Salary> _Salary;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Position()
		{
			this._Salary = new EntitySet<Salary>(new Action<Salary>(this.attach_Salary), new Action<Salary>(this.detach_Salary));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(10)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Position_Salary", Storage="_Salary", ThisKey="id", OtherKey="position")]
		public EntitySet<Salary> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				this._Salary.Assign(value);
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
		
		private void attach_Salary(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Position1 = this;
		}
		
		private void detach_Salary(Salary entity)
		{
			this.SendPropertyChanging();
			entity.Position1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salary")]
	public partial class Salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _position;
		
		private System.Nullable<double> _sum;
		
		private System.Nullable<System.DateTime> _dateStart;
		
		private System.Nullable<System.DateTime> _dateEnd;
		
		private EntitySet<Employee> _Employee;
		
		private EntityRef<Position> _Position1;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnpositionChanging(System.Nullable<int> value);
    partial void OnpositionChanged();
    partial void OnsumChanging(System.Nullable<double> value);
    partial void OnsumChanged();
    partial void OndateStartChanging(System.Nullable<System.DateTime> value);
    partial void OndateStartChanged();
    partial void OndateEndChanging(System.Nullable<System.DateTime> value);
    partial void OndateEndChanged();
    #endregion
		
		public Salary()
		{
			this._Employee = new EntitySet<Employee>(new Action<Employee>(this.attach_Employee), new Action<Employee>(this.detach_Employee));
			this._Position1 = default(EntityRef<Position>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="Int")]
		public System.Nullable<int> position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					if (this._Position1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sum", DbType="Float")]
		public System.Nullable<double> sum
		{
			get
			{
				return this._sum;
			}
			set
			{
				if ((this._sum != value))
				{
					this.OnsumChanging(value);
					this.SendPropertyChanging();
					this._sum = value;
					this.SendPropertyChanged("sum");
					this.OnsumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateStart", DbType="Date")]
		public System.Nullable<System.DateTime> dateStart
		{
			get
			{
				return this._dateStart;
			}
			set
			{
				if ((this._dateStart != value))
				{
					this.OndateStartChanging(value);
					this.SendPropertyChanging();
					this._dateStart = value;
					this.SendPropertyChanged("dateStart");
					this.OndateStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateEnd", DbType="Date")]
		public System.Nullable<System.DateTime> dateEnd
		{
			get
			{
				return this._dateEnd;
			}
			set
			{
				if ((this._dateEnd != value))
				{
					this.OndateEndChanging(value);
					this.SendPropertyChanging();
					this._dateEnd = value;
					this.SendPropertyChanged("dateEnd");
					this.OndateEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salary_Employee", Storage="_Employee", ThisKey="id", OtherKey="salary")]
		public EntitySet<Employee> Employee
		{
			get
			{
				return this._Employee;
			}
			set
			{
				this._Employee.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Position_Salary", Storage="_Position1", ThisKey="position", OtherKey="id", IsForeignKey=true)]
		public Position Position1
		{
			get
			{
				return this._Position1.Entity;
			}
			set
			{
				Position previousValue = this._Position1.Entity;
				if (((previousValue != value) 
							|| (this._Position1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Position1.Entity = null;
						previousValue.Salary.Remove(this);
					}
					this._Position1.Entity = value;
					if ((value != null))
					{
						value.Salary.Add(this);
						this._position = value.id;
					}
					else
					{
						this._position = default(Nullable<int>);
					}
					this.SendPropertyChanged("Position1");
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
		
		private void attach_Employee(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Salary1 = this;
		}
		
		private void detach_Employee(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Salary1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TablePayroll")]
	public partial class TablePayroll : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _employee;
		
		private System.Nullable<double> _sum;
		
		private System.Nullable<double> _ndfl;
		
		private System.Nullable<int> _payroll;
		
		private EntityRef<Employee> _Employee1;
		
		private EntityRef<Payroll> _Payroll1;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnemployeeChanging(System.Nullable<int> value);
    partial void OnemployeeChanged();
    partial void OnsumChanging(System.Nullable<double> value);
    partial void OnsumChanged();
    partial void OnndflChanging(System.Nullable<double> value);
    partial void OnndflChanged();
    partial void OnpayrollChanging(System.Nullable<int> value);
    partial void OnpayrollChanged();
    #endregion
		
		public TablePayroll()
		{
			this._Employee1 = default(EntityRef<Employee>);
			this._Payroll1 = default(EntityRef<Payroll>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee", DbType="Int")]
		public System.Nullable<int> employee
		{
			get
			{
				return this._employee;
			}
			set
			{
				if ((this._employee != value))
				{
					if (this._Employee1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemployeeChanging(value);
					this.SendPropertyChanging();
					this._employee = value;
					this.SendPropertyChanged("employee");
					this.OnemployeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sum", DbType="Float")]
		public System.Nullable<double> sum
		{
			get
			{
				return this._sum;
			}
			set
			{
				if ((this._sum != value))
				{
					this.OnsumChanging(value);
					this.SendPropertyChanging();
					this._sum = value;
					this.SendPropertyChanged("sum");
					this.OnsumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ndfl", DbType="Float")]
		public System.Nullable<double> ndfl
		{
			get
			{
				return this._ndfl;
			}
			set
			{
				if ((this._ndfl != value))
				{
					this.OnndflChanging(value);
					this.SendPropertyChanging();
					this._ndfl = value;
					this.SendPropertyChanged("ndfl");
					this.OnndflChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payroll", DbType="Int")]
		public System.Nullable<int> payroll
		{
			get
			{
				return this._payroll;
			}
			set
			{
				if ((this._payroll != value))
				{
					if (this._Payroll1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpayrollChanging(value);
					this.SendPropertyChanging();
					this._payroll = value;
					this.SendPropertyChanged("payroll");
					this.OnpayrollChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_TablePayroll", Storage="_Employee1", ThisKey="employee", OtherKey="id", IsForeignKey=true)]
		public Employee Employee1
		{
			get
			{
				return this._Employee1.Entity;
			}
			set
			{
				Employee previousValue = this._Employee1.Entity;
				if (((previousValue != value) 
							|| (this._Employee1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee1.Entity = null;
						previousValue.TablePayroll.Remove(this);
					}
					this._Employee1.Entity = value;
					if ((value != null))
					{
						value.TablePayroll.Add(this);
						this._employee = value.id;
					}
					else
					{
						this._employee = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employee1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Payroll_TablePayroll", Storage="_Payroll1", ThisKey="payroll", OtherKey="id", IsForeignKey=true)]
		public Payroll Payroll1
		{
			get
			{
				return this._Payroll1.Entity;
			}
			set
			{
				Payroll previousValue = this._Payroll1.Entity;
				if (((previousValue != value) 
							|| (this._Payroll1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Payroll1.Entity = null;
						previousValue.TablePayroll.Remove(this);
					}
					this._Payroll1.Entity = value;
					if ((value != null))
					{
						value.TablePayroll.Add(this);
						this._payroll = value.id;
					}
					else
					{
						this._payroll = default(Nullable<int>);
					}
					this.SendPropertyChanged("Payroll1");
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
