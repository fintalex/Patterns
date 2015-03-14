using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    class SugerCondiment : CondimentsDecoratorBase
    {
        public SugerCondiment(BeverageBase beverage)
            :base(beverage)
        {
            Description = _beverage.GetDescription() + "+Sugar";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 10;
        }
    }
}
