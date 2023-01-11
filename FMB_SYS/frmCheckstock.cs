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
    public partial class frmCheckstock : Form
    {
        public frmCheckstock()
        {
            InitializeComponent();
        }
        HVN_SYSContext fmb = new HVN_SYSContext();
        private void frmCheckstock_Load(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25,
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
            for (int i = 1; i <= 16; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    var check = fmb.PFmbLabels.SingleOrDefault(c => c.FmbLine == i && c.FmbNo == j);
                    if (check != null && check.InputTime != null)
                    {
                        buttons[(i - 1) * 5 + j - 1].Text = check.RubberName + "\n" + check.RubberWeight + "kg\n" + check.InputTime.Value.ToShortDateString();
                        buttons[(i - 1) * 5 + j - 1].BackColor = Color.LightGreen;
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
            var sum = (from c in fmb.PFmbLabels
                       where c.RubberName == listBox1.Text
                       select c.RubberWeight).Sum();
            textBox1.Text = sum.ToString();
        }
    }
}
