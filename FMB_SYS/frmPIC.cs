﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMB_SYS
{
    public partial class frmPIC : Form
    {
        public frmPIC()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmMain child = new frmMain();
            child.Message = txtName.Text;
            child.ShowDialog();
            txtName.Text = string.Empty;
        }
    }
}