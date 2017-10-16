using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    class CheckingAccount: Account//inherits from account
    {
        private decimal fee;
        //constructor
        public CheckingAccount(decimal balance, decimal fee):base (balance)//inherits balance from account class
        {
        
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value >0)
                {
                    fee = value;
                }
                else
                {
                    throw new Exception("fee cannot be less than zero");
                }
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }
    }
}
