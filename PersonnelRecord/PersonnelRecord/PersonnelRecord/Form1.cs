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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var row = (_D__MYDB_MDFDataSet.EmployeeRow)((DataRowView)employeeBindingSource.AddNew()).Row;
            AddEmployee form = new AddEmployee();
            form.employeeBindingSource.DataSource = employeeBindingSource.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                employeeTableAdapter.Update(row);
            }
            else
            {
                employeeBindingSource.CancelEdit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.Salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this._D__MYDB_MDFDataSet.Salary);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.StartWork". При необходимости она может быть перемещена или удалена.
            this.startWorkTableAdapter.Fill(this._D__MYDB_MDFDataSet.StartWork);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.Position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this._D__MYDB_MDFDataSet.Position);
            this.employeeTableAdapter.Fill(this._D__MYDB_MDFDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.EndWork". При необходимости она может быть перемещена или удалена.
            this.endWorkTableAdapter.Fill(this._D__MYDB_MDFDataSet.EndWork);
            employeeBindingSource.Sort = "TabelNumber ASC";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow != null)
            {
                var row = (_D__MYDB_MDFDataSet.EmployeeRow)((DataRowView)employeeBindingSource.Current).Row;
                AddEmployee form = new AddEmployee();
                form.employeeBindingSource.DataSource = employeeBindingSource.Current;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    employeeBindingSource.EndEdit();
                    employeeTableAdapter.Update(row);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var row = (_D__MYDB_MDFDataSet.EmployeeRow)((DataRowView)employeeBindingSource.Current).Row;
                employeeBindingSource.RemoveCurrent();
                employeeTableAdapter.Update(row);
            }
        }

        private void addStart_Click(object sender, EventArgs e)
        {
            var row = (_D__MYDB_MDFDataSet.StartWorkRow)((DataRowView)startWorkBindingSource.AddNew()).Row;
            row.startdate = DateTime.Now;
            StartWork form = new StartWork();
            form.startWorkBindingSource1.DataSource = startWorkBindingSource.Current;
            form.employeeBindingSource.DataSource = employeeBindingSource;
            form.positionBindingSource.DataSource = positionBindingSource;
            DialogResult result = form.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                if (startWorkBindingSource.Find("employee", row.employee) != -1)
                {
                    MessageBox.Show("Для данного сотрудника уже есть документ приема! Документ не был создан.");
                    startWorkBindingSource.CancelEdit();
                    return;
                }

                startWorkBindingSource.EndEdit();
                var newSalaryRow = (_D__MYDB_MDFDataSet.SalaryRow)((DataRowView)salaryBindingSource.AddNew()).Row;
                newSalaryRow.dateStart = row.startdate;
                newSalaryRow.position = row.sPos;
                newSalaryRow.sum = row.sum;
                salaryBindingSource.EndEdit();
                salaryTableAdapter.Update(newSalaryRow);

                row.salary = (int)salaryTableAdapter.GetId();

                int idEmployee = employeeBindingSource.Find("id", row.employee);
                var employeeRow = (_D__MYDB_MDFDataSet.EmployeeRow)_D__MYDB_MDFDataSet.Employee.Rows[idEmployee];
                employeeRow.salary = row.salary;
                employeeBindingSource.EndEdit();
                employeeTableAdapter.Update(employeeRow);

                startWorkTableAdapter.Update(row);
            }
            else
            {
                startWorkBindingSource.CancelEdit();
            }
        }

        private void deleteStart_Click(object sender, EventArgs e)
        {
            if (dataGridViewStart.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var row = (_D__MYDB_MDFDataSet.StartWorkRow)((DataRowView)startWorkBindingSource.Current).Row;
                if (!row.isEditable)
                {
                    MessageBox.Show("Невозможно удалить документ приема для уволенного или сотрудника, по которому были переводы.");
                    return;
                }

                employeeTableAdapter.SetNullSalary(null, row.employee);
                salaryTableAdapter.DeleteById(row.salary);

                startWorkBindingSource.RemoveCurrent();
                startWorkTableAdapter.Update(row);
            }
        }

        private void editStart_Click(object sender, EventArgs e)
        {
            if (dataGridViewStart.CurrentRow != null)
            {
                var row = (_D__MYDB_MDFDataSet.StartWorkRow)((DataRowView)startWorkBindingSource.Current).Row;
                if (!row.isEditable)
                {
                    MessageBox.Show("Невозможно редактировать документ приема для уволенного или сотрудника, по которому были переводы.");
                    return;
                }

                StartWork form = new StartWork();
                form.startWorkBindingSource1.DataSource = startWorkBindingSource.Current;
                form.employeeBindingSource.DataSource = employeeBindingSource;
                form.positionBindingSource.DataSource = positionBindingSource;
                form.comboBox1.Enabled = false;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    int idSalary = salaryBindingSource.Find("id", row.salary);
                    var salaryRow = (_D__MYDB_MDFDataSet.SalaryRow)_D__MYDB_MDFDataSet.Salary.Rows[idSalary];
                    salaryRow.dateStart = row.startdate;
                    salaryRow.position = row.sPos;
                    salaryRow.sum = row.sum;
                    salaryBindingSource.EndEdit();
                    salaryTableAdapter.Update(salaryRow);

                    startWorkBindingSource.EndEdit();
                    startWorkTableAdapter.Update(row);
                }
            }
        }

        private void dataGridViewStart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void addEnd_Click(object sender, EventArgs e)
        {
            var row = (_D__MYDB_MDFDataSet.EndWorkRow)((DataRowView)endWorkBindingSource.AddNew()).Row;
            row.endDate = DateTime.Now;
            EndWork form = new EndWork();
            form.endWorkBindingSource.DataSource = endWorkBindingSource.Current;
            form.employeeBindingSource.DataSource = employeeBindingSource;
            DialogResult result = form.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                if (endWorkBindingSource.Find("employee", row.employee) != -1)
                {
                    MessageBox.Show("Для данного сотрудника уже есть документ увольнения! Документ не был создан.");
                    endWorkBindingSource.CancelEdit();
                    return;
                }

                int startIndex = startWorkBindingSource.Find("employee", row.employee);
                if (startIndex == -1)
                {
                    MessageBox.Show("Для данного сотрудника не найден документ приема! Документ не был создан.");
                    endWorkBindingSource.CancelEdit();
                    return;
                }

                int idEmployee = employeeBindingSource.Find("id", row.employee);
                var employeeRow = (_D__MYDB_MDFDataSet.EmployeeRow)_D__MYDB_MDFDataSet.Employee.Rows[idEmployee];

                int idSalary = salaryBindingSource.Find("id", employeeRow.salary);
                var salaryRow = (_D__MYDB_MDFDataSet.SalaryRow)_D__MYDB_MDFDataSet.Salary.Rows[idSalary];

                if (salaryRow.dateStart > row.endDate)
                {
                    MessageBox.Show("Дата увольнения ниже даты приема или последнего перевода! Документ не был создан.");
                    endWorkBindingSource.CancelEdit();
                    return;
                }

                endWorkBindingSource.EndEdit();

                var startRow = (_D__MYDB_MDFDataSet.StartWorkRow)_D__MYDB_MDFDataSet.StartWork.Rows[startIndex];
                startRow.isEditable = false;
                startWorkBindingSource.EndEdit();
                startWorkTableAdapter.Update(startRow);

                salaryRow.dateEnd = row.endDate;
                salaryBindingSource.EndEdit();
                salaryTableAdapter.Update(salaryRow);

                endWorkTableAdapter.Update(row);
            }
            else
            {
                endWorkBindingSource.CancelEdit();
            }
        }

        private void editEnd_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnd.CurrentRow != null)
            {
                var row = (_D__MYDB_MDFDataSet.EndWorkRow)((DataRowView)endWorkBindingSource.Current).Row;
                EndWork form = new EndWork();
                form.endWorkBindingSource.DataSource = endWorkBindingSource.Current;
                form.employeeBindingSource.DataSource = employeeBindingSource;
                form.comboBox1.Enabled = false;
                DialogResult result = form.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    int idEmployee = employeeBindingSource.Find("id", row.employee);
                    var employeeRow = (_D__MYDB_MDFDataSet.EmployeeRow)_D__MYDB_MDFDataSet.Employee.Rows[idEmployee];

                    int idSalary = salaryBindingSource.Find("id", employeeRow.salary);
                    var salaryRow = (_D__MYDB_MDFDataSet.SalaryRow)_D__MYDB_MDFDataSet.Salary.Rows[idSalary];

                    if (salaryRow.dateStart > row.endDate)
                    {
                        MessageBox.Show("Дата увольнения ниже даты приема или последнего перевода! Документ не был создан.");
                        endWorkBindingSource.CancelEdit();
                        return;
                    }

                    endWorkBindingSource.EndEdit();

                    salaryRow.dateEnd = row.endDate;
                    salaryBindingSource.EndEdit();
                    salaryTableAdapter.Update(salaryRow);

                    endWorkTableAdapter.Update(row);
                }
                else
                {
                    endWorkBindingSource.CancelEdit();
                }
            }
        }

        private void deleteEnd_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnd.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить данную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var row = (_D__MYDB_MDFDataSet.EndWorkRow)((DataRowView)endWorkBindingSource.Current).Row;

                int idEmployee = employeeBindingSource.Find("id", row.employee);
                var employeeRow = (_D__MYDB_MDFDataSet.EmployeeRow)_D__MYDB_MDFDataSet.Employee.Rows[idEmployee];

                int idSalary = salaryBindingSource.Find("id", employeeRow.salary);
                var salaryRow = (_D__MYDB_MDFDataSet.SalaryRow)_D__MYDB_MDFDataSet.Salary.Rows[idSalary];
                salaryRow.SetdateEndNull();
                salaryBindingSource.EndEdit();
                salaryTableAdapter.Update(salaryRow);

                int startIndex = startWorkBindingSource.Find("employee", row.employee);
                var startRow = (_D__MYDB_MDFDataSet.StartWorkRow)_D__MYDB_MDFDataSet.StartWork.Rows[startIndex];
                startRow.isEditable = true;
                startWorkBindingSource.EndEdit();
                startWorkTableAdapter.Update(startRow);

                endWorkBindingSource.RemoveCurrent();
                endWorkTableAdapter.Update(row);
            }
        }
    }
}
