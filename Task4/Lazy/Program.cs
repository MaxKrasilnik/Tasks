using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Lazy
{
    class Program
    {
        class Room
        {
            public Lazy<Student> student = new Lazy<Student>();
            public void ShowStudent()
            {
                Console.WriteLine($"{student.Value.Name} {student.Value.Surname}");
            }

            public void ShowStudentEmpty()
            {
                Console.WriteLine("Nobody is here");
            }
        }

        class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }

            public Student()
            {
                Name = "Ivan";
                Surname = "Ivanov";
            }
        }

        static void Main(string[] args)
        {
            Room room = new Room();
            room.ShowStudentEmpty();
            Console.WriteLine();
            room.ShowStudent();
            Console.WriteLine();
            Console.WriteLine();

            Span<int> span = new int[] { 1, 2, 3, 4, 5 };
            Span<int> span1 = span;
            span[0] += 20;
            foreach(var i in span)
                Console.Write(i+" ");
            Console.WriteLine();
            foreach (var i in span1)
                Console.Write(i + " ");
            Console.WriteLine();


            Console.WriteLine($"span == span1 {span == span1}");
            Span<int> span2 = span.Slice(2);
            foreach (var i in span2)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine($"span == span2 {span == span2}");
        }
    }
}
