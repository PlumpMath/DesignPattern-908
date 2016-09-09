using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class MenedzerPlikow
    {
        private static MenedzerPlikow instancja = null;
        private int identyfikator;

        private MenedzerPlikow()
        {
            Random random = new Random();
            identyfikator = random.Next(10);
        }

        //-------------------------------------------------------------------------------------------#1 sposob
        public static MenedzerPlikow dawajMenedzer()
        {
            if (instancja == null)
            {
                instancja = new MenedzerPlikow();
                return instancja;
            }
            Console.WriteLine("Menedzer juz zostal wczesniej utworzony!");
            return instancja;
        }

        public void about()
        {
            Console.WriteLine("Identyfiaktor = " + identyfikator);
        }

        /*-------------------------------------------------------------------------------------------#2 sposob
        // nie inicjujemy tutan nullem, instancja juz od poczatku posiada wartosc

        private static readonly MenedzerPlikow instancja = new MenedzerPlikow();
        public static MenedzerPlikow dawajMenedzer(){
        return instancja;
        }
        */

    }
}
