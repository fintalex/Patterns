using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi, i am a wooden duck");
        }
    }
}
