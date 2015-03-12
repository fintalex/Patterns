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
			var twitterWidget = new TwitterWidget();
			var lentaWidget = new LentaWidget();
			var tvWidget = new TvWidget();

			newsAggregator.RegisterObserver(lentaWidget);
			newsAggregator.RegisterObserver(tvWidget);
			newsAggregator.RegisterObserver(twitterWidget);



			newsAggregator.NewNewsAvailable();
			Console.WriteLine();

			newsAggregator.NewNewsAvailable();
			Console.ReadLine();
		}
	}
}
