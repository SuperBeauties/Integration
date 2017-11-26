using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MakePayroll {
    /// <summary>
    /// Логика взаимодействия для EmploeesWindow.xaml
    /// </summary>
    public partial class EmploeesWindow : Window {
        EmployeesWindowView view;
        public EmployeeView employee;
        public EmploeesWindow(DateTime date) {
            InitializeComponent();
            view = new EmployeesWindowView(date);
            DataContext = view;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (view.employee != null) {
                employee = view.employee;
                DialogResult = true;
            }
        }
    }
}
