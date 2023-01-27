using FMB_SYS.Models1;
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
    public partial class frmTake : Form
    {
        public frmTake()
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
        private void btnEnter_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (txtID.Text.Length >= 10)
            {
                var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
                if (update != null && update.Place == "FMB Stock")
                {
                    var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                            .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                    if (check == update)
                    {
                        if (update != null)
                        {
                            lbInformation.Text = "Xe được lấy đi ở hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nMã xe: " + update.MaCode + "\nNgười lấy: " + _message;
                            update.PicTake = _message;
                            var down = fmb.PFmbLabResults.Where(c => c.MaNguyenLieu == update.MaNguyenLieu).ToList();
                            foreach (var item in down)
                            {
                                item.FmbNo++;
                                if (item.FmbNo > 5)
                                {
                                    item.FmbNo = 1;
                                    item.FmbLine = item.FmbLine + 1;
                                }
                            }
                            update.TakeTime = DateTime.Now;
                            update.FmbLine = null;
                            update.FmbNo = null;
                            update.Place = "PD";
                            if (update.Labkind == "Arnormal")
                            {
                                update.Place = null;
                                update.PicTake = null;
                                update.TakeTime = null;
                                update.RemoveTime = DateTime.Now;
                                update.RemoveReason = "NG kết quả lab";
                                update.PicRemove = _message;
                            }
                            fmb.SaveChanges();
                            lbError.Text = "";
                            lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                            txtID.Text = string.Empty;
                            txtID.Focus();
                        }
                    }
                    else if (check != update && check != null)
                    {
                        lbError.Text = "Xe " + update.MaCode + " không ở vị trí cuối cùng của hàng\nXe ở cuối cùng hiện tại ở hàng " + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe cần lấy: " + check.MaCode;
                        lbInformation.Text = "";
                        txtID.Text = string.Empty;
                        txtID.Focus();
                    }
                }
                else if (update != null && update.Place != "FMB Stock")
                {
                    lbError.Text = "Xe " + update.MaCode + " không còn trong kho";
                    lbInformation.Text = "";
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
                else if (update == null)
                {
                    lbError.Text = "Xe không tồn tại";
                    lbInformation.Text = "";
                    txtID.Text = string.Empty;
                    txtID.Focus();
                }
                else
                {
                    lbInformation.Text = string.Empty;
                    lbError.Text = string.Empty;
                    txtID.Text = string.Empty;
                    txtID.Focus();
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain load = new frmMain();
            load.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }

        private void frmTake_Load(object sender, EventArgs e)
        {
            lbError.Text = string.Empty;
            lbInformation.Text = string.Empty;
            lbSP.Text = "Quét mã QR của xe";
            txtID.Focus();
            lbName.Text = _message;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckstock open = new frmCheckstock();
            open.ShowDialog();
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
