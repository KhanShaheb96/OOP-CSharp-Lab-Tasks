using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInAList
{
    internal class PersonalInformation
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string IdentificationNumber { get; }

        public PersonalInformation(string firstName, string lastName, string identificationNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdentificationNumber = identificationNumber;
        }
    }
}
