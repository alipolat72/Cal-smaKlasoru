using System;
using System.Collections.Generic;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            product1.Id = 1;
            product1.ProductName = "elma1";
            product1.Fiyat = 10;
            product1.Acıklama = "kışlık elma1";

            product2.Id = 2;
            product2.ProductName = "elma2";
            product2.Fiyat = 20;
            product2.Acıklama = "kışlık elma2";

            product3.Id = 3;
            product3.ProductName = "elma3";
            product3.Fiyat = 30;
            product3.Acıklama = "kışlık elma3";


            //Product[] liste= new  Product[] {product1, product2, product3};

            //foreach (var urun in liste)
            //{                                                       
            //    Console.WriteLine(urun.ProductName);
            //    Console.WriteLine(urun.Fiyat);
            //    Console.WriteLine(urun.Acıklama);
            //}
            //Console.WriteLine("------------------------------------------------------");
            
            Product product4 = new Product();

            product4.Id = 4;
            product4.ProductName = "elma4";
            product4.Fiyat = 40;
            product4.Acıklama = "kışlık elma4";

            //Product[] liste2 = new Product[] { product4 };

            //foreach (var urun in liste2)
            //{
            //    Console.WriteLine(urun.ProductName);
            //    Console.WriteLine(urun.Fiyat);
            //    Console.WriteLine(urun.Acıklama);
            //}


            List<Product> list = new List<Product> { product1, product2 };

            Listele(list);

            list.Add(product3);
            Console.WriteLine("------------------------------------------------------------");

            Listele(list);

            // yeni ürün ekleyelim
            list.Add(product4);
            Console.WriteLine("------------------------------------------------------------");
            //ve listeleyelim burda Listele metodunu kullanacağız
            Listele(list);

            SepetManeger sepetManeger = new SepetManeger();

            sepetManeger.Add();


            Topla(5, 6);

            Console.WriteLine(Topla(5, 6));

            Console.WriteLine("Topla(5, 6);  ne yazdı...?");

            Console.WriteLine("parametreli metod da sayı2 yi girmedik..:"+Carp(15));

            Console.WriteLine("parametreli metod da sayı2 ye 5 girdik..:" + Carp(15,5));


            Console.WriteLine("parametreli metod 3 sayı girilmesi lazım " + Topla1(2));





        }

        static void Listele(List<Product> product)
        {
            foreach (var urun in product)
            {
                Console.WriteLine(urun.ProductName);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Acıklama);
            }
        }



        static int Topla(int sayı1,int sayı2)
        {
            var result = sayı1 + sayı2;
            return result;
            
            //return sayı1 + sayı2;
        }
        // parametreli metod eğer sayı2 verilmezse direkt 10 olur
        static int Carp(int sayı1, int sayı2=10)
        {
            var result = sayı1 * sayı2;
            return result;

            //return sayı1 + sayı2;
        }

        static int Topla1(int x,int sayı1=10,int sayı2 = 5)
        {
            var result = x + sayı1 + sayı2;
            return result;
        }

    }
}
