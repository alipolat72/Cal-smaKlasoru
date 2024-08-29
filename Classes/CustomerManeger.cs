using System;

namespace Classes
{
    class CustomerManeger :IManegerService
    {
        public void Add()
        {
            Console.WriteLine("customer müşteri dosyaya eklendi");
        }

        public void List()
        {
            Console.WriteLine("customer müşteri bilgileri listelendi");
        }

        public void Update()
        {
            Console.WriteLine("customer müşteri bilgileri güncellendi");
        }
    }
}
