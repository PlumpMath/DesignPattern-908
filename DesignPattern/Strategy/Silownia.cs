using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Silownia : SpedzanieWolnegoCzasu
    {
        public void spedzajWolnyCzas()
        {
            Console.WriteLine("Wolny Czas: silownia");
        }
    }
}
