using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Grafiki
{
    public class GrafikaDlaPC : IGrafika
    {
        String name = "GrafikaDlaPC";
        public IGrafika dawajGrafike()
        {
            Console.WriteLine("Dodaje: " + name);
            return new GrafikaDlaPC();
        }
    }
}
