using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ControlledSystems
{
	public enum State
	{
		Off= 0,
		On =1
	}
	public class Tv
	{
		public void TurnOn()
		{
			Console.WriteLine("телевизор включен");
			State = State.On;
		}
		public void TurnOn()
		{
			Console.WriteLine("телевизор выключен");
			State = State.Off;
		}


		public State State { get; set; }
	}
}
