using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_3.İnMemory
{
    public class InMemoryProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
             _products = new List<Product> { new Product {ProductId=1, CategoryId=1,ProductName="kitap"},
                                            new Product {ProductId=2, CategoryId=1,ProductName="Defter"},
                                            new Product {ProductId=1, CategoryId=2,ProductName="laptop"},
                                            new Product {ProductId=2, CategoryId=2,ProductName="klavye"},
                                            new Product {ProductId=5, CategoryId=3,ProductName="buzdolabı" } };
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

    }
}
