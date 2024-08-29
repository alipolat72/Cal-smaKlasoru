using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "cep Telefonu";


            // gsm i evente abone etmek için gsm.StockKontrolEvent += yazıp tab tab yaparsak bize 
            //******************************************************
            //private static void Gsm_StockKontrolEvent()
            //{
            //    Console.WriteLine("gsm about to finish cep telefonu bitti");
            //}***************************************************************** bize yıldızların içini otmtk.yapar

            //Gsm.StockKontrolEvent += Gsm_StockKontrolEvent;
            //Harddisk.StockKontrolEvent+=
             gsm.StockKontrolEvent += Gsm_StockKontrolEvent;
            harddisk.StockKontrolEvent += Harddisk_StockKontrolEvent;

            for (int i = 0; i < 10; i++)
            { 
                
                 harddisk.Cell(10);
                 gsm.Cell(10);
                
               
                Console.ReadLine();
            }
        }

        private static void Harddisk_StockKontrolEvent()
        {
            Console.WriteLine("harddisk about to finish/ yanii / hard disk bitti");
        }

        private static void Gsm_StockKontrolEvent()
        {
            Console.WriteLine("gsm about to finish/ yanii / cep telefonu bitti");
        }
    }
}
