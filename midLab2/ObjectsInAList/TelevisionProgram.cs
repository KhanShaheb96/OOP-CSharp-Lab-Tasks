using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInAList
{
    internal class TelevisionProgram
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public TelevisionProgram(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}
