using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class Hamburger : FastFood
	{
		public override void Prepare()
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
	
		public void FryMeat()
		{
			Console.WriteLine("FryMeat");
		}
		
	}
}
