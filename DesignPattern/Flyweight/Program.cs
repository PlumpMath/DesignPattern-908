using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Posilek posilek = new Pizza();
            posilek = new Sos(posilek);
            Console.WriteLine(posilek.dawajNazwe());
            posilek = new Ser(posilek);
            Console.WriteLine(posilek.dawajNazwe());
            Console.ReadLine();
        }
    }
}
