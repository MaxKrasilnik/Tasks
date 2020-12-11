using Microsoft.VisualBasic;
using System;

namespace ReadonlyStruct
{
    class Program//https://habr.com/ru/company/microsoft/blog/423053/
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("a.InsideAGetB(a.bUsual);");
            Console.WriteLine("a.bUsual._a=" + a.bUsual._a);
            Console.WriteLine("a.bUsual._b=" + a.bUsual._b);
            Console.WriteLine();
            a.InsideAGetB(a.bUsual);

            Console.WriteLine("After method");
            Console.WriteLine("a.bUsual._a=" + a.bUsual._a);
            Console.WriteLine("a.bUsual._b=" + a.bUsual._b);
            Console.WriteLine();

            Console.WriteLine("a.InsideAGetB(a.bReadonly);");
            Console.WriteLine("a.bReadonly._a=" + a.bReadonly._a);
            Console.WriteLine("a.bReadonly._b=" + a.bReadonly._b);
            Console.WriteLine();
            a.InsideAGetB(a.bReadonly);

            Console.WriteLine("After method");
            Console.WriteLine("a.bReadonly._a=" + a.bReadonly._a);
            Console.WriteLine("a.bReadonly._b=" + a.bReadonly._b);
            Console.WriteLine();

            Console.WriteLine("a.InsideAGetC(a.cUsual);");
            Console.WriteLine("a.cUsual._a=" + a.cUsual._a);
            Console.WriteLine("a.cUsual._b=" + a.cUsual._b);
            Console.WriteLine();
            a.InsideAGetC(a.cUsual);
            Console.WriteLine("A property of readonly struct. We can't change value");

            Console.WriteLine();

            Console.WriteLine("a.InsideAGetC(a.cReadonlyReadonly);");
            Console.WriteLine("a.cReadonlyReadonly._a=" + a.cReadonlyReadonly._a);
            Console.WriteLine("a.cReadonlyReadonly._b=" + a.cReadonlyReadonly._b);
            Console.WriteLine();
            a.InsideAGetC(a.cReadonlyReadonly);
            Console.WriteLine("A property of readonly struct. We can't change value");



            D d = new D();

            d.InsideDGetC(new C(40, 50));
        }
    }
}
