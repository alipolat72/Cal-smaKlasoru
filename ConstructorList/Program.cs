using System;
using System.Collections.Generic;

namespace ConstructorList
{
    class Program
    {
        static void Main(string[] args)
        {
            // alttaki iki tanımlamada aynı () olsada olur olmasada
            //Customer customer1 = new Customer() {Id=1,FisrtName="ali",Age=50 };
            Customer customer1 = new Customer{ Id = 1, FisrtName = "veli", Age = 50 };
            Customer customer2 = new Customer(1, "ali", 50);
            
            //Customer customer3 = new Customer();
            //customer3.Id = 1;
            //customer3.FisrtName = "ayşe";
            //customer3.Age = 1;
           
            
            Console.WriteLine("firstname :"+customer2.FisrtName);
             
           
            //Liste(2, "veli", 25);
            
        }
        static void Liste(int id,string name,int age)
        {
             
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
      
    }
    class Customer
    {
        public Customer(int id, string name, int age)
        {
            Id = id;
            FisrtName = name;
            Age = age;

            Console.WriteLine(" dolu yapıcı blok constructor çalıştı");
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(age);

        }
        public Customer()
        {
            Console.WriteLine("boş olan constructor çalıştı");
        }
        public int Id { get; set; }

        public string FisrtName { get; set; }

        public int Age { get; set; }
    }
}
