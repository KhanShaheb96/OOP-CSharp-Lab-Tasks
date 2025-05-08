using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Withdrawal(20);

            Console.WriteLine("\nThe balance of Heikki's account is now: " + heikkisAccount.GetBalance().ToString("C"));

            heikkisSwissAccount.Deposit(200);

            Console.WriteLine("\nThe balance of Heikki's other account is now: " + heikkisSwissAccount.GetBalance().ToString("C"));

            Console.WriteLine("\nEnd state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Deposit(920);

            Account personalAccount = new Account("Personal account", 0.0);

            heikkisAccount.Withdrawal(100.0);

            personalAccount.Deposit(100.0);

            Console.WriteLine();
            Console.WriteLine(heikkisAccount.ToString());
            Console.WriteLine(personalAccount.ToString());

            Console.ReadLine();
        }
    }
}
