using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public interface IState
    {
        void FillTank();
        void TurnKey();
        void Drive();
        void Stop();
    }
}
