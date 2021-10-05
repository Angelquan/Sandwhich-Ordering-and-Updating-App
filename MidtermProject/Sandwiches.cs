using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MidtermProject
{
    class Sandwiches
    {
        public Sandwiches(int sandWichnum, string naMe, double cost, string meAt, string toPPings, int caLos)
        {
           number = sandWichnum;
           namo = naMe;
           costo = cost;
           meatType = meAt;
           toppins = toPPings;
            cals = caLos;
        }

        public int number {get; set;}
        public string namo {get; set;}
        public double costo { get; set; }
        public string meatType {get; set;}
        public string toppins {get; set;}
        public int cals {get; set;}

    }
}
