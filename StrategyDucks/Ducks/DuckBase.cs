using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyBehavior _flyBegavior;
        protected IQuackBehavior _quackBehavior;

        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        // метод для переопределения
        public abstract void Display();
    }
}
