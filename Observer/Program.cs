using Observer.News;
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

			newsAggregator.NewNewsAvailable();
			Console.WriteLine();

			newsAggregator.NewNewsAvailable();
			Console.ReadLine();
		}
	}
}
