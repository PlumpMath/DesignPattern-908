using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            String zawod = Console.ReadLine();

            try
            {
                Pracownik pracownik = new Pracownik(zawod);
                pracownik.methods();
            }
            catch (Exception e)
            {
                Console.WriteLine("nie ma takiego zawodu");
            }
            zawod = Console.ReadLine();
        }
    }
}
