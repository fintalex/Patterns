using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    class ChocolateCondiment : CondimentsDecoratorBase
    {
         private BeverageBase _beverage;
         public ChocolateCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + "Chocolate";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 70;
        }
    }
}
