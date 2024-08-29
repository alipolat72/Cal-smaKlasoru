using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer=(new Customer {Id=1,FirstName="ali",Age=52 });  
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]//AllowMultiple = true olduğunda iki kere yazabiliriz
    //[RequiredProperty] burda kullanmak istersek( [AttributeUsage(AttributeTargets.Class)])
    class Customer
    {
        public int Id { get; set; }
        //[RequiredProperty] burda kullanmak istersek( [AttributeUsage(AttributeTargets.All)])
        [RequiredProperty]
        public string  FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]//AllowMultiple = true olursa iki kere yazabiliriz
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Bu Add metodunu kullanma yenisini AddNew metodunu kullan")]
        public void Add(Customer c)
        {
            Console.WriteLine("{0},{1},{2},{3} added", c.Id, c.FirstName, c.LastName, c.Age);
        }
        //bu metodun aşağıda yenisini yazdık artık Add1 in kullanımsını istiyorsak [Obsolote]hazır attribütünü kullanırız 
        public void AddNew(Customer c)
        {
            Console.WriteLine("{0},{1},{2},{3} added", c.Id, c.FirstName, c.LastName, c.Age);
        }
    }

    //[AttributeUsage(AttributeTargets.All)]
   // [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    [AttributeUsage(AttributeTargets.Property ,AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }
}
