using System;

namespace IfBlokları
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = new string[7] {"pazatesi","salı","çarşamba","persembe","cuma","c.tesi","pazar"};

            foreach (var day in gunler)
            {

                if (day == "pazar")
                {
                    Console.WriteLine("bu gün tatil");
                }
                else
                {
                    Console.WriteLine(day);
                }
            }

            //if else blokları
            for (int i = 0; i < 6; i++)
            {
                var day = gunler[i];

                if (day == "pazartesi")
                {
                    Console.WriteLine("haftanın ilk günü");
                }
                else if (day == "salı") 
                {
                    Console.WriteLine("bu gün günlerden {0}  haftanın 2.günü",gunler[i]);
                } else if (day == "cuma")
                {
                    Console.WriteLine("bugün günlerden ...{0}  bizim bayramımız",gunler[i]);
                }
                Console.WriteLine("-----------------------------------------");
            }


            var number = 10;

            Console.WriteLine(number == 10 ? "sayı 10 dur" : "sayı 10 değildir");





        }

    }
}
