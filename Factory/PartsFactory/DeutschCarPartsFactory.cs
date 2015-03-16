using Factory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PartsFactory
{
	public class DeutschCarPartsFactory : CarPartsFactory
	{
		public override Parts.Engine CreateEngine()
		{
			return new DieselEngine();
		}

		public override Parts.Paint CreatePaint()
		{
			return new WhitePaint(); 
		}

		public override Parts.Wheels CreateWheels()
		{
			return new BigWheels();
		}
	}
}
