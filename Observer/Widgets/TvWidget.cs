using Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class TvWidget : IObserver, IWidget
	{
		private string _tv;
		private ISubject _subject;

		public TvWidget(ISubject subject)
		{
			_subject = subject;
			_subject.RegisterObserver(this);
		}

		public void Update(string twitter, string lenta, string tv)
		{
			_tv = tv;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("tv: {0}", _tv);
		}

		public void RemoveFromSubject()
		{
			_subject.RemoveObserver(this);
		}
	}
}
