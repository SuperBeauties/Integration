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
    /// Логика взаимодействия для Начисление_заработной_платы.xaml
    /// </summary>
    public partial class PayrollWindow : Window {
        PayrollWindowViewModel view;
        public PayrollWindow(PayrollView payroll) {
            InitializeComponent();
            view = new PayrollWindowViewModel(payroll);
            DataContext = view;
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            view.add();
        }

        private void remove_Click(object sender, RoutedEventArgs e) {
            view.remove();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (!view.saveTable()) {
                MessageBox.Show("В строках заполнены не все поля");
                return;
            }
            DialogResult = true;
            Close();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e) {
            month.Text = view.month();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            MessageBoxResult res = MessageBox.Show("Сохранить документ перед закрытием?", "Сохранить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes) {
                if (!view.saveTable()) {
                    MessageBox.Show("В строках заполнены не все поля");
                    e.Cancel = true;
                }
                DialogResult = true;
            } else if (res == MessageBoxResult.No) {
                view.unSave();
            } else {
                e.Cancel = true;
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            view.selectEmployee();
        }
    }
}
