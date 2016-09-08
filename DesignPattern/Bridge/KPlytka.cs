using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class KPlytka : Plytka
    {
        public KPlytka(Tlok type, String name, PlytkaInterface plytkaInterface) : base(type, name, plytkaInterface)
        {
        }

        public override void akcja()
        {
            plytkaInterface.akcja();
        }

    }
}
