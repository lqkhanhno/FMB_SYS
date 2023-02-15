using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmAdd add = new frmAdd();
                add.Message = lbName.Text;
                add.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmTake take = new frmTake();
                take.Message = lbName.Text;
                take.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmBack back = new frmBack();
                back.Message = lbName.Text;
                back.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void btnBacknew_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmBacknew backnew = new frmBacknew();
                backnew.Message = lbName.Text;
                backnew.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            frmCheckstock checkstock = new frmCheckstock();
            checkstock.Message = lbName.Text;
            checkstock.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmAdd add = new frmAdd();
                add.Message = lbName.Text;
                add.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmTake take = new frmTake();
                take.Message = lbName.Text;
                take.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmBack back = new frmBack();
                back.Message = lbName.Text;
                back.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (lbName.Text != string.Empty)
            {
                timer1.Enabled = false;
                frmBacknew backnew = new frmBacknew();
                backnew.Message = lbName.Text;
                backnew.ShowDialog();
            }
            else
            {
                button1_Click(sender, e);
                timer1.Enabled = false;
            }
        }
        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmload();
        }
        public void frmload()
        {
            lbName.Text = _message;
            timer1.Enabled = true;
            this.Size = new System.Drawing.Size(1920, 1080);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            frmCheckstock open = new frmCheckstock();
            open.ShowDialog();
        }
    }
}
