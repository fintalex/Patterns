using StrategyDucks.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
            }

            Console.ReadLine();
        }
    }
}
