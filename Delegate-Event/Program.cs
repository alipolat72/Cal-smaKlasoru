using System;

namespace Delegate_Event
{
    class Program
    {
        delegate void DenemeDelegate();

        static event DenemeDelegate DenemeEvent;
        static void Main(string[] args)
        {
            CustomerManeger customerManeger = new CustomerManeger();
            DenemeDelegate denemeDelegate = customerManeger.CustomerAdd;
            //denemeDelegate();

            //DenemeDelegate denemeDelegate1 = Deneme;
            //denemeDelegate1();
            DenemeEvent += Deneme;
            DenemeEvent();
            DenemeEvent += customerManeger.CustomerAdd;
            DenemeEvent();

            denemeDelegate += Deneme;
            denemeDelegate();
        }

        

        static void Deneme()
        {
            Console.WriteLine("deneme metodu çalıştı");
        }
    }
    public class CustomerManeger
    {
        

        public CustomerManeger()
        {

        }
        public void CustomerAdd()
        {
            Console.WriteLine("customer Added ");
        }
        public void CustomerDelete()
        {
            Console.WriteLine("customer Delete ");
        }
        public void CustomerUpdate()
        {
            Console.WriteLine("customer Update");
        }
    }
    public class ProductManeger
    {


        public ProductManeger()
        {
            
        }
        public void ProductAdd()
        {
            Console.WriteLine("product Added ");
        }
        public void ProductDelete()
        {
            Console.WriteLine("product Delete ");
        }
        public void ProductUpdate()
        {
            Console.WriteLine("product Update");
        }
    }
}
