using FMB_SYS.Models1;
using FMB_SYS.Models2;
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
                var fmbInfo = fmb.PFmbLabels.SingleOrDefault(c => c.CartId == txtID.Text);
                if (fmbInfo != null && fmbInfo.Place == "PD")
                {
                    lbError.Text = "Chọn sai chức năng\nXe có mã: " + fmbInfo.CartId + " hiện tại đang ở PD\nCần báo hết cho xe!";
                    lbInformation.Text = "";
                }
                else if (fmbInfo != null && fmbInfo.Place == "FMB_Stock")
                {
                    lbError.Text = "Xe có mã: " + fmbInfo.CartId + " đã ở trong kho\nHàng " + fmbInfo.FmbLine + " vị trí " + fmbInfo.FmbNo;
                    lbInformation.Text = "";
                }
                else if (fmbInfo != null && fmbInfo.MixingDate != null && fmbInfo.Place == null)
                {
                    var first = fmb.PFmbMasterLocationRubbers.FirstOrDefault(c => c.RubberName == fmbInfo.RubberName);
                    if (first != null)
                    {
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == fmbInfo.RubberName);
                        var up = fmb.PFmbLabels.Where(c => c.RubberName == fmbInfo.RubberName).ToList();
                        foreach (var item in up)
                        {
                            item.FmbNo++;
                            if (item.FmbNo > 5)
                            {
                                item.FmbNo = 1;
                                item.FmbLine = item.FmbLine + 1;
                            }
                        }
                        fmbInfo.InputTime = DateTime.Now;
                        fmbInfo.PicInput = lbName.Text;
                        fmbInfo.FmbLine = first.FmbLine;
                        fmbInfo.FmbNo = 1;
                        fmbInfo.Place = "FMB Stock";
                        if (labInfo != null)
                        {
                            PFmbLabResult insertLab = new PFmbLabResult()
                            {
                                Id = labInfo.Id,
                                MaCode = labInfo.MaCode,
                                ThoiGian = labInfo.ThoiGian,
                                NgayCan = labInfo.NgayCan,
                                IdspthongSo = labInfo.IdspthongSo,
                                IdNl = labInfo.IdNl,
                                Lotruber = labInfo.Lotruber,
                                Idca = labInfo.Idca,
                                IdloaiSp = labInfo.IdloaiSp,
                                Cmb = labInfo.Cmb,
                                Fmb = labInfo.Fmb,
                                Reometer = labInfo.Reometer,
                                Tenlsi = labInfo.Tenlsi,
                                TenlsiUts = labInfo.TenlsiUts,
                                TenlsiBelong = labInfo.TenlsiBelong,
                                Moisture = labInfo.Moisture,
                                GravityCmb = labInfo.GravityCmb,
                                KhoiLuong = labInfo.KhoiLuong,
                                Kq = labInfo.Kq,
                                ByPass = labInfo.ByPass,
                                Huy = labInfo.Huy,
                                MaNguyenLieu = labInfo.MaNguyenLieu,
                                CardId = fmbInfo.CartId
                            };
                            try
                            {
                                fmb.PFmbLabResults.Add(insertLab);
                                fmb.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error");
                            }
                        }
                        lbInformation.Text = "Mã xe: " + fmbInfo.CartId + " được thêm vào hàng " + fmbInfo.FmbLine + " Thời gian: " + fmbInfo.InputTime + "\nNgười thêm: " + _message;
                        lbError.Text = "";
                        if (due != null)
                        {
                            int duemax = Convert.ToInt32(due.VadilityMax);
                            int duemin = Convert.ToInt32(due.VadilityMin);
                            fmbInfo.MinDuedate = fmbInfo.MixingDate.Value.AddHours(duemin);
                            fmbInfo.MaxDuedate = fmbInfo.MixingDate.Value.AddHours(duemax);
                            fmb.SaveChanges();
                        }
                        else
                        {
                            lbError.Text = "Chưa có thông tin hạn của mã cao su " + fmbInfo.RubberName;
                            lbInformation.Text = string.Empty;
                        }
                    }
                    else
                    {
                        lbError.Text = "Mã cao su chưa có trong kho";
                        lbInformation.Text = string.Empty;
                    }
                }
                else
                {
                    lbError.Text = "Mã xe không tồn tại";
                    lbInformation.Text = string.Empty;
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
