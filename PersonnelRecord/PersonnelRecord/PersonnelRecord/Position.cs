﻿using System;
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

        public Position()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                label2.Text = "Введите название должности!";
                return;
            }
            positionBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            positionBindingSource.CancelEdit();
            DialogResult = DialogResult.Abort;
        }
    }
}
