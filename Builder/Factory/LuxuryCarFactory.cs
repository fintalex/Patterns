using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Factory
{
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder)
            : base(builder)
        { }
        public override Car Construct()
        {
            CarBuilder.BuilderFrames();
            CarBuilder.BuilderEngine();
            CarBuilder.BuilderWheels();
            CarBuilder.BuilderSafety();
            CarBuilder.BuilderMuitimedia();
            CarBuilder.BuilderLuxury();

            return CarBuilder.GetCar();
        }
    }
}
