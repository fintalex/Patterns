using Factory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PartsFactory
{
	// создали прототипа создания машины
	public abstract class CarPartsFactory
	{
		public abstract Engine CreateEngine();
		public abstract Paint CreatePaint();
		public abstract Wheels CreateWheels();
	}
}
