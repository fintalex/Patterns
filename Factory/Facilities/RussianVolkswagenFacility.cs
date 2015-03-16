using Factory.Cars;
using Factory.PartsFactory;
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
			CarPartsFactory factory = new RussianCarPartsFactory();

			// это есть реализация простой фабрики
			if (type == "Golf")
				return new Golf(factory);
			else if (type == "Passat")
				return new Passat(factory);
			else if (type == "Tiguan")
				return new Tiguan(factory);
			else if (type == "Touareg")
				return new Touareg(factory);

            return null;
        }
    }
}
