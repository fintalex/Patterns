using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    // Классы должны быть открыты к расширению и закрыты для изменений (OCP) - open/closed principle

    // Наследование интерфейсов, а не поведения

    // композиция - для расширения поведения

    // Композиция дает свободу в режиме выполнения

    // вместо абстрактного класса может быть интерфейс - все зависи от изходной структуры

    public abstract class BeverageBase
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();
    }
}
