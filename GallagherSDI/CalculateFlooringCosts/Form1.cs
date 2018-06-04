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
    public partial class frmFlooringCalc : Form
    {
        public frmFlooringCalc()
        {
            InitializeComponent();
        }

        private void frmFlooringCalc_Load(object sender, EventArgs e)
        {

        }

        private void newHardwoodCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHardwood();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void newHardwoodCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newCarpetingCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newCarpetingCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCarpeting();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
                activeForm.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
