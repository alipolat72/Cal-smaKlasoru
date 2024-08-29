using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Generic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="laptop",UnitPrice=5000,StockAmount=5 },
                new Product{ProductId=2,CategoryId=1,ProductName="Tablettop",UnitPrice=7000,StockAmount=10 },
                new Product{ProductId=3,CategoryId=1,ProductName="Yazıcı top",UnitPrice=6000,StockAmount=20 },
                new Product{ProductId=4,CategoryId=2,ProductName="buzdolabı",UnitPrice=6500,StockAmount=8 },
                new Product{ProductId=5,CategoryId=2,ProductName="çam.makinası",UnitPrice=6000,StockAmount=15 },
                new Product{ProductId=6,CategoryId=2,ProductName="bul.makinası",UnitPrice=4500,StockAmount=10 },
                new Product{ProductId=7,CategoryId=4,ProductName="salon takımı",UnitPrice=15500,StockAmount=5 },
                new Product{ProductId=8,CategoryId=3,ProductName="büfe takımı",UnitPrice=16000,StockAmount=4 },
                new Product{ProductId=9,CategoryId=3,ProductName="oturma gurubu",UnitPrice=14500,StockAmount=6 }
            };


            ListeYap(product);
            cizgi();
            int  silinecekOlanId = 4 ;

            ListedenSil(silinecekOlanId,product);

            //ListeYap(product);
            // LİNQ Language Intagreted Query
            //      Dile     Gömülü     Sorgulama


        }
      
        
           static void  ListeYap(List<Product> products)
           {
                foreach (var p in products)
                {
                    Console.WriteLine(p.ProductId + " " + p.ProductName + " ...:" + p.UnitPrice);
                    
                }
            }

           static void ListedenSil(int id,List<Product> products)
           {
            Product productToDelette=null;
            //foreach (var p in products)
            //{
            //    if (p.ProductId == id)
            //    {
            //        Console.WriteLine(p.ProductId + " " + p.ProductName + " ...:" + p.UnitPrice);
            //        Console.WriteLine("silinecek olan ürün adı"); Console.ReadLine();
            //        productToDelette = p;
            //    }
            //}
            //products.Remove(productToDelette);
            //              tek bir eleman bulmaya yarar =>bu işerete lambda denir 
                       
            //productToDelette = products.SingleOrDefault(p=>p.ProductId==id);
            productToDelette = products.First(p => p.ProductId == id);
           // iki şekilde ürün aranabilir ister SingleOrDefault ister First  
            products.Remove(productToDelette);
            foreach (var p in products)
            {
                Console.WriteLine(p.ProductId + " " + p.ProductName + " ...:" + p.UnitPrice);
               
            }
           
        }



           static void cizgi()
           {
                    Console.WriteLine("------------------------------");
           }
    }
    class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockAmount { get; set; }
    }
}