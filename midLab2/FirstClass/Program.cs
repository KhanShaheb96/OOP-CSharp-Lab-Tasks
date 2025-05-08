using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Dog Class-----");
            
            Dog dog = new Dog();
            dog.Name = "Tommy";
            dog.Breed = "German Shepherd";
            dog.Age = 5;
            
            Console.WriteLine($"Name: {dog.Name}");
            Console.WriteLine($"Breed: {dog.Breed}");
            Console.WriteLine($"Age: {dog.Age}");

            Console.WriteLine("\n-----Room Class-----");
            
            Room room = new Room("DS0502", 40);

            Console.WriteLine($"Code: {room.Code}");
            Console.WriteLine($"Seats: {room.Seats}");

            Console.WriteLine("\n-----Whistle Class-----");

            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");

            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();

            Console.WriteLine("\n-----Product Class-----");

            Product banana = new Product("Banana", 1.1, 13);
            banana.PrintProduct();

            Console.ReadLine();
        }
    }
}
