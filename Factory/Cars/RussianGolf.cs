﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Cars
{
    public class RussianGolf : Car
    {
        public RussianGolf()
        {
            Name = "Golf";
            Body = "Hatchback";
            Engine = "Gasolin";
        }
    }
}
