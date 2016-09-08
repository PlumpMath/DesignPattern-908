using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Czekolada
    {
        protected String about;

        public abstract Czekolada dawajCzekolade();

        protected void dodajeKakao()
        {
            Console.WriteLine("Dodaje kakao...");
        }
    }
}
