using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PakietDodatkowy
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public PakietDodatkowy(string n,double c)
        {
            Nazwa = n;
            Cena = c;
        }
    }
}
