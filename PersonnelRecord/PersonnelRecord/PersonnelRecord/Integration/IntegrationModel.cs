using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelRecord.Integration
{
    public class IntegrationModel
    {
        public Employees employees;
        public Positions positions;
        public Salaries salaries;
        public EmployeesSalaries employeesSalary;

        public IntegrationModel()
        {
        }

        public IntegrationModel(List<Employee> employees,
            List<Position> positions,
            List<Salary> salaries,
            List<EmployeesSalary> employeesSalary)
        {
            this.employees = new Employees(employees);
            this.positions = new Positions(positions);
            this.salaries = new Salaries(salaries);
            this.employeesSalary = new EmployeesSalaries(employeesSalary);
        }
    }

    public class Employees
    {
        public List<Employee> employees;

        public Employees()
        {
        }

        public Employees(List<Employee> employees)
        {
            this.employees = employees;
        }
    }

    public class Positions
    {
        public List<Position> positions;

        public Positions()
        {
        }

        public Positions(List<Position> positions)
        {
            this.positions = positions;
        }
    }

    public class Salaries
    {
        public List<Salary> salaries;

        public Salaries()
        {
        }

        public Salaries(List<Salary> salaries)
        {
            this.salaries = salaries;
        }
    }

    public class EmployeesSalaries
    {
        public List<EmployeesSalary> employeesSalary;

        public EmployeesSalaries()
        {
        }

        public EmployeesSalaries(List<EmployeesSalary> employeesSalary)
        {
            this.employeesSalary = employeesSalary;
        }
    }

    public class Employee
    {
        public int id;
        public string tabelNumber;
        public string fio;
        public DateTime birthdate;
        public string passportData;
        public string address;
        public int? salary;

        public Employee()
        {
        }

        public Employee(int id,
            string tabelNumber,
            string fio,
            DateTime birthdate,
            string passportData,
            string address,
            int? salary)
        {
            this.id = id;
            this.tabelNumber = tabelNumber;
            this.fio = fio;
            this.birthdate = birthdate;
            this.passportData = passportData;
            this.address = address;
            this.salary = salary;
        }
    }

    public class Position
    {
        public int id;
        public string name;

        public Position()
        {
        }

        public Position(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class Salary
    {
        public int id;
        public int position;
        public double sum;
        public DateTime start;
        public DateTime? end;

        public Salary()
        {
        }

        public Salary(int id, int position, double sum, DateTime start, DateTime? end)
        {
            this.id = id;
            this.position = position;
            this.sum = sum;
            this.start = start;
            this.end = end;
        }
    }

    public class EmployeesSalary
    {
        public int employee;
        public int salary;

        public EmployeesSalary()
        {
        }

        public EmployeesSalary(int employee, int salary)
        {
            this.employee = employee;
            this.salary = salary;
        }
    }
}
