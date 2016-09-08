using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ProducentCzekolady producent = new ProducentCzekolady();
            Czekolada[] tab = new Czekolada[3];

            tab[0] = producent.produkcjaCzekolady("Gorzka");
            Console.WriteLine("--------------------------------------------------------------");
            tab[1] = producent.produkcjaCzekolady("Z orzechami i bakaliami");
            Console.WriteLine("--------------------------------------------------------------");
            tab[2] = producent.produkcjaCzekolady("Mleczna");
            Console.ReadLine();
        }
    }
}
