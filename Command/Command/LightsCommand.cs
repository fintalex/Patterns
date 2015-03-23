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
        private Stack<LightState> _states;

		public LightsCommand(Light light) 
		{
			_light = light;
            _states = new Stack<LightState>();
		}
		public void Execute()
		{
            _states.Push(_light.State);
			_light.ToggleLight(); 
		}
		public void Undo()
		{
            var prevStates = _states.Pop();
            _light.SetState(prevStates);
		}

		public override string ToString()
		{
			return "Включить свет";
		}
	}
}
