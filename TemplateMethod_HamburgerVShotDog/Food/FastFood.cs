using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	abstract class FastFood
	{
		public void Prepare()
		{
			RoastBred();
			PrepareIngridient();
			PutVegetables();
			AddTopings();
		}

		public abstract void AddTopings();

		public abstract void PrepareIngridient();

		public void RoastBred()
		{
			Console.WriteLine("bread");
		}
		public void PutVegetables()
		{
			Console.WriteLine("vegetables");
		}
	}
}
