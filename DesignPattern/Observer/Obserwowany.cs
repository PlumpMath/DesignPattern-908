using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface Obserwowany
    {
        void dodajObserwatora(Obserwator o);
        void usunObserwatora(Obserwator o);
        void powiadamiajObserwatorow();
    }
}
