using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{//adds interest rate
    class SavingsAccount : Account
    {
        private decimal interestRate;
        //recieves balance and interestRate
        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }
        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                {
                    interestRate = value;//set rate here
                }
                else
                {
                    throw new Exception("InterestRate Must be greater than zero");

                }
            }
        }

        //CalculateInterest determens the interest rate for the savings account
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
