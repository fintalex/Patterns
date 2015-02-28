using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.BubbleSorter
{
    public interface SortHandler
    {
        void Swap(int index);
        bool OutOfOrder(int index);
        int Length();
        void SetArray(object array);
    }
}
