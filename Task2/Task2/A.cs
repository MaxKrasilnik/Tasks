using System;
using System.Collections.Generic;
using System.Text;

namespace ReadonlyStruct
{
    class A
    {
        public readonly B bReadonly;
        public B bUsual;
        public readonly C cReadonlyReadonly;
        public C cUsual;

        public A()
        {
            bUsual._a = 10;
            bUsual._b = 20;
            bReadonly._a = 11;
            bReadonly._b = 21;

            cUsual = new C(30, 40);
            cReadonlyReadonly = new C(31, 41);
        }



        public void InsideA()
        {
            bUsual._a = 100;
            bUsual._b = 200;
            // bReadonly._a = 110; //Error. Realonly properties is initialized when their create or in the constructor
            // bReadonly._b = 210; //Error. Realonly properties is initialized when their create or in the constructor


            cUsual = new C(300, 400);
            // cReadonlyReadonly = new C(310, 410); //Error. Realonly properties is initialized when their create or in the constructor
        }


        public void InsideAGetB(B b)
        {
            b._a = 1000;
            b._b = 2000;

            Console.WriteLine("InsideAGetB  b._a=" + b._a);
            Console.WriteLine("InsideAGetB  b._b=" + b._b);
            Console.WriteLine();
        }

        public void InsideAGetC(C c)
        {
            //c._a = 1000;//A property of readonly struct. We can't change value
            //c._b = 2000;//A property of readonly struct. We can't change value

            Console.WriteLine("InsideAGetC  c._a=" + c._a);
            Console.WriteLine("InsideAGetC  c._b=" + c._b);
            Console.WriteLine();
        }

        public void InsideAGetC(ref C c)
        {
            //c._a = 1000;//A property of readonly struct. We can't change value
            //c._b = 2000;//A property of readonly struct. We can't change value

            Console.WriteLine("InsideAGetC  c._a=" + c._a);
            Console.WriteLine("InsideAGetC  c._b=" + c._b);
            Console.WriteLine();
        }

        public void InsideAGetA(A a)
        {
            a.bUsual._a = 1000;
            a.bUsual._b = 2000;
            //a.bReadonly._a = 3000;//Readonly property of class A. We can't change value
            //a.bReadonly._b = 4000;//Readonly property of class A. We can't change value

            //a.cUsual._a = 5000;//A property of readonly struct. We can't change value
            //a.cUsual._b = 6000;//A property of readonly struct. We can't change value

            //a.cReadonlyReadonly._a = 7000;//Readonly property of class A and it's readonly struct. We can't change value
            //a.cReadonlyReadonly._b = 8000;//Readonly property of class A and it's readonly struct. We can't change value
        }
    }
}
