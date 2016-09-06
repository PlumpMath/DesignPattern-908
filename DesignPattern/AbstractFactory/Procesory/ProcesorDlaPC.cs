using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Procesory
{
    public class ProcesorDlaPC : IProcesor
    {
        String name = "ProcesorDlaPC";
        public IProcesor dawajProcesor()
        {
            Console.WriteLine("Dodaje: " + name);
            return new ProcesorDlaPC();
        }
    }
}
