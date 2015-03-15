using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            _flyBehavior = new NoFly();
            _quackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }
}
