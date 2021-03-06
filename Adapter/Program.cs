﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.HomeCats;
using Adapter.WildCats;
using Adapter.Adapters;

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

			IWildCat tiger = new Tiger();
			HomeCatAdapter adapter = new HomeCatAdapter(tiger);
			CatInfoPrinter.PrintCatInfo(adapter);

			Console.ReadLine();
		}
	}
}
