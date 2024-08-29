using System;
using System.Reflection;

namespace Reflection_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName = "Ali";

            string LastName = "Polat";

            int Age = 20;

            bool isOnline = true;


            // GetType();

            //1-
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(isOnline);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("yukardaki field lerin tiplerin. yazalım");

            Console.WriteLine("FirsnName in tipini al ==>FirstName.GetType()...==>" + FirstName.GetType());
            Console.WriteLine(LastName.GetType());
            Console.WriteLine(Age.GetType());
            Console.WriteLine(isOnline.GetType());



            Console.ReadLine();
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //DortIslem dortIslem = new DortIslem(5,5);

            //Console.WriteLine( dortIslem.Topla1(5, 7));
            //Console.WriteLine(dortIslem.Carp1(5, 7));

            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Carp2());

            //var type = typeof(DortIslem);


            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 5, 6);


            //Console.WriteLine(dortIslem.Topla1(7 , 7));
            //Console.WriteLine(dortIslem.Topla2());

            //var instance = Activator.CreateInstance(type, 5, 6);

            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            //Console.WriteLine(methodInfo.Invoke(instance, null));

            //Console.ReadLine();

            




        }
    }

    class DortIslem
    {
        int _sayı1;
        int _sayı2;
        public DortIslem(int sayı1,int sayı2)
        {
            _sayı1 = sayı1;
            _sayı2 = sayı2;

        }
        public int Topla1(int sayı1,int sayı2)
        {

            return sayı1 + sayı2;
        }

        public int Carp1(int sayı1,int sayı2)
        {
            return sayı1 * sayı2;
        }
        
        //***********************************
        
        public int Topla2()
        {

            return _sayı1 + _sayı2;
        }

        public int Carp2()
        {
            return _sayı1 * _sayı2;
        }

    }

}
