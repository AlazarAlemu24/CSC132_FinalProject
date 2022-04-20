using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC132_FinalProject
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            //Actual Name is lblNumberNeededCredits
            
        }

        private void sevenSemestersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Not actually seven. It is actually six. Naming error
            txtSM1.Enabled = true;
            txtJT1.Enabled = true;
            txtSM2.Enabled = true;
            txtSummer1.Enabled = true;
            txtSM3.Enabled = true;
            txtJT2.Enabled = true;
            txtSM4.Enabled = true;
            txtSummer2.Enabled = true;
            txtSM5.Enabled = true;
            txtJT3.Enabled = true;
            txtSM6.Enabled = true;
        }

        private void sevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSM1.Enabled = true;
            txtJT1.Enabled = true;
            txtSM2.Enabled = true;
            txtSummer1.Enabled = true;
            txtSM3.Enabled = true;
            txtJT2.Enabled = true;
            txtSM4.Enabled = true;
            txtSummer2.Enabled = true;
            txtSM5.Enabled = true;
            txtJT3.Enabled = true;
            txtSM6.Enabled = true;
            txtSummer3.Enabled = true;
            txtSM7.Enabled = true;
        }

        private void eightSemestersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSM1.Enabled = true;
            txtJT1.Enabled = true;
            txtSM2.Enabled = true;
            txtSummer1.Enabled = true;
            txtSM3.Enabled = true;
            txtJT2.Enabled = true;
            txtSM4.Enabled = true;
            txtSummer2.Enabled = true;
            txtSM5.Enabled = true;
            txtJT3.Enabled = true;
            txtSM6.Enabled = true;
            txtSummer3.Enabled = true;
            txtSM7.Enabled = true;
            txtJT4.Enabled = true;
            txtSM8.Enabled = true;
        }

        private void nineSemestersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSM1.Enabled = true;
            txtJT1.Enabled = true;
            txtSM2.Enabled = true;
            txtSummer1.Enabled = true;
            txtSM3.Enabled = true;
            txtJT2.Enabled = true;
            txtSM4.Enabled = true;
            txtSummer2.Enabled = true;
            txtSM5.Enabled = true;
            txtJT3.Enabled = true;
            txtSM6.Enabled = true;
            txtSummer3.Enabled = true;
            txtSM7.Enabled = true;
            txtJT4.Enabled = true;
            txtSM8.Enabled = true;
            txtSummer4.Enabled = true;
            txtSM9.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage BackToIntro = new HomePage();
            BackToIntro.Show();
        }
    }
}
