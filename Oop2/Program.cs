using System;
using System.Collections.Generic;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
             IKrediManeger ihtiyacKredi = new IhtiyacKrediManeger();

            ihtiyacKredi.Hesapla();
            ihtiyacKredi.Listele();

            IKrediManeger tasıtKredi= new TasıtKrediManeger();
            tasıtKredi.Hesapla();
            tasıtKredi.Listele();

             IKrediManeger konutKredi= new KonutKrediManeger();
            konutKredi.Hesapla();
            konutKredi.Listele();
            Console.WriteLine("********* loglama alanı*************************");
            
            BasvuruManeger basvuruManeger = new BasvuruManeger();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService SmsLoggerService = new SmsLoggerService();

            //1-yazım şekli loglama eklenmesi için
            basvuruManeger.BasvuruYap(ihtiyacKredi, databaseloggerService);
            
            //2-yazım şekli loglama eklenmesi için burda direkt newleniyor
            basvuruManeger.BasvuruYap(konutKredi,new FileLoggerService());

            basvuruManeger.BasvuruYap(new EsnafKrediManeger(), new DatabaseLoggerService());

            Console.WriteLine("************ loglama alanı son**********************");

            //basvuruManeger.BasvuruYap(tasıtKredi);

            //basvuruManeger.BasvuruYap(konutKredi);

            List<IKrediManeger> krediListe= new List<IKrediManeger> {konutKredi,ihtiyacKredi };

            basvuruManeger.KrediOnBilgilendirmesiYap(krediListe);


            


        }
    }
}
