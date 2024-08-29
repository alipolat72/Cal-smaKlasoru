using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Maneger maneger = new Maneger();
            maneger.Departman = "muhasebe müdür";
            
            Worker worker = new Worker();
            worker.Departman = "muhasebe";

            Stajier stajier = new Stajier();
            stajier.School = "dedekorkut lisesi";
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Maneger:Person
        {
            public string Departman { get; set; }
            public string Unvanı { get; set; }
        }

        class Worker:Person
        {
            public string Departman { get; set; }
        }

        class Stajier:Person
        { 
            public string School { get; set; }
        }



    }
}
