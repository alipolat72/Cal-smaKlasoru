using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="bilgisayar"},
                new Category{CategoryId=2,CategoryName="beyaz Eşya"},
                new Category{CategoryId=3,CategoryName="mobilya"}
            };

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

            //foreach (var p in product)
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            cizgi();
            //AnyTest(product);
            //**************************************************
            // Linq te Find 
            //string arananUrun = "laptop";
            //UrunBul(arananUrun, product) ;
            //**************************************************
            //linq te FindAll
            //FindAll(product);
            //**************************************************
            // AscDsc(product);
            //Select(product);

            var result = from p in product
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.CategoryId==1
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId,CategoryName = c.CategoryName,
                                                ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var p in result)
            {
               
                Console.WriteLine(p.CategoryName);
                Console.WriteLine(p.ProductName);
                Console.WriteLine(p.UnitPrice);
            }


        }

        private static void Select(List<Product> product)
        {
            var result1 = from p in product
                          select p;
            foreach (var p in result1)
            {
                Console.WriteLine(p.ProductName);
            }
            cizgi();
            var result2 = from p in product
                          where p.UnitPrice > 5000 && p.StockAmount >= 10
                          select p;
            foreach (var p in result2)
            {
                Console.WriteLine(p.ProductName);
            }
            cizgi();
            var result3 = from p in product
                          where p.UnitPrice > 5000 && p.StockAmount >= 10
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select p;
            foreach (var p in result3)
            {
                Console.WriteLine(p.ProductName + "  fiyat..:" + p.UnitPrice);
            }
        }

        private static void AscDsc(List<Product> product)
        {
            var aranan = "top";
            var result1 = product.Where(p => p.ProductName.Contains(aranan)).OrderBy(p => p.UnitPrice);
            foreach (var p in result1)
            {
                Console.WriteLine(p.ProductName + "...:fiyatı..:" + p.UnitPrice);
            }
            cizgi();
            var result2 = product.Where(p => p.ProductName.Contains(aranan)).OrderByDescending(p => p.UnitPrice);
            foreach (var p in result2)
            {
                Console.WriteLine(p.ProductName + "...:fiyatı..:" + p.UnitPrice);
            }
            cizgi();

            var result = product.Where(p => p.ProductName.Contains(aranan)).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName + "...:fiyatı..:" + p.UnitPrice);
            }
        }

        private static void FindAll(List<Product> product)
        {
            var result = product.FindAll(p => p.ProductName.Contains("nası"));
            Console.WriteLine(result);

            foreach (var p in result)
            {

                Console.WriteLine(p.ProductName);
            }
        }

        private static void AnyTest(List<Product> product)
        {
            var result = product.Any(p => p.ProductName == "laptop");

            Console.WriteLine(result);
            if (result == true)
            {
                Console.WriteLine("result true ");
            };
        }

        static void UrunBul(string aranan,List<Product> product)
        {
            //foreach (var p in product)
            //{
            //    Console.WriteLine(p.ProductName);
            //}
            var result = product.Find(p => p.ProductName == aranan);
            if (result == null)
            {
                Console.WriteLine("bu ürün bulunamadı");
                return;
            }
            else
            {
                Console.WriteLine("Arana Ürün olan " + result.ProductName + "'nın  Liste fiyatı...:" + result.UnitPrice);
            }
        }

        static void cizgi()
        {
            Console.WriteLine("------------------------------");
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }

        public string  CategoryName { get; set; }

        public string  ProductName { get; set; }

        public decimal UnitPrice { get; set; }
    }




    class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
      
}
