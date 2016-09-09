using System;

namespace Flyweight
{
    public class Ser : Zmiana
    {
        public Ser(Posilek posilek) : base(posilek)
        {
        }

        public override String dawajNazwe()
        {
            return posilek.dawajNazwe() + " + ser";
        }
    }
}