using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class RussianTiguan : Car
    {
        public RussianTiguan()
        {
            Name = "Tiguan";
            Body = "Sedan";
            Engine = "Gasolin";
        }
    }
}
