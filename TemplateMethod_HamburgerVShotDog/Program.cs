using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_HamburgerVShotDog.Food;

// реализация с http://www.youtube.com/watch?v=fLTOE6vZ8Ck&list=PLtjuvkyFrt5Wjd-973N117XS7xuuoD6XM&index=8
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
