using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class DatabaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("veri tabanına  loglama yapıldı");
        }
    }
}
