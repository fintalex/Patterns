﻿using Factory.PartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class Passat : Car
    {
		private CarPartsFactory _factory;

		public Passat(CarPartsFactory factory)
        {
			Name = "Passat";
			Body = "Sedan";
			_factory = factory;
        }

		public override void Configure()
		{
			Console.WriteLine("configuring {0}", Name);
			Console.WriteLine("body is: {0}", Body);

			this.Engine = _factory.CreateEngine();
			this.PaintColor = _factory.CreatePaint();
			this.Wheels = _factory.CreateWheels();

		}
    }
}
