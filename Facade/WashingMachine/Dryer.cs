using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WashingMachine
{
	public class Dryer
	{
		public void Dry(int seconds, int intensity)
		{
			Console.WriteLine("Drying {0} seconds with intensity {1}", seconds, intensity);
		}
	}
}
