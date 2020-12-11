using System;

namespace СorrectСonstructorСalls
{
    class BaseClass
    {
        public int Id { get; set; }

        static BaseClass()
        {
            Console.WriteLine("static constructor A");
        }

        public BaseClass()
        {
            Console.WriteLine("default constructor A");
        }

        public BaseClass(int id)
        {
            Id = id;
            Console.WriteLine("overloaded constructor A");
        }
    }

    class Person : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        static Person()
        {
            Console.WriteLine("static constructor B");
        }

        public Person()
        {
            Console.WriteLine("default constructor B");
        }

        public Person(int id, string name, string surname) : base(id)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("overloaded constructor B");
        }
    }

    
  

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine();
            Console.WriteLine();

            Person p1 = new Person(1, "Ivan", "Ivanov");
        }
    }
}
