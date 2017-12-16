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
    public partial class EndWork : Form
    {
        public EndWork()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

        private void EndWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.EndWork". При необходимости она может быть перемещена или удалена.
            this.endWorkTableAdapter.Fill(this._D__MYDB_MDFDataSet.EndWork);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this._D__MYDB_MDFDataSet.Employee);

        }
    }
}
