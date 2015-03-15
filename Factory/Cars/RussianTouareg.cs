using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class RussianTouareg : Car
    {
        public RussianTouareg()
        {
            Name = "Touareg";
            Body = "Big Crossover";
            Engine = "Gasolin";
        }
    }
}
