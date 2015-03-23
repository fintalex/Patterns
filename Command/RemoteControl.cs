using Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class RemoteControl
	{
		private Dictionary<string, ICommand> _commands;

		public RemoteControl()
		{
			_commands = new Dictionary<string, ICommand>();
			_commands.Add("1", new LightsCommand());
			_commands.Add("2", new TvCommand());
			_commands.Add("3", new MusicCommand());
		}

		internal void DrawMenu()
		{
			Console.WriteLine("Выберите вариант ниже:");

			foreach (var btnId in _commands.Keys)
			{
				Console.WriteLine("{0} \t- {1}", btnId, _commands[btnId]);
			}
			
			Console.WriteLine("1off \t  Выключить свет");
			Console.WriteLine("2off \t  Выключить телевизор");
			Console.WriteLine("3off \t  Выключить музыку");
			Console.WriteLine("0 \t  Выход");
			Console.WriteLine();
		}

		// Но данное решение в лоб
		internal void PerformAction()
		{
			Console.Write("Ваш выбор: ");
			var input = Console.ReadLine() ?? string.Empty;

			switch (input)
			{
				case "1off":
					TurnLightOff();
					break;
				case "2off":
					TurnTvOff();
					break;
				case "3off":
					TurnMusicOff();
					break;
			}

			if (_commands.ContainsKey(input))
				_commands[input].Execute();
		}

		public void SerCommandForButton(string btnId, ICommand cmd)
		{
			_commands[btnId] = cmd; // если же ключ существет - он будет перезаписан, если нет - добавлен
		}

		private void TurnMusicOff()
		{
			Console.WriteLine("Music выключен");
		}

		private void TurnTvOff()
		{
			Console.WriteLine("Телевизор выключен");
		}

		private void TurnLightOff()
		{
			Console.WriteLine("Свет выключен");
		}

	}
}
