using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCats
{
	public class YardCat : IHomeCats
	{

		public string Name
		{
			get;
			set;
		}

		public void Meow()
		{
			Console.WriteLine(" May May may");
		}

		public void Scratch()
		{
			Console.WriteLine("Я царапаюсь, но не сильно");
		}
	}
}
