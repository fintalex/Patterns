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
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
                Console.WriteLine("=====");
            }

            DuckBase transformer = new TransformerDuck();
            transformer.Display();
            transformer.Swim();
            transformer.Quack();
            transformer.Fly();

            // после того как наш трансформер утка научилась летать и квакать
            transformer.SetFlyBehavior(new FlyWithRocket());
            transformer.SetQuackBehavior(new ExoticQuack());
            transformer.Quack();
            transformer.Fly();

            Console.ReadLine();
        }
    }
}
