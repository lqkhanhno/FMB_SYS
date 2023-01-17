using FMB_SYS.Models;
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
    public partial class frmBack : Form
    {
        public frmBack()
        {
            InitializeComponent();
        }
        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        HVN_SYSContext fmb = new HVN_SYSContext();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain load = new frmMain();
            load.Refresh();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                timer1.Enabled = false;
                var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
                if (update != null)
                {
                    var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                    var first = (from p in fmb.PFmbLabResults
                                 join m in fmb.PFmbMasterLocationRubbers on p.MaNguyenLieu equals m.RubberName
                                 where p.MaCode == txtID.Text
                                 select m).FirstOrDefault();
                    if (check != null && update.Place == "PD")
                    {
                        if (txtWeight.Text == "")
                        {
                            txtWeight.Focus();
                            lbError.Text = "Nhập khối lượng còn lại của xe " + update.MaCode;
                            lbInformation.Text = string.Empty;
                        }
                        else if(int.Parse(txtWeight.Text) <= 0)
                        {
                            lbError.Text = "Khối lượng không hợp lệ";
                            lbInformation.Text = string.Empty;
                        }
                        else
                        {
                            if (update.KhoiLuong >= int.Parse(txtWeight.Text))
                            {
                                update.PicReturn = _message;
                                update.KhoiLuong = int.Parse(txtWeight.Text);
                                update.Place = "FMB Stock";
                                if (check.FmbNo == 5)
                                {
                                    update.FmbLine = check.FmbLine + 1;
                                    update.FmbNo = 1;
                                }
                                else
                                {
                                    update.FmbLine = check.FmbLine;
                                    update.FmbNo = check.FmbNo + 1;
                                }
                                int save = fmb.SaveChanges();
                                if (save > 0)
                                {
                                    lbInformation.Text = ("Xe " + update.MaCode + " đã được trả về hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nXe còn lại " + txtWeight.Text + ". Người trả xe: " + _message);
                                }
                                txtWeight.Text = "";
                                lbError.Text = "";
                                lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                                txtID.Focus();
                            }
                            else
                            {
                                lbError.Text = ("Xe trả về có khối lượng lớn hơn xe lấy đi");
                                lbInformation.Text = "";
                            }
                        }
                    }
                    else if (update.Place == "FMB Stock")
                    {
                        lbError.Text = ("Chọn sai chức năng\nXe " + update.MaCode + " đang ở trong kho\nHàng " + update.FmbLine + " vị trí " + update.FmbNo);
                        lbInformation.Text = "";
                    }
                    else if (update.Place == null)
                    {
                        lbError.Text = ("Chọn sai chức năng\nXe " + update.MaCode + " chưa nhập kho");
                        lbInformation.Text = "";
                    }
                    else if (check == null && first != null)
                    {
                        if (txtWeight.Text == "")
                        {
                            txtWeight.Focus();
                            lbError.Text = "Nhập khối lượng còn lại của xe " + update.MaCode;
                        }
                        else
                        {
                            if (update.KhoiLuong >= int.Parse(txtWeight.Text))
                            {
                                update.PicReturn = _message;
                                update.KhoiLuong = int.Parse(txtWeight.Text);
                                update.Place = "FMB Stock";
                                update.FmbLine = first.FmbLine;
                                update.FmbNo = 1;
                                int save = fmb.SaveChanges();
                                if (save > 0)
                                {
                                    lbInformation.Text = ("Xe " + update.MaCode + " đã được về trả về hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nXe còn lại " + txtWeight.Text + ".Người trả xe: " + _message);
                                }
                                txtWeight.Text = "";
                                lbError.Text = "";
                            }
                            else
                            {
                                lbError.Text = ("Xe trả về có khối lượng lớn hơn xe lấy đi");
                                lbInformation.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    txtID.Text = string.Empty;
                    txtWeight.Text = string.Empty;
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

        private void frmBack_Load(object sender, EventArgs e)
        {
            lbError.Text = string.Empty;
            lbInformation.Text = string.Empty;
            lbSP.Text = "Quét mã QR của xe";
            txtID.Focus();
            lbName.Text = _message;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                lbSP.Text = "Nhập khối lượng còn lại";
                txtWeight.Focus();
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckstock open = new frmCheckstock();
            open.ShowDialog();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWeight.Text.Length >= 1)
            {
                lbSP.Text = "Enter";
            }
        }
    }
}
