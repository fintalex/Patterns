using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class MusicCommand : ICommand
	{

		public void Execute()
		{
			Console.WriteLine("Music включен");
		}
		public override string ToString()
		{
			return "Включить music";
		}
	}
}
