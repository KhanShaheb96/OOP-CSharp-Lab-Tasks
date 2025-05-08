using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class Agent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Agent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return "My name is " + LastName + ". " + FirstName + " " + LastName + ".";
        }
    }
}
