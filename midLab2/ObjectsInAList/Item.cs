using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInAList
{
    internal class Item
    {
        public string Name { get; }
        public DateTime CreationTime { get; }

        public Item(string name)
        {
            Name = name;
            CreationTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name} (created at: {CreationTime})";
        }
    }
}
