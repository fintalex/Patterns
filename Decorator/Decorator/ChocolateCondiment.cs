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
         
        public ChocolateCondiment(BeverageBase beverage)
            : base(beverage)
        {
            Description = _beverage.GetDescription() + "Chocolate";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 70;
        }
    }
}
