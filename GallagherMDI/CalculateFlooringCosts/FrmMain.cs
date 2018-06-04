using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFlooringCosts
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmCarpeting = new frmCarpeting();
            frmCarpeting.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmHardwood = new frmHardwood();
            frmHardwood.Show();
        }
    }
}
