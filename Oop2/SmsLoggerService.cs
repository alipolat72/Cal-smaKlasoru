using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class SmsLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("smsle loglama yapıldı");
        }
    }
}
