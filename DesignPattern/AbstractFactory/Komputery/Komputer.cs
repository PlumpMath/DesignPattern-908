using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Komputer
    {
        protected IDysk dysk;
        protected IGrafika grafika;
        protected IRam ram;
        protected IProcesor procesor;
        protected IChlodzenie chlodzenie;

        public abstract void skladanie();

        public void instalowanieOprogramowania()
        {
            Console.WriteLine("Instaluje oprogramowanie...");
        }

        public void pakowanie()
        {
            Console.WriteLine("Pakuje sprzet...");
        }
        public void sprzedawanie()
        {
            Console.WriteLine("Sprzedaje sprzet...");
        }
    }
}
