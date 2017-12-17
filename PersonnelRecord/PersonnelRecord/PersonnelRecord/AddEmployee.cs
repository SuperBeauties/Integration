using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelRecord
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tabelNumber.Text) ||
                string.IsNullOrEmpty(fio.Text) ||
                string.IsNullOrEmpty(passportData.Text) ||
                string.IsNullOrEmpty(address.Text)) {
                MessageBox.Show("Заполнены не все поля!");
                return;
            }
            employeeBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            employeeBindingSource.CancelEdit();
            DialogResult = DialogResult.Abort;
        }

    }
}
