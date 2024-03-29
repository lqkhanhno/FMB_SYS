﻿using FMB_SYS.Models1;
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
using FMB_SYS.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.VisualBasic;

namespace FMB_SYS
{
    public partial class frmCheckstock : Form
    {
        public frmCheckstock()
        {
            InitializeComponent();
        }

        HVN_SYSContext fmb = new HVN_SYSContext();
        private void frmCheckstock_Load(object sender, EventArgs e)
        {
            frmCheckstock_load();
        }
        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void frmCheckstock_load()
        {
            if (_message == "khanh")
            {
                txtlistreason.SelectedItems.Clear();
                txtlistreason.Visible = false;
                btnRemove.Visible = true;
            }
            this.Size = new System.Drawing.Size(1920, 1080);
            this.StartPosition = FormStartPosition.CenterScreen;
            List<Label> labelline = new List<Label>
            {
                lbline1, lbline2, lbline3, lbline4, lbline5, lbline6, lbline7, lbline8, lbline9, lbline10,
                lbline11, lbline12, lbline13, lbline14, lbline15, lbline16, lbline17, lbline18, lbline19, lbline20
            };
            for (int i = 0; i < 20; i++)
            {
                var line = fmb.PFmbMasterLocationRubbers.SingleOrDefault(c => c.FmbLine == i + 1);
                if (line != null)
                {
                    labelline[i].Text = (i + 1) + ". " + line.RubberName;
                }
            }
            List<Button> buttons = new List<Button>
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25,
                button26, button27, button28, button29, button30,
                button31, button32, button33, button34, button35,
                button36, button37, button38, button39, button40,
                button41, button42, button43, button44, button45,
                button46, button47, button48, button49, button50,
                button51, button52, button53, button54, button55,
                button56, button57, button58, button59, button60,
                button61, button62, button63, button64, button65,
                button66, button67, button68, button69, button70,
                button71, button72, button73, button74, button75,
                button76, button77, button78, button79, button80,
                button81, button82, button83, button84, button85,
                button86, button87, button88, button89, button90,
                button91, button92, button93, button94, button95,
                button96, button97, button98, button99, button100,
            };
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    buttons[(i - 1) * 5 + j - 1].BackColor = Color.White;
                    var check = fmb.PFmbLabResults.SingleOrDefault(c => c.FmbLine == i && c.FmbNo == j);
                    buttons[(i - 1) * 5 + j - 1].TabIndex = (i - 1) * 5 + j - 1;
                    if (check != null && check.ThoiGian != null && check.MaxDuedate != null && check.Lotruber != null)
                    {
                        buttons[(i - 1) * 5 + j - 1].Text = check.MaNguyenLieu + "|" + check.KhoiLuong + "kg\n" + check.Kq + "\n" + check.Lotruber.Value.ToString("dd/MM") + "|" + check.Idca + "\nHạn còn: " + (int)(check.MaxDuedate - DateTime.Now).Value.TotalHours + "h";
                        if (check.MaxDuedate > DateTime.Now && check.MinDuedate < DateTime.Now && check.Kq == "OK")
                        {
                            buttons[(i - 1) * 5 + j - 1].BackColor = Color.LightGreen;
                        }
                        else if (check.MinDuedate > DateTime.Now && check.ThoiGian <= DateTime.Now)
                        {
                            buttons[(i - 1) * 5 + j - 1].BackColor = Color.White;
                        }
                        else if (check.Kq == "OK special")
                        {
                            buttons[(i - 1) * 5 + j - 1].BackColor = Color.Orange;
                        }
                        else
                        {
                            buttons[(i - 1) * 5 + j - 1].BackColor = Color.Red;
                        }
                        var due = fmb.PFmbMasterListRubbers.SingleOrDefault(c => c.RubberName == check.MaNguyenLieu);
                        if (due != null)
                        {
                            if ((int)(check.MaxDuedate - DateTime.Now).Value.TotalHours < due.VadilityMax * 0.7)
                            {
                                buttons[(i - 1) * 5 + j - 1].BackColor = Color.Yellow;
                            }
                            if ((int)(check.MaxDuedate - DateTime.Now).Value.TotalHours < 0)
                            {
                                buttons[(i - 1) * 5 + j - 1].BackColor = Color.Red;
                            }
                        }
                    }
                    else if (check != null && check.Lotruber != null)
                    {
                        buttons[(i - 1) * 5 + j - 1].Text = check.MaNguyenLieu + "|" + check.KhoiLuong + "kg\n" + check.Kq + "\n" + check.Lotruber.Value.ToString("dd/MM") + "|" + check.Idca;
                        buttons[(i - 1) * 5 + j - 1].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[(i - 1) * 5 + j - 1].Text = "Trống";
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sum = fmb.PFmbLabResults.Where(c => c.MaNguyenLieu.Contains(listBox1.Text)).Where(c => c.Place == "FMB Stock").Where(c => c.Labkind == "Normal" || c.Labkind == "Bổ sung").Sum(c => c.KhoiLuong);
            textBox1.Text = sum.ToString();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Refresh();
            this.Close();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtlistreason.Visible == true)
            {
                if (txtlistreason.SelectedItems.Count != 0)
                {
                    try
                    {
                        Button btn = (Button)sender;
                        var check = fmb.PFmbLabResults.SingleOrDefault(c => c.FmbLine == btn.TabIndex / 5 + 1 && c.FmbNo == btn.TabIndex % 5 + 1);
                        if (check != null && check.NgayCan != null && check.Lotruber != null && check.Lotruber != null && check.MaxDuedate == null)
                        {
                            DialogResult result = MessageBox.Show("Mã xe: " + check.MaCode + "\nMã cao su: " + check.MaNguyenLieu + "\nNgày cán: " + check.NgayCan.Value.ToString("dd/MM/yyyy") + "\nCa: " + check.Idca + "\nKhối lượng: " + check.KhoiLuong + "kg\nKết quả test lab: " + check.Kq + "\nLotruber: " + check.Lotruber.Value.ToString("dd/MM/yyyy") + "\nThời gian nhập kho: " + check.InputTime + "\nNgười nhập kho: " + check.PicInput
                                + "\n_________________________________________\n      Bạn có muốn hủy xe này?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == check.FmbLine).Where(c => c.FmbNo > check.FmbNo).ToList();
                                var check1 = fmb.PFmbMasterLocationRubbers.OrderBy(c => c.FmbLine).FirstOrDefault(c => c.RubberName == check.MaNguyenLieu);
                                var check2 = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == check.MaNguyenLieu);
                                foreach (var item in up)
                                {
                                    item.FmbNo--;
                                }
                                if (check1 != check2 && check1 != null && check2 != null)
                                {
                                    if (check.FmbLine == check2.FmbLine)
                                    {
                                        var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == check1.FmbLine).ToList();
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
                                check.RemoveTime = DateTime.Now;
                                check.RemoveReason = txtlistreason.Text;
                                check.FmbLine = null;
                                check.FmbNo = null;
                                check.Place = null;
                                check.PicRemove = _message;
                                fmb.SaveChanges();
                                MessageBox.Show("Xe có mã: " + check.MaCode + " đã được hủy thành công\nNgười hủy: " + _message + "\nLý do hủy: " + check.RemoveReason);
                                txtlistreason.SelectedItems.Clear();
                                txtlistreason.Visible = false;
                                btnRemove.Visible = true;
                                frmCheckstock_load();
                            }
                        }
                        else if (check != null && check.MaxDuedate != null && check.NgayCan != null && check.Lotruber != null)
                        {
                            DialogResult result = MessageBox.Show("Mã xe: " + check.MaCode + "\nMã cao su: " + check.MaNguyenLieu + "\nNgày cán: " + check.NgayCan.Value.ToString("dd/MM/yyyy") + "\nCa: " + check.Idca + "\nKhối lượng: " + check.KhoiLuong + "kg\nKết quả test lab: " + check.Kq + "\nLotruber: " + check.Lotruber.Value.ToString("dd/MM/yyyy") + "\nHạn còn: " + (int)(check.MaxDuedate - DateTime.Now).Value.TotalHours + " giờ" + "\nThời gian nhập kho: " + check.InputTime + "\nNgười nhập kho: " + check.PicInput
                                + "\n_________________________________________\n      Bạn có muốn hủy xe này?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                var up = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == check.FmbLine).Where(c => c.FmbNo > check.FmbNo).ToList();
                                var check1 = fmb.PFmbMasterLocationRubbers.OrderBy(c => c.FmbLine).FirstOrDefault(c => c.RubberName == check.MaNguyenLieu);
                                var check2 = fmb.PFmbMasterLocationRubbers.OrderByDescending(c => c.FmbLine).FirstOrDefault(c => c.RubberName == check.MaNguyenLieu);
                                foreach (var item in up)
                                {
                                    item.FmbNo--;
                                }
                                if (check1 != check2 && check1 != null && check2 != null)
                                {
                                    if (check.FmbLine == check2.FmbLine)
                                    {
                                        var down = fmb.PFmbLabResults.Where(c => c.Place == "FMB Stock").Where(c => c.FmbLine == check1.FmbLine).ToList();
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
                                check.RemoveTime = DateTime.Now;
                                check.RemoveReason = txtlistreason.Text;
                                check.FmbLine = null;
                                check.FmbNo = null;
                                check.Place = null;
                                check.PicRemove = _message;
                                fmb.SaveChanges();
                                MessageBox.Show("Xe có mã: " + check.MaCode + " đã được hủy thành công\nNgười hủy: " + _message + "\nLý do hủy: " + check.RemoveReason);
                                txtlistreason.SelectedItems.Clear();
                                frmCheckstock_load();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        frmCheckstock_load();
                    }
                }
                else
                {
                    try
                    {
                        Button btn = (Button)sender; 
                        MessageBox.Show("Bạn cần phải chọn lý do trước khi hủy!");
                    }
                    catch (Exception)
                    {
                        frmCheckstock_load();
                    }
                }
            }
            else
            {
                try
                {
                    Button btn = (Button)sender;
                    var check = fmb.PFmbLabResults.SingleOrDefault(c => c.FmbLine == btn.TabIndex / 5 + 1 && c.FmbNo == btn.TabIndex % 5 + 1);
                    if (check != null && check.NgayCan != null && check.Lotruber != null && check.Lotruber != null && check.MaxDuedate == null)
                    {
                        MessageBox.Show("Mã xe: " + check.MaCode + "\nMã cao su: " + check.MaNguyenLieu + "\nNgày cán: " + check.NgayCan.Value.ToString("dd/MM/yyyy") + "\nCa: " + check.Idca + "\nKhối lượng: " + check.KhoiLuong + "kg\nKết quả test lab: " + check.Kq + "\nLotruber: " + check.Lotruber.Value.ToString("dd/MM/yyyy") + "\nThời gian nhập kho: " + check.InputTime + "\nNgười nhập kho: " + check.PicInput, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (check != null && check.MaxDuedate != null && check.NgayCan != null && check.Lotruber != null)
                    {
                        MessageBox.Show("Mã xe: " + check.MaCode + "\nMã cao su: " + check.MaNguyenLieu + "\nNgày cán: " + check.NgayCan.Value.ToString("dd/MM/yyyy") + "\nCa: " + check.Idca + "\nKhối lượng: " + check.KhoiLuong + "kg\nKết quả test lab: " + check.Kq + "\nLotruber: " + check.Lotruber.Value.ToString("dd/MM/yyyy") + "\nHạn còn: " + (int)(check.MaxDuedate - DateTime.Now).Value.TotalHours + " giờ" + "\nThời gian nhập kho: " + check.InputTime + "\nNgười nhập kho: " + check.PicInput, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    frmCheckstock_load();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.Visible = false;
            txtlistreason.Visible = true;
        }
    }
}