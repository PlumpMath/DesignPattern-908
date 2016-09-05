using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Klimatyzacja : Dekorator
    {
        Samochod car;

        public Klimatyzacja(Samochod samochod)
        {
            car = samochod;
        }

        public override String About()
        {
            return car.About() + " + klimatyzacja";
        }

        public override double Cena()
        {
            if (car is Mercedes)
            {
                return car.Cena() + 100000;
            }
            else if (car is Fiat)
            {
                return car.Cena() + 20000;
            }
            return 0;
        }
    }
}
