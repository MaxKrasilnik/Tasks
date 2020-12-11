using System;

namespace Patterns
{
    class Program//Паттерны switch: https://metanit.com/sharp/tutorial/3.45.php
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom", "Manson", 25);
            Console.WriteLine("GetAction");
            Console.WriteLine(person.GetAction(3));
            Console.WriteLine(person.GetAction(8));
            Console.WriteLine();

            Console.WriteLine("UseSeveralActions");
            Console.WriteLine(person.UseSeveralActions(6));
            Console.WriteLine(person.UseSeveralActions(22));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("GetMessage");
            Console.WriteLine(Person.GetMessage(new Person("John", "Wilson", 25)));
            Console.WriteLine(Person.GetMessage(person));
            Console.WriteLine(Person.GetMessage(new Person("Alex", "Gingam", 25)));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("GetWelcome(english, evening)");
            string message = Person.GetWelcome("english", "evening");
            Console.WriteLine(message);  // Good evening

            message = Person.GetWelcome("french", "morning");
            Console.WriteLine(message);  // Здрасьть
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("GetWelcome(Person)");
            Console.WriteLine(Person.GetWelcome(person));
            Console.WriteLine(Person.GetWelcome(new Person("John", "Wilson", 25)));
            Console.WriteLine(Person.GetWelcome(new Person("Alex", "Gingam", 25)));
        }
    }
}
