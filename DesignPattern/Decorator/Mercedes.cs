using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mercedes : Samochod
    {

        public Mercedes()
        {
            samochod = "Mercedes";
        }

        public override double Cena()
        {
            return 500000;
        }
    }
}
