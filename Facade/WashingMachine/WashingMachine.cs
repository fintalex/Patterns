using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WashingMachine
{
	public class WashingMachine
	{
		private Dryer _dryer;
		private Engine _engine;
		private Thermo _thermo;
		private WaterManagingSubsystem _water;

		public WashingMachine(Dryer dryer, Engine engine, Thermo thermo, WaterManagingSubsystem water)
		{
			_dryer = dryer;
			_engine = engine;
			_thermo = thermo;
			_water = water;
		}

		// вводим режим стирки хлопка
		public void washCotton()
		{
			_water.FillWater(10);
			_thermo.WarmUp(70);
			_engine.Rotate();
			_engine.Rotate();
			_engine.Rotate();
			_engine.Stop();
			_water.EmtyWater();
			_dryer.Dry(3000, 1000);
			_water.FillWater(15);
			_engine.Rotate();
			_engine.Rotate();
			_engine.Rotate();
			_engine.Stop();
			_water.EmtyWater();
			_dryer.Dry(6000, 1000);
		}

		// вводим режим стирки шерсти
		public void washWool()
		{
			_water.FillWater(20);
			_thermo.WarmUp(10);
			_engine.Rotate();
			_engine.Rotate();
			_engine.Rotate();
			_engine.Stop();
			_water.EmtyWater();
			_dryer.Dry(1500, 1000);
			_water.FillWater(15);
			_engine.Rotate();
			_engine.Rotate();
			_engine.Rotate();
			_engine.Stop();
			_water.EmtyWater();
			_dryer.Dry(2000, 1000);
		}
	}
}
