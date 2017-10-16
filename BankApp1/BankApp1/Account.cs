using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp1
{
    class Account
    {
        //private decimal for balance
        private decimal balance;
        //constructor
        public Account(Decimal balance)
        {
            Balance = balance;
        }

        // show balance
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("Balance cannot be Less than zero");
                }
            }
        }

        //methdod to add to balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
            {
                balance = +amount;
            }
            else
            {
                throw new Exception("Amount must be greater than zero");
            }
        }
        //withdraw money from a/c
        public virtual bool Debit(decimal amount)
        {
            bool ok = true;
            if (balance - amount >= 0)
            {
                balance -= amount;
                ok = true;
            }
            else
            {
                ok = false;
                throw new Exception("Amount must be greater than zero");
                
            }
            return ok;
        }

    }
}
