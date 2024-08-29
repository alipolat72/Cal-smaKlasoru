using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {


            //gerçek müşteri ---  Tüzel Müşteri

            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adı = "ali";
            gercekMusteri1.soyadı = "polat";
            gercekMusteri1.TcNo = "6545566";

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "2345";
            tuzelMusteri1.SirketAdı = "polat ticaret";
            tuzelMusteri1.VergiNo = 931256;

            Musteri musteri1 = new GercekMusteri();
            
            musteri1.

            Musteri musteri2 = new TuzelMusteri();




        }
    }
}
