using FMB_SYS.Models1;
using FMB_SYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FMB_SYS
{
    public partial class frmAdd : Form
    {
        public frmAdd()
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
        COEX_MESContext lab = new COEX_MESContext();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            var labInfo = lab.Barcodes.SingleOrDefault(c => c.MaCode == txtID.Text);
            var fmbInfo = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
            if (fmbInfo != null && fmbInfo.Place == "PD")
            {
                lbError.Text = "Chọn sai chức năng\nXe có mã: " + fmbInfo.MaCode + " hiện tại đang ở PD\nCần báo hết cho xe!";
                lbInformation.Text = "";
                txtID.Text = string.Empty;
                txtID.Focus();
                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
            }
            else if (fmbInfo != null && fmbInfo.Place == "FMB Stock")
            {
                lbError.Text = "Xe có mã: " + fmbInfo.MaCode + " đã ở trong kho\nHàng " + fmbInfo.FmbLine + " vị trí " + fmbInfo.FmbNo;
                lbInformation.Text = "";
                txtID.Text = string.Empty;
                txtID.Focus();
                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
            }
            else if (fmbInfo != null && fmbInfo.Place == null && labInfo != null)
            {
                if (fmbInfo.Kq == "NG" || listArnormal.Visible == true && listArnormal.SelectedItems != null)
                {
                    fmbInfo.Labkind = "NG lab";
                    if (listArnormal.Visible == true && listArnormal.SelectedItems != null)
                    {
                        fmbInfo.Labkind = listArnormal.Text;
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                        if (due != null && fmbInfo.ThoiGian != null)
                        {
                            int duemax = Convert.ToInt32(due.VadilityMax);
                            int duemin = Convert.ToInt32(due.VadilityMin);
                            fmbInfo.MinDuedate = fmbInfo.ThoiGian.Value.AddHours(duemin);
                            fmbInfo.MaxDuedate = fmbInfo.ThoiGian.Value.AddHours(duemax);
                            fmb.SaveChanges();
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                        }
                        else
                        {
                            lbError.Text = "Chưa có thông tin hạn của mã cao su " + fmbInfo.MaNguyenLieu;
                            lbInformation.Text = string.Empty;
                            lbSP.Text = "Vui lòng báo với IT";
                        }
                    }
                    var countno = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Count(c => c.Labkind == fmbInfo.Labkind);
                    if (countno >= 5)
                    {
                        lbError.Text = "Kho đã đầy không thể nhập";
                        lbInformation.Text = "";
                        txtID.Text = string.Empty;
                        txtID.Focus();
                        lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                    }
                    else
                    {
                        var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderBy(c => c.FmbNo).FirstOrDefault(c => c.Labkind == fmbInfo.Labkind);
                        if (check != null)
                        {
                            fmbInfo.FmbNo = check.FmbNo + 1;
                        }
                        else
                        {
                            fmbInfo.FmbNo = 1;
                        }
                        var line = fmb.PFmbMasterLocationRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.Labkind);
                        if (line != null)
                        {
                            fmbInfo.Place = "FMB Stock";
                            fmbInfo.FmbLine = line.FmbLine;
                            fmbInfo.InputTime = DateTime.Now;
                            fmbInfo.PicInput = lbName.Text;
                            lbInformation.Text = "Mã xe: " + fmbInfo.MaCode + " được thêm vào hàng " + fmbInfo.FmbLine + "\nNgười thêm: " + _message;
                            lbError.Text = "";
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            fmb.SaveChanges();
                        }
                    }
                }
                else
                {
                    var count = fmb.PFmbMasterLocationRubbers.Count(c => c.RubberName == fmbInfo.MaNguyenLieu);
                    var countno = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == "Normal").Count(c => c.MaNguyenLieu == fmbInfo.MaNguyenLieu);
                    if (count != 0 && countno != 0 && countno >= count * 5)
                    {
                        lbError.Text = "Kho đã đầy không thể nhập";
                        lbInformation.Text = "";
                    }
                    else
                    {
                        var check = fmb.PFmbLabResults.Where(c => c.Labkind == "Normal").Where(c => c.Place == "FMB Stock").OrderBy(c => c.FmbLine).ThenByDescending(c => c.FmbNo).FirstOrDefault(c => c.MaNguyenLieu == fmbInfo.MaNguyenLieu);
                        var last = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                        if (check != null && last != null)
                        {
                            var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                            fmbInfo.InputTime = DateTime.Now;
                            fmbInfo.PicInput = lbName.Text;
                            if (check.FmbNo == 5)
                            {
                                fmbInfo.FmbLine = check.FmbLine - 1;
                                fmbInfo.FmbNo = 1;
                            }
                            else
                            {
                                fmbInfo.FmbLine = check.FmbLine;
                                fmbInfo.FmbNo = check.FmbNo + 1;
                            }
                            fmbInfo.Place = "FMB Stock";
                            lbInformation.Text = "Mã xe: " + fmbInfo.MaCode + " được thêm vào hàng " + fmbInfo.FmbLine + "\nNgười thêm: " + _message;
                            lbError.Text = "";
                            if (due != null && fmbInfo.ThoiGian != null)
                            {
                                int duemax = Convert.ToInt32(due.VadilityMax);
                                int duemin = Convert.ToInt32(due.VadilityMin);
                                fmbInfo.MinDuedate = fmbInfo.ThoiGian.Value.AddHours(duemin);
                                fmbInfo.MaxDuedate = fmbInfo.ThoiGian.Value.AddHours(duemax);
                                fmb.SaveChanges();
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            else
                            {
                                lbError.Text = "Chưa có thông tin hạn của mã cao su " + fmbInfo.MaNguyenLieu;
                                lbInformation.Text = string.Empty;
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                        }
                        else if (check == null && last != null)
                        {
                            var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                            fmbInfo.InputTime = DateTime.Now;
                            fmbInfo.PicInput = lbName.Text;
                            fmbInfo.FmbLine = last.FmbLine;
                            fmbInfo.FmbNo = 1;
                            fmbInfo.Place = "FMB Stock";
                            fmbInfo.Labkind = "Normal";
                            lbInformation.Text = "Mã xe: " + fmbInfo.MaCode + " được thêm vào hàng " + fmbInfo.FmbLine + "\nKết quả test: " + fmbInfo.Kq + "\nNgười thêm: " + _message;
                            if (due != null && fmbInfo.ThoiGian != null)
                            {
                                int duemax = Convert.ToInt32(due.VadilityMax);
                                int duemin = Convert.ToInt32(due.VadilityMin);
                                fmbInfo.MinDuedate = fmbInfo.ThoiGian.Value.AddHours(duemin);
                                fmbInfo.MaxDuedate = fmbInfo.ThoiGian.Value.AddHours(duemax);
                                fmb.SaveChanges();
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            else
                            {
                                lbError.Text = "Chưa có thông tin hạn của mã cao su. Vui lòng liên hệ IT " + fmbInfo.MaNguyenLieu;
                                lbInformation.Text = string.Empty;
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            lbError.Text = "";
                            lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp";
                        }
                        else
                        {
                            lbError.Text = "Mã cao su chưa có trong kho";
                            lbInformation.Text = string.Empty;
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                        }
                    }
                }
            }
            else if (fmbInfo == null && labInfo != null)
            {
                PFmbLabResult insert = new PFmbLabResult()
                {
                    MaCode = txtID.Text,
                    MaNguyenLieu = labInfo.MaNguyenLieu,
                    NgayCan = labInfo.NgayCan,
                    ThoiGian = labInfo.ThoiGian,
                    IdspthongSo = labInfo.IdspthongSo,
                    IdNl = labInfo.IdNl,
                    Lotruber = labInfo.Lotruber,
                    Idca = labInfo.Idca,
                    Cmb = labInfo.Cmb,
                    Fmb = labInfo.Fmb,
                    Reometer = labInfo.Reometer,
                    Tenlsi = labInfo.Tenlsi,
                    TenlsiBelong = labInfo.TenlsiBelong,
                    TenlsiUts = labInfo.TenlsiUts,
                    Moisture = labInfo.Moisture,
                    GravityCmb = labInfo.GravityCmb,
                    KhoiLuong = labInfo.KhoiLuong,
                    Kq = labInfo.Kq,
                    ByPass = labInfo.ByPass,
                    Huy = labInfo.Huy,
                };
                if (insert.Kq == "NG" || listArnormal.Visible == true && listArnormal.SelectedItems != null)
                {
                    insert.Labkind = "NG lab";
                    if (listArnormal.Visible == true && listArnormal.SelectedItems != null)
                    {
                        insert.Labkind=listArnormal.Text;
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == insert.MaNguyenLieu);
                        if (due != null && insert.ThoiGian != null)
                        {
                            int duemax = Convert.ToInt32(due.VadilityMax);
                            int duemin = Convert.ToInt32(due.VadilityMin);
                            insert.MinDuedate = insert.ThoiGian.Value.AddHours(duemin);
                            insert.MaxDuedate = insert.ThoiGian.Value.AddHours(duemax);
                            fmb.SaveChanges();
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                        }
                        else
                        {
                            lbError.Text = "Chưa có thông tin hạn của mã cao su " + insert.MaNguyenLieu;
                            lbInformation.Text = string.Empty;
                            lbSP.Text = "Vui lòng báo với IT";
                        }
                    }
                    var countno = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Count(c => c.Labkind == insert.Labkind);
                    if (countno >= 5)
                    {
                        lbError.Text = "Kho đã đầy không thể nhập";
                        lbInformation.Text = "";
                    }
                    else
                    {
                        fmb.PFmbLabResults.Add(insert);
                        var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbNo).FirstOrDefault(c => c.Labkind == insert.Labkind);
                        if (check != null)
                        {
                            insert.FmbNo = check.FmbNo + 1;
                        }
                        else
                        {
                            insert.FmbNo = 1;
                        }
                        var line = fmb.PFmbMasterLocationRubbers.SingleOrDefault(c => c.RubberName == insert.Labkind);
                        if (line != null)
                        {
                            insert.FmbLine = line.FmbLine;
                            insert.InputTime = DateTime.Now;
                            insert.PicInput = lbName.Text;
                            insert.Place = "FMB Stock";
                            lbInformation.Text = "Mã xe: " + insert.MaCode + " được thêm vào hàng " + insert.FmbLine + "\nKết quả test: " + insert.Kq + "\nNgười thêm: " + _message;
                            lbError.Text = "";
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            fmb.SaveChanges();
                        }
                    }
                }
                else
                {
                    var count = fmb.PFmbMasterLocationRubbers.Count(c => c.RubberName == insert.MaNguyenLieu);
                    var countno = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == "Normal").Count(c => c.MaNguyenLieu == insert.MaNguyenLieu);
                    if (count != 0 && countno != 0 && countno >= count * 5)
                    {
                        lbError.Text = "Kho đã đầy không thể nhập";
                        lbInformation.Text = "";
                    }
                    else if (insert != null)
                    {
                        fmb.PFmbLabResults.Add(insert);
                        var check = fmb.PFmbLabResults.Where(c => c.Labkind == "Normal").Where(c => c.Place == "FMB Stock").OrderBy(c => c.FmbLine).ThenByDescending(c => c.FmbNo).FirstOrDefault(c => c.MaNguyenLieu == insert.MaNguyenLieu);
                        var last = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == insert.MaNguyenLieu);
                        if (check != null && last != null)
                        {
                            var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == insert.MaNguyenLieu);
                            insert.InputTime = DateTime.Now;
                            insert.PicInput = lbName.Text;
                            if (check.FmbNo == 5)
                            {
                                insert.FmbLine = check.FmbLine - 1;
                                insert.FmbNo = 1;
                            }
                            else
                            {
                                insert.FmbLine = check.FmbLine;
                                insert.FmbNo = check.FmbNo + 1;
                            }
                            insert.Place = "FMB Stock";
                            insert.Labkind = "Normal";
                            lbInformation.Text = "Mã xe: " + insert.MaCode + " được thêm vào hàng " + insert.FmbLine + "\nKết quả test: " + insert.Kq + "\nNgười thêm: " + _message;
                            lbError.Text = "";
                            if (due != null && insert.ThoiGian != null)
                            {
                                int duemax = Convert.ToInt32(due.VadilityMax);
                                int duemin = Convert.ToInt32(due.VadilityMin);
                                insert.MinDuedate = insert.ThoiGian.Value.AddHours(duemin);
                                insert.MaxDuedate = insert.ThoiGian.Value.AddHours(duemax);
                                fmb.SaveChanges();
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            else
                            {
                                lbError.Text = "Chưa có thông tin hạn của mã cao su " + insert.MaNguyenLieu;
                                lbInformation.Text = string.Empty;
                                lbSP.Text = "Vui lòng báo với IT";
                            }
                        }
                        else if (check == null && last != null)
                        {
                            var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == insert.MaNguyenLieu);
                            insert.InputTime = DateTime.Now;
                            insert.PicInput = lbName.Text;
                            insert.FmbLine = last.FmbLine;
                            insert.FmbNo = 1;
                            insert.Place = "FMB Stock";
                            insert.Labkind = "Normal";
                            lbInformation.Text = "Mã xe: " + insert.MaCode + " được thêm vào hàng " + insert.FmbLine + "\nNgười thêm: " + _message;
                            if (due != null && insert.ThoiGian != null)
                            {
                                int duemax = Convert.ToInt32(due.VadilityMax);
                                int duemin = Convert.ToInt32(due.VadilityMin);
                                insert.MinDuedate = insert.ThoiGian.Value.AddHours(duemin);
                                insert.MaxDuedate = insert.ThoiGian.Value.AddHours(duemax);
                                fmb.SaveChanges();
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            else
                            {
                                lbError.Text = "Chưa có thông tin hạn của mã cao su. Vui lòng liên hệ IT " + insert.MaNguyenLieu;
                                lbInformation.Text = string.Empty;
                                lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                            }
                            lbError.Text = "";
                            lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp";
                        }
                        else
                        {
                            lbError.Text = "Mã cao su '" + labInfo.MaNguyenLieu + "' không tồn tại trong hệ thống. Vui lòng liên hệ IT";
                            lbInformation.Text = string.Empty;
                            lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                        }
                    }
                }
            }
            else if (labInfo == null)
            {
                lbError.Text = "Mã code không tồn tại";
                lbInformation.Text = string.Empty;
                lbSP.Text = "Quét mã QR của xe";
            }
            txtID.Text = string.Empty;
            txtID.Focus();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMain load = new frmMain();
            load.Refresh();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }

        private void frmAdd_Load(object sender, EventArgs e)
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
            open.ShowDialog();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 10)
            {
                lbSP.Text = "Enter";
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (btnZoom.Text == "Khác")
            {
                btnZoom.Text = "Đóng";
                lbZoom.Visible = true;
                listArnormal.Visible = true;
                listArnormal.Enabled = true;
            }
            else
            {
                btnZoom.Text = "Khác";
                lbZoom.Visible = false;
                listArnormal.Visible = false;
                listArnormal.Enabled = false;
                listArnormal.SelectedItems.Clear();
            }
        }
    }
}
