using KininTech.SqlMapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Delegates
{
    class Program
    {
        //void döndüren ve parametre almayan operasyonlara delegelik yapıyor deriz
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int sayı1, int sayı2);
        static void Main(string[] args)
        {
            //MyDelegete();
            //MyDelegete2();
            //FuncRandomNumber();

            var tip = typeof(CustomerManeger);

            var metodlar = tip.GetMethods();
            foreach (var item in metodlar)
            {
                Console.WriteLine(item.Name);
                foreach (var parametreitem in item.GetParameters())
                {
                    Console.WriteLine(parametreitem.Name);
                }

                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine(attribute.GetType().Name);
                }
            }





            Console.ReadLine();
        }


        private static void MyDelegete2()
        {
            CustomerManeger customerManeger = new CustomerManeger();
            MyDelegate2 myDelegate2 = customerManeger.SendMessage2;
            myDelegate2("hellooo");
            myDelegate2 += customerManeger.ShowAlert2;
            myDelegate2("be careful");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.topla;
            myDelegate3 += matematik.carp;
            var result = myDelegate3(2, 3);
            Console.WriteLine(result);
        }

        private static void MyDelegete()
        {
            CustomerManeger customerManeger = new CustomerManeger();

            customerManeger.SendMessage();
            customerManeger.ShowAlert();

            MyDelegate myDelegate = customerManeger.SendMessage;
            myDelegate();
            Console.WriteLine("------------------");
            myDelegate += customerManeger.ShowAlert;
            myDelegate();
            Console.WriteLine("------------------");

            Console.WriteLine("------------------");
            myDelegate -= customerManeger.SendMessage;
            myDelegate -= customerManeger.ShowAlert;
        }

        private static void FuncRandomNumber()
        {
            // Func nedir nasıl çalışır ?
            // ilk iki int göderilen parametreler sonuncu da geridöndürülen değer
            //Func<int, int, int> add = Topla;
            //Console.WriteLine( add(10, 15));

            //tek int varsa demekki func geriye bişey döndürüyor parametresiz metodlara delege yapıyor ama geri int döndürüyor

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);



            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());
        }

        static int Topla(int sayı1,int sayı2)
        {
            //Console.WriteLine(sayı1 + sayı2);
            return sayı1 + sayı2;
        }


        

    }
   
    public class CustomerManeger
    {
        public void SendMessage()
        {
            Console.WriteLine("helllo !");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Dikkatli ol !");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }
    public class Matematik
    {
        public int topla(int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        public int carp(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
    }
     

}
