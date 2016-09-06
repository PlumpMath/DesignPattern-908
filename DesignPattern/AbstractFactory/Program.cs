using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabrykaKomputerow fabrykaKomputerow = new FabrykaKomputerow();
            Console.WriteLine("PC");
            Komputer pc = fabrykaKomputerow.wydajKomputer("PC");
            Console.WriteLine("\n\nLaptop");
            Komputer laptop = fabrykaKomputerow.wydajKomputer("Laptop");
            Console.ReadLine();
        }
    }
}
