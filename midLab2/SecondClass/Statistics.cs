using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class Statistics
    {
        public int count { get; private set; }
        public int sum { get; private set; }

        public Statistics()
        {
            count = 0;
            sum = 0;
        }

        public void AddNumber(int number)
        {
            count++;
            sum += number;
        }
    }
}
