using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Plytka ob1 = new KPlytka(Tlok.dvd, "TDK", new Nagrywanie());
            Plytka ob2 = new KPlytka(Tlok.cd, "Dysan", new Odczytywanie());
            ob1.akcja();
            Console.WriteLine(ob1.Get() + "\n");
            ob2.akcja();
            Console.WriteLine(ob2.Get() + "\n");
            ob1.Set("Verbatim", Tlok.bd);
            ob1.akcja();
            Console.WriteLine(ob1.Get() + "\n");
            Console.ReadKey(true);
        }
    }
}
