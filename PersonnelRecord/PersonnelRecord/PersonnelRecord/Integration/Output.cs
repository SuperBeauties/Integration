using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonnelRecord.Integration
{
    public class Output
    {
        private IntegrationModel integrationModelCreate()
        {
            _D__MYDB_MDFDataSet dataSet = new _D__MYDB_MDFDataSet();

            var employeeTableAdapter = new _D__MYDB_MDFDataSetTableAdapters.EmployeeTableAdapter();
            employeeTableAdapter.Fill(dataSet.Employee);

            List<Employee> employees = new List<Employee>();
            foreach (_D__MYDB_MDFDataSet.EmployeeRow row in dataSet.Employee)
            {
                int? salary = null;
                salary = row.IssalaryNull() ? salary : row.salary;
                Employee employee = new Employee(row.id, row.tabelNumber, row.fio, row.birthdate, row.passportData, row.address, salary);
                employees.Add(employee);
            }

            var positionTableAdapter = new _D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter();
            positionTableAdapter.Fill(dataSet.Position);

            List<Position> positions = new List<Position>();
            foreach (_D__MYDB_MDFDataSet.PositionRow row in dataSet.Position)
            {
                Position position = new Position(row.id, row.name);
                positions.Add(position);
            }

            var salaryTableAdapter = new _D__MYDB_MDFDataSetTableAdapters.SalaryTableAdapter();
            salaryTableAdapter.Fill(dataSet.Salary);

            List<Salary> salaries = new List<Salary>();
            foreach (_D__MYDB_MDFDataSet.SalaryRow row in dataSet.Salary)
            {
                DateTime? end = null;
                end = row.IsdateEndNull() ? end : row.dateEnd;
                Salary salary = new Salary(row.id, row.position, row.sum, row.dateStart, end);
                salaries.Add(salary);
            }

            var startTableAdapter = new _D__MYDB_MDFDataSetTableAdapters.StartWorkTableAdapter();
            startTableAdapter.Fill(dataSet.StartWork);

            var changeTableAdapter = new _D__MYDB_MDFDataSetTableAdapters.ChangePositionTableAdapter();
            changeTableAdapter.Fill(dataSet.ChangePosition);

            List<EmployeesSalary> employeesSalary = new List<EmployeesSalary>();
            foreach (_D__MYDB_MDFDataSet.StartWorkRow row in dataSet.StartWork)
            {
                EmployeesSalary salary = new EmployeesSalary(row.employee, row.salary);
                employeesSalary.Add(salary);
            }

            foreach (_D__MYDB_MDFDataSet.ChangePositionRow row in dataSet.ChangePosition)
            {
                EmployeesSalary salary = new EmployeesSalary(row.employee, row.salary);
                employeesSalary.Add(salary);
            }

            IntegrationModel integrationModel = new IntegrationModel(employees, positions, salaries, employeesSalary);
            return integrationModel;
        }

        public void output() {
            IntegrationModel integrationModel = integrationModelCreate();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(IntegrationModel));
            StreamWriter streamWriter = new StreamWriter("E:\\integration.xml");
            xmlSerializer.Serialize(streamWriter, integrationModel);
            streamWriter.Close();
            
        }

    }
}
