using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOracleMysqal
{
    public class SqlServer : ICustomerDal
    {
        public void Add()
        {
           
            Console.WriteLine("sqlservere eklendi");
            
        }

        public void Delete()
        {
            Console.WriteLine("sqlserver dan silindi");
        }

        public void Update()
        {
            Console.WriteLine("sqlserver da güncellendi");
        }
    }
}
