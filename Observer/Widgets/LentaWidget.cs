using Observer.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Widgets
{
	class LentaWidget : IObserver, IWidget
	{
		private string _lenta;
		private ISubject _subject;

		public LentaWidget(ISubject subject)
		{
			_subject = subject;
			_subject.RegisterObserver(this);
		}

		public void Update(string twitter, string lenta, string tv)
		{
			_lenta = lenta;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("Lenta: {0}", _lenta);
		}

		public void RemoveFromSubject()
		{
			_subject.RemoveObserver(this);
		}

	}
}
