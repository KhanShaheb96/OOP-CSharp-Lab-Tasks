using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            code = classCode;
            seats = numberOfSeats;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }
    }
}
