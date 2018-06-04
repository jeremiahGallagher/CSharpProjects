using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GallagherWeek4
{
    class Account
    {
        //private members
        private decimal balance;
        
        //constructor
        public Account(decimal balance)
        {
            this.Balance = balance;
        }
        //Getter and Setter for balance 
        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("The Balance cannot be negative");
                }
            }
        }

        //Credit
        public virtual void Credit(decimal creditAmount)
        {
            if (creditAmount > 0)
            {
                Balance += creditAmount;
            }
            else
            {
                throw new Exception("You can only credit positive amounts to your account");
            }

        }
        

        //Debit
        public virtual bool Debit (decimal debitAmount)
        {
            bool goodBalance = true;
            if (Balance - debitAmount >= 0)
            {
                Balance -= debitAmount;
                goodBalance = true;
            }
            else
            {
                Console.WriteLine("test");
                goodBalance = false;
            }
            return goodBalance;
        }





    }
}
