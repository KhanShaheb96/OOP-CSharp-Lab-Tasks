using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInAList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Main Class-----");

            List<Item> items = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                Item item = new Item(name);
                items.Add(item);
            }

            Console.WriteLine("Items:");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n-----Personal Infromation Main-----");

            List<PersonalInformation> personalInfoList = new List<PersonalInformation>();

            while (true)
            {
                Console.Write("First name:\n> ");
                string firstName = Console.ReadLine();

                if (string.IsNullOrEmpty(firstName))
                    break;

                Console.Write("Last name:\n> ");
                string lastName = Console.ReadLine();

                Console.Write("Identification number:\n> ");
                string identificationNumber = Console.ReadLine();

                PersonalInformation personalInfo = new PersonalInformation(firstName, lastName, identificationNumber);
                personalInfoList.Add(personalInfo);
            }

            Console.WriteLine();

            foreach (PersonalInformation info in personalInfoList)
            {
                Console.WriteLine(info.FirstName + " " + info.LastName);
            }

            Console.WriteLine("\n-----Television Guide-----");

            List<TelevisionProgram> programs = new List<TelevisionProgram>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                Console.Write("Duration: ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                {
                    TelevisionProgram program = new TelevisionProgram(name, duration);
                    programs.Add(program);
                }
                else
                {
                    Console.WriteLine("Invalid input. Duration must be an integer.");
                }
            }

            Console.Write("Program's maximum duration? ");
            if (int.TryParse(Console.ReadLine(), out int maxDuration))
            {
                Console.WriteLine("Matching programs:");

                foreach (TelevisionProgram program in programs)
                {
                    if (program.Duration <= maxDuration)
                    {
                        Console.WriteLine($"{program.Name}, {program.Duration} minutes");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Maximum duration must be an integer.");
            }

            Console.WriteLine("\n-----Book Class-----");

            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();

                if (string.IsNullOrEmpty(title))
                    break;

                Console.Write("Pages: ");
                if (int.TryParse(Console.ReadLine(), out int pages))
                {
                    Console.Write("Publication year: ");
                    if (int.TryParse(Console.ReadLine(), out int publicationYear))
                    {
                        Book book = new Book(title, pages, publicationYear);
                        books.Add(book);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Publication year must be an integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Pages must be an integer.");
                }
            }

            Console.Write("What information will be printed? ");
            string printOption = Console.ReadLine();

            if (printOption == "everything")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.Title}, {book.Pages} pages, {book.PublicationYear}");
                }
            }
            else if (printOption == "title")
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Title);
                }
            }

            Console.ReadLine();
        }
    }
}
