using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private Builder _builder;

        public Builder Builder
        {
            get
            {
                return _builder;
            }
            set
            {
                _builder = value;
            }
        }

        public ZestawKomputerowy Zestaw
        {
            get
            {
                return _builder.Zestaw;
            }
        }
        

        //public void SetBuilder(Builder builder)
        //{
        //    this.builder = builder;
        //}

        //public ZestawKomputerowy GetZestaw()
        //{
        //    return builder.getZestaw();
        //}

        public void Skladaj()
        {
            _builder.newZestaw();
            _builder.buildMonitor();
            _builder.buildProcesor();
            _builder.buildHdd();
            _builder.buildRam();
            _builder.buildGrafika();
        }
    }
}
