﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            _quackBehavior = new ExoticQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I am exotic duck");
        }
    }
}
