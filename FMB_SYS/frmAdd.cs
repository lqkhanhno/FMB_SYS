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
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtID.Text.Substring(0, 4);
            if(input == "PFMB")
            {
                timer1.Enabled = false;
                var update = fmb.PFmbLabels.SingleOrDefault(
                    c => c.CartId == txtID.Text);
                if (update != null
                    && update.Place == null
                    )
                {
                    var first = (from p in fmb.PFmbLabels
                                 join m in fmb.PFmbMasterLocationRubbers on p.RubberName equals m.RubberName
                                 where p.CartId == txtID.Text
                                 select m).FirstOrDefault();
                    if (first != null)
                    {
                        try
                        {
                            var up = fmb.PFmbLabels.Where(c => c.RubberName == update.RubberName).ToList();
                            foreach (var item in up)
                            {
                                item.FmbNo++;
                                if (item.FmbNo > 6)
                                {
                                    item.FmbNo = 1;
                                    item.FmbLine = item.FmbLine + 1;
                                }
                                fmb.SaveChanges();
                            }
                            update.PicInput = _message;
                            update.FmbLine = first.FmbLine;
                            update.FmbNo = 1;
                            update.Place = "FMB Stock";
                            fmb.SaveChanges();
                            lbInformation.Text = "Xe " + update.CartId + " được thêm vào hàng " + update.FmbLine + "\nNgười thêm: " + _message;
                            lbError.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                    }
                }
                else if (update != null && update.Place == "FMB Stock")
                {
                    lbError.Text = "Xe " + update.CartId + " đã ở trong kho\nHàng " + update.FmbLine + " vị trí " + update.FmbNo;
                    lbInformation.Text = "";

                }
                else if (update != null && update.Place == "PD")
                {
                    lbError.Text = "Chọn sai chức năng\nXe " + update.CartId + " hiện tại đang ở PD\nCần báo hết cho xe!";
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
            else
            {
                lbError.Text = "Hãy quét mã xe trước!";
                lbInformation.Text = string.Empty;
            }
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
