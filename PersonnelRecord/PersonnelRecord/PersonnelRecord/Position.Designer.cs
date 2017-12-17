namespace PersonnelRecord
{
    partial class Position
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__MYDB_MDFDataSet = new PersonnelRecord._D__MYDB_MDFDataSet();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.positionTableAdapter = new PersonnelRecord._D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // textBox
            // 
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "name", true));
            this.textBox.Location = new System.Drawing.Point(101, 6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(206, 20);
            this.textBox.TabIndex = 2;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this._D__MYDB_MDFDataSet;
            // 
            // _D__MYDB_MDFDataSet
            // 
            this._D__MYDB_MDFDataSet.DataSetName = "_D__MYDB_MDFDataSet";
            this._D__MYDB_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 54);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(93, 54);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // Position
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(323, 89);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Position";
            this.Text = "Должность";
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__MYDB_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private _D__MYDB_MDFDataSet _D__MYDB_MDFDataSet;
        private _D__MYDB_MDFDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        public System.Windows.Forms.BindingSource positionBindingSource;
    }
}