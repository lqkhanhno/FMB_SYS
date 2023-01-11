using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            frmTake take = new frmTake();
            take.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBack back = new frmBack();
            back.ShowDialog();
        }

        private void btnBacknew_Click(object sender, EventArgs e)
        {
            frmBacknew backnew = new frmBacknew();
            backnew.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckstock checkstock = new frmCheckstock();
            checkstock.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTake take = new frmTake();
            take.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmBack back = new frmBack();
            back.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmBacknew backnew = new frmBacknew();
            backnew.ShowDialog();
        }
        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = _message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
