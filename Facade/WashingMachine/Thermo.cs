using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WashingMachine
{
	public class Thermo
	{
		public void WarmUp(int degrees)
		{
			Console.WriteLine("Warm for {0} degrees", degrees);
		}
	}
}
