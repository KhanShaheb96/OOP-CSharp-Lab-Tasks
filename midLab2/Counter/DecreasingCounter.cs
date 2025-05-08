using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class DecreasingCounter
    {
        private int value;

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            if (this.value > 0)
            {
                this.value--;
            }
        }

        public void Reset()
        {
            this.value = 0;
        }
    }
}
