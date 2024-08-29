using İnterFace_3.Abstract;
using İnterFace_3.Entity;
using İnterFace_3.İnMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_3.Concrate
{
    public class CategoryDal :ICategory
    {
        InMemoryCategoryDal categoryDal = new InMemoryCategoryDal();
        public void Add(Category entity)
        {
            Console.WriteLine("category Add Çalıştı");
        }

        public void Delete(Category entity)
        {
            Console.WriteLine("category Add Çalıştı");
        }

        public List<Category> GetAll()
        {
            Console.WriteLine("Category GetAll metoduna girdi");
            return categoryDal.GetAll();
            
        }


    }
    

}
