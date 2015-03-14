using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    class MilkCondiment : CondimentsDecoratorBase
    {
        public MilkCondiment( BeverageBase beverage)
            : base(beverage)
        {
            Description = _beverage.GetDescription() + "+milk";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 50;
        }
    }
}
