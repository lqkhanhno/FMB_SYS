using FMB_SYS.Models1;
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
        }
        HVN_SYSContext fmb = new HVN_SYSContext();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var update = fmb.PFmbLabels.SingleOrDefault(
                c => c.CartId == txtID.Text);
            if (update != null && update.Place != "FMB Stock")
            {
                try
                {
                    update.FmbLine = null;
                    update.FmbNo = null;
                    update.Place = null;
                    int save = fmb.SaveChanges();
                    if (save > 0)
                    {
                        lbInformation.Text = ("Xe " + update.CartId + " đã hết");
                        lbError.Text = "";
                    }
                    else
                    {
                        lbInformation.Text = ("Xe " + update.CartId + " đã được báo hết");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else if (update != null && update.Place == "FMB Stock")
            {
                lbError.Text = ("Xe đang ở trong kho!");
                DialogResult box = MessageBox.Show("Bạn có chắc chắn muốn bỏ?", "Thông báo", MessageBoxButtons.YesNo);
                if (box == DialogResult.Yes)
                {
                    var check = fmb.PFmbLabels.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                        .FirstOrDefault(c => c.RubberName == update.RubberName);
                    if (check != null && update != check)
                    {
                        lbError.Text = "Xe không ở vị trí cuối cùng!\nXe ở cuối cùng hiện tại ở hàng" + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe: " + check.CartId;
                        lbInformation.Text = "";
                    }
                    else
                    {
                        try
                        {
                            update.FmbLine = null;
                            update.FmbNo = null;
                            update.Place = null;
                            int save = fmb.SaveChanges();
                            if (save > 0)
                            {
                                lbInformation.Text = ("Xe " + update.CartId + " đã được bỏ");
                                lbError.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }
                }
            }
            else if (update == null)
            {
                lbError.Text = ("Mã xe không tồn tại!");
                lbInformation.Text = "";
            }
            else
            {
                lbError.Text = "";
                lbInformation.Text = "";
            }
            txtID.Text = string.Empty;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }
    }
}
