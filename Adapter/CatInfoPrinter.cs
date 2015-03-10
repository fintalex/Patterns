using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.HomeCats;

namespace Adapter
{
	class CatInfoPrinter
	{
		public static void PrintCatInfo(IHomeCats cat)
		{
			Console.WriteLine("Кошачье досье");
			Console.WriteLine(string.Format("Имя кота: {0}", cat.Name));
			Console.WriteLine("Вид мяуканья");
			cat.Meow();
			Console.WriteLine("Вид царапания");
			cat.Scratch();

			Console.WriteLine();
		}
	}
}
