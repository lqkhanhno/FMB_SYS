using FMB_SYS.Models1;
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
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                timer1.Enabled = false;
                var update = fmb.PFmbLabels
                        .SingleOrDefault(c => c.CartId == txtID.Text.Substring(2, 10));
                if (update != null)
                {
                    var check = fmb.PFmbLabels.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                .FirstOrDefault(c => c.RubberName == update.RubberName);
                    var first = (from p in fmb.PFmbLabels
                                 join m in fmb.PFmbMasterLocationRubbers on p.RubberName equals m.RubberName
                                 where p.CartId == txtID.Text.Substring(2, 10)
                                 select m).FirstOrDefault();
                    if (check != null && update.Place == "PD")
                    {
                        if (txtWeight.Text == "")
                        {
                            txtWeight.Focus();
                            lbError.Text = "Nhập khối lượng còn lại của xe " + update.CartId;
                        }
                        else
                        {
                            if (update.RubberWeight >= int.Parse(txtWeight.Text))
                            {
                                update.PicReturn = _message;
                                update.RubberWeight = int.Parse(txtWeight.Text);
                                update.Place = "FMB Stock";
                                if (check.FmbNo == 6)
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
                                    lbInformation.Text = ("Xe " + update.CartId + " đã được trả về hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nXe còn lại " + txtWeight.Text + ".Người trả xe: " + _message);
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
                        lbError.Text = ("Chọn sai chức năng\nXe " + update.CartId + " đang ở trong kho\nHàng " + update.FmbLine + " vị trí " + update.FmbNo);
                        lbInformation.Text = "";
                    }
                    else if (update.Place == null)
                    {
                        lbError.Text = ("Chọn sai chức năng\nXe " + update.CartId + " chưa nhập kho");
                        lbInformation.Text = "";
                    }
                    else if (check == null && first != null)
                    {
                        if (txtWeight.Text == "")
                        {
                            txtWeight.Focus();
                            lbError.Text = "Nhập khối lượng còn lại của xe " + update.CartId;
                        }
                        else
                        {
                            if (update.RubberWeight >= int.Parse(txtWeight.Text))
                            {
                                update.PicReturn = _message;
                                update.RubberWeight = int.Parse(txtWeight.Text);
                                update.Place = "FMB Stock";
                                update.FmbLine = first.FmbLine;
                                update.FmbNo = 1;
                                int save = fmb.SaveChanges();
                                if (save > 0)
                                {
                                    lbInformation.Text = ("Xe " + update.CartId + " đã được về trả về hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nXe còn lại " + txtWeight.Text + ".Người trả xe: " + _message);
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
            lbSP.Text = "Quét mã QR của xe";
            txtID.Focus();
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
            open.Close();
        }
    }
}
