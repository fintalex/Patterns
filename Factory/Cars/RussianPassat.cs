using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class RussianPassat : Car
    {
        public RussianPassat()
        {
            Name = "Passat";
            Body = "Sedan";
            Engine = "Gasolin";
        }
    }
}
