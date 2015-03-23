using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class LightsCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Телевизор включен");
		}
	}
}
