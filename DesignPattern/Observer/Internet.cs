using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Internet : Obserwator, Media
    {
        private int[] wyniki;
        private TotoLotek lotek;

        public Internet(TotoLotek lotek)
        {
            wyniki = new int[6];
            this.lotek = lotek;
        }

        public void update(int[] tab)
        {
            for (int i = 0; i < 6; i++)
            {
                wyniki[i] = tab[i];
            }
        }

        public void informuj()
        {
            Console.WriteLine("Wyniki TotoLotka na stronie internetowej");
            for (int i = 0; i < 6; i++)
                Console.Write(wyniki[i] + " ");
            Console.WriteLine();
        }

        public void spadam()
        {
            lotek.usunObserwatora(this);
        }
    }
}
