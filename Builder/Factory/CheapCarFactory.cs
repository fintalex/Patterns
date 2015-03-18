using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Factory
{
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder)
            : base(builder)
        { }
        public override Car Construct()
        {
            throw new NotImplementedException();
        }
    }
}
