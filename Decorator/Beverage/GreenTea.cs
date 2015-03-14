using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class GreenTea : BeverageBase
    {
        public GreenTea()
        {
            Description = "Green leaf tea";
        }

        public override double GetCost()
        {
            return 125;
        }
    }
}
