using System;

namespace İnterFace_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManeger personManeger = new PersonManeger();
            //// 1- yazım şekli
            //personManeger.Add(new Customer { Id = 1, FirstName = "ali", LastName = "polat", Address="Ankara-pursaklar", TcNo = "12345" });
            ////2- yazaım şekli************************
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "hasan",
            //    LastName = "polat",
            //    Address = "pursaklar-Ankara",
            //    TcNo = "23456"
            //};

            //personManeger.Add(customer);
            ////2-*************************************

            //Student student = new Student
            //{
            //    Id = 2,
            //    TcNo="68623",
            //     FirstName="Fatma Nuray",
            //     LastName="Polat",
            //      Depertman="yazlım" 

            //};

            //personManeger.Add(customer);


            IWorker worker = new Worker();
            worker.Work();
            IWorker robot = new Robot();
            robot.Work();
            IWorker maneger = new Maneger();
            maneger.Work();

            IWorker[] eleman=new IWorker[3]
            {
                new Worker(),
                new Robot(),
                new Maneger()
            };
            Console.WriteLine(eleman.Length);

            foreach (var item in eleman)
            {
                item.Work();
            }
            Console.WriteLine("*********************************");
            IEat[] eat = new IEat[2]
            {
                new Worker(),
                new Maneger(),
                
            };
            foreach (var item in eat)
            {
                item.Eat();
            }
            Console.WriteLine("*********************************");
            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Maneger(),
            };
            foreach (var item in salaries)
            {
                item.GetSalary();
            }
        }


        //***********************************************
        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }


        class Maneger : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("maneger yemek yedi");
            }

            public void GetSalary()
            {
                Console.WriteLine("Maneger Maaş aldı");
            }

            public void Work()
            {
                Console.WriteLine("maneger çalıştı");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker yemek yedi");
            }

            public void GetSalary()
            {
                Console.WriteLine("worker maaş aldı");
            }

            public void Work()
            {
                Console.WriteLine("worker çok çalıştı");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("robot çok hızlı yorulmadan çalıştı");
            }
        }






















    }
}
