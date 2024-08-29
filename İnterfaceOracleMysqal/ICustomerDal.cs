using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOracleMysqal
{
    public interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();

    }
   



    //class CustomerManeger 
    //{
    //    public void Add(ICustomerDal customerDal)
    //    {
    //        customerDal.Add();
             
    //    }
    //    public void Delete(ICustomerDal customerDal)
    //    {
    //        customerDal.Delete();

    //    }
    //    public void Update(ICustomerDal customerDal)
    //    {
    //        customerDal.Update();

    //    }

    //    public void DosyalaraEkle(List<ICustomerDal> customerDals)
    //    {
    //        foreach (var customer in customerDals)
    //        {
    //            CustomerManeger customerManeger = new CustomerManeger();
    //            customerManeger.Add(customer);
    //        }
    //    }
    //}

    //class SqlServer : ICustomerDal
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("sql added");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("sql deleted");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("sql Updated");
    //    }
    //}
    //class OracleServer : ICustomerDal
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Oracle added");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("Oracle Deleted");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Oracle Updated");
    //    }
    //}
    //class MySqelServer : ICustomerDal
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("MySqel added");
    //    }

    //    public void Delete()
    //    {
    //        Console.WriteLine("MySqel Deleted");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("MySqel Updated");
    //    }
    //}
}
