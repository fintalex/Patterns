using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class FlyWithRocket : IFlyBehavior
    {

        public void Fly()
        {
            Console.WriteLine("I am a super duck, i am flying with rocket");
        }
    }
}
