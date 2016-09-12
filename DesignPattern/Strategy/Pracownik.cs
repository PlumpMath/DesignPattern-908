using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Pracownik
    {
        private Pracowac pracowac = null;
        private Dojezdzac dojezdzac = null;
        private SpedzanieWolnegoCzasu spedzanieWolnegoCzasu = null;

        public Pracownik(String zawod)
        {
            if ((zawod.ToUpper()).Equals("MECHANIK"))
            {
                pracowac = new NaprawaSamochodow();
                dojezdzac = new Samochod();
                spedzanieWolnegoCzasu = new Silownia();
            }
            else if ((zawod.ToUpper()).Equals("LEKARZ"))
            {
                pracowac = new Leczenie();
                dojezdzac = new Samochod();
                spedzanieWolnegoCzasu = new LiteraturaPopularnoNaukowa();
            }
            else if ((zawod.ToUpper()).Equals("LISTONOSZ"))
            {
                pracowac = new RoznoszenieListow();
                dojezdzac = new Rower();
                spedzanieWolnegoCzasu = new Silownia();
            }

        }


        //tutaj wywolujemy algorytmy
        public void methods()
        {
            pracowac.pracuj();
            dojezdzac.dojezdzaj();
            spedzanieWolnegoCzasu.spedzajWolnyCzas();
        }
    }
}
