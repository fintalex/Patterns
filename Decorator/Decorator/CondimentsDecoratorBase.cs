

namespace Decorator.Decorator
{
    abstract class CondimentsDecoratorBase : Beverage.BeverageBase
    {
        protected Beverage.BeverageBase _beverage;
        public CondimentsDecoratorBase(Beverage.BeverageBase beverage)
        {
            _beverage = beverage;
        }
    
    }   
}
