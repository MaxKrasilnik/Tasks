
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b["name"] = "myname";
            Console.WriteLine(b["name"]);
            b["firstname"] = "firstname";
            Console.WriteLine(b["firstname"]);
            Console.WriteLine(b["name"]);

            b.AutoProperty = "Hello world";
            Console.WriteLine(b.AutoProperty);

            Console.WriteLine();
            Console.WriteLine();

            ((IA)b).MethodWithRealize();
            Console.WriteLine("IA.MYCONST="+IA.MYCONST);
            Console.WriteLine("IA.propertyStatic=" + IA.propertyStatic);
            Console.WriteLine("IA.AutoPropertyStatic=" + IA.AutoPropertyStatic);
            Console.WriteLine("IA.MethodStatic();");
            IA.MethodStatic();
        }
    }
}
