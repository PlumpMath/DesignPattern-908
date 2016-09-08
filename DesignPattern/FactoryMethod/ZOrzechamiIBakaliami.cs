using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ZOrzechamiIBakaliami : Czekolada
    {
        public ZOrzechamiIBakaliami()
        {
            about = "Z orzechami i bakaliami";
        }

        public void dodajeOrzechy()
        {
            Console.WriteLine("Dodaje orzechy...");
        }

        public void dodajeBakalie()
        {
            Console.WriteLine("Dodaje bakalie...");
        }

        public void dodajeCukier()
        {
            Console.WriteLine("Dodaje cukier...");
        }

        public override Czekolada dawajCzekolade()
        {
            Console.WriteLine(about);
            dodajeKakao();
            dodajeCukier();
            dodajeOrzechy();
            dodajeBakalie();
            return this;
        }
    }
}
