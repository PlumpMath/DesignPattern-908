using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class PelnyTrening : Polecenie
    {
        private Polecenie[] tab;
        public PelnyTrening(Polecenie[] tab)
        {
            this.tab = tab;
        }

        public void wykonaj()
        {
            foreach (Polecenie temp in tab)
            {
                temp.wykonaj();
            }
        }

        public void cofnij()
        {
            foreach (Polecenie temp in tab)
            {
                temp.cofnij();
            }
        }
    }
}
