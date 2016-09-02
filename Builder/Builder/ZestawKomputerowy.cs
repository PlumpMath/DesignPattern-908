using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ZestawKomputerowy
    {
        private String monitor;
        private String procesor;
        private String grafika;
        private String ram;
        private String hdd;
        public string Monitor
        {
            set
            {
                monitor = value;
            }
        }
        public string Procesor
        {
            set
            {
                procesor = value;
            }
        }
        public string Grafika
        {
            set
            {
                grafika = value;
            }
        }
        public string Ram
        {
            set
            {
                ram = value;
            }
        }
        public string Hdd
        {
            set
            {
                hdd = value;
            }
        }
        //public void setMonitor(String monitor)
        //{
        //    this.monitor = monitor;
        //}

        //public void setProcesor(String procesor)
        //{
        //    this.procesor = procesor;
        //}

        //public void setGrafika(String grafika)
        //{
        //    this.grafika = grafika;
        //}

        //public void setRam(String ram)
        //{
        //    this.ram = ram;
        //}

        //public void setHdd(String hdd)
        //{
        //    this.hdd = hdd;
        //}

        public void show()
        {
            if (monitor != null) Console.WriteLine("Monitor = " + monitor);
            if (procesor != null) Console.WriteLine("Procesor = " + procesor);
            if (grafika != null) Console.WriteLine("Grafika = " + grafika);
            if (ram != null) Console.WriteLine("RAM = " + ram);
            if (hdd != null) Console.WriteLine("HDD = " + hdd);
        }
    }
}
