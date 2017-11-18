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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakePayroll {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void payroll_Click(object sender, RoutedEventArgs e) {
            PayrollWindow payroll = new PayrollWindow();
            payroll.ShowDialog();
        }

        private void report_Click(object sender, RoutedEventArgs e) {
            ReportWindow report = new ReportWindow();
            report.ShowDialog();
        }
    }
}
