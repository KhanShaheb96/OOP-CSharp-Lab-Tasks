using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Section 01-----");
            DecreasingCounter counter = new DecreasingCounter(10);
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();
            counter.PrintValue();

            Console.WriteLine("\n-----Section 02-----");
            DecreasingCounter counter2 = new DecreasingCounter(2);
            counter2.PrintValue();
            counter2.Decrement();
            counter2.Decrement();
            counter2.PrintValue();
            counter2.Decrement();
            counter2.PrintValue();

            Console.WriteLine("\n-----Section 03-----");
            DecreasingCounter counter3 = new DecreasingCounter(20);
            counter3.PrintValue();
            counter3.Reset();
            counter3.PrintValue();

            Console.ReadLine();
        }
    }
}