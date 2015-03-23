using Command.ControlledSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class LightsCommand : ICommand
	{
		private Light _light;

		public LightsCommand(Light light) 
		{
			_light = light;
		}
		public void Execute()
		{
			_light.TurnOn(); // Console.WriteLine("Свет включен");
		}
		public void Undo()
		{
			_light.TurnOff();
		}

		public override string ToString()
		{
			return "Включить свет";
		}
	}
}
