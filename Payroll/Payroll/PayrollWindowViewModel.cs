using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MakePayroll
{
    public class PayrollWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PayrollView payroll { get; set; }
        public List<TablePayrollView> tablePayroll { get; set; }
        public List<TablePayrollView> tablePayrollAdded { get; set; }
        public List<TablePayrollView> tablePayrollRemoved { get; set; }
        public TablePayrollView rowTablePayroll { get; set; }
        public ICollectionView tableView { get; set; }

        public PayrollWindowViewModel(PayrollView payroll)
        {
            this.payroll = payroll;
            tablePayrollAdded = new List<TablePayrollView>();
            tablePayrollRemoved = new List<TablePayrollView>();
            Queries queries = new Queries();
            tablePayroll = queries.getTablePayroll(payroll.id);
            tableView = CollectionViewSource.GetDefaultView(tablePayroll);
        }

        public void add()
        {
            TablePayrollView rowTablePayroll = new TablePayrollView();
            rowTablePayroll.payroll = payroll.id;
            Queries queries = new Queries();
            queries.addRowTablePayroll(rowTablePayroll);
            tablePayrollAdded.Add(rowTablePayroll);
            tablePayroll.Add(rowTablePayroll);
            tableView.Refresh();
        }

        public void remove()
        {
            Queries queries = new Queries();
            queries.removeTablePayroll(rowTablePayroll);
            tablePayrollRemoved.Add(rowTablePayroll);
            tablePayroll.Remove(rowTablePayroll);
            tableView.Refresh();
        }

        public bool saveTable()
        {
            Queries queries = new Queries();
            queries.editPayroll(payroll);
            return queries.saveTablePayroll(tablePayroll);
        }

        public void unSave()
        {
            Queries queries = new Queries();
            foreach (var rowTable in tablePayrollAdded)
            {
                queries.removeTablePayroll(rowTable);
            }
            foreach (var rowTable in tablePayrollRemoved)
            {
                queries.addRowTablePayroll(rowTable);
            }
        }

        public string month()
        {
            string date = ((DateTime)payroll.date).ToLongDateString();
            string[] dateItems = date.Split(' ');
            StringBuilder monthBuilder = new StringBuilder();
            monthBuilder.Append(dateItems[1]
                .Replace("ря", "рь ")
                .Replace("ля", "ль ")
                .Replace("та", "т ")
                .Replace("мая", "май ")
                .Replace("ня", "нь "));
            monthBuilder.Append(dateItems[2]);
            payroll.month = monthBuilder.ToString();
            return payroll.month;
        }

        public void selectEmployee()
        {
            if (rowTablePayroll != null && payroll.date != null)
            {
                EmploeesWindow win = new EmploeesWindow((DateTime)payroll.date);
                win.ShowDialog();

                if (win.DialogResult == true)
                {
                    if (tablePayroll.Where(c => c.employee == win.employee.id).Count() >= 1)
                    {
                        MessageBox.Show("Данный сотрудник уже добавлен в таблицу");
                        return;
                    }

                    rowTablePayroll.employee = win.employee.id;
                    rowTablePayroll.tabelNumber = win.employee.tabelNumber;
                    rowTablePayroll.fio = win.employee.fio;
                    rowTablePayroll.name = win.employee.name;

                    Queries queries = new Queries();
                    rowTablePayroll.sum = queries.getSum(win.employee.id, (DateTime)payroll.date);

                    rowTablePayroll.ndfl = rowTablePayroll.sum * 0.13;
                    rowTablePayroll.fact = rowTablePayroll.sum - rowTablePayroll.ndfl;
                    tableView.Refresh();
                }
            }
        }
    }
}
