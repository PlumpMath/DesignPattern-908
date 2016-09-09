using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Zawodnik
    {
        private String id;
        public Zawodnik(String id)
        {
            this.id = id;
        }

        public void zacznijBiegac()
        {
            Console.WriteLine("zawodnik " + id + " biega");
        }

        public void przestanBiegac()
        {
            Console.WriteLine("zawodnik " + id + " przestal biegac");
        }

        public void zacznijPlywac()
        {
            Console.WriteLine("zawodnik " + id + " plywa");
        }

        public void przestanPlywac()
        {
            Console.WriteLine("zawodnik " + id + " przestal plywac");
        }

        public void zacznijCwiczyc()
        {
            Console.WriteLine("zawodnik " + id + " cwiczy");
        }

        public void przestanCwiczyc()
        {
            Console.WriteLine("zawodnik " + id + " przestal cwiczyc");
        }
    }
}
