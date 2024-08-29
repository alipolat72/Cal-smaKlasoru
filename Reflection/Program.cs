using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dortislem dortislem = new Dortislem(2,5);

            //Console.WriteLine( dortislem.Topla(4, 7));
            //Console.WriteLine( dortislem.Topla2());


            var tip = typeof(Dortislem);

            //Console.WriteLine(" var tip = typeof(Dortislem); " + tip);
            // çalışma anında Activator.CreateIntance ile Instance üretiyoruz
            // bu reflection ın  entemel konularından biridir 
            //Dortislem dortislem = (Dortislem)Activator.CreateInstance(tip,7,7);

            //Console.WriteLine(" Dortislem dortislem = (Dortislem)Activator.CreateInstance(tip); "
           //                   + dortislem);

            //*****************************************************************************************

            //var instance = Activator.CreateInstance(tip,5,5);

            //Console.WriteLine(instance.GetType().Name);
            //Console.WriteLine(instance.GetType().FullName);

            //******************************************************************************************

            var instance = Activator.CreateInstance(tip, 5, 5);
            //Console.WriteLine( instance.GetType().GetMethod("Topla2").Invoke(instance,null));

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance,null));


            //*********************************************************************************************
            // reflection bir nesnemize ait özelliklere liste şeklinde ulaşabilmemizi sağlar.
            // mesala bu sınıfın metodlarına ulaşmak veya bu sınıfın özelliklerine ulaşmak
            // vaya sınıfın Attribute lerine ulaşmak

            //yukarıda GetMethod() la 1 metoda ulaştık ama GetMethods la tüm metodlara ulaşabiliriz

            // invoke = çağırmak
            // info =bilgi
            var methods = tip.GetMethods();
            //var methods = instance.GetType().GetMethods();
            foreach (var info in methods)
            {
                //Console.WriteLine("Metod Adı {0}",method);
                Console.WriteLine("Metod Adı {0}", info.Name);
                 
                foreach (var parametre in info.GetParameters())
                {
                    Console.WriteLine("parametre :{0}",parametre.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("AttributeName :{0}", attribute.GetType().Name);
                }
                 
            }





        }
    }
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
    }
    public class Dortislem
    {
        private int _sayı1;
        private int _sayı2;
        public Dortislem(int sayı1,int sayı2)
        {
            _sayı1 = sayı1;
            _sayı2 = sayı2;
        }
        public Dortislem( )
        {
             
        }

        public int Topla(int sayı1,int sayı2)
        {
            var result = sayı1 + sayı2;
            return result;
        }

        public int Carp(int sayı1, int sayı2)
        {
            var result = sayı1 * sayı2;
            return result;
        }

        public int Topla2()
        {
            return _sayı1 + _sayı2;
        }
        [MetodNameAttributte("çarpma işlemi")]
        public int Carp2()
        {
            return _sayı1 * _sayı2;
        }

    }
    public class MetodNameAttributte : Attribute
    {
        public MetodNameAttributte(string name)
        {
            Console.WriteLine("attribute girdi");
        }
    } 
}
