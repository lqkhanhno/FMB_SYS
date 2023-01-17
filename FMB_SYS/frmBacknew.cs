using FMB_SYS.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FMB_SYS
{
    public partial class frmBacknew : Form
    {
        public frmBacknew()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain load = new frmMain();
            load.Refresh();
        }
        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        HVN_SYSContext fmb = new HVN_SYSContext();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                timer1.Enabled = false;
                var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
                if (update != null && update.Place != "FMB Stock")
                {
                    try
                    {
                        update.PicRemove = _message;
                        update.FmbLine = null;
                        update.FmbNo = null;
                        update.Place = null;
                        int save = fmb.SaveChanges();
                        if (save > 0)
                        {
                            lbInformation.Text = ("Xe " + update.MaCode + " đã hết.\nNgười báo hết: " + _message);
                            lbError.Text = "";
                        }
                        else
                        {
                            lbInformation.Text = ("Xe " + update.MaCode + " đã được báo hết");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                }
                else if (update != null && update.Place == "FMB Stock")
                {
                    lbError.Text = ("Xe đang ở trong kho!");
                    DialogResult box = MessageBox.Show("Bạn có chắc chắn muốn bỏ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (box == DialogResult.Yes)
                    {
                        var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                            .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                        if (check != null && update != check)
                        {
                            lbError.Text = "Xe không ở vị trí cuối cùng!\nXe ở cuối cùng hiện tại ở hàng" + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe: " + check.MaCode + "\nNgười báo hết: " + _message;
                            lbInformation.Text = "";
                        }
                        else
                        {
                            try
                            {
                                update.FmbLine = null;
                                update.FmbNo = null;
                                update.Place = null;
                                int save = fmb.SaveChanges();
                                if (save > 0)
                                {
                                    lbInformation.Text = ("Xe " + update.MaCode + " đã được bỏ");
                                    lbError.Text = "";
                                }
                                lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                                txtID.Focus();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error");
                            }
                        }
                    }
                }
                else if (update == null)
                {
                    lbError.Text = ("Mã xe không tồn tại!");
                    lbInformation.Text = "";
                }
                else
                {
                    lbError.Text = "";
                    lbInformation.Text = "";
                }
                txtID.Text = string.Empty;
                timer1.Enabled = true;
            }
            else
            {
                txtID.Focus();
                lbError.Text = "Chưa quét mã QR của xe";
                lbSP.Text = "Quét mã QR của xe rồi mới Enter";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }

        private void frmBacknew_Load(object sender, EventArgs e)
        {
            lbError.Text = string.Empty;
            lbInformation.Text = string.Empty;
            lbSP.Text = "Quét mã QR của xe";
            txtID.Focus();
            lbName.Text = _message;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckstock check = new frmCheckstock();
            check.ShowDialog();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                lbSP.Text = "Enter";
            }
        }
    }
}
