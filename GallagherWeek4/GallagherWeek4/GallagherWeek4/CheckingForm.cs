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
    public partial class NewCheckingForm : Form
    {
        public NewCheckingForm()
        {
            InitializeComponent();
        }

        public string myDepositInput= "";
        public decimal myDeposit = 0;
        public string myFeeInput = "";
        public decimal myFee = 0;

        private void clearValues()
        {
            myDepositInput = "";
            myDeposit = 0;
            myFeeInput = "";
            myFee = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckingForm_Load(object sender, EventArgs e)
        {

        }

        private void createChAcctBtn_Click(object sender, EventArgs e)

        {
            
            myDeposit = decimal.Parse(myDepositInput);
            myFee = decimal.Parse(myFeeInput);
            if (myDeposit > 0)
            {
                CheckingAccount checking = new CheckingAccount(myDeposit, myFee);
                MessageBox.Show("Account Created");
                
            }
           else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clearValues();
            myDepositInput = this.Text;
            //myDeposit = decimal.Parse(myDepositInput);
            createChAcctBtn.Enabled = true;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feeText_TextChanged(object sender, EventArgs e)
        {
            myFeeInput = this.Text;
            //myFee = decimal.Parse(myFeeInput);
        }
    }
}
