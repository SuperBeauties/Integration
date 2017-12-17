using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MakePayroll.Integration
{
    public class Input
    {
        public void input()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(IntegrationModel));
            StreamReader streamReader = new StreamReader("E:\\integration.xml");
            IntegrationModel model = xmlSerializer.Deserialize(streamReader) as IntegrationModel;
            streamReader.Close();
            editDataInDb(model);
        }

        private void editDataInDb(IntegrationModel model)
        {
            List<Employee> employees = model.employees.employees;
            List<Salary> salaries = model.salaries.salaries;
            List<Position> positions = model.positions.positions;
            List<EmployeesSalary> employeeSalaries = model.employeesSalary.employeesSalary;

            Queries queries = new Queries();
            queries.editPositions(positions);
            queries.editSalaries(salaries);
            queries.editEmployees(employees);
            queries.editEmployeesSalary(employeeSalaries);
        }
    }
}
