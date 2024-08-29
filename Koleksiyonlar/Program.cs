using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "murat", "kerem", "ali" };
            Listele(isimler);
            
            isimler.Add("veli");
            isimler.Add("ömer");
            Listele(isimler);
            isimler.Remove("ali");
            Listele(isimler);
        }

        static void Listele(List<string> isimler)
        {
            var ı = 1;
            foreach (var isim in isimler)
            {
                Console.WriteLine(ı+"."+isim);
                ı++;
            }
            Console.WriteLine("*******************");
        }
    }
}
