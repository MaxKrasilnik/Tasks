using System;
using System.Collections.Generic;
using System.Text;

namespace ReadonlyStruct
{
    class D
    {
        public void InsideDGetB(B b)
        {
            b._a = 1000;
            b._b = 2000;

            Console.WriteLine("InsideAGetB  b._a=" + b._a);
            Console.WriteLine("InsideAGetB  b._b=" + b._b);
            Console.WriteLine();
        }

        public void InsideDGetC(C c)
        {
            //c._a = 1000;//A property of readonly struct. We can't change value
            //c._b = 2000;//A property of readonly struct. We can't change value

            Console.WriteLine("InsideAGetC  c._a=" + c._a);
            Console.WriteLine("InsideAGetC  c._b=" + c._b);
            Console.WriteLine();
        }

        public void InsideDGetC(ref C c)
        {
            //c._a = 1000;//A property of readonly struct. We can't change value
            //c._b = 2000;//A property of readonly struct. We can't change value

            Console.WriteLine("InsideAGetC  c._a=" + c._a);
            Console.WriteLine("InsideAGetC  c._b=" + c._b);
            Console.WriteLine();
        }
    }
}
