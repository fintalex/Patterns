using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class FtoCTemplateMethod : Application
    {
        private TextReader input;
        private TextWriter output;

        static void Main(string[] args)
        {
            // имеет примерно такой цикл 
            //Initialize();
            //while (!Done()) // основной цикл
            //{
            //    Idle(); // сделать нечто полезное.
            //}
            //Cleanup();

            // ======  это стандартная реализация которую мы можем написамть в своих приложениях
            //bool done = false;
            //while (!done)
            //{
            //    string fahrString = Console.In.ReadLine();
            //    if (fahrString == null || fahrString.Length == 0)
            //        done = true;
            //    else
            //    {
            //        double fahr = double.Parse(fahrString);
            //        double celcius = 5.0 / 9.0 * (fahr - 32);
            //        Console.Out.WriteLine("F={0}, C={1}", fahr, celcius);
            //    }
            //    Console.Out.WriteLine("ftoc exit");
            //}

            new FtoCTemplateMethod().Run();
        }

        protected override void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        protected override void Idle()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
                SetDone();
            else
            {
                double fahr = double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine("F={0}, C={1}", fahr, celcius);
            }
        }

        protected override void Cleanup()
        {
            output.WriteLine("ftoc exit");
        }
    }

    // ======================== Template Method ==========================
    //Здесь представлена общая структура приложения с главным циклом.
    //Сам цикл находится в реализованном методе Run. А содержательная
    //работа вынесена в абстрактные методы Init, Idle и Cleanup. Метод Init
    //берет на себя инициализацию. Метод Idle выполняет основную работу
    //программы и вызывается до тех пор, пока Done() возвращает false. Ну
    //а метод Cleanup отвечает за очистку перед выходом.

    // применение данного класса в данном приложение глупо, но задачу отображает хорошо.
    public abstract class Application
    {
        private bool isDone = false;
        protected abstract void Init();
        protected abstract void Idle();
        protected abstract void Cleanup();
        protected void SetDone()
        {
            isDone = true;
        }
        protected bool Done()
        {
            return isDone;
        }
        public void Run()
        {
            Init();
            while (!Done())
                Idle();
            Cleanup();
        }
    }
}
