using FMB_SYS.Models1;
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
            string mabarcode = txtID.Text;
            var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == mabarcode);
            if (update != null && update.Place == "FMB Stock")
            {
                var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == "Normal").OrderByDescending(c => c.FmbLine).ThenBy(c => c.FmbNo)
                        .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                if (check == update && update.Labkind == "Normal")
                {
                    lbInformation.Text = "Xe được lấy đi ở đầu hàng " + update.FmbLine + "\nMã xe: " + update.MaCode + "\nNgười lấy: " + _message;
                    update.PicTake = _message;
                    var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).ToList();
                    foreach (var item in down)
                    {
                        item.FmbNo--;
                        if (item.FmbNo < 1)
                        {
                            item.FmbNo = 5;
                            item.FmbLine = item.FmbLine + 1;
                        }
                    }
                    update.TakeTime = DateTime.Now;
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = "PD";
                    fmb.SaveChanges();
                    lbError.Text = "";
                    lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                }
                else if (update.Labkind == "NG lab")
                {
                    var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                    foreach (var item in up)
                    {
                        item.FmbNo--;
                    }
                    update.RemoveTime = DateTime.Now;
                    update.RemoveReason = "NG kết quả lab";
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    update.PicRemove = _message;
                    fmb.SaveChanges();
                    lbInformation.Text = "Xe" + update.MaNguyenLieu + "có mã: " + update.MaCode + " đã được hủy thành công\nNgười hủy: " + _message;
                    lbError.Text = string.Empty;
                }
                else if (update.Labkind == "Test")
                {
                    var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                    foreach (var item in up)
                    {
                        item.FmbNo--;
                    }
                    update.RemoveTime = DateTime.Now;
                    update.RemoveReason = "Cao su test";
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    update.PicRemove = _message;
                    fmb.SaveChanges();
                    lbInformation.Text = "Xe có mã: " + update.MaCode + " đã được lấy thành công\nNgười lấy: " + _message;
                    lbError.Text = string.Empty;
                }
                else if (update.Labkind == "Tráng máy")
                {
                    var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                    foreach (var item in up)
                    {
                        item.FmbNo--;
                    }
                    update.RemoveTime = DateTime.Now;
                    update.RemoveReason = "Cao su tráng máy";
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    update.PicRemove = _message;
                    fmb.SaveChanges();
                    lbInformation.Text = "Xe có mã: " + update.MaCode + " đã được lấy thành công\nNgười lấy: " + _message;
                    lbError.Text = string.Empty;
                }
                else if (update.Labkind == "Cán lại")
                {
                    var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                    foreach (var item in up)
                    {
                        item.FmbNo--;
                    }
                    update.RemoveTime = DateTime.Now;
                    update.RemoveReason = "Cao su cán lại";
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    update.PicRemove = _message;
                    fmb.SaveChanges();
                    lbInformation.Text = "Xe có mã: " + update.MaCode + " đã được lấy thành công\nNgười lấy: " + _message;
                    lbError.Text = string.Empty;
                }
                else if (update.Labkind == "Bổ sung")
                {
                    var checkbackup = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == update.Labkind).OrderByDescending(c => c.FmbLine).ThenBy(c => c.FmbNo)
                        .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                    if (checkbackup == update)
                    {
                        lbInformation.Text = "Xe được lấy đi ở đầu hàng " + update.FmbLine + "\nMã xe: " + update.MaCode + "\nNgười lấy: " + _message;
                        update.PicTake = _message;
                        var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == checkbackup.FmbLine).ToList();
                        foreach (var item in down)
                        {
                            item.FmbNo--;
                        }
                        update.TakeTime = DateTime.Now;
                        update.FmbLine = null;
                        update.FmbNo = null;
                        update.Place = "PD";
                        fmb.SaveChanges();
                        lbError.Text = "";
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                    }
                    else if (checkbackup != update && checkbackup != null)
                    {
                        lbError.Text = "Xe " + update.MaCode + " không ở vị trí đầu của hàng\nXe ở đầu hàng hiện tại ở hàng " + checkbackup.FmbLine + " vị trí " + checkbackup.FmbNo + "\nMã xe cần lấy: " + checkbackup.MaCode;
                        lbInformation.Text = "";
                    }
                }
                else if (check != update && check != null)
                {
                    lbError.Text = "Xe " + update.MaCode + " không ở vị trí đầu của hàng\nXe hiện tại ở hàng " + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe cần lấy: " + check.MaCode;
                    lbInformation.Text = "";
                }
            }
            else if (update != null && update.Place != "FMB Stock")
            {
                lbError.Text = "Xe " + update.MaCode + " không còn trong kho";
                lbInformation.Text = "";
            }
            else if (update == null)
            {
                lbError.Text = "Xe không tồn tại";
                lbInformation.Text = "";
            }
            else
            {
                lbInformation.Text = string.Empty;
                lbError.Text = string.Empty;

            }
            txtID.Text = string.Empty;
            timer1.Enabled = true;
            txtID.Focus();
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
            this.Size = new System.Drawing.Size(1920, 1080);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckstock open = new frmCheckstock();
            open.Message = lbName.Text;
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
