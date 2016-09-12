using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Leczenie : Pracowac
    {
        public void pracuj()
        {
            Console.WriteLine("Praca: leczy ludzi");
        }
    }
}
