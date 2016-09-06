using AbstractFactory.Dyski;
using AbstractFactory.Grafiki;
using AbstractFactory.Pamiec;
using AbstractFactory.Procesory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Czesci
{
    public class FabrykaPodzespolowPC : IFabrykaPodzespolowKomputerowych
    {
        public IChlodzenie produkujemyChlodzenie()
        {
            return null;
        }

        public IDysk produkujemyDysk()
        {
            return new DyskDlaPC();
        }

        public IGrafika produkujemyGrafike()
        {
            return new GrafikaDlaPC();
        }

        public IProcesor produkujemyProcesor()
        {
            return new ProcesorDlaPC();
        }

        public IRam produkujemyRam()
        {
            return new DDR3();
        }
    }
}
