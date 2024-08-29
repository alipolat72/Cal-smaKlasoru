using System;
using System.Collections.Generic;

namespace Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {    // 1. dizi tanımlama şekli
             //string[] students = new string[2];

            //students[0] = "ali";
            //students[1] = "veli";

            // 2.dizi tanımlama şekli
            // string[] students=new []{"ali,"veli"};(şeklindede diziyi tanımlayabiliriz)

            // 3. dizi tanımlama şekli
            //string[] students = { "ali", "veli","selami"};

            // 4ç dizi tanımlama şekli aşağıda sayıları tırnak içinde kullandığımız için string olarak değerlendirdi.
            string[] students = new string[] { "ali", "veli", "selami","12345"};

            Diziler diziler = new Diziler();
            diziler.ListStudents(students);

            //*****************************************************************************************************
            //  ç o k   b o y u t l u    d i z i l e r 
            string[] bolgeler = new string[] { "içanadolu", "ege", "karadeniz"};
            string[,] regions = new string[3, 3]
            {
                {"ankara","sivas","çorum" },
                { "izmir","denizli","afyon" },
                { "samsun","rize","sinop" }
            };

            //for(var j = 0; j < 3; j++)
            //{
            //    for (int i = 0; i <3 ; i++)
            //    {
            //        Console.WriteLine(regions[j, i]);
            //    }
            //}
           
            
            // GetUpperBound ile listeleme
           
            for (var j = 0; j <= regions.GetUpperBound(0); j++)
            {
                Console.WriteLine(bolgeler[j]+" Bölgesi illeri");
                Console.WriteLine("--------------");
                for (int i = 0; i <= regions.GetUpperBound(0); i++)
                {
                    Console.WriteLine(regions[j, i]);
                }
                Console.WriteLine("****************************");
            }


            //while döngüsü

            int number = 0;
            while(number > 100)// number yüzden büyükmü hayır işlem yok
            {
                Console.WriteLine("sayı :" + number);
                number++;
            }

            int number1 = 1;
            while (number1 < 10)// number1 yüzden küçükmü evet işlem var
            {
                Console.WriteLine("sayı :" + number1);
                number1+=2;
            }

            Console.ReadLine();

        }

       

       

    }
}
