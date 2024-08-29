using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class EsnafKrediManeger : IKrediManeger
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }

        public void Listele()
        {
            Console.WriteLine("esnaf kredi hesaplaması listelendi");
        }
    }
}
