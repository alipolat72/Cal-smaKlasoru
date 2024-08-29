using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOracleMysqal
{
    public class CustomerManeger 
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();

        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();

        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();

        }

        public void DosyalaraEkle(List<ICustomerDal> customerDals)
        {
            foreach (var customer in customerDals)
            {
                CustomerManeger customerManeger = new CustomerManeger();
                customerManeger.Add(customer);
            }
        }

        //public void Add()
        //{
        //    Console.WriteLine("ekleme yapıldı");
        //}

        //public void Delete()
        //{
        //    Console.WriteLine("delete yapıldı");
        //}

        //public void Update()
        //{
        //    Console.WriteLine("update yapıldı");
        //}
    }
}
