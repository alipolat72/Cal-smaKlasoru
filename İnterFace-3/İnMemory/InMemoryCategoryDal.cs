using İnterFace_3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_3.İnMemory
{
    class InMemoryCategoryDal
    {

        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category> { new Category { CategoryId=1,CategoryName="kırtasiye"},
                                                   new Category {CategoryId=2,CategoryName="bilgisayar"},
                                                   new Category {CategoryId=3,CategoryName="beyazeşya"}};
        }
         
        public List<Category> GetAll()
        {
            return _categories;
        }

    }
}
