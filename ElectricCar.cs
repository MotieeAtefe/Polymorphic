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
        public  void MeasurementCapacityBatry(double kwh)
        {
            
            this.kwh = kwh;
            if(kwh < 2) 
            {
                Console.WriteLine("Please charge Car");
            }
            else if(kwh >2)
            {  
               
                Start();
            }
            else if(kwh < 0)
            {
                Stop();
            }
        }
    }
}
