using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class Debt
    {
        private double balance;
        private double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            balance = initialBalance;
            interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            balance *= interestRate;
        }
    }
}
