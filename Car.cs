using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic
{
    internal class Car
    {
        protected String Model;
        protected String Name;
        protected String color;
        public void Start()
        {
            Console.WriteLine("The Car is Running... ");
        }
        public void Stop()
        {
            Console.WriteLine("The Car is stoping...");

        }
        public void SetColor(String Color)
        {
            this.color = Color;
        }
        public String GetColor()
        {
            return this.color;
        }



    }
}
