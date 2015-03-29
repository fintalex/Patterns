using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Car
    {
        public int Gasoline {get; private set;} 

        public EmptyTankState EmtpyTank { get; private set; }
        public FullTankState FullTank { get; private set; }
        public EngineStartedState EngineStarted { get; private set; }
        public DrivingState Driving { get; private set; }

        private IState _currentState;
        public Car ()
        {
            EmtpyTank = new EmptyTankState(this);
            FullTank = new FullTankState(this);
            EngineStarted = new EngineStartedState(this);
            Driving = new DrivingState(this);

            _currentState = EmtpyTank;
            Gasoline = 0;
        }

        public void FillTank()
        {
            Gasoline = 70;
            _currentState.FillTank();
        }

        public void TurnKey()
        {
            _currentState.TurnKey();
        }

        public void Drive()
        {
            _currentState.Drive();
            Gasoline -= 10;
        }

        public void Stop()
        {
            _currentState.Stop();
        }

        public void SetState (IState state)
        {
            _currentState = state;
        }
    }
}
