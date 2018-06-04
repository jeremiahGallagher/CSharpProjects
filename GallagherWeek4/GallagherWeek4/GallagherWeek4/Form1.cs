using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GallagherWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            pnlNewAcct.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (radBtnChecking.Checked)
            {
                listBox1.Items.Add("Checking");
                radBtnChecking.Enabled = false;
                /* NewCheckingForm f = new NewCheckingForm();
                 f.ShowDialog();*/

            }
            if (radBtnSavings.Checked)
            {
                listBox1.Items.Add("Savings");
                radBtnSavings.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if( )
        }
    }
}
