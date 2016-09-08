using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ProducentCzekolady
    {
        public Czekolada produkcjaCzekolady(String about)
        {
            Czekolada czekolada = null;

            /* teraz decyduje o tym, ktora czekolade wytworzy */
            if (about.Equals("Mleczna"))
            {
                czekolada = new Mleczna();
            }
            else if (about.Equals("Z orzechami i bakaliami"))
            {
                czekolada = new ZOrzechamiIBakaliami();
            }
            else if (about.Equals("Gorzka"))
            {
                czekolada = new Gorzka();
            }
            return czekolada.dawajCzekolade();
        }
    }

}
