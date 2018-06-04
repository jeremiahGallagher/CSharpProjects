using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GallagherWeek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // create variables to hold and calculate total money amounts.
        private const double TaxRate = 0.0775;
        private const double BurgerPrice = 6.95;
        private const double PizzaPrice = 5.95;
        private const double SaladPrice = 4.95;
        private const double BurgerAddonPrice = .75;
        private const double PizzaAddonPrice = .50;
        private const double SaladAddonPrice = .25;
        double subTotal = 0;
        double taxAmount = 0;
        double grandTotal = 0;
        double addOns = 0;
        
        // This function resets the checkboxes, doubles and text boxes to defaults
        private void clearTotals()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            subTotal = 0;
            addOns = 0;
            grandTotal = 0;
            txtSubTotal.Text = " ";
            txtTax.Text = " ";
            txtTotal.Text = " ";

        }

        
        //When selecting a radio button, calls clearTotoals() and sets appropriate
        // text fields within the checkbox area.
        private void btnSalad_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
            addOnBox.Text = "Add-ons ($0.25 / each)";
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon Bits";
            checkBox3.Text = "Bread sticks";
            
        }

        private void btnBurger_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
            addOnBox.Text = "Add-ons ($0.75 / each)";
            checkBox1.Text = "Lettuce, Tomato, Onion";
            checkBox2.Text = "Ketchup, Mustard, Mayo";
            checkBox3.Text = "French Fries";
            

        }

        private void btnPizza_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals();
            addOnBox.Text = "Add-ons ($0.50 / each)";
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
            
        }

        private void mainCourseBox_Enter(object sender, EventArgs e)
        {
           
               
          
                
            
        }
        //Exits application on clicking Exit button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void addOnBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
        // The selected Radio-Button determines the initial values
        // of subTotal and Addons.
            if (btnBurger.Checked)
            {
                subTotal = BurgerPrice;
                addOns = BurgerAddonPrice;
            }

            else if (btnPizza.Checked)
            {
                subTotal = PizzaPrice;
                addOns = PizzaAddonPrice;
            }

            else
            {
                subTotal = SaladPrice;
                addOns = SaladAddonPrice;
            }
        // Each selected check-box will add the value(price) of Addons to subTotal.
            if (checkBox1.Checked)
            {
                subTotal += addOns;
            }

            if (checkBox2.Checked)
            {
                subTotal += addOns;
            }
            if (checkBox3.Checked)
            {
                subTotal += addOns;
            }

            taxAmount = subTotal * TaxRate;
            grandTotal = subTotal + taxAmount;
            // Displays subTotal, Tax and Total in Currency Format
            txtSubTotal.Text = subTotal.ToString("c");
            txtTax.Text =  (subTotal * TaxRate).ToString("c");
            txtTotal.Text = ((subTotal * TaxRate).ToString("c") + subTotal);
            txtTotal.Text = grandTotal.ToString("c");
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
