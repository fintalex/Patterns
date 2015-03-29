using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class EngineStartedState : IState
    {
        private readonly Car _car;
        public EngineStartedState(Car car)
        {
            _car = car;
        }
        public void FillTank()
        {
            Console.WriteLine("Нельзя заправляться с работающим двигателем");
        }

        public void TurnKey()
        {
            Console.WriteLine("Тссс. Передышка");
        }

        public void Drive()
        {
            TryDriving();
        }

        public void Stop()
        {
            Console.WriteLine("Я и так стою");
        }

        private void TryDriving()
        {
            if (_car.Gasoline > 0)
            {
                Console.WriteLine("Поехали!");
                _car.Gasoline -= 10;
            }
            else
            {
                Console.WriteLine("Докатились. Бензин кончился");
            }
        }
    }
}
