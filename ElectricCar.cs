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
            else
            {
                Start();
            }
        }
    }
}
