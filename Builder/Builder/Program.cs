using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director szef = new Director();
            Builder builder = new ZestawXT001();
            Builder builder2 = new ZestawABC996();

            Console.WriteLine("\nZESTAW1");
            szef.Builder =builder;
            szef.Skladaj();
            ZestawKomputerowy zestaw1 = szef.Zestaw;


            szef.Builder = builder2;
            szef.Skladaj();
            ZestawKomputerowy zestaw2 = szef.Zestaw;


            zestaw1.show();
            Console.WriteLine("\n\nZESTAW2");
            zestaw2.show();

            String s = Console.ReadLine();
        }
    }
}
