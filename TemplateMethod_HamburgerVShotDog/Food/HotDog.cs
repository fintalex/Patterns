using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class HotDog : FastFood
	{
		public override void Prepare()
		{
			RoastBred();
			BoilSausage();
			PutVegetables();
			AddMustard();
		}

		public void AddMustard()
		{
			Console.WriteLine("AddMustard");
		}
		public void BoilSausage()
		{
			Console.WriteLine("sausage");
		}
		
	}
}
