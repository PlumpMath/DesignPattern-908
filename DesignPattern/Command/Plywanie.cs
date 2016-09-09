using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Plywanie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Plywanie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijPlywac();
        }

        public void cofnij()
        {
            zawodnik.przestanPlywac();
        }
    }
}
