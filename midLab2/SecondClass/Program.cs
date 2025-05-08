using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Debt Class-----");
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();
            mortgage.WaitOneYear();
            mortgage.PrintBalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }
            mortgage.PrintBalance();

            Console.WriteLine("\n-----Dalmatian Class-----");
            Dalmatian spotty = new Dalmatian("Spot", 306);
            Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur.");

            Console.WriteLine("\n-----Gauge Class-----");
            Gauge g = new Gauge();
            while (!g.Full())
            {
                Console.WriteLine("Not full! Value: " + g.value);
                g.Increase();
            }
            Console.WriteLine("Full! Value: " + g.value);
            g.Decrease();
            Console.WriteLine("Not full! Value: " + g.value);

            Console.WriteLine("\n-----Agent Class-----");
            Agent bond = new Agent("James", "Bond");
            Console.WriteLine(bond);
            Agent bourne = new Agent("Jason", "Bourne");
            Console.WriteLine(bourne);

            Console.WriteLine("\n-----Multiplier Class-----");
            Multiplier multiplyByThree = new Multiplier(3);
            Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));
            Multiplier multiplyByFour = new Multiplier(4);
            Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
            Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));

            Console.WriteLine("\n-----Statistics Class-----");
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);

            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);

            Console.ReadLine();
        }
    }
}
