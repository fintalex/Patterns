using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.BubbleSorter
{
    //вариант пузырьковой сортировки, кото-
    //рый прекращал бы работу, как только на очередном проходе по массиву
    //выясняется, что он уже отсортирован
    public class QuickBubbleSorter
    {
        private int operations = 0;
        private int length = 0;
        private SortHandler itsSortHandler = null;

        public QuickBubbleSorter(SortHandler handler)
        {
            itsSortHandler = handler;
        }
        public int Sort(object array)
        {
            itsSortHandler.SetArray(array);
            length = itsSortHandler.Length();
            operations = 0;
            if (length <= 1)
                return operations;
            bool thisPassInOrder = false;
            for (int nextToLast = length-2; nextToLast >= 0 && !thisPassInOrder; nextToLast--)
            {
                thisPassInOrder = true; //potenially;
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (itsSortHandler.OutOfOrder(index))
                    {
                        itsSortHandler.Swap(index);
                        thisPassInOrder = false;
                    }
                    operations++;
                }
            }
            return operations;
        }
    }
}
