using System;
using System.Collections.Generic;

namespace ConstructorList

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılar1 = new List<int>();

            sayılar1 = new List<int>{ 1, 2, 3, 4, 5, 6 };

            List<string> isimler = new List<string> { "Ali", "Veli", "Hasan", "Hüseyin", "Ayşe" };

            CustomerManeger customer = new CustomerManeger();

            customer.SayıListele(sayılar1);
            customer.İsimListele(isimler);

            sayılar1.Add(7);
            isimler.Add("sena");
            customer.SayıListele(sayılar1);
            customer.İsimListele(isimler);
            Console.WriteLine("****************");
            isimler.Remove("Veli");
            customer.İsimListele(isimler);

            Listele(sayılar1);

           











        }






        static int SayıTopla(int sayı1, int sayı2)
        {
            int sonuc = sayı1 + sayı2;
            return sonuc;
        }

        static void Listele(List<int> sayılar)
        {
            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
