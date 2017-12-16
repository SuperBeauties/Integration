namespace PersonnelRecord
{
    partial class StartWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startWorkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._D__MYDB_MDFDataSet = new PersonnelRecord._D__MYDB_MDFDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sum = new System.Windows.Forms.TextBox();
            this.startWorkTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.StartWorkTableAdapter();
            this.employeeTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.EmployeeTableAdapter();
            this.positionTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startWorkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Оклад";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(33, 143);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(114, 143);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.startWorkBindingSource1, "startdate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // startWorkBindingSource1
            // 
            this.startWorkBindingSource1.DataMember = "StartWork";
            this.startWorkBindingSource1.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // _D__MYDB_MDFDataSet
            // 
            this._D__MYDB_MDFDataSet.DataSetName = "_D__MYDB_MDFDataSet";
            this._D__MYDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.startWorkBindingSource1, "employee", true));
            this.comboBox1.DataSource = this.employeeBindingSource;
            this.comboBox1.DisplayMember = "fio";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.startWorkBindingSource1, "sPos", true));
            this.comboBox2.DataSource = this.positionBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "Id";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // sum
            // 
            this.sum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.startWorkBindingSource1, "sum", true));
            this.sum.Location = new System.Drawing.Point(101, 94);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(200, 20);
            this.sum.TabIndex = 10;
            // 
            // startWorkTableAdapter
            // 
            this.startWorkTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // StartWork
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(318, 178);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartWork";
            this.Text = "Прием на работу";
            this.Load += new System.EventHandler(this.StartWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startWorkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox sum;
        private _D__MYDB_MDFDataSet _D__MYDB_MDFDataSet;
        private _D__MYDB_MDFDataSetTableAdapters.StartWorkTableAdapter startWorkTableAdapter;
        public System.Windows.Forms.BindingSource startWorkBindingSource1;
        public System.Windows.Forms.BindingSource employeeBindingSource;
        public _D__MYDB_MDFDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        public System.Windows.Forms.BindingSource positionBindingSource;
        public _D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}