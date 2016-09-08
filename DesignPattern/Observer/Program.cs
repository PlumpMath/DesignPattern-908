using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TotoLotek totoLotek = new TotoLotek();
            Telewizja telewizja = new Telewizja(totoLotek);
            Internet internet = new Internet(totoLotek);

            totoLotek.dodajObserwatora(telewizja);
            totoLotek.dodajObserwatora(internet);

            totoLotek.kolejneLosowanie();
            Console.WriteLine("LOSOWANIE 1\n");
            telewizja.informuj();
            internet.informuj();

            totoLotek.kolejneLosowanie();
            Console.WriteLine("\nLOSOWANIE 2\n");
            telewizja.informuj();
            internet.informuj();

            /* telewizja juz nie obserwuuje wynikow, nie bedzie miec aktualnych losowan */
            telewizja.spadam();
            totoLotek.kolejneLosowanie();
            Console.WriteLine("\nLOSOWANIE 3\n");
            telewizja.informuj();
            internet.informuj();
            String s = Console.ReadLine();
        }
    }
}
