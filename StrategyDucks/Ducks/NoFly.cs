using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDucks.Ducks
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            // ничего не делаем. Просто не умеем летать.
        }
    }
}
