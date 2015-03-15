using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class Car
    {
        protected string Name = "";
        protected string Engine = "Diesel";
        protected string PaintColor = "White";
        protected string Wheels = "16 inch";
        protected string Body = "Caravan";

        public void Configure()
        {
            Console.WriteLine("Configuring {0}", Name);
            Console.WriteLine("Engine is: {0}", Engine);
            Console.WriteLine("Body is: {0}", Body);
            Console.WriteLine("PaintColor is:  {0}", PaintColor);
            Console.WriteLine("Wheels are: {0}", Wheels);
        }

        public void AssembleBody()
        {
            Console.WriteLine("Body is assembled");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is in its place");
        }
        public void Paint()
        {
            Console.WriteLine("Car is painted");
        }
        public void InstallWheels()
        {
            Console.WriteLine("Wheels are installed");
        }
    }
}
