using System;

namespace Questions_3_4_5
{
    //Частичные методы: https://metanit.com/sharp/tutorial/3.21.php
    //Анонимные типы: https://metanit.com/sharp/tutorial/3.20.php
    //Локальные функции: https://metanit.com/sharp/tutorial/2.20.php

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.DoSomething();
            Console.WriteLine();

            tom.Name = "Tom";
            int age = 26;
            var student = new { tom.Name, age };
            Console.WriteLine($"student.Name = {student.Name}");
            Console.WriteLine($"student.age = {student.age}");
            Console.WriteLine();

            tom.Show();
        }
    }
}
