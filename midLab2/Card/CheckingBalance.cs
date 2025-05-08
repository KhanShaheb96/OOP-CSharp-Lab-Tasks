using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class CheckingBalance
    {
        private UsingCard usingCard;

        public CheckingBalance(UsingCard card)
        {
            usingCard = card;
        }

        public bool CanPurchase(double amount)
        {
            return usingCard.Card.balance >= amount;
        }

        public void BuyItem(double amount)
        {
            if (CanPurchase(amount))
            {
                usingCard.DecreaseBalance(amount);
            }
        }
    }
}
