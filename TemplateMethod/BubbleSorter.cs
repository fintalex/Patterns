using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    #region without Template Method
    //public class BubbleSorter
    //{
    //    static int operations = 0;

    //    public static int Sort(int[] array)
    //    {
    //        operations = 0;
    //        if (array.Length <= 1)
    //            return operations;
    //        for (int nextToLast = array.Length-2; nextToLast >=0; nextToLast--)
    //        {
    //            for (int index = 0; index <= nextToLast; index ++)
    //                CompareAndSwap(array, index);
    //        }
    //        return operations;
    //    }

    //    private static void Swap(int[] array, int index)
    //    {
    //        int temp = array[index];
    //        array[index] = array[index + 1];
    //        array[index + 1] = temp;
    //    }
    //    private static void CompareAndSwap(int[] array, int index)
    //    {
    //        if (array[index] > array[index+1])
    //        {
    //            Swap(array, index);
    //        }
    //        operations++;
    //    }
    //} 
    #endregion

    public abstract class BubbleSorter
    {
        private int operations = 0;
        protected int length = 0;

        protected int DoSort()
        {
            operations = 0;
            if (length <= 1)
                return operations;
            for(int nextToLast = length - 2; nextToLast >= 0; nextToLast --)
            {
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (OutOfOrder(index))
                        Swap(index);
                    operations++;
                }
            }
            return operations;
        }
        protected abstract void Swap(int index);
        protected abstract bool OutOfOrder(int index);
    }
    // а вот теперь, когда у нас уже есть выделенные абстрактный метод, 
    // мы можем создавать производные классы например IntBubbleSorter или DoubleBubbleSorter

    // Но этой техникой сопряжены издержки. Наследование – очень сильное
    //отношение. Подклассы оказываются неразрывно связаны со своими ба-
    //зовыми классами.
}
