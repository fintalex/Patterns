using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public DuckBase()
        {
            _flyBehavior = new FlyWithWings(); // по умолчанию все летают
            _quackBehavior = new Quack(); // по умолчанию все квакают
        }
        public void Quack()
        {
            _quackBehavior.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
         {
             _flyBehavior = flyBehavior;
         }

        // метод для переопределения
        public abstract void Display();
    }
}
