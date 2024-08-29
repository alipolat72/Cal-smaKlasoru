using İnterFace_3.Concrate;
using System;

namespace İnterFace_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            Console.WriteLine("--------------------------------------------");
            CategoryTest();









        }

        private static void CategoryTest()
        {
            CategoryDal categoryDal = new CategoryDal();
            foreach (var c in categoryDal.GetAll())
            {
                Console.WriteLine(c.CategoryId + "/" + c.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductDal productDal = new ProductDal();
            

            foreach (var p in productDal.GetAll())
            {
                Console.WriteLine(p.ProductId + " / " + p.ProductName);
            }
        }
    }
    
}
