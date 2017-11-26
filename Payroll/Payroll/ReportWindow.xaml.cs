using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class ReportWindow : Window {
        ReportWindowViewModel view;
        public ReportWindow() {
            InitializeComponent();
            view = new ReportWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            DataSet dataSet = new DataSet();
            dataSet.BeginInit();

            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = dataSet.CreatePayroll;
            _reportViewer.LocalReport.DataSources.Add(reportDataSource);
            _reportViewer.LocalReport.ReportEmbeddedResource = "MakePayroll.PayrollReport.rdl";

            dataSet.EndInit();

            var tableAdapter = new DataSetTableAdapters.CreatePayrollTableAdapter();
            tableAdapter.ClearBeforeFill = true;

            DateTime start = (view.start.Equals(DateTime.MinValue)) ? new DateTime(1800, 1, 1) : view.start;
            DateTime end = (view.end.Equals(DateTime.MinValue)) ? new DateTime(9999, 1, 1) : view.end;
            tableAdapter.Fill(dataSet.CreatePayroll, start, end);

            ReportParameter p1 = new ReportParameter("start", start.ToShortDateString());
            ReportParameter p2 = new ReportParameter("end", end.ToShortDateString());
            List<ReportParameter> list = new List<ReportParameter>();
            list.Add(p1);
            list.Add(p2);
            _reportViewer.LocalReport.SetParameters(list);
            _reportViewer.RefreshReport();
        }
    }
}
