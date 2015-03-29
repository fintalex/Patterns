using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Car
    {
        private enum CarState
        {
            EmtyTank,
            FullTank,
            EngineStarted,
            Driving
        }

        public int Gasoline { get; set; }
        private CarState _state = CarState.EmtyTank;

        public void FillTank()
        {
            if (_state == CarState.EmtyTank)
            {
                _gasoline = 70;
                _state = CarState.FullTank;
                Console.WriteLine("Бак теперь полон");
            }
            else if (_state == CarState.FullTank)
            {
                Console.WriteLine("В меня столько не влезет");
            }
            else if (_state == CarState.EngineStarted)
            {
                Console.WriteLine("Нельзя заправляться с работающим двигателем");
            }
            else if (_state == CarState.Driving)
            {
                Console.WriteLine("Ты что, убить нас хочешь? Нельзя заправлять на ходу");
            }
        }

        public void TurnKey()
        {
            if (_state == CarState.EmtyTank)
            {
                Console.WriteLine("Без бензина не работаю");
            }
            else if (_state == CarState.FullTank)
            {
                _state = CarState.EngineStarted;
                Console.WriteLine("Дрын дын дын дны дын тррррр");
            }
            else if (_state == CarState.EngineStarted)
            {
                Console.WriteLine("Тссс. Передышка");
            }
            else if (_state == CarState.Driving)
            {
                Console.WriteLine("На ходу ключ не трогать");
            }
        }

        public void Drive()
        {
            if (_state == CarState.EmtyTank)
            {
                Console.WriteLine("Без бензина не еду");
            }
            else if (_state == CarState.FullTank)
            {
                Console.WriteLine("Сначала заведи меня");
            }
            else if (_state == CarState.EngineStarted)
            {
                _state = CarState.Driving;
                TryDriving();
            }
            else if (_state == CarState.Driving)
            {
                TryDriving();
            }
        }

        public void Stop()
        {
            if (_state == CarState.EmtyTank)
            {
                Console.WriteLine("Нет бензина - значит и так стоим");
            }
            else if (_state == CarState.FullTank)
            {
                Console.WriteLine("Я и так стою");
            }
            else if (_state == CarState.EngineStarted)
            {
                Console.WriteLine("Я и так стою");
            }
            else if (_state == CarState.Driving)
            {
                _state = CarState.EngineStarted;
                Console.WriteLine("Накатался? Ну давай постоиим");
            }
        }

        private void TryDriving()
        {
            if (_gasoline > 0)
            {
                Console.WriteLine("Поехали!");
                _gasoline -= 10;
            }
            else
            {
                Console.WriteLine("Докатились. Бензин кончился");
                _state = CarState.EmtyTank;
            }
        }
    }
}
