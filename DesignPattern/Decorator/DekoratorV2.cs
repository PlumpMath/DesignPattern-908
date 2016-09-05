using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DekoratorV2 : Samochod
    {
        Samochod car;
        PakietDodatkowy pakietDodatkowy;
        public DekoratorV2(Samochod c, PakietDodatkowy pd)
        {
            car = c;
            pakietDodatkowy = pd;
        }

        public override string About()
        {
            return car.About() + " + " + pakietDodatkowy.Nazwa;
        }
        public override double Cena()
        {
            return car.Cena() + pakietDodatkowy.Cena;
        }
    }
}
