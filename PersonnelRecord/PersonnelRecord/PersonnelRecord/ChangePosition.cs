using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelRecord
{
    public partial class ChangePosition : Form
    {
        public ChangePosition()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                label5.Text = "Не выбраны должность и/или сотрудник";
                return;
            }
            double temp = 0;
            if (string.IsNullOrEmpty(sum.Text) || !double.TryParse(sum.Text, out temp))
            {
                label5.Text = "Сумма оклада не указана или имеет неверный формат";
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
