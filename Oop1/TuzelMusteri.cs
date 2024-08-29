using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    // coorporate - tüzel müşteri
    // miras inheritance
    class TuzelMusteri:Musteri
    {
       

        public string SirketAdı { get; set; }

        public int VergiNo { get; set; }
    }
}
