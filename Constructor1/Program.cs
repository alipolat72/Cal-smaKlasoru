using System;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManeger customerManeger = new CustomerManeger(20);

            //customerManeger.Add();

            //customerManeger.Listed();

            //Product product = new Product  ( 1,"ali" );

            //EmployeeManeger employeeManeger = new EmployeeManeger(new DatabaseLogger());

            //employeeManeger.Add();


            PersonManeger personManeger = new PersonManeger("person");
            personManeger.Add();

        }
        
    }
    class CustomerManeger
    {
        int _count;  int _unitPrice;


        public CustomerManeger(int count)
        {
            _count = count;
            
        }
        public CustomerManeger()
        {

        }
        
        public void Add()
        {
            Console.WriteLine("added..! {0}  items " ,_count);
        }

        public void Listed()
        {
            Console.WriteLine("listed..!");
        }
    }

    class Product
    {
        public Product()
        {
            Console.WriteLine("product boş contructor çalıştı");
        }

        int _id;
        string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
            Console.WriteLine("product contructor çalıştı");
            Console.WriteLine(_id + " / " + _name);

        }



        public int id { get; set; }
        public string  ProductName { get; set; }


    }


    interface ILogger
    {
        void log();
    }


    class DatabaseLogger : ILogger
    {
         public void log()
        {
            Console.WriteLine("Database logged");
        }
    }
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("File logged");
        }
    }

    class EmployeeManeger
    {
        ILogger _logger;
        public EmployeeManeger(ILogger logger)
        {
            _logger = logger;
        }
        
        
        public void Add()
        {

            _logger.log();
            
            Console.WriteLine("Added..!");
        }
    }
    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} mesaj", _entity);
        }
    }
    
    class PersonManeger:BaseClass
    {
        public PersonManeger(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Eklendi");
            Message();
        }
    }
}
