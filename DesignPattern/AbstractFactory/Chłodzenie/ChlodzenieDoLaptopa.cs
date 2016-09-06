using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Chłodzenie
{
    class ChlodzenieDoLaptopa : IChlodzenie
    {
        String name = "ChlodzenieDlaLaptopa";
        public IChlodzenie dawajChlodzenie()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ChlodzenieDoLaptopa();
        }
    }
}
