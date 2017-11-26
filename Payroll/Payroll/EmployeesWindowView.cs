using MakePayroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePayroll {
    public class EmployeesWindowView : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public EmployeeView employee { get; set; }
        public List<EmployeeView> employees { get; set; }
        public ICollectionView employeesView { get; set; }

        public EmployeesWindowView(DateTime date) {
            Queries queries = new Queries();
            employees = queries.getEmployees(date);
        }
    }
}
