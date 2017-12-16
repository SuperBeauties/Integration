namespace PersonnelRecord
{
    partial class AddEmployee
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
            this.label5 = new System.Windows.Forms.Label();
            this.tabelNumber = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__MYDB_MDFDataSet = new PersonnelRecord._D__MYDB_MDFDataSet();
            this.fio = new System.Windows.Forms.TextBox();
            this.passportData = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Табельный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспортные данные";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // tabelNumber
            // 
            this.tabelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "tabelNumber", true));
            this.tabelNumber.Location = new System.Drawing.Point(148, 6);
            this.tabelNumber.Name = "tabelNumber";
            this.tabelNumber.Size = new System.Drawing.Size(92, 20);
            this.tabelNumber.TabIndex = 9;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // _D__MYDB_MDFDataSet
            // 
            this._D__MYDB_MDFDataSet.DataSetName = "_D__MYDB_MDFDataSet";
            this._D__MYDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fio
            // 
            this.fio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "fio", true));
            this.fio.Location = new System.Drawing.Point(148, 35);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(280, 20);
            this.fio.TabIndex = 10;
            // 
            // passportData
            // 
            this.passportData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "passportData", true));
            this.passportData.Location = new System.Drawing.Point(148, 93);
            this.passportData.Name = "passportData";
            this.passportData.Size = new System.Drawing.Size(280, 20);
            this.passportData.TabIndex = 11;
            // 
            // address
            // 
            this.address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "address", true));
            this.address.Location = new System.Drawing.Point(148, 125);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(280, 20);
            this.address.TabIndex = 12;
            // 
            // birthdate
            // 
            this.birthdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "birthdate", true));
            this.birthdate.Location = new System.Drawing.Point(148, 64);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(200, 20);
            this.birthdate.TabIndex = 15;
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(225, 182);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 26);
            this.save.TabIndex = 18;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(341, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddEmployee
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(454, 230);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.address);
            this.Controls.Add(this.passportData);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.tabelNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEmployee";
            this.Text = "Сотрудник";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.TextBox tabelNumber;
        public System.Windows.Forms.TextBox fio;
        public System.Windows.Forms.TextBox passportData;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Button button1;
		private _D__MYDB_MDFDataSet _D__MYDB_MDFDataSet;
		public System.Windows.Forms.BindingSource employeeBindingSource;
	}
}