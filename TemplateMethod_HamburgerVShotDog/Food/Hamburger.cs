using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class Hamburger
	{
		public void Prepare()
		{
			RoastBred();
			FryMeat();
			PutVegetables();
			AddKetchup();
		}

		public void AddKetchup()
		{
			Console.WriteLine("AddKetchup");
		}
		public void PutVegetables()
		{
			Console.WriteLine("vegetables");
		}
		public void FryMeat()
		{
			Console.WriteLine("FryMeat");
		}
		public void RoastBred()
		{
			Console.WriteLine("bread");
		}
	}
}
