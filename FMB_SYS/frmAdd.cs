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
            try
            {
                var labInfo = lab.Barcodes.SingleOrDefault(c => c.MaCode == txtID.Text);
                var fmbInfo = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
                if (fmbInfo != null && fmbInfo.Place == "PD")
                {
                    lbError.Text = "Chọn sai chức năng\nXe có mã: " + fmbInfo.MaCode + " hiện tại đang ở PD\nCần báo hết cho xe!";
                    lbInformation.Text = "";
                }
                else if (fmbInfo != null && fmbInfo.Place == "FMB Stock")
                {
                    lbError.Text = "Xe có mã: " + fmbInfo.MaCode + " đã ở trong kho\nHàng " + fmbInfo.FmbLine + " vị trí " + fmbInfo.FmbNo;
                    lbInformation.Text = "";
                }
                else if (fmbInfo != null && fmbInfo.Place == null && labInfo != null && labInfo.ThoiGian != null)
                {
                    var first = fmb.PFmbMasterLocationRubbers.FirstOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                    if (first != null)
                    {
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.MaNguyenLieu);
                        var up = fmb.PFmbLabResults.Where(c => c.MaNguyenLieu == fmbInfo.MaNguyenLieu).ToList();
                        foreach (var item in up)
                        {
                            item.FmbNo++;
                            if (item.FmbNo > 5)
                            {
                                item.FmbNo = 1;
                                item.FmbLine = item.FmbLine + 1;
                            }
                        }
                        fmbInfo.ThoiGian = DateTime.Now;
                        fmbInfo.NgayCan = labInfo.NgayCan;
                        fmbInfo.IdspthongSo = labInfo.IdspthongSo;
                        fmbInfo.IdNl = labInfo.IdNl;
                        fmbInfo.Lotruber = labInfo.Lotruber;
                        fmbInfo.Idca = labInfo.Idca;
                        fmbInfo.Cmb = labInfo.Cmb;
                        fmbInfo.Fmb = labInfo.Fmb;
                        fmbInfo.Reometer = labInfo.Reometer;
                        fmbInfo.Tenlsi = labInfo.Tenlsi;
                        fmbInfo.TenlsiBelong = labInfo.TenlsiBelong;
                        fmbInfo.TenlsiUts = labInfo.TenlsiUts;
                        fmbInfo.Moisture = labInfo.Moisture;
                        fmbInfo.GravityCmb = labInfo.GravityCmb;
                        fmbInfo.KhoiLuong = labInfo.KhoiLuong;
                        fmbInfo.Kq = labInfo.Kq;
                        fmbInfo.ByPass = labInfo.ByPass;
                        fmbInfo.Huy = labInfo.Huy;
                        fmbInfo.PicInput = lbName.Text;
                        fmbInfo.FmbLine = first.FmbLine;
                        fmbInfo.FmbNo = 1;
                        fmbInfo.Place = "FMB Stock";
                        fmb.SaveChanges();
                        lbInformation.Text = "Mã xe: " + fmbInfo.MaCode + " được thêm vào hàng " + fmbInfo.FmbLine + " Thời gian: " + fmbInfo.ThoiGian + "\nNgười thêm: " + _message;
                        lbError.Text = "";
                        if (due != null)
                        {
                            int duemax = Convert.ToInt32(due.VadilityMax);
                            int duemin = Convert.ToInt32(due.VadilityMin);
                            fmbInfo.MinDuedate = fmbInfo.ThoiGian.Value.AddHours(duemin);
                            fmbInfo.MaxDuedate = fmbInfo.ThoiGian.Value.AddHours(duemax);
                            fmb.SaveChanges();
                        }
                        else
                        {
                            lbError.Text = "Chưa có thông tin hạn của mã cao su " + fmbInfo.MaNguyenLieu;
                            lbInformation.Text = string.Empty;
                        }
                    }
                    else
                    {
                        lbError.Text = "Mã cao su chưa có trong kho";
                        lbInformation.Text = string.Empty;
                    }
                }
                else if (fmbInfo == null && labInfo != null && labInfo.ThoiGian != null)
                {
                    PFmbLabResult insert = new PFmbLabResult()
                    {
                        MaCode = txtID.Text,
                        MaNguyenLieu = labInfo.MaNguyenLieu,
                        NgayCan = labInfo.NgayCan,
                        ThoiGian = DateTime.Now,
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
                    fmb.PFmbLabResults.Add(insert);
                    var first = fmb.PFmbMasterLocationRubbers.FirstOrDefault(c => c.RubberName == labInfo.MaNguyenLieu);
                    if (first != null)
                    {
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == labInfo.MaNguyenLieu);
                        var up = fmb.PFmbLabResults.Where(c => c.MaNguyenLieu == labInfo.MaNguyenLieu).ToList();
                        foreach (var item in up)
                        {
                            item.FmbNo++;
                            if (item.FmbNo > 5)
                            {
                                item.FmbNo = 1;
                                item.FmbLine = item.FmbLine + 1;
                            }
                        }
                        insert.PicInput = lbName.Text;
                        insert.FmbLine = first.FmbLine;
                        insert.FmbNo = 1;
                        insert.Place = "FMB Stock";
                        fmb.SaveChanges();
                        lbInformation.Text = "Mã xe: " + insert.MaCode + " được thêm vào hàng " + insert.FmbLine + " Thời gian: " + insert.ThoiGian + "\nNgười thêm: " + _message;
                        lbError.Text = "";
                        if (due != null)
                        {
                            int duemax = Convert.ToInt32(due.VadilityMax);
                            int duemin = Convert.ToInt32(due.VadilityMin);
                            insert.MinDuedate = insert.ThoiGian.Value.AddHours(duemin);
                            insert.MaxDuedate = insert.ThoiGian.Value.AddHours(duemax);
                            fmb.SaveChanges();
                        }
                        else
                        {
                            lbError.Text = "Chưa có thông tin hạn của mã cao su " + insert.MaNguyenLieu;
                            lbInformation.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
                lbInformation.Text = string.Empty;
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

        private void frmAdd_Load(object sender, EventArgs e)
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
