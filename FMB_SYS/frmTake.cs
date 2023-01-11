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
    public partial class frmTake : Form
    {
        public frmTake()
        {
            InitializeComponent();
        }
        HVN_SYSContext fmb = new HVN_SYSContext();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var update = fmb.PFmbLabels.SingleOrDefault(c => c.CartId == txtID.Text);
            if (update != null && update.Place == "FMB Stock")
            {
                var check = fmb.PFmbLabels.Where(c => c.Place == "FMB Stock").OrderByDescending(c => c.FmbLine).ThenByDescending(c => c.FmbNo)
                        .FirstOrDefault(c => c.RubberName == update.RubberName);
                if (check == update)
                {
                    try
                    {
                        if (update != null)
                        {
                            lbInformation.Text = "Xe được lấy đi ở hàng " + update.FmbLine + " vị trí " + update.FmbNo + "\nMã xe: " + update.CartId;
                            update.FmbLine = null;
                            update.FmbNo = null;
                            update.Place = "PD";
                            fmb.SaveChanges();
                            lbError.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else if (check != update && check != null)
                {
                    lbError.Text = "Xe " + update.CartId + " không ở vị trí cuối cùng\nXe ở cuối cùng hiện tại ở hàng " + check.FmbLine + " vị trí " + check.FmbNo + "\nMã xe: " + check.CartId;
                    lbInformation.Text = "";
                }
            }
            else if (update != null && update.Place != "FMB Stock")
            {
                lbError.Text = "Xe " + update.CartId + " đã được lấy ra khỏi kho";
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
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInformation.Text = string.Empty;
            lbError.Text = string.Empty;
            timer1.Enabled = false;
        }
    }
}
