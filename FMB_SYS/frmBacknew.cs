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
            timer1.Enabled = false;
            var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
            if (update != null && update.Place != "FMB Stock")
            {
                lbError.Text = "Xe không còn trong kho\n";
                if (update.PicRemove != null)
                {
                    lbError.Text += "Xe đã được hủy bởi: " + update.PicRemove + "\nThời gian hủy: " + update.RemoveTime + "\nLý do: " + update.RemoveReason;
                }
                else if(update.PicTake != null)
                {
                    lbError.Text += "Người lấy: " + update.PicTake + "\nThời gian lấy: " + update.TakeTime;
                }
                lbInformation.Text = string.Empty;
            }
            else if (update != null && update.Place == "FMB Stock")
            {
                if (txtlistreason.Text == string.Empty)
                {
                    lbInformation.Text = string.Empty;
                    lbSP.Text = "Cần chọn lý do hủy trước khi quét";
                    lbError.Text = "Chưa chọn lý do hủy";
                }
                else
                {
                    var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                    var check = fmb.PFmbMasterLocationRubbers.OrderBy(c => c.FmbLine).FirstOrDefault(c => c.RubberName == update.MaNguyenLieu);
                    var check1 = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == update.MaNguyenLieu);
                    foreach (var item in up)
                    {
                        item.FmbNo--;
                    }
                    if (check != check1 && check != null && check1 != null)
                    {
                        if (update.FmbLine == check1.FmbLine)
                        {
                            var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == check.FmbLine).ToList();
                            foreach (var item in down)
                            {
                                item.FmbNo--;
                                if (item.FmbNo < 1)
                                {
                                    item.FmbNo = 5;
                                    item.FmbLine = item.FmbLine + 1;
                                }
                            }
                        }
                    }
                    update.RemoveTime = DateTime.Now;
                    update.RemoveReason = txtlistreason.Text;
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    update.PicRemove = _message;
                    fmb.SaveChanges();
                    lbInformation.Text = "Xe có mã: " + update.MaCode + " đã được hủy thành công\nNgười hủy: " + _message+"\nLý do hủy: "+update.RemoveReason;
                    lbError.Text = string.Empty;
                    txtlistreason.SelectedItems.Clear();
                }
            }
            lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
            txtID.Focus();
            txtID.Text = string.Empty;
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
            this.Size = new System.Drawing.Size(1920, 1080);

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
