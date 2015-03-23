using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.ControlledSystems
{
	public class Music
	{
		public void TurnOn()
		{
			Console.WriteLine("Музыка включена");
			State = State.On;
		}
		public void TurnOn()
		{
			Console.WriteLine("Музыка выключена");
			State = State.Off;
		}


		public State State { get; set; }
	}
}
