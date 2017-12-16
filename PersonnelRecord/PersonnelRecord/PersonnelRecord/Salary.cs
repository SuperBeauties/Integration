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
    public partial class Salary : Form
    {
        SqlConnection sqlConnection;

        public Salary()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label2.Visible)
                label2.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Salary] (position, sum, datestart)VALUES(@position, @sum, @datestart)", sqlConnection);

                command.Parameters.AddWithValue("position", textBox1.Text);

                command.Parameters.AddWithValue("sum", Convert.ToDouble(textBox2.Text));

                command.Parameters.AddWithValue("datestart", dateTimePicker1.Value);


                await command.ExecuteNonQueryAsync();

            }
            else
            {
                label2.Visible = true;

                label2.Text = "Не все обязательные поля заполнены!";
            }
        }

        private async void Salary_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D:\MYDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        private void Salary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
