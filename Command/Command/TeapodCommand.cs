using Command.ControlledSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class TeapodCommand : ICommand
	{
		private Teapod _teapod;

		public TeapodCommand(Teapod teapod)
		{
			_teapod = teapod;
		}

		public void Execute()
		{
			_teapod.TurnOn(); //Console.WriteLine("Чайник включен");
		}

		public void Undo()
		{
			_teapod.TurnOff();
		}

		public override string ToString()
		{
			return "Включить чайник";
		}
	}
}
