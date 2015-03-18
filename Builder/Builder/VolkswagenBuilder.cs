using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder()
            : base()
        { }



        public override void BuilderMuitimedia()
        {
            Car.Multimedia = "VW Rns 510";
        }

        public override void BuilderWheels()
        {
            Car.Wheels = "17\" VW Wheel";
        }

        public override void BuilderEngine()
        {
            Car.Engine = "1.8 TSI";
        }

        public override void BuilderFrames()
        {
            Car.Frame = "VW frame";
        }

        public override void BuilderLuxury()
        {
            Car.Luxury = "VW R-style";
        }

        public override void BuilderSafety()
        {
            Car.Safety = "VW Lane Assist";
        }
    }
}
