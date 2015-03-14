using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase greenTea = new GreenTea();
            BeverageBase blackTea = new BlackTea();
            BeverageBase espresso = new Espresso();

            Console.WriteLine("Beverage: {0}; Price: {1}", blackTea.GetDescription(), blackTea.GetCost());
            Console.WriteLine("hotChocolate: {0}; Price: {1}", greenTea.GetDescription(), greenTea.GetCost());
            Console.WriteLine("espresso: {0}; Price: {1}", espresso.GetDescription(), espresso.GetCost());

            Console.WriteLine("------");

            BeverageBase capuccino = new SugerCondiment(new MilkCondiment(new Espresso()));
            Console.WriteLine("capuccino: {0}; Price: {1}", capuccino.GetDescription(), capuccino.GetCost());

            BeverageBase greanTeaWithSugar = new SugerCondiment(new GreenTea());
            Console.WriteLine("greanTeaWithSugar: {0}; Price: {1}", greanTeaWithSugar.GetDescription(), greanTeaWithSugar.GetCost());

            Console.ReadLine();
        }
    }
}
