﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class DrivingState : IState
    {
        private readonly Car _car;
        public DrivingState(Car car)
        {
            _car = car;
        }
        public void FillTank()
        {
            Console.WriteLine("Ты что, убить нас хочешь? Нельзя заправлять на ходу");
        }

        public void TurnKey()
        {
            Console.WriteLine("На ходу ключ не трогать");
        }

        public void Drive()
        {
            TryDriving();
        }

        public void Stop()
        {
            Console.WriteLine("Накатался? Ну давай постоиим");
            _car.SetState(_car.EngineStarted);
        }

        private void TryDriving()
        {
            if (_car.Gasoline > 0)
            {
                Console.WriteLine("Поехали!");
            }
            else
            {
                Console.WriteLine("Докатились. Бензин кончился");
                _car.SetState(_car.EmtpyTank);
            }
        }
    }
}
