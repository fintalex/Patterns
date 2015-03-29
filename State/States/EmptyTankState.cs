using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class EmptyTankState : IState
    {
        private readonly Car _car;
        public EmptyTankState(Car car)
        {
            _car = car;
        }
        public void FillTank()
        {
            _car.Gasoline = 70;
            Console.WriteLine("Бак теперь полон");
        }

        public void TurnKey()
        {
            Console.WriteLine("Без бензина не работаю");
        }

        public void Drive()
        {
            Console.WriteLine("Без бензина не еду");
        }

        public void Stop()
        {
            Console.WriteLine("Нет бензина - значит и так стоим");
        }
    }
}
