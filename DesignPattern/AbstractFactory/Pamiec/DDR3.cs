using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pamiec
{
    public class DDR3 : IRam
    {
        String name = "DDR3";
        public IRam dawajRam()
        {
            Console.WriteLine("Dodaje: " + name);
            return new DDR3();
        }
    }
}
