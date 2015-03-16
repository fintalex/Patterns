using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Parts
{
	public class DieselEngine : Engine
	{
		public DieselEngine()
		{
			Console.WriteLine("Engine is Diesel");
		}
	}
}
