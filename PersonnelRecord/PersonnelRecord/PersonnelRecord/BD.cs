using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelRecord.Properties;


namespace PersonnelRecord
{
	class BDDataContext : System.Data.Linq.DataContext
	{
		public BDDataContext(string cs)
			: base(cs)
		{
		}

		//#region Свойства
		//свойства для таблиц базы данных

		//public System.Data.Linq.Table<Employee> employee
		//{
		//	get { return this.GetTable<Employee>(); }
		//}

		//#endregion

		//#region выгрузка данных

		//public List<Employee> EmployeeOut()
		//{
		//	if (existEmployee() == true)
		//	{
		//		return this.Employee.ToList();
		//	}
		//	return new List<Employee>();
		//}

		//public Employee EmployeeId(int id)
		//{
		//	return this.employee.Where(c => c.id == id).FirstOrDefault();
		//}


		//#endregion

		//#region проверка


		//public bool existEmployee()
		//{
		//	List<Employee> employee = this.employee.ToList();
		//	if (employee.Count != 0)
		//	{
		//		return true;
		//	}
		//	return false;
		//}

		//#endregion

		//#region добавление
		//public void Add_Employee(int id_v, int id_p, string level, string value)
		//{
		//	Employee employee = new Employee();
		//	//employee.id_p = id_p;
		//	//employee.id_v = id_v;
		//	//employee.value = value;
		//	//employee.level = level;
		//	this.employee.InsertOnSubmit(employee); // добавляем
		//	this.SubmitChanges(); // сохраняем изменения
		//}

		//public void savingData()
		//{
		//	this.SubmitChanges(); // сохраняем изменения
		//}

		//#endregion

		//#region  редактирование
		//public void UpdateEmployee(int id, int id_v, int id_p, string level, string value)
		//{
		//	Employee employee = this.employee.Where(c => c.id == id).FirstOrDefault();
		//	//employee.id_p = id_p;
		//	//employee.id_v = id_v;
		//	//employee.value = value;
		//	//employee.level = level;
		//	this.SubmitChanges(); // сохраняем изменения
		//}

		//#endregion

		//#region удаление
		//public void DeleteEmployee(int id)
		//{
		//	Employee emp = this.employee.Where(c => c.id == id).FirstOrDefault();
		//	this.settingsValue.DeleteOnSubmit(emp);
		//	this.SubmitChanges();
		//}
		//#endregion

	}
}



