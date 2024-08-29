using System;

namespace Oop2
{
    class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("dosyaya  loglama yapıldı");
        }
    }
}
