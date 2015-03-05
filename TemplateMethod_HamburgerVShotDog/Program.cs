using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_HamburgerVShotDog.Food;

namespace TemplateMethod_HamburgerVShotDog
{
	class Program
	{
		static void Main(string[] args)
		{
			var hotDog = new HotDog();
			var hamburger = new Hamburger();

			Console.WriteLine("\nHotDog");
			hotDog.Prepare();

			Console.WriteLine("\nHamburger");
			hamburger.Prepare();
		}
	}
}
