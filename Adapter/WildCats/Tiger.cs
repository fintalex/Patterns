using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WildCats
{
	class Tiger : IWildCat
	{
		string Breed
		{
			get { return "Тигр обыкновенны"; }
		}

		void Growl()
		{
			Console.WriteLine("Grrrrr");
		}

		void Scratch()
		{
			Console.WriteLine("Очень сильно царапаюсь");
		}
	}
}
