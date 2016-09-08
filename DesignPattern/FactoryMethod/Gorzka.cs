using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Gorzka : Czekolada
    {
        public void dodajeEkstratWaniliowy()
        {
            Console.WriteLine("Dodaje ekstrat waniliowy...");
        }
        public override Czekolada dawajCzekolade()
        {
            Console.WriteLine(about);
            dodajeKakao();
            dodajeEkstratWaniliowy();
            return this;
        }
    }
}
