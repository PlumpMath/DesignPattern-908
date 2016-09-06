using AbstractFactory;
using AbstractFactory.Czesci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Komputery
{
    public class KomputerPC : Komputer
    {
        FabrykaPodzespolowPC fabrykaPodzespolowKomputerowych;

        public KomputerPC(FabrykaPodzespolowPC f)
        {
            fabrykaPodzespolowKomputerowych = f;
            skladanie();
        }

        public override void skladanie()
        {
            dysk = fabrykaPodzespolowKomputerowych.produkujemyDysk().dawajDysk();
            grafika = fabrykaPodzespolowKomputerowych.produkujemyGrafike().dawajGrafike();
            procesor = fabrykaPodzespolowKomputerowych.produkujemyProcesor().dawajProcesor();
            ram = fabrykaPodzespolowKomputerowych.produkujemyRam().dawajRam();
        }
    }
}
