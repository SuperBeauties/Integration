using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePayroll.Integration
{
    public class Queries
    {
        DataClassesDataContext db;
        public Queries()
        {
            db = new DataClassesDataContext();
        }

        public void editEmployees(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                MakePayroll.Employee employee = db.Employee.Where(c => c.id == item.id).FirstOrDefault();
                if (employee == null)
                {
                    employee = new MakePayroll.Employee();
                    employee.id = item.id;
                    employee.tabelNumber = item.tabelNumber;
                    employee.address = item.address;
                    employee.birthdate = item.birthdate;
                    employee.passportData = item.passportData;
                    employee.salary = item.salary;
                    db.Employee.InsertOnSubmit(employee);
                    db.SubmitChanges();
                }
                else
                {
                    employee.tabelNumber = item.tabelNumber;
                    employee.address = item.address;
                    employee.birthdate = item.birthdate;
                    employee.passportData = item.passportData;
                    employee.salary = item.salary;
                    db.SubmitChanges();
                }
            }
        }

        public void editSalaries(List<Salary> salaries)
        {
            foreach (var item in salaries)
            {
                MakePayroll.Salary salary = db.Salary.Where(c => c.id == item.id).FirstOrDefault();
                if (salary == null)
                {
                    salary = new MakePayroll.Salary();
                    salary.id = item.id;
                    db.Salary.InsertOnSubmit(salary);
                }
                salary.position = item.position;
                salary.sum = item.sum;
                salary.dateStart = item.start;
                salary.dateEnd = item.end;
                db.SubmitChanges();
            }
        }

        public void editPositions(List<Position> positions)
        {
            foreach (var item in positions)
            {
                MakePayroll.Position position = db.Position.Where(c => c.id == item.id).FirstOrDefault();
                if (position == null)
                {
                    position = new MakePayroll.Position();
                    position.id = item.id;
                    position.name = item.name;
                    db.Position.InsertOnSubmit(position);
                    db.SubmitChanges();
                }
                else
                {
                    position.name = item.name;
                    db.SubmitChanges();
                }
            }
        }

        public void editEmployeesSalary(List<EmployeesSalary> employeesSalaries)
        {
            db.EmployeesSalary.DeleteAllOnSubmit(db.EmployeesSalary);
            db.SubmitChanges();
            foreach (var item in employeesSalaries)
            {
                MakePayroll.EmployeesSalary employeesSalary = new MakePayroll.EmployeesSalary();
                employeesSalary.employee = item.employee;
                employeesSalary.salary = item.salary;
                db.EmployeesSalary.InsertOnSubmit(employeesSalary);
                db.SubmitChanges();
            }
        }
    }
}
