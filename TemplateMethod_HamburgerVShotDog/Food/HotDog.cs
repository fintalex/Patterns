using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_HamburgerVShotDog.Food
{
	class HotDog : FastFood
	{
		public override void AddTopings()
		{
			Console.WriteLine("AddMustard");
		}
		public override void PrepareIngridient()
		{
			Console.WriteLine("sausage");
		}
		public override bool CustomerWantsTopings()
		{
			Console.WriteLine("Do you want mustard?");
			var userInput = Console.ReadLine();

			return userInput.ToLower() == "yes" || userInput == "y";
		}

		
	}
}
