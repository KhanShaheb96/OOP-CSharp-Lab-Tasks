using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class Multiplier
    {
        private int number; 

        public Multiplier(int number)
        {
            this.number = number;
        }

        public int Multiply(int numberToMultiply)
        {
            int result = numberToMultiply * this.number;
            this.number = result; 
            return result;
        }
    }
}
