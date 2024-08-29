using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] cities =new string[] { "ankara","izmir","samsun"};
            
            Listeler listeler = new Listeler();
            listeler.Sehirler(cities);

            var cities1 = cities;
            cities = new string[5];
            cities[0] = "ali";
            cities[1] = "veli";
            cities[2] = cities1[0];
            cities[3] = cities1[1];
            cities[4] = cities1[2];
           // cities = cities1;
            Console.WriteLine("********************");
            listeler.Sehirler(cities);
             

        }
    }
}
