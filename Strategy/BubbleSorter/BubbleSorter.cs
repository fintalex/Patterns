﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.BubbleSorter
{
    public class BubbleSorterClass
    {
        private int operations = 0;
        private int length = 0;
        private SortHandler itsSortHandler = null;
        public BubbleSorterClass(SortHandler handler)
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
            for (int nextToLast = length - 2;
            nextToLast >= 0; nextToLast--)
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (itsSortHandler.OutOfOrder(index))
                        itsSortHandler.Swap(index);
                    operations++;
                }
            return operations;
        }
    }
}
