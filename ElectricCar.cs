using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    internal class ElectricCar: Car
    {
        protected DateTime t;
        protected double kwh;
        public void MeasurementCapacityBatry(string t, double kwh)
        {
            this.t = DateTime.Parse(t);
            this.kwh = kwh;
            if(kwh < 2000) 
            {
                Console.WriteLine("Please charge Car");
            }
            else if(kwh >2000)
            {
                Console.WriteLine("Running Car..."+" Have a Good Times");
                Start();
            }
            else if(kwh < 0)
            {
                Console.WriteLine("Stoping Car, \n Beacuse not have a charge!, \n Please charge Car");
                Stop();
            }
        }
    }
}
