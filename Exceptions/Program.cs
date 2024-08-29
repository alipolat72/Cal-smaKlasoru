using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception1();



            //try
            //{
            //  Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);

            //}




            //aşağıdaki bir metod metoda (string name)-(int sayı) gibi parametreler gönderebiliyoruz şimdide 
            // parametre olarak bir metod göndereceğiz ama nasıl delege dediğimiz yapılarla gönderiyoruz.
            // (()=>{}) ben parametresiz bir metod göndereceğim o metodun karşılığıda 
            //               HandleException(                                 ()   =>        {    Find();     })            
            
            
            
            HandleException(()=> {

                Find();
            
            });












            //List<string> students = new List<string>{ "a", "b", "c", "d" };


            //List list = new List();

            //list.Listele(students);

            //students.Add("ee");
            //list.Listele(students);

            //students.Remove("bb");
            //list.Listele(students);

            //students.Add(5);

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find(string name )
        {
            List<string> students1 = new List<string> { "ali", "fatma", "hasan", "melike", "havva" };

            if (!students1.Contains("gulay"))
            {
                throw new RecordNotFoundException("Record Not Found !");
            }
            else
            {
                Console.WriteLine("record found ");
            }
        }

        private static void Exception1()
        {
            try
            {
                string[] students1 = new string[3] { "a", "b", "c" };

                students1[3] = "a";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine("dikkat idex hatsı dizinin eleman sayısından fazla girildi");

            }
        }
    }

    public class List
    {
        public void Listele(List<string> students)
        {
            foreach (var item in students)
            {
              Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
        }

        
    }
}
