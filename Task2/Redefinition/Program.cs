using System;

namespace Redefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.WriteLine("C c = new C();");
            c.Show();
            c.Display();
            Console.WriteLine();

            A a = new C();
            Console.WriteLine("A a = new C();");
            a.Show();
            Console.WriteLine();

            A a1 = new B();
            Console.WriteLine("A a1 = new B();");
            a1.Show();
            Console.WriteLine();

            B b = new B();
            Console.WriteLine("b.Screen();");
            b.Screen();
            Console.WriteLine("c.Screen();");
            c.Screen();
            Console.WriteLine();

            Console.WriteLine("c.ScreenNew();");
            c.ScreenNew();
            Console.WriteLine();

            A a3 = new B();
            Console.WriteLine("a3.ScreenNew();");
            a3.ScreenNew();


        }
    }
}
