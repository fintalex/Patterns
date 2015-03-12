using Observer.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.News
{
	class NewsAggregator : ISubject
	{
	//	private static TwitterWidget _twitterWidget;
	//	private static LentaWidget _lentaWidget;
	//	private static TvWidget _tvWidget;
		private static Random _random;

		private List<Widgets.IObserver> _observers;

		public NewsAggregator()
		{
			//_twitterWidget = new TwitterWidget();
			//_lentaWidget = new LentaWidget();
			//_tvWidget = new TvWidget();
			_random = new Random();
			_observers = new List<Widgets.IObserver>();
		}

		public void RegisterObserver(Widgets.IObserver observer)
		{
			_observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			_observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			string twitter = GetTwitterNews();
			string tv = GetTvNews();
			string lenta = GetLentaNews();

			foreach (var observer in _observers)
			{
				observer.Update(twitter, lenta, tv);
			}
		}



		public string GetTwitterNews()
		{
			var news = new List<string>
			{
				"Новость из Twitter №1",
				"Новость из Twitter №2",
				"Новость из Twitter №3"
			};
			return news[_random.Next(3)];
		}

		public string GetLentaNews()
		{
			var news = new List<string>
			{
				"Новость из Lenta №1",
				"Новость из Lenta №2",
				"Новость из Lenta №3"
			};
			return news[_random.Next(3)];
		}

		public string GetTvNews()
		{
			var news = new List<string>
			{
				"Новость из Tv №1",
				"Новость из Tv №2",
				"Новость из Tv №3"
			};
			return news[_random.Next(3)];
		}

		public void NewNewsAvailable()
		{
			NotifyObservers();
		}


		
	}
}
