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
