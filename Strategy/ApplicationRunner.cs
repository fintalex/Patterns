using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // помещаем общий алгориттм в отдельный класс ( не абстрактный)
    // все методы абстрактного прошлого мтеода помещены в интерфейс Application

    public class ApplicationRunner
    {
        private Application itsApplication = null;

        public ApplicationRunner(Application app)
        {
            itsApplication = app;
        }

        public void run()
        {
            itsApplication.Init();
            while (!itsApplication.Done())
                itsApplication.Idle();
            itsApplication.Cleanup();
        }
    }
}
