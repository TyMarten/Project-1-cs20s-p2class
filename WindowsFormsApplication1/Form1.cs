using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNoHelp_Click(object sender, EventArgs e)
        {
            lblK.Visible = true;
            lblK.Text = "K.";
            lblAnswer.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            lblAnswer.Visible = true;
            lblAnswer.Text = "Ouch that hurt me right in the PEELS";
            lblK.Visible = false;
        }

        private void lblHelpTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
