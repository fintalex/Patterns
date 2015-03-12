using Observer.News;
using Observer.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			var newsAggregator = new NewsAggregator();
			var twitterWidget = new TwitterWidget(newsAggregator);
			var lentaWidget = new LentaWidget(newsAggregator);
			var tvWidget = new TvWidget(newsAggregator);

			//newsAggregator.RegisterObserver(lentaWidget);
			//newsAggregator.RegisterObserver(tvWidget);
			//newsAggregator.RegisterObserver(twitterWidget);



			newsAggregator.NewNewsAvailable();
			Console.WriteLine();

			twitterWidget.RemoveFromSubject();

			newsAggregator.NewNewsAvailable();

			Console.ReadLine();
		}
	}
}
