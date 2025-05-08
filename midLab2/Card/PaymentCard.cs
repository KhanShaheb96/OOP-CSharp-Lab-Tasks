using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class PaymentCard
    {
        public double balance;

        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }

        public override string ToString()
        {
            return "The card has a balance of " + balance + " euros";
        }
    }
}
