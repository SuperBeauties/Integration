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
        SqlConnection sqlConnection;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            employeeBindingSource.CancelEdit();
            DialogResult = DialogResult.Abort;
        }


        //      private async void AddEmployee_Load(object sender, EventArgs e)
        //      {
        //	// TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.Employee". При необходимости она может быть перемещена или удалена.
        //	this.employeeTableAdapter.Fill(this._D__MYDB_MDFDataSet.Employee);
        //	string connectionString = @"Data Source=КСЕНИЯ\SQLEXPRESS;Initial Catalog=D:\MYDB.MDF;Integrated Security=True";

        //          sqlConnection = new SqlConnection(connectionString);

        //          await sqlConnection.OpenAsync();

        //      }

        //      private async void save_Click(object sender, EventArgs e)
        //      {
        //          if (label10.Visible)
        //              label10.Visible = false;

        //          if (!string.IsNullOrEmpty(tnumber.Text) && !string.IsNullOrEmpty(fio.Text) && !string.IsNullOrEmpty(birthdate.Text) && !string.IsNullOrEmpty(passport.Text) && !string.IsNullOrEmpty(adress.Text) 
        //              && !string.IsNullOrWhiteSpace(tnumber.Text) && !string.IsNullOrWhiteSpace(fio.Text) && !string.IsNullOrWhiteSpace(birthdate.Text) && !string.IsNullOrWhiteSpace(passport.Text) && !string.IsNullOrWhiteSpace(adress.Text))
        //          {

        //              //SqlCommand command = new SqlCommand("INSERT INTO [Employee] (tNumber, fio, birthdate, passport, adress)VALUES(@tNumber, @fio, @birthdate, @passport, @adress)", sqlConnection);

        //              //command.Parameters.AddWithValue("tnumber", tnumber.Text);

        //              //command.Parameters.AddWithValue("fio", fio.Text);

        //              //command.Parameters.AddWithValue("birthdate", birthdate.Value);

        //              //command.Parameters.AddWithValue("passport", passport.Text);

        //              //command.Parameters.AddWithValue("adress", adress.Text);

        //              //// command.Parameters.AddWithValue("startdate", startdate.Value);

        //              //// command.Parameters.AddWithValue("position", Convert.ToInt32(position.Text));

        //              //// command.Parameters.AddWithValue("salary", Convert.ToInt32(salary.Text));

        //              //// command.Parameters.AddWithValue("enddate", enddate.Value);

        //              //await command.ExecuteNonQueryAsync();

        //              ////Form f = new Form1();
        //              ////f.Update();

        //          }
        //          else
        //          {
        //              label10.Visible = true;

        //              label10.Text = "Не все обязательные поля заполнены!";
        //          }
        //      }

        //      private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        //      {
        //	//if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
        //	//    sqlConnection.Close();

        //	if (!string.IsNullOrEmpty(tnumber.Text) && !string.IsNullOrEmpty(fio.Text) && !string.IsNullOrEmpty(birthdate.Text) && !string.IsNullOrEmpty(passport.Text) && !string.IsNullOrEmpty(adress.Text)
        //	   && !string.IsNullOrWhiteSpace(tnumber.Text) && !string.IsNullOrWhiteSpace(fio.Text) && !string.IsNullOrWhiteSpace(birthdate.Text) && !string.IsNullOrWhiteSpace(passport.Text) && !string.IsNullOrWhiteSpace(adress.Text))
        //	{
        //		//если пользователь нажал на первую кнопку:
        //		if (DialogResult == System.Windows.Forms.DialogResult.OK)
        //			//сохранить изменения:
        //			employeeBindingSource.EndEdit();
        //		else
        //			//не сохранять изменения:
        //			employeeBindingSource.CancelEdit();
        //	}
        //	else
        //	{
        //		label10.Visible = true;

        //		label10.Text = "Не все обязательные поля заполнены!";

        //		return;
        //	}

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
