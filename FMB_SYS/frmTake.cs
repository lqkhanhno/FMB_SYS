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
            timer1.Enabled = false;
            string mabarcode = txtID.Text;
            var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == mabarcode);
            if (update != null)
            {
                if (update.Place == "FMB Stock")
                {
                    if (update.Labkind == "Normal")
                    {
                        var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == "Normal").OrderByDescending(c => c.FmbLine).ThenBy(c => c.FmbNo)
                        .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                        if (check == update)
                        {
                            lbInformation.Text = "Xe được lấy đi ở đầu hàng " + update.FmbLine + "\nMã xe: " + update.MaNguyenLieu + "\nNgười lấy: " + _message;
                            update.PicTake = _message;
                            var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.MaNguyenLieu == update.MaNguyenLieu).Where(c => c.Labkind == update.Labkind).ToList();
                            foreach (var item in down)
                            {
                                item.FmbNo--;
                                if (item.FmbNo < 1)
                                {
                                    item.FmbNo = 5;
                                    item.FmbLine++;
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
                        else if (check != update && check != null)
                        {
                            lbError.Text = "Xe " + update.MaNguyenLieu + " không ở vị trí đầu của hàng\nXe hiện tại ở hàng " + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe cần lấy: " + check.MaCode;
                            lbInformation.Text = "";
                        }
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
                        lbInformation.Text = "Xe" + update.MaNguyenLieu + " đã được hủy thành công\nNgười hủy: " + _message;
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
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
                        lbInformation.Text = "Xe có mã: " + update.MaNguyenLieu + " đã được lấy thành công\nNgười lấy: " + _message;
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
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
                        lbInformation.Text = "Xe có mã: " + update.MaNguyenLieu + " đã được lấy thành công\nNgười lấy: " + _message;
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
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
                        lbInformation.Text = "Xe có mã: " + update.MaNguyenLieu + " đã được lấy thành công\nNgười lấy: " + _message;
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                    }
                    else if (update.Labkind == "Bổ sung")
                    {
                        var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo > update.FmbNo).ToList();
                        foreach (var item in up)
                        {
                            item.FmbNo--;
                        }
                        update.TakeTime = DateTime.Now;
                        update.FmbLine = null;
                        update.FmbNo = null;
                        update.Place = "PD";
                        update.PicTake = _message;
                        fmb.SaveChanges();
                        lbInformation.Text = "Xe có mã: " + update.MaNguyenLieu + " đã được lấy thành công\nNgười lấy: " + _message;
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                    }
                }
                else if (update.Place == "PD")
                {
                    lbError.Text = "Xe " + update.MaNguyenLieu + " này không còn trong kho\nXe đã được mang đi cán vào lúc: " + update.TakeTime + " bởi: " + update.PicTake;
                    lbInformation.Text = "";
                    lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                }
                else if (update.Place == null)
                {
                    lbError.Text = "Xe " + update.MaNguyenLieu + " này không còn trong kho\nXe đã hủy lúc: " + update.RemoveTime + " bởi: " + update.PicRemove + "\nLí do hủy: " + update.RemoveReason;
                    lbInformation.Text = "";
                    lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                }
            }
            else
            {
                lbError.Text = "Xe chưa từng nhập kho";
                lbInformation.Text = "";
                lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
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
