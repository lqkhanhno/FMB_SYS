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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            timer1.Enabled = false;
            var update = fmb.PFmbLabResults.SingleOrDefault(c => c.MaCode == txtID.Text);
            if (update != null && update.Labkind != "Normal")
            {
                txtWeight.Text = "";
                lbError.Text = "Không thể trả xe về";
                lbInformation.Text = string.Empty;
                lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                txtID.Text = string.Empty;
                txtID.Focus();
            }
            else if (update != null)
            {
                var check = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenBy(c => c.FmbNo)
            .FirstOrDefault(c => c.MaNguyenLieu == update.MaNguyenLieu);
                var first = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == update.MaNguyenLieu);
                if (check != null && update.Place == "PD" && first != null)
                {
                    if (txtWeight.Text == "")
                    {
                        txtWeight.Focus();
                        lbInformation.Text = "Nhập khối lượng còn lại của xe " + update.MaCode;
                        lbError.Text = string.Empty;
                    }
                    else if (int.Parse(txtWeight.Text) <= 0)
                    {
                        lbError.Text = "Khối lượng không hợp lệ";
                        lbInformation.Text = string.Empty;
                        txtWeight.Text = string.Empty;
                        txtWeight.Focus();
                        lbSP.Text = "Nhập lại khối lượng cho cao su";
                    }
                    else
                    {
                        if (update.KhoiLuong >= int.Parse(txtWeight.Text))
                        {
                            var count = fmb.PFmbMasterLocationRubbers.Count(c => c.RubberName == update.MaNguyenLieu);
                            var countno = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Count(c => c.MaNguyenLieu == update.MaNguyenLieu);
                            if (countno >= count * 5)
                            {
                                lbError.Text = "Kho đã đầy không thể nhập";
                                lbInformation.Text = "";
                            }
                            else
                            {
                                update.PicReturn = _message;
                                update.KhoiLuong = int.Parse(txtWeight.Text);
                                update.Place = "FMB Stock";
                                var down = fmb.PFmbLabResults.Where(c => c.MaNguyenLieu == update.MaNguyenLieu).ToList();
                                foreach (var item in down)
                                {
                                    item.FmbNo++;
                                    if (item.FmbNo > 5)
                                    {
                                        item.FmbNo = 1;
                                        item.FmbLine = item.FmbLine - 1;
                                    }
                                }
                                update.FmbLine = first.FmbLine;
                                update.FmbNo = 1;
                                update.ReturnTime = DateTime.Now;
                                int save = fmb.SaveChanges();
                                if (save > 0)
                                {
                                    lbInformation.Text = ("Xe " + update.MaCode + " đã được trả về hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nXe còn lại " + txtWeight.Text + ". Người trả xe: " + _message);
                                }
                                txtWeight.Text = "";
                                lbError.Text = "";
                                lbSP.Text = "Thoát hoặc quét mã QR của xe tiếp theo";
                                txtID.Text = string.Empty;
                                txtID.Focus();
                            }
                        }
                        else
                        {
                            lbError.Text = ("Xe trả về có khối lượng lớn hơn xe lấy đi");
                            lbInformation.Text = "";
                            txtWeight.Text = string.Empty;
                            txtID.Text = string.Empty;
                            txtID.Focus();
                            lbSP.Text = "Thoát hoặc quét mã QR của xe";
                        }
                    }
                }
                else if (update.Place == "FMB Stock")
                {
                    lbError.Text = ("Chọn sai chức năng\nXe " + update.MaCode + " đang ở trong kho\nHàng " + update.FmbLine + " vị trí " + update.FmbNo);
                    lbInformation.Text = "";
                    txtID.Text = string.Empty;
                    txtID.Focus();
                    txtWeight.Text = string.Empty;
                }
                else if (update.Place == null)
                {
                    lbError.Text = ("Chọn sai chức năng\nXe " + update.MaCode + " chưa nhập kho");
                    lbInformation.Text = "";
                    txtID.Text = string.Empty;
                    txtWeight.Text = string.Empty;
                    txtID.Focus();
                }
                else if (check == null && first != null)
                {
                    if (txtWeight.Text == "")
                    {
                        txtWeight.Focus();
                        lbInformation.Text = "Nhập khối lượng còn lại của xe " + update.MaCode;
                    }
                    else if (int.Parse(txtWeight.Text) <= 0)
                    {
                        lbError.Text = "Khối lượng không hợp lệ";
                        lbInformation.Text = string.Empty;
                        txtWeight.Text = string.Empty;
                        txtWeight.Focus();
                        lbSP.Text = "Nhập lại khối lượng cho cao su";
                    }
                    else
                    {
                        if (update.KhoiLuong >= int.Parse(txtWeight.Text))
                        {
                            update.ReturnTime = DateTime.Now;
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
                            txtID.Text = string.Empty;
                            txtID.Focus();
                        }
                        else
                        {
                            lbError.Text = ("Xe trả về có khối lượng lớn hơn xe lấy đi");
                            lbInformation.Text = "";
                            txtWeight.Text = string.Empty;
                            txtID.Text = string.Empty;
                            txtID.Focus();
                        }
                    }
                }
                else
                {
                    lbError.Text = "Xe trả về không còn có dữ liệu trong kho. Vui lòng liên hệ IT";
                    lbInformation.Text = "";
                    txtID.Text = string.Empty;
                    txtID.Focus();
                    lbSP.Text = "Thoát hoặc quét mã QR tiếp";
                }
            }
            else
            {
                txtID.Text = string.Empty;
                txtWeight.Text = string.Empty;
                txtID.Text = string.Empty;
                txtID.Focus();
            }
            timer1.Enabled = true;
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
