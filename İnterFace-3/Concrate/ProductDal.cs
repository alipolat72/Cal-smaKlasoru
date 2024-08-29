using İnterFace_3.İnMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_3
{
    public class ProductDal :  IProduct
    {
        
       InMemoryProductDal products = new InMemoryProductDal();

        public void Add(Product entity)
        {
            Console.WriteLine("Product Dal Add metodu çalıitı");
        }

        public void Delete(Product entity)
        {
            Console.WriteLine("Product Dal Delete metodu çalıitı");
        }

        public List<Product> GetAll()
        {
            Console.WriteLine("Product GetAll metoduna girdi");
            return products.GetAll();
        }

































        ////public ProductDal() => Console.WriteLine("productDal yapıcı method constructer çalıştı");
        //public void Add()
        //{
        //    Console.WriteLine("Product Dal Add metodu çalıitı");
        //}

        //public void Delete()
        //{
        //    Console.WriteLine("Product Dal Delete metodu çalıitı");
        //}


        //public List<Product> GetAll()
        //{
        //     
        //}
    }
}
