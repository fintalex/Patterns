using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class HotChocolate : BeverageBase
    {
        public HotChocolate()
        {
            Description = "Sweet hot chocolate";
        }

        public override double GetCost()
        {
            return 150 + base.GetCost();
        }

        public override bool HasMilk()
        {
            return true;
        }

        public override bool HasSugar()
        {
            return true;
        }

        public override bool HasChocolate()
        {
            return true;
        }
    }
}
