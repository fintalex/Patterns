using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = "Small portion of strong coffee";
        }
        public override double GetCost()
        {
            return 150;
        }
    }
}
