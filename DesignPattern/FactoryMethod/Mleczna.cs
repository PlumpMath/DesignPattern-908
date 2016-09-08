using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Mleczna : Czekolada
    {
        public Mleczna()
        {
            about = "Mleczna";
        }

        public void dodajeMleko()
        {
            Console.WriteLine("Dodaje mleko...");
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
            dodajeMleko();
            return this;
        }
    }
}
