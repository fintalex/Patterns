using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ControlledSystems
{
	class Light
	{
		public void TurnOn()
		{
			Console.WriteLine("Свет включен");
			State = State.On;
		}
		public void TurnOn()
		{
			Console.WriteLine("Свет выключен");
			State = State.Off;
		}


		public State State { get; set; }
	}
}
