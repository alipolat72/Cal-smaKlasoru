using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOracleMysqal
{
    public class MySqelServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySqel added");
        }

        public void Delete()
        {
            Console.WriteLine("MySqel Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySqel Updated");
        }
    }
}
