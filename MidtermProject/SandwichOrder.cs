using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class SandwichOrder
    {
        public SandwichOrder(int sandWichnumero, string naMez, double price, string meAtz, string toPPys, int caLo)
        {
            numero = sandWichnumero;
            nombre = naMez;
            cuanto = price;
            carne = meAtz;
            toppingz = toPPys;
            calorias = caLo;
        }

        public int numero { get; set; }
        public string nombre { get; set; }
        public double cuanto { get; set; }
        public string carne { get; set; }
        public string toppingz { get; set; }
        public int calorias { get; set; }
    }
}
