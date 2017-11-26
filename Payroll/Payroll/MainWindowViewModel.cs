using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using System.Globalization;

namespace MakePayroll {
    public class MainWindowViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<PayrollView> payrolls { get; set; }
        public PayrollView rowPayroll { get; set; }
        public ICollectionView payrollView { get; set; }

        public MainWindowViewModel() {
            Queries queries = new Queries();
            payrolls = queries.getPayrollView();
            payrollView = CollectionViewSource.GetDefaultView(payrolls);
        }

        public void add() {
            Queries queries = new Queries();
            PayrollView rowPayroll = new PayrollView();
            rowPayroll.number = queries.getTabelNumber().ToString("00000000");
            rowPayroll.date = DateTime.Now;
            queries.addPayroll(rowPayroll);

            PayrollWindow win = new PayrollWindow(rowPayroll);
            win.ShowDialog();

            if (win.DialogResult == true) {
                payrolls.Add(rowPayroll);
                payrollView.Refresh();
                this.rowPayroll = rowPayroll;
            } else {
                queries.removePayroll(rowPayroll);
            }
        }

        public void remove() {
            if (rowPayroll == null)
                return;

            payrolls.Remove(rowPayroll);
            Queries queries = new Queries();
            queries.removePayroll(rowPayroll);
            payrollView.Refresh();
        }

        public void edit() {
            if (rowPayroll == null)
                return;

            PayrollWindow win = new PayrollWindow(rowPayroll);
            win.ShowDialog();

            if (win.DialogResult == true) {
                Queries queries = new Queries();
                queries.editPayroll(rowPayroll);
                payrollView.Refresh();
            }
        }

    }
}
