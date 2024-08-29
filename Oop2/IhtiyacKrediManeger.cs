using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class IhtiyacKrediManeger : IKrediManeger
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void Listele()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı Listelendi");
        }
    }
}
