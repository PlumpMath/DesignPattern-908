using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Plytka
    {
        protected PlytkaInterface plytkaInterface;
        protected Tlok type;
        protected String name;


        public Plytka(Tlok type, String name, PlytkaInterface plytkaImp)
        {
            this.type = type;
            this.name = name;
            this.plytkaInterface = plytkaImp;
        }


        public String Get()
        {
            return name + " " + type;
        }


        public void Set(String s, Tlok type)
        {
            this.name = s;
            this.type = type;
        }


        public abstract void akcja();
    }
}
