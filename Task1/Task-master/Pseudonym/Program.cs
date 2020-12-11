using System;

using Person = Pseudonym.User;
namespace Pseudonym
{
    class Program//https://metanit.com/sharp/tutorial/3.25.php
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Tom";
            Console.WriteLine(person.name);

            User user = new User();
            user.name = "Jinny";
            Console.WriteLine(user.name);
        }
    }

    struct User
    {
        public string name;
    }
}