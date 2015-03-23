using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class TvCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Телевизор включен");
		}
		public override string ToString()
		{
			return "Включить tv";
		}
	}
}
