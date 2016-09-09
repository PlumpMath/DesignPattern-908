using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class Zmiana : Posilek
    {
        protected Posilek posilek;
        protected Zmiana(Posilek p)
        {
            this.posilek = p;
        }
        public abstract String dawajNazwe();
    }
}
