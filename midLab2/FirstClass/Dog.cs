using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Dog
    {
        private string name;
        private string breed;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
