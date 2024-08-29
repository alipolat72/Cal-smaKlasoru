using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorList
{
    public class CustomerManeger
    {
        public void SayıListele(List<int> sayılar)
        {
            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
        }

        public void İsimListele(List<string> isimler)
        {
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
