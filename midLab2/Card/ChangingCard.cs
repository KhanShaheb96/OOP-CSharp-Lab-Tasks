using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class ChangingCard
    {
        public PaymentCard Card { get; private set; }

        public ChangingCard(PaymentCard card)
        {
            Card = card;
        }

        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                Card.balance += amount;
                if (Card.balance > 150)
                {
                    Card.balance = 150;
                }
            }
            else
            {
                Console.WriteLine("NOTICE! You cannot add negative money!");
            }
        }
    }
}
