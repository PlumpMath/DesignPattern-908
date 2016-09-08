using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class TotoLotek : Obserwowany
    {
        private ArrayList obserwatorzy;
        private int[] wyniki;

        public TotoLotek()
        {
            obserwatorzy = new ArrayList();
            wyniki = new int[] { 0, 0, 0, 0, 0, 0 };
        }

        public void dodajObserwatora(Obserwator o)
        {
            obserwatorzy.Add(o);
        }

        public void usunObserwatora(Obserwator o)
        {
            int index = obserwatorzy.IndexOf(o);
            obserwatorzy.RemoveAt(index);
        }

        public void powiadamiajObserwatorow()
        {
            Obserwator[] tab = (Obserwator[])obserwatorzy.ToArray(typeof(Obserwator));
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].update(wyniki);
            }
        }

        public void kolejneLosowanie()
        {
            int i = 0;
            Random random = new Random();
            while (i < 6)
            {
                bool powtorka = false;
                int x = random.Next(48);// (Math.random() * 47 - 1);
                for (int j = 0; j < 6; j++)
                {
                    if (wyniki[j] == x)
                    {
                        powtorka = true;
                    }
                }
                if (powtorka == false)
                {
                    wyniki[i++] = x;
                }
            }//while
            powiadamiajObserwatorow();
        }

        public int[] getResults()
        {
            return wyniki;
        }
    }//class
}
