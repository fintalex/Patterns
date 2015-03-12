using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class TvWidget
	{
		public void Update(string twitter, string lenta, string tv)
		{
			Console.WriteLine("TV: {0}", tv);
		}
	}
}
