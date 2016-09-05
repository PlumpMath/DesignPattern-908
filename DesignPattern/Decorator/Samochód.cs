using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Samochod
    {
        protected string samochod = "Samochod podstawowy";

        virtual public String About()
        {
            return samochod;
        }

        public abstract double Cena();
    }
}
