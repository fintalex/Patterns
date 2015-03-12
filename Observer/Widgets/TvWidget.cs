using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class TvWidget : IObserver
	{
		private string _tv;

		public void Update(string twitter, string lenta, string tv)
		{
			_tv = tv;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("tv: {0}", _tv);
		}
	}
}
