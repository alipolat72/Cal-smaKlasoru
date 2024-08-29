using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Listeler
    {
        public Listeler()
        {
            string[] cities = new string[] { "ankara", "izmir", "samsun" };
        }


        
        public void Sehirler(string[] sehirler)
        {
            int ı = 1;
            Console.WriteLine(sehirler.Length);
            foreach(var sehir in sehirler)
            {
                Console.WriteLine(ı+"."+sehir);
                ı++;
            }
        }

    }
}
