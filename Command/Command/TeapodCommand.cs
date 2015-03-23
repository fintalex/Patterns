using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class TeapodCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Чайник включен");
		}

		public override string ToString()
		{
			return "Включить чайник";
		}
	}
}
