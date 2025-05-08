using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(100);
            UsingCard usingCard = new UsingCard(card);
            CheckingBalance checker = new CheckingBalance(usingCard);
            ChangingCard changingCard = new ChangingCard(card);

            Console.WriteLine(usingCard.Card);

            checker.BuyItem(10.60);
            Console.WriteLine(usingCard.Card);

            checker.BuyItem(2.0);
            Console.WriteLine(usingCard.Card);

            changingCard.AddMoney(49.99);
            Console.WriteLine(changingCard.Card);

            changingCard.AddMoney(10000.0);
            Console.WriteLine(changingCard.Card);

            changingCard.AddMoney(-10);
            Console.WriteLine(changingCard.Card);

            Console.ReadLine();
        }
    }
}
