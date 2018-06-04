using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GallagherWeek4
{
    class SavingsAccount : Account 
    {
        //private members
        private decimal interestRate;

        //Constructor
        public SavingsAccount (decimal balance, decimal interestRate) : base(balance)
        {
            this.InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value > 0)
                {
                    interestRate = value;
                }
                else
                {
                    throw new Exception("Interest Rate must be greater than zero.");
                }
            }
        }

        //Calculate Interest
        public decimal CalcInterestRate()
        {
            return Balance * InterestRate;
        }
    }
}
