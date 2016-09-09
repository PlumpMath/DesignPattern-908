using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TrenerDelegat : Polecenie
    {
        delegate void Cwiczenia();
        Cwiczenia cwiczeniaDoWykonania;
        Cwiczenia cwiczeniaCofniecia;

        public TrenerDelegat(Polecenie[] tab)
        {
            foreach (var item in tab)
            {
                cwiczeniaDoWykonania += item.wykonaj;
                cwiczeniaCofniecia += item.cofnij;
            }
        }

        public void wykonaj()
        {
            cwiczeniaDoWykonania();
        }

        public void cofnij()
        {
            cwiczeniaCofniecia();
        }
    }

}
