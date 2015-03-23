using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class RemoteControl
	{
		internal void DrawMenu()
		{
			Console.WriteLine("Выберите вариант ниже:");
			Console.WriteLine("1 \t Включить свет");
			Console.WriteLine("1off \t  Выключить свет");
			Console.WriteLine("2 \t  Включить телевизор");
			Console.WriteLine("2off \t  Выключить телевизор");
			Console.WriteLine("3 \t  Включить музыку");
			Console.WriteLine("3off \t  Выключить музыку");
			Console.WriteLine("0 \t  Выход");
			Console.WriteLine();
		}

		// Но данное решение в лоб
		internal void PerformAction()
		{
			Console.Write("Ваш выбор: ");
			var input = Console.ReadLine();

			switch (input)
			{
				case "1":
					TurnLightOn();
					break;
				case "1off":
					TurnLightOff();
					break;
				case "2":
					TurnTvOn();
					break;
				case "2off":
					TurnTvOff();
					break;
				case "3":
					TurnMusicOn();
					break;
				case "3off":
					TurnMusicOff();
					break;
			}

		}

		private void TurnMusicOff()
		{
			Console.WriteLine("Music выключен");
		}

		private void TurnMusicOn()
		{
			Console.WriteLine("Music включен");
		}

		private void TurnTvOff()
		{
			Console.WriteLine("Телевизор выключен");
		}

		private void TurnTvOn()
		{
			Console.WriteLine("Телевизор включен");
		}

		private void TurnLightOff()
		{
			Console.WriteLine("Свет выключен");
		}

		private void TurnLightOn()
		{
			Console.WriteLine("Свет включен");
		}
	}
}
