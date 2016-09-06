using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pamiec
{
        public class DDR2 : IRam
        {
            String name = "DDR2";
            public IRam dawajRam()
            {
                Console.WriteLine("Dodaje: " + name);
                return new DDR2();
            }
    }
}
