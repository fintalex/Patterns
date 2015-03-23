using Command.ControlledSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
	public class TvCommand : ICommand
	{
		private Tv _tv;

		public TvCommand(Tv tv) 
		{
			_tv = tv;
		}

		public void Execute()
		{
			_tv.TurnOn(); // Console.WriteLine("Телевизор включен");
		}
		public void Undo()
		{
			_tv.TurnOff();
		}

		public override string ToString()
		{
			return "Включить tv";
		}
	}
}
