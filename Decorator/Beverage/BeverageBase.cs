using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    public abstract class BeverageBase
    {
        protected string Description = "";
        protected double MilkPrice = 50;
        protected double SugarPrice = 10;
        protected double ChocolatePrice = 70;

        public string GetDescription()
        {
            return Description;
        }

        public virtual double GetCost()
        {
            double cost = 0;
            if (HasMilk())
                cost += MilkPrice;
            if (HasSugar())
                cost += SugarPrice;
            if (HasChocolate())
                cost += ChocolatePrice;
            return 0;
        }

        public abstract bool HasMilk();
        public abstract bool HasSugar();
        public abstract bool HasChocolate();
    }
}
