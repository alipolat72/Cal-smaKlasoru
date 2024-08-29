using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> sehirler = new List<string>();


            //ulkeler.Add("Türkiye");
            //ulkeler.Add("Almanya");
            //ulkeler.Add("mısır");
            //ulkeler.Add("fransa");

            // List<string> ulkeler=new List<string>{"türkiye","almanya","mısır","fransa","italya"};
            MyList<string> isimler= new MyList<string>();

            isimler.Add("ali");
            Console.WriteLine(isimler.Length);

            isimler.Add("veli");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            //Console.WriteLine(ulkeler[0]);
            //Console.WriteLine(ulkeler[1]);
            //Console.WriteLine(ulkeler[2]);
            //Console.WriteLine(ulkeler[3]);
            //Console.WriteLine(ulkeler[4]);





            Console.ReadLine(); 
        }
    }
}
