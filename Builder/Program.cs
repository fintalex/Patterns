using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vwBuilder = new VolkswagenBuilder();
            vwBuilder.BuilderEngine();
            vwBuilder.BuilderFrames();
            vwBuilder.BuilderWheels();

            var car = vwBuilder.GetCar();
            Console.WriteLine(car);

            vwBuilder.BuilderMuitimedia();
            car = vwBuilder.GetCar();
            Console.WriteLine(car);

            vwBuilder.BuilderSafety();
            car = vwBuilder.GetCar();
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
