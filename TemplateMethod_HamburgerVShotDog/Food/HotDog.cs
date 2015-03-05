using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class HotDog
	{
		public void Prepare()
		{
			RoastBred();
			BoilSausage();
			PutVegetables();
			AddMustard();
		}

		public void AddMustard()
		{
			Console.WriteLine("Musstard");
		}
		public void PutVegetables()
		{
			Console.WriteLine("vegetables");
		}
		public void BoilSausage()
		{
			Console.WriteLine("sausage");
		}
		public void RoastBred()
		{
			Console.WriteLine("bread");
		}
	}
}
