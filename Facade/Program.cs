using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.WashingMachine;

// пример со стиральной машиной
namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			// пример демонстрирует неудобство использования разрозненных вещей.
			// паттерн фассад же позволит нам все это объеденить в один общий упрощенный интерфейс по средством композиции объектов.
			var water = new WaterManagingSubsystem();
			var dryer = new Dryer();
			var engine = new Engine();
			var thermo = new Thermo();

			var washingMashine = new WashingMachine.WashingMachine(dryer, engine, thermo, water);

			// хлопок стираем 
			washingMashine.washCotton();

			// для шерсти по другому уже! 
			washingMashine.washWool();

			Console.ReadLine();
		}
	}
}
