using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class TwitterWidget : IObserver
	{
		private string _twitter;

		public void Update(string twitter, string lenta, string tv)
		{
			_twitter = twitter;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("twitter: {0}", _twitter);
		}
	}
}
