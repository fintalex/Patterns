using Factory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Facilities
{
    class VolkswagenFacility
    {
        public Car GetCar()
        {
            Car car = new Car();

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }
    }
}
