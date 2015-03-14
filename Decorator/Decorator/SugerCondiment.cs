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
        private BeverageBase _beverage;
        public SugerCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + "+Sugar";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 10;
        }
    }
}
