using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class Hamburger : FastFood
	{
		public override void AddTopings()
		{
			Console.WriteLine("AddKetchup");
		}

		public override void PrepareIngridient()
		{
			Console.WriteLine("FryMeat");
		}
		
	}
}
