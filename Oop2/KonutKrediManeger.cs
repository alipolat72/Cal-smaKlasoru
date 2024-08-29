using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class KonutKrediManeger : IKrediManeger
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void Listele()
        {
            Console.WriteLine("konut kredisi ödeme planı Listelendi");
        }
    }
}
