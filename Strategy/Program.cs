using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.BubbleSorter;

namespace Strategy
{
    public class FtoCStrategy : Application
    {
        private TextReader input;
        private TextWriter output;
        private bool isDone = false;

        public static void Main(string[] args)
        {
            //(new ApplicationRunner(new FtoCStrategy())).run();

            IntSortHandler intSortHandl = new IntSortHandler() ;
            
            QuickBubbleSorter qbs = new QuickBubbleSorter(intSortHandl);
            int op1 = qbs.Sort(new int[] { 5, 23, 44, 15, 34 });

            BubbleSorterClass bs = new BubbleSorterClass(new IntSortHandler());
            int op2 = bs.Sort(new int[] { 5, 23, 44, 15, 34 });
        }

        public void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        public void Idle()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
                isDone = true;
            else
            {
                double fahr = Double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine("F={0}, C={1}", fahr, celcius);
            }
        }

        public void Cleanup()
        {
            output.WriteLine("ftoc exit");
        }

        public bool Done()
        {
            return isDone;
        }
    }
}
