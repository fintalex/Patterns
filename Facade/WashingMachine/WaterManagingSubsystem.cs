using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WashingMachine
{
	public class WaterManagingSubsystem
	{
		public void FillWater(int litres)
		{
			Console.WriteLine("Fill with {0} litres of water", litres);
		}

		public void EmtyWater()
		{
			Console.WriteLine("Empty water tank");
		}

	}
}
