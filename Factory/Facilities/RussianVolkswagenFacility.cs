using Factory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Facilities
{
    class RussianVolkswagenFacility : VolkswagenFacility
    {
        public override Cars.Car CreateCar(string type)
        {
            Car car = new Car(); // сильно привязаны к своим классам

            // это есть реализация простой фабрики
            if (type == "Golf")
                car = new RussianGolf();
            else if (type == "Passat")
                car = new RussianPassat();
            else if (type == "Tiguan")
                car = new RussianTiguan();
            else if (type == "Touareg")
                car = new RussianTouareg();

            return car;
        }
    }
}
