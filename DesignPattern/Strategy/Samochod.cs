using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Samochod : Dojezdzac
    {
        public void dojezdzaj()
        {
            Console.WriteLine("Dojazd: samochod");
        }
    }
}
