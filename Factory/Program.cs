using Factory.Facilities;
using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VolkswagenFacility facility = new RussianVolkswagenFacility();
            facility.GetCar("Golf");
			Console.WriteLine("===");
            facility.GetCar("Passat");
			Console.WriteLine("===");

            facility.GetCar("Tiguan");
			Console.WriteLine("===");
            facility.GetCar("Touareg");
			Console.WriteLine("===");

            Console.ReadLine();
        }
    }
}
