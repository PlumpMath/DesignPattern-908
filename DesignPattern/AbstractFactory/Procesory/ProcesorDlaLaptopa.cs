using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Procesory
{
    class ProcesorDlaLaptopa : IProcesor
    {
        String name = "ProcesorDlaLaptopa";
        public IProcesor dawajProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaLaptopa();
        }
    }
}
