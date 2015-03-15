using Factory.Facilities;
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
            VolkswagenFacility facility = new VolkswagenFacility();
            facility.GetCar();

            Console.ReadLine();
        }
    }
}
