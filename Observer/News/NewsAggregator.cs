using Observer.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.News
{
	class NewsAggregator
	{
		private static TwitterWidget _twitterWidget;
		private static LentaWidget _lentaWidget;
		private static TvWidget _tvWidget;
		private static Random _random;

		public NewsAggregator()
		{
			_twitterWidget = new TwitterWidget();
			_lentaWidget = new LentaWidget();
			_tvWidget = new TvWidget();
			_random = new Random();
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
			string twitter = GetTwitterNews();
			string tv = GetTvNews();
			string lenta = GetLentaNews();

			_twitterWidget.Update(twitter, lenta, tv);
			_tvWidget.Update(twitter, lenta, tv);
			_lentaWidget.Update(twitter, lenta, tv);
		}
	}
}
