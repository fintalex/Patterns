using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ControlledSystems
{
	public class Teapod
	{

		public void TurnOn()
		{
			Console.WriteLine("Чайник включен");
			State = State.On;
		}
		public void TurnOff()
		{
			Console.WriteLine("Чайник выключен");
			State = State.Off;
		}


		public State State { get; set; }

	}
}
