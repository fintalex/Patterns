using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    abstract class CarBuilderBase
    {
        protected Car Car;
        protected CarBuilderBase()
        {
            Car = new Car();
        }
        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuilderMuitimedia();
        public abstract void BuilderWheels();
        public abstract void BuilderEngine();
        public abstract void BuilderFrames();
        public abstract void BuilderLuxury();
        public abstract void BuilderSafety();
    }
}
