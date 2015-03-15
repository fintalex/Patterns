using Factory.Cars;
using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Facilities
{
    abstract class VolkswagenFacility
    {
        //private SimpleFactory _factory;
        //public VolkswagenFacility(SimpleFactory factory)
        //{
        //    _factory = factory;
        //}
        public Car GetCar(string type)
        {
            
            //Car car = new Car(); // сильно привязаны к своим классам
            //Car car = _factory.GetCar(type);
            Car car = CreateCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }
        public abstract Car CreateCar(string type);
    }
}
