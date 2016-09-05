using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ZestawABC996 : Builder
    {

        public override void buildMonitor()
        {
            zestawKomputerowy.Monitor = "LG";
        }

        public override void buildProcesor()
        {
            zestawKomputerowy.Procesor="INTEL";
        }

        public override void buildGrafika()
        {
            //zestaw nie obejmuje karty graficznej
        }

        public override void buildRam()
        {
            zestawKomputerowy.Ram="DDR";
        }

        public override void buildHdd()
        {
            zestawKomputerowy.Hdd="Samsung";
        }
    }
}
