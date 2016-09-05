using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OponyZimowe : Dekorator
    {
        Samochod car;

        public OponyZimowe(Samochod samochod)
        {
            car = samochod;
        }

        public override String About()
        {
            return car.About() + " + opony zimowe";
        }

        /* niech ceny beda takie same */
        public override double Cena()
        {
            return car.Cena() + 31234;
        }
    }
}
