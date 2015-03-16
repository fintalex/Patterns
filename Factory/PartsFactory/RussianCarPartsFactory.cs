using Factory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PartsFactory
{
	public class RussianCarPartsFactory : CarPartsFactory
	{
		public override Parts.Engine CreateEngine()
		{
			return new GasolineEngine();
		}

		public override Parts.Paint CreatePaint()
		{
			return new BlackPaint();
		}

		public override Parts.Wheels CreateWheels()
		{
			return new MediumWheels();
		}
	}
}
