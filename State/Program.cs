using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.FillTank();
            car.TurnKey();
            car.TurnKey();
            car.TurnKey();
            car.Drive();
            car.Stop();

            Console.ReadLine();
        }
    }
}
