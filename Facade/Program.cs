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

			// стирка хлопка
			water.FillWater(90);
			thermo.WarmUp(70);
			engine.Rotate();
			engine.Rotate();
			engine.Rotate();
			engine.Stop();
			water.EmtyWater();
			dryer.Dry(3000, 1000);
			water.FillWater(15);
			engine.Rotate();
			engine.Rotate();
			engine.Rotate();
			engine.Stop();
			water.EmtyWater();
			dryer.Dry(6000, 1000);

			Console.ReadLine();

			// для шерсти по другому уже! 
		}
	}
}
