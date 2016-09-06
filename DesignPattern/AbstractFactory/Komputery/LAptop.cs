using AbstractFactory.Czesci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Komputery
{
    class Laptop : Komputer
    {
        FabrykaPodzespolowLaptop fabrykaPodzespolowLaptop;

        public Laptop(FabrykaPodzespolowLaptop fabrykaPodzespolowLaptop)
        {
            this.fabrykaPodzespolowLaptop = fabrykaPodzespolowLaptop;
            skladanie();
        }

        public override void skladanie()
        {
            dysk = fabrykaPodzespolowLaptop.produkujemyDysk().dawajDysk();
            grafika = fabrykaPodzespolowLaptop.produkujemyGrafike().dawajGrafike();
            procesor = fabrykaPodzespolowLaptop.produkujemyProcesor().dawajProcesor();
            ram = fabrykaPodzespolowLaptop.produkujemyRam().dawajRam();
            chlodzenie = fabrykaPodzespolowLaptop.produkujemyChlodzenie().dawajChlodzenie();
        }
    }
}
