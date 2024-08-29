using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace_1
{
    class PersonManeger
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Peson Maneger çalıştı .....");
            Console.WriteLine("****************************");
            Console.WriteLine(person.Id);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.TcNo);

           
        }
    }
}
