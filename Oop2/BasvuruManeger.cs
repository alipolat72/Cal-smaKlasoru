using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class BasvuruManeger 
    {    //                                               burası metodh injection (dependent injection) 
        public void BasvuruYap(IKrediManeger krediManeger,ILoggerService loggerService)
        {
            // müsteri adı soyadı kredi türü v.s. bilgiler alınır
            //KonutKrediManeger krediManeger = new KonutKrediManeger();
            //Console.WriteLine(mesaj);
            //krediManeger.Hesapla();

            krediManeger.Hesapla();
            loggerService.log();

         }  
            public void KrediOnBilgilendirmesiYap(List<IKrediManeger> krediler)
            {
            foreach (var kredi in krediler)
            {
                Console.WriteLine("*********************************");
                kredi.Hesapla(); 
            }

            }

            



       
    }
}
