using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class LentaWidget : IObserver
	{
		private string _lenta;

		public void Update(string twitter, string lenta, string tv)
		{
			_lenta = lenta;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("Lenta: {0}", _lenta);
		}

	}
}
