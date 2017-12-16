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
    public partial class Position : Form
    {
        SqlConnection sqlConnection;

        public Position()
        {
            InitializeComponent();
        }

  //      private async void button1_Click(object sender, EventArgs e)
  //      {
  //          //if (label2.Visible)
  //          //    label2.Visible = false;

  //          //if (!string.IsNullOrEmpty(textBox1.Text)  && !string.IsNullOrWhiteSpace(textBox1.Text))
  //          //{
  //          //    SqlCommand command = new SqlCommand("INSERT INTO [Position] (name)VALUES(@name)", sqlConnection);

  //          //    command.Parameters.AddWithValue("name", textBox1.Text);


  //          //    await command.ExecuteNonQueryAsync();

  //          //}
  //          //else
  //          //{
  //          //    label2.Visible = true;

  //          //    label2.Text = "Не все обязательные поля заполнены!";
  //          //}
  //      }

  //      private async void Position_Load(object sender, EventArgs e)
  //      {
		//	// TODO: данная строка кода позволяет загрузить данные в таблицу "_D__MYDB_MDFDataSet.Position". При необходимости она может быть перемещена или удалена.
		//	this.positionTableAdapter.Fill(this._D__MYDB_MDFDataSet.Position);
		//	//string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D:\MYDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

  // //         sqlConnection = new SqlConnection(connectionString);

  // //         await sqlConnection.OpenAsync();
  //      }

  //      private void Position_FormClosing(object sender, FormClosingEventArgs e)
  //      {
		//	//если пользователь нажал на первую кнопку:
		//	if (DialogResult == System.Windows.Forms.DialogResult.OK)
		//		//сохранить изменения:
		//		positionBindingSource.EndEdit();
		//	else
		//		//не сохранять изменения:
		//		positionBindingSource.CancelEdit();
		//}
    }
}
