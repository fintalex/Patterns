using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Factory
{
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase CarBuilder;
        protected CarFactoryBase (CarBuilderBase builder)
        {
            CarBuilder = builder;
        }
        public abstract Car Construct();
    }
}
