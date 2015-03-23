using Command.Command;
using Command.ControlledSystems;
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

			remote.SetCommandForButton(1, new LightsCommand(new Light()));
			remote.SetCommandForButton(2, new TvCommand(new Tv()));
			remote.SetCommandForButton(3, new MusicCommand(new Music()));
			remote.SetCommandForButton(4, new TeapodCommand(new Teapod()));
			do
			{
				Console.WriteLine("Выберите вариант ниже:");
				//remote.DrawMenu();
				//remote.PerformAction();

				Console.WriteLine(remote);
				Console.WriteLine("\nВаш выбор: ");

				var input = Console.ReadLine();
				int btnID;
				int.TryParse(input, out btnID);

				remote.PushButton(btnID);
				remote.UndoButton(btnID);

				Console.WriteLine("\nВы хотите продолжить (y/n): ");
				userInput = Console.ReadLine();
			} while (userInput == "y");
		}
	}
}
