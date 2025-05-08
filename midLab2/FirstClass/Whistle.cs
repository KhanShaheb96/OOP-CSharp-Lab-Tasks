using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Whistle
    {
        private string sound;

        public Whistle(string whistleSound)
        {
            sound = whistleSound;
        }

        public void Sound()
        {
            Console.WriteLine(sound);
        }
    }
}
