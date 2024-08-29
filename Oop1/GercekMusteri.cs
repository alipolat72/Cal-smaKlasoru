using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    // Individual  --- gerçek müşteri -- bu claslar özellik tutar- varlık- entity-burda operasyon olmaz
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }

        public string Adı { get; set; }

        public string soyadı { get; set; }

       
    }
}
