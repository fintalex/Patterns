using Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			var remote = new RemoteControl();
			string userInput;

			remote.SerCommandForButton("1", new LightsCommand());
			remote.SerCommandForButton("2", new TvCommand());
			remote.SerCommandForButton("3", new MusicCommand());
			remote.SerCommandForButton("4", new TeapodCommand());
			do
			{
				remote.DrawMenu();
				remote.PerformAction();

				Console.WriteLine("\nВы хотите продолжить (y/n): ");
				userInput = Console.ReadLine();
			} while (userInput != "y");
		}
	}
}
