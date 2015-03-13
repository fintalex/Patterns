using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase capuccino = new Capuccino();
            BeverageBase hotChocolate = new HotChocolate();
            BeverageBase espresso = new Espresso();

            Console.WriteLine("Beverage: {0}; Price: {1}", capuccino.GetDescription(), capuccino.GetCost());
            Console.WriteLine("hotChocolate: {0}; Price: {1}", hotChocolate.GetDescription(), hotChocolate.GetCost());
            Console.WriteLine("espresso: {0}; Price: {1}", espresso.GetDescription(), espresso.GetCost());

            Console.ReadLine();
        }
    }
}
