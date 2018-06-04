using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GallagherWeek4
{
    class CheckingAccount : Account
    {
        //private members
        private decimal transactionFee;

        //constructor inherits balance from base class Account
        public CheckingAccount(decimal balance, decimal tFee) : base(balance)
        {

        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                if (value > 0)
                {
                    transactionFee = value;
                }
                else
                {
                    throw new Exception("Fee cannot be less than Zero");
                }
            }


        }
        //CheckingAccount Overrrides Credit, subtracts the transaction fee
        public override void Credit(decimal creditAmount)
        {
            base.Credit(creditAmount);
            Balance -= TransactionFee;
        }
        //CheckingAccount Overrides Debit, subtracting the transaction fee
        public override bool Debit(decimal debitAmount)
        {
            if (base.Debit(debitAmount))
            {
                Balance -= TransactionFee;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
