using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Application
    {
        void Init();
        void Idle();
        void Cleanup();
        bool Done();
    }
}
