using System;

namespace TypesAndVariables_tipvedegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //burda veri tiplerini öğreneceğiz .. (Value Types = değer tipleri)
            //bunlar değer tiplerdir

            //1-byte bellekte 8 bitlik yer tutar 8bit=1byte dır. 0 ile 255 arası sayıları tutar
            // -255 te altını çizer 256 atarsak altını çizer
            //byte number1 = -255; //altı çizilir 
            //byte number1=256;  // altı  çizilir
            byte number1 = 255;
            Console.WriteLine("byte tipi number1 ....:{0}", number1);
            
            //2-short tip bellekte 16bitlik yer kaplar 2 byte lık
            //short number2 = -32768;//-32769 olursa altını çizer kabul etmez
            short number2 = 32767;//+olursa32767-32768 olursa kabul etmez
            Console.WriteLine("short tip number2 ....:{0}", number2);

            //3-int tip bellekte 32 bitlik yer kaplar.4 byte lık.
            //int number3 = -2147483648; ile + 2147483647 arası sayıları tutar
            int number3 = 2147483647;//2147483648 olursa altını çizer hata verir.
            Console.WriteLine("int veri tipi number3 ....:{0}", number3);


            //4-long veritipi 64bitlik yer kaplar 8 bytlık yer kaplar
            //long number4 = -9223372036854775807 ile +9223372036854775807 arasındaki sayıları tutar;
            long number4 = 9223372036854775807;
            Console.WriteLine("long veri tipi number4 .....:{0}", number4);
            
            //5-double veritipi ondalıklı sayıları tutmak için kullanılır 64 bit yer kaplar 4byte
            // doble veri tipinde virgülden sonra 15-16 charecter tutabilir
            double number5=10.1234567891234567;//virgülden sonra en fazla bu kadar
            Console.WriteLine("double veri tipi number5..:{0}", number5);

            //6-decimal veri tipi int için long ne ise double içinde decimal odur
            //daha hassas hesaplamalar için kullanılır virgülden sonra 28-29 charecter tutabilir
            decimal number6=10.123456789123456789123456789m;//virgülden sonra en fazla bu kadar 
            Console.WriteLine("decimal veri tipinde number6...:{0}", number6);


            //7-bool tipi mantısal veri tipidir - değer tipdir - true/false tutar
            // condition = durum - şart demek tir 
            bool condition = true;
            bool sart_durum = false;
            Console.WriteLine("bool veri tipi condition....:{0}", condition);
            Console.WriteLine("bool veri tipi sart_durum....:{0}", sart_durum);


            //8-char tipi veri sadece bir charecter tutar
            //bu veri tipi integer veri tipine dönüştütülebilir 
            char charecter = 'A';
            Console.WriteLine("char tipi charecter....:{0}", charecter);
            //var charecter1 = int('A'); böyle yapamadım bakıcam
            var charecter1 = (int)'B';
            Console.WriteLine("char tipi charecterin int e dönüşü ....:{0}", (int)charecter);
            Console.WriteLine("char tipi charecter1....:{0}..nin asci kodu..:{1}",(char)charecter1,charecter1);
            //for (int i = 65; i < 90; i++)
            //{
            //    Console.WriteLine((char)i+" => harfinin asci kodu ...:"+i+"   dir.");
            //}



            //enum 

            ////****enumu tam anlayamdık
            //var day = Days.carsamba;
            //string[] gunler = new string[7] { "a", "b", "c", "d", "e", "f", "g" };

            //Days.mumartesi;
            //Console.WriteLine((int)day);
















































            //ileri seviye oop konusu
            //x-1 implicit ve explicit operatörü;
            //MyClasss nesne = new MyClasss();
            //nesne.sayı = 15;
            //int c = (int)nesne;

            //Console.WriteLine(c);
        }
    }

    //x1
    class MyClasss
    {
        
        public int sayı;

        //public static implicit operator int(MyClasss a)
        //{
        //    return a.sayı;
        //}
        public static explicit operator int(MyClasss a)
        {
            return a.sayı;
        }

        
    }
    enum Days
    {
        pazartesi, salı, carsamba, persembe, cuma, mumartesi, pazar
    }
}
