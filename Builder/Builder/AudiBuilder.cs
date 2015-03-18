using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder()
            : base()
        { }



        public override void BuilderMuitimedia()
        {
            Car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuilderWheels()
        {
            Car.Multimedia = "18\" Audi Wheel";
        }

        public override void BuilderEngine()
        {
            Car.Multimedia = "2.0 TFSI";
        }

        public override void BuilderFrames()
        {
            Car.Multimedia = "Audi frame";
        }

        public override void BuilderLuxury()
        {
            Car.Multimedia = "Audi Exclusive Interior";
        }

        public override void BuilderSafety()
        {
            Car.Multimedia = "Side Assist";
        }
    }
}
