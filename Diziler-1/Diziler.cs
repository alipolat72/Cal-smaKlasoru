using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_1
{
    public class Diziler
    {

        public void ListStudents(string[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                // burda length her bir ögrenci isminin uzunluğunu ölçer
                Console.WriteLine(student.Length);

            };
            // burda length students dizisinin eleman sayısını ölçer
            Console.WriteLine(students.Length);
             
        }






        public void ListeleSehirler(string[] sehirler)
        {
            foreach (var ı in sehirler)
            {
                Console.WriteLine(ı);
            };

        }
        public void ListeleSayılar(int[] sayılar)
        {
            foreach (var ı in sayılar)
            {
                Console.WriteLine(ı);
            };
        }

        public void ListeleUlkeler(List<string> ulkeler)
        {
            foreach(var ulke in ulkeler)
            {
                Console.WriteLine(ulke);
                Console.WriteLine(ulke.Length);
                
            }
        }


    }
}
