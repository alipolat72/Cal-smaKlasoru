using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_1
{
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string TcNo { get ; set; }
       
        public string Address { get; set; }
    }
}
