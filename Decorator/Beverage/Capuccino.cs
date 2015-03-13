using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class Capuccino : BeverageBase
    {
        public Capuccino()
        {
            Description = "Coffee with steamed milk";
        }

        public override double GetCost()
        {
            return 100 + base.GetCost();
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
            return false;
        }
    }
}
