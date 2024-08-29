using System;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface den önceki kullanım clas olusturduk daha sonre o clası kullanmak bir için öreneğini olşturuyoruz.
            //CustomerManeger customerManeger = new CustomerManeger();
            //customerManeger.Add();
            //customerManeger.Update();

            //ProductManeger productManeger = new ProductManeger();
            //productManeger.Add();
            //productManeger.Update();


            //interfaceden sonra ki kullanım
            IManegerService customer = new CustomerManeger();
            customer.Add();
            IManegerService product = new ProductManeger();
            product.Update();



            Customer customer1 = new Customer
             { Id = 1, FirstName = "ali", TcNo = "123"};// burda set bloğu çalışıyor

            Console.WriteLine(customer1.FirstName);//burda get bloğu çalışıyor



        }
    }
}
