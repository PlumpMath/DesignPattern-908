using AbstractFactory.Czesci;
using AbstractFactory.Komputery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FabrykaKomputerow
    {
        public Komputer wydajKomputer(String model)
        {
            Komputer komputer = zlozKomputer(model);
            komputer.instalowanieOprogramowania();
            komputer.pakowanie();
            komputer.sprzedawanie();
            return komputer;
        }

        protected Komputer zlozKomputer(String model)
        {
            Komputer komputer = null;
            if (model.Equals("PC"))
            {
                komputer = new KomputerPC(new FabrykaPodzespolowPC());
            }
            else if (model.Equals("Laptop"))
            {
                komputer = new Laptop(new FabrykaPodzespolowLaptop());
            }
            return komputer;
        }
    }
}
