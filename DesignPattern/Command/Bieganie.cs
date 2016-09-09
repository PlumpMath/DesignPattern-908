using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Bieganie : Polecenie
    {
        private Zawodnik zawodnik;  //obiekt wykonujacy
        public Bieganie(Zawodnik zawodnik)
        {
            this.zawodnik = zawodnik;
        }

        public void wykonaj()
        {
            zawodnik.zacznijBiegac();
        }

        public void cofnij()
        {
            zawodnik.przestanBiegac();
        }
    }
}
