using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Nagrywanie : PlytkaInterface
    {
        public void akcja()
        {
            Console.WriteLine("Nagrywam plytke");
        }
    }
}
