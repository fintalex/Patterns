using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.HomeCats;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			IHomeCats vaska = new YardCat();
			vaska.Name = "Васька";
			CatInfoPrinter.PrintCatInfo(vaska);

			IHomeCats wagner = new PedigreeCat();
			wagner.Name = "Вагнер";
			CatInfoPrinter.PrintCatInfo(vaska);

			Console.ReadLine();
		}
	}
}
