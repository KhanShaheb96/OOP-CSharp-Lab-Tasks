using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class UsingCard
    {
        public PaymentCard Card { get; private set; }

        public UsingCard(PaymentCard card)
        {
            Card = card;
        }

        public void EatLunch()
        {
            DecreaseBalance(10.60);
        }

        public void DrinkCoffee()
        {
            DecreaseBalance(2.0);
        }

        public void DecreaseBalance(double amount)
        {
            if (Card.balance >= amount)
            {
                Card.balance -= amount;
            }
        }
    }
}
