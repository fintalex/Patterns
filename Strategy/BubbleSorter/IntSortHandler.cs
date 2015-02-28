using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.BubbleSorter
{
    // класс IntSortHandler ничего не знает о BubbleSorter и никак
    //не зависит от реализации пузырьковой сортировки
    public class IntSortHandler : SortHandler
    {
        private int[] array = null;

        public void Swap(int index)
        {
            // замена
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        public void SetArray(object array)
        {
            this.array = (int[])array;
        }
        public bool OutOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }

        public int Length()
        {
            return array.Length;
        }
    }
}
