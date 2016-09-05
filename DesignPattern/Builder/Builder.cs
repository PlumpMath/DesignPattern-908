using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Builder
    {
        protected ZestawKomputerowy zestawKomputerowy;

        public void newZestaw()
        {
            zestawKomputerowy = new ZestawKomputerowy();
        }

        //public ZestawKomputerowy getZestaw()
        //{
        //    return zestawKomputerowy;
        //}

        public ZestawKomputerowy Zestaw
        {
            get
            {
                return zestawKomputerowy;
            }
        }
        public abstract void buildMonitor();
        public abstract void buildProcesor();
        public abstract void buildGrafika();
        public abstract void buildRam();
        public abstract void buildHdd();
    }
}
