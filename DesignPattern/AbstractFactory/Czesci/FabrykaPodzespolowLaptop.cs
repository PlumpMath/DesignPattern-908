using AbstractFactory.Chłodzenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Dyski;
using AbstractFactory.Grafiki;
using AbstractFactory.Pamiec;
using AbstractFactory.Procesory;

namespace AbstractFactory.Czesci
{
    public class FabrykaPodzespolowLaptop : IFabrykaPodzespolowKomputerowych
    {
        public IChlodzenie produkujemyChlodzenie()
        {
            return new ChlodzenieDoLaptopa();
        }

        public IDysk produkujemyDysk()
        {
            return new DyskDlaLaptopa();
        }

        public IGrafika produkujemyGrafike()
        {
            return new GrafikaDlaLaptopa();
        }

        public IProcesor produkujemyProcesor()
        {
            return new ProcesorDlaLaptopa();
        }

        public IRam produkujemyRam()
        {
            return new DDR2();
        }
    }
}
