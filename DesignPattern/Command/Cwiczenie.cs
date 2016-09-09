using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Cwiczenie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Cwiczenie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijCwiczyc();
        }

        public void cofnij()
        {
            zawodnik.przestanCwiczyc();
        }
    }
}
