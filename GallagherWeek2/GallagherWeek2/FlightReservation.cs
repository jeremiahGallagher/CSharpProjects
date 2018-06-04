using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GallagherWeek2
{
    public partial class FlightReservation : Form
    {
        public FlightReservation()
        {
            InitializeComponent();
        }
        //Constant to hold max number of seats
        const int MaxSeats = 10;

        //Create and initialize array of bools for tracking the seats
        bool[] isAssignedSeat = new bool[MaxSeats];


        private void FlightReservation_Load(object sender, EventArgs e)
        {

        }
        /* When the button labeled First Class is clicked, the bool array isAssignedSeat indexes 
         * 0-4 are checked to see if they are false, if false, they are turned to true and then a 
         * messageBox is presented to inform the customer of their seat assignment.  This will 
         * assign the seats in order from least to greatest. For this reason, if the largest index
         * is already assigned true then the user will receive the Message that all First Class
         * Seats have been assigned */ 
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 4; i++)
            {
                int j = i + 1;
                if (!isAssignedSeat[i])
                {
                    isAssignedSeat[i] = true;
                    MessageBox.Show("You Have Been Assigned Seat # " +  j);
                    break;
                }
                if (isAssignedSeat[4])
                {
                    MessageBox.Show("All First Class Seats Are Taken. Please Select an Economy Class Seat.  If you do not Want economy or one is not available, The next Flight Will Depart in 3 Hours");
                    break;
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /* When the button labeled Economy is clicked, the bool array isAssignedSeat indexes 
         * 5-9 are checked to see if they are false, if false, they are turned to true and then a 
         * messageBox is presented to inform the customer of their seat assignment.  This will 
         * assign the seats in order from least to greatest. For this reason, if the largest index
         * is already assigned true then the user will receive the Message that all Economy
         * Seats have been assigned */
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 5; i <= 9; i++)
            {
                int j = i + 1;
                if (!isAssignedSeat[i])
                {
                    isAssignedSeat[i] = true;
                    MessageBox.Show("You Have Been Assigned Seat # " + j);
                    break;
                }
                if (isAssignedSeat[9])
                {
                    MessageBox.Show("All Economy Seats Are Taken. Please Select a First Class Seat.  If you do not Want First Class or one is not available, The next Flight Will Depart in 3 Hours");
                    break;
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
