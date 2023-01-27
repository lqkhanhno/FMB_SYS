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
                else if (update != null && update.Place == "FMB Stock")
                {
                    if (txtlistreason.Text == string.Empty)
                    {
                        lbInformation.Text = string.Empty;
                        lbSP.Text = "Cần nhập lý do hủy";
                        lbError.Text = "Chưa nhập lý do hủy";
                    }
                    else {
                        var up = fmb.PFmbLabResults.Where(c => c.FmbLine == update.FmbLine).Where(c => c.FmbNo < update.FmbNo).ToList();
                        var check = fmb.PFmbMasterLocationRubbers.OrderBy(c => c.FmbLine).FirstOrDefault(c => c.RubberName == update.MaNguyenLieu);
                        var check1 = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == update.MaNguyenLieu);
                        foreach (var item in up)
                        {
                            item.FmbNo++;
                        }
                        if (check != check1 && check != null && check1 != null)
                        {
                            if (update.FmbLine == check1.FmbLine)
                            {
                                var down = fmb.PFmbLabResults.Where(c => c.FmbLine == check.FmbLine).ToList();
                                foreach (var item in down)
                                {
                                    item.FmbNo++;
                                    if (item.FmbNo > 5)
                                    {
                                        item.FmbNo = 1;
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
                        lbInformation.Text = "Xe có mã: " + update.MaCode + "đã được hủy thành công";
                        lbError.Text = string.Empty;
                        lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                        txtID.Focus();
                    }
                }
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
