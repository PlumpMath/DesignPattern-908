using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ZestawXT001 : Builder
    {


        public override void buildMonitor()
        {
            zestawKomputerowy.Monitor="Benq 19";
        }

        public override void buildProcesor()
        {
            zestawKomputerowy.Procesor="amd";
        }

        public override void buildGrafika()
        {
            zestawKomputerowy.Grafika="ATI";
        }

        public override void buildRam()
        {
            zestawKomputerowy.Ram="DDR3";
        }

        public override void buildHdd()
        {
            zestawKomputerowy.Hdd="WD Red";

        }
    }
}
