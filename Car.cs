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
        public virtual void Start()
        {
            Console.WriteLine("Running Car..."+" Have a Good Times");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Stoping Car, \n Beacuse not have a charge!, \n Please charge Car");

        }
        public virtual void SetColor(String Color)
        {
            this.color = Color;
        }
        public virtual String GetColor()
        {
            return this.color;
        }



    }
}
