using System;

namespace Classes
{
    class ProductManeger  :IManegerService
    {
        public void Add()
        {
            Console.WriteLine("product-ürün bilgileri dosyaya eklendi");
        }

        public void List()
        {
            Console.WriteLine("product-ürün bilgileri listed-listelendi");
        }

        public void Update()
        {
            Console.WriteLine("product-ürün bilgileri güncellendi");
        }
    }
}
