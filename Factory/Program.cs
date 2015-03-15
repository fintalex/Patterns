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
            facility.GetCar("Passat");
            facility.GetCar("Tiguan");
            facility.GetCar("Touareg");

            Console.ReadLine();
        }
    }
}
