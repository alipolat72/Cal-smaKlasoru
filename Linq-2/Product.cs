﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_2
{
    class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockAmount { get; set; }
    }
}