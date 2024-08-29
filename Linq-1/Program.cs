using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
              new Category{CategoryId=1,CategoryName="Bilgisayar" },
              new Category{CategoryId=2,CategoryName="Beyaz eşya"}
            };

            ProductManeger productManeger = new ProductManeger();
            productManeger.GetAll();

            Console.ReadLine();
        }
 


       

    }
    

    
}
