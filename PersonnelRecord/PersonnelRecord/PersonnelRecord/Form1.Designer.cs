﻿namespace PersonnelRecord
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMYDBMDFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__MYDB_MDFDataSet = new PersonnelRecord._D__MYDB_MDFDataSet();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.EmployeeTableAdapter();
            this.startWorkTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.StartWorkTableAdapter();
            this.salaryTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.SalaryTableAdapter();
            this.positionTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteEnd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewEnd = new System.Windows.Forms.DataGridView();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editStart = new System.Windows.Forms.Button();
            this.deliteStart = new System.Windows.Forms.Button();
            this.addStart = new System.Windows.Forms.Button();
            this.dataGridViewStart = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Оклад = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.tabelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.endWorkTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.EndWorkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMYDBMDFDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWorkBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endWorkBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dMYDBMDFDataSetBindingSource;
            // 
            // dMYDBMDFDataSetBindingSource
            // 
            this.dMYDBMDFDataSetBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            this.dMYDBMDFDataSetBindingSource.Position = 0;
            // 
            // _D__MYDB_MDFDataSet
            // 
            this._D__MYDB_MDFDataSet.DataSetName = "_D__MYDB_MDFDataSet";
            this._D__MYDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.dMYDBMDFDataSetBindingSource;
            // 
            // startWorkBindingSource
            // 
            this.startWorkBindingSource.DataMember = "StartWork";
            this.startWorkBindingSource.DataSource = this.dMYDBMDFDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // startWorkTableAdapter
            // 
            this.startWorkTableAdapter.ClearBeforeFill = true;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button12);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(659, 345);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Должности";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(102, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 23);
            this.button12.TabIndex = 7;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(56, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(8, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(8, 41);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(257, 296);
            this.dataGridView5.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(659, 345);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Кадровый перевод";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(56, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(8, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 41);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(576, 298);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.deleteEnd);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dataGridViewEnd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Увольнение с работы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(102, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.editEnd_Click);
            // 
            // deleteEnd
            // 
            this.deleteEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEnd.Location = new System.Drawing.Point(56, 12);
            this.deleteEnd.Name = "deleteEnd";
            this.deleteEnd.Size = new System.Drawing.Size(40, 23);
            this.deleteEnd.TabIndex = 9;
            this.deleteEnd.Text = "-";
            this.deleteEnd.UseVisualStyleBackColor = true;
            this.deleteEnd.Click += new System.EventHandler(this.deleteEnd_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(8, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.addEnd_Click);
            // 
            // dataGridViewEnd
            // 
            this.dataGridViewEnd.AllowUserToAddRows = false;
            this.dataGridViewEnd.AllowUserToDeleteRows = false;
            this.dataGridViewEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEnd.AutoGenerateColumns = false;
            this.dataGridViewEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewEnd.DataSource = this.endWorkBindingSource;
            this.dataGridViewEnd.Location = new System.Drawing.Point(8, 41);
            this.dataGridViewEnd.Name = "dataGridViewEnd";
            this.dataGridViewEnd.ReadOnly = true;
            this.dataGridViewEnd.Size = new System.Drawing.Size(643, 298);
            this.dataGridViewEnd.TabIndex = 2;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "employee";
            this.employeeDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.employeeDataGridViewTextBoxColumn.DisplayMember = "fio";
            this.employeeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата окончания работы";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // endWorkBindingSource
            // 
            this.endWorkBindingSource.DataMember = "EndWork";
            this.endWorkBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editStart);
            this.tabPage2.Controls.Add(this.deliteStart);
            this.tabPage2.Controls.Add(this.addStart);
            this.tabPage2.Controls.Add(this.dataGridViewStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прием на работу";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editStart
            // 
            this.editStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStart.Location = new System.Drawing.Point(102, 10);
            this.editStart.Name = "editStart";
            this.editStart.Size = new System.Drawing.Size(36, 23);
            this.editStart.TabIndex = 7;
            this.editStart.Text = "/";
            this.editStart.UseVisualStyleBackColor = true;
            this.editStart.Click += new System.EventHandler(this.editStart_Click);
            // 
            // deliteStart
            // 
            this.deliteStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliteStart.Location = new System.Drawing.Point(56, 10);
            this.deliteStart.Name = "deliteStart";
            this.deliteStart.Size = new System.Drawing.Size(40, 23);
            this.deliteStart.TabIndex = 2;
            this.deliteStart.Text = "-";
            this.deliteStart.UseVisualStyleBackColor = true;
            this.deliteStart.Click += new System.EventHandler(this.deleteStart_Click);
            // 
            // addStart
            // 
            this.addStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStart.Location = new System.Drawing.Point(8, 10);
            this.addStart.Name = "addStart";
            this.addStart.Size = new System.Drawing.Size(42, 23);
            this.addStart.TabIndex = 1;
            this.addStart.Text = "+";
            this.addStart.UseVisualStyleBackColor = true;
            this.addStart.Click += new System.EventHandler(this.addStart_Click);
            // 
            // dataGridViewStart
            // 
            this.dataGridViewStart.AllowUserToAddRows = false;
            this.dataGridViewStart.AllowUserToDeleteRows = false;
            this.dataGridViewStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStart.AutoGenerateColumns = false;
            this.dataGridViewStart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.dataGridViewTextBoxColumn2,
            this.salaryDataGridViewTextBoxColumn,
            this.Оклад});
            this.dataGridViewStart.DataSource = this.startWorkBindingSource;
            this.dataGridViewStart.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewStart.Name = "dataGridViewStart";
            this.dataGridViewStart.ReadOnly = true;
            this.dataGridViewStart.Size = new System.Drawing.Size(635, 298);
            this.dataGridViewStart.TabIndex = 0;
            this.dataGridViewStart.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewStart_DataError);
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "employee";
            this.employeeName.DataSource = this.employeeBindingSource;
            this.employeeName.DisplayMember = "fio";
            this.employeeName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.employeeName.HeaderText = "Сотрудник";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeName.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "startdate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата приема на работу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "sPos";
            this.salaryDataGridViewTextBoxColumn.DataSource = this.positionBindingSource;
            this.salaryDataGridViewTextBoxColumn.DisplayMember = "name";
            this.salaryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.salaryDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // Оклад
            // 
            this.Оклад.DataPropertyName = "salary";
            this.Оклад.DataSource = this.salaryBindingSource;
            this.Оклад.DisplayMember = "sum";
            this.Оклад.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Оклад.HeaderText = "Оклад";
            this.Оклад.Name = "Оклад";
            this.Оклад.ReadOnly = true;
            this.Оклад.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Оклад.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Оклад.ValueMember = "id";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 371);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.dataGridViewEmployees);
            this.tabPage1.Controls.Add(this.delete);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(91, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "/";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabelNumberDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(645, 305);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // tabelNumberDataGridViewTextBoxColumn
            // 
            this.tabelNumberDataGridViewTextBoxColumn.DataPropertyName = "tabelNumber";
            this.tabelNumberDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.tabelNumberDataGridViewTextBoxColumn.Name = "tabelNumberDataGridViewTextBoxColumn";
            this.tabelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "dateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "Дата начала работы на позиции";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Дата окончания работы на позиции";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(49, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(36, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(6, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(37, 23);
            this.add.TabIndex = 4;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // endWorkTableAdapter
            // 
            this.endWorkTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Кадровый учет";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMYDBMDFDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWorkBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endWorkBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dMYDBMDFDataSetBindingSource;
        private _D__MYDB_MDFDataSet _D__MYDB_MDFDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private _D__MYDB_MDFDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource startWorkBindingSource;
        private _D__MYDB_MDFDataSetTableAdapters.StartWorkTableAdapter startWorkTableAdapter;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private _D__MYDB_MDFDataSetTableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private _D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteEnd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewEnd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button editStart;
        private System.Windows.Forms.Button deliteStart;
        private System.Windows.Forms.Button addStart;
        private System.Windows.Forms.DataGridView dataGridViewStart;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Оклад;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.BindingSource endWorkBindingSource;
        private _D__MYDB_MDFDataSetTableAdapters.EndWorkTableAdapter endWorkTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
