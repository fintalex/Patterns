using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Black tea from teabag";
        }
        public override double GetCost()
        {
            return 25;
        }

        //public override bool HasMilk()
        //{
        //    return false;
        //}

        //public override bool HasSugar()
        //{
        //    return false;
        //}

        //public override bool HasChocolate()
        //{
        //    return false;
        //}
    }
}
