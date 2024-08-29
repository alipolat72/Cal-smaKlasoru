using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_3.Repositorys
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);

        void Delete(T entity);

        public List<T> GetAll();

    }
}
