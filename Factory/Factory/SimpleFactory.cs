using Factory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class SimpleFactory
    {
        public Car GetCar(string type)
        {
            Car car = new Car(); // сильно привязаны к своим классам

            // это есть реализация простой фабрики
            if (type == "Golf")
                car = new Golf();
            else if (type == "Passat")
                car = new Passat();
            else if (type == "Tiguan")
                car = new Tiguan();
            else if (type == "Touareg")
                car = new Touareg();

            return car;
        }

    }
}
