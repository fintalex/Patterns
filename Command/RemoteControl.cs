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
		private Dictionary<int, ICommand> _commands;

		public RemoteControl()
		{
			_commands = new Dictionary<int, ICommand>();
		}

		internal void DrawMenu()
		{
			Console.WriteLine("Выберите вариант ниже:");

			// перебираем все наши команды и рисуем меню
			foreach (var btnId in _commands.Keys)
			{
				Console.WriteLine("{0} \t- {1}", btnId, _commands[btnId]);
			}
			
			Console.WriteLine();
		}

		public void PushButton(int btnID)
		{
			if (_commands.ContainsKey(btnID))
				_commands[btnID].Execute();
		}

		public void UndoButton(int btnID)
		{
			if (_commands.ContainsKey(btnID))
				_commands[btnID].Undo();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var btnID in _commands.Keys)
			{
				sb.AppendFormat("{0} \t-{1}\n", btnID, _commands[btnID]);
			}

			sb.Append("проч. \t- Выход");
			return sb.ToString();
		}

		public void SetCommandForButton(int btnId, ICommand cmd)
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
