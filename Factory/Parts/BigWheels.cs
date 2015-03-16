using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Parts
{
	public class BigWheels : Wheels
	{
		public BigWheels()
		{
			Console.WriteLine("Wheels are 17");
		}
	}
}
