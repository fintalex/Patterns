using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public abstract class DuckBase
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        // метод для переопределения
        public abstract void Display();
    }
}
