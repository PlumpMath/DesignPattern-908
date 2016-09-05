using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Fiat : Samochod
    {

        public Fiat()
        {
            samochod = "Fiat";
        }

        public override double Cena()
        {
            return 100000;
        }
    }
}
