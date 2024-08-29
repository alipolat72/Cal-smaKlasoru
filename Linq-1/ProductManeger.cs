using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_1
{
    public class ProductManeger
    {
        List<Product> _products;  
        public ProductManeger()
        {
            //Product product = new Product();
             _products=new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="laptop",UnitPrice=5000,StockAmount=5 },
                new Product{ProductId=1,CategoryId=1,ProductName="Tablet",UnitPrice=7000,StockAmount=10 },
                new Product{ProductId=1,CategoryId=1,ProductName="Yazıcı",UnitPrice=5000,StockAmount=20 },
                new Product{ProductId=1,CategoryId=1,ProductName="buzdolabı",UnitPrice=6500,StockAmount=8 },
                new Product{ProductId=1,CategoryId=1,ProductName="çam.makinası",UnitPrice=5500,StockAmount=15 },
                new Product{ProductId=1,CategoryId=1,ProductName="bul.makinası",UnitPrice=4500,StockAmount=10 },
            };
            Console.WriteLine("constructor çalıştı");
            
        }

        public void GetAll()
        {
            List<Product> FilteredProducts = new List<Product>();

            foreach (var p in _products )
            {
                if(p.UnitPrice>=5000 && p.StockAmount >= 10)
                {
                    FilteredProducts.Add(p);
                    Console.WriteLine(p.ProductName);
                    Console.WriteLine(p.UnitPrice);
                }
            }

            foreach (var p in FilteredProducts)
            {
                Console.WriteLine(p.ProductName);
                Console.WriteLine(p.UnitPrice);
            }




          
            Console.WriteLine("************************");

            
            var result = _products.Where(p => p.UnitPrice >= 5000 && p.StockAmount > 15);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
                Console.WriteLine(p.UnitPrice);

            }

        }

         
   

       
    }
}
