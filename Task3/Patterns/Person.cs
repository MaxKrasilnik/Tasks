using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //Патерн для switch работает, только если нужно сделать одну простенькую операцию и вернуть ее результат.
        public string GetAction(int action) => action switch
        {
            1 => "I'm reading!",
            2 => "I'm eating!",
            3 => "I'm programming!",
            _ => "I'm relaxing!"
        };

        //Если в switch нужно сделать несколько действий, то по прежнему используем классическую конструкцию.
        public string UseSeveralActions(int time)
        {
            switch (time)
            {
                case 6:
                    Console.WriteLine("I wake up");
                    Console.WriteLine("And do many actions");
                    return "I go to work";
                case 12:
                    Console.WriteLine("I'm working");
                    Console.WriteLine("And do many actions");
                    return "I go to lanch";
                case 18:
                    Console.WriteLine("I come home");
                    Console.WriteLine("And do many actions");
                    return "I go to bed";
                default:
                    return "I've a rest";
            }
        }

        //Паттерн свойств
        public static string GetMessage(Person p) => p switch
        {
            { Surname: "Manson" } => "Hello, Manson!",
            { Surname: "Wilson", Name: "John" } => "Hallo, John!",
            { Age: 25 } => $"Salut, {p.Name}!",
            { } => "undefined"
        };

        //Паттерн свойств
        public static string GetWelcome(string lang, string daytime) => (lang, daytime) switch
        {
            ("english", "morning") => "Good morning",
            ("english", "evening") => "Good evening",
            ("german", "morning") => "Guten Morgen",
            ("german", "evening") => "Guten Abend",
            _ => "Здрасьть"
        };

        public void Deconstruct(out string name, out string surname, out int age)
        {
            name = Name;
            surname = Surname;
            age = Age;
        }

        //Позиционный паттерн
        public static string GetWelcome(Person person) => person switch
        {
            ("Tom", "Manson", _) => "Good morning",
            ("John", "Wilson", _) => "Good evening",
            (_, _, 25) => $"Hello, {person.Name}",
            _ => "Здрасьть"
        };

        //Реляционный паттерн C# 9.0
        /*static string AgePerson(int age)
        {
            return age switch
            {
                <= 12 => "Ребенок", //Если возраст больше или равно 12
                < 18 => "Подросток",//Если возраст меньше 18
                >= 18 => "Взрослый"//Если возраст больше или равно 18
            };
        }*/

        //Логический паттерн C# 9.0
        /*static string AgePerson2(int age)
        {
            return age switch
            {
                <1 or >110 => "Недействительный возраст",   // если age больше 110 и меньше 1
                >=1 and <18 => "Доступ запрещен",       // если age равно или больше 1 и меньше 18
                _ => "Доступ разрешен"                      // в остальных случаях
            };
        }*/

        //Логический паттерн C# 9.0
        /*static string AgePerson3(int age) => age switch
        {
            not 33 => "Обычный возраст",   // если age НЕ равен 33
            _ => "Вам 33 года"             // в остальных случаях, то есть если age = 33
        };*/
    }
}
