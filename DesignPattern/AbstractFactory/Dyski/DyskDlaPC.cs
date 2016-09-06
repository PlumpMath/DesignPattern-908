using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Dyski
{
    public class DyskDlaPC : IDysk
    {
        String name = "DyskDlaPC";
        public IDysk dawajDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaPC();
        }
    }
}
