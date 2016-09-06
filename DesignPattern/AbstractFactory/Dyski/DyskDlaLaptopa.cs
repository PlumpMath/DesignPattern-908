using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Dyski
{
    public class DyskDlaLaptopa : IDysk
    {
        String name = "DyskDlaLaptopa";
        public IDysk dawajDysk()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DyskDlaLaptopa();
        }
    }
}
