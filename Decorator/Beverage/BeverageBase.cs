using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    // Классы должны быть открыты к расширению и закрыты для изменений (OCP) - open/closed principle
    public abstract class BeverageBase
    {
        protected string Description = "";
        //protected double MilkPrice = 50;
        //protected double SugarPrice = 10;
        //protected double ChocolatePrice = 70;

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();

        //public abstract bool HasMilk();
        //public abstract bool HasSugar();
        //public abstract bool HasChocolate();
    }
}
