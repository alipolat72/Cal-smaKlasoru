using System;
using System.Collections.Generic;

namespace İnterfaceOracleMysqal
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManeger customerManeger = new CustomerManeger();

            customerManeger.Add(new SqlServer());

            //Console.WriteLine(Message.ProductAdded);
            
            
            
            
            
            
            //customerManeger.Add(new OracleServer());
            //customerManeger.Delete(new SqlServer());
            //customerManeger.Update(new OracleServer());

            //List<ICustomerDal> customerDals = new List<ICustomerDal>() { new OracleServer(), new SqlServer()};

            //customerDals.Add(new MySqelServer());
            //customerManeger.DosyalaraEkle(customerDals);
            
            //foreach (var customer in customerDals)
            //{
            //       customerManeger.Add(customer);
            //}
             
        }
    }
}
