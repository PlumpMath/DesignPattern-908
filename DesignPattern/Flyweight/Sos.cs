namespace Flyweight
{
    internal class Sos : Zmiana
    {
        public Sos(Posilek posilek) : base(posilek)
        {
        }


        public override string dawajNazwe()
        {
            return posilek.dawajNazwe() + " + sos";
        }
    }
}