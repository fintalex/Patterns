using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WildCats
{
	class Tiger : IWildCat
	{
		public string Breed
		{
			get { return "Тигр обыкновенны"; }
		}

		public void Growl()
		{
			Console.WriteLine("Grrrrr");
		}

		public void Scratch()
		{
			Console.WriteLine("Очень сильно царапаюсь");
		}
	}
}
