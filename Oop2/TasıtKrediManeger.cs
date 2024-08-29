using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class TasıtKrediManeger : IKrediManeger
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void Listele()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı Listelendi");
        }
    }
}
