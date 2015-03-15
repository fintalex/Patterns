using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class FlyWithWings : IFlyBehavior
    {

        public void Fly()
        {
            Console.WriteLine("I am flying with wings");
        }
    }
}
