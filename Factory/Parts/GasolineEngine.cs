using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Parts
{
	public class GasolineEngine : Engine
	{
		public GasolineEngine()
		{
			Console.WriteLine("Engine is Gasoline");
		}
	}
}
