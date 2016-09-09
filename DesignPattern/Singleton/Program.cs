using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            MenedzerPlikow[] tab = new MenedzerPlikow[3];
            tab[0] = MenedzerPlikow.dawajMenedzer();
            tab[1] = MenedzerPlikow.dawajMenedzer();
            tab[2] = MenedzerPlikow.dawajMenedzer();

            for (int i = 0; i < 3; i++)
                tab[i].about();
            Console.ReadLine();
        }
    }
}
