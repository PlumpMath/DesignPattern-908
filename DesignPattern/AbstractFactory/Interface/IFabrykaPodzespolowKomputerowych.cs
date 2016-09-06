using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFabrykaPodzespolowKomputerowych
    {
        IDysk produkujemyDysk();
        IGrafika produkujemyGrafike();
        IRam produkujemyRam();
        IProcesor produkujemyProcesor();
        IChlodzenie produkujemyChlodzenie();
    }
}
