using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MakePayroll {
    public class PayrollWindowViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public Payroll payroll { get; set; }
        public List<TablePayroll> tablePayroll { get; set; }
        public TablePayroll rowTablePayroll { get; set; }
        public ICollectionView tableView { get; set; }
        public string month { get; set; }

        public DateTime payrollDate {
            get {
                return (payroll.date == null) ? DateTime.Now : (DateTime)payroll.date;
            }
            set {
                payroll.date = value;
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
                month = monthBuilder.ToString();
            }
        }
        public PayrollWindowViewModel() {
            payroll = new Payroll();
            tablePayroll = new List<TablePayroll>();
            tableView = CollectionViewSource.GetDefaultView(tablePayroll);
        }

        public void add() {
            tablePayroll.Add(new TablePayroll());
            tableView.Refresh();
        }

        public void remove() {
            tablePayroll.Remove(rowTablePayroll);
            tableView.Refresh();
        }
    }
}
