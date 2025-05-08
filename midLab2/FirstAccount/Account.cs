using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAccount
{
    internal class Account
    {
        private string accountName;
        private double balance;

        public Account(string name, double initialBalance)
        {
            accountName = name;
            balance = initialBalance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdrawal(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"{accountName}: {balance:C}";
        }
    }
}
