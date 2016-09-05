using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Mercedes();
            Samochod s2 = new Fiat();

            Console.WriteLine("\nBez wyposazenia");
            Console.WriteLine(string.Format("{0} {1}", s1.About(), s1.Cena()));
            Console.WriteLine(string.Format("{0} {1}", s2.About(), s2.Cena()));

            //dodajemy po klimie

            s1 = new Klimatyzacja(s1);
            s2 = new Klimatyzacja(s2);
            Console.WriteLine("\nZ Klima");
            Console.WriteLine(string.Format("{0} {1}", s1.About(), s1.Cena()));
            Console.WriteLine(string.Format("{0} {1}", s2.About(), s2.Cena()));

            // i opony

            s1 = new OponyZimowe(s1);
            s2 = new OponyZimowe(s2);
            Console.WriteLine("\nZ oponami");
            Console.WriteLine(string.Format("{0} {1}", s1.About(), s1.Cena()));
            Console.WriteLine(string.Format("{0} {1}", s2.About(), s2.Cena()));

            //odrazu tworzymy wyposazony samochod
            Console.WriteLine("\nPelne wyposazenie");
            Samochod s3 = new OponyZimowe(new Klimatyzacja(new Mercedes()));
            Console.WriteLine(string.Format("{0} {1}", s3.About(), s3.Cena()));

            Console.WriteLine("\nUniwersalny Dekorator");
            Samochod s4 = new DekoratorV2(s3, new PakietDodatkowy("podgrzewane siedzenie", 1000));
            Console.WriteLine(string.Format("{0} {1}", s4.About(), s4.Cena()));
            Console.ReadLine();
        }
    }
}
