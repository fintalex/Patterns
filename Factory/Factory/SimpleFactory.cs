﻿using Factory.Cars;
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
			//Car car = new Car(); // сильно привязаны к своим классам

			//// это есть реализация простой фабрики
			//if (type == "Golf")
			//	car = new DeutschGolf();
			//else if (type == "Passat")
			//	car = new DeutschPassat();
			//else if (type == "Tiguan")
			//	car = new DeutschTiguan();
			//else if (type == "Touareg")
			//	car = new DeutschTouareg();

            return null;
        }

    }
}
