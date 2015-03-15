using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class TransformerDuck:DuckBase
    {
        // по умолчанию ниче не умеет
        public TransformerDuck()
        {
            _flyBehavior = new NoFly();
            _quackBehavior = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am transformer duck");
        }
    }
}
