using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.News
{
	public interface ISubject
	{
		void RegisterObserver(Widgets.IObserver observer);
		void RemoveObserver(Widgets.IObserver observer);
		void NotifyObservers();
	}
}
